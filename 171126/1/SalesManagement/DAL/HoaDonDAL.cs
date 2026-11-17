using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using SalesManagement.DTO;

namespace SalesManagement.DAL
{
    public class HoaDonDAL
    {
        public int ExecuteOrderTransaction(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> details)
        {
            if (details == null || details.Count == 0)
            {
                throw new ArgumentException("Giỏ hàng không có sản phẩm.");
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlInsertHD = @"
                            INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) 
                            VALUES (@NgayLap, @MaNV, @MaKH, @TongTien);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int newMaHD;
                        using (var cmdHD = new SqlCommand(sqlInsertHD, conn, trans))
                        {
                            cmdHD.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = hoaDon.NgayLap;
                            cmdHD.Parameters.Add("@MaNV", SqlDbType.Int).Value = hoaDon.MaNV;
                            cmdHD.Parameters.Add("@MaKH", SqlDbType.Int).Value = hoaDon.MaKH.HasValue ? hoaDon.MaKH.Value : DBNull.Value;
                            cmdHD.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = hoaDon.TongTien;
                            newMaHD = (int)cmdHD.ExecuteScalar()!;
                        }

                        foreach (var item in details)
                        {
                            string sqlCheckStock = "SELECT SoLuongTon, TenSP FROM SanPham WITH (UPDLOCK) WHERE MaSP = @MaSP";
                            int currentStock = 0;
                            string tenSP = item.TenSP;

                            using (var cmdStock = new SqlCommand(sqlCheckStock, conn, trans))
                            {
                                cmdStock.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = item.MaSP;
                                using (var reader = cmdStock.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        currentStock = reader.GetInt32(0);
                                        tenSP = reader.GetString(1);
                                    }
                                    else
                                    {
                                        throw new InvalidOperationException($"Sản phẩm mã '{item.MaSP}' không tồn tại trong hệ thống!");
                                    }
                                }
                            }

                            if (currentStock < item.SoLuong)
                            {
                                throw new InvalidOperationException(
                                    $"Sản phẩm '{tenSP}' (Mã: {item.MaSP}) không đủ hàng trong kho. " +
                                    $"Tồn kho hiện tại: {currentStock}, yêu cầu mua: {item.SoLuong}. " +
                                    $"Giao dịch bị HỦY (Rollback) hoàn toàn!");
                            }

                            string sqlUpdateStock = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";
                            using (var cmdUpdateStock = new SqlCommand(sqlUpdateStock, conn, trans))
                            {
                                cmdUpdateStock.Parameters.Add("@SoLuong", SqlDbType.Int).Value = item.SoLuong;
                                cmdUpdateStock.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = item.MaSP;
                                cmdUpdateStock.ExecuteNonQuery();
                            }

                            string sqlInsertCT = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                            using (var cmdCT = new SqlCommand(sqlInsertCT, conn, trans))
                            {
                                cmdCT.Parameters.Add("@MaHD", SqlDbType.Int).Value = newMaHD;
                                cmdCT.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = item.MaSP;
                                cmdCT.Parameters.Add("@SoLuong", SqlDbType.Int).Value = item.SoLuong;
                                cmdCT.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = item.DonGia;
                                cmdCT.ExecuteNonQuery();
                            }
                        }

                        if (hoaDon.MaKH.HasValue && hoaDon.TongTien >= 100000)
                        {
                            int diemCong = (int)(hoaDon.TongTien / 100000m);
                            if (diemCong > 0)
                            {
                                string sqlUpdateDiem = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @DiemCong WHERE MaKH = @MaKH";
                                using (var cmdDiem = new SqlCommand(sqlUpdateDiem, conn, trans))
                                {
                                    cmdDiem.Parameters.Add("@DiemCong", SqlDbType.Int).Value = diemCong;
                                    cmdDiem.Parameters.Add("@MaKH", SqlDbType.Int).Value = hoaDon.MaKH.Value;
                                    cmdDiem.ExecuteNonQuery();
                                }
                            }
                        }

                        trans.Commit();
                        return newMaHD;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public decimal GetDoanhThuTheoNgay(DateTime date)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CONVERT(date, NgayLap) = CONVERT(date, @Ngay)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = date.Date;
                    object result = cmd.ExecuteScalar()!;
                    return Convert.ToDecimal(result);
                }
            }
        }

        public decimal GetDoanhThuTheoThang(int month, int year)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE MONTH(NgayLap) = @Month AND YEAR(NgayLap) = @Year";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                    object result = cmd.ExecuteScalar()!;
                    return Convert.ToDecimal(result);
                }
            }
        }

        public List<TopSanPhamDTO> GetTop5SanPham()
        {
            var list = new List<TopSanPhamDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT TOP 5 
                        sp.MaSP, 
                        sp.TenSP, 
                        SUM(ct.SoLuong) AS TongSoLuongBan, 
                        SUM(ct.SoLuong * ct.DonGia) AS TongDoanhThu
                    FROM ChiTietHoaDon ct
                    INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                    GROUP BY sp.MaSP, sp.TenSP
                    ORDER BY TongSoLuongBan DESC";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TopSanPhamDTO
                        {
                            MaSP = reader.GetString(0),
                            TenSP = reader.GetString(1),
                            TongSoLuongBan = reader.GetInt32(2),
                            TongDoanhThu = reader.GetDecimal(3)
                        });
                    }
                }
            }
            return list;
        }

        public List<HoaDonDTO> GetAllHoaDon()
        {
            var list = new List<HoaDonDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaHD, NgayLap, MaNV, MaKH, TongTien FROM HoaDon ORDER BY MaHD DESC";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonDTO
                        {
                            MaHD = reader.GetInt32(0),
                            NgayLap = reader.GetDateTime(1),
                            MaNV = reader.GetInt32(2),
                            MaKH = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                            TongTien = reader.GetDecimal(4)
                        });
                    }
                }
            }
            return list;
        }
    }
}


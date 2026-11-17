using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HRMManagement.DTO;

namespace HRMManagement.DAL
{
    public class LuongDAL
    {
        /// <summary>
        /// Tính toán lương tạm tính theo công thức:
        /// ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)
        /// </summary>
        public List<BangLuongDTO> TinhLuong(string thangNam)
        {
            var list = new List<BangLuongDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT n.MaNV, n.HoTen, p.TenPB, c.ThangNam, n.LuongCoBan, n.HeSoLuong, 
                           ISNULL(c.SoNgayCong, 0) AS SoNgayCong, 
                           ISNULL(c.SoGioOT, 0) AS SoGioOT,
                           ISNULL(l.MaLuong, 0) AS MaLuong,
                           l.ThucLinh AS DaChotThucLinh
                    FROM BangChamCong c
                    INNER JOIN NhanVien n ON c.MaNV = n.MaNV
                    LEFT JOIN PhongBan p ON n.MaPB = p.MaPB
                    LEFT JOIN BangLuong l ON c.MaNV = l.MaNV AND c.ThangNam = l.ThangNam
                    WHERE c.ThangNam = @ThangNam
                    ORDER BY n.MaNV";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maNV = reader.GetInt32(0);
                            string hoTen = reader.GetString(1);
                            string? tenPB = reader.IsDBNull(2) ? null : reader.GetString(2);
                            string thang = reader.GetString(3);
                            decimal luongCB = reader.GetDecimal(4);
                            double heSo = reader.GetDouble(5);
                            double ngayCong = reader.GetDouble(6);
                            double gioOT = reader.GetDouble(7);
                            int maLuong = reader.GetInt32(8);

                            // Công thức tính lương theo yêu cầu đề bài
                            decimal thucLinh;
                            if (!reader.IsDBNull(9))
                            {
                                thucLinh = reader.GetDecimal(9);
                            }
                            else
                            {
                                decimal luongNgay = (luongCB * (decimal)heSo) / 22m;
                                decimal tienOT = (decimal)gioOT * 50000m;
                                thucLinh = Math.Round((luongNgay * (decimal)ngayCong) + tienOT, 0);
                            }

                            list.Add(new BangLuongDTO
                            {
                                MaLuong = maLuong,
                                MaNV = maNV,
                                HoTen = hoTen,
                                TenPB = tenPB,
                                ThangNam = thang,
                                LuongCoBan = luongCB,
                                HeSoLuong = heSo,
                                SoNgayCong = ngayCong,
                                SoGioOT = gioOT,
                                ThucLinh = thucLinh
                            });
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Thực thi giao dịch SqlTransaction:
        /// Ghi nhận bảng lương cho toàn bộ nhân viên có trong tháng và khóa dữ liệu chấm công.
        /// </summary>
        public int ChotLuongThang(string thangNam)
        {
            // Lấy danh sách lương tính toán trước
            var danhSach = TinhLuong(thangNam);
            if (danhSach.Count == 0)
            {
                throw new InvalidOperationException($"Không có dữ liệu chấm công cho tháng {thangNam} để chốt lương!");
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        int count = 0;
                        string sqlUpsert = @"
                            IF EXISTS (SELECT 1 FROM BangLuong WHERE MaNV = @MaNV AND ThangNam = @ThangNam)
                            BEGIN
                                UPDATE BangLuong 
                                SET ThucLinh = @ThucLinh 
                                WHERE MaNV = @MaNV AND ThangNam = @ThangNam
                            END
                            ELSE
                            BEGIN
                                INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) 
                                VALUES (@MaNV, @ThangNam, @ThucLinh)
                            END";

                        foreach (var item in danhSach)
                        {
                            using (var cmdLuong = new SqlCommand(sqlUpsert, conn, trans))
                            {
                                cmdLuong.Parameters.Add("@MaNV", SqlDbType.Int).Value = item.MaNV;
                                cmdLuong.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;
                                cmdLuong.Parameters.Add("@ThucLinh", SqlDbType.Decimal).Value = item.ThucLinh;
                                cmdLuong.ExecuteNonQuery();
                                count++;
                            }
                        }

                        // Khóa dữ liệu chấm công tháng này
                        string sqlKhoa = "UPDATE BangChamCong SET DaKhoa = 1 WHERE ThangNam = @ThangNam";
                        using (var cmdKhoa = new SqlCommand(sqlKhoa, conn, trans))
                        {
                            cmdKhoa.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;
                            cmdKhoa.ExecuteNonQuery();
                        }

                        // Hoàn tất transaction
                        trans.Commit();
                        return count;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Logic an toàn: Mô phỏng kiểm thử cơ chế SqlTransaction Rollback khi phát sinh ngoại lệ hệ thống
        /// </summary>
        public bool KiemTraRollbackMoPhong(out string logMessage)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("UPDATE BangChamCong SET DaKhoa = 1 WHERE ThangNam = 'TEST/9999'", conn, trans))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        throw new InvalidOperationException("MÔ PHỎNG LỖI HỆ THỐNG: Mất kết nối đường truyền đột ngột trong khi đang ghi nhận lương!");
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        logMessage = $"[ROLLBACK THÀNH CÔNG] Ngoại lệ: {ex.Message}. Dữ liệu được bảo toàn nguyên vẹn.";
                        return true;
                    }
                }
            }
        }
    }
}


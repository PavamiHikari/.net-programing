using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HRMManagement.DTO;

namespace HRMManagement.DAL
{
    public class NhanVienDAL
    {
        public List<NhanVienDTO> GetAll()
        {
            var list = new List<NhanVienDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT n.MaNV, n.HoTen, n.NgaySinh, n.CCCD, n.MaPB, p.TenPB, n.LuongCoBan, n.HeSoLuong
                    FROM NhanVien n
                    LEFT JOIN PhongBan p ON n.MaPB = p.MaPB
                    ORDER BY n.MaNV";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienDTO
                        {
                            MaNV = reader.GetInt32(0),
                            HoTen = reader.GetString(1),
                            NgaySinh = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                            CCCD = reader.GetString(3),
                            MaPB = reader.GetInt32(4),
                            TenPB = reader.IsDBNull(5) ? null : reader.GetString(5),
                            LuongCoBan = reader.GetDecimal(6),
                            HeSoLuong = reader.GetDouble(7)
                        });
                    }
                }
            }
            return list;
        }

        public List<NhanVienDTO> Search(string keyword, int? maPB)
        {
            var list = new List<NhanVienDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT n.MaNV, n.HoTen, n.NgaySinh, n.CCCD, n.MaPB, p.TenPB, n.LuongCoBan, n.HeSoLuong
                    FROM NhanVien n
                    LEFT JOIN PhongBan p ON n.MaPB = p.MaPB
                    WHERE (@kw = '' OR n.HoTen LIKE @kwLike OR n.CCCD LIKE @kwLike)
                      AND (@maPB IS NULL OR n.MaPB = @maPB)
                    ORDER BY n.MaNV";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = keyword ?? "";
                    cmd.Parameters.Add("@kwLike", SqlDbType.NVarChar, 105).Value = "%" + (keyword ?? "") + "%";
                    cmd.Parameters.Add("@maPB", SqlDbType.Int).Value = (object?)maPB ?? DBNull.Value;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhanVienDTO
                            {
                                MaNV = reader.GetInt32(0),
                                HoTen = reader.GetString(1),
                                NgaySinh = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                                CCCD = reader.GetString(3),
                                MaPB = reader.GetInt32(4),
                                TenPB = reader.IsDBNull(5) ? null : reader.GetString(5),
                                LuongCoBan = reader.GetDecimal(6),
                                HeSoLuong = reader.GetDouble(7)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong)
                    VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = nv.HoTen;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                    cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = nv.CCCD;
                    cmd.Parameters.Add("@MaPB", SqlDbType.Int).Value = nv.MaPB;
                    cmd.Parameters.Add("@LuongCoBan", SqlDbType.Decimal).Value = nv.LuongCoBan;
                    cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = nv.HeSoLuong;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE NhanVien
                    SET HoTen = @HoTen,
                        NgaySinh = @NgaySinh,
                        CCCD = @CCCD,
                        MaPB = @MaPB,
                        LuongCoBan = @LuongCoBan,
                        HeSoLuong = @HeSoLuong
                    WHERE MaNV = @MaNV";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = nv.HoTen;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                    cmd.Parameters.Add("@CCCD", SqlDbType.VarChar, 20).Value = nv.CCCD;
                    cmd.Parameters.Add("@MaPB", SqlDbType.Int).Value = nv.MaPB;
                    cmd.Parameters.Add("@LuongCoBan", SqlDbType.Decimal).Value = nv.LuongCoBan;
                    cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = nv.HeSoLuong;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ChuyenPhongBan(int maNV, int maPBMoi)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE NhanVien SET MaPB = @MaPB WHERE MaNV = @MaNV";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
                    cmd.Parameters.Add("@MaPB", SqlDbType.Int).Value = maPBMoi;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int maNV)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}


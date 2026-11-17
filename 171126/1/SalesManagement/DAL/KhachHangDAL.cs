using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using SalesManagement.DTO;

namespace SalesManagement.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetAll()
        {
            var list = new List<KhachHangDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang ORDER BY MaKH";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHangDTO
                        {
                            MaKH = reader.GetInt32(0),
                            TenKH = reader.GetString(1),
                            DienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DiemTichLuy = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(KhachHangDTO kh)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES (@TenKH, @DienThoai, @DiemTichLuy)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = kh.TenKH;
                    cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = (object?)kh.DienThoai ?? DBNull.Value;
                    cmd.Parameters.Add("@DiemTichLuy", SqlDbType.Int).Value = kh.DiemTichLuy;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiemTichLuy = @DiemTichLuy WHERE MaKH = @MaKH";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = kh.MaKH;
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = kh.TenKH;
                    cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = (object?)kh.DienThoai ?? DBNull.Value;
                    cmd.Parameters.Add("@DiemTichLuy", SqlDbType.Int).Value = kh.DiemTichLuy;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int maKH)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}


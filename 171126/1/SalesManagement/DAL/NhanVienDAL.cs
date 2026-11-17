using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using SalesManagement.DTO;

namespace SalesManagement.DAL
{
    public class NhanVienDAL
    {
        public List<NhanVienDTO> GetAll()
        {
            var list = new List<NhanVienDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaNV, TenNV, SoDienThoai, ChucVu FROM NhanVien ORDER BY MaNV";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienDTO
                        {
                            MaNV = reader.GetInt32(0),
                            TenNV = reader.GetString(1),
                            SoDienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            ChucVu = reader.IsDBNull(3) ? null : reader.GetString(3)
                        });
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
                string sql = "INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES (@TenNV, @SoDienThoai, @ChucVu)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 100).Value = nv.TenNV;
                    cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 15).Value = (object?)nv.SoDienThoai ?? DBNull.Value;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50).Value = (object?)nv.ChucVu ?? DBNull.Value;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE NhanVien SET TenNV = @TenNV, SoDienThoai = @SoDienThoai, ChucVu = @ChucVu WHERE MaNV = @MaNV";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 100).Value = nv.TenNV;
                    cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 15).Value = (object?)nv.SoDienThoai ?? DBNull.Value;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50).Value = (object?)nv.ChucVu ?? DBNull.Value;
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


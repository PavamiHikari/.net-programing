using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using SalesManagement.DTO;

namespace SalesManagement.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            var list = new List<SanPhamDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham ORDER BY MaSP";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPhamDTO
                        {
                            MaSP = reader.GetString(0),
                            TenSP = reader.GetString(1),
                            GiaBan = reader.GetDecimal(2),
                            SoLuongTon = reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }

        public List<SanPhamDTO> Search(string keyword)
        {
            var list = new List<SanPhamDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Sử dụng SqlParameter có ký tự đại diện % để phòng chống 100% SQL Injection
                string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham WHERE MaSP LIKE @kw OR TenSP LIKE @kw ORDER BY MaSP";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 150).Value = "%" + (keyword ?? "") + "%";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SanPhamDTO
                            {
                                MaSP = reader.GetString(0),
                                TenSP = reader.GetString(1),
                                GiaBan = reader.GetDecimal(2),
                                SoLuongTon = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public SanPhamDTO? GetById(string maSP)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = maSP;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SanPhamDTO
                            {
                                MaSP = reader.GetString(0),
                                TenSP = reader.GetString(1),
                                GiaBan = reader.GetDecimal(2),
                                SoLuongTon = reader.GetInt32(3)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool Insert(SanPhamDTO sp)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongTon)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = sp.MaSP;
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 150).Value = sp.TenSP;
                    cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = sp.GiaBan;
                    cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sp.SoLuongTon;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(SanPhamDTO sp)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE SanPham SET TenSP = @TenSP, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaSP = @MaSP";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = sp.MaSP;
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 150).Value = sp.TenSP;
                    cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = sp.GiaBan;
                    cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sp.SoLuongTon;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(string maSP)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = maSP;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}


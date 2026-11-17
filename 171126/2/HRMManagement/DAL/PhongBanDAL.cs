using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HRMManagement.DTO;

namespace HRMManagement.DAL
{
    public class PhongBanDAL
    {
        public List<PhongBanDTO> GetAll()
        {
            var list = new List<PhongBanDTO>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaPB, TenPB, Mota FROM PhongBan ORDER BY MaPB";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PhongBanDTO
                        {
                            MaPB = reader.GetInt32(0),
                            TenPB = reader.GetString(1),
                            Mota = reader.IsDBNull(2) ? null : reader.GetString(2)
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(PhongBanDTO pb)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO PhongBan (TenPB, Mota) VALUES (@TenPB, @Mota)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar, 100).Value = pb.TenPB;
                    cmd.Parameters.Add("@Mota", SqlDbType.NVarChar, 255).Value = (object?)pb.Mota ?? DBNull.Value;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}


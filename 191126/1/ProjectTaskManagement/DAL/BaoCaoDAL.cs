using Microsoft.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL;

public class BaoCaoDAL
{
    public List<BaoCaoDTO> GetMemberCompletionStats(int? maDuAn)
    {
        List<BaoCaoDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();

        string sql = @"SELECT 
                        tv.HoTen, 
                        tv.ChuyenMon,
                        COUNT(c.MaTask) AS TongTask,
                        SUM(CASE WHEN c.TrangThai = 'Done' THEN 1 ELSE 0 END) AS TaskDone
                       FROM ThanhVien tv
                       LEFT JOIN PhanCong p ON tv.MaThanhVien = p.MaThanhVien
                       LEFT JOIN CongViec c ON p.MaTask = c.MaTask";

        if (maDuAn.HasValue && maDuAn.Value > 0)
        {
            sql += " AND c.MaDuAn = @MaDuAn";
        }

        sql += @" GROUP BY tv.MaThanhVien, tv.HoTen, tv.ChuyenMon
                 ORDER BY tv.HoTen";

        using SqlCommand cmd = new(sql, conn);
        if (maDuAn.HasValue && maDuAn.Value > 0)
        {
            cmd.Parameters.AddWithValue("@MaDuAn", maDuAn.Value);
        }

        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            string hoTen = reader.GetString(0);
            string chuyenMon = reader.IsDBNull(1) ? "" : reader.GetString(1);
            int tongTask = reader.GetInt32(2);
            int taskDone = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
            double tyLe = tongTask > 0 ? Math.Round((double)taskDone * 100 / tongTask, 1) : 0;

            list.Add(new BaoCaoDTO
            {
                HoTen = hoTen,
                ChuyenMon = chuyenMon,
                TongSoTask = tongTask,
                SoTaskHoanThanh = taskDone,
                TyLeHoanThanh = tyLe
            });
        }

        return list;
    }
}


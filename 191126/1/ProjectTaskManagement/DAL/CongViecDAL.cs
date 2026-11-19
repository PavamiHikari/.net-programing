using System.Data;
using Microsoft.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL;

public class CongViecDAL
{
    public List<CongViecDTO> GetTasks(int? maDuAn, string? trangThai)
    {
        List<CongViecDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();

        string sql = @"SELECT c.MaTask, c.MaDuAn, d.TenDuAn, c.TenTask, c.MoTa, c.HanNop, c.DoUuTien, c.TrangThai
                       FROM CongViec c
                       INNER JOIN DuAn d ON c.MaDuAn = d.MaDuAn
                       WHERE (1=1)";

        if (maDuAn.HasValue && maDuAn.Value > 0)
        {
            sql += " AND c.MaDuAn = @MaDuAn";
        }
        if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
        {
            sql += " AND c.TrangThai = @TrangThai";
        }
        sql += " ORDER BY c.HanNop ASC";

        using SqlCommand cmd = new(sql, conn);
        if (maDuAn.HasValue && maDuAn.Value > 0)
        {
            cmd.Parameters.AddWithValue("@MaDuAn", maDuAn.Value);
        }
        if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
        {
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);
        }

        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new CongViecDTO
            {
                MaTask = reader.GetInt32(0),
                MaDuAn = reader.GetInt32(1),
                TenDuAn = reader.GetString(2),
                TenTask = reader.GetString(3),
                MoTa = reader.IsDBNull(4) ? "" : reader.GetString(4),
                HanNop = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                DoUuTien = reader.IsDBNull(6) ? "" : reader.GetString(6),
                TrangThai = reader.IsDBNull(7) ? "" : reader.GetString(7)
            });
        }
        return list;
    }

    public bool Insert(CongViecDTO task)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
                                    VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai)", conn);
        cmd.Parameters.AddWithValue("@MaDuAn", task.MaDuAn);
        cmd.Parameters.AddWithValue("@TenTask", task.TenTask);
        cmd.Parameters.AddWithValue("@MoTa", task.MoTa);
        cmd.Parameters.AddWithValue("@HanNop", task.HanNop);
        cmd.Parameters.AddWithValue("@DoUuTien", task.DoUuTien);
        cmd.Parameters.AddWithValue("@TrangThai", task.TrangThai);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool UpdateStatus(int maTask, string trangThaiMoi)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask", conn);
        cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
        cmd.Parameters.AddWithValue("@MaTask", maTask);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool Delete(int maTask)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("DELETE FROM CongViec WHERE MaTask = @MaTask", conn);
        cmd.Parameters.AddWithValue("@MaTask", maTask);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public List<CongViecDTO> GetOverdueTasks()
    {
        List<CongViecDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT c.MaTask, c.MaDuAn, d.TenDuAn, c.TenTask, c.MoTa, c.HanNop, c.DoUuTien, c.TrangThai
                                    FROM CongViec c
                                    INNER JOIN DuAn d ON c.MaDuAn = d.MaDuAn
                                    WHERE c.HanNop < GETDATE() AND c.TrangThai != 'Done'
                                    ORDER BY c.HanNop ASC", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new CongViecDTO
            {
                MaTask = reader.GetInt32(0),
                MaDuAn = reader.GetInt32(1),
                TenDuAn = reader.GetString(2),
                TenTask = reader.GetString(3),
                MoTa = reader.IsDBNull(4) ? "" : reader.GetString(4),
                HanNop = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                DoUuTien = reader.IsDBNull(6) ? "" : reader.GetString(6),
                TrangThai = reader.IsDBNull(7) ? "" : reader.GetString(7)
            });
        }
        return list;
    }
}


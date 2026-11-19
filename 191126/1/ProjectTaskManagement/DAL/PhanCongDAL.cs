using Microsoft.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL;

public class PhanCongDAL
{
    public List<PhanCongDTO> GetAssignmentsByTask(int maTask)
    {
        List<PhanCongDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT p.MaTask, c.TenTask, p.MaThanhVien, tv.HoTen, p.NgayGiao
                                    FROM PhanCong p
                                    INNER JOIN CongViec c ON p.MaTask = c.MaTask
                                    INNER JOIN ThanhVien tv ON p.MaThanhVien = tv.MaThanhVien
                                    WHERE p.MaTask = @MaTask", conn);
        cmd.Parameters.AddWithValue("@MaTask", maTask);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PhanCongDTO
            {
                MaTask = reader.GetInt32(0),
                TenTask = reader.GetString(1),
                MaThanhVien = reader.GetInt32(2),
                HoTen = reader.GetString(3),
                NgayGiao = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
            });
        }
        return list;
    }

    public bool AssignTask(int maTask, int maThanhVien)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"IF NOT EXISTS (SELECT 1 FROM PhanCong WHERE MaTask = @MaTask AND MaThanhVien = @MaThanhVien)
                                    BEGIN
                                        INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao)
                                        VALUES (@MaTask, @MaThanhVien, GETDATE())
                                    END", conn);
        cmd.Parameters.AddWithValue("@MaTask", maTask);
        cmd.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool RemoveAssignment(int maTask, int maThanhVien)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("DELETE FROM PhanCong WHERE MaTask = @MaTask AND MaThanhVien = @MaThanhVien", conn);
        cmd.Parameters.AddWithValue("@MaTask", maTask);
        cmd.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}


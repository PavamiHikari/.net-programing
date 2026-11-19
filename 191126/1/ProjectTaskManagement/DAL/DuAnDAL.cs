using System.Data;
using Microsoft.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL;

public class DuAnDAL
{
    public List<DuAnDTO> GetAll()
    {
        List<DuAnDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("SELECT MaDuAn, TenDuAn, NgayBatDau, NgayKetThuc, TrangThai FROM DuAn ORDER BY MaDuAn DESC", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DuAnDTO
            {
                MaDuAn = reader.GetInt32(0),
                TenDuAn = reader.GetString(1),
                NgayBatDau = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                NgayKetThuc = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                TrangThai = reader.IsDBNull(4) ? "" : reader.GetString(4)
            });
        }
        return list;
    }

    public bool Insert(DuAnDTO duAn)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai)
                                    VALUES (@TenDuAn, @NgayBatDau, @NgayKetThuc, @TrangThai)", conn);
        cmd.Parameters.AddWithValue("@TenDuAn", duAn.TenDuAn);
        cmd.Parameters.AddWithValue("@NgayBatDau", duAn.NgayBatDau);
        cmd.Parameters.AddWithValue("@NgayKetThuc", duAn.NgayKetThuc);
        cmd.Parameters.AddWithValue("@TrangThai", duAn.TrangThai);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool Update(DuAnDTO duAn)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"UPDATE DuAn
                                    SET TenDuAn = @TenDuAn, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, TrangThai = @TrangThai
                                    WHERE MaDuAn = @MaDuAn", conn);
        cmd.Parameters.AddWithValue("@MaDuAn", duAn.MaDuAn);
        cmd.Parameters.AddWithValue("@TenDuAn", duAn.TenDuAn);
        cmd.Parameters.AddWithValue("@NgayBatDau", duAn.NgayBatDau);
        cmd.Parameters.AddWithValue("@NgayKetThuc", duAn.NgayKetThuc);
        cmd.Parameters.AddWithValue("@TrangThai", duAn.TrangThai);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool Delete(int maDuAn)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("DELETE FROM DuAn WHERE MaDuAn = @MaDuAn", conn);
        cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}


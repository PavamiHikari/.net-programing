using Microsoft.Data.SqlClient;
using KaraokeManagement.DTO;

namespace KaraokeManagement.DAL;

public class PhongHatDAL
{
    public List<PhongHatDTO> GetAll()
    {
        List<PhongHatDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("SELECT MaPhong, TenPhong, LoaiPhong, GiaTheoGio, TrangThai FROM PhongHat ORDER BY MaPhong", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PhongHatDTO
            {
                MaPhong = reader.GetInt32(0),
                TenPhong = reader.GetString(1),
                LoaiPhong = reader.IsDBNull(2) ? "" : reader.GetString(2),
                GiaTheoGio = reader.GetDecimal(3),
                TrangThai = reader.GetString(4)
            });
        }
        return list;
    }

    public bool UpdateStatus(int maPhong, string trangThai)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("UPDATE PhongHat SET TrangThai = @TrangThai WHERE MaPhong = @MaPhong", conn);
        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}


using Microsoft.Data.SqlClient;
using KaraokeManagement.DTO;

namespace KaraokeManagement.DAL;

public class DichVuDAL
{
    public List<DichVuDTO> GetAll()
    {
        List<DichVuDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("SELECT MaDV, TenDV, DonGia, TonKho FROM DichVu ORDER BY TenDV", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DichVuDTO
            {
                MaDV = reader.GetInt32(0),
                TenDV = reader.GetString(1),
                DonGia = reader.GetDecimal(2),
                TonKho = reader.GetInt32(3)
            });
        }
        return list;
    }
}


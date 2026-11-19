using Microsoft.Data.SqlClient;
using GarageManagement.DTO;

namespace GarageManagement.DAL;

public class PhuTungDAL
{
    public List<PhuTungDTO> GetAll()
    {
        List<PhuTungDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new("SELECT MaPhuTung, TenPhuTung, DonGia, SoLuongTon FROM PhuTung ORDER BY TenPhuTung", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PhuTungDTO
            {
                MaPhuTung = reader.GetInt32(0),
                TenPhuTung = reader.GetString(1),
                DonGia = reader.GetDecimal(2),
                SoLuongTon = reader.GetInt32(3)
            });
        }
        return list;
    }

    public bool UpdateInventoryAndPrice(int maPhuTung, decimal donGia, int soLuongTon)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"UPDATE PhuTung
                                    SET DonGia = @DonGia, SoLuongTon = @SoLuongTon
                                    WHERE MaPhuTung = @MaPhuTung", conn);
        cmd.Parameters.AddWithValue("@DonGia", donGia);
        cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
        cmd.Parameters.AddWithValue("@MaPhuTung", maPhuTung);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool Insert(PhuTungDTO pt)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon)
                                    VALUES (@TenPhuTung, @DonGia, @SoLuongTon)", conn);
        cmd.Parameters.AddWithValue("@TenPhuTung", pt.TenPhuTung);
        cmd.Parameters.AddWithValue("@DonGia", pt.DonGia);
        cmd.Parameters.AddWithValue("@SoLuongTon", pt.SoLuongTon);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}


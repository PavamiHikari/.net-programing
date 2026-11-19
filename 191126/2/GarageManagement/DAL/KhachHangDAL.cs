using Microsoft.Data.SqlClient;
using GarageManagement.DTO;

namespace GarageManagement.DAL;

public class KhachHangDAL
{
    public int Insert(KhachHangDTO kh)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"INSERT INTO KhachHang (TenKH, DienThoai, DiaChi)
                                    VALUES (@TenKH, @DienThoai, @DiaChi);
                                    SELECT SCOPE_IDENTITY();", conn);
        cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
        cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
        cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
        conn.Open();
        object result = cmd.ExecuteScalar();
        return Convert.ToInt32(result);
    }
}


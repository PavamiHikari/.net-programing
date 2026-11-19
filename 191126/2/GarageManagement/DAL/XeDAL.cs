using Microsoft.Data.SqlClient;
using GarageManagement.DTO;

namespace GarageManagement.DAL;

public class XeDAL
{
    public XeDTO? FindByBienSo(string bienSo)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT x.BienSo, x.MaKH, kh.TenKH, kh.DienThoai, x.HieuXe, x.NamSanXuat
                                    FROM Xe x
                                    INNER JOIN KhachHang kh ON x.MaKH = kh.MaKH
                                    WHERE x.BienSo = @BienSo", conn);
        cmd.Parameters.AddWithValue("@BienSo", bienSo);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new XeDTO
            {
                BienSo = reader.GetString(0),
                MaKH = reader.GetInt32(1),
                TenKH = reader.GetString(2),
                DienThoai = reader.IsDBNull(3) ? "" : reader.GetString(3),
                HieuXe = reader.IsDBNull(4) ? "" : reader.GetString(4),
                NamSanXuat = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
            };
        }
        return null;
    }

    public bool Insert(XeDTO xe)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat)
                                    VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)", conn);
        cmd.Parameters.AddWithValue("@BienSo", xe.BienSo);
        cmd.Parameters.AddWithValue("@MaKH", xe.MaKH);
        cmd.Parameters.AddWithValue("@HieuXe", xe.HieuXe);
        cmd.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public List<XeDTO> GetAll()
    {
        List<XeDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT x.BienSo, x.MaKH, kh.TenKH, kh.DienThoai, x.HieuXe, x.NamSanXuat
                                    FROM Xe x
                                    INNER JOIN KhachHang kh ON x.MaKH = kh.MaKH
                                    ORDER BY x.BienSo", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new XeDTO
            {
                BienSo = reader.GetString(0),
                MaKH = reader.GetInt32(1),
                TenKH = reader.GetString(2),
                DienThoai = reader.IsDBNull(3) ? "" : reader.GetString(3),
                HieuXe = reader.IsDBNull(4) ? "" : reader.GetString(4),
                NamSanXuat = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
            });
        }
        return list;
    }
}


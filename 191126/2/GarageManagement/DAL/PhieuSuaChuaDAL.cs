using Microsoft.Data.SqlClient;
using GarageManagement.DTO;

namespace GarageManagement.DAL;

public class PhieuSuaChuaDAL
{
    public List<PhieuSuaChuaDTO> GetAll()
    {
        List<PhieuSuaChuaDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT p.MaPhieu, p.BienSo, kh.TenKH, p.NgayNhan, p.NoiDungSua, p.TongTien, p.TrangThai
                                    FROM PhieuSuaChua p
                                    INNER JOIN Xe x ON p.BienSo = x.BienSo
                                    INNER JOIN KhachHang kh ON x.MaKH = kh.MaKH
                                    ORDER BY p.MaPhieu DESC", conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PhieuSuaChuaDTO
            {
                MaPhieu = reader.GetInt32(0),
                BienSo = reader.GetString(1),
                TenKH = reader.GetString(2),
                NgayNhan = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                NoiDungSua = reader.IsDBNull(4) ? "" : reader.GetString(4),
                TongTien = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                TrangThai = reader.IsDBNull(6) ? "" : reader.GetString(6)
            });
        }
        return list;
    }

    public List<ChiTietSuaChuaDTO> GetDetails(int maPhieu)
    {
        List<ChiTietSuaChuaDTO> list = [];
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT ct.MaPhieu, ct.MaPhuTung, pt.TenPhuTung, ct.SoLuong, pt.DonGia, ct.TienCong
                                    FROM ChiTietSuaChua ct
                                    INNER JOIN PhuTung pt ON ct.MaPhuTung = pt.MaPhuTung
                                    WHERE ct.MaPhieu = @MaPhieu", conn);
        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new ChiTietSuaChuaDTO
            {
                MaPhieu = reader.GetInt32(0),
                MaPhuTung = reader.GetInt32(1),
                TenPhuTung = reader.GetString(2),
                SoLuong = reader.GetInt32(3),
                DonGia = reader.GetDecimal(4),
                TienCong = reader.GetDecimal(5)
            });
        }
        return list;
    }

    public (bool Success, string Message, int MaPhieu) CreateRepairTicketWithTransaction(
        PhieuSuaChuaDTO phieu,
        List<ChiTietSuaChuaDTO> chiTietList)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        conn.Open();
        using SqlTransaction trans = conn.BeginTransaction();

        try
        {
            foreach (var item in chiTietList)
            {
                using SqlCommand cmdCheck = new(
                    "SELECT SoLuongTon, TenPhuTung FROM PhuTung WHERE MaPhuTung = @MaPhuTung",
                    conn, trans);
                cmdCheck.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);

                using SqlDataReader rdr = cmdCheck.ExecuteReader();
                if (!rdr.Read())
                {
                    rdr.Close();
                    trans.Rollback();
                    return (false, $"Phụ tùng mã {item.MaPhuTung} không tồn tại.", 0);
                }

                int ton = rdr.GetInt32(0);
                string tenPt = rdr.GetString(1);
                rdr.Close();

                if (ton < item.SoLuong)
                {
                    trans.Rollback();
                    return (false, $"Phụ tùng \"{tenPt}\" không đủ tồn kho (Còn lại: {ton}, yêu cầu: {item.SoLuong}).", 0);
                }
            }

            decimal tongTien = 0;
            foreach (var item in chiTietList)
            {
                tongTien += (item.SoLuong * item.DonGia) + item.TienCong;
            }

            using SqlCommand cmdPhieu = new(@"
                INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai)
                VALUES (@BienSo, @NgayNhan, @NoiDungSua, @TongTien, @TrangThai);
                SELECT SCOPE_IDENTITY();", conn, trans);
            cmdPhieu.Parameters.AddWithValue("@BienSo", phieu.BienSo);
            cmdPhieu.Parameters.AddWithValue("@NgayNhan", phieu.NgayNhan);
            cmdPhieu.Parameters.AddWithValue("@NoiDungSua", phieu.NoiDungSua);
            cmdPhieu.Parameters.AddWithValue("@TongTien", tongTien);
            cmdPhieu.Parameters.AddWithValue("@TrangThai", "Đang sửa");

            int maPhieuMoi = Convert.ToInt32(cmdPhieu.ExecuteScalar());

            foreach (var item in chiTietList)
            {
                using SqlCommand cmdChiTiet = new(@"
                    INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong)
                    VALUES (@MaPhieu, @MaPhuTung, @SoLuong, @TienCong)", conn, trans);
                cmdChiTiet.Parameters.AddWithValue("@MaPhieu", maPhieuMoi);
                cmdChiTiet.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);
                cmdChiTiet.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                cmdChiTiet.Parameters.AddWithValue("@TienCong", item.TienCong);
                cmdChiTiet.ExecuteNonQuery();

                using SqlCommand cmdTruTon = new(@"
                    UPDATE PhuTung
                    SET SoLuongTon = SoLuongTon - @SoLuong
                    WHERE MaPhuTung = @MaPhuTung", conn, trans);
                cmdTruTon.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                cmdTruTon.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);
                cmdTruTon.ExecuteNonQuery();
            }

            trans.Commit();
            return (true, "Lập phiếu sửa chữa thành công.", maPhieuMoi);
        }
        catch (Exception ex)
        {
            try
            {
                trans.Rollback();
            }
            catch { }
            return (false, "Lỗi Transaction: " + ex.Message, 0);
        }
    }

    public bool ThanhToan(int maPhieu)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"UPDATE PhieuSuaChua
                                    SET TrangThai = N'Đã thanh toán'
                                    WHERE MaPhieu = @MaPhieu", conn);
        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}


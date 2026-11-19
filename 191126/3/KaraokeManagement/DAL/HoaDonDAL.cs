using System.Data;
using Microsoft.Data.SqlClient;
using KaraokeManagement.DTO;

namespace KaraokeManagement.DAL;

public class HoaDonDAL
{
    public HoaDonDTO? GetActiveInvoiceByRoom(int maPhong)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT hd.MaHD, hd.MaPhong, p.TenPhong, hd.GioVao, hd.GioRa, hd.TongTienPhong, hd.TongTienDichVu, hd.TrangThai
                                    FROM HoaDon hd
                                    INNER JOIN PhongHat p ON hd.MaPhong = p.MaPhong
                                    WHERE hd.MaPhong = @MaPhong AND hd.TrangThai = 0", conn);
        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new HoaDonDTO
            {
                MaHD = reader.GetInt32(0),
                MaPhong = reader.GetInt32(1),
                TenPhong = reader.GetString(2),
                GioVao = reader.GetDateTime(3),
                GioRa = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                TongTienPhong = reader.GetDecimal(5),
                TongTienDichVu = reader.GetDecimal(6),
                TrangThai = reader.GetBoolean(7)
            };
        }
        return null;
    }

    public int MoPhong(int maPhong)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        conn.Open();
        using SqlTransaction trans = conn.BeginTransaction();
        try
        {
            using SqlCommand cmdHD = new(@"INSERT INTO HoaDon (MaPhong, GioVao, TongTienPhong, TongTienDichVu, TrangThai)
                                          VALUES (@MaPhong, GETDATE(), 0, 0, 0);
                                          SELECT SCOPE_IDENTITY();", conn, trans);
            cmdHD.Parameters.AddWithValue("@MaPhong", maPhong);
            int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

            using SqlCommand cmdPhong = new("UPDATE PhongHat SET TrangThai = N'Đang hát' WHERE MaPhong = @MaPhong", conn, trans);
            cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
            cmdPhong.ExecuteNonQuery();

            trans.Commit();
            return maHD;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    public DataTable GetServiceOrderTable(int maHD)
    {
        DataTable dt = new();
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"SELECT ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia, (ct.SoLuong * ct.DonGia) AS ThanhTien
                                    FROM ChiTietDichVu ct
                                    INNER JOIN DichVu dv ON ct.MaDV = dv.MaDV
                                    WHERE ct.MaHD = @MaHD", conn);
        cmd.Parameters.AddWithValue("@MaHD", maHD);
        using SqlDataAdapter da = new(cmd);
        da.Fill(dt);
        return dt;
    }

    public bool AddServiceToRoom(int maHD, int maDV, int soLuong, decimal donGia)
    {
        using SqlConnection conn = DatabaseHelper.GetConnection();
        using SqlCommand cmd = new(@"
            IF EXISTS (SELECT 1 FROM ChiTietDichVu WHERE MaHD = @MaHD AND MaDV = @MaDV)
            BEGIN
                UPDATE ChiTietDichVu 
                SET SoLuong = SoLuong + @SoLuong, DonGia = @DonGia
                WHERE MaHD = @MaHD AND MaDV = @MaDV
            END
            ELSE
            BEGIN
                INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia)
                VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)
            END", conn);
        cmd.Parameters.AddWithValue("@MaHD", maHD);
        cmd.Parameters.AddWithValue("@MaDV", maDV);
        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
        cmd.Parameters.AddWithValue("@DonGia", donGia);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public (bool Success, string Message, decimal TienPhong, decimal TienDV, decimal TongCong, double SoGio) ThanhToanHoaDon(
        int maHD, int maPhong, decimal giaTheoGio, DateTime gioVao)
    {
        DateTime gioRa = DateTime.Now;
        TimeSpan duration = gioRa - gioVao;
        double soGio = Math.Max(0.5, Math.Round(duration.TotalHours, 2));
        decimal tongTienPhong = Math.Round((decimal)soGio * giaTheoGio, 0);

        using SqlConnection conn = DatabaseHelper.GetConnection();
        conn.Open();
        using SqlTransaction trans = conn.BeginTransaction();

        try
        {
            decimal tongTienDV = 0;
            using SqlCommand cmdGetCT = new("SELECT MaDV, SoLuong, DonGia FROM ChiTietDichVu WHERE MaHD = @MaHD", conn, trans);
            cmdGetCT.Parameters.AddWithValue("@MaHD", maHD);

            List<(int MaDV, int SoLuong, decimal DonGia)> ctList = [];
            using (SqlDataReader rdr = cmdGetCT.ExecuteReader())
            {
                while (rdr.Read())
                {
                    ctList.Add((rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetDecimal(2)));
                }
            }

            foreach (var item in ctList)
            {
                tongTienDV += item.SoLuong * item.DonGia;

                using SqlCommand cmdTruKho = new(@"UPDATE DichVu 
                                                  SET TonKho = CASE WHEN TonKho >= @SoLuong THEN TonKho - @SoLuong ELSE 0 END
                                                  WHERE MaDV = @MaDV", conn, trans);
                cmdTruKho.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                cmdTruKho.Parameters.AddWithValue("@MaDV", item.MaDV);
                cmdTruKho.ExecuteNonQuery();
            }

            using SqlCommand cmdUpdateHD = new(@"UPDATE HoaDon
                                                SET GioRa = @GioRa,
                                                    TongTienPhong = @TongTienPhong,
                                                    TongTienDichVu = @TongTienDichVu,
                                                    TrangThai = 1
                                                WHERE MaHD = @MaHD", conn, trans);
            cmdUpdateHD.Parameters.AddWithValue("@GioRa", gioRa);
            cmdUpdateHD.Parameters.AddWithValue("@TongTienPhong", tongTienPhong);
            cmdUpdateHD.Parameters.AddWithValue("@TongTienDichVu", tongTienDV);
            cmdUpdateHD.Parameters.AddWithValue("@MaHD", maHD);
            cmdUpdateHD.ExecuteNonQuery();

            using SqlCommand cmdUpdatePhong = new("UPDATE PhongHat SET TrangThai = N'Trống' WHERE MaPhong = @MaPhong", conn, trans);
            cmdUpdatePhong.Parameters.AddWithValue("@MaPhong", maPhong);
            cmdUpdatePhong.ExecuteNonQuery();

            trans.Commit();
            return (true, "Thanh toán thành công!", tongTienPhong, tongTienDV, tongTienPhong + tongTienDV, soGio);
        }
        catch (Exception ex)
        {
            try { trans.Rollback(); } catch { }
            return (false, "Lỗi thanh toán: " + ex.Message, 0, 0, 0, 0);
        }
    }
}


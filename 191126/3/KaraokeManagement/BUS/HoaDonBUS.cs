using System.Data;
using KaraokeManagement.DAL;
using KaraokeManagement.DTO;

namespace KaraokeManagement.BUS;

public class HoaDonBUS
{
    private readonly HoaDonDAL _dal = new();

    public HoaDonDTO? GetActiveInvoiceByRoom(int maPhong) => _dal.GetActiveInvoiceByRoom(maPhong);

    public int MoPhong(int maPhong) => _dal.MoPhong(maPhong);

    public DataTable GetServiceOrderTable(int maHD) => _dal.GetServiceOrderTable(maHD);

    public bool AddServiceToRoom(int maHD, int maDV, int soLuong, decimal donGia)
    {
        if (soLuong <= 0)
        {
            throw new ArgumentException("Số lượng phải lớn hơn 0.");
        }
        return _dal.AddServiceToRoom(maHD, maDV, soLuong, donGia);
    }

    public (bool Success, string Message, decimal TienPhong, decimal TienDV, decimal TongCong, double SoGio) ThanhToanHoaDon(
        int maHD, int maPhong, decimal giaTheoGio, DateTime gioVao)
    {
        return _dal.ThanhToanHoaDon(maHD, maPhong, giaTheoGio, gioVao);
    }
}


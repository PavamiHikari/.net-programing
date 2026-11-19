using GarageManagement.DAL;
using GarageManagement.DTO;

namespace GarageManagement.BUS;

public class PhieuSuaChuaBUS
{
    private readonly PhieuSuaChuaDAL _dal = new();

    public List<PhieuSuaChuaDTO> GetAll() => _dal.GetAll();

    public List<ChiTietSuaChuaDTO> GetDetails(int maPhieu) => _dal.GetDetails(maPhieu);

    public (bool Success, string Message, int MaPhieu) CreateRepairTicket(
        PhieuSuaChuaDTO phieu,
        List<ChiTietSuaChuaDTO> chiTietList)
    {
        if (string.IsNullOrWhiteSpace(phieu.BienSo))
        {
            return (false, "Nhập hoặc chọn biển số xe!", 0);
        }
        if (chiTietList == null || chiTietList.Count == 0)
        {
            return (false, "Phiếu sửa chữa phải có ít nhất 1 phụ tùng / công việc.", 0);
        }
        return _dal.CreateRepairTicketWithTransaction(phieu, chiTietList);
    }

    public bool ThanhToan(int maPhieu) => _dal.ThanhToan(maPhieu);
}


using GarageManagement.DAL;
using GarageManagement.DTO;

namespace GarageManagement.BUS;

public class KhachHangBUS
{
    private readonly KhachHangDAL _dal = new();

    public int Insert(KhachHangDTO kh)
    {
        if (string.IsNullOrWhiteSpace(kh.TenKH))
        {
            throw new ArgumentException("Tên khách hàng không được trống.");
        }
        return _dal.Insert(kh);
    }
}


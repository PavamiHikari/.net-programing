using GarageManagement.DAL;
using GarageManagement.DTO;

namespace GarageManagement.BUS;

public class PhuTungBUS
{
    private readonly PhuTungDAL _dal = new();

    public List<PhuTungDTO> GetAll() => _dal.GetAll();

    public bool UpdateInventoryAndPrice(int maPhuTung, decimal donGia, int soLuongTon)
    {
        if (donGia < 0)
        {
            throw new ArgumentException("Đơn giá không được âm.");
        }
        if (soLuongTon < 0)
        {
            throw new ArgumentException("Số lượng tồn không được âm.");
        }
        return _dal.UpdateInventoryAndPrice(maPhuTung, donGia, soLuongTon);
    }

    public bool Insert(PhuTungDTO pt)
    {
        if (string.IsNullOrWhiteSpace(pt.TenPhuTung))
        {
            throw new ArgumentException("Tên phụ tùng không được trống.");
        }
        return _dal.Insert(pt);
    }
}


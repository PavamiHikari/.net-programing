using KaraokeManagement.DAL;
using KaraokeManagement.DTO;

namespace KaraokeManagement.BUS;

public class PhongHatBUS
{
    private readonly PhongHatDAL _dal = new();

    public List<PhongHatDTO> GetAll() => _dal.GetAll();

    public bool UpdateStatus(int maPhong, string trangThai) => _dal.UpdateStatus(maPhong, trangThai);
}


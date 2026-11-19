using KaraokeManagement.DAL;
using KaraokeManagement.DTO;

namespace KaraokeManagement.BUS;

public class DichVuBUS
{
    private readonly DichVuDAL _dal = new();

    public List<DichVuDTO> GetAll() => _dal.GetAll();
}


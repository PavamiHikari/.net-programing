using ProjectTaskManagement.DAL;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.BUS;

public class DuAnBUS
{
    private readonly DuAnDAL _dal = new();

    public List<DuAnDTO> GetAll() => _dal.GetAll();

    public bool Insert(DuAnDTO duAn)
    {
        if (string.IsNullOrWhiteSpace(duAn.TenDuAn))
        {
            throw new ArgumentException("Tên dự án không được trống.");
        }
        return _dal.Insert(duAn);
    }

    public bool Update(DuAnDTO duAn)
    {
        if (string.IsNullOrWhiteSpace(duAn.TenDuAn))
        {
            throw new ArgumentException("Tên dự án không được trống.");
        }
        return _dal.Update(duAn);
    }

    public bool Delete(int maDuAn) => _dal.Delete(maDuAn);
}


using ProjectTaskManagement.DAL;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.BUS;

public class CongViecBUS
{
    private readonly CongViecDAL _dal = new();

    public List<CongViecDTO> GetTasks(int? maDuAn, string? trangThai) => _dal.GetTasks(maDuAn, trangThai);

    public bool Insert(CongViecDTO task)
    {
        if (task.MaDuAn <= 0)
        {
            throw new ArgumentException("Chọn dự án.");
        }
        if (string.IsNullOrWhiteSpace(task.TenTask))
        {
            throw new ArgumentException("Tên công việc không được trống.");
        }
        return _dal.Insert(task);
    }

    public bool UpdateStatus(int maTask, string trangThaiMoi) => _dal.UpdateStatus(maTask, trangThaiMoi);

    public bool Delete(int maTask) => _dal.Delete(maTask);

    public List<CongViecDTO> GetOverdueTasks() => _dal.GetOverdueTasks();
}


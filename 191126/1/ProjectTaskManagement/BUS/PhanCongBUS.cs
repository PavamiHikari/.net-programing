using ProjectTaskManagement.DAL;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.BUS;

public class PhanCongBUS
{
    private readonly PhanCongDAL _dal = new();

    public List<PhanCongDTO> GetAssignmentsByTask(int maTask) => _dal.GetAssignmentsByTask(maTask);

    public bool AssignTask(int maTask, int maThanhVien) => _dal.AssignTask(maTask, maThanhVien);

    public bool RemoveAssignment(int maTask, int maThanhVien) => _dal.RemoveAssignment(maTask, maThanhVien);
}


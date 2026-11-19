using ProjectTaskManagement.DAL;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.BUS;

public class BaoCaoBUS
{
    private readonly BaoCaoDAL _dal = new();

    public List<BaoCaoDTO> GetMemberCompletionStats(int? maDuAn) => _dal.GetMemberCompletionStats(maDuAn);
}


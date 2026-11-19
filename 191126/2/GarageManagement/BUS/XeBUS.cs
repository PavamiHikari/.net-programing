using GarageManagement.DAL;
using GarageManagement.DTO;

namespace GarageManagement.BUS;

public class XeBUS
{
    private readonly XeDAL _dal = new();

    public XeDTO? FindByBienSo(string bienSo) => _dal.FindByBienSo(bienSo.Trim());

    public bool Insert(XeDTO xe)
    {
        if (string.IsNullOrWhiteSpace(xe.BienSo))
        {
            throw new ArgumentException("Biển số xe không được trống.");
        }
        return _dal.Insert(xe);
    }

    public List<XeDTO> GetAll() => _dal.GetAll();
}


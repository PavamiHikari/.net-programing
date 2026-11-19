namespace GarageManagement.DTO;

public class PhieuSuaChuaDTO
{
    public int MaPhieu { get; set; }
    public string BienSo { get; set; } = string.Empty;
    public string TenKH { get; set; } = string.Empty;
    public DateTime NgayNhan { get; set; }
    public string NoiDungSua { get; set; } = string.Empty;
    public decimal TongTien { get; set; }
    public string TrangThai { get; set; } = string.Empty;
}


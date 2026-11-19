namespace GarageManagement.DTO;

public class XeDTO
{
    public string BienSo { get; set; } = string.Empty;
    public int MaKH { get; set; }
    public string TenKH { get; set; } = string.Empty;
    public string DienThoai { get; set; } = string.Empty;
    public string HieuXe { get; set; } = string.Empty;
    public int NamSanXuat { get; set; }

    public override string ToString() => $"{BienSo} - {HieuXe}";
}


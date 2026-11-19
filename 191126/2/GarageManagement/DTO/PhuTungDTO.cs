namespace GarageManagement.DTO;

public class PhuTungDTO
{
    public int MaPhuTung { get; set; }
    public string TenPhuTung { get; set; } = string.Empty;
    public decimal DonGia { get; set; }
    public int SoLuongTon { get; set; }

    public override string ToString() => $"{TenPhuTung} (Tồn: {SoLuongTon} - Giá: {DonGia:N0} đ)";
}


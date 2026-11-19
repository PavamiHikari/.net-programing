namespace ProjectTaskManagement.DTO;

public class PhanCongDTO
{
    public int MaTask { get; set; }
    public string TenTask { get; set; } = string.Empty;
    public int MaThanhVien { get; set; }
    public string HoTen { get; set; } = string.Empty;
    public DateTime NgayGiao { get; set; }
}


namespace SalesManagement.DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; } = string.Empty;
        public string? SoDienThoai { get; set; }
        public string? ChucVu { get; set; }

        public override string ToString() => $"{MaNV} - {TenNV} ({ChucVu})";
    }
}


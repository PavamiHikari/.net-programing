using System;

namespace SalesManagement.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public int MaNV { get; set; }
        public int? MaKH { get; set; }
        public decimal TongTien { get; set; }
    }
}


using System;

namespace RepairServiceTracker;

public class RepairOrder
{
    public string MaDon { get; set; } = string.Empty;
    public string TenKhachHang { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public string LoaiThietBi { get; set; } = string.Empty;
    public string MoTaLoi { get; set; } = string.Empty;
    public DateTime NgayTiepNhan { get; set; } = DateTime.Today;
    public decimal ChiPhiDuKien { get; set; } = 0;
    public string TrangThai { get; set; } = "Mới tiếp nhận";
    public string HinhAnh { get; set; } = string.Empty;

    public RepairOrder() { }

    public RepairOrder(string maDon, string tenKhach, string sdt, string loaiTb, string moTa, DateTime ngayTiepNhan, decimal chiPhi, string trangThai, string hinhAnh = "")
    {
        MaDon = maDon;
        TenKhachHang = tenKhach;
        SoDienThoai = sdt;
        LoaiThietBi = loaiTb;
        MoTaLoi = moTa;
        NgayTiepNhan = ngayTiepNhan;
        ChiPhiDuKien = chiPhi;
        TrangThai = trangThai;
        HinhAnh = hinhAnh;
    }
}


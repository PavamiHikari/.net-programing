using System;

namespace LabEquipmentCheckout;

public class CheckoutRecord
{
    public string MaPhieu { get; set; } = string.Empty;
    public string MaSinhVien { get; set; } = string.Empty;
    public string HoTenSinhVien { get; set; } = string.Empty;
    public string ThietBi { get; set; } = string.Empty;
    public int SoLuong { get; set; } = 1;
    public DateTime NgayMuon { get; set; } = DateTime.Today;
    public DateTime HanTra { get; set; } = DateTime.Today.AddDays(7);
    public DateTime? NgayTraThucTe { get; set; }
    public string TinhTrang { get; set; } = "Đang mượn";

    public CheckoutRecord() { }

    public CheckoutRecord(string maPhieu, string maSv, string hoTen, string thietBi, int soLuong, DateTime ngayMuon, DateTime hanTra, DateTime? ngayTraThucTe = null)
    {
        MaPhieu = maPhieu;
        MaSinhVien = maSv;
        HoTenSinhVien = hoTen;
        ThietBi = thietBi;
        SoLuong = soLuong;
        NgayMuon = ngayMuon;
        HanTra = hanTra;
        NgayTraThucTe = ngayTraThucTe;
        CapNhatTinhTrang();
    }

    public void CapNhatTinhTrang()
    {
        if (NgayTraThucTe.HasValue)
        {
            TinhTrang = "Đã trả";
        }
        else if (HanTra.Date < DateTime.Today)
        {
            TinhTrang = "Quá hạn";
        }
        else
        {
            TinhTrang = "Đang mượn";
        }
    }
}


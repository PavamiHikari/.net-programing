namespace ClinicAppointmentManager;

public class Appointment
{
    public string MaLichHen { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public DateTime NgayGioHen { get; set; }
    public string BacSi { get; set; } = string.Empty;
    public string LyDoKham { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Chờ khám";

    public Appointment() { }

    public Appointment(string ma, string hoTen, string sdt, DateTime ngayGio, string bacSi, string lyDo, string trangThai)
    {
        MaLichHen = ma;
        HoTen = hoTen;
        SoDienThoai = sdt;
        NgayGioHen = ngayGio;
        BacSi = bacSi;
        LyDoKham = lyDo;
        TrangThai = trangThai;
    }
}


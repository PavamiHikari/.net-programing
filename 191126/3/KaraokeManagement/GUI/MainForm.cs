using System.Data;
using KaraokeManagement.BUS;
using KaraokeManagement.DTO;

namespace KaraokeManagement.GUI;

public partial class MainForm : Form
{
    private readonly PhongHatBUS _phongBUS = new();
    private readonly DichVuBUS _dichVuBUS = new();
    private readonly HoaDonBUS _hoaDonBUS = new();

    private PhongHatDTO? _selectedRoom;
    private HoaDonDTO? _currentInvoice;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        LoadDichVuCombo();
        LoadRoomButtons();
    }

    private void LoadDichVuCombo()
    {
        try
        {
            var dvList = _dichVuBUS.GetAll();
            cboDichVu.DataSource = null;
            cboDichVu.DataSource = dvList;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadRoomButtons()
    {
        flpPhongHat.Controls.Clear();
        try
        {
            var rooms = _phongBUS.GetAll();
            foreach (var room in rooms)
            {
                Button btn = new()
                {
                    Width = 130,
                    Height = 100,
                    Margin = new Padding(6),
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Text = $"{room.TenPhong}\n({room.LoaiPhong})\n[{room.TrangThai}]",
                    Tag = room,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat
                };

                if (room.TrangThai == "Trống")
                {
                    btn.BackColor = Color.LightGreen;
                    btn.FlatAppearance.BorderColor = Color.ForestGreen;
                }
                else
                {
                    btn.BackColor = Color.Salmon;
                    btn.FlatAppearance.BorderColor = Color.DarkRed;
                }

                btn.Click += RoomButton_Click;
                flpPhongHat.Controls.Add(btn);
            }

            if (_selectedRoom != null)
            {
                var refreshed = rooms.FirstOrDefault(r => r.MaPhong == _selectedRoom.MaPhong);
                SelectRoom(refreshed);
            }
            else if (rooms.Count > 0)
            {
                SelectRoom(rooms[0]);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RoomButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn && btn.Tag is PhongHatDTO room)
        {
            SelectRoom(room);
        }
    }

    private void SelectRoom(PhongHatDTO? room)
    {
        _selectedRoom = room;
        if (room == null)
        {
            lblTenPhong.Text = "Chưa chọn phòng";
            return;
        }

        lblTenPhong.Text = room.TenPhong;
        lblLoaiPhong.Text = $"Loại phòng: {room.LoaiPhong}";
        lblGiaGio.Text = $"Giá giờ: {room.GiaTheoGio:N0} đ/giờ";
        lblTrangThaiPhong.Text = $"Trạng thái: {room.TrangThai}";

        if (room.TrangThai == "Trống")
        {
            btnMoPhong.Enabled = true;
            btnThemDichVu.Enabled = false;
            btnThanhToan.Enabled = false;
            lblGioVao.Text = "Giờ vào: --:--";
            dgvDichVuDaGoi.DataSource = null;

            lblTienPhongTamTinh.Text = "Tiền phòng tạm tính: 0 VNĐ";
            lblTienDichVuTamTinh.Text = "Tiền dịch vụ: 0 VNĐ";
            lblTongTienDuKien.Text = "TỔNG CỘNG: 0 VNĐ";
            _currentInvoice = null;
        }
        else
        {
            btnMoPhong.Enabled = false;
            btnThemDichVu.Enabled = true;
            btnThanhToan.Enabled = true;

            try
            {
                _currentInvoice = _hoaDonBUS.GetActiveInvoiceByRoom(room.MaPhong);
                if (_currentInvoice != null)
                {
                    lblGioVao.Text = $"Giờ vào: {_currentInvoice.GioVao:HH:mm dd/MM/yyyy}";
                    LoadServiceOrderGrid(_currentInvoice.MaHD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp hóa đơn phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void LoadServiceOrderGrid(int maHD)
    {
        try
        {
            DataTable dt = _hoaDonBUS.GetServiceOrderTable(maHD);
            dgvDichVuDaGoi.DataSource = dt;

            decimal tienDV = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ThanhTien"] != DBNull.Value)
                {
                    tienDV += Convert.ToDecimal(row["ThanhTien"]);
                }
            }

            decimal tienGio = 0;
            if (_selectedRoom != null && _currentInvoice != null)
            {
                double hours = Math.Max(0.5, Math.Round((DateTime.Now - _currentInvoice.GioVao).TotalHours, 2));
                tienGio = Math.Round((decimal)hours * _selectedRoom.GiaTheoGio, 0);
                lblTienPhongTamTinh.Text = $"Tiền phòng ({hours}h): {tienGio:N0} VNĐ";
            }

            lblTienDichVuTamTinh.Text = $"Tiền dịch vụ: {tienDV:N0} VNĐ";
            lblTongTienDuKien.Text = $"TỔNG CỘNG: {(tienGio + tienDV):N0} VNĐ";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dịch vụ đã đặt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnMoPhong_Click(object? sender, EventArgs e)
    {
        if (_selectedRoom == null)
        {
            MessageBox.Show("Chọn phòng cần mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_selectedRoom.TrangThai != "Trống")
        {
            MessageBox.Show("Phòng này đang có khách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int maHD = _hoaDonBUS.MoPhong(_selectedRoom.MaPhong);
            MessageBox.Show($"Mở {_selectedRoom.TenPhong} thành công. Hóa đơn mới #{maHD}.", "Mở Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRoomButtons();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi mở phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThemDichVu_Click(object? sender, EventArgs e)
    {
        if (_selectedRoom == null || _selectedRoom.TrangThai != "Đang hát" || _currentInvoice == null)
        {
            MessageBox.Show("Chọn phòng đang hát để gọi dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cboDichVu.SelectedItem is not DichVuDTO dv)
        {
            MessageBox.Show("Chọn dịch vụ / đồ uống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int sl = (int)nudSoLuongDV.Value;
        try
        {
            if (_hoaDonBUS.AddServiceToRoom(_currentInvoice.MaHD, dv.MaDV, sl, dv.DonGia))
            {
                MessageBox.Show($"Đã thêm {sl} x {dv.TenDV} vào {_selectedRoom.TenPhong}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServiceOrderGrid(_currentInvoice.MaHD);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        if (_selectedRoom == null || _selectedRoom.TrangThai != "Đang hát" || _currentInvoice == null)
        {
            MessageBox.Show("Chọn phòng đang hát cần thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult confirm = MessageBox.Show(
            $"Xác nhận thanh toán cho {_selectedRoom.TenPhong}?",
            "Xác nhận thanh toán",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        try
        {
            var (success, msg, tienPhong, tienDV, tongCong, soGio) = _hoaDonBUS.ThanhToanHoaDon(
                _currentInvoice.MaHD,
                _selectedRoom.MaPhong,
                _selectedRoom.GiaTheoGio,
                _currentInvoice.GioVao);

            if (success)
            {
                MessageBox.Show(
                    $"=== HÓA ĐƠN ===\n" +
                    $"Phòng: {_selectedRoom.TenPhong}\n" +
                    $"Giờ vào: {_currentInvoice.GioVao:HH:mm dd/MM/yyyy}\n" +
                    $"Giờ ra: {DateTime.Now:HH:mm dd/MM/yyyy}\n" +
                    $"Thời gian hát: {soGio} giờ\n" +
                    $"------------------------------------\n" +
                    $"Tiền phòng: {tienPhong:N0} VNĐ\n" +
                    $"Tiền dịch vụ: {tienDV:N0} VNĐ\n" +
                    $"TỔNG THANH TOÁN: {tongCong:N0} VNĐ\n\n",
                    "Hóa Đơn Thanh Toán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDichVuCombo();
                LoadRoomButtons();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


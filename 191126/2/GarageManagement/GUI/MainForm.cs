using GarageManagement.BUS;
using GarageManagement.DTO;

namespace GarageManagement.GUI;

public partial class MainForm : Form
{
    private readonly KhachHangBUS _khBUS = new();
    private readonly XeBUS _xeBUS = new();
    private readonly PhuTungBUS _phuTungBUS = new();
    private readonly PhieuSuaChuaBUS _phieuBUS = new();

    private readonly List<ChiTietSuaChuaDTO> _chiTietTamList = [];

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        cboHieuXe.SelectedIndex = 0;
        LoadXeData();
        LoadPhuTungData();
        LoadPhieuData();
    }

    #region Tab 1: Tiếp nhận Xe & Quản lý Phụ tùng
    private void LoadXeData()
    {
        try
        {
            var xeList = _xeBUS.GetAll();
            cboChonXe.DataSource = null;
            cboChonXe.DataSource = xeList;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadPhuTungData()
    {
        try
        {
            var ptList = _phuTungBUS.GetAll();
            dgvPhuTung.DataSource = null;
            dgvPhuTung.DataSource = ptList;

            cboChonPhuTung.DataSource = null;
            cboChonPhuTung.DataSource = ptList;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải phụ tùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnTraCuu_Click(object? sender, EventArgs e)
    {
        string bienSo = txtTraCuuBienSo.Text.Trim();
        if (string.IsNullOrEmpty(bienSo))
        {
            MessageBox.Show("Nhập biển số xe cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            XeDTO? xe = _xeBUS.FindByBienSo(bienSo);
            if (xe != null)
            {
                txtBienSo.Text = xe.BienSo;
                txtTenKH.Text = xe.TenKH;
                txtDienThoai.Text = xe.DienThoai;
                cboHieuXe.SelectedItem = xe.HieuXe;
                nudNamSanXuat.Value = xe.NamSanXuat > 1990 ? xe.NamSanXuat : 2022;

                MessageBox.Show($"Tìm thấy xe {xe.BienSo} của chủ xe {xe.TenKH}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtBienSo.Text = bienSo;
                txtTenKH.Clear();
                txtDienThoai.Clear();
                txtDiaChi.Clear();
                MessageBox.Show($"Xe \"{bienSo}\" chưa có trong hệ thống. Nhập thông tin chủ xe và xe mới.", "Xe mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tra cứu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLuuXeMoi_Click(object? sender, EventArgs e)
    {
        string bienSo = txtBienSo.Text.Trim();
        string tenKH = txtTenKH.Text.Trim();
        string sdt = txtDienThoai.Text.Trim();
        string diaChi = txtDiaChi.Text.Trim();
        string hieuXe = cboHieuXe.SelectedItem?.ToString() ?? "Toyota";
        int namSX = (int)nudNamSanXuat.Value;

        if (string.IsNullOrEmpty(bienSo) || string.IsNullOrEmpty(tenKH))
        {
            MessageBox.Show("Nhập biển số xe và tên chủ xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (_xeBUS.FindByBienSo(bienSo) != null)
            {
                MessageBox.Show($"Xe \"{bienSo}\" đã có trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO kh = new() { TenKH = tenKH, DienThoai = sdt, DiaChi = diaChi };
            int maKH = _khBUS.Insert(kh);

            XeDTO xe = new()
            {
                BienSo = bienSo,
                MaKH = maKH,
                HieuXe = hieuXe,
                NamSanXuat = namSX
            };
            if (_xeBUS.Insert(xe))
            {
                MessageBox.Show("Lưu chủ xe và xe mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadXeData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi lưu xe mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvPhuTung_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvPhuTung.CurrentRow?.DataBoundItem is PhuTungDTO pt)
        {
            txtTenPhuTung.Text = pt.TenPhuTung;
            nudDonGia.Value = pt.DonGia >= nudDonGia.Minimum && pt.DonGia <= nudDonGia.Maximum ? pt.DonGia : 0;
            nudSoLuongTon.Value = pt.SoLuongTon >= nudSoLuongTon.Minimum && pt.SoLuongTon <= nudSoLuongTon.Maximum ? pt.SoLuongTon : 0;
        }
    }

    private void btnThemPhuTung_Click(object? sender, EventArgs e)
    {
        string ten = txtTenPhuTung.Text.Trim();
        if (string.IsNullOrEmpty(ten))
        {
            MessageBox.Show("Tên phụ tùng không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            PhuTungDTO pt = new()
            {
                TenPhuTung = ten,
                DonGia = nudDonGia.Value,
                SoLuongTon = (int)nudSoLuongTon.Value
            };
            if (_phuTungBUS.Insert(pt))
            {
                MessageBox.Show("Thêm phụ tùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhuTungData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thêm phụ tùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCapNhatPhuTung_Click(object? sender, EventArgs e)
    {
        if (dgvPhuTung.CurrentRow?.DataBoundItem is not PhuTungDTO pt)
        {
            MessageBox.Show("Chọn phụ tùng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (_phuTungBUS.UpdateInventoryAndPrice(pt.MaPhuTung, nudDonGia.Value, (int)nudSoLuongTon.Value))
            {
                MessageBox.Show("Cập nhật phụ tùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhuTungData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi cập nhật phụ tùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region Tab 2: Lập Phiếu Sửa Chữa (SqlTransaction)
    private void btnThemChiTiet_Click(object? sender, EventArgs e)
    {
        if (cboChonPhuTung.SelectedItem is not PhuTungDTO pt)
        {
            MessageBox.Show("Chọn phụ tùng cần thay thế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int sl = (int)nudSoLuongThayThe.Value;
        decimal cong = nudTienCong.Value;

        var existing = _chiTietTamList.FirstOrDefault(x => x.MaPhuTung == pt.MaPhuTung);
        if (existing != null)
        {
            existing.SoLuong += sl;
            existing.TienCong += cong;
        }
        else
        {
            _chiTietTamList.Add(new ChiTietSuaChuaDTO
            {
                MaPhuTung = pt.MaPhuTung,
                TenPhuTung = pt.TenPhuTung,
                SoLuong = sl,
                DonGia = pt.DonGia,
                TienCong = cong
            });
        }

        RefreshChiTietTam();
    }

    private void btnXoaChiTiet_Click(object? sender, EventArgs e)
    {
        if (dgvChiTietTam.CurrentRow?.DataBoundItem is ChiTietSuaChuaDTO item)
        {
            _chiTietTamList.Remove(item);
            RefreshChiTietTam();
        }
    }

    private void RefreshChiTietTam()
    {
        dgvChiTietTam.DataSource = null;
        dgvChiTietTam.DataSource = _chiTietTamList.ToList();

        decimal tongTien = _chiTietTamList.Sum(x => x.ThanhTien);
        lblTongTienDuKien.Text = $"Tổng chi phí dự kiến: {tongTien:N0} đ";
    }

    private void btnTaoPhieuSuaChua_Click(object? sender, EventArgs e)
    {
        if (cboChonXe.SelectedItem is not XeDTO xe)
        {
            MessageBox.Show("Chọn xe tiếp nhận sửa chữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_chiTietTamList.Count == 0)
        {
            MessageBox.Show("Thêm ít nhất một phụ tùng / công việc vào phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        PhieuSuaChuaDTO phieu = new()
        {
            BienSo = xe.BienSo,
            NgayNhan = dtpNgayNhan.Value,
            NoiDungSua = txtNoiDungSua.Text.Trim()
        };

        var (success, msg, maPhieu) = _phieuBUS.CreateRepairTicket(phieu, _chiTietTamList);

        if (success)
        {
            MessageBox.Show($"Lập phiếu sửa chữa #{maPhieu} thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _chiTietTamList.Clear();
            RefreshChiTietTam();
            txtNoiDungSua.Clear();
            LoadPhuTungData();
            LoadPhieuData();
        }
        else
        {
            MessageBox.Show($"Transaction Rollback: {msg}", "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region Tab 3: Thanh toán & Xuất Hóa đơn
    private void LoadPhieuData()
    {
        try
        {
            var list = _phieuBUS.GetAll();
            dgvPhieuSuaChua.DataSource = null;
            dgvPhieuSuaChua.DataSource = list;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải phiếu sửa chữa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvPhieuSuaChua_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvPhieuSuaChua.CurrentRow?.DataBoundItem is PhieuSuaChuaDTO phieu)
        {
            try
            {
                var details = _phieuBUS.GetDetails(phieu.MaPhieu);
                dgvChiTietHoaDon.DataSource = null;
                dgvChiTietHoaDon.DataSource = details;

                decimal tong = details.Sum(x => x.ThanhTien);
                lblTongThanhToan.Text = $"Tổng thanh toán: {tong:N0} VNĐ ({phieu.TrangThai})";

                btnThanhToan.Enabled = phieu.TrangThai != "Đã thanh toán";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        if (dgvPhieuSuaChua.CurrentRow?.DataBoundItem is not PhieuSuaChuaDTO phieu)
        {
            MessageBox.Show("Chọn phiếu sửa chữa cần thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (phieu.TrangThai == "Đã thanh toán")
        {
            MessageBox.Show("Phiếu này đã được thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            if (_phieuBUS.ThanhToan(phieu.MaPhieu))
            {
                MessageBox.Show($"Thanh toán hóa đơn phiếu #{phieu.MaPhieu} cho xe {phieu.BienSo} thành công.", "Xuất Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion
}


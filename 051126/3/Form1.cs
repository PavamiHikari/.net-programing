using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace RepairServiceTracker;

public partial class Form1 : Form
{
    private BindingList<RepairOrder> _allList = new();
    private BindingList<RepairOrder> _filteredList = new();
    private BindingSource _bindingSource = new();
    private ErrorProvider _errorProvider = new();
    private bool _isBindingSelection = false;
    private string _currentImagePath = string.Empty;

    public Form1()
    {
        InitializeComponent();
        SetupCustomUI();
        //LoadSampleData();
        RefreshDataAndStatus();
    }

    private void SetupCustomUI()
    {
        cboLoaiThietBi.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Máy tính bảng", "PC để bàn", "Khác" });
        cboLoaiThietBi.SelectedIndex = 0;

        cboTrangThai.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
        cboTrangThai.SelectedIndex = 0;

        cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
        cboLocTrangThai.SelectedIndex = 0;

        dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom;
        dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy";
        dtpNgayTiepNhan.Value = DateTime.Today;

        picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
        picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
        picHinhAnh.BackColor = Color.White;

        dgvOrders.AutoGenerateColumns = false;
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrders.MultiSelect = false;
        dgvOrders.ReadOnly = true;
        dgvOrders.AllowUserToAddRows = false;
        dgvOrders.BackgroundColor = Color.White;
        dgvOrders.RowHeadersVisible = false;

        dgvOrders.Columns.Clear();
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaDon", HeaderText = "Mã Đơn", Width = 85 });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenKhachHang", HeaderText = "Tên Khách Hàng", Width = 150 });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Số Điện Thoại", Width = 110 });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoaiThietBi", HeaderText = "Loại Thiết Bị", Width = 110 });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MoTaLoi", HeaderText = "Mô Tả Lỗi", Width = 170 });

        var colNgayTiepNhan = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NgayTiepNhan",
            HeaderText = "Ngày Tiếp Nhận",
            Width = 115
        };
        colNgayTiepNhan.DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvOrders.Columns.Add(colNgayTiepNhan);

        var colChiPhi = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ChiPhiDuKien",
            HeaderText = "Chi Phí Dự Kiến (VNĐ)",
            Width = 150
        };
        colChiPhi.DefaultCellStyle.Format = "N0";
        colChiPhi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgvOrders.Columns.Add(colChiPhi);

        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 110 });

        var colAnh = new DataGridViewTextBoxColumn { Name = "ColAnh", HeaderText = "Ảnh", Width = 80 };
        dgvOrders.Columns.Add(colAnh);

        dgvOrders.CellFormatting += DgvOrders_CellFormatting;
        dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;

        _bindingSource.DataSource = _filteredList;
        dgvOrders.DataSource = _bindingSource;

        txtTimKiem.TextChanged += (s, e) => ApplyFilter();
        cboLocTrangThai.SelectedIndexChanged += (s, e) => ApplyFilter();

        btnChonAnh.Click += BtnChonAnh_Click;
        btnXoaAnh.Click += BtnXoaAnh_Click;

        btnThem.Click += BtnThem_Click;
        btnCapNhat.Click += BtnCapNhat_Click;
        btnXoa.Click += BtnXoa_Click;
        btnLamMoi.Click += (s, e) => ClearInputs();

        menuItemXuatCsv.Click += MenuItemXuatCsv_Click;
        menuItemThoat.Click += (s, e) => Application.Exit();
    }

    private void DgvOrders_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (dgvOrders.Columns[e.ColumnIndex].Name == "ColAnh")
        {
            if (dgvOrders.Rows[e.RowIndex].DataBoundItem is RepairOrder ord)
            {
                e.Value = !string.IsNullOrEmpty(ord.HinhAnh) && File.Exists(ord.HinhAnh) ? "Có ảnh" : "-";
                e.FormattingApplied = true;
            }
        }
    }

    private void DgvOrders_SelectionChanged(object? sender, EventArgs e)
    {
        if (_isBindingSelection) return;
        if (dgvOrders.SelectedRows.Count > 0)
        {
            var item = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
            if (item != null)
            {
                txtMaDon.Text = item.MaDon;
                txtTenKhachHang.Text = item.TenKhachHang;
                txtSoDienThoai.Text = item.SoDienThoai;
                cboLoaiThietBi.SelectedItem = item.LoaiThietBi;
                if (cboLoaiThietBi.SelectedIndex < 0) cboLoaiThietBi.Text = item.LoaiThietBi;
                txtMoTaLoi.Text = item.MoTaLoi;
                dtpNgayTiepNhan.Value = item.NgayTiepNhan;
                txtChiPhiDuKien.Text = item.ChiPhiDuKien.ToString("0.##");
                cboTrangThai.SelectedItem = item.TrangThai;
                _currentImagePath = item.HinhAnh ?? string.Empty;
                DisplayImage(_currentImagePath);
                _errorProvider.Clear();
            }
        }
    }

    private void DisplayImage(string path)
    {
        picHinhAnh.Image?.Dispose();
        picHinhAnh.Image = null;

        if (!string.IsNullOrEmpty(path) && File.Exists(path))
        {
            try
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                picHinhAnh.Image = Image.FromStream(fs);
                lblDuongDanAnh.Text = Path.GetFileName(path);
            }
            catch
            {
                lblDuongDanAnh.Text = "(Không tải được ảnh)";
            }
        }
        else
        {
            lblDuongDanAnh.Text = "(Chưa chọn ảnh)";
        }
    }

    private void BtnChonAnh_Click(object? sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Title = "Chọn ảnh thiết bị sửa chữa";
        ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả tệp (*.*)|*.*";
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            _currentImagePath = ofd.FileName;
            DisplayImage(_currentImagePath);
        }
    }

    private void BtnXoaAnh_Click(object? sender, EventArgs e)
    {
        _currentImagePath = string.Empty;
        DisplayImage(string.Empty);
    }

    private void ClearInputs()
    {
        _isBindingSelection = true;
        dgvOrders.ClearSelection();
        _isBindingSelection = false;

        txtMaDon.Clear();
        txtTenKhachHang.Clear();
        txtSoDienThoai.Clear();
        if (cboLoaiThietBi.Items.Count > 0) cboLoaiThietBi.SelectedIndex = 0;
        txtMoTaLoi.Clear();
        dtpNgayTiepNhan.Value = DateTime.Today;
        txtChiPhiDuKien.Text = "0";
        cboTrangThai.SelectedIndex = 0;
        _currentImagePath = string.Empty;
        DisplayImage(string.Empty);
        _errorProvider.Clear();
        txtMaDon.Focus();
    }

    private bool ValidateInputs(bool isUpdating, out decimal chiPhi)
    {
        _errorProvider.Clear();
        bool isValid = true;
        chiPhi = 0;

        string maDon = txtMaDon.Text.Trim();
        if (string.IsNullOrWhiteSpace(maDon))
        {
            _errorProvider.SetError(txtMaDon, "Mã đơn không được trống.");
            isValid = false;
        }
        else
        {
            bool duplicate = isUpdating
                ? _allList.Any(x => x.MaDon.Equals(maDon, StringComparison.OrdinalIgnoreCase) && x != (dgvOrders.SelectedRows.Count > 0 ? dgvOrders.SelectedRows[0].DataBoundItem : null))
                : _allList.Any(x => x.MaDon.Equals(maDon, StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                _errorProvider.SetError(txtMaDon, "Mã đơn đã tồn tại.");
                isValid = false;
            }
        }

        if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text.Trim()))
        {
            _errorProvider.SetError(txtTenKhachHang, "Tên khách hàng không được trống.");
            isValid = false;
        }

        string sdt = txtSoDienThoai.Text.Trim();
        if (string.IsNullOrWhiteSpace(sdt))
        {
            _errorProvider.SetError(txtSoDienThoai, "Số điện thoại không được trống.");
            isValid = false;
        }
        else if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
        {
            _errorProvider.SetError(txtSoDienThoai, "Số điện thoại không hợp lệ.");
            isValid = false;
        }

        if (cboLoaiThietBi.SelectedItem == null && string.IsNullOrWhiteSpace(cboLoaiThietBi.Text))
        {
            _errorProvider.SetError(cboLoaiThietBi, "Chọn loại thiết bị.");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtMoTaLoi.Text.Trim()))
        {
            _errorProvider.SetError(txtMoTaLoi, "Mô tả lỗi bắt buộc.");
            isValid = false;
        }

        string chiPhiStr = txtChiPhiDuKien.Text.Trim();
        if (string.IsNullOrWhiteSpace(chiPhiStr) || !decimal.TryParse(chiPhiStr, out chiPhi) || chiPhi < 0)
        {
            _errorProvider.SetError(txtChiPhiDuKien, "Chi phí dự kiến phải là số không âm.");
            isValid = false;
        }

        if (cboTrangThai.SelectedItem == null)
        {
            _errorProvider.SetError(cboTrangThai, "Chọn trạng thái.");
            isValid = false;
        }

        return isValid;
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (!ValidateInputs(isUpdating: false, out decimal chiPhi)) return;

        var ord = new RepairOrder(
            txtMaDon.Text.Trim(),
            txtTenKhachHang.Text.Trim(),
            txtSoDienThoai.Text.Trim(),
            cboLoaiThietBi.Text.Trim(),
            txtMoTaLoi.Text.Trim(),
            dtpNgayTiepNhan.Value.Date,
            chiPhi,
            cboTrangThai.SelectedItem?.ToString() ?? "Mới tiếp nhận",
            _currentImagePath
        );

        _allList.Add(ord);
        RefreshDataAndStatus();
        MessageBox.Show("Thêm đơn sửa chữa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearInputs();
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        if (dgvOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn một đơn để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputs(isUpdating: true, out decimal chiPhi)) return;

        var selected = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
        if (selected == null) return;

        selected.MaDon = txtMaDon.Text.Trim();
        selected.TenKhachHang = txtTenKhachHang.Text.Trim();
        selected.SoDienThoai = txtSoDienThoai.Text.Trim();
        selected.LoaiThietBi = cboLoaiThietBi.Text.Trim();
        selected.MoTaLoi = txtMoTaLoi.Text.Trim();
        selected.NgayTiepNhan = dtpNgayTiepNhan.Value.Date;
        selected.ChiPhiDuKien = chiPhi;
        selected.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Mới tiếp nhận";
        selected.HinhAnh = _currentImagePath;

        RefreshDataAndStatus();
        MessageBox.Show("Cập nhật đơn sửa chữa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (dgvOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selected = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
        if (selected == null) return;

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa đơn [{selected.MaDon}] của khách hàng {selected.TenKhachHang}?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirm == DialogResult.Yes)
        {
            _allList.Remove(selected);
            RefreshDataAndStatus();
            ClearInputs();
            MessageBox.Show("Xóa đơn sửa chữa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void RefreshDataAndStatus()
    {
        ApplyFilter();
    }

    private void ApplyFilter()
    {
        _isBindingSelection = true;
        string kw = txtTimKiem.Text.Trim();
        string filterStatus = cboLocTrangThai.SelectedItem?.ToString() ?? "Tất cả";

        var filtered = _allList.Where(item =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           item.MaDon.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                           item.TenKhachHang.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                           item.SoDienThoai.Contains(kw, StringComparison.OrdinalIgnoreCase);

            bool matchStatus = filterStatus == "Tất cả" || item.TrangThai.Equals(filterStatus, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchStatus;
        }).ToList();

        _filteredList.Clear();
        foreach (var x in filtered) _filteredList.Add(x);

        _bindingSource.ResetBindings(false);
        _isBindingSelection = false;

        decimal tongChiPhiChuaHoanTat = _allList
            .Where(x => !x.TrangThai.Equals("Hoàn tất", StringComparison.OrdinalIgnoreCase))
            .Sum(x => x.ChiPhiDuKien);

        lblStatus.Text = $"Số đơn theo bộ lọc: {_filteredList.Count} / {_allList.Count} | Tổng chi phí đơn chưa hoàn tất: {tongChiPhiChuaHoanTat:N0} VNĐ";
    }

    private void MenuItemXuatCsv_Click(object? sender, EventArgs e)
    {
        if (_filteredList.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var sfd = new SaveFileDialog();
        sfd.Filter = "CSV File (*.csv)|*.csv";
        sfd.FileName = $"DonSuaChua_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến (VNĐ),Trạng thái,Đường dẫn ảnh");
                foreach (var item in _filteredList)
                {
                    sb.AppendLine($"\"{EscapeCsv(item.MaDon)}\",\"{EscapeCsv(item.TenKhachHang)}\",\"{EscapeCsv(item.SoDienThoai)}\",\"{EscapeCsv(item.LoaiThietBi)}\",\"{EscapeCsv(item.MoTaLoi)}\",\"{item.NgayTiepNhan:dd/MM/yyyy}\",{item.ChiPhiDuKien:0},\"{EscapeCsv(item.TrangThai)}\",\"{EscapeCsv(item.HinhAnh)}\"");
                }
                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất file CSV thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private string EscapeCsv(string s) => s.Replace("\"", "\"\"");
}

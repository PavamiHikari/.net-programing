using System.ComponentModel;
using System.Text;

namespace LabEquipmentCheckout;

public partial class Form1 : Form
{
    private BindingList<CheckoutRecord> _allList = new();
    private BindingList<CheckoutRecord> _filteredList = new();
    private BindingSource _bindingSource = new();
    private ErrorProvider _errorProvider = new();
    private bool _isBindingSelection = false;

    public Form1()
    {
        InitializeComponent();
        SetupCustomUI();
        RefreshDataAndStatus();
    }

    private void SetupCustomUI()
    {
        cboThietBi.Items.AddRange(new object[] {
            "Cisco C8111-C-G2-MX Router",
            "Cisco C9350-24/48HX Switch",
            "Cisco C9115AXE-EWC-I 9115AX Wifi-6",
            "Cisco FPR2110-ASA-K9 Firewall",
            "Cisco Global Site Selector GSS-4492R-K9"
        });
        if (cboThietBi.Items.Count > 0) cboThietBi.SelectedIndex = 0;

        cboLocTinhTrang.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
        cboLocTinhTrang.SelectedIndex = 0;

        dtpNgayMuon.Format = DateTimePickerFormat.Custom;
        dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
        dtpNgayMuon.Value = DateTime.Today;

        dtpHanTra.Format = DateTimePickerFormat.Custom;
        dtpHanTra.CustomFormat = "dd/MM/yyyy";
        dtpHanTra.Value = DateTime.Today.AddDays(7);

        dtpNgayTraThucTe.Format = DateTimePickerFormat.Custom;
        dtpNgayTraThucTe.CustomFormat = "dd/MM/yyyy";
        dtpNgayTraThucTe.Value = DateTime.Today;
        dtpNgayTraThucTe.Enabled = false;

        numSoLuong.Minimum = 1;
        numSoLuong.Maximum = 1000;
        numSoLuong.Value = 1;

        dgvCheckouts.AutoGenerateColumns = false;
        dgvCheckouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCheckouts.MultiSelect = false;
        dgvCheckouts.ReadOnly = true;
        dgvCheckouts.AllowUserToAddRows = false;
        dgvCheckouts.BackgroundColor = Color.White;
        dgvCheckouts.RowHeadersVisible = false;

        dgvCheckouts.Columns.Clear();
        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPhieu", HeaderText = "Mã Phiếu", Width = 95 });
        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSinhVien", HeaderText = "Mã SV", Width = 95 });
        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTenSinhVien", HeaderText = "Họ Tên SV", Width = 150 });
        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThietBi", HeaderText = "Thiết Bị", Width = 200 });
        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Width = 50 });

        var colNgayMuon = new DataGridViewTextBoxColumn { DataPropertyName = "NgayMuon", HeaderText = "Ngày Mượn", Width = 100 };
        colNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvCheckouts.Columns.Add(colNgayMuon);

        var colHanTra = new DataGridViewTextBoxColumn { DataPropertyName = "HanTra", HeaderText = "Hạn Trả", Width = 100 };
        colHanTra.DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvCheckouts.Columns.Add(colHanTra);

        var colNgayTra = new DataGridViewTextBoxColumn { Name = "ColNgayTra", HeaderText = "Ngày Trả TT", Width = 105 };
        dgvCheckouts.Columns.Add(colNgayTra);

        dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TinhTrang", HeaderText = "Tình Trạng", Width = 100 });

        dgvCheckouts.CellFormatting += DgvCheckouts_CellFormatting;
        dgvCheckouts.SelectionChanged += DgvCheckouts_SelectionChanged;

        _bindingSource.DataSource = _filteredList;
        dgvCheckouts.DataSource = _bindingSource;

        txtTimKiem.TextChanged += (s, e) => ApplyFilter();
        cboLocTinhTrang.SelectedIndexChanged += (s, e) => ApplyFilter();

        chkDaTra.CheckedChanged += (s, e) => {
            dtpNgayTraThucTe.Enabled = chkDaTra.Checked;
            if (chkDaTra.Checked && dtpNgayTraThucTe.Value < dtpNgayMuon.Value)
            {
                dtpNgayTraThucTe.Value = DateTime.Today;
            }
        };

        btnThem.Click += BtnThem_Click;
        btnCapNhat.Click += BtnCapNhat_Click;
        btnXoa.Click += BtnXoa_Click;
        btnDanhDauDaTra.Click += BtnDanhDauDaTra_Click;
        btnLamMoi.Click += (s, e) => ClearInputs();

        menuItemXuatCsv.Click += MenuItemXuatCsv_Click;
        menuItemThoat.Click += (s, e) => Application.Exit();
    }

    private void DgvCheckouts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (dgvCheckouts.Columns[e.ColumnIndex].Name == "ColNgayTra")
        {
            if (dgvCheckouts.Rows[e.RowIndex].DataBoundItem is CheckoutRecord rec)
            {
                e.Value = rec.NgayTraThucTe.HasValue ? rec.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "-";
                e.FormattingApplied = true;
            }
        }
    }

    private void DgvCheckouts_SelectionChanged(object? sender, EventArgs e)
    {
        if (_isBindingSelection) return;
        if (dgvCheckouts.SelectedRows.Count > 0)
        {
            var item = dgvCheckouts.SelectedRows[0].DataBoundItem as CheckoutRecord;
            if (item != null)
            {
                txtMaPhieu.Text = item.MaPhieu;
                txtMaSinhVien.Text = item.MaSinhVien;
                txtHoTenSinhVien.Text = item.HoTenSinhVien;
                cboThietBi.SelectedItem = item.ThietBi;
                if (cboThietBi.SelectedIndex < 0) cboThietBi.Text = item.ThietBi;
                numSoLuong.Value = Math.Max(numSoLuong.Minimum, Math.Min(numSoLuong.Maximum, item.SoLuong));
                dtpNgayMuon.Value = item.NgayMuon;
                dtpHanTra.Value = item.HanTra;
                if (item.NgayTraThucTe.HasValue)
                {
                    chkDaTra.Checked = true;
                    dtpNgayTraThucTe.Value = item.NgayTraThucTe.Value;
                }
                else
                {
                    chkDaTra.Checked = false;
                    dtpNgayTraThucTe.Value = DateTime.Today;
                }
                _errorProvider.Clear();
            }
        }
    }

    private void ClearInputs()
    {
        _isBindingSelection = true;
        dgvCheckouts.ClearSelection();
        _isBindingSelection = false;

        txtMaPhieu.Clear();
        txtMaSinhVien.Clear();
        txtHoTenSinhVien.Clear();
        if (cboThietBi.Items.Count > 0) cboThietBi.SelectedIndex = 0;
        numSoLuong.Value = 1;
        dtpNgayMuon.Value = DateTime.Today;
        dtpHanTra.Value = DateTime.Today.AddDays(7);
        chkDaTra.Checked = false;
        dtpNgayTraThucTe.Value = DateTime.Today;
        _errorProvider.Clear();
        txtMaPhieu.Focus();
    }

    private bool ValidateInputs(bool isUpdating)
    {
        _errorProvider.Clear();
        bool isValid = true;

        string maPhieu = txtMaPhieu.Text.Trim();
        if (string.IsNullOrWhiteSpace(maPhieu))
        {
            _errorProvider.SetError(txtMaPhieu, "Mã phiếu không được trống.");
            isValid = false;
        }
        else
        {
            bool duplicate = isUpdating
                ? _allList.Any(x => x.MaPhieu.Equals(maPhieu, StringComparison.OrdinalIgnoreCase) && x != (dgvCheckouts.SelectedRows.Count > 0 ? dgvCheckouts.SelectedRows[0].DataBoundItem : null))
                : _allList.Any(x => x.MaPhieu.Equals(maPhieu, StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                _errorProvider.SetError(txtMaPhieu, "Mã phiếu đã tồn tại.");
                isValid = false;
            }
        }

        if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text.Trim()))
        {
            _errorProvider.SetError(txtMaSinhVien, "Mã sinh viên không được trống.");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtHoTenSinhVien.Text.Trim()))
        {
            _errorProvider.SetError(txtHoTenSinhVien, "Họ tên sinh viên không được trống.");
            isValid = false;
        }

        if (cboThietBi.SelectedItem == null && string.IsNullOrWhiteSpace(cboThietBi.Text))
        {
            _errorProvider.SetError(cboThietBi, "Thiết bị không được trống.");
            isValid = false;
        }

        if (numSoLuong.Value <= 0)
        {
            _errorProvider.SetError(numSoLuong, "Số lượng phải lớn hơn 0.");
            isValid = false;
        }

        if (dtpHanTra.Value.Date < dtpNgayMuon.Value.Date)
        {
            _errorProvider.SetError(dtpHanTra, "Hạn trả không được trước ngày mượn.");
            isValid = false;
        }

        if (chkDaTra.Checked && dtpNgayTraThucTe.Value.Date < dtpNgayMuon.Value.Date)
        {
            _errorProvider.SetError(dtpNgayTraThucTe, "Ngày trả thực tế không được trước ngày mượn.");
            isValid = false;
        }

        return isValid;
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (!ValidateInputs(isUpdating: false)) return;

        DateTime? ngayTra = chkDaTra.Checked ? dtpNgayTraThucTe.Value.Date : null;

        var rec = new CheckoutRecord(
            txtMaPhieu.Text.Trim(),
            txtMaSinhVien.Text.Trim(),
            txtHoTenSinhVien.Text.Trim(),
            cboThietBi.Text.Trim(),
            (int)numSoLuong.Value,
            dtpNgayMuon.Value.Date,
            dtpHanTra.Value.Date,
            ngayTra
        );

        _allList.Add(rec);
        RefreshDataAndStatus();
        MessageBox.Show("Thêm phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearInputs();
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        if (dgvCheckouts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn một phiếu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputs(isUpdating: true)) return;

        var selected = dgvCheckouts.SelectedRows[0].DataBoundItem as CheckoutRecord;
        if (selected == null) return;

        selected.MaPhieu = txtMaPhieu.Text.Trim();
        selected.MaSinhVien = txtMaSinhVien.Text.Trim();
        selected.HoTenSinhVien = txtHoTenSinhVien.Text.Trim();
        selected.ThietBi = cboThietBi.Text.Trim();
        selected.SoLuong = (int)numSoLuong.Value;
        selected.NgayMuon = dtpNgayMuon.Value.Date;
        selected.HanTra = dtpHanTra.Value.Date;
        selected.NgayTraThucTe = chkDaTra.Checked ? dtpNgayTraThucTe.Value.Date : null;
        selected.CapNhatTinhTrang();

        RefreshDataAndStatus();
        MessageBox.Show("Cập nhật phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (dgvCheckouts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn phiếu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selected = dgvCheckouts.SelectedRows[0].DataBoundItem as CheckoutRecord;
        if (selected == null) return;

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa phiếu mượn [{selected.MaPhieu}] của sinh viên {selected.HoTenSinhVien}?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirm == DialogResult.Yes)
        {
            _allList.Remove(selected);
            RefreshDataAndStatus();
            ClearInputs();
            MessageBox.Show("Xóa phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void BtnDanhDauDaTra_Click(object? sender, EventArgs e)
    {
        if (dgvCheckouts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn phiếu mượn cần đánh dấu đã trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selected = dgvCheckouts.SelectedRows[0].DataBoundItem as CheckoutRecord;
        if (selected == null) return;

        selected.NgayTraThucTe = DateTime.Today;
        selected.CapNhatTinhTrang();

        chkDaTra.Checked = true;
        dtpNgayTraThucTe.Value = DateTime.Today;

        RefreshDataAndStatus();
        MessageBox.Show($"Đã đánh dấu trả thiết bị cho phiếu [{selected.MaPhieu}].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void RefreshDataAndStatus()
    {
        foreach (var item in _allList)
        {
            item.CapNhatTinhTrang();
        }

        ApplyFilter();
    }

    private void ApplyFilter()
    {
        _isBindingSelection = true;
        string kw = txtTimKiem.Text.Trim();
        string filterStatus = cboLocTinhTrang.SelectedItem?.ToString() ?? "Tất cả";

        var filtered = _allList.Where(item =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           item.MaSinhVien.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                           item.ThietBi.Contains(kw, StringComparison.OrdinalIgnoreCase);

            bool matchStatus = filterStatus == "Tất cả" || item.TinhTrang.Equals(filterStatus, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchStatus;
        }).ToList();

        _filteredList.Clear();
        foreach (var x in filtered) _filteredList.Add(x);

        _bindingSource.ResetBindings(false);
        _isBindingSelection = false;

        int total = _allList.Count;
        int overdue = _allList.Count(x => x.TinhTrang == "Quá hạn");
        lblStatus.Text = $"Tổng số phiếu: {total} | Số phiếu quá hạn: {overdue} | Đang hiển thị: {_filteredList.Count}";
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
        sfd.FileName = $"MuonTraThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("Mã phiếu,Mã sinh viên,Họ tên sinh viên,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");
                foreach (var item in _filteredList)
                {
                    string ngayTraStr = item.NgayTraThucTe.HasValue ? item.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "";
                    sb.AppendLine($"\"{EscapeCsv(item.MaPhieu)}\",\"{EscapeCsv(item.MaSinhVien)}\",\"{EscapeCsv(item.HoTenSinhVien)}\",\"{EscapeCsv(item.ThietBi)}\",{item.SoLuong},\"{item.NgayMuon:dd/MM/yyyy}\",\"{item.HanTra:dd/MM/yyyy}\",\"{ngayTraStr}\",\"{EscapeCsv(item.TinhTrang)}\"");
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

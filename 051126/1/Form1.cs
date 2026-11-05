using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace ClinicAppointmentManager;

public partial class Form1 : Form
{
    private BindingList<Appointment> _allList = new();
    private BindingList<Appointment> _filteredList = new();
    private BindingSource _bindingSource = new();
    private ErrorProvider _errorProvider = new();
    private bool _isBindingSelection = false;

    public Form1()
    {
        InitializeComponent();
        SetupCustomUI();
        ApplyFilter();
    }

    private void SetupCustomUI()
    {
        cboBacSi.Items.AddRange(new object[] {
            "BS. Nguyễn Văn An - Nội tổng quát",
            "BS. Trần Thị Bé - Tai mũi họng",
            "BS. Lê Hoàng Cầu - Răng hàm mặt",
            "BS. Phạm Thu Dương - Da liễu"
        });
        if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;

        cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
        cboTrangThai.SelectedIndex = 0;

        cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
        cboLocTrangThai.SelectedIndex = 0;

        dtpNgayGio.Format = DateTimePickerFormat.Custom;
        dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpNgayGio.Value = DateTime.Now.AddHours(1);

        dtpLocNgay.Format = DateTimePickerFormat.Custom;
        dtpLocNgay.CustomFormat = "dd/MM/yyyy";
        dtpLocNgay.Value = DateTime.Today;

        dgvAppointments.AutoGenerateColumns = false;
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAppointments.MultiSelect = false;
        dgvAppointments.ReadOnly = true;
        dgvAppointments.AllowUserToAddRows = false;
        dgvAppointments.BackgroundColor = Color.White;
        dgvAppointments.RowHeadersVisible = false;

        dgvAppointments.Columns.Clear();
        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaLichHen", HeaderText = "Mã Lịch Hẹn", Width = 110 });
        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ Tên Bệnh Nhân", Width = 170 });
        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Số Điện Thoại", Width = 120 });
        
        var colNgayGio = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NgayGioHen",
            HeaderText = "Ngày Giờ Hẹn",
            Width = 140
        };
        colNgayGio.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        dgvAppointments.Columns.Add(colNgayGio);

        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BacSi", HeaderText = "Bác Sĩ", Width = 160 });
        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LiDoKham", HeaderText = "Lý Do Khám", Width = 180 });
        dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 110 });

        _bindingSource.DataSource = _filteredList;
        dgvAppointments.DataSource = _bindingSource;

        dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;
        txtTimKiem.TextChanged += (s, e) => ApplyFilter();
        cboLocTrangThai.SelectedIndexChanged += (s, e) => ApplyFilter();
        chkLocNgay.CheckedChanged += (s, e) => {
            dtpLocNgay.Enabled = chkLocNgay.Checked;
            ApplyFilter();
        };
        dtpLocNgay.ValueChanged += (s, e) => {
            if (chkLocNgay.Checked) ApplyFilter();
        };

        btnThem.Click += BtnThem_Click;
        btnCapNhat.Click += BtnCapNhat_Click;
        btnXoa.Click += BtnXoa_Click;
        btnLamMoi.Click += (s, e) => ClearInputs();

        menuItemXuatCsv.Click += MenuItemXuatCsv_Click;
        menuItemThoat.Click += (s, e) => Application.Exit();
    }

    private void DgvAppointments_SelectionChanged(object? sender, EventArgs e)
    {
        if (_isBindingSelection) return;
        if (dgvAppointments.SelectedRows.Count > 0)
        {
            var item = dgvAppointments.SelectedRows[0].DataBoundItem as Appointment;
            if (item != null)
            {
                txtMaLichHen.Text = item.MaLichHen;
                txtHoTen.Text = item.HoTen;
                txtSoDienThoai.Text = item.SoDienThoai;
                dtpNgayGio.Value = item.NgayGioHen;
                cboBacSi.SelectedItem = item.BacSi;
                if (cboBacSi.SelectedIndex < 0 && cboBacSi.Items.Count > 0) cboBacSi.Text = item.BacSi;
                txtLyDoKham.Text = item.LyDoKham;
                cboTrangThai.SelectedItem = item.TrangThai;
                _errorProvider.Clear();
            }
        }
    }

    private void ClearInputs()
    {
        _isBindingSelection = true;
        dgvAppointments.ClearSelection();
        _isBindingSelection = false;

        txtMaLichHen.Clear();
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        dtpNgayGio.Value = DateTime.Now.AddHours(1);
        if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
        txtLyDoKham.Clear();
        cboTrangThai.SelectedIndex = 0;
        _errorProvider.Clear();
        txtMaLichHen.Focus();
    }

    private bool ValidateInputs(bool isUpdating)
    {
        _errorProvider.Clear();
        bool isValid = true;

        string ma = txtMaLichHen.Text.Trim();
        if (string.IsNullOrWhiteSpace(ma))
        {
            _errorProvider.SetError(txtMaLichHen, "Mã lịch hẹn không được trống.");
            isValid = false;
        }
        else
        {
            bool duplicate = isUpdating
                ? _allList.Any(x => x.MaLichHen.Equals(ma, StringComparison.OrdinalIgnoreCase) && x != (dgvAppointments.SelectedRows.Count > 0 ? dgvAppointments.SelectedRows[0].DataBoundItem : null))
                : _allList.Any(x => x.MaLichHen.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                _errorProvider.SetError(txtMaLichHen, "Mã lịch hẹn đã tồn tại.");
                isValid = false;
            }
        }

        if (string.IsNullOrWhiteSpace(txtHoTen.Text.Trim()))
        {
            _errorProvider.SetError(txtHoTen, "Họ tên bệnh nhân bắt buộc.");
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

        if (string.IsNullOrWhiteSpace(txtLyDoKham.Text.Trim()))
        {
            _errorProvider.SetError(txtLyDoKham, "Lý do khám không được trống.");
            isValid = false;
        }

        if (dtpNgayGio.Value < DateTime.Now.AddMinutes(-1))
        {
            _errorProvider.SetError(dtpNgayGio, "Ngày hẹn không được nằm trong quá khứ.");
            isValid = false;
        }

        if (cboBacSi.SelectedItem == null && string.IsNullOrWhiteSpace(cboBacSi.Text))
        {
            _errorProvider.SetError(cboBacSi, "Hãy chọn bác sĩ.");
            isValid = false;
        }

        if (cboTrangThai.SelectedItem == null)
        {
            _errorProvider.SetError(cboTrangThai, "Hãy chọn trạng thái.");
            isValid = false;
        }

        return isValid;
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (!ValidateInputs(isUpdating: false)) return;

        var item = new Appointment(
            txtMaLichHen.Text.Trim(),
            txtHoTen.Text.Trim(),
            txtSoDienThoai.Text.Trim(),
            dtpNgayGio.Value,
            cboBacSi.Text.Trim(),
            txtLyDoKham.Text.Trim(),
            cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám"
        );

        _allList.Add(item);
        ApplyFilter();
        MessageBox.Show("Thêm lịch hẹn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearInputs();
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        if (dgvAppointments.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn một lịch hẹn để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputs(isUpdating: true)) return;

        var selected = dgvAppointments.SelectedRows[0].DataBoundItem as Appointment;
        if (selected == null) return;

        selected.MaLichHen = txtMaLichHen.Text.Trim();
        selected.HoTen = txtHoTen.Text.Trim();
        selected.SoDienThoai = txtSoDienThoai.Text.Trim();
        selected.NgayGioHen = dtpNgayGio.Value;
        selected.BacSi = cboBacSi.Text.Trim();
        selected.LyDoKham = txtLyDoKham.Text.Trim();
        selected.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám";

        ApplyFilter();
        MessageBox.Show("Cập nhật lịch hẹn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (dgvAppointments.SelectedRows.Count == 0)
        {
            MessageBox.Show("Chọn lịch hẹn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selected = dgvAppointments.SelectedRows[0].DataBoundItem as Appointment;
        if (selected == null) return;

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa lịch hẹn [{selected.MaLichHen}] của bệnh nhân {selected.HoTen}?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirm == DialogResult.Yes)
        {
            _allList.Remove(selected);
            ApplyFilter();
            ClearInputs();
            MessageBox.Show("Xóa lịch hẹn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void ApplyFilter()
    {
        _isBindingSelection = true;
        string kw = txtTimKiem.Text.Trim();
        string status = cboLocTrangThai.SelectedItem?.ToString() ?? "Tất cả";
        bool filterDate = chkLocNgay.Checked;
        DateTime targetDate = dtpLocNgay.Value.Date;

        var filtered = _allList.Where(item =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           item.HoTen.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                           item.SoDienThoai.Contains(kw, StringComparison.OrdinalIgnoreCase);

            bool matchStatus = status == "Tất cả" || item.TrangThai.Equals(status, StringComparison.OrdinalIgnoreCase);

            bool matchDate = !filterDate || item.NgayGioHen.Date == targetDate;

            return matchKw && matchStatus && matchDate;
        }).ToList();

        _filteredList.Clear();
        foreach (var x in filtered) _filteredList.Add(x);

        _bindingSource.ResetBindings(false);
        _isBindingSelection = false;

        lblStatus.Text = $"Số lịch hẹn sau khi lọc: {_filteredList.Count} (Tổng: {_allList.Count})";
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
        sfd.FileName = $"LichHen_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");
                foreach (var item in _filteredList)
                {
                    sb.AppendLine($"\"{EscapeCsv(item.MaLichHen)}\",\"{EscapeCsv(item.HoTen)}\",\"{EscapeCsv(item.SoDienThoai)}\",\"{item.NgayGioHen:dd/MM/yyyy HH:mm}\",\"{EscapeCsv(item.BacSi)}\",\"{EscapeCsv(item.LyDoKham)}\",\"{EscapeCsv(item.TrangThai)}\"");
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

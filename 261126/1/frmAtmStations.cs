using System.ComponentModel;

namespace BankAtmMdiSystem;

public partial class frmAtmStations : Form
{
    private readonly BindingList<AtmStation> _stations = new();
    private string _selectedImagePath = string.Empty;

    public frmAtmStations()
    {
        InitializeComponent();
        LoadSampleStations();
    }

    private void LoadSampleStations()
    {
        _stations.Add(new AtmStation
        {
            MaTram = "ATM-HN01",
            DiaChi = "Số 18 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội",
            TonQuy = 850_000_000m,
            TrangThai = "Hoạt động"
        });
        _stations.Add(new AtmStation
        {
            MaTram = "ATM-HN02",
            DiaChi = "Số 102 Trần Phú, Hà Đông, Hà Nội",
            TonQuy = 420_000_000m,
            TrangThai = "Hoạt động"
        });
        _stations.Add(new AtmStation
        {
            MaTram = "ATM-HN03",
            DiaChi = "Số 235 Hoàng Quốc Việt, Cầu Giấy, Hà Nội",
            TonQuy = 0m,
            TrangThai = "Hết tiền"
        });

        dgvTramAtm.DataSource = _stations;
        if (cboTrangThai.Items.Count > 0)
        {
            cboTrangThai.SelectedIndex = 0;
        }
    }

    private bool TryReadInputs(out string maTram, out string diaChi, out decimal tonQuy, out string trangThai)
    {
        maTram = txtMaTram.Text.Trim();
        diaChi = txtDiaChi.Text.Trim();
        trangThai = cboTrangThai.SelectedItem?.ToString() ?? "Hoạt động";
        tonQuy = 0;

        if (string.IsNullOrWhiteSpace(maTram))
        {
            MessageBox.Show("Nhập Mã trạm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaTram.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(diaChi))
        {
            MessageBox.Show("Nhập Địa chỉ đặt máy.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDiaChi.Focus();
            return false;
        }

        string rawBalance = txtTonQuy.Text.Trim().Replace(",", string.Empty);
        if (!decimal.TryParse(rawBalance, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out tonQuy) || tonQuy < 0)
        {
            MessageBox.Show("Số tiền tồn quỹ không được âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTonQuy.Focus();
            return false;
        }

        return true;
    }

    private void LoadImagePreview(string imagePath)
    {
        Image? oldImage = picHienTruong.Image;
        picHienTruong.Image = null;
        oldImage?.Dispose();

        _selectedImagePath = imagePath;

        if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
        {
            return;
        }

        try
        {
            using Bitmap tempBitmap = new(imagePath);
            picHienTruong.Image = new Bitmap(tempBitmap);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể tải ảnh hiện trường: {ex.Message}", "Lỗi đọc ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnChonAnh_Click(object? sender, EventArgs e)
    {
        if (ofdAnhTram.ShowDialog(this) == DialogResult.OK)
        {
            LoadImagePreview(ofdAnhTram.FileName);
        }
    }

    private void btnThem_Click(object? sender, EventArgs e)
    {
        if (!TryReadInputs(out string maTram, out string diaChi, out decimal tonQuy, out string trangThai))
        {
            return;
        }

        if (_stations.Any(s => string.Equals(s.MaTram, maTram, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã trạm đã tồn tại trong danh sách.", "Trùng mã trạm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaTram.Focus();
            return;
        }

        _stations.Add(new AtmStation
        {
            MaTram = maTram,
            DiaChi = diaChi,
            TonQuy = tonQuy,
            TrangThai = trangThai,
            AnhHienTruong = _selectedImagePath
        });

        dgvTramAtm.ClearSelection();
        int lastIndex = _stations.Count - 1;
        if (lastIndex >= 0)
        {
            dgvTramAtm.Rows[lastIndex].Selected = true;
        }
    }

    private void btnCapNhat_Click(object? sender, EventArgs e)
    {
        if (dgvTramAtm.CurrentRow?.DataBoundItem is not AtmStation selected)
        {
            MessageBox.Show("Chọn một trạm ATM cần cập nhật.", "Chưa chọn trạm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryReadInputs(out string maTram, out string diaChi, out decimal tonQuy, out string trangThai))
        {
            return;
        }

        bool duplicateCode = _stations.Any(s =>
            !ReferenceEquals(s, selected) &&
            string.Equals(s.MaTram, maTram, StringComparison.OrdinalIgnoreCase));

        if (duplicateCode)
        {
            MessageBox.Show("Mã trạm đã trùng với một trạm khác.", "Trùng mã trạm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaTram.Focus();
            return;
        }

        selected.MaTram = maTram;
        selected.DiaChi = diaChi;
        selected.TonQuy = tonQuy;
        selected.TrangThai = trangThai;
        selected.AnhHienTruong = _selectedImagePath;

        int index = _stations.IndexOf(selected);
        if (index >= 0)
        {
            _stations.ResetItem(index);
        }
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        if (dgvTramAtm.CurrentRow?.DataBoundItem is not AtmStation selected)
        {
            MessageBox.Show("Chọn một trạm ATM cần xóa.", "Chưa chọn trạm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _stations.Remove(selected);
        if (_stations.Count == 0)
        {
            txtMaTram.Clear();
            txtDiaChi.Clear();
            txtTonQuy.Clear();
            LoadImagePreview(string.Empty);
        }
    }

    private void dgvTramAtm_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvTramAtm.CurrentRow?.DataBoundItem is not AtmStation selected)
        {
            return;
        }

        txtMaTram.Text = selected.MaTram;
        txtDiaChi.Text = selected.DiaChi;
        txtTonQuy.Text = selected.TonQuy.ToString("0");

        int statusIndex = cboTrangThai.Items.IndexOf(selected.TrangThai);
        cboTrangThai.SelectedIndex = statusIndex >= 0 ? statusIndex : 0;

        LoadImagePreview(selected.AnhHienTruong);
    }

    private void frmAtmStations_FormClosed(object? sender, FormClosedEventArgs e)
    {
        picHienTruong.Image?.Dispose();
        picHienTruong.Image = null;
    }
}

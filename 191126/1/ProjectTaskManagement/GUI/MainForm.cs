using ProjectTaskManagement.BUS;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.GUI;

public partial class MainForm : Form
{
    private readonly DuAnBUS _duAnBUS = new();
    private readonly CongViecBUS _congViecBUS = new();
    private readonly ThanhVienBUS _thanhVienBUS = new();
    private readonly PhanCongBUS _phanCongBUS = new();
    private readonly BaoCaoBUS _baoCaoBUS = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        cboTrangThaiDuAn.SelectedIndex = 0;
        cboDoUuTien.SelectedIndex = 0;
        cboTrangThaiTask.SelectedIndex = 0;
        cboLocTrangThai.SelectedIndex = 0;
        cboChuyenTrangThai.SelectedIndex = 0;

        LoadDuAnData();
        LoadThanhVienData();
        LoadTienDoData();
        LoadOverdueData();
        LoadThongKeData();
    }

    #region Tab 1: Quản lý Dự án & Task
    private void LoadDuAnData()
    {
        try
        {
            var listDuAn = _duAnBUS.GetAll();
            dgvDuAn.DataSource = null;
            dgvDuAn.DataSource = listDuAn;

            cboLocDuAn.Items.Clear();
            cboLocDuAn.Items.Add(new DuAnDTO { MaDuAn = 0, TenDuAn = "-- Tất cả dự án --" });
            foreach (var da in listDuAn)
            {
                cboLocDuAn.Items.Add(da);
            }
            if (cboLocDuAn.Items.Count > 0)
            {
                cboLocDuAn.SelectedIndex = 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp danh sách dự án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvDuAn_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvDuAn.CurrentRow?.DataBoundItem is DuAnDTO da)
        {
            txtTenDuAn.Text = da.TenDuAn;
            dtpNgayBatDau.Value = da.NgayBatDau > DateTime.MinValue ? da.NgayBatDau : DateTime.Today;
            dtpNgayKetThuc.Value = da.NgayKetThuc > DateTime.MinValue ? da.NgayKetThuc : DateTime.Today;
            cboTrangThaiDuAn.SelectedItem = da.TrangThai;

            LoadTaskByDuAn(da.MaDuAn);
        }
    }

    private void LoadTaskByDuAn(int maDuAn)
    {
        try
        {
            var tasks = _congViecBUS.GetTasks(maDuAn, null);
            dgvTask.DataSource = null;
            dgvTask.DataSource = tasks;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp task: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThemDuAn_Click(object? sender, EventArgs e)
    {
        try
        {
            DuAnDTO da = new()
            {
                TenDuAn = txtTenDuAn.Text.Trim(),
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                TrangThai = cboTrangThaiDuAn.SelectedItem?.ToString() ?? "Đang chạy"
            };

            if (_duAnBUS.Insert(da))
            {
                MessageBox.Show("Thêm dự án thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuAnData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnSuaDuAn_Click(object? sender, EventArgs e)
    {
        if (dgvDuAn.CurrentRow?.DataBoundItem is not DuAnDTO currentDa)
        {
            MessageBox.Show("Chọn dự án cần sửa/", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            currentDa.TenDuAn = txtTenDuAn.Text.Trim();
            currentDa.NgayBatDau = dtpNgayBatDau.Value;
            currentDa.NgayKetThuc = dtpNgayKetThuc.Value;
            currentDa.TrangThai = cboTrangThaiDuAn.SelectedItem?.ToString() ?? "Đang chạy";

            if (_duAnBUS.Update(currentDa))
            {
                MessageBox.Show("Cập nhật dự án thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuAnData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnXoaDuAn_Click(object? sender, EventArgs e)
    {
        if (dgvDuAn.CurrentRow?.DataBoundItem is not DuAnDTO currentDa)
        {
            MessageBox.Show("Chọn dự án cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show($"Chắc chắn muốn xóa dự án \"{currentDa.TenDuAn}\" và các task liên quan?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                if (_duAnBUS.Delete(currentDa.MaDuAn))
                {
                    MessageBox.Show("Đã xóa dự án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuAnData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dự án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnThemTask_Click(object? sender, EventArgs e)
    {
        if (dgvDuAn.CurrentRow?.DataBoundItem is not DuAnDTO currentDa)
        {
            MessageBox.Show("Chọn một dự án để thêm task.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            CongViecDTO task = new()
            {
                MaDuAn = currentDa.MaDuAn,
                TenTask = txtTenTask.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                HanNop = dtpHanNop.Value,
                DoUuTien = cboDoUuTien.SelectedItem?.ToString() ?? "Trung bình",
                TrangThai = cboTrangThaiTask.SelectedItem?.ToString() ?? "To Do"
            };

            if (_congViecBUS.Insert(task))
            {
                MessageBox.Show("Thêm task thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaskByDuAn(currentDa.MaDuAn);
                txtTenTask.Clear();
                txtMoTa.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnXoaTask_Click(object? sender, EventArgs e)
    {
        if (dgvTask.CurrentRow?.DataBoundItem is not CongViecDTO task)
        {
            MessageBox.Show("Chọn task cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show($"Xóa task \"{task.TenTask}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                if (_congViecBUS.Delete(task.MaTask))
                {
                    MessageBox.Show("Đã xóa task.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dgvDuAn.CurrentRow?.DataBoundItem is DuAnDTO da)
                    {
                        LoadTaskByDuAn(da.MaDuAn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa task: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion

    #region Tab 2: Tiến độ & Phân công
    private void LoadThanhVienData()
    {
        try
        {
            var tvList = _thanhVienBUS.GetAll();
            cboThanhVien.DataSource = null;
            cboThanhVien.DataSource = tvList;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp thành viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadTienDoData()
    {
        try
        {
            int? maDuAn = null;
            if (cboLocDuAn.SelectedItem is DuAnDTO da && da.MaDuAn > 0)
            {
                maDuAn = da.MaDuAn;
            }

            string? trangThai = cboLocTrangThai.SelectedItem?.ToString();
            var tasks = _congViecBUS.GetTasks(maDuAn, trangThai);

            dgvTienDoTask.DataSource = null;
            dgvTienDoTask.DataSource = tasks;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp tiến độ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLoc_Click(object? sender, EventArgs e)
    {
        LoadTienDoData();
    }

    private void dgvTienDoTask_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvTienDoTask.CurrentRow?.DataBoundItem is CongViecDTO task)
        {
            cboChuyenTrangThai.SelectedItem = task.TrangThai;
            LoadPhanCongByTask(task.MaTask);
        }
        else
        {
            dgvPhanCong.DataSource = null;
        }
    }

    private void LoadPhanCongByTask(int maTask)
    {
        try
        {
            var list = _phanCongBUS.GetAssignmentsByTask(maTask);
            dgvPhanCong.DataSource = null;
            dgvPhanCong.DataSource = list;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp phân công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCapNhatTrangThai_Click(object? sender, EventArgs e)
    {
        if (dgvTienDoTask.CurrentRow?.DataBoundItem is not CongViecDTO task)
        {
            MessageBox.Show("Chọn task cần cập nhật trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string newStatus = cboChuyenTrangThai.SelectedItem?.ToString() ?? "Done";
        try
        {
            if (_congViecBUS.UpdateStatus(task.MaTask, newStatus))
            {
                MessageBox.Show($"Đã cập nhật trạng thái task thành \"{newStatus}\"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTienDoData();
                LoadOverdueData();
                LoadThongKeData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi cập nhật trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnPhanCong_Click(object? sender, EventArgs e)
    {
        if (dgvTienDoTask.CurrentRow?.DataBoundItem is not CongViecDTO task)
        {
            MessageBox.Show("Chọn task cần phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cboThanhVien.SelectedItem is not ThanhVienDTO tv)
        {
            MessageBox.Show("Chọn thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (_phanCongBUS.AssignTask(task.MaTask, tv.MaThanhVien))
            {
                MessageBox.Show($"Đã giao task \"{task.TenTask}\" cho {tv.HoTen}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanCongByTask(task.MaTask);
                LoadThongKeData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi phân công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuyPhanCong_Click(object? sender, EventArgs e)
    {
        if (dgvPhanCong.CurrentRow?.DataBoundItem is not PhanCongDTO pc)
        {
            MessageBox.Show("Chọn bản ghi phân công cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (_phanCongBUS.RemoveAssignment(pc.MaTask, pc.MaThanhVien))
            {
                MessageBox.Show("Đã hủy phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanCongByTask(pc.MaTask);
                LoadThongKeData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi hủy phân công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region Tab 3: Cảnh báo trễ hạn & Báo cáo
    private void btnTaiOverdue_Click(object? sender, EventArgs e)
    {
        LoadOverdueData();
    }

    private void LoadOverdueData()
    {
        try
        {
            var overdue = _congViecBUS.GetOverdueTasks();
            dgvOverdue.DataSource = null;
            dgvOverdue.DataSource = overdue;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp danh sách trễ hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnTaiThongKe_Click(object? sender, EventArgs e)
    {
        LoadThongKeData();
    }

    private void LoadThongKeData()
    {
        try
        {
            var stats = _baoCaoBUS.GetMemberCompletionStats(null);
            dgvBaoCao.DataSource = null;
            dgvBaoCao.DataSource = stats;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion
}

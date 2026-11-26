namespace BankAtmMdiSystem;

public partial class frmBankAtmMain : Form
{
    private bool _isLoggedIn = true;
    private bool _isLocked;

    public frmBankAtmMain()
    {
        InitializeComponent();
    }

    private void OpenMdiChild<T>() where T : Form, new()
    {
        foreach (Form child in MdiChildren)
        {
            if (child is T)
            {
                if (child.WindowState == FormWindowState.Minimized)
                {
                    child.WindowState = FormWindowState.Normal;
                }
                child.Activate();
                return;
            }
        }

        T newForm = new()
        {
            MdiParent = this
        };
        newForm.Show();
    }

    public void UpdateReconciliationProgress(int percent, string? coreStatusText = null)
    {
        if (IsDisposed || Disposing)
        {
            return;
        }

        if (InvokeRequired)
        {
            Invoke(new Action(() => UpdateReconciliationProgress(percent, coreStatusText)));
            return;
        }

        tspbDoiSoat.Value = Math.Clamp(percent, tspbDoiSoat.Minimum, tspbDoiSoat.Maximum);
        if (!string.IsNullOrEmpty(coreStatusText))
        {
            tslCoreBanking.Text = coreStatusText;
        }
    }

    private void CloseAllMdiChildren()
    {
        foreach (Form child in MdiChildren.ToArray())
        {
            child.Close();
        }
    }

    private void mnuDanhSachAtm_Click(object? sender, EventArgs e)
    {
        OpenMdiChild<frmAtmStations>();
    }

    private void mnuDoiSoatGiaoDich_Click(object? sender, EventArgs e)
    {
        OpenMdiChild<frmAtmReconciliation>();
    }

    private void mnuXepTang_Click(object? sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
    }

    private void mnuXepNgang_Click(object? sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void mnuXepDoc_Click(object? sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }

    private void mnuDongTatCa_Click(object? sender, EventArgs e)
    {
        CloseAllMdiChildren();
    }

    private void mnuDangXuat_Click(object? sender, EventArgs e)
    {
        if (_isLoggedIn)
        {
            DialogResult result = MessageBox.Show(
                "Đăng xuất và đóng toàn bộ cửa sổ làm việc?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            CloseAllMdiChildren();
            _isLoggedIn = false;
            _isLocked = false;

            mnuQuanLyAtm.Enabled = false;
            mnuCuaSo.Enabled = false;
            mnuKhoaManHinh.Enabled = false;
            mnuKhoaManHinh.Text = "Khóa màn hình";
            mnuDangXuat.Text = "Đăng nhập lại";

            tslGiaoDichVien.Text = "GDV trực: (Đã đăng xuất)";
            tslCoreBanking.Text = "Core Banking: Ngắt kết nối";
            tspbDoiSoat.Value = 0;
        }
        else
        {
            _isLoggedIn = true;
            mnuQuanLyAtm.Enabled = true;
            mnuCuaSo.Enabled = true;
            mnuKhoaManHinh.Enabled = true;
            mnuDangXuat.Text = "Đăng xuất";

            tslGiaoDichVien.Text = "GDV trực: Nguyễn Văn An";
            tslCoreBanking.Text = "Core Banking: Đã kết nối";
        }
    }

    private void mnuKhoaManHinh_Click(object? sender, EventArgs e)
    {
        if (!_isLoggedIn)
        {
            return;
        }

        _isLocked = !_isLocked;
        bool active = !_isLocked;

        mnuQuanLyAtm.Enabled = active;
        mnuCuaSo.Enabled = active;
        foreach (Form child in MdiChildren)
        {
            child.Enabled = active;
        }

        mnuKhoaManHinh.Text = _isLocked ? "Mở khóa màn hình" : "Khóa màn hình";
        tslCoreBanking.Text = _isLocked ? "Trạng thái: Đã khóa màn hình" : "Core Banking: Đã kết nối";
    }

    private void mnuThoat_Click(object? sender, EventArgs e)
    {
        Close();
    }
}

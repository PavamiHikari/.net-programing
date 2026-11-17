using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRMManagement.BUS;
using HRMManagement.DTO;

namespace HRMManagement.GUI
{
    public partial class MainForm : Form
    {
        private readonly PhongBanBUS _phongBanBUS = new PhongBanBUS();
        private readonly NhanVienBUS _nhanVienBUS = new NhanVienBUS();
        private readonly ChamCongBUS _chamCongBUS = new ChamCongBUS();
        private readonly LuongBUS _luongBUS = new LuongBUS();

        private SqlDataAdapter? _chamCongAdapter;
        private DataTable? _chamCongTable;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadPhongBanCombos();
                LoadNhanVienList();
                TaiBangChamCong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối CSDL HRMDB:\n{ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TAB 1: QUẢN LÝ HỒ SƠ NHÂN SỰ
        private void LoadPhongBanCombos()
        {
            var pbs = _phongBanBUS.GetAll();

            cboPhongBan.DataSource = pbs.ToList();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";

            cboChuyenPB.DataSource = pbs.ToList();
            cboChuyenPB.DisplayMember = "TenPB";
            cboChuyenPB.ValueMember = "MaPB";

            var filterList = new List<PhongBanDTO> { new PhongBanDTO { MaPB = 0, TenPB = "-- Tất cả phòng ban --" } };
            filterList.AddRange(pbs);
            cboLocPhongBan.DataSource = filterList;
            cboLocPhongBan.DisplayMember = "TenPB";
            cboLocPhongBan.ValueMember = "MaPB";
        }

        private void LoadNhanVienList()
        {
            dgvNhanVien.DataSource = _nhanVienBUS.GetAll();
            if (dgvNhanVien.Columns["MaPB"] != null) dgvNhanVien.Columns["MaPB"].Visible = false;
        }

        private void BtnTimKiemNV_Click(object? sender, EventArgs e)
        {
            string kw = txtTimKiemNV.Text.Trim();
            int? maPB = (cboLocPhongBan.SelectedValue is int pbId && pbId > 0) ? pbId : null;
            dgvNhanVien.DataSource = _nhanVienBUS.Search(kw, maPB);
        }

        private void BtnTatCaNV_Click(object? sender, EventArgs e)
        {
            txtTimKiemNV.Clear();
            if (cboLocPhongBan.Items.Count > 0)
                cboLocPhongBan.SelectedIndex = 0;
            LoadNhanVienList();
        }

        private void DgvNhanVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.DataBoundItem is NhanVienDTO nv)
            {
                txtMaNV.Text = nv.MaNV.ToString();
                txtHoTen.Text = nv.HoTen;
                dtpNgaySinh.Value = nv.NgaySinh > DateTime.MinValue ? nv.NgaySinh : DateTime.Today;
                txtCCCD.Text = nv.CCCD;
                cboPhongBan.SelectedValue = nv.MaPB;
                numLuongCoBan.Value = nv.LuongCoBan;
                numHeSoLuong.Value = (decimal)nv.HeSoLuong;
            }
        }

        private void ResetNhanVienForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            txtCCCD.Clear();
            numLuongCoBan.Value = 10000000;
            numHeSoLuong.Value = 1.0M;
            txtTimKiemNV.Clear();
            LoadNhanVienList();
        }

        private void BtnThemNV_Click(object? sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVienDTO
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = (int)(cboPhongBan.SelectedValue ?? 0),
                    LuongCoBan = numLuongCoBan.Value,
                    HeSoLuong = (double)numHeSoLuong.Value
                };
                _nhanVienBUS.Insert(nv);
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetNhanVienForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaNV_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = (int)(cboPhongBan.SelectedValue ?? 0),
                    LuongCoBan = numLuongCoBan.Value,
                    HeSoLuong = (double)numHeSoLuong.Value
                };
                _nhanVienBUS.Update(nv);
                MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetNhanVienForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChuyenPB_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chuyển phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPBMoi = (int)(cboChuyenPB.SelectedValue ?? 0);
            try
            {
                _nhanVienBUS.ChuyenPhongBan(maNV, maPBMoi);
                MessageBox.Show($"Đã chuyển nhân viên #{maNV} sang {cboChuyenPB.Text} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chuyển phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaNV_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên #{maNV}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _nhanVienBUS.Delete(maNV);
                    MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetNhanVienForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoiNV_Click(object? sender, EventArgs e)
        {
            ResetNhanVienForm();
        }
        #endregion

        #region TAB 2: CHẤM CÔNG NGẮT KẾT NỐI
        private void BtnTaiChamCong_Click(object? sender, EventArgs e)
        {
            TaiBangChamCong();
        }

        private void TaiBangChamCong()
        {
            try
            {
                string thangNam = dtpThangNamChamCong.Value.ToString("MM/yyyy");
                _chamCongAdapter = _chamCongBUS.LoadChamCong(thangNam, out _chamCongTable);

                dgvChamCong.DataSource = _chamCongTable;

                if (dgvChamCong.Columns["MaCong"] != null) dgvChamCong.Columns["MaCong"].ReadOnly = true;
                if (dgvChamCong.Columns["MaNV"] != null) dgvChamCong.Columns["MaNV"].ReadOnly = true;
                if (dgvChamCong.Columns["ThangNam"] != null) dgvChamCong.Columns["ThangNam"].ReadOnly = true;
                if (dgvChamCong.Columns["DaKhoa"] != null) dgvChamCong.Columns["DaKhoa"].ReadOnly = true;

                if (dgvChamCong.Columns["SoNgayCong"] != null)
                {
                    dgvChamCong.Columns["SoNgayCong"].ReadOnly = false;
                    dgvChamCong.Columns["SoNgayCong"].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                if (dgvChamCong.Columns["SoGioOT"] != null)
                {
                    dgvChamCong.Columns["SoGioOT"].ReadOnly = false;
                    dgvChamCong.Columns["SoGioOT"].DefaultCellStyle.BackColor = Color.LightYellow;
                }

                bool daKhoa = _chamCongBUS.IsThangDaKhoa(thangNam);
                if (daKhoa)
                {
                    lblTrangThaiChamCong.Text = "Trạng thái: [ĐÃ KHÓA SỔ]";
                    lblTrangThaiChamCong.ForeColor = Color.Red;
                    btnLuuChamCong.Enabled = false;
                    dgvChamCong.ReadOnly = true;
                }
                else
                {
                    lblTrangThaiChamCong.Text = "Trạng thái: [MỞ - Cho phép sửa]";
                    lblTrangThaiChamCong.ForeColor = Color.DarkGreen;
                    btnLuuChamCong.Enabled = true;
                    dgvChamCong.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp dữ liệu chấm công:\n{ex.Message}", "Lỗi Disconnected Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLuuChamCong_Click(object? sender, EventArgs e)
        {
            if (_chamCongAdapter == null || _chamCongTable == null)
            {
                MessageBox.Show("Vui lòng tải bảng chấm công trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thangNam = dtpThangNamChamCong.Value.ToString("MM/yyyy");

            try
            {
                dgvChamCong.EndEdit();

                int rowsUpdated = _chamCongBUS.LuuChamCong(_chamCongAdapter, _chamCongTable, thangNam);

                MessageBox.Show($"Lưu thành công. Đã đồng bộ {rowsUpdated} thay đổi về SQL Server trong 1 thao tác duy nhất (adapter.Update).", "Đồng bộ thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiBangChamCong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đồng bộ dữ liệu chấm công về SQL Server:\n{ex.Message}", "Lỗi đồng bộ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TAB 3: TÍNH LƯƠNG & CHỐT LƯƠNG
        private void BtnTinhLuong_Click(object? sender, EventArgs e)
        {
            XemTinhLuong();
        }

        private void XemTinhLuong()
        {
            string thangNam = dtpThangNamLuong.Value.ToString("MM/yyyy");
            try
            {
                var list = _luongBUS.TinhLuong(thangNam);
                dgvBangLuong.DataSource = list;

                decimal tongLuong = list.Sum(x => x.ThucLinh);
                lblTongQuyLuong.Text = $"Tổng quỹ lương thực lĩnh tháng {thangNam}: {tongLuong:N0} đ ({list.Count} nhân viên)";

                txtNhatKyLuong.Text = $"Đã tính lương tháng {thangNam} theo công thức:\r\n" +
                                      $"ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)\r\n" +
                                      $"Tổng nhân viên: {list.Count} | Tổng chi lương: {tongLuong:N0} đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính lương:\n{ex.Message}", "Lỗi tính lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChotLuong_Click(object? sender, EventArgs e)
        {
            string thangNam = dtpThangNamLuong.Value.ToString("MM/yyyy");

            if (MessageBox.Show($"Bạn có chắc chắn muốn CHỐT LƯƠNG tháng {thangNam}?\nSau khi chốt, dữ liệu chấm công sẽ bị KHÓA và không thể chỉnh sửa.", "Xác nhận chốt lương", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                txtNhatKyLuong.Text = $"[Bắt đầu] Mở SqlTransaction để chốt lương tháng {thangNam}...\r\n";

                int count = _luongBUS.ChotLuongThang(thangNam);

                txtNhatKyLuong.AppendText(
                    $"[THÀNH CÔNG] SqlTransaction đã Commit hoàn tất!\r\n" +
                    $"- Đã ghi nhận bảng lương cho {count} nhân viên vào BangLuong.\r\n" +
                    $"- Đã khóa dữ liệu chấm công tháng {thangNam} (DaKhoa = 1).");

                MessageBox.Show($"Chốt lương tháng {thangNam} thành công cho {count} nhân viên.\nSqlTransaction đã COMMIT an toàn.", "Chốt lương thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                XemTinhLuong();
                TaiBangChamCong();
            }
            catch (Exception ex)
            {
                txtNhatKyLuong.AppendText(
                    $"[GIAO DỊCH THẤT BẠI - ĐÃ ROLLBACK]\r\n" +
                    $"Lý do: {ex.Message}\r\n" +
                    $"Dữ liệu BangLuong và BangChamCong không bị thay đổi.");

                MessageBox.Show($"Chốt lương thất bại (SqlTransaction Rollback):\n{ex.Message}", "Lỗi chốt lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void lblThangChamCong_Click(object sender, EventArgs e)
        {

        }
    }
}

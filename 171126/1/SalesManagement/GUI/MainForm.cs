using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesManagement.BUS;
using SalesManagement.DTO;

namespace SalesManagement.GUI
{
    public partial class MainForm : Form
    {
        private readonly NhanVienBUS _nhanVienBUS = new NhanVienBUS();
        private readonly KhachHangBUS _khachHangBUS = new KhachHangBUS();
        private readonly SanPhamBUS _sanPhamBUS = new SanPhamBUS();
        private readonly HoaDonBUS _hoaDonBUS = new HoaDonBUS();

        private readonly List<ChiTietHoaDonDTO> _gioHang = new List<ChiTietHoaDonDTO>();

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            try
            {
                numThangDoanhThu.Value = DateTime.Today.Month;
                numNamDoanhThu.Value = DateTime.Today.Year;

                LoadDataBanHang();
                LoadSanPhamList();
                LoadKhachHangList();
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối CSDL SalesDB:\n{ex.Message}\n.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TAB 1: BÁN HÀNG & LẬP HÓA ĐƠN
        private void LoadDataBanHang()
        {
            var nvs = _nhanVienBUS.GetAll();
            cboNhanVien.DataSource = nvs;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            var khs = _khachHangBUS.GetAll();
            var khList = new List<KhachHangDTO>
            {
                new KhachHangDTO { MaKH = 0, TenKH = "-- Khách lẻ (Không tích điểm) --", DiemTichLuy = 0 }
            };
            khList.AddRange(khs);
            cboKhachHang.DataSource = khList;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";

            var sps = _sanPhamBUS.GetAll();
            cboSanPham.DataSource = sps;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";

            CapNhatGioHangView();
        }

        private void CboKhachHang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboKhachHang.SelectedItem is KhachHangDTO kh)
            {
                lblDiemHienCo.Text = kh.MaKH == 0 ? "Khách vãng lai" : $"Điểm tích lũy hiện có: {kh.DiemTichLuy}";
            }
            TinhTongTien();
        }

        private void BtnThemGioHang_Click(object? sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is not SanPhamDTO sp)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuong = (int)numSoLuongMua.Value;
            var existing = _gioHang.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
            }
            else
            {
                _gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = soLuong
                });
            }

            CapNhatGioHangView();
        }

        private void BtnXoaGioHang_Click(object? sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.CurrentRow.DataBoundItem is ChiTietHoaDonDTO item)
            {
                _gioHang.Remove(item);
                CapNhatGioHangView();
            }
        }

        private void BtnXoaTatCaGioHang_Click(object? sender, EventArgs e)
        {
            _gioHang.Clear();
            CapNhatGioHangView();
        }

        private void CapNhatGioHangView()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang.ToList();
            if (dgvGioHang.Columns["MaHD"] != null) dgvGioHang.Columns["MaHD"].Visible = false;
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = _gioHang.Sum(x => x.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {tong:N0} đ";

            if (cboKhachHang.SelectedItem is KhachHangDTO kh && kh.MaKH > 0)
            {
                int diemCong = (int)(tong / 100000m);
                lblDiemCong.Text = $"Điểm cộng dự kiến: +{diemCong}";
            }
            else
            {
                lblDiemCong.Text = "Điểm cộng dự kiến: 0 (Khách lẻ)";
            }
        }

        private void BtnThanhToan_Click(object? sender, EventArgs e)
        {
            if (cboNhanVien.SelectedItem is not NhanVienDTO nv)
            {
                MessageBox.Show("Vui lòng chọn nhân viên bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống. Vui lòng thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = cboKhachHang.SelectedItem as KhachHangDTO;
            int? maKH = (kh != null && kh.MaKH > 0) ? kh.MaKH : null;

            decimal tongTien = _gioHang.Sum(x => x.ThanhTien);
            var hoaDon = new HoaDonDTO
            {
                NgayLap = DateTime.Now,
                MaNV = nv.MaNV,
                MaKH = maKH,
                TongTien = tongTien
            };

            try
            {
                txtTrangThai.Text = "[Bắt đầu] Xử lý thanh toán đơn hàng...";
                int maHDMoi = _hoaDonBUS.ThanhToanHoaDon(hoaDon, _gioHang);

                txtTrangThai.Text = $"[THÀNH CÔNG] Thanh toán hóa đơn #{maHDMoi} thành công!\r\n" +
                                   $"- Đã tạo Hóa Đơn với {_gioHang.Count} sản phẩm.\r\n" +
                                   $"- Đã cập nhật trừ tồn kho.\r\n" +
                                   (maKH.HasValue ? $"- Khách hàng được cộng thêm {(int)(tongTien / 100000m)} điểm tích lũy." : "- Khách lẻ (không tích điểm).");

                MessageBox.Show($"Thanh toán hóa đơn #{maHDMoi} thành công.\nTổng tiền: {tongTien:N0} đ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _gioHang.Clear();
                CapNhatGioHangView();
                LoadDataBanHang();
                LoadSanPhamList();
                LoadKhachHangList();
            }
            catch (Exception ex)
            {
                txtTrangThai.Text = $"[GIAO DỊCH THẤT BẠI]\r\n" +
                                   $"Lý do: {ex.Message}\r\n";
                MessageBox.Show($"Giao dịch bị hủy:\n{ex.Message}", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region TAB 2: QUẢN LÝ DANH MỤC - SẢN PHẨM
        private void LoadSanPhamList(string? keyword = null)
        {
            var list = string.IsNullOrWhiteSpace(keyword) ? _sanPhamBUS.GetAll() : _sanPhamBUS.Search(keyword);
            dgvSanPham.DataSource = list;
        }

        private void BtnTimKiemSP_Click(object? sender, EventArgs e)
        {
            LoadSanPhamList(txtTimKiemSP.Text.Trim());
        }

        private void BtnTatCaSP_Click(object? sender, EventArgs e)
        {
            txtTimKiemSP.Clear();
            LoadSanPhamList();
        }

        private void DgvSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.CurrentRow != null && dgvSanPham.CurrentRow.DataBoundItem is SanPhamDTO sp)
            {
                txtMaSP.Text = sp.MaSP;
                txtMaSP.ReadOnly = true;
                txtTenSP.Text = sp.TenSP;
                numGiaBanSP.Value = sp.GiaBan;
                numSoLuongTonSP.Value = sp.SoLuongTon;
            }
        }

        private void ResetSanPhamForm()
        {
            txtMaSP.ReadOnly = false;
            txtMaSP.Clear();
            txtTenSP.Clear();
            numGiaBanSP.Value = 0;
            numSoLuongTonSP.Value = 0;
            txtTimKiemSP.Clear();
            LoadSanPhamList();
        }

        private void BtnThemSP_Click(object? sender, EventArgs e)
        {
            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = numGiaBanSP.Value,
                    SoLuongTon = (int)numSoLuongTonSP.Value
                };
                _sanPhamBUS.Insert(sp);
                MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSanPhamForm();
                LoadDataBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaSP_Click(object? sender, EventArgs e)
        {
            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = numGiaBanSP.Value,
                    SoLuongTon = (int)numSoLuongTonSP.Value
                };
                _sanPhamBUS.Update(sp);
                MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSanPhamForm();
                LoadDataBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaSP_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm mã '{txtMaSP.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _sanPhamBUS.Delete(txtMaSP.Text.Trim());
                    MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSanPhamForm();
                    LoadDataBanHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoiSP_Click(object? sender, EventArgs e)
        {
            ResetSanPhamForm();
        }
        #endregion

        #region TAB 2: QUẢN LÝ DANH MỤC - KHÁCH HÀNG
        private void LoadKhachHangList()
        {
            dgvKhachHang.DataSource = _khachHangBUS.GetAll();
        }

        private void DgvKhachHang_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null && dgvKhachHang.CurrentRow.DataBoundItem is KhachHangDTO kh)
            {
                txtMaKH.Text = kh.MaKH.ToString();
                txtTenKH.Text = kh.TenKH;
                txtDienThoaiKH.Text = kh.DienThoai ?? "";
                numDiemTichLuyKH.Value = kh.DiemTichLuy;
            }
        }

        private void ResetKhachHangForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDienThoaiKH.Clear();
            numDiemTichLuyKH.Value = 0;
            LoadKhachHangList();
        }

        private void BtnThemKH_Click(object? sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHangDTO
                {
                    TenKH = txtTenKH.Text.Trim(),
                    DienThoai = string.IsNullOrWhiteSpace(txtDienThoaiKH.Text) ? null : txtDienThoaiKH.Text.Trim(),
                    DiemTichLuy = (int)numDiemTichLuyKH.Value
                };
                _khachHangBUS.Insert(kh);
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetKhachHangForm();
                LoadDataBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaKH_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var kh = new KhachHangDTO
                {
                    MaKH = maKH,
                    TenKH = txtTenKH.Text.Trim(),
                    DienThoai = string.IsNullOrWhiteSpace(txtDienThoaiKH.Text) ? null : txtDienThoaiKH.Text.Trim(),
                    DiemTichLuy = (int)numDiemTichLuyKH.Value
                };
                _khachHangBUS.Update(kh);
                MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetKhachHangForm();
                LoadDataBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaKH_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa khách hàng #{maKH}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _khachHangBUS.Delete(maKH);
                    MessageBox.Show("Xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetKhachHangForm();
                    LoadDataBanHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoiKH_Click(object? sender, EventArgs e)
        {
            ResetKhachHangForm();
        }
        #endregion

        #region TAB 2: QUẢN LÝ DANH MỤC - NHÂN VIÊN
        private void LoadNhanVienList()
        {
            dgvNhanVien.DataSource = _nhanVienBUS.GetAll();
        }

        private void DgvNhanVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.DataBoundItem is NhanVienDTO nv)
            {
                txtMaNV.Text = nv.MaNV.ToString();
                txtTenNV.Text = nv.TenNV;
                txtSDTNV.Text = nv.SoDienThoai ?? "";
                txtChucVuNV.Text = nv.ChucVu ?? "";
            }
        }

        private void ResetNhanVienForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDTNV.Clear();
            txtChucVuNV.Clear();
            LoadNhanVienList();
        }

        private void BtnThemNV_Click(object? sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVienDTO
                {
                    TenNV = txtTenNV.Text.Trim(),
                    SoDienThoai = string.IsNullOrWhiteSpace(txtSDTNV.Text) ? null : txtSDTNV.Text.Trim(),
                    ChucVu = string.IsNullOrWhiteSpace(txtChucVuNV.Text) ? null : txtChucVuNV.Text.Trim()
                };
                _nhanVienBUS.Insert(nv);
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetNhanVienForm();
                LoadDataBanHang();
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
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    TenNV = txtTenNV.Text.Trim(),
                    SoDienThoai = string.IsNullOrWhiteSpace(txtSDTNV.Text) ? null : txtSDTNV.Text.Trim(),
                    ChucVu = string.IsNullOrWhiteSpace(txtChucVuNV.Text) ? null : txtChucVuNV.Text.Trim()
                };
                _nhanVienBUS.Update(nv);
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetNhanVienForm();
                LoadDataBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaNV_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên #{maNV}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _nhanVienBUS.Delete(maNV);
                    MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetNhanVienForm();
                    LoadDataBanHang();
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

        #region TAB 3: BÁO CÁO - THỐNG KÊ
        private void BtnDoanhThuNgay_Click(object? sender, EventArgs e)
        {
            DateTime ngay = dtpNgayDoanhThu.Value;
            decimal dt = _hoaDonBUS.GetDoanhThuTheoNgay(ngay);
            lblDoanhThuNgayKetQua.Text = $"Doanh thu ngày {ngay:dd/MM/yyyy}: {dt:N0} đ";
        }

        private void BtnDoanhThuThang_Click(object? sender, EventArgs e)
        {
            int thang = (int)numThangDoanhThu.Value;
            int nam = (int)numNamDoanhThu.Value;
            decimal dt = _hoaDonBUS.GetDoanhThuTheoThang(thang, nam);
            lblDoanhThuThangKetQua.Text = $"Doanh thu tháng {thang:D2}/{nam}: {dt:N0} đ";
        }

        private void BtnTop5SP_Click(object? sender, EventArgs e)
        {
            LoadTop5SanPham();
        }

        private void LoadTop5SanPham()
        {
            var topList = _hoaDonBUS.GetTop5SanPham();
            dgvTop5SP.DataSource = topList;
        }
        #endregion
    }
}

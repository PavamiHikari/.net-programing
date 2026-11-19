namespace GarageManagement.GUI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        tabMain = new TabControl();
        tabTiepNhan = new TabPage();
        grpPhuTung = new GroupBox();
        dgvPhuTung = new DataGridView();
        colPT_Ma = new DataGridViewTextBoxColumn();
        colPT_Ten = new DataGridViewTextBoxColumn();
        colPT_DonGia = new DataGridViewTextBoxColumn();
        colPT_Ton = new DataGridViewTextBoxColumn();
        btnCapNhatPhuTung = new Button();
        btnThemPhuTung = new Button();
        nudSoLuongTon = new NumericUpDown();
        lblTon = new Label();
        nudDonGia = new NumericUpDown();
        lblDonGia = new Label();
        txtTenPhuTung = new TextBox();
        lblTenPhuTung = new Label();
        grpXe = new GroupBox();
        btnLuuXeMoi = new Button();
        nudNamSanXuat = new NumericUpDown();
        lblNamSX = new Label();
        cboHieuXe = new ComboBox();
        lblHieuXe = new Label();
        txtBienSo = new TextBox();
        lblBienSo = new Label();
        txtDiaChi = new TextBox();
        lblDiaChi = new Label();
        txtDienThoai = new TextBox();
        lblDienThoai = new Label();
        txtTenKH = new TextBox();
        lblTenKH = new Label();
        btnTraCuu = new Button();
        txtTraCuuBienSo = new TextBox();
        lblTraCuu = new Label();
        tabLapPhieu = new TabPage();
        lblTongTienDuKien = new Label();
        btnTaoPhieuSuaChua = new Button();
        grpChiTiet = new GroupBox();
        dgvChiTietTam = new DataGridView();
        colCT_Ma = new DataGridViewTextBoxColumn();
        colCT_Ten = new DataGridViewTextBoxColumn();
        colCT_SoLuong = new DataGridViewTextBoxColumn();
        colCT_DonGia = new DataGridViewTextBoxColumn();
        colCT_TienCong = new DataGridViewTextBoxColumn();
        colCT_ThanhTien = new DataGridViewTextBoxColumn();
        btnXoaChiTiet = new Button();
        btnThemChiTiet = new Button();
        nudTienCong = new NumericUpDown();
        lblTienCong = new Label();
        nudSoLuongThayThe = new NumericUpDown();
        lblSoLuongThayThe = new Label();
        cboChonPhuTung = new ComboBox();
        lblChonPhuTung = new Label();
        grpThongTinPhieu = new GroupBox();
        txtNoiDungSua = new TextBox();
        lblNoiDungSua = new Label();
        dtpNgayNhan = new DateTimePicker();
        lblNgayNhan = new Label();
        cboChonXe = new ComboBox();
        lblChonXe = new Label();
        tabThanhToan = new TabPage();
        grpChiTietHD = new GroupBox();
        btnThanhToan = new Button();
        lblTongThanhToan = new Label();
        dgvChiTietHoaDon = new DataGridView();
        colHD_Ten = new DataGridViewTextBoxColumn();
        colHD_SoLuong = new DataGridViewTextBoxColumn();
        colHD_DonGia = new DataGridViewTextBoxColumn();
        colHD_TienCong = new DataGridViewTextBoxColumn();
        colHD_ThanhTien = new DataGridViewTextBoxColumn();
        grpPhieuSuaChua = new GroupBox();
        dgvPhieuSuaChua = new DataGridView();
        colPSC_Ma = new DataGridViewTextBoxColumn();
        colPSC_BienSo = new DataGridViewTextBoxColumn();
        colPSC_TenKH = new DataGridViewTextBoxColumn();
        colPSC_NgayNhan = new DataGridViewTextBoxColumn();
        colPSC_TongTien = new DataGridViewTextBoxColumn();
        colPSC_TrangThai = new DataGridViewTextBoxColumn();
        tabMain.SuspendLayout();
        tabTiepNhan.SuspendLayout();
        grpPhuTung.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhuTung).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
        grpXe.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudNamSanXuat).BeginInit();
        tabLapPhieu.SuspendLayout();
        grpChiTiet.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietTam).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTienCong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongThayThe).BeginInit();
        grpThongTinPhieu.SuspendLayout();
        tabThanhToan.SuspendLayout();
        grpChiTietHD.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        grpPhieuSuaChua.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhieuSuaChua).BeginInit();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabTiepNhan);
        tabMain.Controls.Add(tabLapPhieu);
        tabMain.Controls.Add(tabThanhToan);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Location = new Point(0, 0);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(984, 611);
        tabMain.TabIndex = 0;
        // 
        // tabTiepNhan
        // 
        tabTiepNhan.Controls.Add(grpPhuTung);
        tabTiepNhan.Controls.Add(grpXe);
        tabTiepNhan.Location = new Point(4, 29);
        tabTiepNhan.Name = "tabTiepNhan";
        tabTiepNhan.Padding = new Padding(10);
        tabTiepNhan.Size = new Size(976, 578);
        tabTiepNhan.TabIndex = 0;
        tabTiepNhan.Text = "1. Tiếp nhận Xe & Quản lý Phụ tùng";
        tabTiepNhan.UseVisualStyleBackColor = true;
        // 
        // grpPhuTung
        // 
        grpPhuTung.Controls.Add(dgvPhuTung);
        grpPhuTung.Controls.Add(btnCapNhatPhuTung);
        grpPhuTung.Controls.Add(btnThemPhuTung);
        grpPhuTung.Controls.Add(nudSoLuongTon);
        grpPhuTung.Controls.Add(lblTon);
        grpPhuTung.Controls.Add(nudDonGia);
        grpPhuTung.Controls.Add(lblDonGia);
        grpPhuTung.Controls.Add(txtTenPhuTung);
        grpPhuTung.Controls.Add(lblTenPhuTung);
        grpPhuTung.Location = new Point(460, 10);
        grpPhuTung.Name = "grpPhuTung";
        grpPhuTung.Size = new Size(505, 555);
        grpPhuTung.TabIndex = 1;
        grpPhuTung.TabStop = false;
        grpPhuTung.Text = "Quản lý danh mục Phụ tùng & Tồn kho";
        // 
        // dgvPhuTung
        // 
        dgvPhuTung.AllowUserToAddRows = false;
        dgvPhuTung.AllowUserToDeleteRows = false;
        dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPhuTung.Columns.AddRange(new DataGridViewColumn[] { colPT_Ma, colPT_Ten, colPT_DonGia, colPT_Ton });
        dgvPhuTung.Location = new Point(15, 205);
        dgvPhuTung.MultiSelect = false;
        dgvPhuTung.Name = "dgvPhuTung";
        dgvPhuTung.ReadOnly = true;
        dgvPhuTung.RowHeadersWidth = 51;
        dgvPhuTung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPhuTung.Size = new Size(475, 335);
        dgvPhuTung.TabIndex = 8;
        dgvPhuTung.SelectionChanged += dgvPhuTung_SelectionChanged;
        // 
        // colPT_Ma
        // 
        colPT_Ma.DataPropertyName = "MaPhuTung";
        colPT_Ma.HeaderText = "Mã";
        colPT_Ma.MinimumWidth = 6;
        colPT_Ma.Name = "colPT_Ma";
        colPT_Ma.ReadOnly = true;
        colPT_Ma.Width = 60;
        // 
        // colPT_Ten
        // 
        colPT_Ten.DataPropertyName = "TenPhuTung";
        colPT_Ten.HeaderText = "Tên Phụ Tùng";
        colPT_Ten.MinimumWidth = 6;
        colPT_Ten.Name = "colPT_Ten";
        colPT_Ten.ReadOnly = true;
        colPT_Ten.Width = 180;
        // 
        // colPT_DonGia
        // 
        colPT_DonGia.DataPropertyName = "DonGia";
        colPT_DonGia.HeaderText = "Đơn Giá";
        colPT_DonGia.MinimumWidth = 6;
        colPT_DonGia.Name = "colPT_DonGia";
        colPT_DonGia.ReadOnly = true;
        colPT_DonGia.Width = 110;
        // 
        // colPT_Ton
        // 
        colPT_Ton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPT_Ton.DataPropertyName = "SoLuongTon";
        colPT_Ton.HeaderText = "Tồn Kho";
        colPT_Ton.MinimumWidth = 6;
        colPT_Ton.Name = "colPT_Ton";
        colPT_Ton.ReadOnly = true;
        // 
        // btnCapNhatPhuTung
        // 
        btnCapNhatPhuTung.Location = new Point(255, 155);
        btnCapNhatPhuTung.Name = "btnCapNhatPhuTung";
        btnCapNhatPhuTung.Size = new Size(130, 32);
        btnCapNhatPhuTung.TabIndex = 7;
        btnCapNhatPhuTung.Text = "Cập nhật giá/tồn";
        btnCapNhatPhuTung.UseVisualStyleBackColor = true;
        btnCapNhatPhuTung.Click += btnCapNhatPhuTung_Click;
        // 
        // btnThemPhuTung
        // 
        btnThemPhuTung.Location = new Point(115, 155);
        btnThemPhuTung.Name = "btnThemPhuTung";
        btnThemPhuTung.Size = new Size(130, 32);
        btnThemPhuTung.TabIndex = 6;
        btnThemPhuTung.Text = "Thêm Phụ Tùng";
        btnThemPhuTung.UseVisualStyleBackColor = true;
        btnThemPhuTung.Click += btnThemPhuTung_Click;
        // 
        // nudSoLuongTon
        // 
        nudSoLuongTon.Location = new Point(115, 110);
        nudSoLuongTon.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nudSoLuongTon.Name = "nudSoLuongTon";
        nudSoLuongTon.Size = new Size(270, 27);
        nudSoLuongTon.TabIndex = 5;
        // 
        // lblTon
        // 
        lblTon.AutoSize = true;
        lblTon.Location = new Point(15, 113);
        lblTon.Name = "lblTon";
        lblTon.Size = new Size(98, 20);
        lblTon.TabIndex = 4;
        lblTon.Text = "Số lượng tồn:";
        // 
        // nudDonGia
        // 
        nudDonGia.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
        nudDonGia.Location = new Point(115, 70);
        nudDonGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        nudDonGia.Name = "nudDonGia";
        nudDonGia.Size = new Size(270, 27);
        nudDonGia.TabIndex = 3;
        // 
        // lblDonGia
        // 
        lblDonGia.AutoSize = true;
        lblDonGia.Location = new Point(15, 73);
        lblDonGia.Name = "lblDonGia";
        lblDonGia.Size = new Size(65, 20);
        lblDonGia.TabIndex = 2;
        lblDonGia.Text = "Đơn giá:";
        // 
        // txtTenPhuTung
        // 
        txtTenPhuTung.Location = new Point(115, 30);
        txtTenPhuTung.Name = "txtTenPhuTung";
        txtTenPhuTung.Size = new Size(270, 27);
        txtTenPhuTung.TabIndex = 1;
        // 
        // lblTenPhuTung
        // 
        lblTenPhuTung.AutoSize = true;
        lblTenPhuTung.Location = new Point(15, 33);
        lblTenPhuTung.Name = "lblTenPhuTung";
        lblTenPhuTung.Size = new Size(98, 20);
        lblTenPhuTung.TabIndex = 0;
        lblTenPhuTung.Text = "Tên phụ tùng:";
        // 
        // grpXe
        // 
        grpXe.Controls.Add(btnLuuXeMoi);
        grpXe.Controls.Add(nudNamSanXuat);
        grpXe.Controls.Add(lblNamSX);
        grpXe.Controls.Add(cboHieuXe);
        grpXe.Controls.Add(lblHieuXe);
        grpXe.Controls.Add(txtBienSo);
        grpXe.Controls.Add(lblBienSo);
        grpXe.Controls.Add(txtDiaChi);
        grpXe.Controls.Add(lblDiaChi);
        grpXe.Controls.Add(txtDienThoai);
        grpXe.Controls.Add(lblDienThoai);
        grpXe.Controls.Add(txtTenKH);
        grpXe.Controls.Add(lblTenKH);
        grpXe.Controls.Add(btnTraCuu);
        grpXe.Controls.Add(txtTraCuuBienSo);
        grpXe.Controls.Add(lblTraCuu);
        grpXe.Location = new Point(10, 10);
        grpXe.Name = "grpXe";
        grpXe.Size = new Size(435, 555);
        grpXe.TabIndex = 0;
        grpXe.TabStop = false;
        grpXe.Text = "Tra cứu & Tiếp nhận Xe mới";
        // 
        // btnLuuXeMoi
        // 
        btnLuuXeMoi.Location = new Point(115, 340);
        btnLuuXeMoi.Name = "btnLuuXeMoi";
        btnLuuXeMoi.Size = new Size(180, 35);
        btnLuuXeMoi.TabIndex = 15;
        btnLuuXeMoi.Text = "Lưu Chủ xe & Xe mới";
        btnLuuXeMoi.UseVisualStyleBackColor = true;
        btnLuuXeMoi.Click += btnLuuXeMoi_Click;
        // 
        // nudNamSanXuat
        // 
        nudNamSanXuat.Location = new Point(115, 290);
        nudNamSanXuat.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
        nudNamSanXuat.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
        nudNamSanXuat.Name = "nudNamSanXuat";
        nudNamSanXuat.Size = new Size(295, 27);
        nudNamSanXuat.TabIndex = 14;
        nudNamSanXuat.Value = new decimal(new int[] { 2022, 0, 0, 0 });
        // 
        // lblNamSX
        // 
        lblNamSX.AutoSize = true;
        lblNamSX.Location = new Point(15, 293);
        lblNamSX.Name = "lblNamSX";
        lblNamSX.Size = new Size(65, 20);
        lblNamSX.TabIndex = 13;
        lblNamSX.Text = "Năm SX:";
        // 
        // cboHieuXe
        // 
        cboHieuXe.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHieuXe.FormattingEnabled = true;
        cboHieuXe.Items.AddRange(new object[] { "Toyota", "Honda", "VinFast", "Hyundai", "Kia", "Ford", "Mazda", "Khác" });
        cboHieuXe.Location = new Point(115, 250);
        cboHieuXe.Name = "cboHieuXe";
        cboHieuXe.Size = new Size(295, 28);
        cboHieuXe.TabIndex = 12;
        // 
        // lblHieuXe
        // 
        lblHieuXe.AutoSize = true;
        lblHieuXe.Location = new Point(15, 253);
        lblHieuXe.Name = "lblHieuXe";
        lblHieuXe.Size = new Size(62, 20);
        lblHieuXe.TabIndex = 11;
        lblHieuXe.Text = "Hiệu xe:";
        // 
        // txtBienSo
        // 
        txtBienSo.Location = new Point(115, 210);
        txtBienSo.Name = "txtBienSo";
        txtBienSo.Size = new Size(295, 27);
        txtBienSo.TabIndex = 10;
        // 
        // lblBienSo
        // 
        lblBienSo.AutoSize = true;
        lblBienSo.Location = new Point(15, 213);
        lblBienSo.Name = "lblBienSo";
        lblBienSo.Size = new Size(60, 20);
        lblBienSo.TabIndex = 9;
        lblBienSo.Text = "Biển số:";
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(115, 170);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(295, 27);
        txtDiaChi.TabIndex = 8;
        // 
        // lblDiaChi
        // 
        lblDiaChi.AutoSize = true;
        lblDiaChi.Location = new Point(15, 173);
        lblDiaChi.Name = "lblDiaChi";
        lblDiaChi.Size = new Size(58, 20);
        lblDiaChi.TabIndex = 7;
        lblDiaChi.Text = "Địa chỉ:";
        // 
        // txtDienThoai
        // 
        txtDienThoai.Location = new Point(115, 130);
        txtDienThoai.Name = "txtDienThoai";
        txtDienThoai.Size = new Size(295, 27);
        txtDienThoai.TabIndex = 6;
        // 
        // lblDienThoai
        // 
        lblDienThoai.AutoSize = true;
        lblDienThoai.Location = new Point(15, 133);
        lblDienThoai.Name = "lblDienThoai";
        lblDienThoai.Size = new Size(81, 20);
        lblDienThoai.TabIndex = 5;
        lblDienThoai.Text = "Điện thoại:";
        // 
        // txtTenKH
        // 
        txtTenKH.Location = new Point(115, 90);
        txtTenKH.Name = "txtTenKH";
        txtTenKH.Size = new Size(295, 27);
        txtTenKH.TabIndex = 4;
        // 
        // lblTenKH
        // 
        lblTenKH.AutoSize = true;
        lblTenKH.Location = new Point(15, 93);
        lblTenKH.Name = "lblTenKH";
        lblTenKH.Size = new Size(81, 20);
        lblTenKH.TabIndex = 3;
        lblTenKH.Text = "Tên chủ xe:";
        // 
        // btnTraCuu
        // 
        btnTraCuu.Location = new Point(325, 30);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new Size(85, 30);
        btnTraCuu.TabIndex = 2;
        btnTraCuu.Text = "Tra cứu";
        btnTraCuu.UseVisualStyleBackColor = true;
        btnTraCuu.Click += btnTraCuu_Click;
        // 
        // txtTraCuuBienSo
        // 
        txtTraCuuBienSo.Location = new Point(115, 31);
        txtTraCuuBienSo.Name = "txtTraCuuBienSo";
        txtTraCuuBienSo.PlaceholderText = "Nhập biển số...";
        txtTraCuuBienSo.Size = new Size(200, 27);
        txtTraCuuBienSo.TabIndex = 1;
        // 
        // lblTraCuu
        // 
        lblTraCuu.AutoSize = true;
        lblTraCuu.Location = new Point(15, 35);
        lblTraCuu.Name = "lblTraCuu";
        lblTraCuu.Size = new Size(93, 20);
        lblTraCuu.TabIndex = 0;
        lblTraCuu.Text = "Tra cứu biển:";
        // 
        // tabLapPhieu
        // 
        tabLapPhieu.Controls.Add(lblTongTienDuKien);
        tabLapPhieu.Controls.Add(btnTaoPhieuSuaChua);
        tabLapPhieu.Controls.Add(grpChiTiet);
        tabLapPhieu.Controls.Add(grpThongTinPhieu);
        tabLapPhieu.Location = new Point(4, 29);
        tabLapPhieu.Name = "tabLapPhieu";
        tabLapPhieu.Padding = new Padding(10);
        tabLapPhieu.Size = new Size(976, 578);
        tabLapPhieu.TabIndex = 1;
        tabLapPhieu.Text = "2. Lập Phiếu Sửa Chữa";
        tabLapPhieu.UseVisualStyleBackColor = true;
        // 
        // lblTongTienDuKien
        // 
        lblTongTienDuKien.AutoSize = true;
        lblTongTienDuKien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTongTienDuKien.ForeColor = Color.DarkRed;
        lblTongTienDuKien.Location = new Point(20, 530);
        lblTongTienDuKien.Name = "lblTongTienDuKien";
        lblTongTienDuKien.Size = new Size(233, 25);
        lblTongTienDuKien.TabIndex = 3;
        lblTongTienDuKien.Text = "Tổng chi phí dự kiến: 0 đ";
        // 
        // btnTaoPhieuSuaChua
        // 
        btnTaoPhieuSuaChua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnTaoPhieuSuaChua.Location = new Point(695, 520);
        btnTaoPhieuSuaChua.Name = "btnTaoPhieuSuaChua";
        btnTaoPhieuSuaChua.Size = new Size(260, 45);
        btnTaoPhieuSuaChua.TabIndex = 2;
        btnTaoPhieuSuaChua.Text = "LẬP PHIẾU (SqlTransaction)";
        btnTaoPhieuSuaChua.UseVisualStyleBackColor = true;
        btnTaoPhieuSuaChua.Click += btnTaoPhieuSuaChua_Click;
        // 
        // grpChiTiet
        // 
        grpChiTiet.Controls.Add(dgvChiTietTam);
        grpChiTiet.Controls.Add(btnXoaChiTiet);
        grpChiTiet.Controls.Add(btnThemChiTiet);
        grpChiTiet.Controls.Add(nudTienCong);
        grpChiTiet.Controls.Add(lblTienCong);
        grpChiTiet.Controls.Add(nudSoLuongThayThe);
        grpChiTiet.Controls.Add(lblSoLuongThayThe);
        grpChiTiet.Controls.Add(cboChonPhuTung);
        grpChiTiet.Controls.Add(lblChonPhuTung);
        grpChiTiet.Location = new Point(10, 140);
        grpChiTiet.Name = "grpChiTiet";
        grpChiTiet.Size = new Size(956, 365);
        grpChiTiet.TabIndex = 1;
        grpChiTiet.TabStop = false;
        grpChiTiet.Text = "Danh sách Phụ tùng thay thế & Tiền công";
        // 
        // dgvChiTietTam
        // 
        dgvChiTietTam.AllowUserToAddRows = false;
        dgvChiTietTam.AllowUserToDeleteRows = false;
        dgvChiTietTam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietTam.Columns.AddRange(new DataGridViewColumn[] { colCT_Ma, colCT_Ten, colCT_SoLuong, colCT_DonGia, colCT_TienCong, colCT_ThanhTien });
        dgvChiTietTam.Location = new Point(15, 80);
        dgvChiTietTam.MultiSelect = false;
        dgvChiTietTam.Name = "dgvChiTietTam";
        dgvChiTietTam.ReadOnly = true;
        dgvChiTietTam.RowHeadersWidth = 51;
        dgvChiTietTam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietTam.Size = new Size(925, 270);
        dgvChiTietTam.TabIndex = 8;
        // 
        // colCT_Ma
        // 
        colCT_Ma.DataPropertyName = "MaPhuTung";
        colCT_Ma.HeaderText = "Mã PT";
        colCT_Ma.MinimumWidth = 6;
        colCT_Ma.Name = "colCT_Ma";
        colCT_Ma.ReadOnly = true;
        colCT_Ma.Width = 80;
        // 
        // colCT_Ten
        // 
        colCT_Ten.DataPropertyName = "TenPhuTung";
        colCT_Ten.HeaderText = "Tên Phụ Tùng";
        colCT_Ten.MinimumWidth = 6;
        colCT_Ten.Name = "colCT_Ten";
        colCT_Ten.ReadOnly = true;
        colCT_Ten.Width = 260;
        // 
        // colCT_SoLuong
        // 
        colCT_SoLuong.DataPropertyName = "SoLuong";
        colCT_SoLuong.HeaderText = "Số Lượng";
        colCT_SoLuong.MinimumWidth = 6;
        colCT_SoLuong.Name = "colCT_SoLuong";
        colCT_SoLuong.ReadOnly = true;
        colCT_SoLuong.Width = 125;
        // 
        // colCT_DonGia
        // 
        colCT_DonGia.DataPropertyName = "DonGia";
        colCT_DonGia.HeaderText = "Đơn Giá";
        colCT_DonGia.MinimumWidth = 6;
        colCT_DonGia.Name = "colCT_DonGia";
        colCT_DonGia.ReadOnly = true;
        colCT_DonGia.Width = 130;
        // 
        // colCT_TienCong
        // 
        colCT_TienCong.DataPropertyName = "TienCong";
        colCT_TienCong.HeaderText = "Tiền Công";
        colCT_TienCong.MinimumWidth = 6;
        colCT_TienCong.Name = "colCT_TienCong";
        colCT_TienCong.ReadOnly = true;
        colCT_TienCong.Width = 130;
        // 
        // colCT_ThanhTien
        // 
        colCT_ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colCT_ThanhTien.DataPropertyName = "ThanhTien";
        colCT_ThanhTien.HeaderText = "Thành Tiền";
        colCT_ThanhTien.MinimumWidth = 6;
        colCT_ThanhTien.Name = "colCT_ThanhTien";
        colCT_ThanhTien.ReadOnly = true;
        // 
        // btnXoaChiTiet
        // 
        btnXoaChiTiet.Location = new Point(830, 27);
        btnXoaChiTiet.Name = "btnXoaChiTiet";
        btnXoaChiTiet.Size = new Size(110, 30);
        btnXoaChiTiet.TabIndex = 7;
        btnXoaChiTiet.Text = "Xóa khỏi phiếu";
        btnXoaChiTiet.UseVisualStyleBackColor = true;
        btnXoaChiTiet.Click += btnXoaChiTiet_Click;
        // 
        // btnThemChiTiet
        // 
        btnThemChiTiet.Location = new Point(710, 27);
        btnThemChiTiet.Name = "btnThemChiTiet";
        btnThemChiTiet.Size = new Size(110, 30);
        btnThemChiTiet.TabIndex = 6;
        btnThemChiTiet.Text = "Thêm vào phiếu";
        btnThemChiTiet.UseVisualStyleBackColor = true;
        btnThemChiTiet.Click += btnThemChiTiet_Click;
        // 
        // nudTienCong
        // 
        nudTienCong.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
        nudTienCong.Location = new Point(570, 29);
        nudTienCong.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
        nudTienCong.Name = "nudTienCong";
        nudTienCong.Size = new Size(125, 27);
        nudTienCong.TabIndex = 5;
        // 
        // lblTienCong
        // 
        lblTienCong.AutoSize = true;
        lblTienCong.Location = new Point(495, 32);
        lblTienCong.Name = "lblTienCong";
        lblTienCong.Size = new Size(77, 20);
        lblTienCong.TabIndex = 4;
        lblTienCong.Text = "Tiền công:";
        // 
        // nudSoLuongThayThe
        // 
        nudSoLuongThayThe.Location = new Point(405, 29);
        nudSoLuongThayThe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuongThayThe.Name = "nudSoLuongThayThe";
        nudSoLuongThayThe.Size = new Size(75, 27);
        nudSoLuongThayThe.TabIndex = 3;
        nudSoLuongThayThe.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblSoLuongThayThe
        // 
        lblSoLuongThayThe.AutoSize = true;
        lblSoLuongThayThe.Location = new Point(335, 32);
        lblSoLuongThayThe.Name = "lblSoLuongThayThe";
        lblSoLuongThayThe.Size = new Size(72, 20);
        lblSoLuongThayThe.TabIndex = 2;
        lblSoLuongThayThe.Text = "Số lượng:";
        // 
        // cboChonPhuTung
        // 
        cboChonPhuTung.DropDownStyle = ComboBoxStyle.DropDownList;
        cboChonPhuTung.FormattingEnabled = true;
        cboChonPhuTung.Location = new Point(85, 28);
        cboChonPhuTung.Name = "cboChonPhuTung";
        cboChonPhuTung.Size = new Size(240, 28);
        cboChonPhuTung.TabIndex = 1;
        // 
        // lblChonPhuTung
        // 
        lblChonPhuTung.AutoSize = true;
        lblChonPhuTung.Location = new Point(15, 32);
        lblChonPhuTung.Name = "lblChonPhuTung";
        lblChonPhuTung.Size = new Size(70, 20);
        lblChonPhuTung.TabIndex = 0;
        lblChonPhuTung.Text = "Phụ tùng:";
        // 
        // grpThongTinPhieu
        // 
        grpThongTinPhieu.Controls.Add(txtNoiDungSua);
        grpThongTinPhieu.Controls.Add(lblNoiDungSua);
        grpThongTinPhieu.Controls.Add(dtpNgayNhan);
        grpThongTinPhieu.Controls.Add(lblNgayNhan);
        grpThongTinPhieu.Controls.Add(cboChonXe);
        grpThongTinPhieu.Controls.Add(lblChonXe);
        grpThongTinPhieu.Location = new Point(10, 10);
        grpThongTinPhieu.Name = "grpThongTinPhieu";
        grpThongTinPhieu.Size = new Size(956, 120);
        grpThongTinPhieu.TabIndex = 0;
        grpThongTinPhieu.TabStop = false;
        grpThongTinPhieu.Text = "Thông tin xe tiếp nhận sửa chữa";
        // 
        // txtNoiDungSua
        // 
        txtNoiDungSua.Location = new Point(120, 75);
        txtNoiDungSua.Name = "txtNoiDungSua";
        txtNoiDungSua.Size = new Size(820, 27);
        txtNoiDungSua.TabIndex = 5;
        // 
        // lblNoiDungSua
        // 
        lblNoiDungSua.AutoSize = true;
        lblNoiDungSua.Location = new Point(15, 78);
        lblNoiDungSua.Name = "lblNoiDungSua";
        lblNoiDungSua.Size = new Size(101, 20);
        lblNoiDungSua.TabIndex = 4;
        lblNoiDungSua.Text = "Nội dung sửa:";
        // 
        // dtpNgayNhan
        // 
        dtpNgayNhan.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpNgayNhan.Format = DateTimePickerFormat.Custom;
        dtpNgayNhan.Location = new Point(570, 30);
        dtpNgayNhan.Name = "dtpNgayNhan";
        dtpNgayNhan.Size = new Size(220, 27);
        dtpNgayNhan.TabIndex = 3;
        // 
        // lblNgayNhan
        // 
        lblNgayNhan.AutoSize = true;
        lblNgayNhan.Location = new Point(485, 33);
        lblNgayNhan.Name = "lblNgayNhan";
        lblNgayNhan.Size = new Size(83, 20);
        lblNgayNhan.TabIndex = 2;
        lblNgayNhan.Text = "Ngày nhận:";
        // 
        // cboChonXe
        // 
        cboChonXe.DropDownStyle = ComboBoxStyle.DropDownList;
        cboChonXe.FormattingEnabled = true;
        cboChonXe.Location = new Point(120, 30);
        cboChonXe.Name = "cboChonXe";
        cboChonXe.Size = new Size(330, 28);
        cboChonXe.TabIndex = 1;
        // 
        // lblChonXe
        // 
        lblChonXe.AutoSize = true;
        lblChonXe.Location = new Point(15, 33);
        lblChonXe.Name = "lblChonXe";
        lblChonXe.Size = new Size(65, 20);
        lblChonXe.TabIndex = 0;
        lblChonXe.Text = "Chọn xe:";
        // 
        // tabThanhToan
        // 
        tabThanhToan.Controls.Add(grpChiTietHD);
        tabThanhToan.Controls.Add(grpPhieuSuaChua);
        tabThanhToan.Location = new Point(4, 29);
        tabThanhToan.Name = "tabThanhToan";
        tabThanhToan.Padding = new Padding(10);
        tabThanhToan.Size = new Size(976, 578);
        tabThanhToan.TabIndex = 2;
        tabThanhToan.Text = "3. Thanh toán & Xuất Hóa đơn";
        tabThanhToan.UseVisualStyleBackColor = true;
        // 
        // grpChiTietHD
        // 
        grpChiTietHD.Controls.Add(btnThanhToan);
        grpChiTietHD.Controls.Add(lblTongThanhToan);
        grpChiTietHD.Controls.Add(dgvChiTietHoaDon);
        grpChiTietHD.Location = new Point(500, 10);
        grpChiTietHD.Name = "grpChiTietHD";
        grpChiTietHD.Size = new Size(465, 555);
        grpChiTietHD.TabIndex = 1;
        grpChiTietHD.TabStop = false;
        grpChiTietHD.Text = "Chi tiết Hóa đơn phiếu sửa chữa đang chọn";
        // 
        // btnThanhToan
        // 
        btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnThanhToan.Location = new Point(15, 495);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new Size(435, 45);
        btnThanhToan.TabIndex = 2;
        btnThanhToan.Text = "THANH TOÁN + XUẤT HÓA ĐƠN";
        btnThanhToan.UseVisualStyleBackColor = true;
        btnThanhToan.Click += btnThanhToan_Click;
        // 
        // lblTongThanhToan
        // 
        lblTongThanhToan.AutoSize = true;
        lblTongThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTongThanhToan.ForeColor = Color.DarkGreen;
        lblTongThanhToan.Location = new Point(15, 455);
        lblTongThanhToan.Name = "lblTongThanhToan";
        lblTongThanhToan.Size = new Size(229, 25);
        lblTongThanhToan.TabIndex = 1;
        lblTongThanhToan.Text = "Tổng thanh toán: 0 VNĐ";
        // 
        // dgvChiTietHoaDon
        // 
        dgvChiTietHoaDon.AllowUserToAddRows = false;
        dgvChiTietHoaDon.AllowUserToDeleteRows = false;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { colHD_Ten, colHD_SoLuong, colHD_DonGia, colHD_TienCong, colHD_ThanhTien });
        dgvChiTietHoaDon.Location = new Point(15, 26);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersWidth = 51;
        dgvChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new Size(435, 410);
        dgvChiTietHoaDon.TabIndex = 0;
        // 
        // colHD_Ten
        // 
        colHD_Ten.DataPropertyName = "TenPhuTung";
        colHD_Ten.HeaderText = "Phụ Tùng";
        colHD_Ten.MinimumWidth = 6;
        colHD_Ten.Name = "colHD_Ten";
        colHD_Ten.ReadOnly = true;
        colHD_Ten.Width = 140;
        // 
        // colHD_SoLuong
        // 
        colHD_SoLuong.DataPropertyName = "SoLuong";
        colHD_SoLuong.HeaderText = "SL";
        colHD_SoLuong.MinimumWidth = 6;
        colHD_SoLuong.Name = "colHD_SoLuong";
        colHD_SoLuong.ReadOnly = true;
        colHD_SoLuong.Width = 50;
        // 
        // colHD_DonGia
        // 
        colHD_DonGia.DataPropertyName = "DonGia";
        colHD_DonGia.HeaderText = "Đơn Giá";
        colHD_DonGia.MinimumWidth = 6;
        colHD_DonGia.Name = "colHD_DonGia";
        colHD_DonGia.ReadOnly = true;
        colHD_DonGia.Width = 90;
        // 
        // colHD_TienCong
        // 
        colHD_TienCong.DataPropertyName = "TienCong";
        colHD_TienCong.HeaderText = "Công";
        colHD_TienCong.MinimumWidth = 6;
        colHD_TienCong.Name = "colHD_TienCong";
        colHD_TienCong.ReadOnly = true;
        colHD_TienCong.Width = 70;
        // 
        // colHD_ThanhTien
        // 
        colHD_ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colHD_ThanhTien.DataPropertyName = "ThanhTien";
        colHD_ThanhTien.HeaderText = "Thành Tiền";
        colHD_ThanhTien.MinimumWidth = 6;
        colHD_ThanhTien.Name = "colHD_ThanhTien";
        colHD_ThanhTien.ReadOnly = true;
        // 
        // grpPhieuSuaChua
        // 
        grpPhieuSuaChua.Controls.Add(dgvPhieuSuaChua);
        grpPhieuSuaChua.Location = new Point(10, 10);
        grpPhieuSuaChua.Name = "grpPhieuSuaChua";
        grpPhieuSuaChua.Size = new Size(475, 555);
        grpPhieuSuaChua.TabIndex = 0;
        grpPhieuSuaChua.TabStop = false;
        grpPhieuSuaChua.Text = "Danh sách Phiếu sửa chữa";
        // 
        // dgvPhieuSuaChua
        // 
        dgvPhieuSuaChua.AllowUserToAddRows = false;
        dgvPhieuSuaChua.AllowUserToDeleteRows = false;
        dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPhieuSuaChua.Columns.AddRange(new DataGridViewColumn[] { colPSC_Ma, colPSC_BienSo, colPSC_TenKH, colPSC_NgayNhan, colPSC_TongTien, colPSC_TrangThai });
        dgvPhieuSuaChua.Location = new Point(15, 26);
        dgvPhieuSuaChua.MultiSelect = false;
        dgvPhieuSuaChua.Name = "dgvPhieuSuaChua";
        dgvPhieuSuaChua.ReadOnly = true;
        dgvPhieuSuaChua.RowHeadersWidth = 51;
        dgvPhieuSuaChua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPhieuSuaChua.Size = new Size(445, 515);
        dgvPhieuSuaChua.TabIndex = 0;
        dgvPhieuSuaChua.SelectionChanged += dgvPhieuSuaChua_SelectionChanged;
        // 
        // colPSC_Ma
        // 
        colPSC_Ma.DataPropertyName = "MaPhieu";
        colPSC_Ma.HeaderText = "Mã";
        colPSC_Ma.MinimumWidth = 6;
        colPSC_Ma.Name = "colPSC_Ma";
        colPSC_Ma.ReadOnly = true;
        colPSC_Ma.Width = 50;
        // 
        // colPSC_BienSo
        // 
        colPSC_BienSo.DataPropertyName = "BienSo";
        colPSC_BienSo.HeaderText = "Biển Số";
        colPSC_BienSo.MinimumWidth = 6;
        colPSC_BienSo.Name = "colPSC_BienSo";
        colPSC_BienSo.ReadOnly = true;
        colPSC_BienSo.Width = 90;
        // 
        // colPSC_TenKH
        // 
        colPSC_TenKH.DataPropertyName = "TenKH";
        colPSC_TenKH.HeaderText = "Chủ Xe";
        colPSC_TenKH.MinimumWidth = 6;
        colPSC_TenKH.Name = "colPSC_TenKH";
        colPSC_TenKH.ReadOnly = true;
        colPSC_TenKH.Width = 125;
        // 
        // colPSC_NgayNhan
        // 
        colPSC_NgayNhan.DataPropertyName = "NgayNhan";
        colPSC_NgayNhan.HeaderText = "Ngày";
        colPSC_NgayNhan.MinimumWidth = 6;
        colPSC_NgayNhan.Name = "colPSC_NgayNhan";
        colPSC_NgayNhan.ReadOnly = true;
        colPSC_NgayNhan.Width = 80;
        // 
        // colPSC_TongTien
        // 
        colPSC_TongTien.DataPropertyName = "TongTien";
        colPSC_TongTien.HeaderText = "Tổng Tiền";
        colPSC_TongTien.MinimumWidth = 6;
        colPSC_TongTien.Name = "colPSC_TongTien";
        colPSC_TongTien.ReadOnly = true;
        colPSC_TongTien.Width = 90;
        // 
        // colPSC_TrangThai
        // 
        colPSC_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPSC_TrangThai.DataPropertyName = "TrangThai";
        colPSC_TrangThai.HeaderText = "Trạng Thái";
        colPSC_TrangThai.MinimumWidth = 6;
        colPSC_TrangThai.Name = "colPSC_TrangThai";
        colPSC_TrangThai.ReadOnly = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(984, 611);
        Controls.Add(tabMain);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hệ thống Quản lý Garage & Bảo dưỡng Ô tô";
        Load += MainForm_Load;
        tabMain.ResumeLayout(false);
        tabTiepNhan.ResumeLayout(false);
        grpPhuTung.ResumeLayout(false);
        grpPhuTung.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhuTung).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
        grpXe.ResumeLayout(false);
        grpXe.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudNamSanXuat).EndInit();
        tabLapPhieu.ResumeLayout(false);
        tabLapPhieu.PerformLayout();
        grpChiTiet.ResumeLayout(false);
        grpChiTiet.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietTam).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTienCong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongThayThe).EndInit();
        grpThongTinPhieu.ResumeLayout(false);
        grpThongTinPhieu.PerformLayout();
        tabThanhToan.ResumeLayout(false);
        grpChiTietHD.ResumeLayout(false);
        grpChiTietHD.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        grpPhieuSuaChua.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPhieuSuaChua).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabMain;
    private TabPage tabTiepNhan;
    private TabPage tabLapPhieu;
    private TabPage tabThanhToan;
    private GroupBox grpXe;
    private Label lblTraCuu;
    private TextBox txtTraCuuBienSo;
    private Button btnTraCuu;
    private Label lblTenKH;
    private TextBox txtTenKH;
    private Label lblDienThoai;
    private TextBox txtDienThoai;
    private Label lblDiaChi;
    private TextBox txtDiaChi;
    private Label lblBienSo;
    private TextBox txtBienSo;
    private Label lblHieuXe;
    private ComboBox cboHieuXe;
    private Label lblNamSX;
    private NumericUpDown nudNamSanXuat;
    private Button btnLuuXeMoi;
    private GroupBox grpPhuTung;
    private Label lblTenPhuTung;
    private TextBox txtTenPhuTung;
    private Label lblDonGia;
    private NumericUpDown nudDonGia;
    private Label lblTon;
    private NumericUpDown nudSoLuongTon;
    private Button btnThemPhuTung;
    private Button btnCapNhatPhuTung;
    private DataGridView dgvPhuTung;
    private DataGridViewTextBoxColumn colPT_Ma;
    private DataGridViewTextBoxColumn colPT_Ten;
    private DataGridViewTextBoxColumn colPT_DonGia;
    private DataGridViewTextBoxColumn colPT_Ton;
    private GroupBox grpThongTinPhieu;
    private Label lblChonXe;
    private ComboBox cboChonXe;
    private Label lblNgayNhan;
    private DateTimePicker dtpNgayNhan;
    private Label lblNoiDungSua;
    private TextBox txtNoiDungSua;
    private GroupBox grpChiTiet;
    private Label lblChonPhuTung;
    private ComboBox cboChonPhuTung;
    private Label lblSoLuongThayThe;
    private NumericUpDown nudSoLuongThayThe;
    private Label lblTienCong;
    private NumericUpDown nudTienCong;
    private Button btnThemChiTiet;
    private Button btnXoaChiTiet;
    private DataGridView dgvChiTietTam;
    private DataGridViewTextBoxColumn colCT_Ma;
    private DataGridViewTextBoxColumn colCT_Ten;
    private DataGridViewTextBoxColumn colCT_SoLuong;
    private DataGridViewTextBoxColumn colCT_DonGia;
    private DataGridViewTextBoxColumn colCT_TienCong;
    private DataGridViewTextBoxColumn colCT_ThanhTien;
    private Button btnTaoPhieuSuaChua;
    private Label lblTongTienDuKien;
    private GroupBox grpPhieuSuaChua;
    private DataGridView dgvPhieuSuaChua;
    private DataGridViewTextBoxColumn colPSC_Ma;
    private DataGridViewTextBoxColumn colPSC_BienSo;
    private DataGridViewTextBoxColumn colPSC_TenKH;
    private DataGridViewTextBoxColumn colPSC_NgayNhan;
    private DataGridViewTextBoxColumn colPSC_TongTien;
    private DataGridViewTextBoxColumn colPSC_TrangThai;
    private GroupBox grpChiTietHD;
    private DataGridView dgvChiTietHoaDon;
    private DataGridViewTextBoxColumn colHD_Ten;
    private DataGridViewTextBoxColumn colHD_SoLuong;
    private DataGridViewTextBoxColumn colHD_DonGia;
    private DataGridViewTextBoxColumn colHD_TienCong;
    private DataGridViewTextBoxColumn colHD_ThanhTien;
    private Label lblTongThanhToan;
    private Button btnThanhToan;
}


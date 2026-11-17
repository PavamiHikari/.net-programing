#nullable disable

namespace HRMManagement.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabNhanSu = new TabPage();
            pnlNhanSuCenter = new Panel();
            dgvNhanVien = new DataGridView();
            pnlNhanSuTop = new Panel();
            lblTimKiem = new Label();
            txtTimKiemNV = new TextBox();
            lblLocPB = new Label();
            cboLocPhongBan = new ComboBox();
            btnTimKiemNV = new Button();
            btnTatCaNV = new Button();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblPB = new Label();
            cboPhongBan = new ComboBox();
            lblLuongCB = new Label();
            numLuongCoBan = new NumericUpDown();
            lblHeSo = new Label();
            numHeSoLuong = new NumericUpDown();
            btnThemNV = new Button();
            btnSuaNV = new Button();
            btnXoaNV = new Button();
            btnLamMoiNV = new Button();
            lblChuyen = new Label();
            cboChuyenPB = new ComboBox();
            btnChuyenPB = new Button();
            tabChamCong = new TabPage();
            pnlChamCongCenter = new Panel();
            dgvChamCong = new DataGridView();
            pnlChamCongTop = new Panel();
            lblThangChamCong = new Label();
            dtpThangNamChamCong = new DateTimePicker();
            btnTaiChamCong = new Button();
            btnLuuChamCong = new Button();
            lblTrangThaiChamCong = new Label();
            tabLuong = new TabPage();
            pnlLuongCenter = new Panel();
            dgvBangLuong = new DataGridView();
            pnlLuongTop = new Panel();
            lblThangLuong = new Label();
            dtpThangNamLuong = new DateTimePicker();
            btnTinhLuong = new Button();
            btnChotLuong = new Button();
            pnlLuongBottom = new Panel();
            lblTongQuyLuong = new Label();
            txtNhatKyLuong = new TextBox();
            tabMain.SuspendLayout();
            tabNhanSu.SuspendLayout();
            pnlNhanSuCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            pnlNhanSuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLuongCoBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).BeginInit();
            tabChamCong.SuspendLayout();
            pnlChamCongCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            pnlChamCongTop.SuspendLayout();
            tabLuong.SuspendLayout();
            pnlLuongCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).BeginInit();
            pnlLuongTop.SuspendLayout();
            pnlLuongBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabNhanSu);
            tabMain.Controls.Add(tabChamCong);
            tabMain.Controls.Add(tabLuong);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Font = new Font("Segoe UI", 9.5F);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1082, 720);
            tabMain.TabIndex = 0;
            // 
            // tabNhanSu
            // 
            tabNhanSu.Controls.Add(pnlNhanSuCenter);
            tabNhanSu.Controls.Add(pnlNhanSuTop);
            tabNhanSu.Location = new Point(4, 30);
            tabNhanSu.Name = "tabNhanSu";
            tabNhanSu.Padding = new Padding(8);
            tabNhanSu.Size = new Size(1074, 686);
            tabNhanSu.TabIndex = 0;
            tabNhanSu.Text = "  1. Quản lý Nhân sự (3-Tier CRUD)  ";
            tabNhanSu.UseVisualStyleBackColor = true;
            // 
            // pnlNhanSuCenter
            // 
            pnlNhanSuCenter.Controls.Add(dgvNhanVien);
            pnlNhanSuCenter.Dock = DockStyle.Fill;
            pnlNhanSuCenter.Location = new Point(8, 183);
            pnlNhanSuCenter.Name = "pnlNhanSuCenter";
            pnlNhanSuCenter.Padding = new Padding(0, 8, 0, 0);
            pnlNhanSuCenter.Size = new Size(1058, 495);
            pnlNhanSuCenter.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 8);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1058, 487);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;
            // 
            // pnlNhanSuTop
            // 
            pnlNhanSuTop.BackColor = Color.FromArgb(248, 249, 250);
            pnlNhanSuTop.Controls.Add(lblTimKiem);
            pnlNhanSuTop.Controls.Add(txtTimKiemNV);
            pnlNhanSuTop.Controls.Add(lblLocPB);
            pnlNhanSuTop.Controls.Add(cboLocPhongBan);
            pnlNhanSuTop.Controls.Add(btnTimKiemNV);
            pnlNhanSuTop.Controls.Add(btnTatCaNV);
            pnlNhanSuTop.Controls.Add(lblMaNV);
            pnlNhanSuTop.Controls.Add(txtMaNV);
            pnlNhanSuTop.Controls.Add(lblHoTen);
            pnlNhanSuTop.Controls.Add(txtHoTen);
            pnlNhanSuTop.Controls.Add(lblNgaySinh);
            pnlNhanSuTop.Controls.Add(dtpNgaySinh);
            pnlNhanSuTop.Controls.Add(lblCCCD);
            pnlNhanSuTop.Controls.Add(txtCCCD);
            pnlNhanSuTop.Controls.Add(lblPB);
            pnlNhanSuTop.Controls.Add(cboPhongBan);
            pnlNhanSuTop.Controls.Add(lblLuongCB);
            pnlNhanSuTop.Controls.Add(numLuongCoBan);
            pnlNhanSuTop.Controls.Add(lblHeSo);
            pnlNhanSuTop.Controls.Add(numHeSoLuong);
            pnlNhanSuTop.Controls.Add(btnThemNV);
            pnlNhanSuTop.Controls.Add(btnSuaNV);
            pnlNhanSuTop.Controls.Add(btnXoaNV);
            pnlNhanSuTop.Controls.Add(btnLamMoiNV);
            pnlNhanSuTop.Controls.Add(lblChuyen);
            pnlNhanSuTop.Controls.Add(cboChuyenPB);
            pnlNhanSuTop.Controls.Add(btnChuyenPB);
            pnlNhanSuTop.Dock = DockStyle.Top;
            pnlNhanSuTop.Location = new Point(8, 8);
            pnlNhanSuTop.Name = "pnlNhanSuTop";
            pnlNhanSuTop.Size = new Size(1058, 175);
            pnlNhanSuTop.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimKiem.Location = new Point(15, 12);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(164, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm (Tên/CCCD):";
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Location = new Point(183, 9);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(170, 29);
            txtTimKiemNV.TabIndex = 1;
            // 
            // lblLocPB
            // 
            lblLocPB.AutoSize = true;
            lblLocPB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocPB.Location = new Point(368, 12);
            lblLocPB.Name = "lblLocPB";
            lblLocPB.Size = new Size(88, 20);
            lblLocPB.TabIndex = 2;
            lblLocPB.Text = "Phòng ban:";
            // 
            // cboLocPhongBan
            // 
            cboLocPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocPhongBan.FormattingEnabled = true;
            cboLocPhongBan.Location = new Point(456, 9);
            cboLocPhongBan.Name = "cboLocPhongBan";
            cboLocPhongBan.Size = new Size(180, 29);
            cboLocPhongBan.TabIndex = 3;
            // 
            // btnTimKiemNV
            // 
            btnTimKiemNV.Location = new Point(646, 7);
            btnTimKiemNV.Name = "btnTimKiemNV";
            btnTimKiemNV.Size = new Size(180, 28);
            btnTimKiemNV.TabIndex = 4;
            btnTimKiemNV.Text = "Tìm kiếm (Parameterized)";
            btnTimKiemNV.UseVisualStyleBackColor = true;
            btnTimKiemNV.Click += BtnTimKiemNV_Click;
            // 
            // btnTatCaNV
            // 
            btnTatCaNV.Location = new Point(836, 7);
            btnTatCaNV.Name = "btnTatCaNV";
            btnTatCaNV.Size = new Size(80, 28);
            btnTatCaNV.TabIndex = 5;
            btnTatCaNV.Text = "Tất cả";
            btnTatCaNV.UseVisualStyleBackColor = true;
            btnTatCaNV.Click += BtnTatCaNV_Click;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(15, 52);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(61, 21);
            lblMaNV.TabIndex = 6;
            lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = Color.WhiteSmoke;
            txtMaNV.Location = new Point(78, 49);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(60, 29);
            txtMaNV.TabIndex = 7;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(148, 52);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 21);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(211, 49);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(160, 29);
            txtHoTen.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(381, 52);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(83, 21);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(467, 49);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(120, 29);
            dtpNgaySinh.TabIndex = 11;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(597, 52);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(54, 21);
            lblCCCD.TabIndex = 12;
            lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(656, 48);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(130, 29);
            txtCCCD.TabIndex = 13;
            // 
            // lblPB
            // 
            lblPB.AutoSize = true;
            lblPB.Location = new Point(792, 48);
            lblPB.Name = "lblPB";
            lblPB.Size = new Size(88, 21);
            lblPB.TabIndex = 14;
            lblPB.Text = "Phòng ban:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(888, 48);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(160, 29);
            cboPhongBan.TabIndex = 15;
            // 
            // lblLuongCB
            // 
            lblLuongCB.AutoSize = true;
            lblLuongCB.Location = new Point(15, 92);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(81, 21);
            lblLuongCB.TabIndex = 16;
            lblLuongCB.Text = "Lương CB:";
            // 
            // numLuongCoBan
            // 
            numLuongCoBan.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            numLuongCoBan.Location = new Point(96, 89);
            numLuongCoBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numLuongCoBan.Name = "numLuongCoBan";
            numLuongCoBan.Size = new Size(140, 29);
            numLuongCoBan.TabIndex = 17;
            numLuongCoBan.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // lblHeSo
            // 
            lblHeSo.AutoSize = true;
            lblHeSo.Location = new Point(246, 92);
            lblHeSo.Name = "lblHeSo";
            lblHeSo.Size = new Size(97, 21);
            lblHeSo.TabIndex = 18;
            lblHeSo.Text = "Hệ số lương:";
            // 
            // numHeSoLuong
            // 
            numHeSoLuong.DecimalPlaces = 2;
            numHeSoLuong.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numHeSoLuong.Location = new Point(344, 89);
            numHeSoLuong.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numHeSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numHeSoLuong.Name = "numHeSoLuong";
            numHeSoLuong.Size = new Size(70, 29);
            numHeSoLuong.TabIndex = 19;
            numHeSoLuong.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.LightSteelBlue;
            btnThemNV.FlatStyle = FlatStyle.Flat;
            btnThemNV.Location = new Point(429, 87);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(85, 28);
            btnThemNV.TabIndex = 20;
            btnThemNV.Text = "Thêm mới";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += BtnThemNV_Click;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Location = new Point(519, 87);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(85, 28);
            btnSuaNV.TabIndex = 21;
            btnSuaNV.Text = "Cập nhật";
            btnSuaNV.UseVisualStyleBackColor = true;
            btnSuaNV.Click += BtnSuaNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.Location = new Point(609, 87);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(80, 28);
            btnXoaNV.TabIndex = 22;
            btnXoaNV.Text = "Xóa";
            btnXoaNV.UseVisualStyleBackColor = true;
            btnXoaNV.Click += BtnXoaNV_Click;
            // 
            // btnLamMoiNV
            // 
            btnLamMoiNV.Location = new Point(693, 87);
            btnLamMoiNV.Name = "btnLamMoiNV";
            btnLamMoiNV.Size = new Size(80, 28);
            btnLamMoiNV.TabIndex = 23;
            btnLamMoiNV.Text = "Làm mới";
            btnLamMoiNV.UseVisualStyleBackColor = true;
            btnLamMoiNV.Click += BtnLamMoiNV_Click;
            // 
            // lblChuyen
            // 
            lblChuyen.AutoSize = true;
            lblChuyen.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblChuyen.Location = new Point(15, 135);
            lblChuyen.Name = "lblChuyen";
            lblChuyen.Size = new Size(116, 20);
            lblChuyen.TabIndex = 24;
            lblChuyen.Text = "Chuyển sang PB:";
            // 
            // cboChuyenPB
            // 
            cboChuyenPB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChuyenPB.FormattingEnabled = true;
            cboChuyenPB.Location = new Point(136, 132);
            cboChuyenPB.Name = "cboChuyenPB";
            cboChuyenPB.Size = new Size(180, 29);
            cboChuyenPB.TabIndex = 25;
            // 
            // btnChuyenPB
            // 
            btnChuyenPB.BackColor = Color.Moccasin;
            btnChuyenPB.FlatStyle = FlatStyle.Flat;
            btnChuyenPB.Location = new Point(326, 130);
            btnChuyenPB.Name = "btnChuyenPB";
            btnChuyenPB.Size = new Size(150, 28);
            btnChuyenPB.TabIndex = 26;
            btnChuyenPB.Text = "Xác nhận chuyển PB";
            btnChuyenPB.UseVisualStyleBackColor = false;
            btnChuyenPB.Click += BtnChuyenPB_Click;
            // 
            // tabChamCong
            // 
            tabChamCong.Controls.Add(pnlChamCongCenter);
            tabChamCong.Controls.Add(pnlChamCongTop);
            tabChamCong.Location = new Point(4, 30);
            tabChamCong.Name = "tabChamCong";
            tabChamCong.Padding = new Padding(8);
            tabChamCong.Size = new Size(1074, 686);
            tabChamCong.TabIndex = 1;
            tabChamCong.Text = "  2. Chấm công ngắt kết nối (Disconnected Model)  ";
            tabChamCong.UseVisualStyleBackColor = true;
            // 
            // pnlChamCongCenter
            // 
            pnlChamCongCenter.Controls.Add(dgvChamCong);
            pnlChamCongCenter.Dock = DockStyle.Fill;
            pnlChamCongCenter.Location = new Point(8, 83);
            pnlChamCongCenter.Name = "pnlChamCongCenter";
            pnlChamCongCenter.Padding = new Padding(0, 10, 0, 10);
            pnlChamCongCenter.Size = new Size(1058, 595);
            pnlChamCongCenter.TabIndex = 1;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.BackgroundColor = Color.White;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Dock = DockStyle.Fill;
            dgvChamCong.Location = new Point(0, 10);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(1058, 575);
            dgvChamCong.TabIndex = 0;
            // 
            // pnlChamCongTop
            // 
            pnlChamCongTop.BackColor = Color.FromArgb(245, 247, 250);
            pnlChamCongTop.Controls.Add(lblThangChamCong);
            pnlChamCongTop.Controls.Add(dtpThangNamChamCong);
            pnlChamCongTop.Controls.Add(btnTaiChamCong);
            pnlChamCongTop.Controls.Add(btnLuuChamCong);
            pnlChamCongTop.Controls.Add(lblTrangThaiChamCong);
            pnlChamCongTop.Dock = DockStyle.Top;
            pnlChamCongTop.Location = new Point(8, 8);
            pnlChamCongTop.Name = "pnlChamCongTop";
            pnlChamCongTop.Size = new Size(1058, 75);
            pnlChamCongTop.TabIndex = 0;
            // 
            // lblThangChamCong
            // 
            lblThangChamCong.AutoSize = true;
            lblThangChamCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblThangChamCong.Location = new Point(15, 25);
            lblThangChamCong.Name = "lblThangChamCong";
            lblThangChamCong.Size = new Size(99, 21);
            lblThangChamCong.TabIndex = 0;
            lblThangChamCong.Text = "Chọn Ngày:";
            lblThangChamCong.Click += lblThangChamCong_Click;
            // 
            // dtpThangNamChamCong
            // 
            dtpThangNamChamCong.CustomFormat = "MM/yyyy";
            dtpThangNamChamCong.Format = DateTimePickerFormat.Custom;
            dtpThangNamChamCong.Location = new Point(120, 22);
            dtpThangNamChamCong.Name = "dtpThangNamChamCong";
            dtpThangNamChamCong.Size = new Size(128, 29);
            dtpThangNamChamCong.TabIndex = 1;
            dtpThangNamChamCong.Value = new DateTime(2026, 11, 1, 0, 0, 0, 0);
            // 
            // btnTaiChamCong
            // 
            btnTaiChamCong.BackColor = Color.SteelBlue;
            btnTaiChamCong.FlatStyle = FlatStyle.Flat;
            btnTaiChamCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiChamCong.ForeColor = Color.White;
            btnTaiChamCong.Location = new Point(270, 19);
            btnTaiChamCong.Name = "btnTaiChamCong";
            btnTaiChamCong.Size = new Size(260, 32);
            btnTaiChamCong.TabIndex = 2;
            btnTaiChamCong.Text = "Tải bảng chấm công (SqlDataAdapter)";
            btnTaiChamCong.UseVisualStyleBackColor = false;
            btnTaiChamCong.Click += BtnTaiChamCong_Click;
            // 
            // btnLuuChamCong
            // 
            btnLuuChamCong.BackColor = Color.ForestGreen;
            btnLuuChamCong.FlatStyle = FlatStyle.Flat;
            btnLuuChamCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuuChamCong.ForeColor = Color.White;
            btnLuuChamCong.Location = new Point(545, 19);
            btnLuuChamCong.Name = "btnLuuChamCong";
            btnLuuChamCong.Size = new Size(360, 32);
            btnLuuChamCong.TabIndex = 3;
            btnLuuChamCong.Text = "Lưu chấm công (SqlCommandBuilder & adapter.Update)";
            btnLuuChamCong.UseVisualStyleBackColor = false;
            btnLuuChamCong.Click += BtnLuuChamCong_Click;
            // 
            // lblTrangThaiChamCong
            // 
            lblTrangThaiChamCong.AutoSize = true;
            lblTrangThaiChamCong.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTrangThaiChamCong.Location = new Point(915, 26);
            lblTrangThaiChamCong.Name = "lblTrangThaiChamCong";
            lblTrangThaiChamCong.Size = new Size(138, 20);
            lblTrangThaiChamCong.TabIndex = 4;
            lblTrangThaiChamCong.Text = "Trạng thái: Chưa tải";
            // 
            // tabLuong
            // 
            tabLuong.Controls.Add(pnlLuongCenter);
            tabLuong.Controls.Add(pnlLuongTop);
            tabLuong.Controls.Add(pnlLuongBottom);
            tabLuong.Location = new Point(4, 30);
            tabLuong.Name = "tabLuong";
            tabLuong.Padding = new Padding(8);
            tabLuong.Size = new Size(1074, 686);
            tabLuong.TabIndex = 2;
            tabLuong.Text = "  3. Tính Lương & Chốt Lương (SqlTransaction)  ";
            tabLuong.UseVisualStyleBackColor = true;
            // 
            // pnlLuongCenter
            // 
            pnlLuongCenter.Controls.Add(dgvBangLuong);
            pnlLuongCenter.Dock = DockStyle.Fill;
            pnlLuongCenter.Location = new Point(8, 88);
            pnlLuongCenter.Name = "pnlLuongCenter";
            pnlLuongCenter.Padding = new Padding(0, 10, 0, 10);
            pnlLuongCenter.Size = new Size(1058, 460);
            pnlLuongCenter.TabIndex = 2;
            // 
            // dgvBangLuong
            // 
            dgvBangLuong.AllowUserToAddRows = false;
            dgvBangLuong.AllowUserToDeleteRows = false;
            dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangLuong.BackgroundColor = Color.White;
            dgvBangLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangLuong.Dock = DockStyle.Fill;
            dgvBangLuong.Location = new Point(0, 10);
            dgvBangLuong.MultiSelect = false;
            dgvBangLuong.Name = "dgvBangLuong";
            dgvBangLuong.ReadOnly = true;
            dgvBangLuong.RowHeadersWidth = 51;
            dgvBangLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBangLuong.Size = new Size(1058, 440);
            dgvBangLuong.TabIndex = 0;
            // 
            // pnlLuongTop
            // 
            pnlLuongTop.BackColor = Color.FromArgb(245, 247, 250);
            pnlLuongTop.Controls.Add(lblThangLuong);
            pnlLuongTop.Controls.Add(dtpThangNamLuong);
            pnlLuongTop.Controls.Add(btnTinhLuong);
            pnlLuongTop.Controls.Add(btnChotLuong);
            pnlLuongTop.Dock = DockStyle.Top;
            pnlLuongTop.Location = new Point(8, 8);
            pnlLuongTop.Name = "pnlLuongTop";
            pnlLuongTop.Size = new Size(1058, 80);
            pnlLuongTop.TabIndex = 0;
            // 
            // lblThangLuong
            // 
            lblThangLuong.AutoSize = true;
            lblThangLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblThangLuong.Location = new Point(15, 25);
            lblThangLuong.Name = "lblThangLuong";
            lblThangLuong.Size = new Size(191, 21);
            lblThangLuong.TabIndex = 0;
            lblThangLuong.Text = "Tháng/Năm tính lương:";
            // 
            // dtpThangNamLuong
            // 
            dtpThangNamLuong.CustomFormat = "MM/yyyy";
            dtpThangNamLuong.Format = DateTimePickerFormat.Custom;
            dtpThangNamLuong.Location = new Point(175, 22);
            dtpThangNamLuong.Name = "dtpThangNamLuong";
            dtpThangNamLuong.Size = new Size(110, 29);
            dtpThangNamLuong.TabIndex = 1;
            dtpThangNamLuong.Value = new DateTime(2026, 11, 1, 0, 0, 0, 0);
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.SteelBlue;
            btnTinhLuong.FlatStyle = FlatStyle.Flat;
            btnTinhLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTinhLuong.ForeColor = Color.White;
            btnTinhLuong.Location = new Point(300, 19);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(200, 32);
            btnTinhLuong.TabIndex = 2;
            btnTinhLuong.Text = "Tính & Xem trước lương";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += BtnTinhLuong_Click;
            // 
            // btnChotLuong
            // 
            btnChotLuong.BackColor = Color.Crimson;
            btnChotLuong.FlatStyle = FlatStyle.Flat;
            btnChotLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChotLuong.ForeColor = Color.White;
            btnChotLuong.Location = new Point(515, 19);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(300, 32);
            btnChotLuong.TabIndex = 3;
            btnChotLuong.Text = "CHỐT LƯƠNG THÁNG (SqlTransaction)";
            btnChotLuong.UseVisualStyleBackColor = false;
            btnChotLuong.Click += BtnChotLuong_Click;
            // 
            // pnlLuongBottom
            // 
            pnlLuongBottom.BackColor = Color.FromArgb(240, 243, 246);
            pnlLuongBottom.Controls.Add(lblTongQuyLuong);
            pnlLuongBottom.Controls.Add(txtNhatKyLuong);
            pnlLuongBottom.Dock = DockStyle.Bottom;
            pnlLuongBottom.Location = new Point(8, 548);
            pnlLuongBottom.Name = "pnlLuongBottom";
            pnlLuongBottom.Size = new Size(1058, 130);
            pnlLuongBottom.TabIndex = 1;
            // 
            // lblTongQuyLuong
            // 
            lblTongQuyLuong.AutoSize = true;
            lblTongQuyLuong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongQuyLuong.ForeColor = Color.DarkGreen;
            lblTongQuyLuong.Location = new Point(15, 12);
            lblTongQuyLuong.Name = "lblTongQuyLuong";
            lblTongQuyLuong.Size = new Size(278, 25);
            lblTongQuyLuong.TabIndex = 0;
            lblTongQuyLuong.Text = "Tổng quỹ lương thực lĩnh: 0 đ";
            // 
            // txtNhatKyLuong
            // 
            txtNhatKyLuong.BackColor = Color.FromArgb(235, 240, 245);
            txtNhatKyLuong.Font = new Font("Consolas", 9F);
            txtNhatKyLuong.Location = new Point(15, 45);
            txtNhatKyLuong.Multiline = true;
            txtNhatKyLuong.Name = "txtNhatKyLuong";
            txtNhatKyLuong.ReadOnly = true;
            txtNhatKyLuong.Size = new Size(970, 70);
            txtNhatKyLuong.TabIndex = 1;
            txtNhatKyLuong.Text = "Công thức: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)\r\nKhi ấn Chốt lương: Mở SqlTransaction ghi vào BangLuong và cập nhật BangChamCong (DaKhoa = 1).";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 720);
            Controls.Add(tabMain);
            Font = new Font("Segoe UI", 9F);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Nhân Sự";
            Load += MainForm_Load;
            tabMain.ResumeLayout(false);
            tabNhanSu.ResumeLayout(false);
            pnlNhanSuCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            pnlNhanSuTop.ResumeLayout(false);
            pnlNhanSuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLuongCoBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).EndInit();
            tabChamCong.ResumeLayout(false);
            pnlChamCongCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            pnlChamCongTop.ResumeLayout(false);
            pnlChamCongTop.PerformLayout();
            tabLuong.ResumeLayout(false);
            pnlLuongCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).EndInit();
            pnlLuongTop.ResumeLayout(false);
            pnlLuongTop.PerformLayout();
            pnlLuongBottom.ResumeLayout(false);
            pnlLuongBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNhanSu;
        private System.Windows.Forms.Panel pnlNhanSuTop;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Label lblLocPB;
        private System.Windows.Forms.ComboBox cboLocPhongBan;
        private System.Windows.Forms.Button btnTimKiemNV;
        private System.Windows.Forms.Button btnTatCaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblLuongCB;
        private System.Windows.Forms.NumericUpDown numLuongCoBan;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.NumericUpDown numHeSoLuong;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.ComboBox cboChuyenPB;
        private System.Windows.Forms.Button btnChuyenPB;
        private System.Windows.Forms.Panel pnlNhanSuCenter;
        private System.Windows.Forms.DataGridView dgvNhanVien;

        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.Panel pnlChamCongTop;
        private System.Windows.Forms.Label lblThangChamCong;
        private System.Windows.Forms.DateTimePicker dtpThangNamChamCong;
        private System.Windows.Forms.Button btnTaiChamCong;
        private System.Windows.Forms.Button btnLuuChamCong;
        private System.Windows.Forms.Label lblTrangThaiChamCong;
        private System.Windows.Forms.Panel pnlChamCongCenter;
        private System.Windows.Forms.DataGridView dgvChamCong;

        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.Panel pnlLuongTop;
        private System.Windows.Forms.Label lblThangLuong;
        private System.Windows.Forms.DateTimePicker dtpThangNamLuong;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnChotLuong;
        private System.Windows.Forms.Panel pnlLuongCenter;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Panel pnlLuongBottom;
        private System.Windows.Forms.Label lblTongQuyLuong;
        private System.Windows.Forms.TextBox txtNhatKyLuong;
    }
}

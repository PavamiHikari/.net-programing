namespace ProjectTaskManagement.GUI;

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
        tabDuAnTask = new TabPage();
        grpTask = new GroupBox();
        dgvTask = new DataGridView();
        colTask_Ma = new DataGridViewTextBoxColumn();
        colTask_Ten = new DataGridViewTextBoxColumn();
        colTask_HanNop = new DataGridViewTextBoxColumn();
        colTask_UuTien = new DataGridViewTextBoxColumn();
        colTask_TrangThai = new DataGridViewTextBoxColumn();
        btnXoaTask = new Button();
        btnThemTask = new Button();
        cboTrangThaiTask = new ComboBox();
        lblTrangThaiTask = new Label();
        cboDoUuTien = new ComboBox();
        lblDoUuTien = new Label();
        dtpHanNop = new DateTimePicker();
        lblHanNop = new Label();
        txtMoTa = new TextBox();
        lblMoTa = new Label();
        txtTenTask = new TextBox();
        lblTenTask = new Label();
        grpDuAn = new GroupBox();
        dgvDuAn = new DataGridView();
        colDuAn_Ma = new DataGridViewTextBoxColumn();
        colDuAn_Ten = new DataGridViewTextBoxColumn();
        colDuAn_BatDau = new DataGridViewTextBoxColumn();
        colDuAn_KetThuc = new DataGridViewTextBoxColumn();
        colDuAn_TrangThai = new DataGridViewTextBoxColumn();
        btnXoaDuAn = new Button();
        btnSuaDuAn = new Button();
        btnThemDuAn = new Button();
        cboTrangThaiDuAn = new ComboBox();
        lblTrangThaiDuAn = new Label();
        dtpNgayKetThuc = new DateTimePicker();
        lblNgayKetThuc = new Label();
        dtpNgayBatDau = new DateTimePicker();
        lblNgayBatDau = new Label();
        txtTenDuAn = new TextBox();
        lblTenDuAn = new Label();
        tabTienDoPhanCong = new TabPage();
        grpPhanCong = new GroupBox();
        dgvPhanCong = new DataGridView();
        colPC_MaTask = new DataGridViewTextBoxColumn();
        colPC_TenTask = new DataGridViewTextBoxColumn();
        colPC_HoTen = new DataGridViewTextBoxColumn();
        colPC_NgayGiao = new DataGridViewTextBoxColumn();
        btnHuyPhanCong = new Button();
        btnPhanCong = new Button();
        cboThanhVien = new ComboBox();
        lblChonThanhVien = new Label();
        grpTienDo = new GroupBox();
        dgvTienDoTask = new DataGridView();
        colTD_Ma = new DataGridViewTextBoxColumn();
        colTD_DuAn = new DataGridViewTextBoxColumn();
        colTD_Task = new DataGridViewTextBoxColumn();
        colTD_HanNop = new DataGridViewTextBoxColumn();
        colTD_TrangThai = new DataGridViewTextBoxColumn();
        btnCapNhatTrangThai = new Button();
        cboChuyenTrangThai = new ComboBox();
        lblChuyenTrangThai = new Label();
        btnLoc = new Button();
        cboLocTrangThai = new ComboBox();
        lblLocTrangThai = new Label();
        cboLocDuAn = new ComboBox();
        lblLocDuAn = new Label();
        tabBaoCao = new TabPage();
        grpThongKe = new GroupBox();
        btnTaiThongKe = new Button();
        dgvBaoCao = new DataGridView();
        colBC_HoTen = new DataGridViewTextBoxColumn();
        colBC_ChuyenMon = new DataGridViewTextBoxColumn();
        colBC_TongTask = new DataGridViewTextBoxColumn();
        colBC_Done = new DataGridViewTextBoxColumn();
        colBC_TyLe = new DataGridViewTextBoxColumn();
        grpOverdue = new GroupBox();
        btnTaiOverdue = new Button();
        dgvOverdue = new DataGridView();
        colOD_Ma = new DataGridViewTextBoxColumn();
        colOD_DuAn = new DataGridViewTextBoxColumn();
        colOD_Task = new DataGridViewTextBoxColumn();
        colOD_HanNop = new DataGridViewTextBoxColumn();
        colOD_TrangThai = new DataGridViewTextBoxColumn();
        tabMain.SuspendLayout();
        tabDuAnTask.SuspendLayout();
        grpTask.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
        grpDuAn.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDuAn).BeginInit();
        tabTienDoPhanCong.SuspendLayout();
        grpPhanCong.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
        grpTienDo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTienDoTask).BeginInit();
        tabBaoCao.SuspendLayout();
        grpThongKe.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
        grpOverdue.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOverdue).BeginInit();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabDuAnTask);
        tabMain.Controls.Add(tabTienDoPhanCong);
        tabMain.Controls.Add(tabBaoCao);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Location = new Point(0, 0);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(984, 611);
        tabMain.TabIndex = 0;
        // 
        // tabDuAnTask
        // 
        tabDuAnTask.Controls.Add(grpTask);
        tabDuAnTask.Controls.Add(grpDuAn);
        tabDuAnTask.ForeColor = SystemColors.ControlText;
        tabDuAnTask.Location = new Point(4, 29);
        tabDuAnTask.Name = "tabDuAnTask";
        tabDuAnTask.Padding = new Padding(10);
        tabDuAnTask.Size = new Size(976, 578);
        tabDuAnTask.TabIndex = 0;
        tabDuAnTask.Text = "1. Quản lý Dự án & Task";
        tabDuAnTask.UseVisualStyleBackColor = true;
        // 
        // grpTask
        // 
        grpTask.Controls.Add(dgvTask);
        grpTask.Controls.Add(btnXoaTask);
        grpTask.Controls.Add(btnThemTask);
        grpTask.Controls.Add(cboTrangThaiTask);
        grpTask.Controls.Add(lblTrangThaiTask);
        grpTask.Controls.Add(cboDoUuTien);
        grpTask.Controls.Add(lblDoUuTien);
        grpTask.Controls.Add(dtpHanNop);
        grpTask.Controls.Add(lblHanNop);
        grpTask.Controls.Add(txtMoTa);
        grpTask.Controls.Add(lblMoTa);
        grpTask.Controls.Add(txtTenTask);
        grpTask.Controls.Add(lblTenTask);
        grpTask.Location = new Point(10, 280);
        grpTask.Name = "grpTask";
        grpTask.Size = new Size(956, 285);
        grpTask.TabIndex = 1;
        grpTask.TabStop = false;
        grpTask.Text = "Công việc (Task) của Dự án đang chọn";
        // 
        // dgvTask
        // 
        dgvTask.AllowUserToAddRows = false;
        dgvTask.AllowUserToDeleteRows = false;
        dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTask.Columns.AddRange(new DataGridViewColumn[] { colTask_Ma, colTask_Ten, colTask_HanNop, colTask_UuTien, colTask_TrangThai });
        dgvTask.Location = new Point(360, 26);
        dgvTask.MultiSelect = false;
        dgvTask.Name = "dgvTask";
        dgvTask.ReadOnly = true;
        dgvTask.RowHeadersWidth = 51;
        dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTask.Size = new Size(580, 245);
        dgvTask.TabIndex = 12;
        // 
        // colTask_Ma
        // 
        colTask_Ma.DataPropertyName = "MaTask";
        colTask_Ma.HeaderText = "Mã";
        colTask_Ma.MinimumWidth = 6;
        colTask_Ma.Name = "colTask_Ma";
        colTask_Ma.ReadOnly = true;
        colTask_Ma.Width = 60;
        // 
        // colTask_Ten
        // 
        colTask_Ten.DataPropertyName = "TenTask";
        colTask_Ten.HeaderText = "Tên Task";
        colTask_Ten.MinimumWidth = 6;
        colTask_Ten.Name = "colTask_Ten";
        colTask_Ten.ReadOnly = true;
        colTask_Ten.Width = 180;
        // 
        // colTask_HanNop
        // 
        colTask_HanNop.DataPropertyName = "HanNop";
        colTask_HanNop.HeaderText = "Hạn nộp";
        colTask_HanNop.MinimumWidth = 6;
        colTask_HanNop.Name = "colTask_HanNop";
        colTask_HanNop.ReadOnly = true;
        colTask_HanNop.Width = 110;
        // 
        // colTask_UuTien
        // 
        colTask_UuTien.DataPropertyName = "DoUuTien";
        colTask_UuTien.HeaderText = "Ưu tiên";
        colTask_UuTien.MinimumWidth = 6;
        colTask_UuTien.Name = "colTask_UuTien";
        colTask_UuTien.ReadOnly = true;
        colTask_UuTien.Width = 90;
        // 
        // colTask_TrangThai
        // 
        colTask_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colTask_TrangThai.DataPropertyName = "TrangThai";
        colTask_TrangThai.HeaderText = "Trạng thái";
        colTask_TrangThai.MinimumWidth = 6;
        colTask_TrangThai.Name = "colTask_TrangThai";
        colTask_TrangThai.ReadOnly = true;
        // 
        // btnXoaTask
        // 
        btnXoaTask.Location = new Point(220, 235);
        btnXoaTask.Name = "btnXoaTask";
        btnXoaTask.Size = new Size(110, 32);
        btnXoaTask.TabIndex = 11;
        btnXoaTask.Text = "Xóa Task";
        btnXoaTask.UseVisualStyleBackColor = true;
        btnXoaTask.Click += btnXoaTask_Click;
        // 
        // btnThemTask
        // 
        btnThemTask.Location = new Point(95, 235);
        btnThemTask.Name = "btnThemTask";
        btnThemTask.Size = new Size(110, 32);
        btnThemTask.TabIndex = 10;
        btnThemTask.Text = "Thêm Task";
        btnThemTask.UseVisualStyleBackColor = true;
        btnThemTask.Click += btnThemTask_Click;
        // 
        // cboTrangThaiTask
        // 
        cboTrangThaiTask.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThaiTask.FormattingEnabled = true;
        cboTrangThaiTask.Items.AddRange(new object[] { "To Do", "In Progress", "Review", "Done" });
        cboTrangThaiTask.Location = new Point(95, 195);
        cboTrangThaiTask.Name = "cboTrangThaiTask";
        cboTrangThaiTask.Size = new Size(240, 28);
        cboTrangThaiTask.TabIndex = 9;
        // 
        // lblTrangThaiTask
        // 
        lblTrangThaiTask.AutoSize = true;
        lblTrangThaiTask.Location = new Point(15, 198);
        lblTrangThaiTask.Name = "lblTrangThaiTask";
        lblTrangThaiTask.Size = new Size(78, 20);
        lblTrangThaiTask.TabIndex = 8;
        lblTrangThaiTask.Text = "Trạng thái:";
        // 
        // cboDoUuTien
        // 
        cboDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDoUuTien.FormattingEnabled = true;
        cboDoUuTien.Items.AddRange(new object[] { "Cao", "Trung bình", "Thấp" });
        cboDoUuTien.Location = new Point(95, 155);
        cboDoUuTien.Name = "cboDoUuTien";
        cboDoUuTien.Size = new Size(240, 28);
        cboDoUuTien.TabIndex = 7;
        // 
        // lblDoUuTien
        // 
        lblDoUuTien.AutoSize = true;
        lblDoUuTien.Location = new Point(15, 158);
        lblDoUuTien.Name = "lblDoUuTien";
        lblDoUuTien.Size = new Size(60, 20);
        lblDoUuTien.TabIndex = 6;
        lblDoUuTien.Text = "Ưu tiên:";
        // 
        // dtpHanNop
        // 
        dtpHanNop.CustomFormat = "dd/MM/yyyy";
        dtpHanNop.Format = DateTimePickerFormat.Custom;
        dtpHanNop.Location = new Point(95, 115);
        dtpHanNop.Name = "dtpHanNop";
        dtpHanNop.Size = new Size(240, 27);
        dtpHanNop.TabIndex = 5;
        // 
        // lblHanNop
        // 
        lblHanNop.AutoSize = true;
        lblHanNop.Location = new Point(15, 118);
        lblHanNop.Name = "lblHanNop";
        lblHanNop.Size = new Size(69, 20);
        lblHanNop.TabIndex = 4;
        lblHanNop.Text = "Hạn nộp:";
        // 
        // txtMoTa
        // 
        txtMoTa.Location = new Point(95, 70);
        txtMoTa.Name = "txtMoTa";
        txtMoTa.Size = new Size(240, 27);
        txtMoTa.TabIndex = 3;
        // 
        // lblMoTa
        // 
        lblMoTa.AutoSize = true;
        lblMoTa.Location = new Point(15, 73);
        lblMoTa.Name = "lblMoTa";
        lblMoTa.Size = new Size(51, 20);
        lblMoTa.TabIndex = 2;
        lblMoTa.Text = "Mô tả:";
        // 
        // txtTenTask
        // 
        txtTenTask.Location = new Point(95, 30);
        txtTenTask.Name = "txtTenTask";
        txtTenTask.Size = new Size(240, 27);
        txtTenTask.TabIndex = 1;
        // 
        // lblTenTask
        // 
        lblTenTask.AutoSize = true;
        lblTenTask.Location = new Point(15, 33);
        lblTenTask.Name = "lblTenTask";
        lblTenTask.Size = new Size(66, 20);
        lblTenTask.TabIndex = 0;
        lblTenTask.Text = "Tên Task:";
        // 
        // grpDuAn
        // 
        grpDuAn.Controls.Add(dgvDuAn);
        grpDuAn.Controls.Add(btnXoaDuAn);
        grpDuAn.Controls.Add(btnSuaDuAn);
        grpDuAn.Controls.Add(btnThemDuAn);
        grpDuAn.Controls.Add(cboTrangThaiDuAn);
        grpDuAn.Controls.Add(lblTrangThaiDuAn);
        grpDuAn.Controls.Add(dtpNgayKetThuc);
        grpDuAn.Controls.Add(lblNgayKetThuc);
        grpDuAn.Controls.Add(dtpNgayBatDau);
        grpDuAn.Controls.Add(lblNgayBatDau);
        grpDuAn.Controls.Add(txtTenDuAn);
        grpDuAn.Controls.Add(lblTenDuAn);
        grpDuAn.Location = new Point(10, 10);
        grpDuAn.Name = "grpDuAn";
        grpDuAn.Size = new Size(956, 260);
        grpDuAn.TabIndex = 0;
        grpDuAn.TabStop = false;
        grpDuAn.Text = "Dự án (Project)";
        // 
        // dgvDuAn
        // 
        dgvDuAn.AllowUserToAddRows = false;
        dgvDuAn.AllowUserToDeleteRows = false;
        dgvDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDuAn.Columns.AddRange(new DataGridViewColumn[] { colDuAn_Ma, colDuAn_Ten, colDuAn_BatDau, colDuAn_KetThuc, colDuAn_TrangThai });
        dgvDuAn.Location = new Point(360, 26);
        dgvDuAn.MultiSelect = false;
        dgvDuAn.Name = "dgvDuAn";
        dgvDuAn.ReadOnly = true;
        dgvDuAn.RowHeadersWidth = 51;
        dgvDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDuAn.Size = new Size(580, 220);
        dgvDuAn.TabIndex = 11;
        dgvDuAn.SelectionChanged += dgvDuAn_SelectionChanged;
        // 
        // colDuAn_Ma
        // 
        colDuAn_Ma.DataPropertyName = "MaDuAn";
        colDuAn_Ma.HeaderText = "Mã";
        colDuAn_Ma.MinimumWidth = 6;
        colDuAn_Ma.Name = "colDuAn_Ma";
        colDuAn_Ma.ReadOnly = true;
        colDuAn_Ma.Width = 60;
        // 
        // colDuAn_Ten
        // 
        colDuAn_Ten.DataPropertyName = "TenDuAn";
        colDuAn_Ten.HeaderText = "Tên Dự Án";
        colDuAn_Ten.MinimumWidth = 6;
        colDuAn_Ten.Name = "colDuAn_Ten";
        colDuAn_Ten.ReadOnly = true;
        colDuAn_Ten.Width = 180;
        // 
        // colDuAn_BatDau
        // 
        colDuAn_BatDau.DataPropertyName = "NgayBatDau";
        colDuAn_BatDau.HeaderText = "Bắt đầu";
        colDuAn_BatDau.MinimumWidth = 6;
        colDuAn_BatDau.Name = "colDuAn_BatDau";
        colDuAn_BatDau.ReadOnly = true;
        colDuAn_BatDau.Width = 110;
        // 
        // colDuAn_KetThuc
        // 
        colDuAn_KetThuc.DataPropertyName = "NgayKetThuc";
        colDuAn_KetThuc.HeaderText = "Kết thúc";
        colDuAn_KetThuc.MinimumWidth = 6;
        colDuAn_KetThuc.Name = "colDuAn_KetThuc";
        colDuAn_KetThuc.ReadOnly = true;
        colDuAn_KetThuc.Width = 110;
        // 
        // colDuAn_TrangThai
        // 
        colDuAn_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colDuAn_TrangThai.DataPropertyName = "TrangThai";
        colDuAn_TrangThai.HeaderText = "Trạng thái";
        colDuAn_TrangThai.MinimumWidth = 6;
        colDuAn_TrangThai.Name = "colDuAn_TrangThai";
        colDuAn_TrangThai.ReadOnly = true;
        // 
        // btnXoaDuAn
        // 
        btnXoaDuAn.Location = new Point(235, 210);
        btnXoaDuAn.Name = "btnXoaDuAn";
        btnXoaDuAn.Size = new Size(100, 32);
        btnXoaDuAn.TabIndex = 10;
        btnXoaDuAn.Text = "Xóa Dự Án";
        btnXoaDuAn.UseVisualStyleBackColor = true;
        btnXoaDuAn.Click += btnXoaDuAn_Click;
        // 
        // btnSuaDuAn
        // 
        btnSuaDuAn.Location = new Point(125, 210);
        btnSuaDuAn.Name = "btnSuaDuAn";
        btnSuaDuAn.Size = new Size(100, 32);
        btnSuaDuAn.TabIndex = 9;
        btnSuaDuAn.Text = "Sửa Dự Án";
        btnSuaDuAn.UseVisualStyleBackColor = true;
        btnSuaDuAn.Click += btnSuaDuAn_Click;
        // 
        // btnThemDuAn
        // 
        btnThemDuAn.Location = new Point(15, 210);
        btnThemDuAn.Name = "btnThemDuAn";
        btnThemDuAn.Size = new Size(100, 32);
        btnThemDuAn.TabIndex = 8;
        btnThemDuAn.Text = "Thêm Dự Án";
        btnThemDuAn.UseVisualStyleBackColor = true;
        btnThemDuAn.Click += btnThemDuAn_Click;
        // 
        // cboTrangThaiDuAn
        // 
        cboTrangThaiDuAn.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThaiDuAn.FormattingEnabled = true;
        cboTrangThaiDuAn.Items.AddRange(new object[] { "Đang chạy", "Hoàn thành", "Tạm dừng" });
        cboTrangThaiDuAn.Location = new Point(95, 155);
        cboTrangThaiDuAn.Name = "cboTrangThaiDuAn";
        cboTrangThaiDuAn.Size = new Size(240, 28);
        cboTrangThaiDuAn.TabIndex = 7;
        // 
        // lblTrangThaiDuAn
        // 
        lblTrangThaiDuAn.AutoSize = true;
        lblTrangThaiDuAn.Location = new Point(15, 158);
        lblTrangThaiDuAn.Name = "lblTrangThaiDuAn";
        lblTrangThaiDuAn.Size = new Size(78, 20);
        lblTrangThaiDuAn.TabIndex = 6;
        lblTrangThaiDuAn.Text = "Trạng thái:";
        // 
        // dtpNgayKetThuc
        // 
        dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
        dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
        dtpNgayKetThuc.Location = new Point(95, 115);
        dtpNgayKetThuc.Name = "dtpNgayKetThuc";
        dtpNgayKetThuc.Size = new Size(240, 27);
        dtpNgayKetThuc.TabIndex = 5;
        // 
        // lblNgayKetThuc
        // 
        lblNgayKetThuc.AutoSize = true;
        lblNgayKetThuc.Location = new Point(15, 118);
        lblNgayKetThuc.Name = "lblNgayKetThuc";
        lblNgayKetThuc.Size = new Size(66, 20);
        lblNgayKetThuc.TabIndex = 4;
        lblNgayKetThuc.Text = "Kết thúc:";
        // 
        // dtpNgayBatDau
        // 
        dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
        dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
        dtpNgayBatDau.Location = new Point(95, 70);
        dtpNgayBatDau.Name = "dtpNgayBatDau";
        dtpNgayBatDau.Size = new Size(240, 27);
        dtpNgayBatDau.TabIndex = 3;
        // 
        // lblNgayBatDau
        // 
        lblNgayBatDau.AutoSize = true;
        lblNgayBatDau.Location = new Point(15, 73);
        lblNgayBatDau.Name = "lblNgayBatDau";
        lblNgayBatDau.Size = new Size(63, 20);
        lblNgayBatDau.TabIndex = 2;
        lblNgayBatDau.Text = "Bắt đầu:";
        // 
        // txtTenDuAn
        // 
        txtTenDuAn.Location = new Point(95, 30);
        txtTenDuAn.Name = "txtTenDuAn";
        txtTenDuAn.Size = new Size(240, 27);
        txtTenDuAn.TabIndex = 1;
        // 
        // lblTenDuAn
        // 
        lblTenDuAn.AutoSize = true;
        lblTenDuAn.Location = new Point(15, 33);
        lblTenDuAn.Name = "lblTenDuAn";
        lblTenDuAn.Size = new Size(77, 20);
        lblTenDuAn.TabIndex = 0;
        lblTenDuAn.Text = "Tên dự án:";
        // 
        // tabTienDoPhanCong
        // 
        tabTienDoPhanCong.Controls.Add(grpPhanCong);
        tabTienDoPhanCong.Controls.Add(grpTienDo);
        tabTienDoPhanCong.Location = new Point(4, 29);
        tabTienDoPhanCong.Name = "tabTienDoPhanCong";
        tabTienDoPhanCong.Padding = new Padding(10);
        tabTienDoPhanCong.Size = new Size(976, 578);
        tabTienDoPhanCong.TabIndex = 1;
        tabTienDoPhanCong.Text = "2. Cập nhật Tiến độ & Phân công";
        tabTienDoPhanCong.UseVisualStyleBackColor = true;
        // 
        // grpPhanCong
        // 
        grpPhanCong.Controls.Add(dgvPhanCong);
        grpPhanCong.Controls.Add(btnHuyPhanCong);
        grpPhanCong.Controls.Add(btnPhanCong);
        grpPhanCong.Controls.Add(cboThanhVien);
        grpPhanCong.Controls.Add(lblChonThanhVien);
        grpPhanCong.Location = new Point(10, 330);
        grpPhanCong.Name = "grpPhanCong";
        grpPhanCong.Size = new Size(956, 235);
        grpPhanCong.TabIndex = 1;
        grpPhanCong.TabStop = false;
        grpPhanCong.Text = "Giao việc (Phân công) thành viên giải quyết Task đang chọn";
        // 
        // dgvPhanCong
        // 
        dgvPhanCong.AllowUserToAddRows = false;
        dgvPhanCong.AllowUserToDeleteRows = false;
        dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPhanCong.Columns.AddRange(new DataGridViewColumn[] { colPC_MaTask, colPC_TenTask, colPC_HoTen, colPC_NgayGiao });
        dgvPhanCong.Location = new Point(15, 75);
        dgvPhanCong.MultiSelect = false;
        dgvPhanCong.Name = "dgvPhanCong";
        dgvPhanCong.ReadOnly = true;
        dgvPhanCong.RowHeadersWidth = 51;
        dgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPhanCong.Size = new Size(925, 145);
        dgvPhanCong.TabIndex = 4;
        // 
        // colPC_MaTask
        // 
        colPC_MaTask.DataPropertyName = "MaTask";
        colPC_MaTask.HeaderText = "Mã Task";
        colPC_MaTask.MinimumWidth = 6;
        colPC_MaTask.Name = "colPC_MaTask";
        colPC_MaTask.ReadOnly = true;
        colPC_MaTask.Width = 80;
        // 
        // colPC_TenTask
        // 
        colPC_TenTask.DataPropertyName = "TenTask";
        colPC_TenTask.HeaderText = "Tên Task";
        colPC_TenTask.MinimumWidth = 6;
        colPC_TenTask.Name = "colPC_TenTask";
        colPC_TenTask.ReadOnly = true;
        colPC_TenTask.Width = 260;
        // 
        // colPC_HoTen
        // 
        colPC_HoTen.DataPropertyName = "HoTen";
        colPC_HoTen.HeaderText = "Thành viên được giao";
        colPC_HoTen.MinimumWidth = 6;
        colPC_HoTen.Name = "colPC_HoTen";
        colPC_HoTen.ReadOnly = true;
        colPC_HoTen.Width = 260;
        // 
        // colPC_NgayGiao
        // 
        colPC_NgayGiao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPC_NgayGiao.DataPropertyName = "NgayGiao";
        colPC_NgayGiao.HeaderText = "Ngày giao";
        colPC_NgayGiao.MinimumWidth = 6;
        colPC_NgayGiao.Name = "colPC_NgayGiao";
        colPC_NgayGiao.ReadOnly = true;
        // 
        // btnHuyPhanCong
        // 
        btnHuyPhanCong.Location = new Point(540, 30);
        btnHuyPhanCong.Name = "btnHuyPhanCong";
        btnHuyPhanCong.Size = new Size(130, 30);
        btnHuyPhanCong.TabIndex = 3;
        btnHuyPhanCong.Text = "Hủy phân công";
        btnHuyPhanCong.UseVisualStyleBackColor = true;
        btnHuyPhanCong.Click += btnHuyPhanCong_Click;
        // 
        // btnPhanCong
        // 
        btnPhanCong.Location = new Point(400, 30);
        btnPhanCong.Name = "btnPhanCong";
        btnPhanCong.Size = new Size(130, 30);
        btnPhanCong.TabIndex = 2;
        btnPhanCong.Text = "Giao việc";
        btnPhanCong.UseVisualStyleBackColor = true;
        btnPhanCong.Click += btnPhanCong_Click;
        // 
        // cboThanhVien
        // 
        cboThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien.FormattingEnabled = true;
        cboThanhVien.Location = new Point(140, 31);
        cboThanhVien.Name = "cboThanhVien";
        cboThanhVien.Size = new Size(240, 28);
        cboThanhVien.TabIndex = 1;
        // 
        // lblChonThanhVien
        // 
        lblChonThanhVien.AutoSize = true;
        lblChonThanhVien.Location = new Point(15, 34);
        lblChonThanhVien.Name = "lblChonThanhVien";
        lblChonThanhVien.Size = new Size(118, 20);
        lblChonThanhVien.TabIndex = 0;
        lblChonThanhVien.Text = "Chọn thành viên:";
        // 
        // grpTienDo
        // 
        grpTienDo.Controls.Add(dgvTienDoTask);
        grpTienDo.Controls.Add(btnCapNhatTrangThai);
        grpTienDo.Controls.Add(cboChuyenTrangThai);
        grpTienDo.Controls.Add(lblChuyenTrangThai);
        grpTienDo.Controls.Add(btnLoc);
        grpTienDo.Controls.Add(cboLocTrangThai);
        grpTienDo.Controls.Add(lblLocTrangThai);
        grpTienDo.Controls.Add(cboLocDuAn);
        grpTienDo.Controls.Add(lblLocDuAn);
        grpTienDo.Location = new Point(10, 10);
        grpTienDo.Name = "grpTienDo";
        grpTienDo.Size = new Size(956, 310);
        grpTienDo.TabIndex = 0;
        grpTienDo.TabStop = false;
        grpTienDo.Text = "Tiến độ công việc theo Dự án";
        // 
        // dgvTienDoTask
        // 
        dgvTienDoTask.AllowUserToAddRows = false;
        dgvTienDoTask.AllowUserToDeleteRows = false;
        dgvTienDoTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTienDoTask.Columns.AddRange(new DataGridViewColumn[] { colTD_Ma, colTD_DuAn, colTD_Task, colTD_HanNop, colTD_TrangThai });
        dgvTienDoTask.Location = new Point(15, 115);
        dgvTienDoTask.MultiSelect = false;
        dgvTienDoTask.Name = "dgvTienDoTask";
        dgvTienDoTask.ReadOnly = true;
        dgvTienDoTask.RowHeadersWidth = 51;
        dgvTienDoTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTienDoTask.Size = new Size(925, 180);
        dgvTienDoTask.TabIndex = 8;
        dgvTienDoTask.SelectionChanged += dgvTienDoTask_SelectionChanged;
        // 
        // colTD_Ma
        // 
        colTD_Ma.DataPropertyName = "MaTask";
        colTD_Ma.HeaderText = "Mã";
        colTD_Ma.MinimumWidth = 6;
        colTD_Ma.Name = "colTD_Ma";
        colTD_Ma.ReadOnly = true;
        colTD_Ma.Width = 60;
        // 
        // colTD_DuAn
        // 
        colTD_DuAn.DataPropertyName = "TenDuAn";
        colTD_DuAn.HeaderText = "Dự Án";
        colTD_DuAn.MinimumWidth = 6;
        colTD_DuAn.Name = "colTD_DuAn";
        colTD_DuAn.ReadOnly = true;
        colTD_DuAn.Width = 200;
        // 
        // colTD_Task
        // 
        colTD_Task.DataPropertyName = "TenTask";
        colTD_Task.HeaderText = "Tên Task";
        colTD_Task.MinimumWidth = 6;
        colTD_Task.Name = "colTD_Task";
        colTD_Task.ReadOnly = true;
        colTD_Task.Width = 260;
        // 
        // colTD_HanNop
        // 
        colTD_HanNop.DataPropertyName = "HanNop";
        colTD_HanNop.HeaderText = "Hạn nộp";
        colTD_HanNop.MinimumWidth = 6;
        colTD_HanNop.Name = "colTD_HanNop";
        colTD_HanNop.ReadOnly = true;
        colTD_HanNop.Width = 120;
        // 
        // colTD_TrangThai
        // 
        colTD_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colTD_TrangThai.DataPropertyName = "TrangThai";
        colTD_TrangThai.HeaderText = "Trạng thái";
        colTD_TrangThai.MinimumWidth = 6;
        colTD_TrangThai.Name = "colTD_TrangThai";
        colTD_TrangThai.ReadOnly = true;
        // 
        // btnCapNhatTrangThai
        // 
        btnCapNhatTrangThai.Location = new Point(400, 72);
        btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
        btnCapNhatTrangThai.Size = new Size(180, 30);
        btnCapNhatTrangThai.TabIndex = 7;
        btnCapNhatTrangThai.Text = "Chuyển Trạng Thái";
        btnCapNhatTrangThai.UseVisualStyleBackColor = true;
        btnCapNhatTrangThai.Click += btnCapNhatTrangThai_Click;
        // 
        // cboChuyenTrangThai
        // 
        cboChuyenTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboChuyenTrangThai.FormattingEnabled = true;
        cboChuyenTrangThai.Items.AddRange(new object[] { "To Do", "In Progress", "Review", "Done" });
        cboChuyenTrangThai.Location = new Point(175, 73);
        cboChuyenTrangThai.Name = "cboChuyenTrangThai";
        cboChuyenTrangThai.Size = new Size(205, 28);
        cboChuyenTrangThai.TabIndex = 6;
        // 
        // lblChuyenTrangThai
        // 
        lblChuyenTrangThai.AutoSize = true;
        lblChuyenTrangThai.Location = new Point(15, 76);
        lblChuyenTrangThai.Name = "lblChuyenTrangThai";
        lblChuyenTrangThai.Size = new Size(139, 20);
        lblChuyenTrangThai.TabIndex = 5;
        lblChuyenTrangThai.Text = "Đổi trạng thái sang:";
        // 
        // btnLoc
        // 
        btnLoc.Location = new Point(780, 27);
        btnLoc.Name = "btnLoc";
        btnLoc.Size = new Size(90, 30);
        btnLoc.TabIndex = 4;
        btnLoc.Text = "Lọc Task";
        btnLoc.UseVisualStyleBackColor = true;
        btnLoc.Click += btnLoc_Click;
        // 
        // cboLocTrangThai
        // 
        cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocTrangThai.FormattingEnabled = true;
        cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "To Do", "In Progress", "Review", "Done" });
        cboLocTrangThai.Location = new Point(575, 28);
        cboLocTrangThai.Name = "cboLocTrangThai";
        cboLocTrangThai.Size = new Size(180, 28);
        cboLocTrangThai.TabIndex = 3;
        // 
        // lblLocTrangThai
        // 
        lblLocTrangThai.AutoSize = true;
        lblLocTrangThai.Location = new Point(490, 32);
        lblLocTrangThai.Name = "lblLocTrangThai";
        lblLocTrangThai.Size = new Size(78, 20);
        lblLocTrangThai.TabIndex = 2;
        lblLocTrangThai.Text = "Trạng thái:";
        // 
        // cboLocDuAn
        // 
        cboLocDuAn.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocDuAn.FormattingEnabled = true;
        cboLocDuAn.Location = new Point(100, 28);
        cboLocDuAn.Name = "cboLocDuAn";
        cboLocDuAn.Size = new Size(360, 28);
        cboLocDuAn.TabIndex = 1;
        // 
        // lblLocDuAn
        // 
        lblLocDuAn.AutoSize = true;
        lblLocDuAn.Location = new Point(15, 32);
        lblLocDuAn.Name = "lblLocDuAn";
        lblLocDuAn.Size = new Size(52, 20);
        lblLocDuAn.TabIndex = 0;
        lblLocDuAn.Text = "Dự án:";
        // 
        // tabBaoCao
        // 
        tabBaoCao.Controls.Add(grpThongKe);
        tabBaoCao.Controls.Add(grpOverdue);
        tabBaoCao.Location = new Point(4, 29);
        tabBaoCao.Name = "tabBaoCao";
        tabBaoCao.Padding = new Padding(10);
        tabBaoCao.Size = new Size(976, 578);
        tabBaoCao.TabIndex = 2;
        tabBaoCao.Text = "3. Cảnh báo trễ hạn & Báo cáo";
        tabBaoCao.UseVisualStyleBackColor = true;
        // 
        // grpThongKe
        // 
        grpThongKe.Controls.Add(btnTaiThongKe);
        grpThongKe.Controls.Add(dgvBaoCao);
        grpThongKe.Location = new Point(10, 295);
        grpThongKe.Name = "grpThongKe";
        grpThongKe.Size = new Size(956, 270);
        grpThongKe.TabIndex = 1;
        grpThongKe.TabStop = false;
        grpThongKe.Text = "Thống kê tỷ lệ % hoàn thành công việc theo từng thành viên";
        // 
        // btnTaiThongKe
        // 
        btnTaiThongKe.Location = new Point(15, 26);
        btnTaiThongKe.Name = "btnTaiThongKe";
        btnTaiThongKe.Size = new Size(180, 30);
        btnTaiThongKe.TabIndex = 1;
        btnTaiThongKe.Text = "Cập nhật Thống Kê";
        btnTaiThongKe.UseVisualStyleBackColor = true;
        btnTaiThongKe.Click += btnTaiThongKe_Click;
        // 
        // dgvBaoCao
        // 
        dgvBaoCao.AllowUserToAddRows = false;
        dgvBaoCao.AllowUserToDeleteRows = false;
        dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBaoCao.Columns.AddRange(new DataGridViewColumn[] { colBC_HoTen, colBC_ChuyenMon, colBC_TongTask, colBC_Done, colBC_TyLe });
        dgvBaoCao.Location = new Point(15, 65);
        dgvBaoCao.MultiSelect = false;
        dgvBaoCao.Name = "dgvBaoCao";
        dgvBaoCao.ReadOnly = true;
        dgvBaoCao.RowHeadersWidth = 51;
        dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBaoCao.Size = new Size(925, 190);
        dgvBaoCao.TabIndex = 0;
        // 
        // colBC_HoTen
        // 
        colBC_HoTen.DataPropertyName = "HoTen";
        colBC_HoTen.HeaderText = "Họ Tên";
        colBC_HoTen.MinimumWidth = 6;
        colBC_HoTen.Name = "colBC_HoTen";
        colBC_HoTen.ReadOnly = true;
        colBC_HoTen.Width = 220;
        // 
        // colBC_ChuyenMon
        // 
        colBC_ChuyenMon.DataPropertyName = "ChuyenMon";
        colBC_ChuyenMon.HeaderText = "Chuyên Môn";
        colBC_ChuyenMon.MinimumWidth = 6;
        colBC_ChuyenMon.Name = "colBC_ChuyenMon";
        colBC_ChuyenMon.ReadOnly = true;
        colBC_ChuyenMon.Width = 200;
        // 
        // colBC_TongTask
        // 
        colBC_TongTask.DataPropertyName = "TongSoTask";
        colBC_TongTask.HeaderText = "Tổng số Task";
        colBC_TongTask.MinimumWidth = 6;
        colBC_TongTask.Name = "colBC_TongTask";
        colBC_TongTask.ReadOnly = true;
        colBC_TongTask.Width = 140;
        // 
        // colBC_Done
        // 
        colBC_Done.DataPropertyName = "SoTaskHoanThanh";
        colBC_Done.HeaderText = "Đã hoàn thành";
        colBC_Done.MinimumWidth = 6;
        colBC_Done.Name = "colBC_Done";
        colBC_Done.ReadOnly = true;
        colBC_Done.Width = 140;
        // 
        // colBC_TyLe
        // 
        colBC_TyLe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colBC_TyLe.DataPropertyName = "TyLeHoanThanh";
        colBC_TyLe.HeaderText = "Tỷ lệ hoàn thành (%)";
        colBC_TyLe.MinimumWidth = 6;
        colBC_TyLe.Name = "colBC_TyLe";
        colBC_TyLe.ReadOnly = true;
        // 
        // grpOverdue
        // 
        grpOverdue.Controls.Add(btnTaiOverdue);
        grpOverdue.Controls.Add(dgvOverdue);
        grpOverdue.Location = new Point(10, 10);
        grpOverdue.Name = "grpOverdue";
        grpOverdue.Size = new Size(956, 270);
        grpOverdue.TabIndex = 0;
        grpOverdue.TabStop = false;
        grpOverdue.Text = "Cảnh báo Task trễ hạn (HanNop < Hiện tại & TrangThai != 'Done')";
        // 
        // btnTaiOverdue
        // 
        btnTaiOverdue.Location = new Point(15, 26);
        btnTaiOverdue.Name = "btnTaiOverdue";
        btnTaiOverdue.Size = new Size(180, 30);
        btnTaiOverdue.TabIndex = 1;
        btnTaiOverdue.Text = "Tải Task Trễ Hạn";
        btnTaiOverdue.UseVisualStyleBackColor = true;
        btnTaiOverdue.Click += btnTaiOverdue_Click;
        // 
        // dgvOverdue
        // 
        dgvOverdue.AllowUserToAddRows = false;
        dgvOverdue.AllowUserToDeleteRows = false;
        dgvOverdue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOverdue.Columns.AddRange(new DataGridViewColumn[] { colOD_Ma, colOD_DuAn, colOD_Task, colOD_HanNop, colOD_TrangThai });
        dgvOverdue.Location = new Point(15, 65);
        dgvOverdue.MultiSelect = false;
        dgvOverdue.Name = "dgvOverdue";
        dgvOverdue.ReadOnly = true;
        dgvOverdue.RowHeadersWidth = 51;
        dgvOverdue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOverdue.Size = new Size(925, 190);
        dgvOverdue.TabIndex = 0;
        // 
        // colOD_Ma
        // 
        colOD_Ma.DataPropertyName = "MaTask";
        colOD_Ma.HeaderText = "Mã";
        colOD_Ma.MinimumWidth = 6;
        colOD_Ma.Name = "colOD_Ma";
        colOD_Ma.ReadOnly = true;
        colOD_Ma.Width = 60;
        // 
        // colOD_DuAn
        // 
        colOD_DuAn.DataPropertyName = "TenDuAn";
        colOD_DuAn.HeaderText = "Dự Án";
        colOD_DuAn.MinimumWidth = 6;
        colOD_DuAn.Name = "colOD_DuAn";
        colOD_DuAn.ReadOnly = true;
        colOD_DuAn.Width = 220;
        // 
        // colOD_Task
        // 
        colOD_Task.DataPropertyName = "TenTask";
        colOD_Task.HeaderText = "Tên Task";
        colOD_Task.MinimumWidth = 6;
        colOD_Task.Name = "colOD_Task";
        colOD_Task.ReadOnly = true;
        colOD_Task.Width = 260;
        // 
        // colOD_HanNop
        // 
        colOD_HanNop.DataPropertyName = "HanNop";
        colOD_HanNop.HeaderText = "Hạn nộp";
        colOD_HanNop.MinimumWidth = 6;
        colOD_HanNop.Name = "colOD_HanNop";
        colOD_HanNop.ReadOnly = true;
        colOD_HanNop.Width = 120;
        // 
        // colOD_TrangThai
        // 
        colOD_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colOD_TrangThai.DataPropertyName = "TrangThai";
        colOD_TrangThai.HeaderText = "Trạng thái";
        colOD_TrangThai.MinimumWidth = 6;
        colOD_TrangThai.Name = "colOD_TrangThai";
        colOD_TrangThai.ReadOnly = true;
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
        Text = "Quản lý Công việc & Tiến độ Dự án";
        Load += MainForm_Load;
        tabMain.ResumeLayout(false);
        tabDuAnTask.ResumeLayout(false);
        grpTask.ResumeLayout(false);
        grpTask.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
        grpDuAn.ResumeLayout(false);
        grpDuAn.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDuAn).EndInit();
        tabTienDoPhanCong.ResumeLayout(false);
        grpPhanCong.ResumeLayout(false);
        grpPhanCong.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
        grpTienDo.ResumeLayout(false);
        grpTienDo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTienDoTask).EndInit();
        tabBaoCao.ResumeLayout(false);
        grpThongKe.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
        grpOverdue.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOverdue).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabMain;
    private TabPage tabDuAnTask;
    private TabPage tabTienDoPhanCong;
    private TabPage tabBaoCao;
    private GroupBox grpDuAn;
    private GroupBox grpTask;
    private TextBox txtTenDuAn;
    private Label lblTenDuAn;
    private DateTimePicker dtpNgayBatDau;
    private Label lblNgayBatDau;
    private DateTimePicker dtpNgayKetThuc;
    private Label lblNgayKetThuc;
    private ComboBox cboTrangThaiDuAn;
    private Label lblTrangThaiDuAn;
    private Button btnXoaDuAn;
    private Button btnSuaDuAn;
    private Button btnThemDuAn;
    private DataGridView dgvDuAn;
    private DataGridViewTextBoxColumn colDuAn_Ma;
    private DataGridViewTextBoxColumn colDuAn_Ten;
    private DataGridViewTextBoxColumn colDuAn_BatDau;
    private DataGridViewTextBoxColumn colDuAn_KetThuc;
    private DataGridViewTextBoxColumn colDuAn_TrangThai;
    private TextBox txtTenTask;
    private Label lblTenTask;
    private TextBox txtMoTa;
    private Label lblMoTa;
    private DateTimePicker dtpHanNop;
    private Label lblHanNop;
    private ComboBox cboDoUuTien;
    private Label lblDoUuTien;
    private ComboBox cboTrangThaiTask;
    private Label lblTrangThaiTask;
    private Button btnThemTask;
    private Button btnXoaTask;
    private DataGridView dgvTask;
    private DataGridViewTextBoxColumn colTask_Ma;
    private DataGridViewTextBoxColumn colTask_Ten;
    private DataGridViewTextBoxColumn colTask_HanNop;
    private DataGridViewTextBoxColumn colTask_UuTien;
    private DataGridViewTextBoxColumn colTask_TrangThai;
    private GroupBox grpTienDo;
    private Label lblLocDuAn;
    private ComboBox cboLocDuAn;
    private Label lblLocTrangThai;
    private ComboBox cboLocTrangThai;
    private Button btnLoc;
    private Label lblChuyenTrangThai;
    private ComboBox cboChuyenTrangThai;
    private Button btnCapNhatTrangThai;
    private DataGridView dgvTienDoTask;
    private DataGridViewTextBoxColumn colTD_Ma;
    private DataGridViewTextBoxColumn colTD_DuAn;
    private DataGridViewTextBoxColumn colTD_Task;
    private DataGridViewTextBoxColumn colTD_HanNop;
    private DataGridViewTextBoxColumn colTD_TrangThai;
    private GroupBox grpPhanCong;
    private Label lblChonThanhVien;
    private ComboBox cboThanhVien;
    private Button btnPhanCong;
    private Button btnHuyPhanCong;
    private DataGridView dgvPhanCong;
    private DataGridViewTextBoxColumn colPC_MaTask;
    private DataGridViewTextBoxColumn colPC_TenTask;
    private DataGridViewTextBoxColumn colPC_HoTen;
    private DataGridViewTextBoxColumn colPC_NgayGiao;
    private GroupBox grpOverdue;
    private Button btnTaiOverdue;
    private DataGridView dgvOverdue;
    private DataGridViewTextBoxColumn colOD_Ma;
    private DataGridViewTextBoxColumn colOD_DuAn;
    private DataGridViewTextBoxColumn colOD_Task;
    private DataGridViewTextBoxColumn colOD_HanNop;
    private DataGridViewTextBoxColumn colOD_TrangThai;
    private GroupBox grpThongKe;
    private Button btnTaiThongKe;
    private DataGridView dgvBaoCao;
    private DataGridViewTextBoxColumn colBC_HoTen;
    private DataGridViewTextBoxColumn colBC_ChuyenMon;
    private DataGridViewTextBoxColumn colBC_TongTask;
    private DataGridViewTextBoxColumn colBC_Done;
    private DataGridViewTextBoxColumn colBC_TyLe;
}


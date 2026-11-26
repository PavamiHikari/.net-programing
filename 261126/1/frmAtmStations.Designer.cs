namespace BankAtmMdiSystem;

partial class frmAtmStations
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        grpThongTin = new GroupBox();
        btnChonAnh = new Button();
        picHienTruong = new PictureBox();
        btnXoa = new Button();
        btnCapNhat = new Button();
        btnThem = new Button();
        cboTrangThai = new ComboBox();
        lblTrangThai = new Label();
        txtTonQuy = new TextBox();
        lblTonQuy = new Label();
        txtDiaChi = new TextBox();
        lblDiaChi = new Label();
        txtMaTram = new TextBox();
        lblMaTram = new Label();
        dgvTramAtm = new DataGridView();
        colMaTram = new DataGridViewTextBoxColumn();
        colDiaChi = new DataGridViewTextBoxColumn();
        colTonQuy = new DataGridViewTextBoxColumn();
        colTrangThai = new DataGridViewTextBoxColumn();
        colAnhHienTruong = new DataGridViewTextBoxColumn();
        ofdAnhTram = new OpenFileDialog();
        grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picHienTruong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvTramAtm).BeginInit();
        SuspendLayout();
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(btnChonAnh);
        grpThongTin.Controls.Add(picHienTruong);
        grpThongTin.Controls.Add(btnXoa);
        grpThongTin.Controls.Add(btnCapNhat);
        grpThongTin.Controls.Add(btnThem);
        grpThongTin.Controls.Add(cboTrangThai);
        grpThongTin.Controls.Add(lblTrangThai);
        grpThongTin.Controls.Add(txtTonQuy);
        grpThongTin.Controls.Add(lblTonQuy);
        grpThongTin.Controls.Add(txtDiaChi);
        grpThongTin.Controls.Add(lblDiaChi);
        grpThongTin.Controls.Add(txtMaTram);
        grpThongTin.Controls.Add(lblMaTram);
        grpThongTin.Dock = DockStyle.Top;
        grpThongTin.Location = new Point(0, 0);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(824, 212);
        grpThongTin.TabIndex = 0;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin Trạm ATM";
        // 
        // btnChonAnh
        // 
        btnChonAnh.Location = new Point(540, 166);
        btnChonAnh.Name = "btnChonAnh";
        btnChonAnh.Size = new Size(210, 30);
        btnChonAnh.TabIndex = 6;
        btnChonAnh.Text = "Đính kèm ảnh hiện trường...";
        btnChonAnh.UseVisualStyleBackColor = true;
        btnChonAnh.Click += btnChonAnh_Click;
        // 
        // picHienTruong
        // 
        picHienTruong.BorderStyle = BorderStyle.FixedSingle;
        picHienTruong.Location = new Point(540, 24);
        picHienTruong.Name = "picHienTruong";
        picHienTruong.Size = new Size(210, 134);
        picHienTruong.SizeMode = PictureBoxSizeMode.Zoom;
        picHienTruong.TabIndex = 12;
        picHienTruong.TabStop = false;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(332, 166);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(90, 30);
        btnXoa.TabIndex = 9;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnCapNhat
        // 
        btnCapNhat.Location = new Point(230, 166);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new Size(94, 30);
        btnCapNhat.TabIndex = 8;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        btnCapNhat.Click += btnCapNhat_Click;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(132, 166);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(90, 30);
        btnThem.TabIndex = 7;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // cboTrangThai
        // 
        cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThai.FormattingEnabled = true;
        cboTrangThai.Items.AddRange(new object[] { "Hoạt động", "Tạm ngưng", "Bảo trì", "Hết tiền" });
        cboTrangThai.Location = new Point(132, 130);
        cboTrangThai.Name = "cboTrangThai";
        cboTrangThai.Size = new Size(200, 23);
        cboTrangThai.TabIndex = 5;
        // 
        // lblTrangThai
        // 
        lblTrangThai.AutoSize = true;
        lblTrangThai.Location = new Point(18, 133);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(64, 15);
        lblTrangThai.TabIndex = 4;
        lblTrangThai.Text = "Trạng thái:";
        // 
        // txtTonQuy
        // 
        txtTonQuy.Location = new Point(132, 95);
        txtTonQuy.Name = "txtTonQuy";
        txtTonQuy.Size = new Size(200, 23);
        txtTonQuy.TabIndex = 3;
        // 
        // lblTonQuy
        // 
        lblTonQuy.AutoSize = true;
        lblTonQuy.Location = new Point(18, 98);
        lblTonQuy.Name = "lblTonQuy";
        lblTonQuy.Size = new Size(90, 15);
        lblTonQuy.TabIndex = 2;
        lblTonQuy.Text = "Tồn quỹ (VNĐ):";
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(132, 60);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(370, 23);
        txtDiaChi.TabIndex = 2;
        // 
        // lblDiaChi
        // 
        lblDiaChi.AutoSize = true;
        lblDiaChi.Location = new Point(18, 63);
        lblDiaChi.Name = "lblDiaChi";
        lblDiaChi.Size = new Size(97, 15);
        lblDiaChi.TabIndex = 1;
        lblDiaChi.Text = "Địa chỉ đặt máy:";
        // 
        // txtMaTram
        // 
        txtMaTram.Location = new Point(132, 25);
        txtMaTram.Name = "txtMaTram";
        txtMaTram.Size = new Size(200, 23);
        txtMaTram.TabIndex = 0;
        // 
        // lblMaTram
        // 
        lblMaTram.AutoSize = true;
        lblMaTram.Location = new Point(18, 28);
        lblMaTram.Name = "lblMaTram";
        lblMaTram.Size = new Size(57, 15);
        lblMaTram.TabIndex = 0;
        lblMaTram.Text = "Mã trạm:";
        // 
        // dgvTramAtm
        // 
        dgvTramAtm.AllowUserToAddRows = false;
        dgvTramAtm.AllowUserToDeleteRows = false;
        dgvTramAtm.AutoGenerateColumns = false;
        dgvTramAtm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTramAtm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTramAtm.Columns.AddRange(new DataGridViewColumn[] { colMaTram, colDiaChi, colTonQuy, colTrangThai, colAnhHienTruong });
        dgvTramAtm.Dock = DockStyle.Fill;
        dgvTramAtm.Location = new Point(0, 212);
        dgvTramAtm.MultiSelect = false;
        dgvTramAtm.Name = "dgvTramAtm";
        dgvTramAtm.ReadOnly = true;
        dgvTramAtm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTramAtm.Size = new Size(824, 308);
        dgvTramAtm.TabIndex = 1;
        dgvTramAtm.SelectionChanged += dgvTramAtm_SelectionChanged;
        // 
        // colMaTram
        // 
        colMaTram.DataPropertyName = "MaTram";
        colMaTram.FillWeight = 65F;
        colMaTram.HeaderText = "Mã trạm";
        colMaTram.Name = "colMaTram";
        colMaTram.ReadOnly = true;
        // 
        // colDiaChi
        // 
        colDiaChi.DataPropertyName = "DiaChi";
        colDiaChi.FillWeight = 150F;
        colDiaChi.HeaderText = "Địa chỉ đặt máy";
        colDiaChi.Name = "colDiaChi";
        colDiaChi.ReadOnly = true;
        // 
        // colTonQuy
        // 
        colTonQuy.DataPropertyName = "TonQuy";
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle1.Format = "N0";
        colTonQuy.DefaultCellStyle = dataGridViewCellStyle1;
        colTonQuy.FillWeight = 90F;
        colTonQuy.HeaderText = "Tồn quỹ (VNĐ)";
        colTonQuy.Name = "colTonQuy";
        colTonQuy.ReadOnly = true;
        // 
        // colTrangThai
        // 
        colTrangThai.DataPropertyName = "TrangThai";
        colTrangThai.FillWeight = 75F;
        colTrangThai.HeaderText = "Trạng thái";
        colTrangThai.Name = "colTrangThai";
        colTrangThai.ReadOnly = true;
        // 
        // colAnhHienTruong
        // 
        colAnhHienTruong.DataPropertyName = "AnhHienTruong";
        colAnhHienTruong.FillWeight = 120F;
        colAnhHienTruong.HeaderText = "Ảnh hiện trường";
        colAnhHienTruong.Name = "colAnhHienTruong";
        colAnhHienTruong.ReadOnly = true;
        // 
        // ofdAnhTram
        // 
        ofdAnhTram.Filter = "Tệp ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
        ofdAnhTram.Title = "Chọn ảnh chụp hiện trường trạm ATM";
        // 
        // frmAtmStations
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(824, 520);
        Controls.Add(dgvTramAtm);
        Controls.Add(grpThongTin);
        Name = "frmAtmStations";
        Text = "Quản lý Danh sách Trạm ATM & Tồn quỹ";
        FormClosed += frmAtmStations_FormClosed;
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picHienTruong).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvTramAtm).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpThongTin;
    private Label lblMaTram;
    private TextBox txtMaTram;
    private Label lblDiaChi;
    private TextBox txtDiaChi;
    private Label lblTonQuy;
    private TextBox txtTonQuy;
    private Label lblTrangThai;
    private ComboBox cboTrangThai;
    private Button btnThem;
    private Button btnCapNhat;
    private Button btnXoa;
    private PictureBox picHienTruong;
    private Button btnChonAnh;
    private DataGridView dgvTramAtm;
    private DataGridViewTextBoxColumn colMaTram;
    private DataGridViewTextBoxColumn colDiaChi;
    private DataGridViewTextBoxColumn colTonQuy;
    private DataGridViewTextBoxColumn colTrangThai;
    private DataGridViewTextBoxColumn colAnhHienTruong;
    private OpenFileDialog ofdAnhTram;
}

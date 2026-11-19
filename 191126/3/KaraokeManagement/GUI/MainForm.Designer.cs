namespace KaraokeManagement.GUI;

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
        grpSoDoPhong = new GroupBox();
        flpPhongHat = new FlowLayoutPanel();
        grpThongTinPhong = new GroupBox();
        btnMoPhong = new Button();
        lblGioVao = new Label();
        lblTrangThaiPhong = new Label();
        lblGiaGio = new Label();
        lblLoaiPhong = new Label();
        lblTenPhong = new Label();
        grpDichVu = new GroupBox();
        dgvDichVuDaGoi = new DataGridView();
        colDV_Ten = new DataGridViewTextBoxColumn();
        colDV_SoLuong = new DataGridViewTextBoxColumn();
        colDV_DonGia = new DataGridViewTextBoxColumn();
        colDV_ThanhTien = new DataGridViewTextBoxColumn();
        btnThemDichVu = new Button();
        nudSoLuongDV = new NumericUpDown();
        lblSoLuongDV = new Label();
        cboDichVu = new ComboBox();
        lblChonDV = new Label();
        grpThanhToan = new GroupBox();
        btnThanhToan = new Button();
        lblTongTienDuKien = new Label();
        lblTienDichVuTamTinh = new Label();
        lblTienPhongTamTinh = new Label();
        grpSoDoPhong.SuspendLayout();
        grpThongTinPhong.SuspendLayout();
        grpDichVu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDichVuDaGoi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongDV).BeginInit();
        grpThanhToan.SuspendLayout();
        SuspendLayout();
        // 
        // grpSoDoPhong
        // 
        grpSoDoPhong.Controls.Add(flpPhongHat);
        grpSoDoPhong.Location = new Point(15, 15);
        grpSoDoPhong.Name = "grpSoDoPhong";
        grpSoDoPhong.Padding = new Padding(10);
        grpSoDoPhong.Size = new Size(460, 580);
        grpSoDoPhong.TabIndex = 0;
        grpSoDoPhong.TabStop = false;
        grpSoDoPhong.Text = "Sơ đồ Phòng hát";
        // 
        // flpPhongHat
        // 
        flpPhongHat.AutoScroll = true;
        flpPhongHat.Dock = DockStyle.Fill;
        flpPhongHat.Location = new Point(10, 30);
        flpPhongHat.Name = "flpPhongHat";
        flpPhongHat.Padding = new Padding(5);
        flpPhongHat.Size = new Size(440, 540);
        flpPhongHat.TabIndex = 0;
        // 
        // grpThongTinPhong
        // 
        grpThongTinPhong.Controls.Add(btnMoPhong);
        grpThongTinPhong.Controls.Add(lblGioVao);
        grpThongTinPhong.Controls.Add(lblTrangThaiPhong);
        grpThongTinPhong.Controls.Add(lblGiaGio);
        grpThongTinPhong.Controls.Add(lblLoaiPhong);
        grpThongTinPhong.Controls.Add(lblTenPhong);
        grpThongTinPhong.Location = new Point(490, 15);
        grpThongTinPhong.Name = "grpThongTinPhong";
        grpThongTinPhong.Size = new Size(480, 150);
        grpThongTinPhong.TabIndex = 1;
        grpThongTinPhong.TabStop = false;
        grpThongTinPhong.Text = "Thông tin phòng đang chọn";
        // 
        // btnMoPhong
        // 
        btnMoPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMoPhong.Location = new Point(330, 95);
        btnMoPhong.Name = "btnMoPhong";
        btnMoPhong.Size = new Size(135, 40);
        btnMoPhong.TabIndex = 5;
        btnMoPhong.Text = "MỞ PHÒNG";
        btnMoPhong.UseVisualStyleBackColor = true;
        btnMoPhong.Click += btnMoPhong_Click;
        // 
        // lblGioVao
        // 
        lblGioVao.AutoSize = true;
        lblGioVao.Location = new Point(20, 105);
        lblGioVao.Name = "lblGioVao";
        lblGioVao.Size = new Size(94, 20);
        lblGioVao.TabIndex = 4;
        lblGioVao.Text = "Giờ vào: --:--";
        // 
        // lblTrangThaiPhong
        // 
        lblTrangThaiPhong.AutoSize = true;
        lblTrangThaiPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTrangThaiPhong.Location = new Point(260, 68);
        lblTrangThaiPhong.Name = "lblTrangThaiPhong";
        lblTrangThaiPhong.Size = new Size(129, 20);
        lblTrangThaiPhong.TabIndex = 3;
        lblTrangThaiPhong.Text = "Trạng thái: Trống";
        // 
        // lblGiaGio
        // 
        lblGiaGio.AutoSize = true;
        lblGiaGio.Location = new Point(20, 68);
        lblGiaGio.Name = "lblGiaGio";
        lblGiaGio.Size = new Size(113, 20);
        lblGiaGio.TabIndex = 2;
        lblGiaGio.Text = "Giá giờ: 0 đ/giờ";
        // 
        // lblLoaiPhong
        // 
        lblLoaiPhong.AutoSize = true;
        lblLoaiPhong.Location = new Point(260, 30);
        lblLoaiPhong.Name = "lblLoaiPhong";
        lblLoaiPhong.Size = new Size(112, 20);
        lblLoaiPhong.TabIndex = 1;
        lblLoaiPhong.Text = "Loại phòng: VIP";
        // 
        // lblTenPhong
        // 
        lblTenPhong.AutoSize = true;
        lblTenPhong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTenPhong.Location = new Point(20, 26);
        lblTenPhong.Name = "lblTenPhong";
        lblTenPhong.Size = new Size(171, 25);
        lblTenPhong.TabIndex = 0;
        lblTenPhong.Text = "Chưa chọn phòng";
        // 
        // grpDichVu
        // 
        grpDichVu.Controls.Add(dgvDichVuDaGoi);
        grpDichVu.Controls.Add(btnThemDichVu);
        grpDichVu.Controls.Add(nudSoLuongDV);
        grpDichVu.Controls.Add(lblSoLuongDV);
        grpDichVu.Controls.Add(cboDichVu);
        grpDichVu.Controls.Add(lblChonDV);
        grpDichVu.Location = new Point(490, 175);
        grpDichVu.Name = "grpDichVu";
        grpDichVu.Size = new Size(480, 265);
        grpDichVu.TabIndex = 2;
        grpDichVu.TabStop = false;
        grpDichVu.Text = "Gọi Dịch vụ / Đồ uống";
        // 
        // dgvDichVuDaGoi
        // 
        dgvDichVuDaGoi.AllowUserToAddRows = false;
        dgvDichVuDaGoi.AllowUserToDeleteRows = false;
        dgvDichVuDaGoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDichVuDaGoi.Columns.AddRange(new DataGridViewColumn[] { colDV_Ten, colDV_SoLuong, colDV_DonGia, colDV_ThanhTien });
        dgvDichVuDaGoi.Location = new Point(15, 75);
        dgvDichVuDaGoi.MultiSelect = false;
        dgvDichVuDaGoi.Name = "dgvDichVuDaGoi";
        dgvDichVuDaGoi.ReadOnly = true;
        dgvDichVuDaGoi.RowHeadersWidth = 51;
        dgvDichVuDaGoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDichVuDaGoi.Size = new Size(450, 175);
        dgvDichVuDaGoi.TabIndex = 5;
        // 
        // colDV_Ten
        // 
        colDV_Ten.DataPropertyName = "TenDV";
        colDV_Ten.HeaderText = "Dịch Vụ";
        colDV_Ten.MinimumWidth = 6;
        colDV_Ten.Name = "colDV_Ten";
        colDV_Ten.ReadOnly = true;
        colDV_Ten.Width = 150;
        // 
        // colDV_SoLuong
        // 
        colDV_SoLuong.DataPropertyName = "SoLuong";
        colDV_SoLuong.HeaderText = "SL";
        colDV_SoLuong.MinimumWidth = 6;
        colDV_SoLuong.Name = "colDV_SoLuong";
        colDV_SoLuong.ReadOnly = true;
        colDV_SoLuong.Width = 50;
        // 
        // colDV_DonGia
        // 
        colDV_DonGia.DataPropertyName = "DonGia";
        colDV_DonGia.HeaderText = "Đơn Giá";
        colDV_DonGia.MinimumWidth = 6;
        colDV_DonGia.Name = "colDV_DonGia";
        colDV_DonGia.ReadOnly = true;
        colDV_DonGia.Width = 110;
        // 
        // colDV_ThanhTien
        // 
        colDV_ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colDV_ThanhTien.DataPropertyName = "ThanhTien";
        colDV_ThanhTien.HeaderText = "Thành Tiền";
        colDV_ThanhTien.MinimumWidth = 6;
        colDV_ThanhTien.Name = "colDV_ThanhTien";
        colDV_ThanhTien.ReadOnly = true;
        // 
        // btnThemDichVu
        // 
        btnThemDichVu.Location = new Point(390, 27);
        btnThemDichVu.Name = "btnThemDichVu";
        btnThemDichVu.Size = new Size(75, 30);
        btnThemDichVu.TabIndex = 4;
        btnThemDichVu.Text = "Thêm";
        btnThemDichVu.UseVisualStyleBackColor = true;
        btnThemDichVu.Click += btnThemDichVu_Click;
        // 
        // nudSoLuongDV
        // 
        nudSoLuongDV.Location = new Point(325, 29);
        nudSoLuongDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuongDV.Name = "nudSoLuongDV";
        nudSoLuongDV.Size = new Size(55, 27);
        nudSoLuongDV.TabIndex = 3;
        nudSoLuongDV.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblSoLuongDV
        // 
        lblSoLuongDV.AutoSize = true;
        lblSoLuongDV.Location = new Point(290, 32);
        lblSoLuongDV.Name = "lblSoLuongDV";
        lblSoLuongDV.Size = new Size(27, 20);
        lblSoLuongDV.TabIndex = 2;
        lblSoLuongDV.Text = "SL:";
        // 
        // cboDichVu
        // 
        cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDichVu.FormattingEnabled = true;
        cboDichVu.Location = new Point(70, 28);
        cboDichVu.Name = "cboDichVu";
        cboDichVu.Size = new Size(210, 28);
        cboDichVu.TabIndex = 1;
        // 
        // lblChonDV
        // 
        lblChonDV.AutoSize = true;
        lblChonDV.Location = new Point(15, 32);
        lblChonDV.Name = "lblChonDV";
        lblChonDV.Size = new Size(58, 20);
        lblChonDV.TabIndex = 0;
        lblChonDV.Text = "DV/Đồ:";
        // 
        // grpThanhToan
        // 
        grpThanhToan.Controls.Add(btnThanhToan);
        grpThanhToan.Controls.Add(lblTongTienDuKien);
        grpThanhToan.Controls.Add(lblTienDichVuTamTinh);
        grpThanhToan.Controls.Add(lblTienPhongTamTinh);
        grpThanhToan.Location = new Point(490, 450);
        grpThanhToan.Name = "grpThanhToan";
        grpThanhToan.Size = new Size(480, 145);
        grpThanhToan.TabIndex = 3;
        grpThanhToan.TabStop = false;
        grpThanhToan.Text = "Tính Tiền + Thanh Toán";
        // 
        // btnThanhToan
        // 
        btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnThanhToan.Location = new Point(275, 45);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new Size(190, 65);
        btnThanhToan.TabIndex = 3;
        btnThanhToan.Text = "THANH TOÁN";
        btnThanhToan.UseVisualStyleBackColor = true;
        btnThanhToan.Click += btnThanhToan_Click;
        // 
        // lblTongTienDuKien
        // 
        lblTongTienDuKien.AutoSize = true;
        lblTongTienDuKien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTongTienDuKien.ForeColor = Color.DarkRed;
        lblTongTienDuKien.Location = new Point(15, 95);
        lblTongTienDuKien.Name = "lblTongTienDuKien";
        lblTongTienDuKien.Size = new Size(194, 25);
        lblTongTienDuKien.TabIndex = 2;
        lblTongTienDuKien.Text = "TỔNG CỘNG: 0 VNĐ";
        // 
        // lblTienDichVuTamTinh
        // 
        lblTienDichVuTamTinh.AutoSize = true;
        lblTienDichVuTamTinh.Location = new Point(15, 60);
        lblTienDichVuTamTinh.Name = "lblTienDichVuTamTinh";
        lblTienDichVuTamTinh.Size = new Size(138, 20);
        lblTienDichVuTamTinh.TabIndex = 1;
        lblTienDichVuTamTinh.Text = "Tiền dịch vụ: 0 VNĐ";
        // 
        // lblTienPhongTamTinh
        // 
        lblTienPhongTamTinh.AutoSize = true;
        lblTienPhongTamTinh.Location = new Point(15, 28);
        lblTienPhongTamTinh.Name = "lblTienPhongTamTinh";
        lblTienPhongTamTinh.Size = new Size(193, 20);
        lblTienPhongTamTinh.TabIndex = 0;
        lblTienPhongTamTinh.Text = "Tiền phòng tạm tính: 0 VNĐ";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(984, 611);
        Controls.Add(grpThanhToan);
        Controls.Add(grpDichVu);
        Controls.Add(grpThongTinPhong);
        Controls.Add(grpSoDoPhong);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý Đặt phòng & Dịch vụ Karaoke";
        Load += MainForm_Load;
        grpSoDoPhong.ResumeLayout(false);
        grpThongTinPhong.ResumeLayout(false);
        grpThongTinPhong.PerformLayout();
        grpDichVu.ResumeLayout(false);
        grpDichVu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDichVuDaGoi).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuongDV).EndInit();
        grpThanhToan.ResumeLayout(false);
        grpThanhToan.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpSoDoPhong;
    private FlowLayoutPanel flpPhongHat;
    private GroupBox grpThongTinPhong;
    private Label lblTenPhong;
    private Label lblLoaiPhong;
    private Label lblGiaGio;
    private Label lblTrangThaiPhong;
    private Label lblGioVao;
    private Button btnMoPhong;
    private GroupBox grpDichVu;
    private Label lblChonDV;
    private ComboBox cboDichVu;
    private Label lblSoLuongDV;
    private NumericUpDown nudSoLuongDV;
    private Button btnThemDichVu;
    private DataGridView dgvDichVuDaGoi;
    private DataGridViewTextBoxColumn colDV_Ten;
    private DataGridViewTextBoxColumn colDV_SoLuong;
    private DataGridViewTextBoxColumn colDV_DonGia;
    private DataGridViewTextBoxColumn colDV_ThanhTien;
    private GroupBox grpThanhToan;
    private Label lblTienPhongTamTinh;
    private Label lblTienDichVuTamTinh;
    private Label lblTongTienDuKien;
    private Button btnThanhToan;
}


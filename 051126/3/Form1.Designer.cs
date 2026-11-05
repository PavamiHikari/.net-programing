namespace RepairServiceTracker;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuFile;
    private System.Windows.Forms.ToolStripMenuItem menuItemXuatCsv;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuItemThoat;

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblStatus;

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.TableLayoutPanel tblInput;
    private System.Windows.Forms.Label lblMaDon;
    private System.Windows.Forms.TextBox txtMaDon;
    private System.Windows.Forms.Label lblTenKhachHang;
    private System.Windows.Forms.TextBox txtTenKhachHang;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.Label lblLoaiThietBi;
    private System.Windows.Forms.ComboBox cboLoaiThietBi;
    private System.Windows.Forms.Label lblNgayTiepNhan;
    private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
    private System.Windows.Forms.Label lblChiPhi;
    private System.Windows.Forms.TextBox txtChiPhiDuKien;
    private System.Windows.Forms.Label lblTrangThai;
    private System.Windows.Forms.ComboBox cboTrangThai;
    private System.Windows.Forms.Label lblMoTaLoi;
    private System.Windows.Forms.TextBox txtMoTaLoi;

    private System.Windows.Forms.Panel panelImage;
    private System.Windows.Forms.Label lblTieuDeAnh;
    private System.Windows.Forms.PictureBox picHinhAnh;
    private System.Windows.Forms.Label lblDuongDanAnh;
    private System.Windows.Forms.FlowLayoutPanel flowImgButtons;
    private System.Windows.Forms.Button btnChonAnh;
    private System.Windows.Forms.Button btnXoaAnh;

    private System.Windows.Forms.FlowLayoutPanel flowButtons;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.FlowLayoutPanel flowFilter;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label lblLocTrangThai;
    private System.Windows.Forms.ComboBox cboLocTrangThai;

    private System.Windows.Forms.Panel panelGrid;
    private System.Windows.Forms.DataGridView dgvOrders;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        menuFile = new ToolStripMenuItem();
        menuItemXuatCsv = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        menuItemThoat = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        panelTop = new Panel();
        grpTimKiem = new GroupBox();
        flowFilter = new FlowLayoutPanel();
        lblTimKiem = new Label();
        txtTimKiem = new TextBox();
        lblLocTrangThai = new Label();
        cboLocTrangThai = new ComboBox();
        grpThongTin = new GroupBox();
        panelImage = new Panel();
        picHinhAnh = new PictureBox();
        lblDuongDanAnh = new Label();
        flowImgButtons = new FlowLayoutPanel();
        btnChonAnh = new Button();
        btnXoaAnh = new Button();
        lblTieuDeAnh = new Label();
        tblInput = new TableLayoutPanel();
        lblMaDon = new Label();
        txtMaDon = new TextBox();
        lblTenKhachHang = new Label();
        txtTenKhachHang = new TextBox();
        lblSoDienThoai = new Label();
        txtSoDienThoai = new TextBox();
        lblLoaiThietBi = new Label();
        cboLoaiThietBi = new ComboBox();
        lblNgayTiepNhan = new Label();
        dtpNgayTiepNhan = new DateTimePicker();
        lblChiPhi = new Label();
        txtChiPhiDuKien = new TextBox();
        lblTrangThai = new Label();
        cboTrangThai = new ComboBox();
        lblMoTaLoi = new Label();
        txtMoTaLoi = new TextBox();
        flowButtons = new FlowLayoutPanel();
        btnThem = new Button();
        btnCapNhat = new Button();
        btnXoa = new Button();
        btnLamMoi = new Button();
        panelGrid = new Panel();
        dgvOrders = new DataGridView();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        panelTop.SuspendLayout();
        grpTimKiem.SuspendLayout();
        flowFilter.SuspendLayout();
        grpThongTin.SuspendLayout();
        panelImage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
        flowImgButtons.SuspendLayout();
        tblInput.SuspendLayout();
        flowButtons.SuspendLayout();
        panelGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1000, 28);
        menuStrip1.TabIndex = 0;
        // 
        // menuFile
        // 
        menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemXuatCsv, toolStripSeparator1, menuItemThoat });
        menuFile.Name = "menuFile";
        menuFile.Size = new Size(85, 24);
        menuFile.Text = "Hệ thống";
        // 
        // menuItemXuatCsv
        // 
        menuItemXuatCsv.Name = "menuItemXuatCsv";
        menuItemXuatCsv.Size = new Size(248, 26);
        menuItemXuatCsv.Text = "Xuất danh sách ra CSV...";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(245, 6);
        // 
        // menuItemThoat
        // 
        menuItemThoat.Name = "menuItemThoat";
        menuItemThoat.Size = new Size(248, 26);
        menuItemThoat.Text = "Thoát";
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip1.Location = new Point(0, 636);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1000, 26);
        statusStrip1.TabIndex = 2;
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(68, 20);
        lblStatus.Text = "Sẵn sàng";
        // 
        // panelTop
        // 
        panelTop.Controls.Add(grpTimKiem);
        panelTop.Controls.Add(grpThongTin);
        panelTop.Dock = DockStyle.Top;
        panelTop.Location = new Point(0, 28);
        panelTop.Name = "panelTop";
        panelTop.Padding = new Padding(10, 5, 10, 5);
        panelTop.Size = new Size(1000, 310);
        panelTop.TabIndex = 1;
        // 
        // grpTimKiem
        // 
        grpTimKiem.Controls.Add(flowFilter);
        grpTimKiem.Dock = DockStyle.Bottom;
        grpTimKiem.Location = new Point(10, 245);
        grpTimKiem.Name = "grpTimKiem";
        grpTimKiem.Size = new Size(980, 60);
        grpTimKiem.TabIndex = 0;
        grpTimKiem.TabStop = false;
        grpTimKiem.Text = "Tìm Kiếm & Lọc Đơn";
        // 
        // flowFilter
        // 
        flowFilter.Controls.Add(lblTimKiem);
        flowFilter.Controls.Add(txtTimKiem);
        flowFilter.Controls.Add(lblLocTrangThai);
        flowFilter.Controls.Add(cboLocTrangThai);
        flowFilter.Dock = DockStyle.Fill;
        flowFilter.Location = new Point(3, 23);
        flowFilter.Name = "flowFilter";
        flowFilter.Padding = new Padding(5);
        flowFilter.Size = new Size(974, 34);
        flowFilter.TabIndex = 0;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new Point(8, 5);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Padding = new Padding(0, 5, 0, 0);
        lblTimKiem.Size = new Size(240, 25);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm kiếm (Mã đơn / Tên KH / SĐT):";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Location = new Point(254, 8);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new Size(200, 27);
        txtTimKiem.TabIndex = 1;
        // 
        // lblLocTrangThai
        // 
        lblLocTrangThai.AutoSize = true;
        lblLocTrangThai.Location = new Point(460, 5);
        lblLocTrangThai.Name = "lblLocTrangThai";
        lblLocTrangThai.Padding = new Padding(20, 5, 0, 0);
        lblLocTrangThai.Size = new Size(98, 25);
        lblLocTrangThai.TabIndex = 2;
        lblLocTrangThai.Text = "Trạng thái:";
        // 
        // cboLocTrangThai
        // 
        cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocTrangThai.Location = new Point(564, 8);
        cboLocTrangThai.Name = "cboLocTrangThai";
        cboLocTrangThai.Size = new Size(140, 28);
        cboLocTrangThai.TabIndex = 3;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(panelImage);
        grpThongTin.Controls.Add(tblInput);
        grpThongTin.Controls.Add(flowButtons);
        grpThongTin.Dock = DockStyle.Top;
        grpThongTin.Location = new Point(10, 5);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(980, 235);
        grpThongTin.TabIndex = 1;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông Tin Đơn Sửa Chữa";
        // 
        // panelImage
        // 
        panelImage.Controls.Add(picHinhAnh);
        panelImage.Controls.Add(lblDuongDanAnh);
        panelImage.Controls.Add(flowImgButtons);
        panelImage.Controls.Add(lblTieuDeAnh);
        panelImage.Dock = DockStyle.Right;
        panelImage.Location = new Point(767, 23);
        panelImage.Name = "panelImage";
        panelImage.Padding = new Padding(5);
        panelImage.Size = new Size(210, 174);
        panelImage.TabIndex = 0;
        // 
        // picHinhAnh
        // 
        picHinhAnh.Dock = DockStyle.Fill;
        picHinhAnh.Location = new Point(5, 23);
        picHinhAnh.Name = "picHinhAnh";
        picHinhAnh.Size = new Size(200, 100);
        picHinhAnh.TabIndex = 0;
        picHinhAnh.TabStop = false;
        // 
        // lblDuongDanAnh
        // 
        lblDuongDanAnh.Dock = DockStyle.Bottom;
        lblDuongDanAnh.Location = new Point(5, 123);
        lblDuongDanAnh.Name = "lblDuongDanAnh";
        lblDuongDanAnh.Size = new Size(200, 16);
        lblDuongDanAnh.TabIndex = 1;
        lblDuongDanAnh.Text = "(Chưa chọn ảnh)";
        lblDuongDanAnh.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // flowImgButtons
        // 
        flowImgButtons.Controls.Add(btnChonAnh);
        flowImgButtons.Controls.Add(btnXoaAnh);
        flowImgButtons.Dock = DockStyle.Bottom;
        flowImgButtons.Location = new Point(5, 139);
        flowImgButtons.Name = "flowImgButtons";
        flowImgButtons.Size = new Size(200, 30);
        flowImgButtons.TabIndex = 2;
        // 
        // btnChonAnh
        // 
        btnChonAnh.Location = new Point(3, 3);
        btnChonAnh.Name = "btnChonAnh";
        btnChonAnh.Size = new Size(90, 26);
        btnChonAnh.TabIndex = 0;
        btnChonAnh.Text = "Chọn ảnh...";
        // 
        // btnXoaAnh
        // 
        btnXoaAnh.Location = new Point(99, 3);
        btnXoaAnh.Name = "btnXoaAnh";
        btnXoaAnh.Size = new Size(60, 26);
        btnXoaAnh.TabIndex = 1;
        btnXoaAnh.Text = "Xóa";
        // 
        // lblTieuDeAnh
        // 
        lblTieuDeAnh.Dock = DockStyle.Top;
        lblTieuDeAnh.Location = new Point(5, 5);
        lblTieuDeAnh.Name = "lblTieuDeAnh";
        lblTieuDeAnh.Size = new Size(200, 18);
        lblTieuDeAnh.TabIndex = 3;
        lblTieuDeAnh.Text = "Ảnh thiết bị:";
        // 
        // tblInput
        // 
        tblInput.ColumnCount = 4;
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.Controls.Add(lblMaDon, 0, 0);
        tblInput.Controls.Add(txtMaDon, 1, 0);
        tblInput.Controls.Add(lblTenKhachHang, 2, 0);
        tblInput.Controls.Add(txtTenKhachHang, 3, 0);
        tblInput.Controls.Add(lblSoDienThoai, 0, 1);
        tblInput.Controls.Add(txtSoDienThoai, 1, 1);
        tblInput.Controls.Add(lblLoaiThietBi, 2, 1);
        tblInput.Controls.Add(cboLoaiThietBi, 3, 1);
        tblInput.Controls.Add(lblNgayTiepNhan, 0, 2);
        tblInput.Controls.Add(dtpNgayTiepNhan, 1, 2);
        tblInput.Controls.Add(lblChiPhi, 2, 2);
        tblInput.Controls.Add(txtChiPhiDuKien, 3, 2);
        tblInput.Controls.Add(lblTrangThai, 0, 3);
        tblInput.Controls.Add(cboTrangThai, 1, 3);
        tblInput.Controls.Add(lblMoTaLoi, 0, 4);
        tblInput.Controls.Add(txtMoTaLoi, 1, 4);
        tblInput.Dock = DockStyle.Fill;
        tblInput.Location = new Point(3, 23);
        tblInput.Name = "tblInput";
        tblInput.RowCount = 5;
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        tblInput.Size = new Size(974, 174);
        tblInput.TabIndex = 1;
        // 
        // lblMaDon
        // 
        lblMaDon.Anchor = AnchorStyles.Left;
        lblMaDon.Location = new Point(3, 2);
        lblMaDon.Name = "lblMaDon";
        lblMaDon.Size = new Size(100, 23);
        lblMaDon.TabIndex = 0;
        lblMaDon.Text = "Mã đơn:";
        // 
        // txtMaDon
        // 
        txtMaDon.Dock = DockStyle.Fill;
        txtMaDon.Location = new Point(113, 3);
        txtMaDon.Name = "txtMaDon";
        txtMaDon.Size = new Size(371, 27);
        txtMaDon.TabIndex = 1;
        // 
        // lblTenKhachHang
        // 
        lblTenKhachHang.Anchor = AnchorStyles.Left;
        lblTenKhachHang.Location = new Point(490, 2);
        lblTenKhachHang.Name = "lblTenKhachHang";
        lblTenKhachHang.Size = new Size(100, 23);
        lblTenKhachHang.TabIndex = 2;
        lblTenKhachHang.Text = "Tên KH:";
        // 
        // txtTenKhachHang
        // 
        txtTenKhachHang.Dock = DockStyle.Fill;
        txtTenKhachHang.Location = new Point(600, 3);
        txtTenKhachHang.Name = "txtTenKhachHang";
        txtTenKhachHang.Size = new Size(371, 27);
        txtTenKhachHang.TabIndex = 3;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.Anchor = AnchorStyles.Left;
        lblSoDienThoai.Location = new Point(3, 30);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new Size(100, 23);
        lblSoDienThoai.TabIndex = 4;
        lblSoDienThoai.Text = "Số điện thoại:";
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Dock = DockStyle.Fill;
        txtSoDienThoai.Location = new Point(113, 31);
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.Size = new Size(371, 27);
        txtSoDienThoai.TabIndex = 5;
        // 
        // lblLoaiThietBi
        // 
        lblLoaiThietBi.Anchor = AnchorStyles.Left;
        lblLoaiThietBi.Location = new Point(490, 30);
        lblLoaiThietBi.Name = "lblLoaiThietBi";
        lblLoaiThietBi.Size = new Size(100, 23);
        lblLoaiThietBi.TabIndex = 6;
        lblLoaiThietBi.Text = "Loại thiết bị:";
        // 
        // cboLoaiThietBi
        // 
        cboLoaiThietBi.Dock = DockStyle.Fill;
        cboLoaiThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiThietBi.Location = new Point(600, 31);
        cboLoaiThietBi.Name = "cboLoaiThietBi";
        cboLoaiThietBi.Size = new Size(371, 28);
        cboLoaiThietBi.TabIndex = 7;
        // 
        // lblNgayTiepNhan
        // 
        lblNgayTiepNhan.Anchor = AnchorStyles.Left;
        lblNgayTiepNhan.Location = new Point(3, 58);
        lblNgayTiepNhan.Name = "lblNgayTiepNhan";
        lblNgayTiepNhan.Size = new Size(100, 23);
        lblNgayTiepNhan.TabIndex = 8;
        lblNgayTiepNhan.Text = "Ngày tiếp nhận:";
        // 
        // dtpNgayTiepNhan
        // 
        dtpNgayTiepNhan.Dock = DockStyle.Fill;
        dtpNgayTiepNhan.Location = new Point(113, 59);
        dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
        dtpNgayTiepNhan.Size = new Size(371, 27);
        dtpNgayTiepNhan.TabIndex = 9;
        // 
        // lblChiPhi
        // 
        lblChiPhi.Anchor = AnchorStyles.Left;
        lblChiPhi.Location = new Point(490, 58);
        lblChiPhi.Name = "lblChiPhi";
        lblChiPhi.Size = new Size(100, 23);
        lblChiPhi.TabIndex = 10;
        lblChiPhi.Text = "Chi phí dự kiến:";
        // 
        // txtChiPhiDuKien
        // 
        txtChiPhiDuKien.Dock = DockStyle.Fill;
        txtChiPhiDuKien.Location = new Point(600, 59);
        txtChiPhiDuKien.Name = "txtChiPhiDuKien";
        txtChiPhiDuKien.Size = new Size(371, 27);
        txtChiPhiDuKien.TabIndex = 11;
        // 
        // lblTrangThai
        // 
        lblTrangThai.Anchor = AnchorStyles.Left;
        lblTrangThai.Location = new Point(3, 86);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(100, 23);
        lblTrangThai.TabIndex = 12;
        lblTrangThai.Text = "Trạng thái:";
        // 
        // cboTrangThai
        // 
        cboTrangThai.Dock = DockStyle.Fill;
        cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThai.Location = new Point(113, 87);
        cboTrangThai.Name = "cboTrangThai";
        cboTrangThai.Size = new Size(371, 28);
        cboTrangThai.TabIndex = 13;
        // 
        // lblMoTaLoi
        // 
        lblMoTaLoi.Anchor = AnchorStyles.Left;
        lblMoTaLoi.Location = new Point(3, 131);
        lblMoTaLoi.Name = "lblMoTaLoi";
        lblMoTaLoi.Size = new Size(100, 23);
        lblMoTaLoi.TabIndex = 14;
        lblMoTaLoi.Text = "Mô tả lỗi:";
        // 
        // txtMoTaLoi
        // 
        tblInput.SetColumnSpan(txtMoTaLoi, 3);
        txtMoTaLoi.Dock = DockStyle.Fill;
        txtMoTaLoi.Location = new Point(113, 115);
        txtMoTaLoi.Multiline = true;
        txtMoTaLoi.Name = "txtMoTaLoi";
        txtMoTaLoi.ScrollBars = ScrollBars.Vertical;
        txtMoTaLoi.Size = new Size(858, 56);
        txtMoTaLoi.TabIndex = 15;
        // 
        // flowButtons
        // 
        flowButtons.Controls.Add(btnThem);
        flowButtons.Controls.Add(btnCapNhat);
        flowButtons.Controls.Add(btnXoa);
        flowButtons.Controls.Add(btnLamMoi);
        flowButtons.Dock = DockStyle.Bottom;
        flowButtons.Location = new Point(3, 197);
        flowButtons.Name = "flowButtons";
        flowButtons.Size = new Size(974, 35);
        flowButtons.TabIndex = 2;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(3, 3);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(85, 28);
        btnThem.TabIndex = 0;
        btnThem.Text = "Thêm";
        // 
        // btnCapNhat
        // 
        btnCapNhat.Location = new Point(94, 3);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new Size(85, 28);
        btnCapNhat.TabIndex = 1;
        btnCapNhat.Text = "Cập nhật";
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(185, 3);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(85, 28);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa";
        // 
        // btnLamMoi
        // 
        btnLamMoi.Location = new Point(276, 3);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(85, 28);
        btnLamMoi.TabIndex = 3;
        btnLamMoi.Text = "Làm mới";
        // 
        // panelGrid
        // 
        panelGrid.Controls.Add(dgvOrders);
        panelGrid.Dock = DockStyle.Fill;
        panelGrid.Location = new Point(0, 338);
        panelGrid.Name = "panelGrid";
        panelGrid.Padding = new Padding(10, 0, 10, 10);
        panelGrid.Size = new Size(1000, 298);
        panelGrid.TabIndex = 0;
        // 
        // dgvOrders
        // 
        dgvOrders.ColumnHeadersHeight = 29;
        dgvOrders.Dock = DockStyle.Fill;
        dgvOrders.Location = new Point(10, 0);
        dgvOrders.Name = "dgvOrders";
        dgvOrders.RowHeadersWidth = 51;
        dgvOrders.Size = new Size(980, 288);
        dgvOrders.TabIndex = 0;
        // 
        // Form1
        // 
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(1000, 662);
        Controls.Add(panelGrid);
        Controls.Add(panelTop);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        panelTop.ResumeLayout(false);
        grpTimKiem.ResumeLayout(false);
        flowFilter.ResumeLayout(false);
        flowFilter.PerformLayout();
        grpThongTin.ResumeLayout(false);
        panelImage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
        flowImgButtons.ResumeLayout(false);
        tblInput.ResumeLayout(false);
        tblInput.PerformLayout();
        flowButtons.ResumeLayout(false);
        panelGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}

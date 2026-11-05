namespace LabEquipmentCheckout;

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
    private System.Windows.Forms.Label lblMaPhieu;
    private System.Windows.Forms.TextBox txtMaPhieu;
    private System.Windows.Forms.Label lblMaSinhVien;
    private System.Windows.Forms.TextBox txtMaSinhVien;
    private System.Windows.Forms.Label lblHoTenSinhVien;
    private System.Windows.Forms.TextBox txtHoTenSinhVien;
    private System.Windows.Forms.Label lblThietBi;
    private System.Windows.Forms.ComboBox cboThietBi;
    private System.Windows.Forms.Label lblSoLuong;
    private System.Windows.Forms.NumericUpDown numSoLuong;
    private System.Windows.Forms.Label lblNgayMuon;
    private System.Windows.Forms.DateTimePicker dtpNgayMuon;
    private System.Windows.Forms.Label lblHanTra;
    private System.Windows.Forms.DateTimePicker dtpHanTra;
    private System.Windows.Forms.Label lblTraThucTe;
    private System.Windows.Forms.FlowLayoutPanel flowTraThucTe;
    private System.Windows.Forms.CheckBox chkDaTra;
    private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;

    private System.Windows.Forms.FlowLayoutPanel flowButtons;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnDanhDauDaTra;
    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.FlowLayoutPanel flowFilter;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label lblLocTinhTrang;
    private System.Windows.Forms.ComboBox cboLocTinhTrang;

    private System.Windows.Forms.Panel panelGrid;
    private System.Windows.Forms.DataGridView dgvCheckouts;

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
        lblLocTinhTrang = new Label();
        cboLocTinhTrang = new ComboBox();
        grpThongTin = new GroupBox();
        tblInput = new TableLayoutPanel();
        lblMaPhieu = new Label();
        txtMaPhieu = new TextBox();
        lblMaSinhVien = new Label();
        txtMaSinhVien = new TextBox();
        lblHoTenSinhVien = new Label();
        txtHoTenSinhVien = new TextBox();
        lblThietBi = new Label();
        cboThietBi = new ComboBox();
        lblSoLuong = new Label();
        numSoLuong = new NumericUpDown();
        lblNgayMuon = new Label();
        dtpNgayMuon = new DateTimePicker();
        lblHanTra = new Label();
        dtpHanTra = new DateTimePicker();
        lblTraThucTe = new Label();
        flowTraThucTe = new FlowLayoutPanel();
        chkDaTra = new CheckBox();
        dtpNgayTraThucTe = new DateTimePicker();
        flowButtons = new FlowLayoutPanel();
        btnThem = new Button();
        btnCapNhat = new Button();
        btnXoa = new Button();
        btnDanhDauDaTra = new Button();
        btnLamMoi = new Button();
        panelGrid = new Panel();
        dgvCheckouts = new DataGridView();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        panelTop.SuspendLayout();
        grpTimKiem.SuspendLayout();
        flowFilter.SuspendLayout();
        grpThongTin.SuspendLayout();
        tblInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
        flowTraThucTe.SuspendLayout();
        flowButtons.SuspendLayout();
        panelGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCheckouts).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(980, 28);
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
        statusStrip1.Location = new Point(0, 616);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(980, 26);
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
        panelTop.Size = new Size(980, 270);
        panelTop.TabIndex = 1;
        // 
        // grpTimKiem
        // 
        grpTimKiem.Controls.Add(flowFilter);
        grpTimKiem.Dock = DockStyle.Bottom;
        grpTimKiem.Location = new Point(10, 203);
        grpTimKiem.Name = "grpTimKiem";
        grpTimKiem.Size = new Size(960, 62);
        grpTimKiem.TabIndex = 0;
        grpTimKiem.TabStop = false;
        grpTimKiem.Text = "Tìm Kiếm & Lọc Phiếu";
        // 
        // flowFilter
        // 
        flowFilter.Controls.Add(lblTimKiem);
        flowFilter.Controls.Add(txtTimKiem);
        flowFilter.Controls.Add(lblLocTinhTrang);
        flowFilter.Controls.Add(cboLocTinhTrang);
        flowFilter.Dock = DockStyle.Fill;
        flowFilter.Location = new Point(3, 23);
        flowFilter.Name = "flowFilter";
        flowFilter.Padding = new Padding(5);
        flowFilter.Size = new Size(954, 36);
        flowFilter.TabIndex = 0;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new Point(8, 5);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Padding = new Padding(0, 5, 0, 0);
        lblTimKiem.Size = new Size(193, 25);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm kiếm (Mã SV / Thiết bị):";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Location = new Point(207, 8);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new Size(180, 27);
        txtTimKiem.TabIndex = 1;
        // 
        // lblLocTinhTrang
        // 
        lblLocTinhTrang.AutoSize = true;
        lblLocTinhTrang.Location = new Point(393, 5);
        lblLocTinhTrang.Name = "lblLocTinhTrang";
        lblLocTinhTrang.Padding = new Padding(20, 5, 0, 0);
        lblLocTinhTrang.Size = new Size(99, 25);
        lblLocTinhTrang.TabIndex = 2;
        lblLocTinhTrang.Text = "Tình trạng:";
        // 
        // cboLocTinhTrang
        // 
        cboLocTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocTinhTrang.Location = new Point(498, 8);
        cboLocTinhTrang.Name = "cboLocTinhTrang";
        cboLocTinhTrang.Size = new Size(140, 28);
        cboLocTinhTrang.TabIndex = 3;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(tblInput);
        grpThongTin.Controls.Add(flowButtons);
        grpThongTin.Dock = DockStyle.Top;
        grpThongTin.Location = new Point(10, 5);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(960, 195);
        grpThongTin.TabIndex = 1;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông Tin Phiếu Mượn Thiết Bị";
        // 
        // tblInput
        // 
        tblInput.ColumnCount = 4;
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.Controls.Add(lblMaPhieu, 0, 0);
        tblInput.Controls.Add(txtMaPhieu, 1, 0);
        tblInput.Controls.Add(lblMaSinhVien, 2, 0);
        tblInput.Controls.Add(txtMaSinhVien, 3, 0);
        tblInput.Controls.Add(lblHoTenSinhVien, 0, 1);
        tblInput.Controls.Add(txtHoTenSinhVien, 1, 1);
        tblInput.Controls.Add(lblThietBi, 2, 1);
        tblInput.Controls.Add(cboThietBi, 3, 1);
        tblInput.Controls.Add(lblSoLuong, 0, 2);
        tblInput.Controls.Add(numSoLuong, 1, 2);
        tblInput.Controls.Add(lblNgayMuon, 2, 2);
        tblInput.Controls.Add(dtpNgayMuon, 3, 2);
        tblInput.Controls.Add(lblHanTra, 0, 3);
        tblInput.Controls.Add(dtpHanTra, 1, 3);
        tblInput.Controls.Add(lblTraThucTe, 2, 3);
        tblInput.Controls.Add(flowTraThucTe, 3, 3);
        tblInput.Dock = DockStyle.Top;
        tblInput.Location = new Point(3, 23);
        tblInput.Name = "tblInput";
        tblInput.RowCount = 4;
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.Size = new Size(954, 125);
        tblInput.TabIndex = 0;
        // 
        // lblMaPhieu
        // 
        lblMaPhieu.Anchor = AnchorStyles.Left;
        lblMaPhieu.Location = new Point(3, 3);
        lblMaPhieu.Name = "lblMaPhieu";
        lblMaPhieu.Size = new Size(100, 23);
        lblMaPhieu.TabIndex = 0;
        lblMaPhieu.Text = "Mã phiếu:";
        // 
        // txtMaPhieu
        // 
        txtMaPhieu.Dock = DockStyle.Fill;
        txtMaPhieu.Location = new Point(113, 3);
        txtMaPhieu.Name = "txtMaPhieu";
        txtMaPhieu.Size = new Size(361, 27);
        txtMaPhieu.TabIndex = 1;
        // 
        // lblMaSinhVien
        // 
        lblMaSinhVien.Anchor = AnchorStyles.Left;
        lblMaSinhVien.Location = new Point(480, 3);
        lblMaSinhVien.Name = "lblMaSinhVien";
        lblMaSinhVien.Size = new Size(100, 23);
        lblMaSinhVien.TabIndex = 2;
        lblMaSinhVien.Text = "Mã sinh viên:";
        // 
        // txtMaSinhVien
        // 
        txtMaSinhVien.Dock = DockStyle.Fill;
        txtMaSinhVien.Location = new Point(590, 3);
        txtMaSinhVien.Name = "txtMaSinhVien";
        txtMaSinhVien.Size = new Size(361, 27);
        txtMaSinhVien.TabIndex = 3;
        // 
        // lblHoTenSinhVien
        // 
        lblHoTenSinhVien.Anchor = AnchorStyles.Left;
        lblHoTenSinhVien.Location = new Point(3, 33);
        lblHoTenSinhVien.Name = "lblHoTenSinhVien";
        lblHoTenSinhVien.Size = new Size(100, 23);
        lblHoTenSinhVien.TabIndex = 4;
        lblHoTenSinhVien.Text = "Họ tên SV:";
        // 
        // txtHoTenSinhVien
        // 
        txtHoTenSinhVien.Dock = DockStyle.Fill;
        txtHoTenSinhVien.Location = new Point(113, 33);
        txtHoTenSinhVien.Name = "txtHoTenSinhVien";
        txtHoTenSinhVien.Size = new Size(361, 27);
        txtHoTenSinhVien.TabIndex = 5;
        // 
        // lblThietBi
        // 
        lblThietBi.Anchor = AnchorStyles.Left;
        lblThietBi.Location = new Point(480, 33);
        lblThietBi.Name = "lblThietBi";
        lblThietBi.Size = new Size(100, 23);
        lblThietBi.TabIndex = 6;
        lblThietBi.Text = "Thiết bị:";
        // 
        // cboThietBi
        // 
        cboThietBi.Dock = DockStyle.Fill;
        cboThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThietBi.Location = new Point(590, 33);
        cboThietBi.Name = "cboThietBi";
        cboThietBi.Size = new Size(361, 28);
        cboThietBi.TabIndex = 7;
        // 
        // lblSoLuong
        // 
        lblSoLuong.Anchor = AnchorStyles.Left;
        lblSoLuong.Location = new Point(3, 63);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new Size(100, 23);
        lblSoLuong.TabIndex = 8;
        lblSoLuong.Text = "Số lượng:";
        // 
        // numSoLuong
        // 
        numSoLuong.Dock = DockStyle.Fill;
        numSoLuong.Location = new Point(113, 63);
        numSoLuong.Name = "numSoLuong";
        numSoLuong.Size = new Size(361, 27);
        numSoLuong.TabIndex = 9;
        // 
        // lblNgayMuon
        // 
        lblNgayMuon.Anchor = AnchorStyles.Left;
        lblNgayMuon.Location = new Point(480, 63);
        lblNgayMuon.Name = "lblNgayMuon";
        lblNgayMuon.Size = new Size(100, 23);
        lblNgayMuon.TabIndex = 10;
        lblNgayMuon.Text = "Ngày mượn:";
        // 
        // dtpNgayMuon
        // 
        dtpNgayMuon.Dock = DockStyle.Fill;
        dtpNgayMuon.Location = new Point(590, 63);
        dtpNgayMuon.Name = "dtpNgayMuon";
        dtpNgayMuon.Size = new Size(361, 27);
        dtpNgayMuon.TabIndex = 11;
        // 
        // lblHanTra
        // 
        lblHanTra.Anchor = AnchorStyles.Left;
        lblHanTra.Location = new Point(3, 96);
        lblHanTra.Name = "lblHanTra";
        lblHanTra.Size = new Size(100, 23);
        lblHanTra.TabIndex = 12;
        lblHanTra.Text = "Hạn trả:";
        // 
        // dtpHanTra
        // 
        dtpHanTra.Dock = DockStyle.Fill;
        dtpHanTra.Location = new Point(113, 93);
        dtpHanTra.Name = "dtpHanTra";
        dtpHanTra.Size = new Size(361, 27);
        dtpHanTra.TabIndex = 13;
        // 
        // lblTraThucTe
        // 
        lblTraThucTe.Anchor = AnchorStyles.Left;
        lblTraThucTe.Location = new Point(480, 96);
        lblTraThucTe.Name = "lblTraThucTe";
        lblTraThucTe.Size = new Size(100, 23);
        lblTraThucTe.TabIndex = 14;
        lblTraThucTe.Text = "Trả thực tế:";
        // 
        // flowTraThucTe
        // 
        flowTraThucTe.Controls.Add(chkDaTra);
        flowTraThucTe.Controls.Add(dtpNgayTraThucTe);
        flowTraThucTe.Dock = DockStyle.Fill;
        flowTraThucTe.Location = new Point(587, 90);
        flowTraThucTe.Margin = new Padding(0);
        flowTraThucTe.Name = "flowTraThucTe";
        flowTraThucTe.Size = new Size(367, 35);
        flowTraThucTe.TabIndex = 15;
        // 
        // chkDaTra
        // 
        chkDaTra.AutoSize = true;
        chkDaTra.Location = new Point(3, 3);
        chkDaTra.Name = "chkDaTra";
        chkDaTra.Padding = new Padding(0, 3, 5, 0);
        chkDaTra.Size = new Size(77, 27);
        chkDaTra.TabIndex = 0;
        chkDaTra.Text = "Đã trả";
        // 
        // dtpNgayTraThucTe
        // 
        dtpNgayTraThucTe.Location = new Point(86, 3);
        dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
        dtpNgayTraThucTe.Size = new Size(110, 27);
        dtpNgayTraThucTe.TabIndex = 1;
        // 
        // flowButtons
        // 
        flowButtons.Controls.Add(btnThem);
        flowButtons.Controls.Add(btnCapNhat);
        flowButtons.Controls.Add(btnXoa);
        flowButtons.Controls.Add(btnDanhDauDaTra);
        flowButtons.Controls.Add(btnLamMoi);
        flowButtons.Dock = DockStyle.Bottom;
        flowButtons.Location = new Point(3, 157);
        flowButtons.Name = "flowButtons";
        flowButtons.Size = new Size(954, 35);
        flowButtons.TabIndex = 1;
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
        // btnDanhDauDaTra
        // 
        btnDanhDauDaTra.Location = new Point(276, 3);
        btnDanhDauDaTra.Name = "btnDanhDauDaTra";
        btnDanhDauDaTra.Size = new Size(120, 28);
        btnDanhDauDaTra.TabIndex = 3;
        btnDanhDauDaTra.Text = "Đánh dấu đã trả";
        // 
        // btnLamMoi
        // 
        btnLamMoi.Location = new Point(402, 3);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(85, 28);
        btnLamMoi.TabIndex = 4;
        btnLamMoi.Text = "Làm mới";
        // 
        // panelGrid
        // 
        panelGrid.Controls.Add(dgvCheckouts);
        panelGrid.Dock = DockStyle.Fill;
        panelGrid.Location = new Point(0, 298);
        panelGrid.Name = "panelGrid";
        panelGrid.Padding = new Padding(10, 0, 10, 10);
        panelGrid.Size = new Size(980, 318);
        panelGrid.TabIndex = 0;
        // 
        // dgvCheckouts
        // 
        dgvCheckouts.ColumnHeadersHeight = 29;
        dgvCheckouts.Dock = DockStyle.Fill;
        dgvCheckouts.Location = new Point(10, 0);
        dgvCheckouts.Name = "dgvCheckouts";
        dgvCheckouts.RowHeadersWidth = 51;
        dgvCheckouts.Size = new Size(960, 308);
        dgvCheckouts.TabIndex = 0;
        // 
        // Form1
        // 
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(980, 642);
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
        tblInput.ResumeLayout(false);
        tblInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
        flowTraThucTe.ResumeLayout(false);
        flowTraThucTe.PerformLayout();
        flowButtons.ResumeLayout(false);
        panelGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCheckouts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}

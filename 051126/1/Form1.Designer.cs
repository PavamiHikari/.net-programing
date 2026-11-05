namespace ClinicAppointmentManager;

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

    private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.TableLayoutPanel tblInput;
    private System.Windows.Forms.Label lblMaLichHen;
    private System.Windows.Forms.TextBox txtMaLichHen;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.Label lblNgayGio;
    private System.Windows.Forms.DateTimePicker dtpNgayGio;
    private System.Windows.Forms.Label lblBacSi;
    private System.Windows.Forms.ComboBox cboBacSi;
    private System.Windows.Forms.Label lblTrangThai;
    private System.Windows.Forms.ComboBox cboTrangThai;
    private System.Windows.Forms.Label lblLyDoKham;
    private System.Windows.Forms.TextBox txtLyDoKham;

    private System.Windows.Forms.FlowLayoutPanel flowButtons;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.FlowLayoutPanel flowFilter;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.CheckBox chkLocNgay;
    private System.Windows.Forms.DateTimePicker dtpLocNgay;
    private System.Windows.Forms.Label lblLocTrangThai;
    private System.Windows.Forms.ComboBox cboLocTrangThai;

    private System.Windows.Forms.DataGridView dgvAppointments;

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
        mainTableLayoutPanel = new TableLayoutPanel();
        panelTop = new Panel();
        grpThongTin = new GroupBox();
        tblInput = new TableLayoutPanel();
        lblMaLichHen = new Label();
        txtMaLichHen = new TextBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblSoDienThoai = new Label();
        txtSoDienThoai = new TextBox();
        lblNgayGio = new Label();
        dtpNgayGio = new DateTimePicker();
        lblBacSi = new Label();
        cboBacSi = new ComboBox();
        lblTrangThai = new Label();
        cboTrangThai = new ComboBox();
        lblLyDoKham = new Label();
        txtLyDoKham = new TextBox();
        flowButtons = new FlowLayoutPanel();
        btnThem = new Button();
        btnCapNhat = new Button();
        btnXoa = new Button();
        btnLamMoi = new Button();
        grpTimKiem = new GroupBox();
        flowFilter = new FlowLayoutPanel();
        lblTimKiem = new Label();
        txtTimKiem = new TextBox();
        chkLocNgay = new CheckBox();
        dtpLocNgay = new DateTimePicker();
        lblLocTrangThai = new Label();
        cboLocTrangThai = new ComboBox();
        dgvAppointments = new DataGridView();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        mainTableLayoutPanel.SuspendLayout();
        panelTop.SuspendLayout();
        grpThongTin.SuspendLayout();
        tblInput.SuspendLayout();
        flowButtons.SuspendLayout();
        grpTimKiem.SuspendLayout();
        flowFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1040, 28);
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
        statusStrip1.Size = new Size(1040, 26);
        statusStrip1.TabIndex = 2;
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(68, 20);
        lblStatus.Text = "Sẵn sàng";
        // 
        // mainTableLayoutPanel
        // 
        mainTableLayoutPanel.ColumnCount = 1;
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainTableLayoutPanel.Controls.Add(panelTop, 0, 0);
        mainTableLayoutPanel.Controls.Add(dgvAppointments, 0, 1);
        mainTableLayoutPanel.Dock = DockStyle.Fill;
        mainTableLayoutPanel.Location = new Point(0, 28);
        mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        mainTableLayoutPanel.Padding = new Padding(10);
        mainTableLayoutPanel.RowCount = 2;
        mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
        mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainTableLayoutPanel.Size = new Size(1040, 588);
        mainTableLayoutPanel.TabIndex = 1;
        // 
        // panelTop
        // 
        panelTop.Controls.Add(grpThongTin);
        panelTop.Controls.Add(grpTimKiem);
        panelTop.Dock = DockStyle.Fill;
        panelTop.Location = new Point(13, 13);
        panelTop.Name = "panelTop";
        panelTop.Size = new Size(1014, 269);
        panelTop.TabIndex = 0;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(tblInput);
        grpThongTin.Controls.Add(flowButtons);
        grpThongTin.Dock = DockStyle.Top;
        grpThongTin.Location = new Point(0, 0);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(1014, 195);
        grpThongTin.TabIndex = 0;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông Tin Lịch Hẹn";
        // 
        // tblInput
        // 
        tblInput.ColumnCount = 4;
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tblInput.Controls.Add(lblMaLichHen, 0, 0);
        tblInput.Controls.Add(txtMaLichHen, 1, 0);
        tblInput.Controls.Add(lblHoTen, 2, 0);
        tblInput.Controls.Add(txtHoTen, 3, 0);
        tblInput.Controls.Add(lblSoDienThoai, 0, 1);
        tblInput.Controls.Add(txtSoDienThoai, 1, 1);
        tblInput.Controls.Add(lblNgayGio, 2, 1);
        tblInput.Controls.Add(dtpNgayGio, 3, 1);
        tblInput.Controls.Add(lblBacSi, 0, 2);
        tblInput.Controls.Add(cboBacSi, 1, 2);
        tblInput.Controls.Add(lblTrangThai, 2, 2);
        tblInput.Controls.Add(cboTrangThai, 3, 2);
        tblInput.Controls.Add(lblLyDoKham, 0, 3);
        tblInput.Controls.Add(txtLyDoKham, 1, 3);
        tblInput.Dock = DockStyle.Top;
        tblInput.Location = new Point(3, 23);
        tblInput.Name = "tblInput";
        tblInput.RowCount = 4;
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tblInput.Size = new Size(1008, 125);
        tblInput.TabIndex = 0;
        // 
        // lblMaLichHen
        // 
        lblMaLichHen.Anchor = AnchorStyles.Left;
        lblMaLichHen.Location = new Point(3, 3);
        lblMaLichHen.Name = "lblMaLichHen";
        lblMaLichHen.Size = new Size(100, 23);
        lblMaLichHen.TabIndex = 0;
        lblMaLichHen.Text = "Mã lịch hẹn:";
        // 
        // txtMaLichHen
        // 
        txtMaLichHen.Dock = DockStyle.Fill;
        txtMaLichHen.Location = new Point(113, 3);
        txtMaLichHen.Name = "txtMaLichHen";
        txtMaLichHen.Size = new Size(374, 27);
        txtMaLichHen.TabIndex = 1;
        // 
        // lblHoTen
        // 
        lblHoTen.Anchor = AnchorStyles.Left;
        lblHoTen.Location = new Point(493, 3);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(132, 23);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên bệnh nhân:";
        // 
        // txtHoTen
        // 
        txtHoTen.Dock = DockStyle.Fill;
        txtHoTen.Location = new Point(631, 3);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(374, 27);
        txtHoTen.TabIndex = 3;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.Anchor = AnchorStyles.Left;
        lblSoDienThoai.Location = new Point(3, 33);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new Size(100, 23);
        lblSoDienThoai.TabIndex = 4;
        lblSoDienThoai.Text = "Số điện thoại:";
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Dock = DockStyle.Fill;
        txtSoDienThoai.Location = new Point(113, 33);
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.Size = new Size(374, 27);
        txtSoDienThoai.TabIndex = 5;
        // 
        // lblNgayGio
        // 
        lblNgayGio.Anchor = AnchorStyles.Left;
        lblNgayGio.Location = new Point(493, 33);
        lblNgayGio.Name = "lblNgayGio";
        lblNgayGio.Size = new Size(115, 23);
        lblNgayGio.TabIndex = 6;
        lblNgayGio.Text = "Ngày giờ hẹn:";
        // 
        // dtpNgayGio
        // 
        dtpNgayGio.Dock = DockStyle.Fill;
        dtpNgayGio.Location = new Point(631, 33);
        dtpNgayGio.Name = "dtpNgayGio";
        dtpNgayGio.Size = new Size(374, 27);
        dtpNgayGio.TabIndex = 7;
        // 
        // lblBacSi
        // 
        lblBacSi.Anchor = AnchorStyles.Left;
        lblBacSi.Location = new Point(3, 63);
        lblBacSi.Name = "lblBacSi";
        lblBacSi.Size = new Size(100, 23);
        lblBacSi.TabIndex = 8;
        lblBacSi.Text = "Bác sĩ:";
        // 
        // cboBacSi
        // 
        cboBacSi.Dock = DockStyle.Fill;
        cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboBacSi.Location = new Point(113, 63);
        cboBacSi.Name = "cboBacSi";
        cboBacSi.Size = new Size(374, 28);
        cboBacSi.TabIndex = 9;
        // 
        // lblTrangThai
        // 
        lblTrangThai.Anchor = AnchorStyles.Left;
        lblTrangThai.Location = new Point(493, 63);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(100, 23);
        lblTrangThai.TabIndex = 10;
        lblTrangThai.Text = "Trạng thái:";
        // 
        // cboTrangThai
        // 
        cboTrangThai.Dock = DockStyle.Fill;
        cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThai.Location = new Point(631, 63);
        cboTrangThai.Name = "cboTrangThai";
        cboTrangThai.Size = new Size(374, 28);
        cboTrangThai.TabIndex = 11;
        // 
        // lblLyDoKham
        // 
        lblLyDoKham.Anchor = AnchorStyles.Left;
        lblLyDoKham.Location = new Point(3, 96);
        lblLyDoKham.Name = "lblLyDoKham";
        lblLyDoKham.Size = new Size(100, 23);
        lblLyDoKham.TabIndex = 12;
        lblLyDoKham.Text = "Lý do khám:";
        // 
        // txtLyDoKham
        // 
        tblInput.SetColumnSpan(txtLyDoKham, 3);
        txtLyDoKham.Dock = DockStyle.Fill;
        txtLyDoKham.Location = new Point(113, 93);
        txtLyDoKham.Name = "txtLyDoKham";
        txtLyDoKham.Size = new Size(892, 27);
        txtLyDoKham.TabIndex = 13;
        // 
        // flowButtons
        // 
        flowButtons.Controls.Add(btnThem);
        flowButtons.Controls.Add(btnCapNhat);
        flowButtons.Controls.Add(btnXoa);
        flowButtons.Controls.Add(btnLamMoi);
        flowButtons.Dock = DockStyle.Bottom;
        flowButtons.Location = new Point(3, 157);
        flowButtons.Name = "flowButtons";
        flowButtons.Size = new Size(1008, 35);
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
        // btnLamMoi
        // 
        btnLamMoi.Location = new Point(276, 3);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(85, 28);
        btnLamMoi.TabIndex = 3;
        btnLamMoi.Text = "Làm mới";
        // 
        // grpTimKiem
        // 
        grpTimKiem.Controls.Add(flowFilter);
        grpTimKiem.Dock = DockStyle.Bottom;
        grpTimKiem.Location = new Point(0, 204);
        grpTimKiem.Name = "grpTimKiem";
        grpTimKiem.Size = new Size(1014, 65);
        grpTimKiem.TabIndex = 1;
        grpTimKiem.TabStop = false;
        grpTimKiem.Text = "Tìm Kiếm & Bộ Lọc";
        // 
        // flowFilter
        // 
        flowFilter.Controls.Add(lblTimKiem);
        flowFilter.Controls.Add(txtTimKiem);
        flowFilter.Controls.Add(chkLocNgay);
        flowFilter.Controls.Add(dtpLocNgay);
        flowFilter.Controls.Add(lblLocTrangThai);
        flowFilter.Controls.Add(cboLocTrangThai);
        flowFilter.Dock = DockStyle.Fill;
        flowFilter.Location = new Point(3, 23);
        flowFilter.Name = "flowFilter";
        flowFilter.Padding = new Padding(5);
        flowFilter.Size = new Size(1008, 39);
        flowFilter.TabIndex = 0;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new Point(8, 5);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Padding = new Padding(0, 5, 0, 0);
        lblTimKiem.Size = new Size(143, 25);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm kiếm (Tên/SĐT):";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Location = new Point(157, 8);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new Size(160, 27);
        txtTimKiem.TabIndex = 1;
        // 
        // chkLocNgay
        // 
        chkLocNgay.AutoSize = true;
        chkLocNgay.Location = new Point(323, 8);
        chkLocNgay.Name = "chkLocNgay";
        chkLocNgay.Padding = new Padding(15, 3, 0, 0);
        chkLocNgay.Size = new Size(142, 27);
        chkLocNgay.TabIndex = 2;
        chkLocNgay.Text = "Lọc theo ngày:";
        // 
        // dtpLocNgay
        // 
        dtpLocNgay.Enabled = false;
        dtpLocNgay.Location = new Point(471, 8);
        dtpLocNgay.Name = "dtpLocNgay";
        dtpLocNgay.Size = new Size(110, 27);
        dtpLocNgay.TabIndex = 3;
        // 
        // lblLocTrangThai
        // 
        lblLocTrangThai.AutoSize = true;
        lblLocTrangThai.Location = new Point(587, 5);
        lblLocTrangThai.Name = "lblLocTrangThai";
        lblLocTrangThai.Padding = new Padding(15, 5, 0, 0);
        lblLocTrangThai.Size = new Size(93, 25);
        lblLocTrangThai.TabIndex = 4;
        lblLocTrangThai.Text = "Trạng thái:";
        // 
        // cboLocTrangThai
        // 
        cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocTrangThai.Location = new Point(686, 8);
        cboLocTrangThai.Name = "cboLocTrangThai";
        cboLocTrangThai.Size = new Size(130, 28);
        cboLocTrangThai.TabIndex = 5;
        // 
        // dgvAppointments
        // 
        dgvAppointments.ColumnHeadersHeight = 29;
        dgvAppointments.Dock = DockStyle.Fill;
        dgvAppointments.Location = new Point(13, 288);
        dgvAppointments.Name = "dgvAppointments";
        dgvAppointments.RowHeadersWidth = 51;
        dgvAppointments.Size = new Size(1014, 287);
        dgvAppointments.TabIndex = 1;
        // 
        // Form1
        // 
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(1040, 642);
        Controls.Add(mainTableLayoutPanel);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        ForeColor = Color.Black;
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        mainTableLayoutPanel.ResumeLayout(false);
        panelTop.ResumeLayout(false);
        grpThongTin.ResumeLayout(false);
        tblInput.ResumeLayout(false);
        tblInput.PerformLayout();
        flowButtons.ResumeLayout(false);
        grpTimKiem.ResumeLayout(false);
        flowFilter.ResumeLayout(false);
        flowFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}

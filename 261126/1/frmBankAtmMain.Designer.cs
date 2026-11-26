namespace BankAtmMdiSystem;

partial class frmBankAtmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        mnuHeThong = new ToolStripMenuItem();
        mnuDangXuat = new ToolStripMenuItem();
        mnuKhoaManHinh = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        mnuThoat = new ToolStripMenuItem();
        mnuQuanLyAtm = new ToolStripMenuItem();
        mnuDanhSachAtm = new ToolStripMenuItem();
        mnuDoiSoatGiaoDich = new ToolStripMenuItem();
        mnuCuaSo = new ToolStripMenuItem();
        mnuXepTang = new ToolStripMenuItem();
        mnuXepNgang = new ToolStripMenuItem();
        mnuXepDoc = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        mnuDongTatCa = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        tslGiaoDichVien = new ToolStripStatusLabel();
        tslCoreBanking = new ToolStripStatusLabel();
        tspbDoiSoat = new ToolStripProgressBar();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLyAtm, mnuCuaSo });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.MdiWindowListItem = mnuCuaSo;
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1024, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuHeThong
        // 
        mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuKhoaManHinh, toolStripSeparator1, mnuThoat });
        mnuHeThong.Name = "mnuHeThong";
        mnuHeThong.Size = new Size(71, 20);
        mnuHeThong.Text = "Hệ thống";
        // 
        // mnuDangXuat
        // 
        mnuDangXuat.Name = "mnuDangXuat";
        mnuDangXuat.Size = new Size(180, 22);
        mnuDangXuat.Text = "Đăng xuất";
        mnuDangXuat.Click += mnuDangXuat_Click;
        // 
        // mnuKhoaManHinh
        // 
        mnuKhoaManHinh.Name = "mnuKhoaManHinh";
        mnuKhoaManHinh.Size = new Size(180, 22);
        mnuKhoaManHinh.Text = "Khóa màn hình";
        mnuKhoaManHinh.Click += mnuKhoaManHinh_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(177, 6);
        // 
        // mnuThoat
        // 
        mnuThoat.Name = "mnuThoat";
        mnuThoat.Size = new Size(180, 22);
        mnuThoat.Text = "Thoát";
        mnuThoat.Click += mnuThoat_Click;
        // 
        // mnuQuanLyAtm
        // 
        mnuQuanLyAtm.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhSachAtm, mnuDoiSoatGiaoDich });
        mnuQuanLyAtm.Name = "mnuQuanLyAtm";
        mnuQuanLyAtm.Size = new Size(92, 20);
        mnuQuanLyAtm.Text = "Quản lý ATM";
        // 
        // mnuDanhSachAtm
        // 
        mnuDanhSachAtm.Name = "mnuDanhSachAtm";
        mnuDanhSachAtm.Size = new Size(242, 22);
        mnuDanhSachAtm.Text = "Danh sách Trạm ATM && Tồn quỹ";
        mnuDanhSachAtm.Click += mnuDanhSachAtm_Click;
        // 
        // mnuDoiSoatGiaoDich
        // 
        mnuDoiSoatGiaoDich.Name = "mnuDoiSoatGiaoDich";
        mnuDoiSoatGiaoDich.Size = new Size(242, 22);
        mnuDoiSoatGiaoDich.Text = "Đối soát Giao dịch Cuối ngày";
        mnuDoiSoatGiaoDich.Click += mnuDoiSoatGiaoDich_Click;
        // 
        // mnuCuaSo
        // 
        mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc, toolStripSeparator2, mnuDongTatCa });
        mnuCuaSo.Name = "mnuCuaSo";
        mnuCuaSo.Size = new Size(58, 20);
        mnuCuaSo.Text = "Cửa sổ";
        // 
        // mnuXepTang
        // 
        mnuXepTang.Name = "mnuXepTang";
        mnuXepTang.Size = new Size(216, 22);
        mnuXepTang.Text = "Xếp tầng (Cascade)";
        mnuXepTang.Click += mnuXepTang_Click;
        // 
        // mnuXepNgang
        // 
        mnuXepNgang.Name = "mnuXepNgang";
        mnuXepNgang.Size = new Size(216, 22);
        mnuXepNgang.Text = "Xếp ngang (Tile Horizontal)";
        mnuXepNgang.Click += mnuXepNgang_Click;
        // 
        // mnuXepDoc
        // 
        mnuXepDoc.Name = "mnuXepDoc";
        mnuXepDoc.Size = new Size(216, 22);
        mnuXepDoc.Text = "Xếp dọc (Tile Vertical)";
        mnuXepDoc.Click += mnuXepDoc_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(213, 6);
        // 
        // mnuDongTatCa
        // 
        mnuDongTatCa.Name = "mnuDongTatCa";
        mnuDongTatCa.Size = new Size(216, 22);
        mnuDongTatCa.Text = "Đóng tất cả";
        mnuDongTatCa.Click += mnuDongTatCa_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { tslGiaoDichVien, tslCoreBanking, tspbDoiSoat });
        statusStrip1.Location = new Point(0, 618);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1024, 22);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // tslGiaoDichVien
        // 
        tslGiaoDichVien.BorderSides = ToolStripStatusLabelBorderSides.Right;
        tslGiaoDichVien.Name = "tslGiaoDichVien";
        tslGiaoDichVien.Size = new Size(155, 17);
        tslGiaoDichVien.Text = "GDV trực: Nguyễn Văn A";
        // 
        // tslCoreBanking
        // 
        tslCoreBanking.Name = "tslCoreBanking";
        tslCoreBanking.Size = new Size(674, 17);
        tslCoreBanking.Spring = true;
        tslCoreBanking.Text = "Core Banking: Đã kết nối";
        tslCoreBanking.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tspbDoiSoat
        // 
        tspbDoiSoat.Name = "tspbDoiSoat";
        tspbDoiSoat.Size = new Size(180, 16);
        // 
        // frmBankAtmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 640);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Name = "frmBankAtmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hệ thống Điều hành Mạng lưới Cây ATM Ngân hàng";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem mnuHeThong;
    private ToolStripMenuItem mnuDangXuat;
    private ToolStripMenuItem mnuKhoaManHinh;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem mnuThoat;
    private ToolStripMenuItem mnuQuanLyAtm;
    private ToolStripMenuItem mnuDanhSachAtm;
    private ToolStripMenuItem mnuDoiSoatGiaoDich;
    private ToolStripMenuItem mnuCuaSo;
    private ToolStripMenuItem mnuXepTang;
    private ToolStripMenuItem mnuXepNgang;
    private ToolStripMenuItem mnuXepDoc;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem mnuDongTatCa;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel tslGiaoDichVien;
    private ToolStripStatusLabel tslCoreBanking;
    private ToolStripProgressBar tspbDoiSoat;
}

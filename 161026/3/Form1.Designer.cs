namespace _3
{
    partial class Form1
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
            msMain = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuSystemLogout = new ToolStripMenuItem();
            menuSystemExit = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            menuCatProduct = new ToolStripMenuItem();
            menuCatInventory = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            menuReportRevenue = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            menuWindowCascade = new ToolStripMenuItem();
            menuWindowTileH = new ToolStripMenuItem();
            menuWindowTileV = new ToolStripMenuItem();
            ssMain = new StatusStrip();
            lblCurrentUser = new ToolStripStatusLabel();
            tsProgressBar = new ToolStripProgressBar();
            msMain.SuspendLayout();
            ssMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, báoCáoToolStripMenuItem, windowsToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1037, 28);
            msMain.TabIndex = 1;
            msMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSystemLogout, menuSystemExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuSystemLogout
            // 
            menuSystemLogout.Name = "menuSystemLogout";
            menuSystemLogout.Size = new Size(224, 26);
            menuSystemLogout.Text = "Đăng xuất";
            // 
            // menuSystemExit
            // 
            menuSystemExit.Name = "menuSystemExit";
            menuSystemExit.Size = new Size(224, 26);
            menuSystemExit.Text = "Thoát";
            menuSystemExit.Click += menuSystemExit_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCatProduct, menuCatInventory });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // menuCatProduct
            // 
            menuCatProduct.Name = "menuCatProduct";
            menuCatProduct.Size = new Size(208, 26);
            menuCatProduct.Text = "Quản lí sản phẩm";
            menuCatProduct.Click += menuCatProduct_Click;
            // 
            // menuCatInventory
            // 
            menuCatInventory.Name = "menuCatInventory";
            menuCatInventory.Size = new Size(208, 26);
            menuCatInventory.Text = "Quản lí nhập xuất";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuReportRevenue });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // menuReportRevenue
            // 
            menuReportRevenue.Name = "menuReportRevenue";
            menuReportRevenue.Size = new Size(224, 26);
            menuReportRevenue.Text = "Thống kê doanh thu";
            menuReportRevenue.Click += menuReportRevenue_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuWindowCascade, menuWindowTileH, menuWindowTileV });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(84, 24);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // menuWindowCascade
            // 
            menuWindowCascade.Name = "menuWindowCascade";
            menuWindowCascade.Size = new Size(224, 26);
            menuWindowCascade.Text = "Sắp xếp tầng";
            menuWindowCascade.Click += menuWindowCascade_Click;
            // 
            // menuWindowTileH
            // 
            menuWindowTileH.Name = "menuWindowTileH";
            menuWindowTileH.Size = new Size(224, 26);
            menuWindowTileH.Text = "Sắp xếp ngang";
            menuWindowTileH.Click += menuWindowTileH_Click;
            // 
            // menuWindowTileV
            // 
            menuWindowTileV.Name = "menuWindowTileV";
            menuWindowTileV.Size = new Size(224, 26);
            menuWindowTileV.Text = "Sắp xếp dọc";
            menuWindowTileV.Click += menuWindowTileV_Click;
            // 
            // ssMain
            // 
            ssMain.ImageScalingSize = new Size(20, 20);
            ssMain.Items.AddRange(new ToolStripItem[] { lblCurrentUser, tsProgressBar });
            ssMain.Location = new Point(0, 457);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(1037, 26);
            ssMain.TabIndex = 2;
            ssMain.Text = "statusStrip1";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(151, 20);
            lblCurrentUser.Text = "toolStripStatusLabel1";
            // 
            // tsProgressBar
            // 
            tsProgressBar.Name = "tsProgressBar";
            tsProgressBar.Size = new Size(100, 18);
            tsProgressBar.Style = ProgressBarStyle.Marquee;
            tsProgressBar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1037, 483);
            Controls.Add(ssMain);
            Controls.Add(msMain);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "Form1";
            Text = "Quản lí siêu thị";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem menuSystemLogout;
        private ToolStripMenuItem menuSystemExit;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem menuCatProduct;
        private ToolStripMenuItem menuCatInventory;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem menuReportRevenue;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem menuWindowCascade;
        private ToolStripMenuItem menuWindowTileH;
        private ToolStripMenuItem menuWindowTileV;
        private StatusStrip ssMain;
        private ToolStripStatusLabel lblCurrentUser;
        private ToolStripProgressBar tsProgressBar;
    }
}

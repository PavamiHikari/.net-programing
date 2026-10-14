namespace _1
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
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblGiamGia = new Label();
            txtGiamGia = new TextBox();
            lblTongTienTieuDe = new Label();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(8, 8);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(116, 20);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá dịch vụ:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(128, 8);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(8, 56);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(114, 20);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng khách:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(128, 56);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(8, 104);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(96, 20);
            lblGiamGia.TabIndex = 2;
            lblGiamGia.Text = "Mã giảm giá:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(128, 104);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lblTongTienTieuDe
            // 
            lblTongTienTieuDe.AutoSize = true;
            lblTongTienTieuDe.Location = new Point(8, 160);
            lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            lblTongTienTieuDe.Size = new Size(150, 20);
            lblTongTienTieuDe.TabIndex = 3;
            lblTongTienTieuDe.Text = "Tổng tiền thanh toán:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(200, 160);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(55, 20);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "0 VNĐ";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(8, 208);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(160, 208);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(611, 263);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(lblTongTienTieuDe);
            Controls.Add(txtGiamGia);
            Controls.Add(lblGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Name = "Form1";
            Text = "Máy tính tính cước dịch vụ & Giảm giá (Service Charge Calculator)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblGiamGia;
        private TextBox txtGiamGia;
        private Label lblTongTienTieuDe;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}

namespace _2
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
            grpThongTin = new GroupBox();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblNguoiYeuCau = new Label();
            txtNguoiYeuCau = new TextBox();
            lblNgayGhiNhan = new Label();
            dtpNgayGhiNhan = new DateTimePicker();
            lblMucDo = new Label();
            panel1 = new Panel();
            radThap = new RadioButton();
            radTrungBinh = new RadioButton();
            radKhanCap = new RadioButton();
            grpChiTiet = new GroupBox();
            lblLoaiSuCo = new Label();
            cboLoaiSuCo = new ComboBox();
            lblThietBi = new Label();
            panel2 = new Panel();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            grpThongTin.SuspendLayout();
            panel1.SuspendLayout();
            grpChiTiet.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(panel1);
            grpThongTin.Controls.Add(lblMucDo);
            grpThongTin.Controls.Add(dtpNgayGhiNhan);
            grpThongTin.Controls.Add(lblNgayGhiNhan);
            grpThongTin.Controls.Add(txtNguoiYeuCau);
            grpThongTin.Controls.Add(lblNguoiYeuCau);
            grpThongTin.Controls.Add(txtMaPhieu);
            grpThongTin.Controls.Add(lblMaPhieu);
            grpThongTin.Location = new Point(8, 8);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(384, 432);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phiếu";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(8, 40);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(74, 20);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(120, 40);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(256, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblNguoiYeuCau
            // 
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(8, 96);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(108, 20);
            lblNguoiYeuCau.TabIndex = 2;
            lblNguoiYeuCau.Text = "Người yêu cầu:";
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(120, 96);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(256, 27);
            txtNguoiYeuCau.TabIndex = 3;
            // 
            // lblNgayGhiNhan
            // 
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(8, 152);
            lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            lblNgayGhiNhan.Size = new Size(108, 20);
            lblNgayGhiNhan.TabIndex = 4;
            lblNgayGhiNhan.Text = "Ngày ghi nhận:";
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Location = new Point(120, 152);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(256, 27);
            dtpNgayGhiNhan.TabIndex = 5;
            // 
            // lblMucDo
            // 
            lblMucDo.AutoSize = true;
            lblMucDo.Location = new Point(8, 208);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new Size(113, 20);
            lblMucDo.TabIndex = 6;
            lblMucDo.Text = "Mức độ ưu tiên:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radKhanCap);
            panel1.Controls.Add(radTrungBinh);
            panel1.Controls.Add(radThap);
            panel1.Location = new Point(16, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 40);
            panel1.TabIndex = 7;
            // 
            // radThap
            // 
            radThap.AutoSize = true;
            radThap.Checked = true;
            radThap.Location = new Point(8, 8);
            radThap.Name = "radThap";
            radThap.Size = new Size(63, 24);
            radThap.TabIndex = 0;
            radThap.TabStop = true;
            radThap.Text = "Thấp";
            radThap.UseVisualStyleBackColor = true;
            // 
            // radTrungBinh
            // 
            radTrungBinh.AutoSize = true;
            radTrungBinh.Location = new Point(112, 8);
            radTrungBinh.Name = "radTrungBinh";
            radTrungBinh.Size = new Size(100, 24);
            radTrungBinh.TabIndex = 1;
            radTrungBinh.TabStop = true;
            radTrungBinh.Text = "Trung bình";
            radTrungBinh.UseVisualStyleBackColor = true;
            radTrungBinh.CheckedChanged += radTrungBinh_CheckedChanged;
            // 
            // radKhanCap
            // 
            radKhanCap.AutoSize = true;
            radKhanCap.Location = new Point(256, 8);
            radKhanCap.Name = "radKhanCap";
            radKhanCap.Size = new Size(91, 24);
            radKhanCap.TabIndex = 2;
            radKhanCap.TabStop = true;
            radKhanCap.Text = "Khẩn cấp";
            radKhanCap.UseVisualStyleBackColor = true;
            radKhanCap.CheckedChanged += radKhanCap_CheckedChanged;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(btnNhapLai);
            grpChiTiet.Controls.Add(btnGuiYeuCau);
            grpChiTiet.Controls.Add(btnTaiAnh);
            grpChiTiet.Controls.Add(picAnhLoi);
            grpChiTiet.Controls.Add(panel2);
            grpChiTiet.Controls.Add(lblThietBi);
            grpChiTiet.Controls.Add(cboLoaiSuCo);
            grpChiTiet.Controls.Add(lblLoaiSuCo);
            grpChiTiet.Location = new Point(392, 16);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Size = new Size(400, 424);
            grpChiTiet.TabIndex = 1;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "Phân loại & Chi tiết";
            // 
            // lblLoaiSuCo
            // 
            lblLoaiSuCo.AutoSize = true;
            lblLoaiSuCo.Location = new Point(16, 40);
            lblLoaiSuCo.Name = "lblLoaiSuCo";
            lblLoaiSuCo.Size = new Size(79, 20);
            lblLoaiSuCo.TabIndex = 0;
            lblLoaiSuCo.Text = "Loại sự cố:";
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Location = new Point(104, 40);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(288, 28);
            cboLoaiSuCo.TabIndex = 1;
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Location = new Point(16, 96);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(137, 20);
            lblThietBi.TabIndex = 2;
            lblThietBi.Text = "Thiết bị ảnh hưởng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(chkDienThoai);
            panel2.Controls.Add(chkMayIn);
            panel2.Controls.Add(chkLaptop);
            panel2.Controls.Add(chkMayTinhBan);
            panel2.Location = new Point(8, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 88);
            panel2.TabIndex = 3;
            // 
            // chkMayTinhBan
            // 
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(8, 16);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(117, 24);
            chkMayTinhBan.TabIndex = 0;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(144, 16);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(248, 16);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 2;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(8, 56);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(16, 232);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(200, 184);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 4;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(296, 232);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 5;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.Location = new Point(304, 352);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(94, 29);
            btnGuiYeuCau.TabIndex = 6;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(304, 392);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(94, 29);
            btnNhapLai.TabIndex = 7;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(grpChiTiet);
            Controls.Add(grpThongTin);
            Name = "Form1";
            Text = "Tiếp nhận & Phân loại sự cố IT";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpChiTiet.ResumeLayout(false);
            grpChiTiet.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Panel panel1;
        private RadioButton radThap;
        private Label lblMucDo;
        private DateTimePicker dtpNgayGhiNhan;
        private Label lblNgayGhiNhan;
        private TextBox txtNguoiYeuCau;
        private Label lblNguoiYeuCau;
        private TextBox txtMaPhieu;
        private Label lblMaPhieu;
        private RadioButton radKhanCap;
        private RadioButton radTrungBinh;
        private GroupBox grpChiTiet;
        private Panel panel2;
        private CheckBox chkMayIn;
        private CheckBox chkLaptop;
        private CheckBox chkMayTinhBan;
        private Label lblThietBi;
        private ComboBox cboLoaiSuCo;
        private Label lblLoaiSuCo;
        private Button btnNhapLai;
        private Button btnGuiYeuCau;
        private Button btnTaiAnh;
        private PictureBox picAnhLoi;
        private CheckBox chkDienThoai;
    }
}

namespace _4
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
            flpBanGhe = new FlowLayoutPanel();
            cboKhungGio = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblSoLuong = new Label();
            label3 = new Label();
            lblTamTinh = new Label();
            btnXacNhan = new Button();
            btnHuyChon = new Button();
            SuspendLayout();
            // 
            // flpBanGhe
            // 
            flpBanGhe.AutoScroll = true;
            flpBanGhe.Location = new Point(0, 0);
            flpBanGhe.MinimumSize = new Size(400, 320);
            flpBanGhe.Name = "flpBanGhe";
            flpBanGhe.Size = new Size(400, 320);
            flpBanGhe.TabIndex = 0;
            // 
            // cboKhungGio
            // 
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(504, 8);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(296, 28);
            cboKhungGio.TabIndex = 1;
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 8);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Khung giờ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 48);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Số lượng:";
            label2.Click += label2_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(504, 48);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(17, 20);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 88);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Tạm tính:";
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Location = new Point(504, 88);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(52, 20);
            lblTamTinh.TabIndex = 6;
            lblTamTinh.Text = "0 VND";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(416, 136);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(104, 29);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuyChon
            // 
            btnHuyChon.Location = new Point(536, 136);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(120, 29);
            btnHuyChon.TabIndex = 8;
            btnHuyChon.Text = "Hủy chọn tất cả";
            btnHuyChon.UseVisualStyleBackColor = true;
            btnHuyChon.Click += btnHuyChon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuyChon);
            Controls.Add(btnXacNhan);
            Controls.Add(lblTamTinh);
            Controls.Add(label3);
            Controls.Add(lblSoLuong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboKhungGio);
            Controls.Add(flpBanGhe);
            Name = "Form1";
            Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpBanGhe;
        private ComboBox cboKhungGio;
        private Label label1;
        private Label label2;
        private Label lblSoLuong;
        private Label label3;
        private Label lblTamTinh;
        private Button btnXacNhan;
        private Button btnHuyChon;
    }
}

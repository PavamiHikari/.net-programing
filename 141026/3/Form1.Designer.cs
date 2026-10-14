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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtMaVT = new TextBox();
            label2 = new Label();
            txtTenVT = new TextBox();
            label3 = new Label();
            cboDVT = new ComboBox();
            label4 = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoaDong = new Button();
            btnXoaTatCa = new Button();
            groupBox2 = new GroupBox();
            lvVatTu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaTatCa);
            groupBox1.Controls.Add(btnXoaDong);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboDVT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenVT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaVT);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 456);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vật tư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã vật tư:";
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(96, 32);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(208, 27);
            txtMaVT.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên vật tư:";
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(96, 72);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(208, 27);
            txtTenVT.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 112);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn vị tính:";
            // 
            // cboDVT
            // 
            cboDVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDVT.Location = new Point(96, 112);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(208, 28);
            cboDVT.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 168);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(112, 168);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(192, 27);
            txtDonGia.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(48, 232);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(176, 232);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(104, 29);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(48, 280);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(94, 29);
            btnXoaDong.TabIndex = 10;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(176, 280);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(102, 29);
            btnXoaTatCa.TabIndex = 11;
            btnXoaTatCa.Text = "Xóa toàn bộ";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvVatTu);
            groupBox2.Location = new Point(312, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 456);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách vật tư";
            // 
            // lvVatTu
            // 
            lvVatTu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;
            lvVatTu.Location = new Point(8, 32);
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(416, 416);
            lvVatTu.TabIndex = 0;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "";
            columnHeader1.Text = "Mã VT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn vị tính";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(733, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnXoaTatCa;
        private Button btnXoaDong;
        private Button btnCapNhat;
        private Button btnThem;
        private TextBox txtDonGia;
        private Label label4;
        private ComboBox cboDVT;
        private Label label3;
        private TextBox txtTenVT;
        private Label label2;
        private TextBox txtMaVT;
        private GroupBox groupBox2;
        private ListView lvVatTu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}

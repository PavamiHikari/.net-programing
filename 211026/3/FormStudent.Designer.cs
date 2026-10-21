namespace _2
{
    partial class FormStudent
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
            components = new System.ComponentModel.Container();
            contextMenuDGV = new ContextMenuStrip(components);
            menuXoaDong = new ToolStripMenuItem();
            menuLamMoi = new ToolStripMenuItem();
            menuXemChiTiet = new ToolStripMenuItem();
            dgvStudents = new DataGridView();
            label1 = new Label();
            txtStudentId = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            label4 = new Label();
            picAvatar = new PictureBox();
            btnSelectImage = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCsv = new Button();
            btnLoadDataAsync = new Button();
            prgLoading = new ProgressBar();
            lblPercent = new Label();
            contextMenuDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // contextMenuDGV
            // 
            contextMenuDGV.ImageScalingSize = new Size(20, 20);
            contextMenuDGV.Items.AddRange(new ToolStripItem[] { menuXoaDong, menuLamMoi, menuXemChiTiet });
            contextMenuDGV.Name = "contextMenuDGV";
            contextMenuDGV.Size = new Size(187, 76);
            // 
            // menuXoaDong
            // 
            menuXoaDong.Name = "menuXoaDong";
            menuXoaDong.Size = new Size(186, 24);
            menuXoaDong.Text = "Xóa dòng";
            // 
            // menuLamMoi
            // 
            menuLamMoi.Name = "menuLamMoi";
            menuLamMoi.Size = new Size(186, 24);
            menuLamMoi.Text = "Làm mới dữ liệu";
            // 
            // menuXemChiTiet
            // 
            menuXemChiTiet.Name = "menuXemChiTiet";
            menuXemChiTiet.Size = new Size(186, 24);
            menuXemChiTiet.Text = "Xem chi tiết";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.ContextMenuStrip = contextMenuDGV;
            dgvStudents.Location = new Point(408, 0);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(644, 448);
            dgvStudents.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(104, 8);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(272, 27);
            txtStudentId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(104, 56);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(272, 27);
            txtFullName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 104);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(104, 104);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(272, 27);
            txtAge.TabIndex = 6;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(88, 152);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 152);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Giới tính:";
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(8, 208);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(184, 240);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 9;
            picAvatar.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(200, 208);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(94, 29);
            btnSelectImage.TabIndex = 10;
            btnSelectImage.Text = "Chọn ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(200, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(304, 416);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(94, 29);
            btnExportCsv.TabIndex = 14;
            btnExportCsv.Text = "CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnLoadDataAsync
            // 
            btnLoadDataAsync.Location = new Point(200, 312);
            btnLoadDataAsync.Name = "btnLoadDataAsync";
            btnLoadDataAsync.Size = new Size(102, 29);
            btnLoadDataAsync.TabIndex = 15;
            btnLoadDataAsync.Text = "Nạp dữ liệu";
            btnLoadDataAsync.UseVisualStyleBackColor = true;
            btnLoadDataAsync.Click += btnLoadDataAsync_Click;
            // 
            // prgLoading
            // 
            prgLoading.Location = new Point(200, 352);
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(200, 13);
            prgLoading.TabIndex = 16;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(312, 320);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(29, 20);
            lblPercent.TabIndex = 17;
            lblPercent.Text = "0%";
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1053, 450);
            Controls.Add(lblPercent);
            Controls.Add(prgLoading);
            Controls.Add(btnLoadDataAsync);
            Controls.Add(btnExportCsv);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSelectImage);
            Controls.Add(picAvatar);
            Controls.Add(label4);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtStudentId);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Name = "FormStudent";
            Text = "Quản lí";
            contextMenuDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Label label1;
        private TextBox txtStudentId;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtAge;
        private ComboBox cboGender;
        private Label label4;
        private PictureBox picAvatar;
        private Button btnSelectImage;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportCsv;

        private ContextMenuStrip contextMenuDGV;
        private ToolStripMenuItem menuXoaDong;
        private ToolStripMenuItem menuLamMoi;
        private ToolStripMenuItem menuXemChiTiet;
        private Button btnLoadDataAsync;
        private ProgressBar prgLoading;
        private Label lblPercent;
    }
}

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            msMain = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            menuSystemOpen = new ToolStripMenuItem();
            menuSystemSave = new ToolStripMenuItem();
            menuSystemExit = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            menuToolsImport = new ToolStripMenuItem();
            menuToolsExport = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            tsbImport = new ToolStripButton();
            tsbExport = new ToolStripButton();
            tsbExit = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatusQuantity = new ToolStripStatusLabel();
            lblStatusTotalValue = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            txtProductId = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            cboCategory = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            numQuantity = new NumericUpDown();
            picProductImage = new PictureBox();
            btnBrowseImage = new Button();
            txtImagePath = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            ErrorProvider = new ErrorProvider(components);
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            msMain.SuspendLayout();
            tsMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, toolsToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1259, 28);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSystemOpen, menuSystemSave, menuSystemExit });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // menuSystemOpen
            // 
            menuSystemOpen.Name = "menuSystemOpen";
            menuSystemOpen.Size = new Size(172, 26);
            menuSystemOpen.Text = "Open File";
            // 
            // menuSystemSave
            // 
            menuSystemSave.Name = "menuSystemSave";
            menuSystemSave.Size = new Size(172, 26);
            menuSystemSave.Text = "Save Report";
            // 
            // menuSystemExit
            // 
            menuSystemExit.Name = "menuSystemExit";
            menuSystemExit.Size = new Size(172, 26);
            menuSystemExit.Text = "Exit";
            menuSystemExit.Click += menuSystemExit_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuToolsImport, menuToolsExport });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuToolsImport
            // 
            menuToolsImport.Name = "menuToolsImport";
            menuToolsImport.Size = new Size(167, 26);
            menuToolsImport.Text = "Import CSV";
            menuToolsImport.Click += menuToolsImport_Click;
            // 
            // menuToolsExport
            // 
            menuToolsExport.Name = "menuToolsExport";
            menuToolsExport.Size = new Size(167, 26);
            menuToolsExport.Text = "Export CSV";
            menuToolsExport.Click += menuToolsExport_Click;
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { tsbImport, tsbExport, tsbExit });
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1259, 27);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // tsbImport
            // 
            tsbImport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbImport.Image = (Image)resources.GetObject("tsbImport.Image");
            tsbImport.ImageTransparentColor = Color.Magenta;
            tsbImport.Name = "tsbImport";
            tsbImport.Size = new Size(38, 24);
            tsbImport.Text = "IMP";
            tsbImport.Click += tsbImport_Click;
            // 
            // tsbExport
            // 
            tsbExport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbExport.Image = (Image)resources.GetObject("tsbExport.Image");
            tsbExport.ImageTransparentColor = Color.Magenta;
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new Size(38, 24);
            tsbExport.Text = "EXP";
            tsbExport.Click += tsbExport_Click;
            // 
            // tsbExit
            // 
            tsbExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new Size(38, 24);
            tsbExit.Text = "EXT";
            tsbExit.Click += tsbExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusQuantity, lblStatusTotalValue, lblStatusTime });
            statusStrip1.Location = new Point(0, 517);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1259, 30);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusQuantity
            // 
            lblStatusQuantity.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblStatusQuantity.Name = "lblStatusQuantity";
            lblStatusQuantity.Size = new Size(88, 24);
            lblStatusQuantity.Text = "Tổng tồn: 0";
            // 
            // lblStatusTotalValue
            // 
            lblStatusTotalValue.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblStatusTotalValue.Name = "lblStatusTotalValue";
            lblStatusTotalValue.Size = new Size(118, 24);
            lblStatusTotalValue.Text = "Tổng giá trị: 0 đ";
            // 
            // lblStatusTime
            // 
            lblStatusTime.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(999, 24);
            lblStatusTime.Spring = true;
            lblStatusTime.Text = "toolStripStatusLabel1";
            lblStatusTime.TextAlign = ContentAlignment.MiddleRight;
            lblStatusTime.Click += tsbExit_Click;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 80);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã sản phẩm: ";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(120, 80);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(288, 27);
            txtProductId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 128);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(120, 128);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(288, 27);
            txtProductName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 176);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Loại sản phẩm:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(120, 176);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(288, 28);
            cboCategory.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 224);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 9;
            label4.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 224);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(288, 27);
            txtPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 272);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Số lượng:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(120, 272);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(288, 27);
            numQuantity.TabIndex = 12;
            // 
            // picProductImage
            // 
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(8, 312);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(176, 200);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 13;
            picProductImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(200, 352);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(94, 29);
            btnBrowseImage.TabIndex = 14;
            btnBrowseImage.Text = "Chọn ảnh";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += tsbExit_Click;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(200, 320);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(208, 27);
            txtImagePath.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(312, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(312, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(432, 56);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(824, 456);
            dgvProducts.TabIndex = 20;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1259, 547);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtImagePath);
            Controls.Add(btnBrowseImage);
            Controls.Add(picProductImage);
            Controls.Add(numQuantity);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(cboCategory);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(tsMain);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "Form1";
            Text = "Quản lí kho";
            FormClosing += frmInventoryManager_FormClosing;
            Load += Form1_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem menuSystemOpen;
        private ToolStripMenuItem menuSystemSave;
        private ToolStripMenuItem menuSystemExit;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem menuToolsImport;
        private ToolStripMenuItem menuToolsExport;
        private ToolStrip tsMain;
        private ToolStripButton tsbImport;
        private ToolStripButton tsbExport;
        private ToolStripButton tsbExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusQuantity;
        private ToolStripStatusLabel lblStatusTotalValue;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer timerClock;
        private Label label1;
        private TextBox txtProductId;
        private Label label2;
        private TextBox txtProductName;
        private Label label3;
        private ComboBox cboCategory;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private NumericUpDown numQuantity;
        private PictureBox picProductImage;
        private Button btnBrowseImage;
        private TextBox txtImagePath;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private ErrorProvider ErrorProvider;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
    }
}

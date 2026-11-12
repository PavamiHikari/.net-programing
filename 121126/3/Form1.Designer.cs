namespace Bai5_3;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        grpInfo = new GroupBox();
        cboCategory = new ComboBox();
        lblCategory = new Label();
        txtQuantity = new TextBox();
        lblQuantity = new Label();
        txtUnitPrice = new TextBox();
        lblUnitPrice = new Label();
        txtProductName = new TextBox();
        lblProductName = new Label();
        txtProductId = new TextBox();
        lblProductId = new Label();
        grpActions = new GroupBox();
        btnSearch = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        btnDelete = new Button();
        btnEdit = new Button();
        btnAdd = new Button();
        dgvProducts = new DataGridView();
        bsProducts = new BindingSource(components);
        grpInfo.SuspendLayout();
        grpActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bsProducts).BeginInit();
        SuspendLayout();
        // 
        // grpInfo
        // 
        grpInfo.Controls.Add(cboCategory);
        grpInfo.Controls.Add(lblCategory);
        grpInfo.Controls.Add(txtQuantity);
        grpInfo.Controls.Add(lblQuantity);
        grpInfo.Controls.Add(txtUnitPrice);
        grpInfo.Controls.Add(lblUnitPrice);
        grpInfo.Controls.Add(txtProductName);
        grpInfo.Controls.Add(lblProductName);
        grpInfo.Controls.Add(txtProductId);
        grpInfo.Controls.Add(lblProductId);
        grpInfo.Location = new Point(18, 19);
        grpInfo.Margin = new Padding(3, 4, 3, 4);
        grpInfo.Name = "grpInfo";
        grpInfo.Padding = new Padding(3, 4, 3, 4);
        grpInfo.Size = new Size(743, 171);
        grpInfo.TabIndex = 0;
        grpInfo.TabStop = false;
        grpInfo.Text = "Thông tin sản phẩm";
        // 
        // cboCategory
        // 
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(101, 119);
        cboCategory.Margin = new Padding(3, 4, 3, 4);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(228, 28);
        cboCategory.TabIndex = 5;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(18, 123);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(79, 20);
        lblCategory.TabIndex = 4;
        lblCategory.Text = "Danh mục:";
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(473, 76);
        txtQuantity.Margin = new Padding(3, 4, 3, 4);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new Size(239, 27);
        txtQuantity.TabIndex = 9;
        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new Point(389, 80);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(72, 20);
        lblQuantity.TabIndex = 8;
        lblQuantity.Text = "Số lượng:";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(473, 33);
        txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(239, 27);
        txtUnitPrice.TabIndex = 7;
        // 
        // lblUnitPrice
        // 
        lblUnitPrice.AutoSize = true;
        lblUnitPrice.Location = new Point(389, 37);
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Size = new Size(65, 20);
        lblUnitPrice.TabIndex = 6;
        lblUnitPrice.Text = "Đơn giá:";
        // 
        // txtProductName
        // 
        txtProductName.Location = new Point(101, 76);
        txtProductName.Margin = new Padding(3, 4, 3, 4);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new Size(228, 27);
        txtProductName.TabIndex = 3;
        // 
        // lblProductName
        // 
        lblProductName.AutoSize = true;
        lblProductName.Location = new Point(18, 80);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(55, 20);
        lblProductName.TabIndex = 2;
        lblProductName.Text = "Tên SP:";
        // 
        // txtProductId
        // 
        txtProductId.Location = new Point(101, 33);
        txtProductId.Margin = new Padding(3, 4, 3, 4);
        txtProductId.Name = "txtProductId";
        txtProductId.Size = new Size(228, 27);
        txtProductId.TabIndex = 1;
        // 
        // lblProductId
        // 
        lblProductId.AutoSize = true;
        lblProductId.Location = new Point(18, 37);
        lblProductId.Name = "lblProductId";
        lblProductId.Size = new Size(53, 20);
        lblProductId.TabIndex = 0;
        lblProductId.Text = "Mã SP:";
        // 
        // grpActions
        // 
        grpActions.Controls.Add(btnSearch);
        grpActions.Controls.Add(txtSearch);
        grpActions.Controls.Add(lblSearch);
        grpActions.Controls.Add(btnDelete);
        grpActions.Controls.Add(btnEdit);
        grpActions.Controls.Add(btnAdd);
        grpActions.Location = new Point(18, 200);
        grpActions.Margin = new Padding(3, 4, 3, 4);
        grpActions.Name = "grpActions";
        grpActions.Padding = new Padding(3, 4, 3, 4);
        grpActions.Size = new Size(743, 85);
        grpActions.TabIndex = 1;
        grpActions.TabStop = false;
        grpActions.Text = "Chức năng";
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(619, 32);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(96, 37);
        btnSearch.TabIndex = 5;
        btnSearch.Text = "Tìm kiếm";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(405, 36);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(205, 27);
        txtSearch.TabIndex = 4;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(343, 40);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(55, 20);
        lblSearch.TabIndex = 3;
        lblSearch.Text = "Tên SP:";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(215, 32);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(89, 37);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(117, 32);
        btnEdit.Margin = new Padding(3, 4, 3, 4);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(89, 37);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "Sửa";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(18, 32);
        btnAdd.Margin = new Padding(3, 4, 3, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(89, 37);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.AutoGenerateColumns = false;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.DataSource = bsProducts;
        dgvProducts.Location = new Point(18, 299);
        dgvProducts.Margin = new Padding(3, 4, 3, 4);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new Size(743, 293);
        dgvProducts.TabIndex = 2;
        dgvProducts.CellClick += dgvProducts_CellClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(779, 613);
        Controls.Add(dgvProducts);
        Controls.Add(grpActions);
        Controls.Add(grpInfo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.3 - Quản lý danh sách sản phẩm";
        Load += Form1_Load;
        grpInfo.ResumeLayout(false);
        grpInfo.PerformLayout();
        grpActions.ResumeLayout(false);
        grpActions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)bsProducts).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpInfo = null!;
    private Label lblProductId = null!;
    private TextBox txtProductId = null!;
    private Label lblProductName = null!;
    private TextBox txtProductName = null!;
    private Label lblCategory = null!;
    private ComboBox cboCategory = null!;
    private Label lblUnitPrice = null!;
    private TextBox txtUnitPrice = null!;
    private Label lblQuantity = null!;
    private TextBox txtQuantity = null!;
    private GroupBox grpActions = null!;
    private Button btnAdd = null!;
    private Button btnEdit = null!;
    private Button btnDelete = null!;
    private Label lblSearch = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;
    private DataGridView dgvProducts = null!;
    private BindingSource bsProducts = null!;
}

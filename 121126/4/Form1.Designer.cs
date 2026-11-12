namespace Bai5_4;

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
        pnlTop = new Panel();
        cboViewMode = new ComboBox();
        lblViewMode = new Label();
        splitContainer1 = new SplitContainer();
        tvDepartments = new TreeView();
        imlTree = new ImageList(components);
        lsvEmployees = new ListView();
        colId = new ColumnHeader();
        colName = new ColumnHeader();
        colPosition = new ColumnHeader();
        colHireDate = new ColumnHeader();
        imlLarge = new ImageList(components);
        imlSmall = new ImageList(components);
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.Controls.Add(cboViewMode);
        pnlTop.Controls.Add(lblViewMode);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(820, 42);
        pnlTop.TabIndex = 0;
        // 
        // lblViewMode
        // 
        lblViewMode.AutoSize = true;
        lblViewMode.Location = new Point(12, 13);
        lblViewMode.Name = "lblViewMode";
        lblViewMode.Size = new Size(78, 15);
        lblViewMode.TabIndex = 0;
        lblViewMode.Text = "Chế độ xem:";
        // 
        // cboViewMode
        // 
        cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboViewMode.FormattingEnabled = true;
        cboViewMode.Location = new Point(96, 10);
        cboViewMode.Name = "cboViewMode";
        cboViewMode.Size = new Size(160, 23);
        cboViewMode.TabIndex = 1;
        cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 42);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tvDepartments);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(lsvEmployees);
        splitContainer1.Size = new Size(820, 438);
        splitContainer1.SplitterDistance = 240;
        splitContainer1.TabIndex = 1;
        // 
        // tvDepartments
        // 
        tvDepartments.Dock = DockStyle.Fill;
        tvDepartments.ImageIndex = 0;
        tvDepartments.ImageList = imlTree;
        tvDepartments.Location = new Point(0, 0);
        tvDepartments.Name = "tvDepartments";
        tvDepartments.SelectedImageIndex = 0;
        tvDepartments.Size = new Size(240, 438);
        tvDepartments.TabIndex = 0;
        tvDepartments.AfterSelect += tvDepartments_AfterSelect;
        // 
        // imlTree
        // 
        imlTree.ColorDepth = ColorDepth.Depth32Bit;
        imlTree.ImageSize = new Size(16, 16);
        imlTree.TransparentColor = Color.Transparent;
        // 
        // lsvEmployees
        // 
        //lsvEmployees.Columns.AddRange([colId, colName, colPosition, colHireDate]);
        lsvEmployees.Dock = DockStyle.Fill;
        lsvEmployees.FullRowSelect = true;
        lsvEmployees.GridLines = true;
        lsvEmployees.LargeImageList = imlLarge;
        lsvEmployees.Location = new Point(0, 0);
        lsvEmployees.Name = "lsvEmployees";
        lsvEmployees.Size = new Size(576, 438);
        lsvEmployees.SmallImageList = imlSmall;
        lsvEmployees.TabIndex = 0;
        lsvEmployees.TileSize = new Size(220, 56);
        lsvEmployees.UseCompatibleStateImageBehavior = false;
        lsvEmployees.View = View.Details;
        // 
        // colId
        // 
        colId.Text = "Mã NV";
        colId.Width = 85;
        // 
        // colName
        // 
        colName.Text = "Họ Tên";
        colName.Width = 180;
        // 
        // colPosition
        // 
        colPosition.Text = "Chức vụ";
        colPosition.Width = 160;
        // 
        // colHireDate
        // 
        colHireDate.Text = "Ngày vào làm";
        colHireDate.Width = 120;
        // 
        // imlLarge
        // 
        imlLarge.ColorDepth = ColorDepth.Depth32Bit;
        imlLarge.ImageSize = new Size(32, 32);
        imlLarge.TransparentColor = Color.Transparent;
        // 
        // imlSmall
        // 
        imlSmall.ColorDepth = ColorDepth.Depth32Bit;
        imlSmall.ImageSize = new Size(16, 16);
        imlSmall.TransparentColor = Color.Transparent;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(820, 480);
        Controls.Add(splitContainer1);
        Controls.Add(pnlTop);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.4 - Quản lý tổ chức và nhân viên (TreeView & ListView)";
        Load += Form1_Load;
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlTop = null!;
    private Label lblViewMode = null!;
    private ComboBox cboViewMode = null!;
    private SplitContainer splitContainer1 = null!;
    private TreeView tvDepartments = null!;
    private ListView lsvEmployees = null!;
    private ColumnHeader colId = null!;
    private ColumnHeader colName = null!;
    private ColumnHeader colPosition = null!;
    private ColumnHeader colHireDate = null!;
    private ImageList imlTree = null!;
    private ImageList imlLarge = null!;
    private ImageList imlSmall = null!;
}

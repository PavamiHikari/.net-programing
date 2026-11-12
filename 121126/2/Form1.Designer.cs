namespace Bai5_2;

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
        lblCategory = new Label();
        cboCategory = new ComboBox();
        lblAvailable = new Label();
        lstAvailableServices = new ListBox();
        lblSelected = new Label();
        lstSelectedServices = new ListBox();
        btnSelect = new Button();
        btnRemove = new Button();
        btnClearAll = new Button();
        grpPayment = new GroupBox();
        txtFinalTotal = new TextBox();
        lblFinalTotal = new Label();
        nudDiscount = new NumericUpDown();
        lblDiscount = new Label();
        txtSubTotal = new TextBox();
        lblSubTotal = new Label();
        grpPayment.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
        SuspendLayout();
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(18, 25);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(91, 20);
        lblCategory.TabIndex = 0;
        lblCategory.Text = "Loại dịch vụ:";
        // 
        // cboCategory
        // 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(113, 21);
        cboCategory.Margin = new Padding(3, 4, 3, 4);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(239, 28);
        cboCategory.TabIndex = 1;
        cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
        // 
        // lblAvailable
        // 
        lblAvailable.AutoSize = true;
        lblAvailable.Location = new Point(18, 69);
        lblAvailable.Name = "lblAvailable";
        lblAvailable.Size = new Size(131, 20);
        lblAvailable.TabIndex = 2;
        lblAvailable.Text = "Danh sách dịch vụ:";
        // 
        // lstAvailableServices
        // 
        lstAvailableServices.FormattingEnabled = true;
        lstAvailableServices.Location = new Point(18, 96);
        lstAvailableServices.Margin = new Padding(3, 4, 3, 4);
        lstAvailableServices.Name = "lstAvailableServices";
        lstAvailableServices.Size = new Size(297, 284);
        lstAvailableServices.TabIndex = 3;
        lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
        // 
        // lblSelected
        // 
        lblSelected.AutoSize = true;
        lblSelected.Location = new Point(402, 69);
        lblSelected.Name = "lblSelected";
        lblSelected.Size = new Size(118, 20);
        lblSelected.TabIndex = 7;
        lblSelected.Text = "Dịch vụ đã chọn:";
        // 
        // lstSelectedServices
        // 
        lstSelectedServices.FormattingEnabled = true;
        lstSelectedServices.Location = new Point(402, 96);
        lstSelectedServices.Margin = new Padding(3, 4, 3, 4);
        lstSelectedServices.Name = "lstSelectedServices";
        lstSelectedServices.Size = new Size(297, 284);
        lstSelectedServices.TabIndex = 8;
        lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
        // 
        // btnSelect
        // 
        btnSelect.Location = new Point(331, 153);
        btnSelect.Margin = new Padding(3, 4, 3, 4);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(55, 40);
        btnSelect.TabIndex = 4;
        btnSelect.Text = ">";
        btnSelect.UseVisualStyleBackColor = true;
        btnSelect.Click += btnSelect_Click;
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(331, 207);
        btnRemove.Margin = new Padding(3, 4, 3, 4);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(55, 40);
        btnRemove.TabIndex = 5;
        btnRemove.Text = "<";
        btnRemove.UseVisualStyleBackColor = true;
        btnRemove.Click += btnRemove_Click;
        // 
        // btnClearAll
        // 
        btnClearAll.Location = new Point(331, 260);
        btnClearAll.Margin = new Padding(3, 4, 3, 4);
        btnClearAll.Name = "btnClearAll";
        btnClearAll.Size = new Size(55, 40);
        btnClearAll.TabIndex = 6;
        btnClearAll.Text = "<<";
        btnClearAll.UseVisualStyleBackColor = true;
        btnClearAll.Click += btnClearAll_Click;
        // 
        // grpPayment
        // 
        grpPayment.Controls.Add(txtFinalTotal);
        grpPayment.Controls.Add(lblFinalTotal);
        grpPayment.Controls.Add(nudDiscount);
        grpPayment.Controls.Add(lblDiscount);
        grpPayment.Controls.Add(txtSubTotal);
        grpPayment.Controls.Add(lblSubTotal);
        grpPayment.Location = new Point(18, 397);
        grpPayment.Margin = new Padding(3, 4, 3, 4);
        grpPayment.Name = "grpPayment";
        grpPayment.Padding = new Padding(3, 4, 3, 4);
        grpPayment.Size = new Size(681, 155);
        grpPayment.TabIndex = 9;
        grpPayment.TabStop = false;
        grpPayment.Text = "Thông tin thanh toán";
        // 
        // txtFinalTotal
        // 
        txtFinalTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        txtFinalTotal.Location = new Point(194, 109);
        txtFinalTotal.Margin = new Padding(3, 4, 3, 4);
        txtFinalTotal.Name = "txtFinalTotal";
        txtFinalTotal.ReadOnly = true;
        txtFinalTotal.Size = new Size(228, 27);
        txtFinalTotal.TabIndex = 5;
        txtFinalTotal.Text = "0 đ";
        txtFinalTotal.TextAlign = HorizontalAlignment.Right;
        // 
        // lblFinalTotal
        // 
        lblFinalTotal.AutoSize = true;
        lblFinalTotal.Location = new Point(18, 113);
        lblFinalTotal.Name = "lblFinalTotal";
        lblFinalTotal.Size = new Size(156, 20);
        lblFinalTotal.TabIndex = 4;
        lblFinalTotal.Text = "Thành tiền thanh toán:";
        // 
        // nudDiscount
        // 
        nudDiscount.Location = new Point(194, 71);
        nudDiscount.Margin = new Padding(3, 4, 3, 4);
        nudDiscount.Name = "nudDiscount";
        nudDiscount.Size = new Size(229, 27);
        nudDiscount.TabIndex = 3;
        nudDiscount.TextAlign = HorizontalAlignment.Right;
        nudDiscount.ValueChanged += nudDiscount_ValueChanged;
        // 
        // lblDiscount
        // 
        lblDiscount.AutoSize = true;
        lblDiscount.Location = new Point(18, 75);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new Size(140, 20);
        lblDiscount.TabIndex = 2;
        lblDiscount.Text = "Tỷ lệ chiết khấu (%):";
        // 
        // txtSubTotal
        // 
        txtSubTotal.Location = new Point(194, 32);
        txtSubTotal.Margin = new Padding(3, 4, 3, 4);
        txtSubTotal.Name = "txtSubTotal";
        txtSubTotal.ReadOnly = true;
        txtSubTotal.Size = new Size(228, 27);
        txtSubTotal.TabIndex = 1;
        txtSubTotal.Text = "0 đ";
        txtSubTotal.TextAlign = HorizontalAlignment.Right;
        // 
        // lblSubTotal
        // 
        lblSubTotal.AutoSize = true;
        lblSubTotal.Location = new Point(18, 36);
        lblSubTotal.Name = "lblSubTotal";
        lblSubTotal.Size = new Size(149, 20);
        lblSubTotal.TabIndex = 0;
        lblSubTotal.Text = "Tổng tiền chưa giảm:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(718, 573);
        Controls.Add(grpPayment);
        Controls.Add(btnClearAll);
        Controls.Add(btnRemove);
        Controls.Add(btnSelect);
        Controls.Add(lstSelectedServices);
        Controls.Add(lblSelected);
        Controls.Add(lstAvailableServices);
        Controls.Add(lblAvailable);
        Controls.Add(cboCategory);
        Controls.Add(lblCategory);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.2 - Tính tiền dịch vụ và chiết khấu";
        Load += Form1_Load;
        grpPayment.ResumeLayout(false);
        grpPayment.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCategory = null!;
    private ComboBox cboCategory = null!;
    private Label lblAvailable = null!;
    private ListBox lstAvailableServices = null!;
    private Label lblSelected = null!;
    private ListBox lstSelectedServices = null!;
    private Button btnSelect = null!;
    private Button btnRemove = null!;
    private Button btnClearAll = null!;
    private GroupBox grpPayment = null!;
    private Label lblSubTotal = null!;
    private TextBox txtSubTotal = null!;
    private Label lblDiscount = null!;
    private NumericUpDown nudDiscount = null!;
    private Label lblFinalTotal = null!;
    private TextBox txtFinalTotal = null!;
}

namespace BankAtmMdiSystem;

partial class frmAtmReconciliation
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnChayDoiSoat = new Button();
        btnDungDoiSoat = new Button();
        lblTrangThai = new Label();
        lstNhatKy = new ListBox();
        SuspendLayout();
        // 
        // btnChayDoiSoat
        // 
        btnChayDoiSoat.Location = new Point(20, 20);
        btnChayDoiSoat.Name = "btnChayDoiSoat";
        btnChayDoiSoat.Size = new Size(190, 34);
        btnChayDoiSoat.TabIndex = 0;
        btnChayDoiSoat.Text = "Chạy Đối Soát Tự Động";
        btnChayDoiSoat.UseVisualStyleBackColor = true;
        btnChayDoiSoat.Click += btnChayDoiSoat_Click;
        // 
        // btnDungDoiSoat
        // 
        btnDungDoiSoat.Enabled = false;
        btnDungDoiSoat.Location = new Point(222, 20);
        btnDungDoiSoat.Name = "btnDungDoiSoat";
        btnDungDoiSoat.Size = new Size(140, 34);
        btnDungDoiSoat.TabIndex = 1;
        btnDungDoiSoat.Text = "Dừng Đối Soát";
        btnDungDoiSoat.UseVisualStyleBackColor = true;
        btnDungDoiSoat.Click += btnDungDoiSoat_Click;
        // 
        // lblTrangThai
        // 
        lblTrangThai.AutoSize = true;
        lblTrangThai.Location = new Point(20, 68);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(211, 15);
        lblTrangThai.TabIndex = 2;
        lblTrangThai.Text = "Trạng thái: Sẵn sàng đối soát cuối ngày";
        // 
        // lstNhatKy
        // 
        lstNhatKy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstNhatKy.FormattingEnabled = true;
        lstNhatKy.ItemHeight = 15;
        lstNhatKy.Location = new Point(20, 96);
        lstNhatKy.Name = "lstNhatKy";
        lstNhatKy.Size = new Size(580, 260);
        lstNhatKy.TabIndex = 3;
        // 
        // frmAtmReconciliation
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 376);
        Controls.Add(lstNhatKy);
        Controls.Add(lblTrangThai);
        Controls.Add(btnDungDoiSoat);
        Controls.Add(btnChayDoiSoat);
        Name = "frmAtmReconciliation";
        Text = "Đối soát Sao kê Giao dịch ATM Cuối ngày";
        FormClosing += frmAtmReconciliation_FormClosing;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnChayDoiSoat;
    private Button btnDungDoiSoat;
    private Label lblTrangThai;
    private ListBox lstNhatKy;
}

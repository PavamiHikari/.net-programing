namespace PowerGridMonitor;

partial class frmPowerGridMonitor
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
        grpDieuKhien = new GroupBox();
        btnDisconnect = new Button();
        btnStartScada = new Button();
        cboSubstation = new ComboBox();
        lblTramBienAp = new Label();
        grpThongSo = new GroupBox();
        lblLoadPercent = new Label();
        lblLoadCaption = new Label();
        lblVoltage = new Label();
        lblVoltageCaption = new Label();
        grpNhatKy = new GroupBox();
        dgvGridLogs = new DataGridView();
        statusStrip1 = new StatusStrip();
        tslLastPacket = new ToolStripStatusLabel();
        tslScanCycles = new ToolStripStatusLabel();
        grpDieuKhien.SuspendLayout();
        grpThongSo.SuspendLayout();
        grpNhatKy.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGridLogs).BeginInit();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // grpDieuKhien
        // 
        grpDieuKhien.Controls.Add(btnDisconnect);
        grpDieuKhien.Controls.Add(btnStartScada);
        grpDieuKhien.Controls.Add(cboSubstation);
        grpDieuKhien.Controls.Add(lblTramBienAp);
        grpDieuKhien.Dock = DockStyle.Top;
        grpDieuKhien.Location = new Point(0, 0);
        grpDieuKhien.Name = "grpDieuKhien";
        grpDieuKhien.Size = new Size(760, 76);
        grpDieuKhien.TabIndex = 0;
        grpDieuKhien.TabStop = false;
        grpDieuKhien.Text = "Điều khiển SCADA";
        // 
        // btnDisconnect
        // 
        btnDisconnect.Enabled = false;
        btnDisconnect.Location = new Point(562, 26);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(130, 32);
        btnDisconnect.TabIndex = 3;
        btnDisconnect.Text = "Ngắt Kết nối";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // btnStartScada
        // 
        btnStartScada.Location = new Point(362, 26);
        btnStartScada.Name = "btnStartScada";
        btnStartScada.Size = new Size(188, 32);
        btnStartScada.TabIndex = 2;
        btnStartScada.Text = "Bắt đầu Giám sát SCADA";
        btnStartScada.UseVisualStyleBackColor = true;
        btnStartScada.Click += btnStartScada_Click;
        // 
        // cboSubstation
        // 
        cboSubstation.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSubstation.FormattingEnabled = true;
        cboSubstation.Items.AddRange(new object[] { "Trạm 110kV Hà Đông", "Trạm 220kV Chèm", "Trạm 110kV Thanh Xuân", "Trạm 220kV Long Biên" });
        cboSubstation.Location = new Point(112, 30);
        cboSubstation.Name = "cboSubstation";
        cboSubstation.Size = new Size(232, 23);
        cboSubstation.TabIndex = 1;
        // 
        // lblTramBienAp
        // 
        lblTramBienAp.AutoSize = true;
        lblTramBienAp.Location = new Point(18, 33);
        lblTramBienAp.Name = "lblTramBienAp";
        lblTramBienAp.Size = new Size(82, 15);
        lblTramBienAp.TabIndex = 0;
        lblTramBienAp.Text = "Trạm biến áp:";
        // 
        // grpThongSo
        // 
        grpThongSo.Controls.Add(lblLoadPercent);
        grpThongSo.Controls.Add(lblLoadCaption);
        grpThongSo.Controls.Add(lblVoltage);
        grpThongSo.Controls.Add(lblVoltageCaption);
        grpThongSo.Dock = DockStyle.Top;
        grpThongSo.Location = new Point(0, 76);
        grpThongSo.Name = "grpThongSo";
        grpThongSo.Size = new Size(760, 88);
        grpThongSo.TabIndex = 1;
        grpThongSo.TabStop = false;
        grpThongSo.Text = "Bảng thông số trực quan";
        // 
        // lblLoadPercent
        // 
        lblLoadPercent.AutoSize = true;
        lblLoadPercent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblLoadPercent.Location = new Point(386, 36);
        lblLoadPercent.Name = "lblLoadPercent";
        lblLoadPercent.Size = new Size(51, 21);
        lblLoadPercent.TabIndex = 3;
        lblLoadPercent.Text = "--- %";
        // 
        // lblLoadCaption
        // 
        lblLoadCaption.AutoSize = true;
        lblLoadCaption.Location = new Point(282, 40);
        lblLoadCaption.Name = "lblLoadCaption";
        lblLoadCaption.Size = new Size(89, 15);
        lblLoadCaption.TabIndex = 2;
        lblLoadCaption.Text = "Mức mang tải:";
        // 
        // lblVoltage
        // 
        lblVoltage.AutoSize = true;
        lblVoltage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblVoltage.Location = new Point(128, 36);
        lblVoltage.Name = "lblVoltage";
        lblVoltage.Size = new Size(59, 21);
        lblVoltage.TabIndex = 1;
        lblVoltage.Text = "--- kV";
        // 
        // lblVoltageCaption
        // 
        lblVoltageCaption.AutoSize = true;
        lblVoltageCaption.Location = new Point(18, 40);
        lblVoltageCaption.Name = "lblVoltageCaption";
        lblVoltageCaption.Size = new Size(97, 15);
        lblVoltageCaption.TabIndex = 0;
        lblVoltageCaption.Text = "Điện áp hiện tại:";
        // 
        // grpNhatKy
        // 
        grpNhatKy.Controls.Add(dgvGridLogs);
        grpNhatKy.Dock = DockStyle.Fill;
        grpNhatKy.Location = new Point(0, 164);
        grpNhatKy.Name = "grpNhatKy";
        grpNhatKy.Size = new Size(760, 294);
        grpNhatKy.TabIndex = 2;
        grpNhatKy.TabStop = false;
        grpNhatKy.Text = "Nhật ký sự cố quá tải";
        // 
        // dgvGridLogs
        // 
        dgvGridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvGridLogs.Dock = DockStyle.Fill;
        dgvGridLogs.Location = new Point(3, 19);
        dgvGridLogs.Name = "dgvGridLogs";
        dgvGridLogs.Size = new Size(754, 272);
        dgvGridLogs.TabIndex = 0;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { tslLastPacket, tslScanCycles });
        statusStrip1.Location = new Point(0, 458);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(760, 22);
        statusStrip1.TabIndex = 3;
        statusStrip1.Text = "statusStrip1";
        // 
        // tslLastPacket
        // 
        tslLastPacket.BorderSides = ToolStripStatusLabelBorderSides.Right;
        tslLastPacket.Name = "tslLastPacket";
        tslLastPacket.Size = new Size(141, 17);
        tslLastPacket.Text = "Gói tin cuối: --:--:--";
        // 
        // tslScanCycles
        // 
        tslScanCycles.Name = "tslScanCycles";
        tslScanCycles.Size = new Size(135, 17);
        tslScanCycles.Text = "Tổng chu kỳ đã quét: 0";
        // 
        // frmPowerGridMonitor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 480);
        Controls.Add(grpNhatKy);
        Controls.Add(grpThongSo);
        Controls.Add(grpDieuKhien);
        Controls.Add(statusStrip1);
        Name = "frmPowerGridMonitor";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Trung tâm Điều độ & Giám sát Lưới điện Thời gian thực (SCADA)";
        FormClosing += frmPowerGridMonitor_FormClosing;
        grpDieuKhien.ResumeLayout(false);
        grpDieuKhien.PerformLayout();
        grpThongSo.ResumeLayout(false);
        grpThongSo.PerformLayout();
        grpNhatKy.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvGridLogs).EndInit();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox grpDieuKhien;
    private Label lblTramBienAp;
    private ComboBox cboSubstation;
    private Button btnStartScada;
    private Button btnDisconnect;
    private GroupBox grpThongSo;
    private Label lblVoltageCaption;
    private Label lblVoltage;
    private Label lblLoadCaption;
    private Label lblLoadPercent;
    private GroupBox grpNhatKy;
    private DataGridView dgvGridLogs;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel tslLastPacket;
    private ToolStripStatusLabel tslScanCycles;
}

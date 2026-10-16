namespace _3
{
    partial class Form2
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
            btnLoadReport = new Button();
            dgvReport = new DataGridView();
            lblSyncStatus = new Label();
            btnStartSync = new Button();
            btnStopSync = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // btnLoadReport
            // 
            btnLoadReport.Location = new Point(8, 416);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(104, 29);
            btnLoadReport.TabIndex = 0;
            btnLoadReport.Text = "Tải báo cáo";
            btnLoadReport.UseVisualStyleBackColor = true;
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(0, 0);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(800, 400);
            dgvReport.TabIndex = 1;
            // 
            // lblSyncStatus
            // 
            lblSyncStatus.AutoSize = true;
            lblSyncStatus.Location = new Point(336, 424);
            lblSyncStatus.Name = "lblSyncStatus";
            lblSyncStatus.Size = new Size(35, 20);
            lblSyncStatus.TabIndex = 2;
            lblSyncStatus.Text = "Stat";
            lblSyncStatus.Click += lblSyncStatus_Click;
            // 
            // btnStartSync
            // 
            btnStartSync.Location = new Point(112, 416);
            btnStartSync.Name = "btnStartSync";
            btnStartSync.Size = new Size(94, 29);
            btnStartSync.TabIndex = 3;
            btnStartSync.Text = "Đồng bộ";
            btnStartSync.UseVisualStyleBackColor = true;
            btnStartSync.Click += btnStartSync_Click;
            // 
            // btnStopSync
            // 
            btnStopSync.Location = new Point(208, 416);
            btnStopSync.Name = "btnStopSync";
            btnStopSync.Size = new Size(120, 29);
            btnStopSync.TabIndex = 4;
            btnStopSync.Text = "Dừng đồng bộ";
            btnStopSync.UseVisualStyleBackColor = true;
            btnStopSync.Click += btnStopSync_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnStopSync);
            Controls.Add(btnStartSync);
            Controls.Add(lblSyncStatus);
            Controls.Add(dgvReport);
            Controls.Add(btnLoadReport);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadReport;
        private DataGridView dgvReport;
        private Label lblSyncStatus;
        private Button btnStartSync;
        private Button btnStopSync;
    }
}
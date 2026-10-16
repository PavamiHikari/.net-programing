using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace _3
{
    public partial class Form2 : Form
    {
        private CancellationTokenSource _ctsRealtime;
        private bool _isSyncing = false;
        public Form2()
        {
            InitializeComponent();
            SetupReportGrid();
        }

        private void SetupReportGrid()
        {
            dgvReport.AutoGenerateColumns = false;
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Columns.Clear();

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RevenueReportItem.Month),
                HeaderText = "Kì báo cáo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RevenueReportItem.TotalOrders),
                HeaderText = "Tổng đơn hàng",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RevenueReportItem.Revenue),
                HeaderText = "Doanh thu",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "c0",
                    FormatProvider = new CultureInfo("vi-VN"),
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        #region Scenario B: Xử lý


        private void lblSyncStatus_Click(object sender, EventArgs e)
        {

        }

        private async void btnLoadReport_Click(object sender, EventArgs e)
        {
            btnLoadReport.Enabled = false;

            Form1 mainForm = this.MdiParent as Form1;
            mainForm?.SetProgressState(true);

            try
            {
                List<RevenueReportItem> data = await Task.Run(() => FetchRevenueReportData());

                dgvReport.DataSource = data;
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mainForm?.SetProgressState(false);
                btnLoadReport.Enabled = true;
            }
        }

        private List<RevenueReportItem> FetchRevenueReportData()
        {
            Thread.Sleep(3500);

            var list = new List<RevenueReportItem>();
            var rand = new Random();

            for (int i = 1; i <= 12; i++)
            {
                list.Add(new RevenueReportItem
                {
                    Month = $"Tháng {i:D2}/2026",
                    TotalOrders = rand.Next(150, 600),
                    Revenue = rand.Next(50, 400) * 1000000m
                });
            }

            return list;
        }


        #endregion

        #region Scenario C

        private void btnStartSync_Click(object sender, EventArgs e)
        {
            if (_isSyncing) return;

            _isSyncing = true;
            _ctsRealtime = new CancellationTokenSource();
            btnStartSync.Enabled = false;
            btnStopSync.Enabled = true;

            CancellationToken token = _ctsRealtime.Token;

            Task.Run(() => BackgroundRealtimeSyncWorker(token), token);
        }

        private void BackgroundRealtimeSyncWorker(CancellationToken token)
        {
            var rand = new Random();

            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(2000);

                if (token.IsCancellationRequested) break;

                int newOrders = rand.Next(1, 10);
                decimal exchangeRate = 25400 + rand.Next(-50, 50);
                string timestamp = DateTime.Now.ToString("HH:mm:ss");

                string displayText = $"[Đồng bộ {timestamp}] Đơn mới: +{newOrders} | USD/VND: {exchangeRate:N0}";

                UpdateSyncStatusLabel(displayText);
            }
        }

        private void UpdateSyncStatusLabel(string text)
        {
            if (this.lblSyncStatus.InvokeRequired)
            {
                this.lblSyncStatus.Invoke(new Action<string>(UpdateSyncStatusLabel), text);
            }
            else
            {
                this.lblSyncStatus.Text = text;
            }
        }

        private void btnStopSync_Click(object sender, EventArgs e)
        {
            if (!_isSyncing) return;

            _ctsRealtime?.Cancel();
            _isSyncing = false;
            btnStartSync.Enabled = true;
            btnStopSync.Enabled = false;
            lblSyncStatus.Text = "Đồng bộ đã dừng.";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ctsRealtime?.Cancel();
        }
        #endregion
    }
}

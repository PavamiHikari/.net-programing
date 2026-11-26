namespace PowerGridMonitor;

public partial class frmPowerGridMonitor : Form
{
    private CancellationTokenSource? _cts;
    private Task? _scadaTask;
    private int _scanCycles;

    public frmPowerGridMonitor()
    {
        InitializeComponent();
        ConfigureGridLogs();

        if (cboSubstation.Items.Count > 0)
        {
            cboSubstation.SelectedIndex = 0;
        }
    }

    private void ConfigureGridLogs()
    {
        dgvGridLogs.AutoGenerateColumns = false;
        dgvGridLogs.ReadOnly = true;
        dgvGridLogs.AllowUserToAddRows = false;
        dgvGridLogs.AllowUserToDeleteRows = false;
        dgvGridLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvGridLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvGridLogs.Columns.Clear();

        dgvGridLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colThoiGian",
            HeaderText = "Thời gian sự cố",
            FillWeight = 80
        });
        dgvGridLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTramBienAp",
            HeaderText = "Trạm biến áp",
            FillWeight = 150
        });
        dgvGridLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colDienAp",
            HeaderText = "Điện áp (kV)",
            FillWeight = 80
        });
        dgvGridLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMucTai",
            HeaderText = "Mức tải (%)",
            FillWeight = 80
        });
        dgvGridLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTrangThai",
            HeaderText = "Cảnh báo",
            FillWeight = 100
        });
    }

    private void btnStartScada_Click(object? sender, EventArgs e)
    {
        if (_cts != null)
        {
            return;
        }

        string substation = cboSubstation.SelectedItem?.ToString() ?? "Trạm 110kV Hà Đông";
        _scanCycles = 0;

        _cts = new CancellationTokenSource();
        CancellationToken token = _cts.Token;

        btnStartScada.Enabled = false;
        btnDisconnect.Enabled = true;
        cboSubstation.Enabled = false;

        _scadaTask = Task.Run(async () =>
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    double voltageKv = Math.Round(108.0 + Random.Shared.NextDouble() * 7.0, 1);
                    int loadPercent = Random.Shared.Next(50, 99);
                    DateTime packetTime = DateTime.Now;
                    int cycle = Interlocked.Increment(ref _scanCycles);

                    UpdateDashboardThreadSafe(substation, voltageKv, loadPercent, packetTime, cycle);

                    await Task.Delay(2000, token);
                }
            }
            catch (OperationCanceledException)
            {}
        }, token);
    }

    private void UpdateDashboardThreadSafe(
        string substation,
        double voltageKv,
        int loadPercent,
        DateTime packetTime,
        int cycle)
    {
        if (IsDisposed || Disposing || !IsHandleCreated)
        {
            return;
        }

        if (this.InvokeRequired)
        {
            try
            {
                this.Invoke(new Action(() =>
                    UpdateDashboardThreadSafe(substation, voltageKv, loadPercent, packetTime, cycle)));
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            return;
        }

        lblVoltage.Text = $"{voltageKv:F1} kV";

        if (loadPercent > 85)
        {
            lblLoadPercent.Text = $"{loadPercent}% - CẢNH BÁO QUÁ TẢI.";
            lblLoadPercent.ForeColor = Color.Red;

            dgvGridLogs.Rows.Insert(
                0,
                packetTime.ToString("HH:mm:ss"),
                substation,
                $"{voltageKv:F1} kV",
                $"{loadPercent}%",
                "Quá tải");
        }
        else
        {
            lblLoadPercent.Text = $"{loadPercent}% - Ổn định";
            lblLoadPercent.ForeColor = Color.Green;
        }

        tslLastPacket.Text = $"Gói tin cuối: {packetTime:HH:mm:ss}";
        tslScanCycles.Text = $"Tổng chu kỳ đã quét: {cycle}";
    }

    private async void btnDisconnect_Click(object? sender, EventArgs e)
    {
        if (_cts == null)
        {
            return;
        }

        btnDisconnect.Enabled = false;
        _cts.Cancel();

        if (_scadaTask != null)
        {
            try
            {
                await _scadaTask;
            }
            catch (OperationCanceledException)
            {
            }
        }

        _cts.Dispose();
        _cts = null;
        _scadaTask = null;

        if (!IsDisposed)
        {
            btnStartScada.Enabled = true;
            cboSubstation.Enabled = true;
        }
    }

    private void frmPowerGridMonitor_FormClosing(object? sender, FormClosingEventArgs e)
    {
        _cts?.Cancel();
    }
}

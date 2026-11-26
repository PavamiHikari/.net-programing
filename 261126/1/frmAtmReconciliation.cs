namespace BankAtmMdiSystem;

public partial class frmAtmReconciliation : Form
{
    private CancellationTokenSource? _cts;

    public frmAtmReconciliation()
    {
        InitializeComponent();
    }

    private void ReportProgressToUi(int percent, string? logMessage, string statusLabel, frmBankAtmMain? mainForm)
    {
        if (IsDisposed || Disposing || !IsHandleCreated)
        {
            return;
        }

        if (InvokeRequired)
        {
            try
            {
                Invoke(new Action(() => ReportProgressToUi(percent, logMessage, statusLabel, mainForm)));
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            return;
        }

        lblTrangThai.Text = statusLabel;
        if (!string.IsNullOrEmpty(logMessage))
        {
            lstNhatKy.Items.Add(logMessage);
            lstNhatKy.TopIndex = lstNhatKy.Items.Count - 1;
        }

        mainForm?.UpdateReconciliationProgress(percent, $"Core Banking: Đang đối soát ({percent}%)");
    }

    private async void btnChayDoiSoat_Click(object? sender, EventArgs e)
    {
        if (_cts != null)
        {
            return;
        }

        _cts = new CancellationTokenSource();
        CancellationToken token = _cts.Token;

        btnChayDoiSoat.Enabled = false;
        btnDungDoiSoat.Enabled = true;
        lstNhatKy.Items.Clear();
        lblTrangThai.Text = "Trạng thái: Đang khởi tạo tiến trình đối soát...";

        frmBankAtmMain? mainForm = MdiParent as frmBankAtmMain;
        mainForm?.UpdateReconciliationProgress(0, "Core Banking: Đang tải sao kê...");

        try
        {
            const int totalTransactions = 250_000;
            const int totalSteps = 20;

            var summary = await Task.Run(async () =>
            {
                int matched = 0;
                int mismatched = 0;
                int batchSize = totalTransactions / totalSteps;

                ReportProgressToUi(
                    0,
                    $"[{DateTime.Now:HH:mm:ss}] Bắt đầu tải {totalTransactions:N0} giao dịch từ máy chủ...",
                    "Trạng thái: Đang tải dữ liệu sao kê...",
                    mainForm);

                for (int step = 1; step <= totalSteps; step++)
                {
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(250, token);

                    int batchMismatch = Random.Shared.Next(0, 3);
                    mismatched += batchMismatch;
                    matched += batchSize - batchMismatch;

                    int percent = step * 100 / totalSteps;
                    int processed = step * batchSize;

                    string? log = step % 4 == 0
                        ? $"[{DateTime.Now:HH:mm:ss}] Đã đối chiếu {processed:N0}/{totalTransactions:N0} giao dịch ({percent}%)."
                        : null;

                    ReportProgressToUi(percent, log, $"Trạng thái: Đang đối soát... {percent}%", mainForm);
                }

                return (Total: totalTransactions, Matched: matched, Mismatched: mismatched);
            }, token);

            lblTrangThai.Text = $"Trạng thái: Hoàn tất đối soát {summary.Total:N0} giao dịch.";
            lstNhatKy.Items.Add($"[{DateTime.Now:HH:mm:ss}] Kết quả: Khớp {summary.Matched:N0} | Sai {summary.Mismatched:N0}.");
            lstNhatKy.TopIndex = lstNhatKy.Items.Count - 1;
            mainForm?.UpdateReconciliationProgress(100, "Core Banking: Đối soát hoàn tất");
        }
        catch (OperationCanceledException)
        {
            lblTrangThai.Text = "Trạng thái: Đã dừng đối soát.";
            lstNhatKy.Items.Add($"[{DateTime.Now:HH:mm:ss}] Tiến trình đối soát đã bị dừng bởi người dùng.");
            mainForm?.UpdateReconciliationProgress(0, "Core Banking: Đã kết nối");
        }
        finally
        {
            _cts?.Dispose();
            _cts = null;

            if (!IsDisposed)
            {
                btnChayDoiSoat.Enabled = true;
                btnDungDoiSoat.Enabled = false;
            }
        }
    }

    private void btnDungDoiSoat_Click(object? sender, EventArgs e)
    {
        if (_cts == null)
        {
            return;
        }

        btnDungDoiSoat.Enabled = false;
        lblTrangThai.Text = "Trạng thái: Đang dừng đối soát...";
        _cts.Cancel();
    }

    private void frmAtmReconciliation_FormClosing(object? sender, FormClosingEventArgs e)
    {
        _cts?.Cancel();
        if (MdiParent is frmBankAtmMain mainForm && !mainForm.Disposing)
        {
            mainForm.UpdateReconciliationProgress(0, "Core Banking: Đã kết nối");
        }
    }
}

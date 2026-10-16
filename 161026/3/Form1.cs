using System;
using System.Linq;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCurrentUser.Text = "Người dùng: Pavami -ADMIN";
            tsProgressBar.Visible = false;
        }

        public void SetProgressState(bool isRunning, int value = 0)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetProgressState(isRunning, value)));
                return;
            }

            tsProgressBar.Visible = isRunning;
            if (isRunning)
            {
                tsProgressBar.Style = ProgressBarStyle.Marquee;
                tsProgressBar.MarqueeAnimationSpeed = 30;
            }
            else
            {
                tsProgressBar.Style = ProgressBarStyle.Continuous;
                tsProgressBar.Value = 0;
            }
        }



        #region Scenario A: Điều hướng MDI
        private void ShowMdiChild<T>() where T : Form, new()
        {
            Form existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
                existingForm.Activate();
                if (existingForm.WindowState == FormWindowState.Minimized)
                {
                    existingForm.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                T childForm = new T
                {
                    MdiParent = this,
                    StartPosition = FormStartPosition.CenterScreen
                };
                childForm.Show();
            }
        }

        private void menuCatProduct_Click(object sender, EventArgs e)
        {
            ShowMdiChild<Form2>();
        }

        private void menuReportRevenue_Click(object sender, EventArgs e)
        {
            ShowMdiChild<Form2>();
        }

        
    
    #endregion

    #region Sắp xếp
    private void menuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuWindowTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuWindowTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }



        #endregion

        #region Thoát

        private void menuSystemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát ứng dụng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }

    public class RevenueReportItem
{
    public string Month { get; set; }
    public int TotalOrders { get; set; }
    public decimal Revenue { get; set; }
}
}

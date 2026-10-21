namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerSystem_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void menuQLSinhVien_Click(object sender, EventArgs e)
        {
            ShowMdiChild<FormStudent>();
        }

        private void toolStripButtonStudent_Click(object sender, EventArgs e)
        {
            ShowMdiChild<FormStudent>();
        }

        

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            lblStatus.Text = "Đã đăng xuất.";
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ShowMdiChild<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    return;
                }
            }

            T newChild = new T();
            newChild.MdiParent = this;
            newChild.Show();
        }

        public void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }
    }
}

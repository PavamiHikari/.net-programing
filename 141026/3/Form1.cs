namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboDVT.Items.Count > 0)
                cboDVT.SelectedIndex = 0;
        }

        private bool KiemTraTrungMa(string maVT)
        {
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item.Text.Trim().Equals(maVT.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void XoaTrang()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDVT.Items.Count > 0) cboDVT.SelectedIndex = 0;
            txtMaVT.Focus();
        }

        private void txtMaVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaVT.Text.Trim();
            string ten = txtTenVT.Text.Trim();
            string dvt = cboDVT.SelectedItem?.ToString() ?? "";
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTrungMa(ma))
            {
                MessageBox.Show("Mã vật tư đã tồn tại trong danh sách.", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaVT.Focus();
                return;
            }

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(ten);
            item.SubItems.Add(dvt);
            item.SubItems.Add(donGia);
            lvVatTu.Items.Add(item);

            XoaTrang();
        }

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVatTu.SelectedItems[0];
                txtMaVT.Text = item.SubItems[0].Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDVT.SelectedItem = item.SubItems[2].Text;
                txtDonGia.Text = item.SubItems[3].Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật trên danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvVatTu.SelectedItems[0];
            string maMoi = txtMaVT.Text.Trim();

            if (!item.Text.Equals(maMoi, StringComparison.OrdinalIgnoreCase) && KiemTraTrungMa(maMoi))
            {
                MessageBox.Show("Mã vật tư mới đã bị trùng với dòng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.SubItems[0].Text = maMoi;
            item.SubItems[1].Text = txtTenVT.Text.Trim();
            item.SubItems[2].Text = cboDVT.SelectedItem?.ToString() ?? "";
            item.SubItems[3].Text = txtDonGia.Text.Trim();

            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
                XoaTrang();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0) return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();
                XoaTrang();
            }
        }
    }
}

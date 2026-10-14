using System.Globalization;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            //check gia
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                ShowError("Vui lòng nhập đơn giá dịch vụ!", txtDonGia);
                return;
            }
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                ShowError("Đơn giá phải là một số hợp lệ và không âm!", txtDonGia);
                return;
            }

            // check khach
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                ShowError("Vui lòng nhập số lượng khách!", txtSoLuong);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                ShowError("Số lượng khách phải là số nguyên dương lớn hơn 0!", txtSoLuong);
                return;
            }

            // check giam
            decimal phanTramGiam = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!decimal.TryParse(txtGiamGia.Text.Trim(), out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
                {
                    ShowError("Tỷ lệ giảm giá phải là số từ 0 đến 100!", txtGiamGia);
                    return;
                }
            }

            decimal tongTien = (donGia * soLuong) * ((100 - phanTramGiam) / 100m);

            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", tongTien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "0 VNĐ";

            txtDonGia.Focus();
        }

        private void ShowError(string message, TextBox targetBox)
        {
            MessageBox.Show(message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            targetBox.Focus();
            targetBox.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

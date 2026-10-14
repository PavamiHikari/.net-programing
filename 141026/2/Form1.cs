using System.Text;

namespace _2
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void radKhanCap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTrungBinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp lỗi sự cố";
                ofd.Filter = "Tệp hình ảnh";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = ofd.FileName;

                    if (picAnhLoi.Image != null)
                    {
                        picAnhLoi.Image.Dispose();
                    }

                    using (var fs = new FileStream(duongDanAnh, FileMode.Open, FileAccess.Read))
                    {
                        picAnhLoi.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Người yêu cầu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            string mucDo = "Thấp";
            if (radTrungBinh.Checked)
            {
                mucDo = "Trung bình";
            }
            else if (radKhanCap.Checked)
            {
                mucDo = "Khẩn cấp";
            }

            List<string> dsThietBi = new List<string>();
            if (chkMayTinhBan.Checked) dsThietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) dsThietBi.Add("Laptop");
            if (chkMayIn.Checked) dsThietBi.Add("Máy in");
            if (chkDienThoai.Checked) dsThietBi.Add("Điện thoại");

            string thietBiText = dsThietBi.Count > 0 ? string.Join(", ", dsThietBi) : "Không xác định / Không chọn";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== THÔNG TIN PHIẾU ===");
            sb.AppendLine($"- Mã phiếu: {txtMaPhieu.Text.Trim()}");
            sb.AppendLine($"- Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}");
            sb.AppendLine($"- Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}");
            sb.AppendLine($"- Mức độ ưu tiên: {mucDo}");
            sb.AppendLine();
            sb.AppendLine("=== CHI TIẾT SỰ CỐ ===");
            sb.AppendLine($"- Loại sự cố: {cboLoaiSuCo.SelectedItem}");
            sb.AppendLine($"- Thiết bị ảnh hưởng: {thietBiText}");
            sb.AppendLine($"- Đính kèm ảnh: {(string.IsNullOrEmpty(duongDanAnh) ? "Chưa tải ảnh" : Path.GetFileName(duongDanAnh))}");

            MessageBox.Show(sb.ToString(), "Tóm tắt yêu cầu sự cố", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            radThap.Checked = true;

            cboLoaiSuCo.SelectedIndex = 0;
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }
            duongDanAnh = string.Empty;

            txtMaPhieu.Focus();
        }

        private void cboLoaiSuCo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboLoaiSuCo.Items.AddRange(new string[] {
                "Phần cứng",
                "Phần mềm",
                "Mạng",
                "Tài khoản"
            });
            cboLoaiSuCo.SelectedIndex = 0;
        }
    }
}

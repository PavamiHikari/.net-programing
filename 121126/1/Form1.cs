namespace Bai5_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        epCheck.Clear();
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống.");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            epCheck.SetError(txtPassword, "Mật khẩu không được để trống.");
            isValid = false;
        }

        if (txtConfirmPassword.Text != txtPassword.Text)
        {
            epCheck.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp.");
            isValid = false;
        }

        if (CalculateAge(dtpBirthDate.Value) < 18)
        {
            epCheck.SetError(dtpBirthDate, "Người dùng phải từ 18 tuổi trở lên.");
            isValid = false;
        }

        if (!chkTerms.Checked)
        {
            epCheck.SetError(chkTerms, "Bạn phải đồng ý điều khoản dịch vụ.");
            isValid = false;
        }

        if (isValid)
        {
            string gender = radMale.Checked ? "Nam" : "Nữ";
            MessageBox.Show(
                $"Đăng ký tài khoản thành công.\nTên đăng nhập: {txtUsername.Text.Trim()}\nGiới tính: {gender}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtConfirmPassword.Clear();
        dtpBirthDate.Value = DateTime.Today;
        radMale.Checked = true;
        chkTerms.Checked = false;
        epCheck.Clear();
        txtUsername.Focus();
    }

    private static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    private void txtUsername_TextChanged(object sender, EventArgs e)
    {

    }
}

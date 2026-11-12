namespace Bai5_1;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        grpPersonal = new GroupBox();
        txtConfirmPassword = new TextBox();
        lblConfirmPassword = new Label();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtUsername = new TextBox();
        lblUsername = new Label();
        grpAdditional = new GroupBox();
        chkTerms = new CheckBox();
        radFemale = new RadioButton();
        radMale = new RadioButton();
        lblGender = new Label();
        dtpBirthDate = new DateTimePicker();
        lblBirthDate = new Label();
        btnRegister = new Button();
        btnReset = new Button();
        epCheck = new ErrorProvider(components);
        grpPersonal.SuspendLayout();
        grpAdditional.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
        SuspendLayout();
        // 
        // grpPersonal
        // 
        grpPersonal.Controls.Add(txtConfirmPassword);
        grpPersonal.Controls.Add(lblConfirmPassword);
        grpPersonal.Controls.Add(txtPassword);
        grpPersonal.Controls.Add(lblPassword);
        grpPersonal.Controls.Add(txtUsername);
        grpPersonal.Controls.Add(lblUsername);
        grpPersonal.Location = new Point(18, 21);
        grpPersonal.Margin = new Padding(3, 4, 3, 4);
        grpPersonal.Name = "grpPersonal";
        grpPersonal.Padding = new Padding(3, 4, 3, 4);
        grpPersonal.Size = new Size(457, 173);
        grpPersonal.TabIndex = 0;
        grpPersonal.TabStop = false;
        grpPersonal.Text = "Thông tin cá nhân";
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.Location = new Point(154, 120);
        txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.Size = new Size(257, 27);
        txtConfirmPassword.TabIndex = 5;
        txtConfirmPassword.UseSystemPasswordChar = true;
        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.AutoSize = true;
        lblConfirmPassword.Location = new Point(16, 124);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new Size(137, 20);
        lblConfirmPassword.TabIndex = 4;
        lblConfirmPassword.Text = "Xác nhận mật khẩu:";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(154, 77);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(257, 27);
        txtPassword.TabIndex = 3;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(16, 81);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(73, 20);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Mật khẩu:";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(154, 35);
        txtUsername.Margin = new Padding(3, 4, 3, 4);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(257, 27);
        txtUsername.TabIndex = 1;
        txtUsername.TextChanged += txtUsername_TextChanged;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(16, 39);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(110, 20);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tên đăng nhập:";
        // 
        // grpAdditional
        // 
        grpAdditional.Controls.Add(chkTerms);
        grpAdditional.Controls.Add(radFemale);
        grpAdditional.Controls.Add(radMale);
        grpAdditional.Controls.Add(lblGender);
        grpAdditional.Controls.Add(dtpBirthDate);
        grpAdditional.Controls.Add(lblBirthDate);
        grpAdditional.Location = new Point(18, 211);
        grpAdditional.Margin = new Padding(3, 4, 3, 4);
        grpAdditional.Name = "grpAdditional";
        grpAdditional.Padding = new Padding(3, 4, 3, 4);
        grpAdditional.Size = new Size(457, 165);
        grpAdditional.TabIndex = 1;
        grpAdditional.TabStop = false;
        grpAdditional.Text = "Thông tin bổ sung";
        // 
        // chkTerms
        // 
        chkTerms.AutoSize = true;
        chkTerms.Location = new Point(154, 119);
        chkTerms.Margin = new Padding(3, 4, 3, 4);
        chkTerms.Name = "chkTerms";
        chkTerms.Size = new Size(253, 24);
        chkTerms.TabIndex = 5;
        chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
        chkTerms.UseVisualStyleBackColor = true;
        // 
        // radFemale
        // 
        radFemale.AutoSize = true;
        radFemale.Location = new Point(240, 77);
        radFemale.Margin = new Padding(3, 4, 3, 4);
        radFemale.Name = "radFemale";
        radFemale.Size = new Size(50, 24);
        radFemale.TabIndex = 4;
        radFemale.Text = "Nữ";
        radFemale.UseVisualStyleBackColor = true;
        // 
        // radMale
        // 
        radMale.AutoSize = true;
        radMale.Checked = true;
        radMale.Location = new Point(154, 77);
        radMale.Margin = new Padding(3, 4, 3, 4);
        radMale.Name = "radMale";
        radMale.Size = new Size(62, 24);
        radMale.TabIndex = 3;
        radMale.TabStop = true;
        radMale.Text = "Nam";
        radMale.UseVisualStyleBackColor = true;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Location = new Point(16, 80);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(68, 20);
        lblGender.TabIndex = 2;
        lblGender.Text = "Giới tính:";
        // 
        // dtpBirthDate
        // 
        dtpBirthDate.Format = DateTimePickerFormat.Short;
        dtpBirthDate.Location = new Point(154, 33);
        dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
        dtpBirthDate.Name = "dtpBirthDate";
        dtpBirthDate.Size = new Size(257, 27);
        dtpBirthDate.TabIndex = 1;
        // 
        // lblBirthDate
        // 
        lblBirthDate.AutoSize = true;
        lblBirthDate.Location = new Point(16, 39);
        lblBirthDate.Name = "lblBirthDate";
        lblBirthDate.Size = new Size(77, 20);
        lblBirthDate.TabIndex = 0;
        lblBirthDate.Text = "Ngày sinh:";
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(258, 392);
        btnRegister.Margin = new Padding(3, 4, 3, 4);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(103, 40);
        btnRegister.TabIndex = 2;
        btnRegister.Text = "Đăng Ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(373, 392);
        btnReset.Margin = new Padding(3, 4, 3, 4);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(103, 40);
        btnReset.TabIndex = 3;
        btnReset.Text = "Làm Mới";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // epCheck
        // 
        epCheck.ContainerControl = this;
        // 
        // Form1
        // 
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 255, 192);
        ClientSize = new Size(494, 453);
        Controls.Add(btnReset);
        Controls.Add(btnRegister);
        Controls.Add(grpAdditional);
        Controls.Add(grpPersonal);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.1 - Đăng ký tài khoản";
        grpPersonal.ResumeLayout(false);
        grpPersonal.PerformLayout();
        grpAdditional.ResumeLayout(false);
        grpAdditional.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpPersonal = null!;
    private Label lblUsername = null!;
    private TextBox txtUsername = null!;
    private Label lblPassword = null!;
    private TextBox txtPassword = null!;
    private Label lblConfirmPassword = null!;
    private TextBox txtConfirmPassword = null!;
    private GroupBox grpAdditional = null!;
    private Label lblBirthDate = null!;
    private DateTimePicker dtpBirthDate = null!;
    private Label lblGender = null!;
    private RadioButton radMale = null!;
    private RadioButton radFemale = null!;
    private CheckBox chkTerms = null!;
    private Button btnRegister = null!;
    private Button btnReset = null!;
    private ErrorProvider epCheck = null!;
}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _2
{
    public partial class FormStudent : Form
    {
        private BindingList<Student> studentList;
        private BindingSource bindingSource;
        public FormStudent()
        {
            InitializeComponent();
            InitDataAndBindings();
            InitContextMenuEvents();
        }

        private void InitContextMenuEvents()
        {
            menuXoaDong.Click += (s, e) => btnDelete.PerformClick();

            menuLamMoi.Click += (s, e) =>
            {
                bindingSource.ResetBindings(false);
                if (this.MdiParent is Form1 parent)
                {
                    parent.UpdateStatus("Dữ liệu đã được làm mới.");
                }
            };

            menuXemChiTiet.Click += (s, e) =>
            {
                if (bindingSource.Current is Student sv)
                {
                    MessageBox.Show($"Mã SV: {sv.StudentId}\nHọ tên: {sv.FullName}\nTuổi: {sv.Age}\nGiới tính: {sv.Gender}",
                                    "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            dgvStudents.CellMouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    dgvStudents.ClearSelection();
                    dgvStudents.Rows[e.RowIndex].Selected = true;
                    bindingSource.Position = e.RowIndex;
                }
            };
        }

        private void InitDataAndBindings()
        {
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            studentList = new BindingList<Student>();
            bindingSource = new BindingSource { DataSource = studentList };

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = bindingSource;

            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent && !string.IsNullOrEmpty(currentStudent.AvatarPath) && File.Exists(currentStudent.AvatarPath))
            {
                LoadAvatar(currentStudent.AvatarPath);
            }
            else
            {
                ClearAvatar();
            }
        }

        private void LoadAvatar(string path)
        {
            ClearAvatar();
            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    picAvatar.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                picAvatar.Image = null;
            }
        }

        private void ClearAvatar()
        {
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
                picAvatar.Image = null;
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh";
                    ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        LoadAvatar(ofd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn hoặc thêm một sinh viên trước khi chọn ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Mã sinh viên không được trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtAge.Text, out int age);

            var newStudent = new Student
            {
                StudentId = txtStudentId.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Age = age,
                Gender = cboGender.SelectedItem?.ToString() ?? "Nam",
                AvatarPath = string.Empty
            };

            bindingSource.Add(newStudent);
            bindingSource.MoveLast();

            if (this.MdiParent is Form1 parentForm)
            {
                parentForm.UpdateStatus("Thêm sinh viên thành công lúc " + DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            dgvStudents.Refresh();
            MessageBox.Show("Đã cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.MdiParent is Form1 parentForm)
            {
                parentForm.UpdateStatus("Đã cập nhật thông tin sinh viên.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                var confirmResult = MessageBox.Show("Xóa sinh viên đang chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                    if (this.MdiParent is Form1 parentForm)
                    {
                        parentForm.UpdateStatus("Đã xóa sinh viên.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách đang trống hoặc chưa chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (studentList.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách ra CSV";
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine("Mã SV,Họ tên,Tuổi,Giới tính,Đường dẫn ảnh");

                        foreach (var sv in studentList)
                        {
                            string id = EscapeCsvField(sv.StudentId);
                            string name = EscapeCsvField(sv.FullName);
                            string age = sv.Age.ToString();
                            string gender = EscapeCsvField(sv.Gender);
                            string path = EscapeCsvField(sv.AvatarPath);

                            sb.AppendLine($"{id},{name},{age},{gender},{path}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }

        private async void btnLoadDataAsync_Click(object sender, EventArgs e)
        {
            btnLoadDataAsync.Enabled = false;
            prgLoading.Value = 0;
            lblPercent.Text = "0%";

            var parentForm = this.MdiParent as Form1;

            var progress = new Progress<int>(percent =>
            {
                prgLoading.Value = percent;
                lblPercent.Text = $"{percent}%";

                if (parentForm != null)
                {
                    parentForm.UpdateStatus($"Đang nạp dữ liệu: {percent}%");
                }
            });

            try
            {
                List<Student> result = await LoadStudentDataAsync(progress);

                studentList.Clear();
                foreach (var sv in result)
                {
                    studentList.Add(sv);
                }

                if (parentForm != null)
                {
                    parentForm.UpdateStatus($"Nạp dữ liệu hoàn tất lúc {DateTime.Now:HH:mm:ss}");
                }
                MessageBox.Show("Nạp dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (parentForm != null)
                {
                    parentForm.UpdateStatus("Quá trình nạp dữ liệu gặp lỗi.");
                }
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoadDataAsync.Enabled = true;
            }
        }

        private async Task<List<Student>> LoadStudentDataAsync(IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                var list = new List<Student>();
                int totalRecords = 50;

                for (int i = 1; i <= totalRecords; i++)
                {
                    Thread.Sleep(50);

                    list.Add(new Student
                    {
                        StudentId = $"SV{i:D3}",
                        FullName = $"Sinh viên {i}",
                        Age = 18 + (i % 5),
                        Gender = (i % 2 == 0) ? "Nam" : "Nữ",
                        AvatarPath = string.Empty
                    });

                    int percent = (int)((double)i / totalRecords * 100);
                    progress?.Report(percent);
                }

                return list;
            });
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string studentId;
        private string fullName;
        private int age;
        private string gender;
        private string avatarPath;

        public string StudentId
        {
            get => studentId;
            set { if (studentId != value) { studentId = value; OnPropertyChanged(); } }
        }

        public string FullName
        {
            get => fullName;
            set { if (fullName != value) { fullName = value; OnPropertyChanged(); } }
        }

        public int Age
        {
            get => age;
            set { if (age != value) { age = value; OnPropertyChanged(); } }
        }

        public string Gender
        {
            get => gender;
            set { if (gender != value) { gender = value; OnPropertyChanged(); } }
        }

        public string AvatarPath
        {
            get => avatarPath;
            set { if (avatarPath != value) { avatarPath = value; OnPropertyChanged(); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

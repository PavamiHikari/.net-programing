using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _2
{

    public partial class Form1 : Form
    {
        private BindingList<Product> _productList;
        private BindingSource _bindingSource;
        private ErrorProvider _errorProvider;
        public Form1()
        {
            InitializeComponent();
            InitializeDataComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            SetupDataGridView();
            SetupDataBindings();
            ClearInputFields();
            UpdateStatusStrip();
            timerClock.Tick += (s, ev) => lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timerClock.Start();
        }

        private void InitializeDataComponents()
        {
            _errorProvider = new ErrorProvider { ContainerControl = this };
            _productList = new BindingList<Product>();

            _productList.ListChanged += (s, e) => UpdateStatusStrip();

            _bindingSource = new BindingSource { DataSource = _productList };

            _bindingSource.CurrentChanged += (s, e) =>
            {
                if (_bindingSource.Current is Product p && !string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
                {
                    LoadImageToPictureBox(p.ImagePath);
                }
                else
                {
                    picProductImage.Image = null;
                }
            };
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[]
            {
                "-- Chọn loại thiết bị --",
                "Màn hình",
                "Máy tính",
                "Bàn phím",
                "Chuột",
                "Phụ kiện"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;

            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductId),
                HeaderText = "Mã SP",
                FillWeight = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductName),
                HeaderText = "Tên sản phẩm",
                FillWeight = 110,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Category),
                HeaderText = "Loại",
                FillWeight = 60,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Price),
                HeaderText = "Đơn giá",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "c0",
                    FormatProvider = new CultureInfo("vi-VN"),
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 70,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Quantity),
                HeaderText = "Số lượng",
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ImagePath),
                HeaderText = "Đường dẫn ảnh",
                FillWeight = 90,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.DataSource = _bindingSource;
        }

        private void SetupDataBindings()
        {
            txtProductId.DataBindings.Add("Text", _bindingSource, nameof(Product.ProductId), true, DataSourceUpdateMode.Never);
            txtProductName.DataBindings.Add("Text", _bindingSource, nameof(Product.ProductName), true, DataSourceUpdateMode.Never);
            cboCategory.DataBindings.Add("SelectedItem", _bindingSource, nameof(Product.Category), true, DataSourceUpdateMode.Never);

            Binding priceBinding = new Binding("Text", _bindingSource, nameof(Product.Price), true, DataSourceUpdateMode.Never);
            priceBinding.Format += (s, e) =>
            {
                if (e.Value is decimal val) e.Value = val.ToString("N0", CultureInfo.InvariantCulture);
            };
            txtPrice.DataBindings.Add(priceBinding);

            numQuantity.DataBindings.Add("Value", _bindingSource, nameof(Product.Quantity), true, DataSourceUpdateMode.Never);
            txtImagePath.DataBindings.Add("Text", _bindingSource, nameof(Product.ImagePath), true, DataSourceUpdateMode.Never);
        }

        private void LoadImageToPictureBox(string path)
        {
            picProductImage.Image?.Dispose();
            byte[] bytes = File.ReadAllBytes(path);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                picProductImage.Image = Image.FromStream(ms);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh sản phẩm";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                    LoadImageToPictureBox(ofd.FileName);
                }
            }
        }

        private void ExportCSV()
        {
            if (_productList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất CSV";
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"Inventory_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("ProductId,ProductName,Category,Price,Quantity,ImagePath");

                    foreach (var p in _productList)
                    {
                        string name = p.ProductName.Replace("\"", "\"\"");
                        string category = p.Category.Replace("\"", "\"\"");
                        string path = (p.ImagePath ?? string.Empty).Replace("\"", "\"\"");

                        sb.AppendLine($"\"{p.ProductId}\",\"{name}\",\"{category}\",{p.Price.ToString(CultureInfo.InvariantCulture)},{p.Quantity},\"{path}\"");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ImportCSV()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file CSV";
                ofd.Filter = "CSV Files (*.csv)|*.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    if (lines.Length <= 1)
                    {
                        MessageBox.Show("File lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _productList.Clear();

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrEmpty(line)) continue;

                        string[] parts = ParseCsvLine(line);
                        if (parts.Length >= 5)
                        {
                            decimal.TryParse(parts[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price);
                            int.TryParse(parts[4], out int quantity);

                            _productList.Add(new Product
                            {
                                ProductId = parts[0],
                                ProductName = parts[1],
                                Category = parts[2],
                                Price = price,
                                Quantity = quantity,
                                ImagePath = parts.Length > 5 ? parts[5] : string.Empty
                            });
                        }
                    }

                    MessageBox.Show($"Nhập {_productList.Count} sản phẩm từ CSV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string[] ParseCsvLine(string line)
        {
            var parts = line.Split(',');
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim().Trim('"');
            }
            return parts;
        }

        private void UpdateStatusStrip()
        {
            int totalQuantity = _productList.Sum(p => p.Quantity);
            decimal totalValue = _productList.Sum(p => p.Quantity * p.Price);

            lblStatusQuantity.Text = $"Tổng tồn kho: {totalQuantity:N0}";
            lblStatusTotalValue.Text = $"Tổng giá trị: {totalValue.ToString("C0", new CultureInfo("vi-VN"))}";
        }

        private bool ValidateInput(out decimal parsedPrice)
        {
            bool isValid = true;
            parsedPrice = 0;
            _errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                _errorProvider.SetError(txtProductName, "Tên sản phẩm không được trống.");
                isValid = false;
            }

            if (cboCategory.SelectedIndex <= 0)
            {
                _errorProvider.SetError(cboCategory, "Chọn loại sản phẩm.");
                isValid = false;
            }

            string priceStr = txtPrice.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(priceStr, NumberStyles.Number, CultureInfo.InvariantCulture, out parsedPrice) || parsedPrice < 0)
            {
                _errorProvider.SetError(txtPrice, "Đơn giá phải là số và lớn hơn hoặc bằng 0.");
                isValid = false;
            }

            return isValid;
        }

        private string GenerateNextProductId()
        {
            if (_productList.Count == 0) return "SP001";

            int maxId = _productList
                .Select(p => int.TryParse(p.ProductId.Replace("SP", ""), out int id) ? id : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"SP{(maxId + 1):D3}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal price))
                return;

            var newProduct = new Product
            {
                ProductId = GenerateNextProductId(),
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.SelectedItem.ToString(),
                Price = price,
                Quantity = (int)numQuantity.Value,
                ImagePath = txtImagePath.Text.Trim()
            };

            _productList.Add(newProduct);
            _bindingSource.MoveLast();
            _errorProvider.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Product currentProduct)
                return;
            if (!ValidateInput(out decimal price)) return;

            currentProduct.ProductName = txtProductName.Text.Trim();
            currentProduct.Category = cboCategory.SelectedItem.ToString();
            currentProduct.Price = price;
            currentProduct.Quantity = (int)numQuantity.Value;
            currentProduct.ImagePath = txtImagePath.Text.Trim();

            _bindingSource.ResetCurrentItem();
            UpdateStatusStrip();
            _errorProvider.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Product currentProduct)
                return;

            DialogResult confirm = MessageBox.Show(
                $"Xóa sản phẩm [{currentProduct.ProductId} - {currentProduct.ProductName}]?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                _bindingSource.RemoveCurrent();
                _errorProvider.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtProductId.Text = GenerateNextProductId();
            txtProductName.Clear();
            cboCategory.SelectedIndex = 0;
            txtPrice.Clear();
            numQuantity.Value = 0;
            txtImagePath.Clear();
            picProductImage.Image?.Dispose();
            picProductImage.Image = null;
            txtProductName.Focus();
        }

        private void menuToolsExport_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        private void menuToolsImport_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }

        private void menuSystemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInventoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

    public class Product : INotifyPropertyChanged
    {
        private string _productId;
        private string _productName;
        private string _category;
        private decimal _price;
        private int _quantity;
        private string _imagePath;

        public string ProductId
        {
            get => _productId;
            set
            {
                if(_productId != value)
                {
                    _productId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Category
        {
            get => _category;
            set
            {
                if(_category != value)
                {
                    _category = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if(_price != value)
                {
                    _price = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if(_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                if(_imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

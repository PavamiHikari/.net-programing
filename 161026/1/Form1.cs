using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace _1
{
    public partial class Form1 : Form
    {
        private BindingList<Device> _deviceList;
        private BindingSource _bindingSource;
        private ErrorProvider _errorProvider;
        public Form1()
        {
            InitializeComponent();
            InitializeDataComponents();
        }

        private void txtDeviceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            SetupDataGridView();
            SetupDataBindings();
            ClearInputFields();
        }

        private void InitializeDataComponents()
        {
            _errorProvider = new ErrorProvider { ContainerControl = this };
            _deviceList = new BindingList<Device>();
            _bindingSource = new BindingSource { DataSource = _deviceList };
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
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
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.MultiSelect = false;
            dgvDevices.ReadOnly = true;
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.RowHeadersVisible = false;

            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Device.DeviceId),
                HeaderText = "Mã TB",
                FillWeight = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Device.DeviceName),
                HeaderText = "Tên thiết bị",
                FillWeight = 120,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Device.Category),
                HeaderText = "Loại",
                FillWeight = 70,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Device.Price),
                HeaderText = "Đơn giá",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "c0",
                    FormatProvider = new CultureInfo("vi-VN"),
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 80,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Device.Quantity),
                HeaderText = "Số lượng",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.DataSource = _bindingSource;
        }

        private void SetupDataBindings()
        {
            txtDeviceId.DataBindings.Add("Text", _bindingSource, nameof(Device.DeviceId), true, DataSourceUpdateMode.Never);
            txtDeviceName.DataBindings.Add("Text", _bindingSource, nameof(Device.DeviceName), true, DataSourceUpdateMode.Never);
            cboCategory.DataBindings.Add("SelectedItem", _bindingSource, nameof(Device.Category), true, DataSourceUpdateMode.Never);

            Binding priceBinding = new Binding("Text", _bindingSource, nameof(Device.Price), true, DataSourceUpdateMode.Never);
            priceBinding.Format += (s, e) =>
            {
                if (e.Value is decimal val)
                    e.Value = val.ToString("N0", CultureInfo.InvariantCulture);
            };
            txtPrice.DataBindings.Add(priceBinding);

            numQuantity.DataBindings.Add("Value", _bindingSource, nameof(Device.Quantity), true, DataSourceUpdateMode.Never);
        }

        private bool ValidateInput(out decimal parsedPrice)
        {
            bool isValid = true;
            parsedPrice = 0;
            _errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                _errorProvider.SetError(txtDeviceName, "Tên thiết bị không được trống.");
                isValid = false;
            }

            if (cboCategory.SelectedIndex <= 0)
            {
                _errorProvider.SetError(cboCategory, "Chọn loại thiết bị hợp lệ.");
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

        private string GenerateNextDeviceId()
        {
            if (_deviceList.Count == 0)
                return "DEV001";

            int maxId = _deviceList
                .Select(d => int.TryParse(d.DeviceId.Replace("DEV", ""), out int id) ? id : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"DEV{(maxId + 1):D3}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal price))
                return;

            var newDevice = new Device
            {
                DeviceId = GenerateNextDeviceId(),
                DeviceName = txtDeviceName.Text.Trim(),
                Category = cboCategory.SelectedItem.ToString(),
                Price = price,
                Quantity = (int)numQuantity.Value
            };

            _deviceList.Add(newDevice);
            _bindingSource.MoveLast();
            _errorProvider.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Device currentDevice)
                return;
            if (!ValidateInput(out decimal price))
                return;

            currentDevice.DeviceName = txtDeviceName.Text.Trim();
            currentDevice.Category = cboCategory.SelectedItem.ToString();
            currentDevice.Price = price;
            currentDevice.Quantity = (int)numQuantity.Value;

            _bindingSource.ResetCurrentItem();
            _errorProvider.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Device currentDevice)
                return;

            DialogResult confirm = MessageBox.Show(
                $"Xóa thiết bị [{currentDevice.DeviceId} - {currentDevice.DeviceName}]?",
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
            txtDeviceId.Text = GenerateNextDeviceId();
            txtDeviceName.Clear();
            cboCategory.SelectedIndex = 0;
            txtPrice.Clear();
            numQuantity.Value = 0;
            txtDeviceName.Focus();
        }
    }

    public class Device : INotifyPropertyChanged
    {
        private string _deviceID;
        private string _deviceName;
        private string _category;
        private decimal _price;
        private int _quantity;

        public string DeviceId
        {
            get => _deviceID;
            set
            {
                if (_deviceID != value)
                {
                    _deviceID = value;
                    OnPropertyChanged();
                }
            }
        }

        public string DeviceName
        {
            get => _deviceName;
            set
            {
                if(_deviceName != value)
                {
                    _deviceName = value;
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
                if (_price != value)
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
                if(value != _quantity)
                {
                    _quantity = value;
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

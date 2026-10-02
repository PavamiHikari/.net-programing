using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private BindingList<Product> productList = new BindingList<Product>();
        private BindingSource bindingSource = new BindingSource();
        private BindingList<Category> categoryList = new BindingList<Category>();
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoryList.Add(new Category { Id = "C01", Name = "Điện thoại" });
            categoryList.Add(new Category { Id = "C02", Name = "Laptop" });
            categoryList.Add(new Category { Id = "C03", Name = "Phụ kiện" });

            cboCategory.DataSource = categoryList;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductId", HeaderText = "Mã SP", Name = "ProductId" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên SP", Name = "ProductName" });

            DataGridViewComboBoxColumn colCategory = new DataGridViewComboBoxColumn();
            colCategory.DataPropertyName = "CategoryId";
            colCategory.HeaderText = "Danh Mục";
            colCategory.DataSource = categoryList;
            colCategory.DisplayMember = "Name";
            colCategory.ValueMember = "Id";
            colCategory.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing; // Trông giống textbox bình thường
            dgvProducts.Columns.Add(colCategory);

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Đơn Giá", Name = "UnitPrice" });
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số Lượng", Name = "Quantity" });

            bindingSource.DataSource = productList;
            dgvProducts.DataSource = bindingSource;
            UpdateStatus();
        }
        private void UpdateStatus()
        {
            lblTotal.Text = $"Tổng số sản phẩm: {productList.Count}";
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Tên SP không được để trống.");
                isValid = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(txtUnitPrice, "Đơn giá phải là số lớn hơn 0.");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải là số nguyên >= 0.");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var product = new Product
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                CategoryId = cboCategory.SelectedValue.ToString(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImagePath = picAvatar.ImageLocation
            };

            productList.Add(product);
            UpdateStatus();
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || !ValidateInput()) return;

            var product = (Product)dgvProducts.CurrentRow.DataBoundItem;
            product.ProductId = txtProductId.Text;
            product.ProductName = txtProductName.Text;
            product.CategoryId = cboCategory.SelectedValue.ToString();
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            product.Quantity = int.Parse(txtQuantity.Text);
            product.ImagePath = picAvatar.ImageLocation;

            dgvProducts.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var product = (Product)dgvProducts.CurrentRow.DataBoundItem;
                productList.Remove(product);
                UpdateStatus();
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            picAvatar.Image = null;
            picAvatar.ImageLocation = null;
            txtProductId.Focus();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem != null)
            {
                var product = (Product)dgvProducts.CurrentRow.DataBoundItem;
                txtProductId.Text = product.ProductId;
                txtProductName.Text = product.ProductName;
                cboCategory.SelectedValue = product.CategoryId;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.Quantity.ToString();

                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    picAvatar.ImageLocation = product.ImagePath;
                }
                else
                {
                    picAvatar.ImageLocation = null;
                    picAvatar.Image = null;
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.ImageLocation = ofd.FileName;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                bindingSource.DataSource = productList;
            }
            else
            {
                var filteredList = productList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                bindingSource.DataSource = new BindingList<Product>(filteredList);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("Mã SP,Tên SP,Mã Danh Mục,Đơn Giá,Số Lượng");
                        foreach (var p in productList)
                        {
                            sw.WriteLine($"{p.ProductId},{p.ProductName},{p.CategoryId},{p.UnitPrice},{p.Quantity}");
                        }
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

public class Category
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public string CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public string ImagePath { get; set; }
}
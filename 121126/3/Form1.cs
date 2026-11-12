namespace Bai5_3;

public partial class Form1 : Form
{
    private readonly List<Product> _products =
    [
        new Product { ProductId = "SP01", ProductName = "Bàn phím cơ", UnitPrice = 850000, Quantity = 12, Category = "Phụ kiện" },
        new Product { ProductId = "SP02", ProductName = "Chuột không dây", UnitPrice = 320000, Quantity = 25, Category = "Phụ kiện" },
        new Product { ProductId = "SP03", ProductName = "Màn hình 24 inch", UnitPrice = 3200000, Quantity = 7, Category = "Thiết bị" }
    ];

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        cboCategory.Items.AddRange(["Thiết bị", "Phụ kiện", "Laptop", "Điện thoại", "Khác"]);
        RefreshGrid(_products);
    }

    private void RefreshGrid(List<Product> source)
    {
        bsProducts.DataSource = null;
        bsProducts.DataSource = source;

        if (dgvProducts.Columns[nameof(Product.UnitPrice)] is DataGridViewColumn priceCol)
        {
            priceCol.DefaultCellStyle.Format = "N0";
            priceCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        if (dgvProducts.Columns[nameof(Product.Quantity)] is DataGridViewColumn qtyCol)
        {
            qtyCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }

    private List<Product> GetCurrentFilteredList()
    {
        string keyword = txtSearch.Text.Trim();
        if (string.IsNullOrEmpty(keyword))
        {
            return _products;
        }

        return _products
            .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    private bool TryReadInput(out Product product)
    {
        product = new Product();

        string id = txtProductId.Text.Trim();
        string name = txtProductName.Text.Trim();
        string category = cboCategory.Text.Trim();

        if (string.IsNullOrEmpty(id))
        {
            MessageBox.Show("Vui lòng nhập Mã SP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProductId.Focus();
            return false;
        }

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Vui lòng nhập Tên SP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProductName.Focus();
            return false;
        }

        if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice < 0)
        {
            MessageBox.Show("Đơn giá phải là số hợp lệ (>= 0).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUnitPrice.Focus();
            return false;
        }

        if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity < 0)
        {
            MessageBox.Show("Số lượng phải là số nguyên hợp lệ (>= 0).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtQuantity.Focus();
            return false;
        }

        if (string.IsNullOrEmpty(category))
        {
            MessageBox.Show("Vui lòng chọn hoặc nhập Danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboCategory.Focus();
            return false;
        }

        product = new Product
        {
            ProductId = id,
            ProductName = name,
            UnitPrice = unitPrice,
            Quantity = quantity,
            Category = category
        };
        return true;
    }

    private void ClearInputs()
    {
        txtProductId.Clear();
        txtProductName.Clear();
        txtUnitPrice.Clear();
        txtQuantity.Clear();
        cboCategory.Text = string.Empty;
        txtProductId.Focus();
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (!TryReadInput(out Product newProduct))
        {
            return;
        }

        if (_products.Any(p => p.ProductId.Equals(newProduct.ProductId, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã SP đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProductId.Focus();
            return;
        }

        _products.Add(newProduct);
        RefreshGrid(GetCurrentFilteredList());
        ClearInputs();
    }

    private void btnEdit_Click(object? sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
        {
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryReadInput(out Product updated))
        {
            return;
        }

        if (!updated.ProductId.Equals(selected.ProductId, StringComparison.OrdinalIgnoreCase) &&
            _products.Any(p => p.ProductId.Equals(updated.ProductId, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã SP mới bị trùng với sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProductId.Focus();
            return;
        }

        selected.ProductId = updated.ProductId;
        selected.ProductName = updated.ProductName;
        selected.UnitPrice = updated.UnitPrice;
        selected.Quantity = updated.Quantity;
        selected.Category = updated.Category;

        RefreshGrid(GetCurrentFilteredList());
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
        {
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa sản phẩm \"{selected.ProductName}\" ({selected.ProductId})?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            _products.Remove(selected);
            RefreshGrid(GetCurrentFilteredList());
            ClearInputs();
        }
    }

    private void btnSearch_Click(object? sender, EventArgs e)
    {
        RefreshGrid(GetCurrentFilteredList());
    }

    private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product product)
        {
            txtProductId.Text = product.ProductId;
            txtProductName.Text = product.ProductName;
            txtUnitPrice.Text = product.UnitPrice.ToString("0.##");
            txtQuantity.Text = product.Quantity.ToString();
            cboCategory.Text = product.Category;
        }
    }
}

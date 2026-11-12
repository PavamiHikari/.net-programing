namespace Bai5_2;

public partial class Form1 : Form
{
    private readonly List<ServiceItem> _allServices =
    [
        new ServiceItem { Category = "Khám bệnh", Name = "Khám nội tổng quát", Price = 150000 },
        new ServiceItem { Category = "Khám bệnh", Name = "Khám tai mũi họng", Price = 120000 },
        new ServiceItem { Category = "Khám bệnh", Name = "Khám răng hàm mặt", Price = 100000 },
        new ServiceItem { Category = "Khám bệnh", Name = "Khám mắt", Price = 120000 },

        new ServiceItem { Category = "Xét nghiệm", Name = "Xét nghiệm máu tổng quát", Price = 200000 },
        new ServiceItem { Category = "Xét nghiệm", Name = "Xét nghiệm nước tiểu", Price = 80000 },
        new ServiceItem { Category = "Xét nghiệm", Name = "Xét nghiệm đường huyết", Price = 90000 },
        new ServiceItem { Category = "Xét nghiệm", Name = "Xét nghiệm chức năng gan", Price = 250000 },

        new ServiceItem { Category = "Chụp X-Quang", Name = "Chụp X-Quang phổi", Price = 180000 },
        new ServiceItem { Category = "Chụp X-Quang", Name = "Chụp X-Quang xương khớp", Price = 200000 },
        new ServiceItem { Category = "Chụp X-Quang", Name = "Chụp CT Scanner", Price = 1200000 },

        new ServiceItem { Category = "Vắc-xin", Name = "Vắc-xin cúm mùa", Price = 350000 },
        new ServiceItem { Category = "Vắc-xin", Name = "Vắc-xin viêm gan B", Price = 280000 },
        new ServiceItem { Category = "Vắc-xin", Name = "Vắc-xin HPV", Price = 1800000 }
    ];

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        cboCategory.Items.AddRange(["Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin"]);
        cboCategory.SelectedIndex = 0;
        UpdateTotals();
    }

    private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadAvailableServices();
    }

    private void LoadAvailableServices()
    {
        lstAvailableServices.Items.Clear();
        if (cboCategory.SelectedItem is not string category)
        {
            return;
        }

        foreach (var service in _allServices)
        {
            if (service.Category == category && !lstSelectedServices.Items.Contains(service))
            {
                lstAvailableServices.Items.Add(service);
            }
        }
    }

    private void btnSelect_Click(object? sender, EventArgs e)
    {
        MoveSelectedToChosen();
    }

    private void lstAvailableServices_DoubleClick(object? sender, EventArgs e)
    {
        MoveSelectedToChosen();
    }

    private void MoveSelectedToChosen()
    {
        if (lstAvailableServices.SelectedItem is not ServiceItem item)
        {
            return;
        }

        lstAvailableServices.Items.Remove(item);
        lstSelectedServices.Items.Add(item);
        UpdateTotals();
    }

    private void btnRemove_Click(object? sender, EventArgs e)
    {
        RemoveSelectedFromChosen();
    }

    private void lstSelectedServices_DoubleClick(object? sender, EventArgs e)
    {
        RemoveSelectedFromChosen();
    }

    private void RemoveSelectedFromChosen()
    {
        if (lstSelectedServices.SelectedItem is not ServiceItem item)
        {
            return;
        }

        lstSelectedServices.Items.Remove(item);
        if (cboCategory.SelectedItem is string category && item.Category == category)
        {
            lstAvailableServices.Items.Add(item);
        }
        UpdateTotals();
    }

    private void btnClearAll_Click(object? sender, EventArgs e)
    {
        lstSelectedServices.Items.Clear();
        LoadAvailableServices();
        UpdateTotals();
    }

    private void nudDiscount_ValueChanged(object? sender, EventArgs e)
    {
        UpdateTotals();
    }

    private void UpdateTotals()
    {
        decimal subTotal = 0;
        foreach (ServiceItem item in lstSelectedServices.Items)
        {
            subTotal += item.Price;
        }

        decimal discountRate = nudDiscount.Value / 100m;
        decimal finalTotal = subTotal * (1m - discountRate);

        txtSubTotal.Text = $"{subTotal:N0} đ";
        txtFinalTotal.Text = $"{finalTotal:N0} đ";
    }
}

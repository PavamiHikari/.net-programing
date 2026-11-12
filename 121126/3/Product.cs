using System.ComponentModel;

namespace Bai5_3;

public class Product
{
    [DisplayName("Mã SP")]
    public string ProductId { get; set; } = string.Empty;

    [DisplayName("Tên SP")]
    public string ProductName { get; set; } = string.Empty;

    [DisplayName("Đơn giá")]
    public decimal UnitPrice { get; set; }

    [DisplayName("Số lượng")]
    public int Quantity { get; set; }

    [DisplayName("Danh mục")]
    public string Category { get; set; } = string.Empty;
}


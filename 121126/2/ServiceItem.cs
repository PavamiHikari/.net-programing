namespace Bai5_2;

public class ServiceItem
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public override string ToString() => $"{Name} ({Price:N0} đ)";
}


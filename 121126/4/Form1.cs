namespace Bai5_4;

public partial class Form1 : Form
{
    private readonly List<Employee> _employees =
    [
        new Employee { EmployeeId = "NV01", FullName = "Nguyễn Văn An", Position = "Trưởng nhóm Backend", HireDate = new DateTime(2022, 3, 15), DepartmentCode = "KT", TeamCode = "KT_BE" },
        new Employee { EmployeeId = "NV02", FullName = "Trần Thị Bình", Position = "Lập trình viên .NET", HireDate = new DateTime(2023, 7, 1), DepartmentCode = "KT", TeamCode = "KT_BE" },
        new Employee { EmployeeId = "NV03", FullName = "Lê Hoàng Cường", Position = "Lập trình viên UI", HireDate = new DateTime(2023, 10, 12), DepartmentCode = "KT", TeamCode = "KT_FE" },
        new Employee { EmployeeId = "NV04", FullName = "Phạm Minh Dung", Position = "Chuyên viên B2B", HireDate = new DateTime(2021, 5, 20), DepartmentCode = "KD", TeamCode = "KD_B2B" },
        new Employee { EmployeeId = "NV05", FullName = "Hoàng Thị Hạnh", Position = "Nhân viên CSKH", HireDate = new DateTime(2024, 1, 8), DepartmentCode = "KD", TeamCode = "KD_CSKH" },
        new Employee { EmployeeId = "NV06", FullName = "Vũ Quốc Khánh", Position = "Chuyên viên Tuyển dụng", HireDate = new DateTime(2022, 11, 3), DepartmentCode = "NS", TeamCode = "NS_TD" }
    ];

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        InitializeImageLists();
        InitializeViewModes();
        BuildOrganizationTree();
    }

    private void InitializeImageLists()
    {
        imlTree.Images.Add(CreateBadgeIcon(16, Color.SteelBlue, "C"));
        imlTree.Images.Add(CreateBadgeIcon(16, Color.DarkGoldenrod, "P"));
        imlTree.Images.Add(CreateBadgeIcon(16, Color.SeaGreen, "N"));

        imlSmall.Images.Add(CreatePersonIcon(16, Color.DodgerBlue));
        imlLarge.Images.Add(CreatePersonIcon(32, Color.DodgerBlue));
    }

    private static Bitmap CreateBadgeIcon(int size, Color color, string letter)
    {
        Bitmap bmp = new(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using SolidBrush brush = new(color);
        g.FillRectangle(brush, 1, 1, size - 2, size - 2);
        using Font font = new("Segoe UI", size * 0.5f, FontStyle.Bold);
        using StringFormat sf = new() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        g.DrawString(letter, font, Brushes.White, new RectangleF(0, 0, size, size), sf);
        return bmp;
    }

    private static Bitmap CreatePersonIcon(int size, Color color)
    {
        Bitmap bmp = new(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using SolidBrush brush = new(color);
        int headSize = size / 3;
        g.FillEllipse(brush, (size - headSize) / 2f, size * 0.12f, headSize, headSize);
        g.FillEllipse(brush, size * 0.18f, size * 0.5f, size * 0.64f, size * 0.42f);
        return bmp;
    }

    private void InitializeViewModes()
    {
        cboViewMode.Items.AddRange(
        [
            View.Details,
            View.SmallIcon,
            View.LargeIcon,
            View.Tile,
            View.List
        ]);
        cboViewMode.SelectedItem = View.Details;
    }

    private void BuildOrganizationTree()
    {
        tvDepartments.Nodes.Clear();

        TreeNode root = new("Công ty", 0, 0) { Tag = "ALL" };

        TreeNode deptKt = new("Phòng Kỹ Thuật", 1, 1) { Tag = "DEPT:KT" };
        deptKt.Nodes.Add(new TreeNode("Nhóm Backend", 2, 2) { Tag = "TEAM:KT_BE" });
        deptKt.Nodes.Add(new TreeNode("Nhóm Frontend", 2, 2) { Tag = "TEAM:KT_FE" });

        TreeNode deptKd = new("Phòng Kinh Doanh", 1, 1) { Tag = "DEPT:KD" };
        deptKd.Nodes.Add(new TreeNode("Nhóm B2B", 2, 2) { Tag = "TEAM:KD_B2B" });
        deptKd.Nodes.Add(new TreeNode("Nhóm CSKH", 2, 2) { Tag = "TEAM:KD_CSKH" });

        TreeNode deptNs = new("Phòng Nhân Sự", 1, 1) { Tag = "DEPT:NS" };
        deptNs.Nodes.Add(new TreeNode("Nhóm Tuyển Dụng", 2, 2) { Tag = "TEAM:NS_TD" });

        root.Nodes.AddRange([deptKt, deptKd, deptNs]);
        tvDepartments.Nodes.Add(root);
        tvDepartments.ExpandAll();
        tvDepartments.SelectedNode = root;
    }

    private void tvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
    {
        if (e.Node?.Tag is not string tag)
        {
            return;
        }

        IEnumerable<Employee> filtered = tag switch
        {
            "ALL" => _employees,
            _ when tag.StartsWith("DEPT:") => _employees.Where(emp => emp.DepartmentCode == tag[5..]),
            _ when tag.StartsWith("TEAM:") => _employees.Where(emp => emp.TeamCode == tag[5..]),
            _ => []
        };

        LoadEmployeesToListView(filtered);
    }

    private void LoadEmployeesToListView(IEnumerable<Employee> employees)
    {
        lsvEmployees.BeginUpdate();
        lsvEmployees.Items.Clear();

        foreach (Employee emp in employees)
        {
            ListViewItem item = new(emp.EmployeeId, 0);
            item.SubItems.Add(emp.FullName);
            item.SubItems.Add(emp.Position);
            item.SubItems.Add(emp.HireDate.ToString("dd/MM/yyyy"));
            lsvEmployees.Items.Add(item);
        }

        lsvEmployees.EndUpdate();
    }

    private void cboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboViewMode.SelectedItem is View view)
        {
            lsvEmployees.View = view;
        }
    }
}

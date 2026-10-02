using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagement
{
    public abstract class PhuongTien
    {
        private string _maPT;
        private string _tenHang;
        private int _namSanXuat;
        private decimal _giaGoc;

        public string MaPT
        {
            get => _maPT;
            set => _maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value;
        }

        public string TenHang
        {
            get => _tenHang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên hãng không được để trống.");
                _tenHang = value;
            }
        }

        public int NamSanXuat
        {
            get => _namSanXuat;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException($"Năm sản xuất phải từ 1900 đến {DateTime.Now.Year}.");
                _namSanXuat = value;
            }
        }

        public decimal GiaGoc
        {
            get => _giaGoc;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Giá gốc phải lớn hơn 0.");
                _giaGoc = value;
            }
        }

        public PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
        {
            MaPT = maPT;
            TenHang = tenHang;
            NamSanXuat = namSanXuat;
            GiaGoc = giaGoc;
        }

        public abstract decimal TinhGiaLanBanh();

        public virtual string GetInfo() => $"Mã: {MaPT} | Hãng: {TenHang} | Năm SX: {NamSanXuat} | Giá gốc: {GiaGoc:N0} VNĐ";
    }

    public class OTo : PhuongTien
    {
        private int _soChoNgoi;
        private double _dungTichDongCo;

        public int SoChoNgoi
        {
            get => _soChoNgoi;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0.");
                _soChoNgoi = value;
            }
        }

        public double DungTichDongCo
        {
            get => _dungTichDongCo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tích động cơ phải lớn hơn 0.");
                _dungTichDongCo = value;
            }
        }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo) : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            return SoChoNgoi <= 9 ? GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m) : GiaGoc + (GiaGoc * 0.10m);
        }

        public override string GetInfo() => $"{base.GetInfo()} | Loại: Ô tô | Chỗ ngồi: {SoChoNgoi} | Động cơ: {DungTichDongCo}cc";
    }

    public class XeMay : PhuongTien
    {
        private int _dungTichXilanh;

        public int DungTichXilanh
        {
            get => _dungTichXilanh;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tích xy-lanh phải lớn hơn 0.");
                _dungTichXilanh = value;
            }
        }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int DungTichXilanh) : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXilanh = DungTichXilanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            return DungTichXilanh < 175 ? GiaGoc + (GiaGoc * 0.02m) : GiaGoc + (GiaGoc * 0.05m);
        }

        public override string GetInfo() => $"{base.GetInfo()} | Loại: Xe máy | Phân khối: {DungTichXilanh}cc";
    }

    public class QuanLiPhuongTien
    {
        private readonly List<PhuongTien> _danhSach = new();

        public void AddPhuongTien(PhuongTien pt)
        {
            ArgumentNullException.ThrowIfNull(pt);
            _danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            foreach (var pt in _danhSach)
            {
                Console.WriteLine($"{pt.GetInfo()} => Giá lăn bánh: {pt.TinhGiaLanBanh():N0}VNĐ");
            }
        }

        public PhuongTien? FindMaxGiaLanBanh()
        {
            if (!_danhSach.Any()) return null;
            return _danhSach.MaxBy(pt => pt.TinhGiaLanBanh());
        }

        public IEnumerable<PhuongTien> SearchByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return Enumerable.Empty<PhuongTien>();
            return _danhSach.Where(pt => pt.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLiPhuongTien quanLi = new QuanLiPhuongTien();

            while (true)
            {
                Console.WriteLine("1. Thêm Ô tô");
                Console.WriteLine("2. Thêm Xe máy");
                Console.WriteLine("3. Danh sách phương tiện");
                Console.WriteLine("4. Phương tiện có giá lăn bánh cao nhất");
                Console.WriteLine("5. Tìm kiếm theo hãng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("--NHẬP THÔNG TIN Ô TÔ");

                            Console.Write("Mã PT: ");
                            string maOto = Console.ReadLine();

                            Console.Write("Tên hãng: ");
                            string hangOto = Console.ReadLine();

                            Console.Write("Năm sản xuất: ");
                            int namOto = int.Parse(Console.ReadLine());

                            Console.Write("Giá gốc: ");
                            decimal giaOto = decimal.Parse(Console.ReadLine());

                            Console.Write("Số chỗ ngồi: ");
                            int choNgoi = int.Parse(Console.ReadLine());

                            Console.Write("Dung tích động cơ: ");
                            double dongCo = double.Parse(Console.ReadLine());

                            quanLi.AddPhuongTien(new OTo(maOto, hangOto, namOto, giaOto, choNgoi, dongCo));

                            Console.WriteLine("--Thành công.");
                            break;

                        case "2":
                            Console.WriteLine("--NHẬP THÔNG TIN XE MÁY");

                            Console.Write("Mã PT: ");
                            string maXeMay = Console.ReadLine();

                            Console.Write("Tên hãng: ");
                            string hangXeMay = Console.ReadLine();

                            Console.Write("Năm sản xuất: ");
                            int namXeMay = int.Parse(Console.ReadLine());

                            Console.Write("Giá gốc: ");
                            decimal giaXeMay = decimal.Parse(Console.ReadLine());

                            Console.Write("Phân khối: ");
                            int phanKhoi = int.Parse(Console.ReadLine());

                            quanLi.AddPhuongTien(new XeMay(maXeMay, hangXeMay, namXeMay, giaXeMay, phanKhoi));

                            Console.WriteLine("--Thành công.");
                            break;

                        case "3":
                            Console.WriteLine("\n--DANH SÁCH PHƯƠNG TIỆN");
                            quanLi.DisplayAll();
                            break;

                        case "4":
                            var maxPt = quanLi.FindMaxGiaLanBanh();
                            Console.WriteLine("--CAO NHẤT");
                            if (maxPt != null)
                                Console.WriteLine($"{maxPt.GetInfo()}\n=> Giá lăn bánh: {maxPt.TinhGiaLanBanh():N0} VNĐ");
                            else
                                Console.WriteLine("Danh sách trống.");
                            break;

                        case "5":
                            Console.Write("--Nhập tên hãng cần tìm: ");
                            string keyword = Console.ReadLine();
                            var results = quanLi.SearchByName(keyword);

                            int count = 0;
                            foreach (var pt in results)
                            {
                                Console.WriteLine($"{pt.GetInfo()} => {pt.TinhGiaLanBanh():N0} VNĐ");
                                count++;
                            }
                            if (count == 0)
                                Console.WriteLine("Không tìm thấy phương tiện nào.");
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dữ liệu nhập vào phải là số hợp lệ.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
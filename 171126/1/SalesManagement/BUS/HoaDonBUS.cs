using System;
using System.Collections.Generic;
using SalesManagement.DAL;
using SalesManagement.DTO;

namespace SalesManagement.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL _dal = new HoaDonDAL();

        public int ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> details)
        {
            if (hoaDon.MaNV <= 0)
                throw new ArgumentException("Vui lòng chọn nhân viên bán hàng!");
            if (details == null || details.Count == 0)
                throw new ArgumentException("Giỏ hàng đang trống! Vui lòng thêm sản phẩm vào giỏ.");

            return _dal.ExecuteOrderTransaction(hoaDon, details);
        }

        public decimal GetDoanhThuTheoNgay(DateTime date)
        {
            return _dal.GetDoanhThuTheoNgay(date);
        }

        public decimal GetDoanhThuTheoThang(int month, int year)
        {
            return _dal.GetDoanhThuTheoThang(month, year);
        }

        public List<TopSanPhamDTO> GetTop5SanPham()
        {
            return _dal.GetTop5SanPham();
        }

        public List<HoaDonDTO> GetAllHoaDon()
        {
            return _dal.GetAllHoaDon();
        }
    }
}


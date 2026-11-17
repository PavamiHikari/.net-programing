using System;
using System.Collections.Generic;
using SalesManagement.DAL;
using SalesManagement.DTO;

namespace SalesManagement.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL _dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (kh.DiemTichLuy < 0)
                throw new ArgumentException("Điểm tích lũy không được âm!");
            if (!_dal.Insert(kh))
                throw new Exception("Thêm khách hàng thất bại!");
        }

        public void Update(KhachHangDTO kh)
        {
            if (kh.MaKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (kh.DiemTichLuy < 0)
                throw new ArgumentException("Điểm tích lũy không được âm!");
            if (!_dal.Update(kh))
                throw new Exception("Cập nhật thông tin khách hàng thất bại!");
        }

        public void Delete(int maKH)
        {
            if (maKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");
            if (!_dal.Delete(maKH))
                throw new Exception("Xóa khách hàng thất bại! (Khách hàng có thể đang liên kết với hóa đơn)");
        }
    }
}


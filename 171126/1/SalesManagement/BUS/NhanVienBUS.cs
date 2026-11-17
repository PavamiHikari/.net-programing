using System;
using System.Collections.Generic;
using SalesManagement.DAL;
using SalesManagement.DTO;

namespace SalesManagement.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL _dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            if (!_dal.Insert(nv))
                throw new Exception("Thêm nhân viên thất bại!");
        }

        public void Update(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            if (!_dal.Update(nv))
                throw new Exception("Cập nhật nhân viên thất bại!");
        }

        public void Delete(int maNV)
        {
            if (maNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (!_dal.Delete(maNV))
                throw new Exception("Xóa nhân viên thất bại! (Nhân viên có thể đang liên kết với hóa đơn)");
        }
    }
}


using System;
using System.Collections.Generic;
using SalesManagement.DAL;
using SalesManagement.DTO;

namespace SalesManagement.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL _dal = new SanPhamDAL();

        public List<SanPhamDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public List<SanPhamDTO> Search(string keyword)
        {
            return _dal.Search(keyword);
        }

        public SanPhamDTO? GetById(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                return null;
            return _dal.GetById(maSP);
        }

        public void Insert(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn phải lớn hơn hoặc bằng 0!");

            var existing = _dal.GetById(sp.MaSP);
            if (existing != null)
                throw new ArgumentException($"Mã sản phẩm '{sp.MaSP}' đã tồn tại!");

            if (!_dal.Insert(sp))
                throw new Exception("Thêm sản phẩm thất bại!");
        }

        public void Update(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn phải lớn hơn hoặc bằng 0!");

            if (!_dal.Update(sp))
                throw new Exception("Cập nhật sản phẩm thất bại!");
        }

        public void Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (!_dal.Delete(maSP))
                throw new Exception("Xóa sản phẩm thất bại! (Sản phẩm có thể đã được bán trong hóa đơn)");
        }
    }
}


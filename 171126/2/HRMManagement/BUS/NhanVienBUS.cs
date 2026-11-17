using System;
using System.Collections.Generic;
using HRMManagement.DAL;
using HRMManagement.DTO;

namespace HRMManagement.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL _dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public List<NhanVienDTO> Search(string keyword, int? maPB)
        {
            return _dal.Search(keyword, maPB);
        }

        public void Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                throw new ArgumentException("Họ tên không được để trống!");
            if (string.IsNullOrWhiteSpace(nv.CCCD))
                throw new ArgumentException("Số CCCD không được để trống!");
            if (nv.MaPB <= 0)
                throw new ArgumentException("Vui lòng chọn phòng ban hợp lệ!");
            if (nv.LuongCoBan <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0!");
            if (nv.HeSoLuong <= 0)
                throw new ArgumentException("Hệ số lương phải lớn hơn 0!");

            if (!_dal.Insert(nv))
                throw new Exception("Thêm nhân viên thất bại!");
        }

        public void Update(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                throw new ArgumentException("Họ tên không được để trống!");
            if (string.IsNullOrWhiteSpace(nv.CCCD))
                throw new ArgumentException("Số CCCD không được để trống!");
            if (nv.MaPB <= 0)
                throw new ArgumentException("Vui lòng chọn phòng ban hợp lệ!");
            if (nv.LuongCoBan <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0!");
            if (nv.HeSoLuong <= 0)
                throw new ArgumentException("Hệ số lương phải lớn hơn 0!");

            if (!_dal.Update(nv))
                throw new Exception("Cập nhật thông tin nhân viên thất bại!");
        }

        public void ChuyenPhongBan(int maNV, int maPBMoi)
        {
            if (maNV <= 0 || maPBMoi <= 0)
                throw new ArgumentException("Thông tin chuyển phòng ban không hợp lệ!");
            if (!_dal.ChuyenPhongBan(maNV, maPBMoi))
                throw new Exception("Chuyển phòng ban thất bại!");
        }

        public void Delete(int maNV)
        {
            if (maNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (!_dal.Delete(maNV))
                throw new Exception("Xóa nhân viên thất bại! (Nhân viên có thể đã có dữ liệu chấm công hoặc lương)");
        }
    }
}


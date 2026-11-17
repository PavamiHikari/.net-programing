using System;
using System.Collections.Generic;
using HRMManagement.DAL;
using HRMManagement.DTO;

namespace HRMManagement.BUS
{
    public class LuongBUS
    {
        private readonly LuongDAL _dal = new LuongDAL();

        public List<BangLuongDTO> TinhLuong(string thangNam)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Vui lòng chọn Tháng/Năm!");

            return _dal.TinhLuong(thangNam);
        }

        public int ChotLuongThang(string thangNam)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Vui lòng chọn Tháng/Năm!");

            return _dal.ChotLuongThang(thangNam);
        }

        /// <summary>
        /// Logic an toàn: Kiểm tra cơ chế Rollback đảm bảo Atomicity (ACID)
        /// </summary>
        public bool KiemTraRollbackMoPhong(out string logMessage)
        {
            return _dal.KiemTraRollbackMoPhong(out logMessage);
        }
    }
}


using System;
using System.Collections.Generic;
using HRMManagement.DAL;
using HRMManagement.DTO;

namespace HRMManagement.BUS
{
    public class PhongBanBUS
    {
        private readonly PhongBanDAL _dal = new PhongBanDAL();

        public List<PhongBanDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(PhongBanDTO pb)
        {
            if (string.IsNullOrWhiteSpace(pb.TenPB))
                throw new ArgumentException("Tên phòng ban không được để trống!");
            if (!_dal.Insert(pb))
                throw new Exception("Thêm phòng ban thất bại!");
        }
    }
}


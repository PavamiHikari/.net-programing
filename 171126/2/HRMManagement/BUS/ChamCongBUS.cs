using System;
using System.Data;
using Microsoft.Data.SqlClient;
using HRMManagement.DAL;

namespace HRMManagement.BUS
{
    public class ChamCongBUS
    {
        private readonly ChamCongDAL _dal = new ChamCongDAL();

        public SqlDataAdapter LoadChamCong(string thangNam, out DataTable dt)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Vui lòng chọn Tháng/Năm!");

            return _dal.GetChamCongAdapter(thangNam, out dt);
        }

        public int LuuChamCong(SqlDataAdapter adapter, DataTable dt, string thangNam)
        {
            if (_dal.IsThangDaKhoa(thangNam))
            {
                throw new InvalidOperationException($"Dữ liệu chấm công tháng {thangNam} ĐÃ ĐƯỢC CHỐT VÀ KHÓA! Không thể chỉnh sửa.");
            }

            // Kiểm tra ràng buộc hợp lệ cho từng dòng
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                if (row["SoNgayCong"] != DBNull.Value)
                {
                    double ngay = Convert.ToDouble(row["SoNgayCong"]);
                    if (ngay < 0 || ngay > 31)
                    {
                        throw new ArgumentException($"Số ngày công của nhân viên #{row["MaNV"]} không hợp lệ ({ngay}). Số ngày công phải từ 0 đến 31!");
                    }
                }

                if (row["SoGioOT"] != DBNull.Value)
                {
                    double ot = Convert.ToDouble(row["SoGioOT"]);
                    if (ot < 0)
                    {
                        throw new ArgumentException($"Số giờ OT của nhân viên #{row["MaNV"]} không được âm!");
                    }
                }
            }

            return _dal.SaveChamCong(adapter, dt);
        }

        public bool IsThangDaKhoa(string thangNam)
        {
            return _dal.IsThangDaKhoa(thangNam);
        }
    }
}


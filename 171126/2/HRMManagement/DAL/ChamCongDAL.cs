using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HRMManagement.DAL
{
    public class ChamCongDAL
    {
        /// <summary>
        /// Khởi tạo dữ liệu chấm công cho tất cả nhân viên chưa có trong tháng được chọn
        /// </summary>
        public void InitChamCongThang(string thangNam)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa)
                    SELECT n.MaNV, @ThangNam, 0, 0, 0
                    FROM NhanVien n
                    WHERE NOT EXISTS (
                        SELECT 1 FROM BangChamCong c WHERE c.MaNV = n.MaNV AND c.ThangNam = @ThangNam
                    )";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Mô hình ngắt kết nối (Disconnected Model):
        /// Trả về SqlDataAdapter và nạp dữ liệu vào DataTable
        /// </summary>
        public SqlDataAdapter GetChamCongAdapter(string thangNam, out DataTable dt)
        {
            InitChamCongThang(thangNam);

            var conn = DatabaseHelper.GetConnection();
            string sql = "SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa FROM BangChamCong WHERE ThangNam = @ThangNam";
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;

            var adapter = new SqlDataAdapter(cmd);
            var builder = new SqlCommandBuilder(adapter);
            builder.ConflictOption = ConflictOption.OverwriteChanges;

            // Khởi tạo các command tự động thông qua SqlCommandBuilder
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            dt = new DataTable("BangChamCong");
            adapter.Fill(dt);

            return adapter;
        }

        /// <summary>
        /// Đồng bộ dữ liệu ngắt kết nối về SQL Server trong 1 thao tác bằng adapter.Update()
        /// </summary>
        public int SaveChamCong(SqlDataAdapter adapter, DataTable dt)
        {
            if (adapter == null || dt == null)
                throw new ArgumentNullException("Adapter hoặc DataTable không hợp lệ!");

            return adapter.Update(dt);
        }

        /// <summary>
        /// Kiểm tra xem tháng này đã bị khóa chấm công chưa
        /// </summary>
        public bool IsThangDaKhoa(string thangNam)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT TOP 1 DaKhoa FROM BangChamCong WHERE ThangNam = @ThangNam AND DaKhoa = 1";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ThangNam", SqlDbType.VarChar, 7).Value = thangNam;
                    object? res = cmd.ExecuteScalar();
                    return res != null && Convert.ToBoolean(res);
                }
            }
        }
    }
}


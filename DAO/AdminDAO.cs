using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AdminDAO
    {
        public AdminDAO() { }

        public Admin LayAdminTheoTenTaiKhoan(string tenTaiKhoan)
        {
            Admin admin = new Admin();

            string query = $"SELECT * FROM Admin WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            admin.maAdmin = dataTable.Rows[0]["maAdmin"].ToString();
            admin.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            admin.hoTen = dataTable.Rows[0]["tenAdmin"].ToString();
            admin.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { admin.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { admin.ngaySinh = null; }
            admin.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            admin.email = dataTable.Rows[0]["email"].ToString();
            admin.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            admin.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return admin;
        }
    }
}

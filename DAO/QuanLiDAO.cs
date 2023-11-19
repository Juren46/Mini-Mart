using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLiDAO
    {
        public QuanLiDAO() { }

        public List<QuanLi> LayDanhSachQuanLi()
        {
            List<QuanLi> listQuanLi = new List<QuanLi>();

            string query = $"SELECT * FROM QuanLi WHERE trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    QuanLi quanLi = new QuanLi();

                    quanLi.maQuanLi = row["maQuanLi"].ToString();
                    quanLi.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    quanLi.hoTen = row["tenQuanLi"].ToString();
                    quanLi.gioiTinh = row["gioiTinh"].ToString();
                    try { quanLi.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { quanLi.ngaySinh = null; }
                    quanLi.soDienThoai = row["soDienThoai"].ToString();
                    quanLi.email = row["email"].ToString();
                    quanLi.diaChi = row["diaChi"].ToString();
                    quanLi.trangThai = (bool)row["trangThai"];
                }
            }

            return listQuanLi;
        }

        public QuanLi LayQuanLiTheoTenTaiKhoan(string tenTaiKhoan)
        {
            QuanLi quanLi = new QuanLi();

            string query = $"SELECT * FROM QuanLi WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            quanLi.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
            quanLi.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            quanLi.hoTen = dataTable.Rows[0]["tenQuanLi"].ToString();
            quanLi.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { quanLi.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { quanLi.ngaySinh = null; }
            quanLi.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            quanLi.email = dataTable.Rows[0]["email"].ToString();
            quanLi.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            quanLi.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return quanLi;
        }

        public int DemSoQuanLi()
        {
            string query = "SELECT COUNT(*) AS SoQuanLi FROM QuanLi;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoQuanLi"];

            return count;
        }

        public bool ThemQuanLi(QuanLi quanLi)
        {
            string ngaySinh;

            if (quanLi.ngaySinh.HasValue)
                ngaySinh = $"\'{quanLi.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"INSERT INTO QuanLi VALUES('{quanLi.maQuanLi}', '{quanLi.tenTaiKhoan}', N'{quanLi.hoTen}', N'{quanLi.gioiTinh}', {ngaySinh}, '{quanLi.soDienThoai}', '{quanLi.email}', N'{quanLi.diaChi}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaQuanLi(string maQuanLi)
        {
            string query = $"UPDATE QuanLi SET trangThai = 0 WHERE maQuanLi = '{maQuanLi}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaQuanLi(QuanLi quanLi)
        {
            string ngaySinh;

            if (quanLi.ngaySinh.HasValue)
                ngaySinh = $"\'{quanLi.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"UPDATE QuanLi SET tenQuanLi = N'{quanLi.hoTen}', gioiTinh = N'{quanLi.gioiTinh}', ngaySinh = {ngaySinh}, soDienThoai = '{quanLi.soDienThoai}', email = '{quanLi.email}', diaChi = N'{quanLi.diaChi}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}

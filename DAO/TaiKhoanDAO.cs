using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public TaiKhoanDAO() { }

        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = "SELECT * FROM TaiKhoan WHERE trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool)row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        public TaiKhoan LayTaiKhoanTheoTen(string tenTaiKhoan)
        {
            TaiKhoan taiKhoan = new TaiKhoan();

            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            taiKhoan.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
            taiKhoan.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            taiKhoan.matKhau = dataTable.Rows[0]["matKhau"].ToString();
            taiKhoan.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return taiKhoan;
        }

        public bool KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}' AND matKhau = '{matKhau}' AND  trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool KiemTraTaiKhoanDaTonTai(string tenTaiKhoan)
        {
            string query = $"SELECT tenTaiKhoan FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = $"INSERT INTO TaiKhoan VALUES ('{taiKhoan.maPhanQuyen}', '{taiKhoan.tenTaiKhoan}', '{taiKhoan.matKhau}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool DoiMatKhau(string tenTaiKhoan, string matKhauMoi)
        {
            string query = $"UPDATE TaiKhoan SET matKhau = '{matKhauMoi}' WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaTaiKhoan(string tenTaiKhoan)
        {
            string query = $"UPDATE TaiKhoan SET trangThai = 0 WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<TaiKhoan> TimKiemTaiKhoan(string keyword)
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = $"SELECT * FROM TaiKhoan " +
                           $"WHERE LOWER(tenTaiKhoan) LIKE '%{keyword}%' " +
                           $"AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool)row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        public List<TaiKhoan> LocTaiKhoanTheoPhanQuyen(string tenPhanQuyen)
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = $"SELECT TK.* " +
                           $"FROM TaiKhoan AS TK JOIN PhanQuyen AS PQ ON TK.maPhanQuyen = PQ.maPhanQuyen " +
                           $"WHERE PQ.tenPhanQuyen = N'{tenPhanQuyen}' AND TK.trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool)row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        public List<TaiKhoan> LayDanhSachTaiKhoanChuaDung()
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = "SELECT * FROM TaiKhoan AS TK " +
                           "WHERE TK.tenTaiKhoan NOT IN " +
                           "(SELECT TenTaiKhoan FROM NhanVien " +
                           "UNION SELECT TenTaiKhoan FROM Admin " +
                           "UNION SELECT TenTaiKhoan FROM QuanLi) " +
                           "AND TK.trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool)row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        public bool KiemTraTaiKhoanCoNguoiDung(string tenTaiKhoan)
        {
            string query = "SELECT * FROM TaiKhoan AS TK " +
                           "WHERE TK.tenTaiKhoan IN " +
                           "(SELECT TenTaiKhoan FROM NhanVien " +
                           "UNION SELECT TenTaiKhoan FROM Admin " +
                           "UNION SELECT TenTaiKhoan FROM QuanLi) " +
                           $"AND TK.tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }
    }
}

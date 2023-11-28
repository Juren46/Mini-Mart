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

            string query = "SELECT * FROM TaiKhoan WHERE trangThai = N'Đang hoạt động';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaiKhoan taiKhoan = new TaiKhoan();
                    taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                    taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    taiKhoan.matKhau = row["matKhau"].ToString();
                    taiKhoan.trangThai = row["trangThai"].ToString();

                    listTaiKhoan.Add(taiKhoan);
                }
            }

            return listTaiKhoan;
        }

        public TaiKhoan LayTaiKhoanTheoTen(string tenTaiKhoan)
        {
            TaiKhoan taiKhoan = new TaiKhoan();

            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                taiKhoan.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = dataTable.Rows[0]["matKhau"].ToString();
                taiKhoan.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            }

            return taiKhoan;
        }

        public bool KiemTraTaiKhoanCoNguoiDung(string tenTaiKhoan)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool KiemTraTaiKhoanDangHoatDong(string tenTaiKhoan)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}' AND trangThai = N'Đang hoạt động';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}' AND matKhau = '{matKhau}';";

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
            string query = $"INSERT INTO TaiKhoan VALUES ('{taiKhoan.maPhanQuyen}', '{taiKhoan.tenTaiKhoan}', '{taiKhoan.matKhau}', N'{taiKhoan.trangThai}');";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool DoiMatKhau(string tenTaiKhoan, string matKhauMoi)
        {
            string query = $"UPDATE TaiKhoan SET matKhau = '{matKhauMoi}' WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaTaiKhoan(string tenTaiKhoan, string matKhau, string trangThai)
        {
            string query = $"UPDATE TaiKhoan SET matKhau = '{matKhau}', trangThai = N'{trangThai}' WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool VoHieuHoaTaiKhoan(string tenTaiKhoan, string trangThai)
        {
            string query = $"UPDATE TaiKhoan SET trangThai = N'{trangThai}' WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<TaiKhoan> TimKiemTaiKhoan(string tuKhoa, string maPhanQuyen, string trangThai)
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = $"SELECT * FROM TaiKhoan " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(tenTaiKhoan) LIKE '%{tuKhoa}%') " +
                           $"AND ('{maPhanQuyen}' = '' OR maPhanQuyen = '{maPhanQuyen}') " +
                           $"AND ('{trangThai}' = '' OR trangThai = N'{trangThai}')";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaiKhoan taiKhoan = new TaiKhoan();

                    taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                    taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    taiKhoan.matKhau = row["matKhau"].ToString();
                    taiKhoan.trangThai = row["trangThai"].ToString();

                    listTaiKhoan.Add(taiKhoan);
                }
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
                           "AND TK.trangThai = N'Chờ xử lý';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaiKhoan taiKhoan = new TaiKhoan();
                    taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                    taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    taiKhoan.matKhau = row["matKhau"].ToString();
                    taiKhoan.trangThai = row["trangThai"].ToString();

                    listTaiKhoan.Add(taiKhoan);
                }
            }

            return listTaiKhoan;
        }
    }
}

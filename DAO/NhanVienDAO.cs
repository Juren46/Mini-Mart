using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public NhanVienDAO() { }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = "SELECT * FROM NhanVien WHERE trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["tenNhanVien"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { nhanVien.ngaySinh = DateTime.MinValue; }
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();
                nhanVien.trangThai = (bool)row["trangThai"];

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }

        public NhanVien LayNhanVienTheoMa(string maNhanVien)
        {
            string query = $"SELECT * FROM NhanVien WHERE maNhanVien = '{maNhanVien}' AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            NhanVien nhanVien = new NhanVien();

            nhanVien.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            nhanVien.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            nhanVien.hoTen = dataTable.Rows[0]["tenNhanVien"].ToString();
            nhanVien.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { nhanVien.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { nhanVien.ngaySinh = DateTime.MinValue; }
            nhanVien.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            nhanVien.email = dataTable.Rows[0]["email"].ToString();
            nhanVien.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            nhanVien.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return nhanVien;
        }

        public NhanVien LayNhanVienTheoTenTaiKhoan(string tenTaiKhoan)
        {
            string query = $"SELECT * FROM NhanVien WHERE tenTaiKhoan = '{tenTaiKhoan}' AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            NhanVien nhanVien = new NhanVien();

            nhanVien.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            nhanVien.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            nhanVien.hoTen = dataTable.Rows[0]["tenNhanVien"].ToString();
            nhanVien.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { nhanVien.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { nhanVien.ngaySinh = DateTime.MinValue; }
            nhanVien.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            nhanVien.email = dataTable.Rows[0]["email"].ToString();
            nhanVien.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            nhanVien.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return nhanVien;
        }

        public int DemSoNhanVien(string tenPhanQuyen)
        {
            string query = "SELECT COUNT(*) AS SoNhanVien " +
                           "FROM NhanVien AS NV " +
                           "JOIN TaiKhoan AS TK ON NV.TenTaiKhoan = TK.TenTaiKhoan " +
                           "JOIN PhanQuyen AS PQ ON TK.MaPhanQuyen = PQ.MaPhanQuyen " +
                           $"WHERE PQ.TenPhanQuyen = '{tenPhanQuyen}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoNhanVien"];

            return count;
        }

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            string query = $"INSERT INTO NhanVien VALUES('{nhanVien.maNhanVien}', '{nhanVien.tenTaiKhoan}', N'{nhanVien.hoTen}', N'{nhanVien.gioiTinh}', '{nhanVien.ngaySinh}', '{nhanVien.soDienThoai}', '{nhanVien.email}', N'{nhanVien.diaChi}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaNhanVien(string maNhanVien)
        {
            string query = $"UPDATE NhanVien SET trangThai = 0 WHERE maNhanVien = '{maNhanVien}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaNhanVien(NhanVien nhanVien)
        {
            string query = $"UPDATE NhanVien SET tenNhanVien = N'{nhanVien.hoTen}', gioiTinh = N'{nhanVien.gioiTinh}', ngaySinh = '{nhanVien.ngaySinh}', soDienThoai = '{nhanVien.soDienThoai}', email = '{nhanVien.email}', diaChi = N'{nhanVien.diaChi}' WHERE maNhanVien = '{nhanVien.maNhanVien}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<NhanVien> TimKiemNhanVien(string keyword)
        {

            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien " +
                           $"WHERE LOWER(maNhanVien) LIKE '%{keyword}%' " +
                           $"OR  LOWER(tenTaiKhoan) LIKE '%{keyword}%' " +
                           $"OR LOWER(tenNhanVien) LIKE N'%{keyword}%' " +
                           $"OR soDienThoai LIKE '%{keyword}%' " +
                           $"OR LOWER(email) LIKE '%{keyword}%' " +
                           $"OR LOWER(diaChi) LIKE N'%{keyword}%' " +
                           $"AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["tenNhanVien"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { nhanVien.ngaySinh = DateTime.MinValue; }
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }

        public List<NhanVien> LocNhanVienTheoPhanQuyen(string tenPhanQuyen)
        {

            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT NV.* " +
                           $"FROM NhanVien AS NV " +
                           $"JOIN TaiKhoan AS TK ON NV.tenTaiKhoan = TK.tenTaiKhoan " +
                           $"JOIN PhanQuyen AS PQ ON TK.maPhanQuyen = PQ.maPhanQuyen " +
                           $"WHERE PQ.tenPhanQuyen = N'{tenPhanQuyen}' " +
                           $"AND NV.trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["tenNhanVien"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { nhanVien.ngaySinh = DateTime.MinValue; }
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }

        public List<NhanVien> LocNhanVienTheoGioiTinh(string gioiTinh)
        {

            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien WHERE gioiTinh = N'{gioiTinh}' AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["tenNhanVien"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { nhanVien.ngaySinh = DateTime.MinValue; }
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }
    }
}

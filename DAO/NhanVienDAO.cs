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

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.maNhanVien = row["maNhanVien"].ToString();
                    nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    nhanVien.hoTen = row["tenNhanVien"].ToString();
                    nhanVien.gioiTinh = row["gioiTinh"].ToString();
                    try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nhanVien.ngaySinh = null; }
                    nhanVien.soDienThoai = row["soDienThoai"].ToString();
                    nhanVien.email = row["email"].ToString();
                    nhanVien.diaChi = row["diaChi"].ToString();
                    nhanVien.trangThai = (bool)row["trangThai"];

                    listNhanVien.Add(nhanVien);
                }
            }

            return listNhanVien;
        }

        public NhanVien LayNhanVienTheoMa(string maNhanVien)
        {
            NhanVien nhanVien = new NhanVien();

            string query = $"SELECT * FROM NhanVien WHERE maNhanVien = '{maNhanVien}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            nhanVien.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            nhanVien.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            nhanVien.hoTen = dataTable.Rows[0]["tenNhanVien"].ToString();
            nhanVien.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { nhanVien.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { nhanVien.ngaySinh = null; }
            nhanVien.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            nhanVien.email = dataTable.Rows[0]["email"].ToString();
            nhanVien.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            nhanVien.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return nhanVien;
        }

        public NhanVien LayNhanVienTheoTenTaiKhoan(string tenTaiKhoan)
        {
            NhanVien nhanVien = new NhanVien();

            string query = $"SELECT * FROM NhanVien WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            nhanVien.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            nhanVien.tenTaiKhoan = dataTable.Rows[0]["tenTaiKhoan"].ToString();
            nhanVien.hoTen = dataTable.Rows[0]["tenNhanVien"].ToString();
            nhanVien.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { nhanVien.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { nhanVien.ngaySinh = null; }
            nhanVien.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            nhanVien.email = dataTable.Rows[0]["email"].ToString();
            nhanVien.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            nhanVien.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return nhanVien;
        }

        public int DemSoNhanVienTheoPhanQuyen(string tenPhanQuyen)
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
            string query;

            if (nhanVien.ngaySinh.HasValue)
                query = $"INSERT INTO NhanVien VALUES('{nhanVien.maNhanVien}', '{nhanVien.tenTaiKhoan}', N'{nhanVien.hoTen}', N'{nhanVien.gioiTinh}', '{nhanVien.ngaySinh}', '{nhanVien.soDienThoai}', '{nhanVien.email}', N'{nhanVien.diaChi}', 1);";
            else
                query = $"INSERT INTO NhanVien VALUES('{nhanVien.maNhanVien}', '{nhanVien.tenTaiKhoan}', N'{nhanVien.hoTen}', N'{nhanVien.gioiTinh}', NULL, '{nhanVien.soDienThoai}', '{nhanVien.email}', N'{nhanVien.diaChi}', 1);";
            
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
            string query;

            if (nhanVien.ngaySinh.HasValue)
                query = $"UPDATE NhanVien SET tenNhanVien = N'{nhanVien.hoTen}', gioiTinh = N'{nhanVien.gioiTinh}', ngaySinh = '{nhanVien.ngaySinh}', soDienThoai = '{nhanVien.soDienThoai}', email = '{nhanVien.email}', diaChi = N'{nhanVien.diaChi}' WHERE maNhanVien = '{nhanVien.maNhanVien}';";
            else
                query = $"UPDATE NhanVien SET tenNhanVien = N'{nhanVien.hoTen}', gioiTinh = N'{nhanVien.gioiTinh}', ngaySinh = NULL, soDienThoai = '{nhanVien.soDienThoai}', email = '{nhanVien.email}', diaChi = N'{nhanVien.diaChi}' WHERE maNhanVien = '{nhanVien.maNhanVien}';";            

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<NhanVien> TimKiemNhanVien(string keyword)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien " +
                           $"WHERE LOWER(maNhanVien) LIKE '%{keyword}%' " +
                           $"OR  LOWER(tenTaiKhoan) LIKE '%{keyword}%' " +
                           $"OR tenNhanVien COLLATE Latin1_General_CI_AI LIKE N'%{keyword}%' " +
                           $"OR soDienThoai LIKE '%{keyword}%' " +
                           $"OR LOWER(email) LIKE '%{keyword}%' " +
                           $"OR diaChi COLLATE Latin1_General_CI_AI LIKE N'%{keyword}%' " +
                           $"AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = new NhanVien();

                    nhanVien.maNhanVien = row["maNhanVien"].ToString();
                    nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    nhanVien.hoTen = row["tenNhanVien"].ToString();
                    nhanVien.gioiTinh = row["gioiTinh"].ToString();
                    try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nhanVien.ngaySinh = null; }
                    nhanVien.soDienThoai = row["soDienThoai"].ToString();
                    nhanVien.email = row["email"].ToString();
                    nhanVien.diaChi = row["diaChi"].ToString();
                    nhanVien.trangThai = (bool)row["trangThai"];

                    listNhanVien.Add(nhanVien);
                }
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

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = new NhanVien();

                    nhanVien.maNhanVien = row["maNhanVien"].ToString();
                    nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    nhanVien.hoTen = row["tenNhanVien"].ToString();
                    nhanVien.gioiTinh = row["gioiTinh"].ToString();
                    try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nhanVien.ngaySinh = null; }
                    nhanVien.soDienThoai = row["soDienThoai"].ToString();
                    nhanVien.email = row["email"].ToString();
                    nhanVien.diaChi = row["diaChi"].ToString();
                    nhanVien.trangThai = (bool)row["trangThai"];

                    listNhanVien.Add(nhanVien);
                }
            }

            return listNhanVien;
        }

        public List<NhanVien> LocNhanVienTheoGioiTinh(string gioiTinh)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien WHERE gioiTinh = N'{gioiTinh}' AND trangThai = 1;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = new NhanVien();

                    nhanVien.maNhanVien = row["maNhanVien"].ToString();
                    nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                    nhanVien.hoTen = row["tenNhanVien"].ToString();
                    nhanVien.gioiTinh = row["gioiTinh"].ToString();
                    try { nhanVien.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nhanVien.ngaySinh = null; }
                    nhanVien.soDienThoai = row["soDienThoai"].ToString();
                    nhanVien.email = row["email"].ToString();
                    nhanVien.diaChi = row["diaChi"].ToString();
                    nhanVien.trangThai = (bool)row["trangThai"];

                    listNhanVien.Add(nhanVien);
                }
            }

            return listNhanVien;
        }
    }
}

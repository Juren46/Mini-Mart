using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = "SELECT * FROM KhachHang;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang khachHang = new KhachHang();

                khachHang.maKhachHang = row["maKhachHang"].ToString();
                khachHang.hoTen = row["tenKhachHang"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
                catch { khachHang.ngaySinh = DateTime.MinValue; }
                khachHang.soDienThoai = row["soDienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                khachHang.bacThanhVien = row["bacThanhVien"].ToString();
                khachHang.diemThanhVien = (int)row["diemThanhVien"];
                khachHang.diemTichLuy = (int)row["diemTichLuy"];

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public KhachHang LayKhachHangTheoMa(string maKhachHang)
        {
            string query = $"SELECT * FROM KhachHang WHERE maKhachHang = '{maKhachHang}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            KhachHang khachHang = new KhachHang();

            khachHang.maKhachHang = dataTable.Rows[0]["maKhachHang"].ToString();
            khachHang.hoTen = dataTable.Rows[0]["tenKhachHang"].ToString();
            khachHang.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { khachHang.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { khachHang.ngaySinh = DateTime.MinValue; }
            khachHang.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            khachHang.email = dataTable.Rows[0]["email"].ToString();
            khachHang.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            khachHang.bacThanhVien = dataTable.Rows[0]["bacThanhVien"].ToString();
            khachHang.diemThanhVien = (int)dataTable.Rows[0]["diemThanhVien"];
            khachHang.diemTichLuy = (int)dataTable.Rows[0]["diemTichLuy"];

            return khachHang;
        }

        public KhachHang LayKhachHangTheoSoDienThoai(string soDienThoai)
        {
            string query = $"SELECT * FROM KhachHang WHERE soDienThoai = '{soDienThoai}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            KhachHang khachHang = new KhachHang();

            khachHang.maKhachHang = dataTable.Rows[0]["maKhachHang"].ToString();
            khachHang.hoTen = dataTable.Rows[0]["tenKhachHang"].ToString();
            khachHang.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
            try { khachHang.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
            catch { khachHang.ngaySinh = DateTime.MinValue; }
            khachHang.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            khachHang.email = dataTable.Rows[0]["email"].ToString();
            khachHang.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            khachHang.bacThanhVien = dataTable.Rows[0]["bacThanhVien"].ToString();
            khachHang.diemThanhVien = (int)dataTable.Rows[0]["diemThanhVien"];
            khachHang.diemTichLuy = (int)dataTable.Rows[0]["diemTichLuy"];

            return khachHang;
        }

        public int DemSoKhachHang()
        {
            string query = $"SELECT COUNT(*) AS SoKhachHang FROM KhachHang;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoKhachHang"];

            return count;
        }

        public bool KiemTraSoDienThoaiDaTonTai(string soDienThoai)
        {
            string query = $"SELECT maKhachHang FROM KhachHang WHERE soDienThoai = '{soDienThoai}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            string query = $"INSERT INTO KhachHang VALUES('{khachHang.maKhachHang}', N'{khachHang.hoTen}', N'{khachHang.gioiTinh}', '{khachHang.ngaySinh}', '{khachHang.soDienThoai}', '{khachHang.email}', N'{khachHang.diaChi}', N'{khachHang.bacThanhVien}', {khachHang.diemThanhVien}, {khachHang.diemTichLuy});";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            string query = $"UPDATE KhachHang SET tenKhachHang = N'{khachHang.hoTen}', gioiTinh = N'{khachHang.gioiTinh}', ngaySinh = '{khachHang.ngaySinh}', soDienThoai = '{khachHang.soDienThoai}', email = '{khachHang.email}', diaChi = N'{khachHang.diaChi}' WHERE maKhachHang = '{khachHang.maKhachHang}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<KhachHang> TimKiemKhachHang(string keyword)
        {

            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = $"SELECT * FROM KhachHang " +
                           $"WHERE LOWER(maKhachHang) LIKE '%{keyword}%' " +
                           $"OR  LOWER(tenKhachHang) LIKE N'%{keyword}%' " +
                           $"OR soDienThoai LIKE '%{keyword}%' " +
                           $"OR LOWER(email) LIKE '%{keyword}%' " +
                           $"OR LOWER(diaChi) LIKE N'%{keyword}%';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang khachHang = new KhachHang();

                khachHang.maKhachHang = row["maKhachHang"].ToString();
                khachHang.hoTen = row["tenKhachHang"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { khachHang.ngaySinh = DateTime.MinValue; }
                khachHang.soDienThoai = row["soDienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                khachHang.bacThanhVien = row["bacThanhVien"].ToString();
                khachHang.diemThanhVien = (int)row["diemThanhVien"];
                khachHang.diemTichLuy = (int)row["diemTichLuy"];

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public List<KhachHang> LocKhachHangTheoGioiTinh(string gioiTinh)
        {

            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = $"SELECT * FROM KhachHang WHERE gioiTinh = N'{gioiTinh}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang khachHang = new KhachHang();

                khachHang.maKhachHang = row["maKhachHang"].ToString();
                khachHang.hoTen = row["tenKhachHang"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { khachHang.ngaySinh = DateTime.MinValue; }
                khachHang.soDienThoai = row["soDienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                khachHang.bacThanhVien = row["bacThanhVien"].ToString();
                khachHang.diemThanhVien = (int)row["diemThanhVien"];
                khachHang.diemTichLuy = (int)row["diemTichLuy"];

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public List<KhachHang> LocKhachHangTheoBacThanhVien(string bacThanhVien)
        {

            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = $"SELECT * FROM KhachHang WHERE bacThanhVien = N'{bacThanhVien}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang khachHang = new KhachHang();

                khachHang.maKhachHang = row["maKhachHang"].ToString();
                khachHang.hoTen = row["tenKhachHang"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)row["ngaySinh"]; }
                catch { khachHang.ngaySinh = DateTime.MinValue; }
                khachHang.soDienThoai = row["soDienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                khachHang.bacThanhVien = row["bacThanhVien"].ToString();
                khachHang.diemThanhVien = (int)row["diemThanhVien"];
                khachHang.diemTichLuy = (int)row["diemTichLuy"];

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }
    }
}

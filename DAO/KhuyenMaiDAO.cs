using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhuyenMaiDAO
    {
        public KhuyenMaiDAO() { }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = "SELECT * FROM KhuyenMai WHERE trangThai = 1 AND thoiGianKetThuc < GETDATE();";


            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.maKhuyenMai = row["maKhuyenMai"].ToString();
                khuyenMai.maQuanLi = row["maQuanLi"].ToString();
                khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                khuyenMai.giaTriApDung = (decimal)row["giaTriApDung"];
                khuyenMai.trangThai = (bool)row["trangThai"];

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }

        public KhuyenMai LayKhuyenMaiTheoMa (string maKhuyenMai)
        {
            KhuyenMai khuyenMai = new KhuyenMai();

            string query = $"SELECT * FROM KhuyenMai WHERE maKhuyenMai = '{maKhuyenMai}'  AND trangThai = 1 AND thoiGianKetThuc < GETDATE();";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            khuyenMai.maKhuyenMai = dataTable.Rows[0]["maKhuyenMai"].ToString();
            khuyenMai.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
            khuyenMai.tenKhuyenMai = dataTable.Rows[0]["tenKhuyenMai"].ToString();
            khuyenMai.thoiGianBatDau = (DateTime)dataTable.Rows[0]["thoiGianBatDau"];
            khuyenMai.thoiGianKetThuc = (DateTime)dataTable.Rows[0]["thoiGianKetThuc"];
            khuyenMai.loaiGiaTri = dataTable.Rows[0]["loaiGiaTri"].ToString();
            khuyenMai.giaTriApDung = (decimal)dataTable.Rows[0]["giaTriApDung"];
            khuyenMai.trangThai = (bool)dataTable.Rows[0]["trangThai"];

            return khuyenMai;
        }

        public int DemSoKhuyenMai()
        {
            string query = "SELECT COUNT(*) AS SoKhuyenMai FROM KhuyenMai;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoKhuyenMai"];

            return count;
        }

        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = $"INSERT INTO KhuyenMai VALUES ('{khuyenMai.maKhuyenMai}', '{khuyenMai.maQuanLi}', N'{khuyenMai.tenKhuyenMai}', '{khuyenMai.thoiGianBatDau}', '{khuyenMai.thoiGianKetThuc}', N'{khuyenMai.loaiGiaTri}', '{khuyenMai.giaTriApDung}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaKhuyenMai(string maKhuyenMai)
        {
            string query = $"UPDATE KhuyenMai SET trangThai = 0, thoiGianKetThuc = GETDATE() WHERE maKhuyenMai = '{maKhuyenMai}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string keyword)
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = $"SELECT * FROM KhuyenMai WHERE LOWER(maKhuyenMai) LIKE '%{keyword}%' " +
                           $"OR LOWER(tenKhuyenMai) LIKE N'%{keyword}%' " +
                           $"AND trangThai = 1 " +
                           $"AND thoiGianKetThuc > GETDATE();";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.maKhuyenMai = row["maKhuyenMai"].ToString();
                khuyenMai.maQuanLi = row["maQuanLi"].ToString();
                khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                khuyenMai.giaTriApDung = (decimal)row["giaTriApDung"];
                khuyenMai.trangThai = (bool)row["trangThai"];

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }

        public List<KhuyenMai> TimKiemKhuyenMaiTheoKhoangThoiGian(DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = $"SELECT * FROM KhuyenMai WHERE thoiGianBatDau <= '{thoiGianBatDau}' AND thoiGianKetThuc >= '{thoiGianKetThuc}';";
            
            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.maKhuyenMai = row["maKhuyenMai"].ToString();
                khuyenMai.maQuanLi = row["maQuanLi"].ToString();
                khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                khuyenMai.giaTriApDung = (decimal)row["giaTriApDung"];
                khuyenMai.trangThai = (bool)row["trangThai"];

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }
    }
}

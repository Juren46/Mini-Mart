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

            string query = "SELECT * FROM KhuyenMai WHERE thoiGianKetThuc > GETDATE();";


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

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }

        public KhuyenMai LayKhuyenMaiTheoMa (string maKhuyenMai)
        {
            KhuyenMai khuyenMai = new KhuyenMai();

            string query = $"SELECT * FROM KhuyenMai WHERE maKhuyenMai = '{maKhuyenMai}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            khuyenMai.maKhuyenMai = dataTable.Rows[0]["maKhuyenMai"].ToString();
            khuyenMai.maQuanLi = dataTable.Rows[0]["maQuanLi"].ToString();
            khuyenMai.tenKhuyenMai = dataTable.Rows[0]["tenKhuyenMai"].ToString();
            khuyenMai.thoiGianBatDau = (DateTime)dataTable.Rows[0]["thoiGianBatDau"];
            khuyenMai.thoiGianKetThuc = (DateTime)dataTable.Rows[0]["thoiGianKetThuc"];
            khuyenMai.loaiGiaTri = dataTable.Rows[0]["loaiGiaTri"].ToString();
            khuyenMai.giaTriApDung = Decimal.Parse(dataTable.Rows[0]["giaTriApDung"].ToString());

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
            string query = $"INSERT INTO KhuyenMai VALUES ('{khuyenMai.maKhuyenMai}', '{khuyenMai.maQuanLi}', N'{khuyenMai.tenKhuyenMai}', '{khuyenMai.thoiGianBatDau}', '{khuyenMai.thoiGianKetThuc}', N'{khuyenMai.loaiGiaTri}', '{khuyenMai.giaTriApDung}');";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaKhuyenMai(string maKhuyenMai)
        {
            string query = $"UPDATE KhuyenMai SET thoiGianKetThuc = GETDATE() WHERE maKhuyenMai = '{maKhuyenMai}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = $"UPDATE KhuyenMai SET tenKhuyenMai = N'{khuyenMai.tenKhuyenMai}', thoiGianBatDau = '{khuyenMai.thoiGianBatDau}', thoiGianKetThuc = '{khuyenMai.thoiGianKetThuc}', loaiGiaTri = N'{khuyenMai.loaiGiaTri}', giaTriApDung = '{khuyenMai.giaTriApDung}' WHERE maKhuyenMai = '{khuyenMai.maKhuyenMai}';";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string keyword)
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = $"SELECT * FROM KhuyenMai " +
                           $"WHERE LOWER(maKhuyenMai) LIKE '%{keyword}%' " +
                           $"OR LOWER(tenKhuyenMai) LIKE N'%{keyword}%' " +
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
                khuyenMai.giaTriApDung = Decimal.Parse(row["giaTriApDung"].ToString());

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

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }

        public decimal ApDungKhuyenMai(string maKhuyenMai, decimal donGia)
        {
            KhuyenMai khuyenMai = LayKhuyenMaiTheoMa(maKhuyenMai);

            if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                return donGia * khuyenMai.giaTriApDung / 100;
            else
            {
                if (donGia - khuyenMai.giaTriApDung > donGia * 70 / 100)
                    return donGia * 70 / 100;
                else
                    return donGia - khuyenMai.giaTriApDung;
            }
        }
    }
}

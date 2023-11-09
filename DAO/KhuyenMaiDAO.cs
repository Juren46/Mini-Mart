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
                khuyenMai.maQuanLi = row["maQuanLi"].ToString();
                khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                khuyenMai.doiTuongApDung = row["doiTuongApDung"].ToString();
                khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                khuyenMai.giaTriApDung = (decimal)row["giaTriApDung"];
                khuyenMai.trangThai = (bool)row["trangThai"];

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
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
            string query = $"INSERT INTO KhuyenMai VALUES ('{khuyenMai.maKhuyenMai}', '{khuyenMai.maQuanLi}', '{khuyenMai.tenKhuyenMai}', '{khuyenMai.thoiGianBatDau}', '{khuyenMai.thoiGianKetThuc}', '{khuyenMai.doiTuongApDung}', '{khuyenMai.loaiGiaTri}', '{khuyenMai.giaTriApDung}', 1);";

            int rowsAffected = DBHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}

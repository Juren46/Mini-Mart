using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new List<ChiTietPhieuNhap>();

            string query = $"SELECT * FROM ChiTietPhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

                chiTietPhieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                chiTietPhieuNhap.maSanPham = row["maSanPham"].ToString();
                chiTietPhieuNhap.tenSanPham = row["tenSanPham"].ToString();
                chiTietPhieuNhap.donVi = row["donVi"].ToString();
                chiTietPhieuNhap.soLuong = (int)row["soLuong"];
                chiTietPhieuNhap.giaBan = Decimal.Parse(row["giaBan"].ToString());
                chiTietPhieuNhap.giaNhap = Decimal.Parse(row["giaNhap"].ToString());
                chiTietPhieuNhap.tongTien = Decimal.Parse(row["tongTien"].ToString());

                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }

            return listChiTietPhieuNhap;
        }
    }
}

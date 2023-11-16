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
                chiTietPhieuNhap.donViTinh = row["donViTinh"].ToString();
                chiTietPhieuNhap.soLuong = (int)row["soLuong"];
                chiTietPhieuNhap.donGia = Decimal.Parse(row["donGia"].ToString());
                chiTietPhieuNhap.thanhTien = Decimal.Parse(row["thanhTien"].ToString());

                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }

            return listChiTietPhieuNhap;
        }
    }
}

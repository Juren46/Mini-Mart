using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

            string query = $"SELECT * FROM ChiTietHoaDon WHERE maHoaDon = '{maHoaDon}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();

                chiTietHoaDon.maHoaDon = row["maHoaDon"].ToString();
                chiTietHoaDon.maSanPham = row["maSanPham"].ToString();
                chiTietHoaDon.donViTinh = row["donViTinh"].ToString();
                chiTietHoaDon.soLuong = (int)row["soLuong"];
                chiTietHoaDon.donGia = (decimal)row["donGia"];
                chiTietHoaDon.thanhTien = (decimal)row["thanhTien"];

                listChiTietHoaDon.Add(chiTietHoaDon);
            }

            return listChiTietHoaDon;
        }
    }
}

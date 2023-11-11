using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        public HoaDonDAO() { }

        public List<HoaDon> LayDanhSachHoaDon()
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = "SELECT * FROM HoaDon;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                HoaDon hoaDon = new HoaDon();

                hoaDon.maHoaDon = row["maHoaDon"].ToString();
                hoaDon.maNhanVien = row["maNhanVien"].ToString();
                hoaDon.maKhachHang = row["maKhachHang"].ToString();
                hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                hoaDon.giaTriKhuyenMai = Decimal.Parse(row["giaTriKhuyenMai"].ToString());
                hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                listHoaDon.Add(hoaDon);
            }

            return listHoaDon;
        }

        public int DemSoHoaDon()
        {
            string query = $"SELECT COUNT(*) AS SoHoaDon FROM HoaDon;";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoHoaDon"];

            return count;
        }

        public int DemSoHoaDonTheoNgay(DateTime ngay)
        {
            string query = $"SELECT COUNT(*) AS SoHoaDon FROM HoaDon WHERE thoiGianTao = '{ngay}';";

            DataTable dataTable = DBHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoHoaDon"];

            return count;
        }

        public bool ThemHoaDon(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHoaDon)
        {
            int rowsAffected = 0;

            foreach (ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
            {
                string chiTietHoaDonQuery = $"INSERT INTO ChiTietHoaDon (maHoaDon, maSanPham, soLuong, donViTinh, giaBan, thanhTien) " +
                                            $"SELECT '{hoaDon.maHoaDon}' AS maHoaDon, maSanPham, {chiTietHoaDon.soLuong} AS soLuong, donViTinh, giaBan, giaBan * soLuong AS thanhTien " +
                                            $"FROM SanPham WHERE maSanPham = '{chiTietHoaDon.maSanPham}';";
                rowsAffected += DBHelper.ExecuteNonQuery(chiTietHoaDonQuery);
            }

            string hoaDonQuery = $"INSERT INTO HoaDon VALUES('{hoaDon.maHoaDon}', '{hoaDon.maNhanVien}', '{hoaDon.maKhachHang}', '{hoaDon.maKhuyenMai}', '{hoaDon.thoiGianTao}', {hoaDon.tongTien}, {hoaDon.giaTriKhuyenMai}, {hoaDon.thanhTien}, {hoaDon.tienThua}, {hoaDon.tienThua});";

            rowsAffected += DBHelper.ExecuteNonQuery(hoaDonQuery);

            return rowsAffected == listChiTietHoaDon.Count + 1;
        }
    }
}

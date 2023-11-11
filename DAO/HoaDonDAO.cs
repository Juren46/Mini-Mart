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
    }
}

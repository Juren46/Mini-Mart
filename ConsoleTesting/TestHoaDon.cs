using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestHoaDon
    {
        static HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public static void TestLayDanhSachHoaDon()
        {
            List<HoaDon> listHoaDon = hoaDonBUS.LayDanhSachHoaDon();

            foreach (HoaDon hoaDon in listHoaDon)
            {
                Console.WriteLine(hoaDon.maHoaDon + "\n" + hoaDon.maNhanVien + "\n" + hoaDon.maKhachHang + "\n" + hoaDon.thoiGianTao + "\n" + hoaDon.tongTien + "\n" + hoaDon.giaTriKhuyenMai + "\n" + hoaDon.thanhTien + "\n" + hoaDon.tienNhan + "\n" + hoaDon.tienThua + "\n");
            }
        }
    }
}

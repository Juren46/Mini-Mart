using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestChiTietHoaDon
    {
        static ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();

        public static void TestLayDanhSachChiTietHoaDon()
        {
            Console.Write("Nhập mã hóa đơn: ");  //Luôn đúng
            string maHoaDon = Console.ReadLine();

            List<ChiTietHoaDon> listChiTietHoaDon = chiTietHoaDonBUS.LayDanhSachChiTietHoaDon(maHoaDon);

            foreach (ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
                Console.WriteLine(chiTietHoaDon.maHoaDon + "\n" + chiTietHoaDon.maSanPham + "\n" + chiTietHoaDon.soLuong + "\n" + chiTietHoaDon.donViTinh + "\n" + chiTietHoaDon.donGia + "\n" + chiTietHoaDon.thanhTien + "\n");
        }
    }
}

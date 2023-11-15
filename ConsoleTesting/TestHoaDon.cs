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
                Console.WriteLine(hoaDon.maHoaDon + "\n" + hoaDon.maNhanVien + "\n" + hoaDon.maKhachHang + "\n" + hoaDon.thoiGianTao + "\n" + hoaDon.tongTien + "\n" + hoaDon.giamGia + "\n" + hoaDon.thanhTien + "\n" + hoaDon.tienNhan + "\n" + hoaDon.tienThua + "\n");
            }
        }

        public static void TestLayHoaDonTheoMa()
        {
            Console.Write("Nhập mã hóa đơn: ");
            string maHoaDon = Console.ReadLine(); //Luôn đúng

            HoaDon hoaDon = hoaDonBUS.LayHoaDonTheoMa(maHoaDon);
                
            Console.WriteLine(hoaDon.maHoaDon + "\n" + hoaDon.maNhanVien + "\n" + hoaDon.maKhachHang + "\n" + hoaDon.thoiGianTao + "\n" + hoaDon.tongTien + "\n" + hoaDon.giamGia + "\n" + hoaDon.thanhTien + "\n" + hoaDon.tienNhan + "\n" + hoaDon.tienThua + "\n");
        }

        public static void TestLayDanhSachHoaDonTheoNgay()
        {
            Console.Write("Nhập ngày: ");
            string ngay = Console.ReadLine(); //dd/MM/yyyy

            List<HoaDon> listHoaDon = hoaDonBUS.LayDanhSachHoaDonTheoNgay(ngay);

            foreach (HoaDon hoaDon in listHoaDon)
            {
                Console.WriteLine(hoaDon.maHoaDon + "\n" + hoaDon.maNhanVien + "\n" + hoaDon.maKhachHang + "\n" + hoaDon.thoiGianTao + "\n" + hoaDon.tongTien + "\n" + hoaDon.giamGia + "\n" + hoaDon.thanhTien + "\n" + hoaDon.tienNhan + "\n" + hoaDon.tienThua + "\n");
            }
        }

        public static void TestLayDanhSachHoaDonTheoKhoangThoiGian()
        {
            Console.Write("Nhập ngày trước: ");
            string strNgayTruoc = Console.ReadLine(); //dd/MM/yyyy
            Console.Write("Nhập ngày sau: ");
            string strNgaySau = Console.ReadLine(); //dd/MM/yyyy

            List<HoaDon> listHoaDon = hoaDonBUS.LayDanhSachHoaDonTheoKhoangThoiGian(strNgayTruoc, strNgaySau);

            foreach (HoaDon hoaDon in listHoaDon)
            {
                Console.WriteLine(hoaDon.maHoaDon + "\n" + hoaDon.maNhanVien + "\n" + hoaDon.maKhachHang + "\n" + hoaDon.thoiGianTao + "\n" + hoaDon.tongTien + "\n" + hoaDon.giamGia + "\n" + hoaDon.thanhTien + "\n" + hoaDon.tienNhan + "\n" + hoaDon.tienThua + "\n");
            }
        }

        public static void TestThemHoaDon()
        {
            Console.Write("Nhập mã nhân viên: ");
            string maNhanVien = Console.ReadLine();     //Luôn đúng

            Console.Write("Nhập số lượng chi tiết hóa đơn: ");
            int soLuongCTHD = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();
            for (int i = 0; i < soLuongCTHD; i++)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();

                Console.WriteLine("Chi tiết hóa đơn #" + i);
                
                Console.Write("Nhập mã sản phẩm: ");
                chiTietHoaDon.maSanPham = Console.ReadLine();
                SanPham sanPham = new SanPhamBUS().LaySanPhamTheoMa(chiTietHoaDon.maSanPham);
                Console.Write("Nhập số lượng: ");
                chiTietHoaDon.soLuong = int.Parse(Console.ReadLine());
                chiTietHoaDon.donGia = sanPham.giaBan;
                chiTietHoaDon.thanhTien = (decimal)(chiTietHoaDon.donGia * chiTietHoaDon.soLuong);

                listChiTietHoaDon.Add(chiTietHoaDon);
                Console.WriteLine();
            }

            decimal tongTien = 0;
            foreach (ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
                tongTien += chiTietHoaDon.thanhTien;
            Console.WriteLine("Tổng tiền: " + tongTien + "\n");

            bool apKhuyenMai = false;
            string maKhuyenMai = "";
            decimal giamGia = 0;
            Console.Write("Muốn áp khuyến mãi không? y/n: ");
            if (Console.ReadLine() == "y")
            {
                apKhuyenMai = true;
                Console.Write("Nhập mã khuyến mãi: ");  
                maKhuyenMai = Console.ReadLine();

                giamGia = new KhuyenMaiBUS().ApDungKhuyenMai(maKhuyenMai, tongTien.ToString());
                Console.WriteLine("Giá trị khuyến mãi: " + giamGia + "\n");
            }

            string maKhachHang = "";
            Console.Write("Có thành viên không? y/n: ");
            if (Console.ReadLine() == "y")
            {
                Console.Write("Nhập mã khách hàng: ");   //Luôn đúng
                maKhachHang = Console.ReadLine();

                Console.WriteLine("Tích được: " + new KhachHangBUS().TichDiem(maKhachHang, tongTien.ToString()) + " điểm\n");

                if (apKhuyenMai == false)
                {
                    giamGia = new KhachHangBUS().GiamGiaThanhVien(maKhachHang, tongTien.ToString());
                    Console.WriteLine("Giảm giá thành viên: " + giamGia + "\n");
                }
                else
                    Console.WriteLine("Đã áp khuyến mãi, không giảm giá thành viên!");
            }

            decimal thanhTien = tongTien - giamGia;
            Console.WriteLine("Thành tiền: " +  thanhTien + "\n");
            Console.Write("Nhập số tiền nhận: ");
            decimal tienNhan = decimal.Parse(Console.ReadLine());
            decimal tienThua = tienNhan - thanhTien;
            Console.WriteLine("Tiền thừa: " + tienThua + "\n");

            Console.WriteLine(hoaDonBUS.ThemHoaDon(listChiTietHoaDon, maNhanVien, maKhachHang, maKhuyenMai, tongTien.ToString(), giamGia.ToString(), thanhTien.ToString(), tienNhan.ToString(), tienThua.ToString()));

        }
    }
}

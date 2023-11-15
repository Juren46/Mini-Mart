using BUS;
using BUS.OtherFunctions;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestKhachHang
    {
        static KhachHangBUS khachHangBUS = new KhachHangBUS();
        public static void TestLayDanhSachKhachHang()
        {
            List<KhachHang> listKhachHang = khachHangBUS.LayDanhSachKhachHang();

            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" +  khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLayKhachHangTheoMa()
        {
            Console.Write("Nhập mã khách hàng: ");       //Luôn đúng

            string maKhachHang = Console.ReadLine();

            KhachHang khachHang = khachHangBUS.LayKhachHangTheoMa(maKhachHang);

            Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemTichLuy + "\n");
        }

        public static void TestLayKhachHangTheoSoDienThoai()
        {
            Console.Write("Nhập số điện thoại: ");       //Luôn đúng

            string soDienThoai = Console.ReadLine();

            KhachHang khachHang = khachHangBUS.LayKhachHangTheoSoDienThoai(soDienThoai);

            Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemTichLuy + "\n");
        }

        public static void TestThemKhachHang()
        {          
            string maKhachHang = IDGenerator.GenerateKhachHangID();
            Console.Write("Nhập tên khách hàng: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");          //Nam hoặc Nữ
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");           //dd/MM/yyyy
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhập email: ");
            string email = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(khachHangBUS.ThemKhachHang(maKhachHang, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestSuaKhachHang()
        {
            Console.Write("Nhập mã khách hàng: ");       //Luôn đúng
            string maKhachHang = Console.ReadLine();
            Console.Write("Nhập tên khách hàng: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");          //Nam hoặc Nữ
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");           //dd/MM/yyyy
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhập email: ");
            string email = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(khachHangBUS.SuaKhachHang(maKhachHang, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestTimKiemKhachHang()
        {
            Console.Write("Nhập từ khóa: ");
            string keyword = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.TimKiemKhachHang(keyword);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n"  + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLocKhachHangTheoGioiTinh()
        {
            Console.Write("Nhập giới tính: ");     //Nam hoặc Nữ
            string gioiTinh = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.LocKhachHangTheoGioiTinh(gioiTinh);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLocKhachHangTheoBacThanhVien()
        {
            Console.Write("Nhập bậc thành viên: ");     //Luôn đúng
            string bacThanhVien = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.LocKhachHangTheoBacThanhVien(bacThanhVien);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestTichDiem()
        {
            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();
            Console.Write("Nhập tổng tiền: ");
            string tongTien = Console.ReadLine();
            Console.WriteLine(khachHangBUS.TichDiem(maKhachHang, tongTien));
        }

        public static void TestGiamGiaThanhVien()
        {
            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();
            Console.Write("Nhập điểm muốn đổi: ");
            string diemMuonDoi = Console.ReadLine();
            Console.Write("Nhập tổng tiền: ");
            string tongTien = Console.ReadLine();
            Console.WriteLine(khachHangBUS.GiamGiaThanhVien(maKhachHang, tongTien));
        }
    }
}

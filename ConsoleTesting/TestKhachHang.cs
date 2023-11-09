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
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLayKhachHangTheoMa()
        {
            Console.Write("Nhập mã khách hàng: ");       //Chọn khách hàng từ GUI nên phải luôn đúng

            string maKhachHang = Console.ReadLine();

            KhachHang khachHang = khachHangBUS.LayKhachHangTheoMa(maKhachHang);

            Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
        }

        public static void TestLayKhachHangTheoSoDienThoai()
        {
            Console.Write("Nhập số điện thoại: ");       //Chọn khách hàng từ GUI nên phải luôn đúng

            string soDienThoai = Console.ReadLine();

            KhachHang khachHang = khachHangBUS.LayKhachHangTheoSoDienThoai(soDienThoai);

            Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
        }

        public static void TestThemKhachHang()
        {          
            string maKhachHang = IDGenerator.GenerateKhachHangID();
            Console.Write("Nhap ten khach hang: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");          //Chọn bằng GUI nên luôn là "Nữ" hoặc "Nam"
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");           //Ngày sinh chọn bằng tool trong GUI nên phải luôn đúng định dạng là dd/MM/yyyy
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(khachHangBUS.ThemKhachHang(maKhachHang, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestSuaKhachHang()
        {
            Console.Write("Nhap ma khach hang: ");       //Chọn từ GUI nên luôn đúng
            string maKhachHang = Console.ReadLine();
            Console.Write("Nhap ten khach hang: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");          //Chọn bằng GUI nên luôn là "Nữ" hoặc "Nam"
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");           //Ngày sinh chọn bằng tool trong GUI nên phải luôn đúng định dạng là dd/MM/yyyy
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(khachHangBUS.SuaKhachHang(maKhachHang, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestTimKiemKhachHang()
        {
            Console.Write("Nhập keyword: ");
            string keyword = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.TimKiemKhachHang(keyword);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLocKhachHangTheoGioiTinh()
        {
            Console.Write("Nhập giới tính: ");     //Chọn từ GUI nên luôn đúng
            string gioiTinh = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.LocKhachHangTheoGioiTinh(gioiTinh);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }

        public static void TestLocKhachHangTheoBacThanhVien()
        {
            Console.Write("Nhập bậc thành viên: ");     //Chọn từ GUI nên luôn đúng
            string bacThanhVien = Console.ReadLine();
            List<KhachHang> listKhachHang = khachHangBUS.LocKhachHangTheoBacThanhVien(bacThanhVien);
            foreach (KhachHang khachHang in listKhachHang)
            {
                Console.WriteLine(khachHang.maKhachHang + "\n" + khachHang.hoTen + "\n" + khachHang.gioiTinh + "\n" + khachHang.ngaySinh + "\n" + khachHang.soDienThoai + "\n" + khachHang.email + "\n" + khachHang.diaChi + "\n" + khachHang.bacThanhVien + "\n" + khachHang.diemThanhVien + "\n" + khachHang.diemTichLuy + "\n");
            }
        }
    }
}

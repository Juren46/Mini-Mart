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
    internal class TestNhanVien
    {
        static NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public static void TestLayDanhSachNhanVien()
        {
            List<NhanVien> listNhanVien = nhanVienBUS.LayDanhSachNhanVien();

            foreach (NhanVien nhanVien in listNhanVien)
            {
                Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
            }
        }

        public static void TestThemNhanVien()
        {
            Console.Write("Nhap ten tai khoan: ");       //Tên tài khoản chọn bằng giao diện trong GUI nên phải luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTenTaiKhoan(tenTaiKhoan);
            string maNhanVien = IDGenerator.GenerateNhanVienID(phanQuyen.tenPhanQuyen);
            Console.Write("Nhap ten nhan vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");           //Ngày sinh chọn bằng tool trong GUI nên phải luôn đúng định dạng là dd/MM/yyyy
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(nhanVienBUS.ThemNhanVien(maNhanVien, tenTaiKhoan, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }
    }
}

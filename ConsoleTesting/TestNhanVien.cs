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

        public static void TestLayNhanVienTheoMa()
        {
            Console.Write("Nhập mã nhân viên: ");       //Chọn nhân viên từ GUI nên phải luôn đúng

            string maNhanVien = Console.ReadLine();

            NhanVien nhanVien = nhanVienBUS.LayNhanVienTheoMa(maNhanVien);
                
            Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
        }

        public static void TestLayNhanVienTheoTenTaiKhoan()
        {
            Console.Write("Nhập tên tài khoản: ");       //Chọn từ GUI nên phải luôn đúng

            string tenTaiKhoan = Console.ReadLine();

            NhanVien nhanVien = nhanVienBUS.LayNhanVienTheoTenTaiKhoan(tenTaiKhoan);

            Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
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
            Console.WriteLine(nhanVienBUS.ThemNhanVien(maNhanVien, tenTaiKhoan, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestXoaNhanVien()
        {
            Console.Write("Nhập mã nhân viên: ");
            string maNhanVien = Console.ReadLine();     //Chọn từ GUI nên luôn đúng
            Console.WriteLine(nhanVienBUS.XoaNhanVien(maNhanVien));
        }

        public static void TestSuaNhanVien()
        {
            Console.Write("Nhap ma nhan vien: ");       //Chọn từ GUI nên luôn đúng
            string maNhanVien = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
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
            Console.WriteLine(nhanVienBUS.SuaNhanVien(maNhanVien, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        public static void TestTimKiemNhanVien()
        {
            Console.Write("Nhập keyword: ");
            string keyword = Console.ReadLine();
            List<NhanVien> listNhanVien = nhanVienBUS.TimKiemNhanVien(keyword);
            foreach (NhanVien nhanVien in listNhanVien)
            {
                Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
            }
        }

        public static void TestLocNhanVienTheoPhanQuyen()
        {
            Console.Write("Nhập tên phân quyền: ");     //Chọn từ GUI nên luôn đúng
            string tenPhanQuyen = Console.ReadLine();
            List<NhanVien> listNhanVien = nhanVienBUS.LocNhanVienTheoPhanQuyen(tenPhanQuyen);
            foreach (NhanVien nhanVien in listNhanVien)
            {
                Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
            }
        }

        public static void TestLocNhanVienTheoGioiTinh()
        {
            Console.Write("Nhập giới tính: ");     //Chọn từ GUI nên luôn đúng
            string gioiTinh = Console.ReadLine();
            List<NhanVien> listNhanVien = nhanVienBUS.LocNhanVienTheoGioiTinh(gioiTinh);
            foreach (NhanVien nhanVien in listNhanVien)
            {
                Console.WriteLine(nhanVien.maNhanVien + "\n" + nhanVien.tenTaiKhoan + "\n" + nhanVien.hoTen + "\n" + nhanVien.gioiTinh + "\n" + nhanVien.ngaySinh + "\n" + nhanVien.soDienThoai + "\n" + nhanVien.email + "\n" + nhanVien.diaChi + "\n" + nhanVien.trangThai + "\n");
            }
        }
    }
}

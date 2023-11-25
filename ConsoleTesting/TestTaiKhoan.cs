using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestTaiKhoan
    {
        static TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public static void TestLayDanhSachTaiKhoan()
        {
            List<TaiKhoan> listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();

            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n" + taiKhoan.trangThai + "\n");
            }
        }

        public static void TestLayTaiKhoanTheoTen()
        {
            Console.Write("Nhập tên tài khoản: ");  //Luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            TaiKhoan taiKhoan = taiKhoanBUS.LayTaiKhoanTheoTen(tenTaiKhoan);
            Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n" + taiKhoan.trangThai + "\n");
        }

        public static void TestKiemTraDangNhap()
        {
            Console.Write("Nhập tên tài khoản: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhập mật khẩu: ");
            string matKhau = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.KiemTraDangNhap(tenTaiKhoan, matKhau));
        }

        public static void TestThemTaiKhoan()
        {
            Console.Write("Nhập tên phân quyền: ");     //Luôn đúng
            string tenPhanQuyen = Console.ReadLine();    
            Console.Write("Nhập tên tài khoản: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhập mật khẩu: ");
            string matKhau = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.ThemTaiKhoan(tenPhanQuyen, tenTaiKhoan, matKhau));
        }

        public static void TestDoiMatKhau()
        {
            Console.Write("Nhập tên tài khoản: ");
            string tenTaiKhoan = Console.ReadLine();    //Luôn đúng
            Console.Write("Nhập mật khẩu cũ: ");
            string matKhauCu = Console.ReadLine();
            Console.Write("Nhập mật khẩu mới: ");
            string matKhauMoi = Console.ReadLine();
            Console.Write("Xác nhận mật khẩu mới: ");
            string xacNhanMatKhauMoi = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.DoiMatKhau(tenTaiKhoan, matKhauCu, matKhauMoi, xacNhanMatKhauMoi));
        }

        public static void TestXoaTaiKhoan()
        {
            Console.Write("Nhập tên tài khoản: ");      //Luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.XoaTaiKhoan(tenTaiKhoan));
        }


        public static void TestLocTaiKhoanTheoPhanQuyen()
        {
            Console.Write("Nhập tên phân quyền: ");      //Luôn đúng
            string tenPhanQuyen = Console.ReadLine();
            List<TaiKhoan> listTaiKhoan = taiKhoanBUS.LocTaiKhoanTheoPhanQuyen(tenPhanQuyen);
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n" + taiKhoan.trangThai+ "\n");
            }
        }

        public static void TestLayDanhSachTaiKhoanChuaDung()
        {
            List<TaiKhoan> listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoanChuaDung();
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n" + taiKhoan.trangThai + "\n");
            }
        }
    }
}

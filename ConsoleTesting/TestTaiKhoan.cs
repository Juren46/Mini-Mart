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
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n");
            }
        }

        public static void TestLayTaiKhoanTheoTen()
        {
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            TaiKhoan taiKhoan = taiKhoanBUS.LayTaiKhoanTheoTen(tenTaiKhoan);
            Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n");
        }

        public static void TestKiemTraDangNhap()
        {
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            string matKhau = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.KiemTraDangNhap(tenTaiKhoan, matKhau));
        }

        public static void TestThemTaiKhoan()
        {
            Console.Write("Nhap ten phan quyen: ");
            string tenPhanQuyen = Console.ReadLine();    //Tên phân quyền chọn bằng combobox trong GUI nên phải luôn đúng
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            string matKhau = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.ThemTaiKhoan(tenPhanQuyen, tenTaiKhoan, matKhau));
        }

        public static void TestDoiMatKhau()
        {
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();    //Admin đổi mật khẩu hoặc người dùng có thể tự đổi mật khẩu nên trong GUI tên tài khoản phải luôn đúng
            Console.Write("Nhap mat khau cu: ");
            string matKhauCu = Console.ReadLine();
            Console.Write("Nhap mat khau moi: ");
            string matKhauMoi = Console.ReadLine();
            Console.Write("Xac nhan mat khau moi: ");
            string xacNhanMatKhauMoi = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.DoiMatKhau(tenTaiKhoan, matKhauCu, matKhauMoi, xacNhanMatKhauMoi));
        }

        public static void TestKhoaTaiKhoan()
        {
            Console.Write("Nhap ten tai khoan: ");      //Admin khóa tài khoản chọn trong GUI nên tên tài khoản phải luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.KhoaTaiKhoan(tenTaiKhoan));
            TestKiemTraDangNhap();
        }

        public static void TestMoKhoaTaiKhoan()
        {
            Console.Write("Nhap ten tai khoan: ");      //Admin khóa tài khoản chọn trong GUI nên tên tài khoản phải luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.MoKhoaTaiKhoan(tenTaiKhoan));
            TestKiemTraDangNhap();
        }

        public static void TestTimKiemTaiKhoan()
        {
            string keyword = Console.ReadLine();
            List<TaiKhoan> listTaiKhoan = taiKhoanBUS.TimKiemTaiKhoan(keyword);
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n");
            }
        }

        public static void TestLocTaiKhoanTheoPhanQuyen()
        {
            Console.Write("Nhap ten phan quyen: ");      //Tên phân quyền chọn bằng combobox trong GUI nên phải luôn 
            string tenPhanQuyen = Console.ReadLine();
            List<TaiKhoan> listTaiKhoan = taiKhoanBUS.LocTaiKhoanTheoPhanQuyen(tenPhanQuyen);
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                Console.WriteLine(taiKhoan.maPhanQuyen + "\n" + taiKhoan.tenTaiKhoan + "\n" + taiKhoan.matKhau + "\n");
            }
        }
    }
}

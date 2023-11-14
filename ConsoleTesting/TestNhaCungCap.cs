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
    internal class TestNhaCungCap
    {
        static NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

        public static void TestLayDanhSachNhaCungCap()
        {
            List<NhaCungCap> listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();

            foreach (NhaCungCap nhaCungCap in listNhaCungCap)
            {
                Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
            }
        }

        public static void TestLayNhaCungCapTheoMa()
        {
            Console.Write("Nhập mã nhà cung cấp: ");      //Luôn đúng
            string maNhaCungCap = Console.ReadLine();
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(maNhaCungCap);
            Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
        }

        public static void TestThemNhaCungCap()
        {
            string maNhaCungCap = IDGenerator.GenerateNhaCungCapID();
            Console.Write("Nhập tên nhà cung cấp: ");
            string tenNhaCungCap = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhập email: ");
            string email = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(nhaCungCapBUS.ThemNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi));
        }

        public static void TestSuaNhaCungCap()
        {
            Console.Write("Nhập mã nhà cung cấp: ");
            string maNhaCungCap = Console.ReadLine();     //Luôn đúng
            Console.Write("Nhập tên nhà cung cấp: ");
            string tenNhaCungCap = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhập email: ");
            string email = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(nhaCungCapBUS.SuaNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi));
        }

        public static void TestTimKiemNhaCungCap()
        {
            Console.Write("Nhập từ khóa: ");
            string keyword = Console.ReadLine();
            List<NhaCungCap> listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(keyword);
            foreach (NhaCungCap nhaCungCap in listNhaCungCap)
            {
                Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
            }
        }
    }
}

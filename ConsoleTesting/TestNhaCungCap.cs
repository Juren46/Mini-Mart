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
            Console.Write("Nhập mã nhà cung cấp: ");      //Phải luôn đúng
            string maNhaCungCap = Console.ReadLine();
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(maNhaCungCap);
            Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
        }

        public static void TestLayNhaCungCapTheoTen()
        {
            Console.Write("Nhập tên nhà cung cấp: ");      //Phải luôn đúng
            string tenNhaCungCap = Console.ReadLine();
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoTen(tenNhaCungCap);
            Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
        }

        public static void TestThemNhaCungCap()
        {
            string maNhaCungCap = IDGenerator.GenerateNhaCungCapID();
            Console.Write("Nhap ten nha cung cap: ");
            string tenNhaCungCap = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(nhaCungCapBUS.ThemNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi));
        }

        public static void TestSuaNhaCungCap()
        {
            Console.Write("Nhap ma nha cung cap: ");
            string maNhaCungCap = Console.ReadLine();       //Luôn đúng
            Console.Write("Nhap ten nha cung cap: ");
            string tenNhaCungCap = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine(nhaCungCapBUS.SuaNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi));
        }

        public static void TestTimKiemNhaCungCap()
        {
            Console.Write("Nhap keyword: ");
            string keyword = Console.ReadLine();
            List<NhaCungCap> listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(keyword);
            foreach (NhaCungCap nhaCungCap in listNhaCungCap)
            {
                Console.WriteLine(nhaCungCap.maNhaCungCap + "\n" + nhaCungCap.tenNhaCungCap + "\n" + nhaCungCap.soDienThoai + "\n" + nhaCungCap.email + "\n" + nhaCungCap.diaChi + "\n");
            }
        }
    }
}

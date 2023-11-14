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
    internal class TestLoaiSanPham
    {
        static LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();

        public static void TestLayDanhSachLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = loaiSanPhamBUS.LayDanhSachLoaiSanPham();

            foreach (LoaiSanPham loaiSanPham in listLoaiSanPham)
            {
                Console.WriteLine(loaiSanPham.maLoaiSanPham + "\n" + loaiSanPham.tenLoaiSanPham + "\n");
            }
        }

        public static void TestLayLoaiSanPhamTheoMa()
        {
            Console.Write("Nhập mã loại sản phẩm: ");      //Luôn đúng
            string maLoaiSanPham = Console.ReadLine();
            LoaiSanPham loaiSanPham = loaiSanPhamBUS.LayLoaiSanPhamTheoMa(maLoaiSanPham);
            Console.WriteLine(loaiSanPham.maLoaiSanPham + "\n" + loaiSanPham.tenLoaiSanPham);
        }

        public static void TestLayLoaiSanPhamTheoTen()
        {
            Console.Write("Nhập tên loại sản phẩm: ");      //Luôn đúng
            string tenLoaiSanPham = Console.ReadLine();
            LoaiSanPham loaiSanPham = loaiSanPhamBUS.LayLoaiSanPhamTheoTen(tenLoaiSanPham);
            Console.WriteLine(loaiSanPham.maLoaiSanPham + "\n" + loaiSanPham.tenLoaiSanPham);
        }

        public static void TestThemLoaiSanPham()
        {
            string maLoaiSanPham = IDGenerator.GenerateLoaiSanPhamID();
            Console.Write("Nhập tên loại sản phẩm: ");
            string tenLoaiSanPham = Console.ReadLine();
            Console.WriteLine(loaiSanPhamBUS.ThemLoaiSanPham(maLoaiSanPham, tenLoaiSanPham));
        }

        public static void TestXoaLoaiSanPham()
        {
            Console.Write("Nhập mã loại sản phẩm: ");
            string maLoaiSanPham = Console.ReadLine();
            Console.WriteLine(loaiSanPhamBUS.XoaLoaiSanPham(maLoaiSanPham));
        }

        public static void TestSuaLoaiSanPham()
        {
            Console.Write("Nhập mã loại sản phẩm: ");       //Luôn đúng
            string maLoaiSanPham = Console.ReadLine();
            Console.Write("Nhập tên loại sản phẩm: ");
            string tenLoaiSanPham = Console.ReadLine();
            Console.WriteLine(loaiSanPhamBUS.SuaLoaiSanPham(maLoaiSanPham, tenLoaiSanPham));
        }

        public static void TestTimKiemLoaiSanPham()
        {
            Console.Write("Nhập từ khóa: ");     
            string keyword = Console.ReadLine();
            List<LoaiSanPham> listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham(keyword);
            foreach (LoaiSanPham loaiSanPham in listLoaiSanPham)
            {
                Console.WriteLine(loaiSanPham.maLoaiSanPham + "\n" + loaiSanPham.tenLoaiSanPham + "\n");
            }
        }
    }
}

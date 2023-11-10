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
    internal class TestSanPham
    {
        static SanPhamBUS sanPhamBUS = new SanPhamBUS();

        public static void TestLayDanhSachSanPham()
        {
            List<SanPham> listSanPham = sanPhamBUS.LayDanhSachSanPham();

            foreach (SanPham sanPham in listSanPham)
            {
                Console.WriteLine(sanPham.maSanPham + "\n" + sanPham.maLoaiSanPham + "\n" + sanPham.maNhaCungCap + "\n" + sanPham.tenSanPham + "\n" + sanPham.donViTinh + "\n" + sanPham.soLuong + "\n" + sanPham.giaBan + "\n" + sanPham.duongDanAnh + "\n" + sanPham.maLoaiSanPham + "\n" + sanPham.trangThai + "\n");
            }
        }

        public static void TestLaySanPhamTheoMa()
        {
            Console.Write("Nhập mã sản phẩm: ");
            string maSanPham = Console.ReadLine();      //Luôn đúng
            SanPham sanPham = sanPhamBUS.LaySanPhamTheoMa(maSanPham);
            Console.WriteLine(sanPham.maSanPham + "\n" + sanPham.maLoaiSanPham + "\n" + sanPham.maNhaCungCap + "\n" + sanPham.tenSanPham + "\n" + sanPham.donViTinh + "\n" + sanPham.soLuong + "\n" + sanPham.giaBan + "\n" + sanPham.duongDanAnh + "\n" + sanPham.maLoaiSanPham + "\n" + sanPham.trangThai + "\n");
        }

        public static void TestThemSanPham()
        {
            string maSanPham = IDGenerator.GenerateSanPhamID();
            Console.Write("Nhap ma loai san pham: ");       
            string maLoaiSanPham = Console.ReadLine();      //Luôn đúng
            Console.Write("Nhap ma nha cung cap: ");
            string maNhaCungCap = Console.ReadLine();         //Luôn đúng
            Console.Write("Nhap ten san pham: ");
            string tenSanPham = Console.ReadLine();
            Console.Write("Nhap don vi tinh: ");
            string donViTinh = Console.ReadLine(); 
            Console.Write("Nhap gia ban: ");       
            string giaBan = Console.ReadLine();
            Console.Write("Nhap duong dan anh: ");          
            string duongDanAnh = Console.ReadLine();           //Luôn đúng
            Console.WriteLine(sanPhamBUS.ThemSanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, giaBan, duongDanAnh));
        }

        public static void TestXoaSanPham()
        {
            Console.Write("Nhập mã sản phẩm: ");
            string maSanPham = Console.ReadLine();      //Luôn đúng
            Console.WriteLine(sanPhamBUS.XoaSanPham(maSanPham));
        }
    }
}

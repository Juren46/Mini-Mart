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
    internal class TestKhuyenMai
    {
        static KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

        public static void TestLayDanhSachKhuyenMai()
        {
            List<KhuyenMai> listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();

            foreach (KhuyenMai khuyenMai in listKhuyenMai)
            {
                Console.WriteLine(khuyenMai.maKhuyenMai + "\n" + khuyenMai.maQuanLi + "\n" + khuyenMai.tenKhuyenMai + "\n" + khuyenMai.thoiGianBatDau + "\n" + khuyenMai.thoiGianKetThuc + "\n" + khuyenMai.loaiGiaTri + "\n" + khuyenMai.giaTriApDung + "\n");
            }
        }

        public static void TestLayKhuyenMaiTheoMa()
        {
            Console.Write("Nhập mã khuyến mãi: ");      //luôn đúng
            string maKhuyenMai = Console.ReadLine();
            KhuyenMai khuyenMai = khuyenMaiBUS.LayKhuyenMaiTheoMa(maKhuyenMai);
            Console.WriteLine(khuyenMai.maKhuyenMai + "\n" + khuyenMai.maQuanLi + "\n" + khuyenMai.tenKhuyenMai + "\n" + khuyenMai.thoiGianBatDau + "\n" + khuyenMai.thoiGianKetThuc + "\n" + khuyenMai.loaiGiaTri + "\n" + khuyenMai.giaTriApDung + "\n");
        }

        public static void TestThemKhuyenMai()
        {
            string maKhuyenMai = IDGenerator.GenerateKhuyenMaiID();
            Console.Write("Nhập mã quản lí: ");
            string maQuanLi = Console.ReadLine();       //Luôn đúng
            Console.Write("Nhập tên khuyến mãi: ");
            string tenKhuyenMai = Console.ReadLine();
            Console.Write("Nhập thời gian bắt đầu: ");
            string thoiGianBatDau = Console.ReadLine();
            Console.Write("Nhập thời gian kết thúc: ");
            string thoiGianKetThuc = Console.ReadLine();        //Luôn đúng
            Console.Write("Nhập loại giá trị: ");
            string loaiGiaTri = Console.ReadLine();
            Console.Write("Nhập giá trị áp dụng: ");
            string giaTriApDung = Console.ReadLine();
            Console.WriteLine(khuyenMaiBUS.ThemKhuyenMai(maKhuyenMai, maQuanLi, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung));
        }

        public static void TestXoaKhuyenMai()
        {
            Console.Write("Nhập mã khuyến mãi: ");      //luôn đúng
            string maKhuyenMai = Console.ReadLine();
            Console.WriteLine(khuyenMaiBUS.XoaKhuyenMai(maKhuyenMai));
        }

        public static void TestSuaKhuyenMai()
        {
            Console.Write("Nhập mã khuyến mãi: ");
            string maKhuyenMai = Console.ReadLine();       //Luôn đúng
            Console.Write("Nhập tên khuyến mãi: ");
            string tenKhuyenMai = Console.ReadLine();
            Console.Write("Nhập thời gian bắt đầu: ");
            string thoiGianBatDau = Console.ReadLine();     //Luôn đúng
            Console.Write("Nhập thời gian kết thúc: "); 
            string thoiGianKetThuc = Console.ReadLine();        //Luôn đúng
            Console.Write("Nhập loại giá trị: ");
            string loaiGiaTri = Console.ReadLine();
            Console.Write("Nhập giá trị áp dụng: ");
            string giaTriApDung = Console.ReadLine();
            Console.WriteLine(khuyenMaiBUS.SuaKhuyenMai(maKhuyenMai, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung));
        }

        public static void TestTimKiemKhuyenMai()
        {
            Console.Write("Nhap keyword: ");
            string keyword = Console.ReadLine();
            List<KhuyenMai> listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai(keyword);
            foreach (KhuyenMai khuyenMai in listKhuyenMai)
            {
                Console.WriteLine(khuyenMai.maKhuyenMai + "\n" + khuyenMai.maQuanLi + "\n" + khuyenMai.tenKhuyenMai + "\n" + khuyenMai.thoiGianBatDau + "\n" + khuyenMai.thoiGianKetThuc + "\n" + khuyenMai.loaiGiaTri + "\n" + khuyenMai.giaTriApDung + "\n");
            }
        }

        public static void TestTimKiemKhuyenMaiTheoKhoangThoiGian()
        {
            Console.Write("Nhap thoi gian bat dau: ");
            string thoiGianBatDau = Console.ReadLine();
            Console.Write("Nhap thoi gian ket thuc: ");
            string thoiGianKetThuc = Console.ReadLine();
            List<KhuyenMai> listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMaiTheoKhoangThoiGian(thoiGianBatDau, thoiGianKetThuc);
            foreach (KhuyenMai khuyenMai in listKhuyenMai)
            {
                Console.WriteLine(khuyenMai.maKhuyenMai + "\n" + khuyenMai.maQuanLi + "\n" + khuyenMai.tenKhuyenMai + "\n" + khuyenMai.thoiGianBatDau + "\n" + khuyenMai.thoiGianKetThuc + "\n" + khuyenMai.loaiGiaTri + "\n" + khuyenMai.giaTriApDung + "\n");
            }
        }

        public static void TestApDungKhuyenMai()
        {
            Console.Write("Nhập mã khuyến mãi: ");
            string maKhuyenMai = Console.ReadLine();    //Luôn đúng
            Console.Write("Nhập đơn giá: ");
            string donGia = Console.ReadLine();     //decimal
            Console.WriteLine(khuyenMaiBUS.ApDungKhuyenMai(maKhuyenMai, donGia));
        }
    }
}

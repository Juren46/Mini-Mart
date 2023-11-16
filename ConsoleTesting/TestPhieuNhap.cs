using BUS;
using BUS.OtherFunctions;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestPhieuNhap
    {
        static PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();

        public static void TestThemPhieuNhap()
        {
            string maPhieuNhap = IDGenerator.GeneratePhieuNhapID();

            Console.Write( "Nhập mã nhà cung cấp: ");   //Luôn đúng
            string maNhaCungCap = Console.ReadLine();

            Console.Write("Nhập mã nhân viên: "); //Luôn đúng
            string maNhanVien = Console.ReadLine();

            Console.Write("Nhập số chi tiết phiếu nhập: ");
            int soChiTietPhieuNhap = int.Parse(Console.ReadLine());

            decimal decimalThanhTien = 0;

            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            
            for(int i = 0; i < soChiTietPhieuNhap; i++)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

                Console.WriteLine("Chi tiết phiếu nhập #" + i);

                chiTietPhieuNhap.maPhieuNhap = maPhieuNhap;

                Console.Write("Nhập mã sản phẩm: ");
                chiTietPhieuNhap.maSanPham = Console.ReadLine();

                Console.Write("Nhập số lượng: ");
                chiTietPhieuNhap.soLuong = int.Parse(Console.ReadLine());

                Console.Write("Nhập đơn giá: ");
                chiTietPhieuNhap.donGia = decimal.Parse(Console.ReadLine());

                chiTietPhieuNhap.thanhTien = (decimal)(chiTietPhieuNhap.donGia * chiTietPhieuNhap.soLuong);
                Console.WriteLine("Chi tiết phiếu nhập thành tiền: " + chiTietPhieuNhap.thanhTien);

                decimalThanhTien += chiTietPhieuNhap.thanhTien;

                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
                Console.WriteLine();
            }

            Console.WriteLine("Thành tiền: " + decimalThanhTien + "\n");

            Console.WriteLine(phieuNhapBUS.ThemPhieuNhap(listChiTietPhieuNhap, maPhieuNhap, maNhaCungCap, maNhanVien, decimalThanhTien.ToString()));
        }

        public static void TestLayPhieuNhapTheoMa()
        {
            Console.Write("Nhập mã phiếu nhập: ");      //Luôn đúng
            string maPhieuNhap = Console.ReadLine();
            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapTheoMa(maPhieuNhap);

            Console.WriteLine(phieuNhap.maPhieuNhap + "\n" + phieuNhap.maNhaCungCap + "\n" + phieuNhap.maNhanVien + "\n" + phieuNhap.maQuanLi + "\n" + phieuNhap.thoiGianTao + "\n" + phieuNhap.thoiGianDuyet + "\n" + phieuNhap.thanhTien + "\n" + phieuNhap.trangThaiDuyet + "\n");
        }

        public static void TestLayDanhSachPhieuNhapChuaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = phieuNhapBUS.LayDanhSachPhieuNhapChuaDuyet();

            if (listPhieuNhap.Count > 0)
            {
                foreach (PhieuNhap phieuNhap in listPhieuNhap)
                {
                    Console.WriteLine(phieuNhap.maPhieuNhap + "\n" + phieuNhap.maNhaCungCap + "\n" + phieuNhap.maNhanVien + "\n" + phieuNhap.maQuanLi + "\n" + phieuNhap.thoiGianTao + "\n" + phieuNhap.thoiGianDuyet + "\n" + phieuNhap.thanhTien + "\n" + phieuNhap.trangThaiDuyet + "\n");
                }
            }
            else
                Console.WriteLine("Không có kết quả!");
        }

        public static void TestLayDanhSachPhieuNhapDaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = phieuNhapBUS.LayDanhSachPhieuNhapDaDuyet();

            if (listPhieuNhap.Count > 0)
            {
                foreach (PhieuNhap phieuNhap in listPhieuNhap)
                {
                    Console.WriteLine(phieuNhap.maPhieuNhap + "\n" + phieuNhap.maNhaCungCap + "\n" + phieuNhap.maNhanVien + "\n" + phieuNhap.maQuanLi + "\n" + phieuNhap.thoiGianTao + "\n" + phieuNhap.thoiGianDuyet + "\n" + phieuNhap.thanhTien + "\n" + phieuNhap.trangThaiDuyet + "\n");
                }
            }
            else
                Console.WriteLine("Không có kết quả!");
        }

        public static void TestSuaPhieuNhapChuaDuyet()
        {
            Console.Write("Nhập mã phiếu nhập: ");  //Luôn đúng
            string maPhieuNhap = Console.ReadLine();

            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapBUS().LayDanhSachChiTietPhieuNhap(maPhieuNhap);

            decimal thanhTien = 0;

            for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
            {
                Console.WriteLine("Chi tiết phiếu nhập #" + i);

                Console.WriteLine("Sản phẩm " + listChiTietPhieuNhap[i].maSanPham);
                Console.WriteLine("Số lượng: " + listChiTietPhieuNhap[i].soLuong);
                Console.Write("Nhập lại: ");
                listChiTietPhieuNhap[i].soLuong = int.Parse(Console.ReadLine());
                Console.WriteLine("Đơn giá: " + listChiTietPhieuNhap[i].donGia);
                Console.Write("Nhập lại: ");
                listChiTietPhieuNhap[i].donGia = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Chi tiết phiếu nhập thành tiền cũ: " + listChiTietPhieuNhap[i].thanhTien);
                listChiTietPhieuNhap[i].thanhTien = (decimal)(listChiTietPhieuNhap[i].donGia * listChiTietPhieuNhap[i].soLuong);
                Console.WriteLine("Chi tiết phiếu nhập thành tiền mới: " + listChiTietPhieuNhap[i].thanhTien);
                thanhTien += listChiTietPhieuNhap[i].thanhTien;
                Console.WriteLine();
            }
            Console.WriteLine("Phiếu nhập thành tiền mới: " + thanhTien);

            Console.WriteLine(phieuNhapBUS.SuaPhieuNhapChuaDuyet(listChiTietPhieuNhap));
        }

        public static void TestDuyetPhieuNhap()
        {
            Console.Write("Nhập mã quản lí: ");  //Luôn đúng
            string maQuanLi = Console.ReadLine();
            Console.Write("Nhập mã phiếu nhập: ");   //Luôn đúng
            string maPhieuNhap = Console.ReadLine();
            Console.WriteLine(phieuNhapBUS.DuyetPhieuNhap(maPhieuNhap, maQuanLi));
        }

        public static void TestTuChoiPhieuNhap()
        {
            Console.Write("Nhập mã phiếu nhập: ");   //Luôn đúng
            string maPhieuNhap = Console.ReadLine();
            Console.WriteLine(phieuNhapBUS.TuChoiPhieuNhap(maPhieuNhap));
        }
    }
}

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

            Console.WriteLine(phieuNhap.maPhieuNhap + "\n" + phieuNhap.maNhaCungCap + "\n" + phieuNhap.maNhanVien + "\n" + phieuNhap.maQuanLi + "\n" + phieuNhap.thoiGianTao + "\n" + phieuNhap.thoiGianDuyet + "\n" + phieuNhap.thanhTien + "\n" + phieuNhap.trangThaiDuyet + "\n" + phieuNhap.trangThai + "\n");
        }
    }
}

using BUS;
using DTO;
using Microsoft.Identity.Client;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestPhanQuyen
    {
        static PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
        public static void TestLayDanhSachPhanQuyen()
        {
            List<PhanQuyen> listPhanQuyen = phanQuyenBUS.LayDanhSachPhanQuyen();

            foreach(PhanQuyen phanQuyen in listPhanQuyen)
            {
                Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
            }
        }

        public static void TestLayPhanQuyenTheoMa()
        {
            string maPhanQuyen = "PQ02";
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoMa(maPhanQuyen);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
        }

        public static void TestLayPhanQuyenTheoTen()
        {
            string tenPhanQuyen = "Nhân viên bán hàng";
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTen(tenPhanQuyen);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
        }

        public static void TestLayPhanQuyenTheoTenTaiKhoan()
        {
            string tenTaiKhoan = "nvbhanh";
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTenTaiKhoan(tenTaiKhoan);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
        }

        public static void TestTimKiemTaiKhoan()
        {          
            string keyword = Console.ReadLine();
            List<PhanQuyen> listPhanQuyen = phanQuyenBUS.TimKiemPhanQuyen(keyword);
            foreach (PhanQuyen phanQuyen in listPhanQuyen)
            {
                Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
            }
        }
    }
}

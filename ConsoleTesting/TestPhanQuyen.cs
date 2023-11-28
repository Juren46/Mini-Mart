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
                Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen + "\n");
            }
        }

        public static void TestLayPhanQuyenTheoMa()
        {
            Console.Write("Nhập mã phân quyền: ");  //Luôn đúng
            string maPhanQuyen = Console.ReadLine();
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoMa(maPhanQuyen);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
        }

        public static void TestLayPhanQuyenTheoTen()
        {
            /*Console.Write("Nhập tên phân quyền: ");  //Luôn đúng
            string tenPhanQuyen = Console.ReadLine();
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTen(tenPhanQuyen);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);*/
        }

        public static void TestLayPhanQuyenTheoTenTaiKhoan()
        {
            Console.Write("Nhập tên tài khoản: ");  //Luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTenTaiKhoan(tenTaiKhoan);
            Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen);
        }

        public static void TestTimKiemPhanQuyen()
        {
            Console.Write("Nhập từ khóa: ");
            string keyword = Console.ReadLine();
            List<PhanQuyen> listPhanQuyen = phanQuyenBUS.TimKiemPhanQuyen(keyword);
            foreach (PhanQuyen phanQuyen in listPhanQuyen)
            {
                Console.WriteLine(phanQuyen.maPhanQuyen + "\n" + phanQuyen.tenPhanQuyen + "\n");
            }
        }
    }
}

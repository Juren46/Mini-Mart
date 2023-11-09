using System.Text;

namespace ConsoleTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //TestPhanQuyen.TestLayDanhSachPhanQuyen();
            //TestPhanQuyen.TestLayPhanQuyenTheoMa();
            //TestPhanQuyen.TestLayPhanQuyenTheoTen();
            //TestPhanQuyen.TestLayPhanQuyenTheoTenTaiKhoan();
            //TestPhanQuyen.TestTimKiemTaiKhoan();

            //TestTaiKhoan.TestLayDanhSachTaiKhoan();
            //TestTaiKhoan.TestLayTaiKhoanTheoTen();
            //TestTaiKhoan.TestKiemTraDangNhap();
            //TestTaiKhoan.TestThemTaiKhoan();
            //TestTaiKhoan.TestDoiMatKhau
            //TestTaiKhoan.TestKhoaTaiKhoan();
            //TestTaiKhoan.TestMoKhoaTaiKhoan();
            //TestTaiKhoan.TestTimKiemTaiKhoan();
            //TestTaiKhoan.TestLocTaiKhoanTheoPhanQuyen();

            //TestNhanVien.TestLayDanhSachNhanVien
            TestNhanVien.TestThemNhanVien();
        }
    }
}
using BUS.OtherFunctions;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO;

        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }

        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            return taiKhoanDAO.LayDanhSachTaiKhoan();
        }

        public TaiKhoan LayTaiKhoanTheoTen(string tenTaiKhoan)
        {
            return taiKhoanDAO.LayTaiKhoanTheoTen(tenTaiKhoan);
        }

        public string KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";
            else
            {
                if (taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhau))
                    return "Đăng nhập thành công!";
                else
                    return "Thông tin đăng nhập không chính xác!";
            }
        }

        public string ThemTaiKhoan(string tenPhanQuyen, string tenTaiKhoan, string matKhau)     //Chọn phân quyền bằng combobox trong GUI nên sẽ dùng tên phân quyền
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (InputValidate.KiemTraASCII(tenTaiKhoan) || InputValidate.KiemTraASCII(matKhau))
                return "Tên tài khoản và mật khẩu không được chứa kí tự không thuộc ASCII!";

            if (taiKhoanDAO.KiemTraTaiKhoanDaTonTai(tenTaiKhoan))
                return "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!";           

            tenTaiKhoan = tenTaiKhoan.Trim();
            matKhau = matKhau.Trim();

            PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
            PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoTen(tenPhanQuyen);

            TaiKhoan taiKhoan = new TaiKhoan(phanQuyen.maPhanQuyen, tenTaiKhoan, matKhau);

            if (taiKhoanDAO.ThemTaiKhoan(taiKhoan))
                return "Thêm tài khoản thành công!";
            else
                return "Thêm tài khoản thất bại!";
        }

        public string DoiMatKhau(string tenTaiKhoan, string matKhauCu, string matKhauMoi, string xacNhanMatKhauMoi)
        {
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (!taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhauCu))
                return "Mật khẩu cũ sai!";

            if (InputValidate.KiemTraASCII(matKhauMoi))
                return "Mật khẩu mới không được chứa kí tự không thuộc ASCII!";

            if (!matKhauMoi.Equals(xacNhanMatKhauMoi))
                return "Xác nhận mật khẩu mới không chính xác!";

            if (matKhauCu.Equals(matKhauMoi))
                return "Mật khẩu mới giống với mật khẩu cũ!";

            matKhauMoi = matKhauMoi.Trim();

            if (taiKhoanDAO.DoiMatKhau(tenTaiKhoan, matKhauMoi))
                return "Đổi mật khẩu thành công!";
            else
                return "Đổi mật khẩu thất bại!";
        }

        public string KhoaTaiKhoan(string tenTaiKhoan)
        {
            if (taiKhoanDAO.KhoaTaiKhoan(tenTaiKhoan))
                return "Khóa tài khoản thành công!";

            return "Khóa tài khoản thất bại!";
        }

        public string MoKhoaTaiKhoan(string tenTaiKhoan)
        {
            if (taiKhoanDAO.MoKhoaTaiKhoan(tenTaiKhoan))
                return "Mở khóa tài khoản thành công!";

            return "Mở khóa tài khoản thất bại!";
        }

        public List<TaiKhoan> TimKiemTaiKhoan(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return taiKhoanDAO.TimKiemTaiKhoan(keyword);
        }

        public List<TaiKhoan> LocTaiKhoanTheoPhanQuyen(string tenPhanQuyen)     //Chọn phân quyền bằng combobox trong GUI nên sẽ dùng tên phân quyền
        {
            return taiKhoanDAO.LocTaiKhoanTheoPhanQuyen(tenPhanQuyen);
        }
    }
}

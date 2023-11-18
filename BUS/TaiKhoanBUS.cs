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
                if (!taiKhoanDAO.KiemTraTaiKhoanCoNguoiDung(tenTaiKhoan))
                    return "Tài khoản chưa đăng ký người dùng, liên hệ admin để được hỗ trợ.";

                if (taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhau))
                    return "Đăng nhập thành công!";
                else
                    return "Thông tin đăng nhập không chính xác!";
            }
        }

        public string ThemTaiKhoan(string tenPhanQuyen, string tenTaiKhoan, string matKhau)     //Chọn phân quyền bằng combobox trong GUI nên sẽ dùng tên phân quyền
        {
            if (string.IsNullOrEmpty(tenPhanQuyen) || string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (taiKhoanDAO.KiemTraTaiKhoanDaTonTai(tenTaiKhoan))
                return "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!";           

            tenTaiKhoan = tenTaiKhoan.Trim();
            matKhau = matKhau.Trim();

            PhanQuyen phanQuyen = new PhanQuyenBUS().LayPhanQuyenTheoTen(tenPhanQuyen);

            TaiKhoan taiKhoan = new TaiKhoan(phanQuyen.maPhanQuyen, tenTaiKhoan, matKhau);

            if (taiKhoanDAO.ThemTaiKhoan(taiKhoan))
                return "Thêm tài khoản thành công!";
            else
                return "Thêm tài khoản thất bại!";
        }

        public string DoiMatKhau(string tenTaiKhoan, string matKhauCu, string matKhauMoi, string xacNhanMatKhauMoi)
        {
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhauMoi))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (!taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhauCu))
                return "Mật khẩu cũ sai!";

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

        public string XoaTaiKhoan(string tenTaiKhoan)
        {
            if (taiKhoanDAO.XoaTaiKhoan(tenTaiKhoan))
                return "Xóa tài khoản thành công!";

            return "Xóa tài khoản thất bại!";
        }

        public List<TaiKhoan> TimKiemTaiKhoan(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return taiKhoanDAO.TimKiemTaiKhoan(keyword);
        }

        public List<TaiKhoan> LocTaiKhoanTheoPhanQuyen(string tenPhanQuyen)
        {
            return taiKhoanDAO.LocTaiKhoanTheoPhanQuyen(tenPhanQuyen);
        }

        public List<TaiKhoan> LayDanhSachTaiKhoanChuaDung()
        {
            return taiKhoanDAO.LayDanhSachTaiKhoanChuaDung();
        }

        public bool KiemTraTaiKhoanCoNguoiDung(string tenTaiKhoan)
        {
            return taiKhoanDAO.KiemTraTaiKhoanCoNguoiDung(tenTaiKhoan);
        }
    }
}

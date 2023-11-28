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

        public bool KiemTraTaiKhoanDangHoatDong(string tenTaiKhoan)
        {
            return taiKhoanDAO.KiemTraTaiKhoanDangHoatDong(tenTaiKhoan);
        }

        public bool KiemTraTaiKhoanCoNguoiDung(string tenTaiKhoan)
        {
            return taiKhoanDAO.KiemTraTaiKhoanCoNguoiDung(tenTaiKhoan);
        }

        public string KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";
            else
            {
                if (!taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhau))
                    return "Thông tin đăng nhập không chính xác!";
                else
                {
                    if (!taiKhoanDAO.KiemTraTaiKhoanCoNguoiDung(tenTaiKhoan))
                        return "Tài khoản chưa đăng ký người dùng!";
                    else if (!KiemTraTaiKhoanDangHoatDong(tenTaiKhoan))
                        return "Tài khoản đang tạm thời bị đình chỉ hoặc đã bị xóa!";
                    else
                        return "Đăng nhập thành công!";
                }
            }
        }

        public string ThemTaiKhoan(string maPhanQuyen, string tenTaiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(maPhanQuyen) || string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (taiKhoanDAO.KiemTraTaiKhoanDaTonTai(tenTaiKhoan))
                return "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!";           

            tenTaiKhoan = tenTaiKhoan;
            matKhau = matKhau;

            PhanQuyen phanQuyen = new PhanQuyenBUS().LayPhanQuyenTheoMa(maPhanQuyen);

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

        public string SuaTaiKhoan(string tenTaiKhoan, string matKhau, string trangThai)
        {
            if (taiKhoanDAO.SuaTaiKhoan(tenTaiKhoan, matKhau, trangThai))
                return "Chỉnh sửa thông tin tài khoản thành công!";
            else
                return "Chỉnh sửa thông tin tài khoản thất bại!";
        }

        public string VoHieuHoaTaiKhoan(string tenTaiKhoan, string trangThai)
        {
            bool hanhDong = false;
            
            if (trangThai.Equals("Xóa"))
                hanhDong = taiKhoanDAO.VoHieuHoaTaiKhoan(tenTaiKhoan, "Đã xóa");
            else if (trangThai.Equals("Đình chỉ"))
                hanhDong = taiKhoanDAO.VoHieuHoaTaiKhoan(tenTaiKhoan, "Tạm đình chỉ");
            
            if (hanhDong)   
                return trangThai + " tài khoản thành công!";
            else
                return trangThai + " tài khoản thất bại!";
        }

        public List<TaiKhoan> TimKiemTaiKhoan(string tuKhoa, string maPhanQuyen, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            return taiKhoanDAO.TimKiemTaiKhoan(tuKhoa, maPhanQuyen, trangThai);
        }
    }
}

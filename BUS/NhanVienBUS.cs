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
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO;

        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return nhanVienDAO.LayDanhSachNhanVien();
        }

        public NhanVien LayNhanVienTheoMa(string maNhanVien)
        {
            return nhanVienDAO.LayNhanVienTheoMa(maNhanVien);
        }

        public NhanVien LayNhanVienTheoTenTaiKhoan(string tenTaiKhoan)
        {
            return nhanVienDAO.LayNhanVienTheoTenTaiKhoan(tenTaiKhoan);
        }

        public int DemSoNhanVienTheoPhanQuyen(string tenPhanQuyen)
        {
            return nhanVienDAO.DemSoNhanVienTheoPhanQuyen(tenPhanQuyen);
        }

        public string ThemNhanVien(string maNhanVien, string tenTaiKhoan, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(hoTen))
                return "Tên tài khoản và tên nhân viên không được để trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhanVien nhanVien = new NhanVien();

            nhanVien.maNhanVien = maNhanVien;
            nhanVien.tenTaiKhoan = tenTaiKhoan;
            nhanVien.hoTen = hoTen.Trim();
            nhanVien.gioiTinh = gioiTinh;
            try { nhanVien.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { nhanVien.ngaySinh = null; }
            nhanVien.soDienThoai = soDienThoai.Trim();
            nhanVien.email = email.Trim();
            nhanVien.diaChi = diaChi.Trim();

            if (nhanVienDAO.ThemNhanVien(nhanVien))
                return "Thêm nhân viên thành công!";
            else
                return "Thêm nhân viên thất bại!";
        }

        public string XoaNhanVien(string maNhanVien)
        {
            if (nhanVienDAO.XoaNhanVien(maNhanVien))
                return "Xóa nhân viên thành công!";

            return "Xóa nhân viên thất bại!";
        }

        public string SuaNhanVien(string maNhanVien, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen))
                return "Họ tên không được bỏ trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhanVien nhanVien = new NhanVien();

            nhanVien.maNhanVien = maNhanVien;
            nhanVien.hoTen = hoTen.Trim();
            nhanVien.gioiTinh = gioiTinh;
            try { nhanVien.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { nhanVien.ngaySinh = null; }
            nhanVien.soDienThoai = soDienThoai.Trim();
            nhanVien.email = email.Trim();
            nhanVien.diaChi = diaChi.Trim();

            if (nhanVienDAO.SuaNhanVien(nhanVien))
                return "Sửa thông tin nhân viên thành công!";
            else
                return "Sửa thông tin nhân viên thất bại!";
        }

        public List<NhanVien> TimKiemNhanVien(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return nhanVienDAO.TimKiemNhanVien(keyword);
        }

        public List<NhanVien> LocNhanVienTheoPhanQuyen(string tenPhanQuyen)
        {
            return nhanVienDAO.LocNhanVienTheoPhanQuyen(tenPhanQuyen);
        }

        public List<NhanVien> LocNhanVienTheoGioiTinh(string gioiTinh)
        {
            return nhanVienDAO.LocNhanVienTheoGioiTinh(gioiTinh);
        }
    }
}

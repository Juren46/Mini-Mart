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
    public class QuanLiBUS
    {
        QuanLiDAO quanLiDAO;

        public QuanLiBUS() 
        {
            quanLiDAO = new QuanLiDAO();
        }

        public List<QuanLi> LayDanhSachQuanLi()
        {
            return quanLiDAO.LayDanhSachQuanLi();
        }

        public int DemSoQuanLi()
        {
            return quanLiDAO.DemSoQuanLi();
        }

        public string ThemQuanLi(string maQuanLi, string tenTaiKhoan, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(hoTen))
                return "Tên tài khoản và họ tên không được để trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            QuanLi quanLi = new QuanLi();

            quanLi.maQuanLi = maQuanLi;
            quanLi.tenTaiKhoan = tenTaiKhoan;
            quanLi.hoTen = hoTen.Trim();
            quanLi.gioiTinh = gioiTinh;
            try { quanLi.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { quanLi.ngaySinh = null; }
            quanLi.soDienThoai = soDienThoai.Trim();
            quanLi.email = email.Trim();
            quanLi.diaChi = diaChi.Trim();

            if (quanLiDAO.ThemQuanLi(quanLi))
                return "Thêm quản lí thành công!";
            else
                return "Thêm quản lí thất bại!";
        }

        public string SuaQuanLi(string maQuanLi, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen))
                return "Họ tên không được để trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            QuanLi quanLi = new QuanLi();

            quanLi.maQuanLi = maQuanLi;
            quanLi.hoTen = hoTen.Trim();
            quanLi.gioiTinh = gioiTinh;
            try { quanLi.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { quanLi.ngaySinh = null; }
            quanLi.soDienThoai = soDienThoai.Trim();
            quanLi.email = email.Trim();
            quanLi.diaChi = diaChi.Trim();

            if (quanLiDAO.SuaQuanLi(quanLi))
                return "Sửa thông tin quản lí thành công!";
            else
                return "Sửa thông tin quản lí thất bại!";
        }
    }
}

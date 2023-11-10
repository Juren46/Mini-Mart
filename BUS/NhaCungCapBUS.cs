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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO nhaCungCapDAO;

        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }

        public List<NhaCungCap> LayDanhSachNhaCungCap()
        {
            return nhaCungCapDAO.LayDanhSachNhaCungCap();
        }

        public NhaCungCap LayNhaCungCapTheoMa(string maNhaCungCap)
        {
            return nhaCungCapDAO.LayNhaCungCapTheoMa(maNhaCungCap);
        }

        public NhaCungCap LayNhaCungCapTheoTen(string tenNhaCungCap)
        {
            return nhaCungCapDAO.LayNhaCungCapTheoTen(tenNhaCungCap);
        }

        public int DemSoNhaCungCap()
        {
            return nhaCungCapDAO.DemSoNhaCungCap();
        }

        public string ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap))
                return "Tên nhà cung cấp không được bỏ trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            if (nhaCungCapDAO.KiemTraNhaCungCapDaTonTai(tenNhaCungCap.ToLower()))
                return "Nhà cung cấp đã tồn tại, vui lòng chọn tên khác!";

            NhaCungCap nhaCungCap = new NhaCungCap();

            nhaCungCap.maNhaCungCap = maNhaCungCap;
            nhaCungCap.tenNhaCungCap = tenNhaCungCap.Trim();
            nhaCungCap.soDienThoai = soDienThoai.Trim();
            nhaCungCap.email = email.Trim();
            nhaCungCap.diaChi = diaChi.Trim();

            if (nhaCungCapDAO.ThemNhaCungCap(nhaCungCap))
                return "Thêm nhà cung cấp thành công!";
            else
                return "Thêm nhà cung cấp thất bại!";
        }

        public string SuaNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap))
                return "Tên nhà cung cấp không được bỏ trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhaCungCap nhaCungCap = new NhaCungCap();

            nhaCungCap.maNhaCungCap = maNhaCungCap;
            nhaCungCap.tenNhaCungCap = tenNhaCungCap.Trim();
            nhaCungCap.soDienThoai = soDienThoai.Trim();
            nhaCungCap.email = email.Trim();
            nhaCungCap.diaChi = diaChi.Trim();

            if (nhaCungCapDAO.SuaNhaCungCap(nhaCungCap))
                return "Sửa thông tin nhà cung cấp thành công!";
            else
                return "Sửa thông tin nhà cung cấp thất bại!";
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string keyword)
        {
            keyword = keyword.Trim().ToLower();
            return nhaCungCapDAO.TimKiemNhaCungCap(keyword);
        }
    }
}

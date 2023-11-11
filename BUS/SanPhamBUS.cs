using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO;
        public SanPhamBUS()
        {
            sanPhamDAO = new SanPhamDAO();
        }

        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAO.LayDanhSachSanPham();
        }

        public SanPham LaySanPhamTheoMa(string maSanPham)
        {
            return sanPhamDAO.LaySanPhamTheoMa(maSanPham);
        }

        public int DemSoSanPham()
        {
            return sanPhamDAO.DemSoSanPham();
        }

        public string ThemSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, string duongDanAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(maNhaCungCap) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(duongDanAnh))
                return "Vui lòng nhập đầy đủ thông tin!";

            SanPham sanPham = new SanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, Decimal.Parse(giaBan), duongDanAnh);

            if (sanPhamDAO.ThemSanPham(sanPham))
                return "Thêm sản phẩm thành công!";
            else
                return "Thêm sản phẩm thất bại!";
        }

        public string XoaSanPham(string maSanPham)
        {
            if (sanPhamDAO.XoaSanPham(maSanPham))
                return "Xóa sản phẩm thành công!";

            return "Xóa sản phẩm thất bại!";
        }

        public string SuaSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, string duongDanAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(maNhaCungCap) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(duongDanAnh))
                return "Vui lòng nhập đầy đủ thông tin!";

            SanPham sanPham = new SanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, Decimal.Parse(giaBan), duongDanAnh);

            if (sanPhamDAO.SuaSanPham(sanPham))
                return "Sửa thông tin sản phẩm thành công!";
            else
                return "Sửa thông tin sản phẩm thất bại!";
        }

        public List<SanPham> TimKiemSanPham(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return sanPhamDAO.TimKiemSanPham(keyword);
        }

        public List<SanPham> LocSanPhamTheoLoaiSanPham(string tenLoaiSanPham)
        {
            return sanPhamDAO.LocSanPhamTheoLoaiSanPham(tenLoaiSanPham);
        }
    }
}

using DAO;
using DocumentFormat.OpenXml.Vml;
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

        public string ThemSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, byte[]duLieuAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(maNhaCungCap) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(giaBan) || !(duLieuAnh != null && duLieuAnh.Length > 0))
                return "Vui lòng nhập đầy đủ thông tin!";
            SanPham sanPham = new SanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, Decimal.Parse(giaBan), duLieuAnh);

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

        public string SuaSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, byte[] duLieuAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(maNhaCungCap) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(giaBan) || !(duLieuAnh != null && duLieuAnh.Length > 0))
                return "Vui lòng nhập đầy đủ thông tin!";

            SanPham sanPham = new SanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, Decimal.Parse(giaBan), duLieuAnh);

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

        public List<SanPham> LocSanPhamTheoNhaCungCap(string maNhaCungCap)
        {
            return sanPhamDAO.LocSanPhamTheoNhaCungCap(maNhaCungCap);
        }

        public bool CapNhatSoLuong(string maSanPham, int soLuong)
        {
            return sanPhamDAO.CapNhatSoLuong(maSanPham, soLuong);
        }
    }
}

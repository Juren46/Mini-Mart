using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public SanPham()
        {
            soLuong = 0;
            trangThai = true;
        }

        public SanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, int soLuong, decimal giaBan, byte[]duLieuAnh)
        {
            this.maSanPham = maSanPham;
            this.maLoaiSanPham = maLoaiSanPham;
            this.maNhaCungCap = maNhaCungCap;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.duLieuAnh = duLieuAnh;
            trangThai = true;
        }

        public SanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, decimal giaBan, byte[] duLieuAnh)
        {
            this.maSanPham = maSanPham;
            this.maLoaiSanPham = maLoaiSanPham;
            this.maNhaCungCap = maNhaCungCap;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.giaBan = giaBan;
            this.duLieuAnh = duLieuAnh;
            trangThai = true;
        }

        public string maSanPham { get; set; }
        public string maLoaiSanPham { get; set; }
        public string maNhaCungCap { get; set; }
        public string tenSanPham { get; set; }
        public string donViTinh { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
        public byte[] duLieuAnh { get; set; }
        public bool trangThai { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap()
        {
        }

        public ChiTietPhieuNhap(string maPhieuNhap, string maSanPham, string donViTinh, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maSanPham = maSanPham;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string maPhieuNhap { get; set; }
        public string maSanPham { get; set; }
        public string donViTinh { get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien { get; set; }
    }
}

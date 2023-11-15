using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(string maHoaDon, string maSanPham, string donViTinh, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.maHoaDon = maHoaDon;
            this.maSanPham = maSanPham;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public ChiTietHoaDon(string maSanPham, int soLuong)
        {
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
        }

        public string maHoaDon { get; set; }
        public string maSanPham { get; set; }
        public string donViTinh {  get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien { get; set; }
    }
}

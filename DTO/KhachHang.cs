using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang : ConNguoi
    {
        public string maKhachHang { get; set; }
        public string bacThanhVien { get; set; }
        public decimal diemThanhVien { get; set; }
        public decimal diemTichLuy { get; set; }
        public KhachHang()
        {
            bacThanhVien = "Đồng";
            diemThanhVien = 0;
            diemTichLuy = 0;
        }

        public KhachHang(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maKhachHang, string bacThanhVien = "Đồng", decimal diemThanhVien = 0, decimal diemTichLuy = 0) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.bacThanhVien = bacThanhVien;
            this.diemThanhVien = diemThanhVien;
            this.diemTichLuy = diemTichLuy;
        }
    }
}

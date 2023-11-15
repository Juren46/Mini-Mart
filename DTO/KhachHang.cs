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
        public decimal diemTichLuy { get; set; }
        public KhachHang()
        {
            bacThanhVien = "Đồng";
            diemTichLuy = 0;
        }

        public KhachHang(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maKhachHang, string bacThanhVien = "Đồng", decimal diemTichLuy = 0) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.bacThanhVien = bacThanhVien;
            this.diemTichLuy = diemTichLuy;
        }
    }
}

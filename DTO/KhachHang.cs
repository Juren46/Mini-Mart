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
        public int diemThanhVien { get; set; }
        public int diemTichLuy { get; set; }
        public KhachHang()
        {
            bacThanhVien = "Đồng";
            diemThanhVien = 0;
            diemTichLuy = 0;
        }

        public KhachHang(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maKhachHang, string bacThanhVien = "Đồng", int diemThanhVien = 0, int diemTichLuy = 0) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.bacThanhVien = bacThanhVien;
            this.diemThanhVien = diemThanhVien;
            this.diemTichLuy = diemTichLuy;
        }
    }
}

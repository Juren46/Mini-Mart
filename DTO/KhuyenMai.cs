using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public KhuyenMai()
        {
        }

        public KhuyenMai(string maKhuyenMai, string tenKhuyenMai, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string loaiGiaTri, decimal giaTriApDung)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenKhuyenMai = tenKhuyenMai;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.loaiGiaTri = loaiGiaTri;
            this.giaTriApDung = giaTriApDung;
        }

        public string maKhuyenMai { get; set; }
        public string tenKhuyenMai { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
        public string loaiGiaTri { get; set; }
        public decimal giaTriApDung { get; set; }
    }
}

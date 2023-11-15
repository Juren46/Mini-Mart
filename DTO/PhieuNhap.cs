using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public PhieuNhap()
        {
            trangThaiDuyet = false;
            trangThai = true;
        }

        public PhieuNhap(string maPhieuNhap, string maNhaCungCap, string maNhanVien, string maQuanLi, DateTime thoiGianTao, DateTime thoiGianDuyet, decimal thanhTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maNhaCungCap = maNhaCungCap;
            this.maNhanVien = maNhanVien;
            this.maQuanLi = maQuanLi;
            this.thoiGianTao = thoiGianTao;
            this.thoiGianDuyet = thoiGianDuyet;
            this.thanhTien = thanhTien;
            trangThaiDuyet = false;
            trangThai = true;
        }

        public string maPhieuNhap { get; set; }
        public string maNhaCungCap { get; set; }
        public string maNhanVien { get; set; }
        public string? maQuanLi { get; set; }
        public DateTime thoiGianTao { get; set; }
        public DateTime? thoiGianDuyet { get; set; }
        public decimal thanhTien { get; set; }
        public bool trangThaiDuyet { get; set; }
        public bool trangThai { get; set; }
    }
}

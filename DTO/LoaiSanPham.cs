using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        public LoaiSanPham()
        {
            trangThai = "Đang sử dụng";
        }

        public LoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            this.maLoaiSanPham = maLoaiSanPham;
            this.tenLoaiSanPham = tenLoaiSanPham;
            trangThai = "Đang sử dụng";
        }

        public string maLoaiSanPham { get; set; }
        public string tenLoaiSanPham { get; set; }
        public string trangThai { get; set; }
    }
}

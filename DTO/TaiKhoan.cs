using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            trangThai = "Chờ xử lý";
        }

        public TaiKhoan(string maPhanQuyen, string tenTaiKhoan, string matKhau)
        {
            this.maPhanQuyen = maPhanQuyen;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            trangThai = "Chờ xử lý";
        }

        public string maPhanQuyen { get; set; }
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public string trangThai { get; set; }
    }
}

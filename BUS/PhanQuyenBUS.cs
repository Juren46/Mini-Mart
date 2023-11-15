using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO phanQuyenDAO;

        public PhanQuyenBUS()
        {
            phanQuyenDAO = new PhanQuyenDAO();
        }

        public List<PhanQuyen> LayDanhSachPhanQuyen()
        {
            return phanQuyenDAO.LayDanhSachPhanQuyen();
        }

        public PhanQuyen LayPhanQuyenTheoMa(string maPhanQuyen)
        {
            return phanQuyenDAO.LayPhanQuyenTheoMa(maPhanQuyen);
        }

        public PhanQuyen LayPhanQuyenTheoTen(string tenPhanQuyen)
        {
            return phanQuyenDAO.LayPhanQuyenTheoTen(tenPhanQuyen);
        }

        public PhanQuyen LayPhanQuyenTheoTenTaiKhoan(string tenTaiKhoan)
        {
            return phanQuyenDAO.LayPhanQuyenTheoTenTaiKhoan(tenTaiKhoan);
        }

        public List<PhanQuyen> TimKiemPhanQuyen(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return phanQuyenDAO.TimKiemPhanQuyen(keyword);
        }
    }
}

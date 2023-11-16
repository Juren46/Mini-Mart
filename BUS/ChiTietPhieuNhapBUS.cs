using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;
        public ChiTietPhieuNhapBUS() 
        { 
            chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        }

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            return chiTietPhieuNhapDAO.LayDanhSachChiTietPhieuNhap(maPhieuNhap);
        }
    }
}

using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO;
        public ChiTietPhieuNhapBUS() 
        { 
            chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        }
    }
}

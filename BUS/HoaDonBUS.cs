using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO;
        public HoaDonBUS() 
        { 
            hoaDonDAO = new HoaDonDAO();
        }

        public List<HoaDon> LayDanhSachHoaDon()
        {
            return hoaDonDAO.LayDanhSachHoaDon();
        }
    }
}

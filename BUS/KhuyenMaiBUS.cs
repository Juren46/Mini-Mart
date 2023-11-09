using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO;

        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            return khuyenMaiDAO.LayDanhSachKhuyenMai();
        }

        public int DemSoKhuyenMai()
        {
            return khuyenMaiDAO.DemSoKhuyenMai();
        }
    }
}

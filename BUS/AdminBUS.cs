using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class AdminBUS
    {
        AdminDAO adminDAO;

        public AdminBUS()
        {
            adminDAO = new AdminDAO();
        }

        public Admin LayAdminTheoTenTaiKhoan(string tentaiKhoan)
        {
            return adminDAO.LayAdminTheoTenTaiKhoan(tentaiKhoan);
        }
    }
}

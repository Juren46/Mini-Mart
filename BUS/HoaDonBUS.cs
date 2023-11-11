using BUS.OtherFunctions;
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

        public int DemSoHoaDon()
        {
            return hoaDonDAO.DemSoHoaDon();
        }

        public int DemSoHoaDonTheoNgay(string ngay)
        {
            DateTime dateTime = DateTime.ParseExact(ngay, "dd/MM/yyyy", null); 
            return hoaDonDAO.DemSoHoaDonTheoNgay(dateTime);
        }

        public string ThemHoaDon(List<ChiTietHoaDon> listChiTietHoaDon, string maNhanVien, string maKhachHang, string maKhuyenMai, string tongTien, string giaTriKhuyenMai, string thanhTien, string tienNhan, string tienThua)
        {
            HoaDon hoaDon = new HoaDon();

            hoaDon.maHoaDon = IDGenerator.GenerateHoaDonID();
            hoaDon.maNhanVien = maNhanVien;
            hoaDon.maKhachHang = maKhachHang;
            hoaDon.maKhuyenMai = maKhuyenMai;
            hoaDon.thoiGianTao = DateTime.Now;
            hoaDon.tongTien = Decimal.Parse(tongTien);
            hoaDon.giaTriKhuyenMai = Decimal.Parse(giaTriKhuyenMai);
            hoaDon.thanhTien = Decimal.Parse(thanhTien);
            hoaDon.tienNhan = Decimal.Parse(tienNhan);
            hoaDon.tienThua = Decimal.Parse(tienThua);

            if (hoaDonDAO.ThemHoaDon(hoaDon, listChiTietHoaDon))
                return "Thanh toán thành công!";
            else
                return "Thanh toán thất bại!";
        }
    }
}

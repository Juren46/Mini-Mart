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
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhapDAO;

        public PhieuNhapBUS()
        {
            phieuNhapDAO = new PhieuNhapDAO();
        }

        public int DemSoPhieuNhapTheoNgay(string strNgay)
        {
            DateTime ngay = DateTime.ParseExact(strNgay, "dd/MM/yyyy", null);
            return phieuNhapDAO.DemSoPhieuNhapTheoNgay(ngay);
        }

        public PhieuNhap LayPhieuNhapTheoMa(string maPhieuNhap)
        {
            return phieuNhapDAO.LayPhieuNhapTheoMa(maPhieuNhap);
        }

        public string ThemPhieuNhap(List<ChiTietPhieuNhap> listChiTietPhieuNhap, string maPhieuNhap, string maNhaCungCap, string maNhanVien, string thanhTien)
        {
            PhieuNhap phieuNhap= new PhieuNhap();

            phieuNhap.maPhieuNhap = maPhieuNhap;
            phieuNhap.maNhaCungCap = maNhaCungCap;
            phieuNhap.maNhanVien = maNhanVien;
            phieuNhap.thoiGianTao = DateTime.Now;
            phieuNhap.thanhTien = Decimal.Parse(thanhTien);

            if (phieuNhapDAO.ThemPhieuNhap(phieuNhap, listChiTietPhieuNhap))
                return "Thêm phiếu nhập thành công!";
            else
                return "Thêm phiếu nhập thất bại!";
        }

        /*public string SuaPhieuNhapChuaDuyet(string maPhieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap, string maQuanLi)
        {
            PhieuNhap phieuNhap = phieuNhapDAO.LayPhieuNhapTheoMa(maPhieuNhap);



            if (phieuNhapDAO.SuaPhieuNhapChuaDuyet(phieuNhap, listChiTietPhieuNhap))
                return "Sửa phiếu nhập chưa duyệt thành công!";
            else
                return "Sửa phiếu nhập chưa duyệt thất bại!";
        }*/

        public string DuyetPhieuNhap(string maPhieuNhap)
        {
            if (phieuNhapDAO.DuyetPhieuNhap(maPhieuNhap))
                return "Duyệt phiếu nhập thành công!";
            else
                return "Duyệt phiếu nhập thất bại!";
        }
    }
}

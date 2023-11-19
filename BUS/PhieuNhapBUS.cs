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

        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhap();
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

        public List<PhieuNhap> LayDanhSachPhieuNhapChuaDuyet()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapChuaDuyet();
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaDuyet()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapDaDuyet();
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaTuChoi()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapDaTuChoi();
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

        public string SuaPhieuNhapChuaDuyet(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            if (phieuNhapDAO.SuaPhieuNhapChuaDuyet(listChiTietPhieuNhap))
                return "Sửa phiếu nhập chưa duyệt thành công!";
            else
                return "Sửa phiếu nhập chưa duyệt thất bại!";
        }

        public string DuyetPhieuNhap(string maPhieuNhap, string maQuanLi)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapDAO().LayDanhSachChiTietPhieuNhap(maPhieuNhap);

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                SanPhamBUS sanPhamBUS = new SanPhamBUS();

                sanPhamBUS.CapNhatSoLuong(chiTietPhieuNhap.maSanPham, +(chiTietPhieuNhap.soLuong));
            }

            if (phieuNhapDAO.DuyetPhieuNhap(maPhieuNhap, maQuanLi, DateTime.Now))
                return "Duyệt phiếu nhập thành công!";
            else
                return "Duyệt phiếu nhập thất bại!";
        }

        public string TuChoiPhieuNhap(string maPhieuNhap)
        {
            if (phieuNhapDAO.TuChoiDuyetPhieuNhap(maPhieuNhap))
                return "Từ chối duyệt phiếu nhập thành công!";
            else
                return "Từ chối duyệt phiếu nhập thất bại!";
        }
    }
}

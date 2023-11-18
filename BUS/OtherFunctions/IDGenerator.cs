﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.OtherFunctions
{
    public class IDGenerator
    {
        public static string GenerateLoaiSanPhamID()
        {
            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();

            int count = loaiSanPhamBUS.DemSoLoaiSanPham();

            string loaiSanPhamID = string.Format("LSP{0:D5}", ++count);

            return loaiSanPhamID;
        }

        public static string GenerateNhaCungCapID()
        {
            NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

            int count = nhaCungCapBUS.DemSoNhaCungCap();

            string nhaCungCapID = string.Format("NCC{0:D5}", ++count);

            return nhaCungCapID;
        }

        public static string GenerateNhanVienID(string tenPhanQuyen)
        {
            NhanVienDAO nhanVienDAO = new NhanVienDAO();

            string nhanVienID = "";

            if (tenPhanQuyen.Equals("Nhân viên bán hàng"))
            {
                int count = nhanVienDAO.DemSoNhanVienTheoPhanQuyen(tenPhanQuyen);

                nhanVienID = string.Format("NVB{0:D5}", ++count);
            }

            if (tenPhanQuyen.Equals("Nhân viên kho"))
            {
                int count = nhanVienDAO.DemSoNhanVienTheoPhanQuyen(tenPhanQuyen);

                nhanVienID = string.Format("NVK{0:D5}", ++count);
            }

            return nhanVienID;
        }

        public static string GenerateKhachHangID()
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();

            int count = khachHangBUS.DemSoKhachHang();

            string khachHangID = string.Format("KHH{0:D5}", ++count); ;

            return khachHangID;
        }

        public static string GenerateSanPhamID()
        {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();

            int count = sanPhamBUS.DemSoSanPham();

            string sanPhamID = string.Format("SPH{0:D5}", ++count); ;

            return sanPhamID;
        }

        public static string GenerateKhuyenMaiID()
        {
            KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

            int count = khuyenMaiBUS.DemSoKhuyenMai();

            string khuyenMaiID = string.Format("KHM{0:D5}", ++count);

            return khuyenMaiID;
        }

        public static string GenerateHoaDonID()
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();

            int count = hoaDonBUS.DemSoHoaDonTheoNgay(DateTime.Now.ToString("dd/MM/yyyy"));

            string hoaDonID = string.Format("{0}-HD{1:D4}", DateTime.Now.ToString("dd/MM/yyyy"), ++count);

            return hoaDonID;
        }

        public static string GeneratePhieuNhapID()
        {
            PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();

            int count = phieuNhapBUS.DemSoPhieuNhapTheoNgay(DateTime.Now.ToString("dd/MM/yyyy"));

            string phieuNhapID = string.Format("{0}-PN{1:D4}", DateTime.Now.ToString("dd/MM/yyyy"), ++count);

            return phieuNhapID;
        }

        public static string GenerateQuanLiID()
        {
            QuanLiBUS quanLiBUS = new QuanLiBUS();

            int count = quanLiBUS.DemSoQuanLi();

            string quanLiID = string.Format("QLI{0:D5}", ++count); ;

            return quanLiID;
        }
    }
}

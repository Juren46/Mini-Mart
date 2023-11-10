﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAO loaiSanPhamDAO;

        public LoaiSanPhamBUS()
        {
            loaiSanPhamDAO = new LoaiSanPhamDAO();
        }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            return loaiSanPhamDAO.LayDanhSachLoaiSanPham();
        }

        public LoaiSanPham LayLoaiSanPhamTheoMa(string maLoaiSanPham)
        {
            return loaiSanPhamDAO.LayLoaiSanPhamTheoMa(maLoaiSanPham);
        }

        public LoaiSanPham LayLoaiSanPhamTheoTen(string tenLoaiSanPham)
        {
            return loaiSanPhamDAO.LayLoaiSanPhamTheoTen(tenLoaiSanPham);
        }

        public int DemSoLoaiSanPham()
        {
            return loaiSanPhamDAO.DemSoLoaiSanPham();
        }

        public string ThemLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            if (string.IsNullOrEmpty(tenLoaiSanPham))
                return "Vui lòng nhập đầy đủ thông tin!";

            tenLoaiSanPham = tenLoaiSanPham.Trim();

            if (loaiSanPhamDAO.KiemTraLoaiSanPhamDaTonTai(tenLoaiSanPham.ToLower()))
                return "Tên loại sản phẩm đã tồn tại, vui lòng chọn tên khác!";
            else
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham(maLoaiSanPham, tenLoaiSanPham);

                if (loaiSanPhamDAO.ThemLoaiSanPham(loaiSanPham))
                    return "Thêm loại sản phẩm thành công!";
                else
                    return "Thêm loại sản phẩm thất bại!";
            }
        }

        public string XoaLoaiSanPham(string maLoaiSanPham)
        {
            if (loaiSanPhamDAO.XoaLoaiSanPham(maLoaiSanPham))
                return "Xóa loại sản phẩm thành công!";

            return "Xóa loại  phẩm thất bại!";
        }

        public string SuaLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            if (string.IsNullOrEmpty(tenLoaiSanPham))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (loaiSanPhamDAO.SuaLoaiSanPham(new LoaiSanPham(maLoaiSanPham, tenLoaiSanPham)))
                return "Sửa thông tin loại sản phẩm thành công!";
            else
                return "Sửa thông tin loại sản phẩm thất bại!";
        }

        public List<LoaiSanPham> TimKiemLoaiSanPham(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return loaiSanPhamDAO.TimKiemLoaiSanPham(keyword);
        }     
    }
}

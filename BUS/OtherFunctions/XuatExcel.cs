﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using DTO;
using System.Security;
using ClosedXML.Excel;

namespace BUS.OtherFunctions
{
    public class XuatExcel
    {
        string filePath;

        public XuatExcel(string filePath) 
        {
            this.filePath = filePath;
        }

        public void XuatExcelPhanQuyen(List<PhanQuyen> listPhanQuyen)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã phân quyền";
                worksheet.Cell(1, 2).Value = "Tên phân quyền";

                int row = 2;
                foreach (PhanQuyen phanQuyen in listPhanQuyen)
                {
                    worksheet.Cell(row, 1).Value = phanQuyen.maPhanQuyen;
                    worksheet.Cell(row, 2).Value = phanQuyen.tenPhanQuyen;
                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelTaiKhoan(List<TaiKhoan> listTaiKhoan)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Tên tài khoản";
                worksheet.Cell(1, 2).Value = "Mã phân quyền";
                worksheet.Cell(1, 3).Value = "Mật khẩu";
                worksheet.Cell(1, 4).Value = "Trạng thái";

                int row = 2;
                foreach (TaiKhoan taiKhoan in listTaiKhoan)
                {
                    worksheet.Cell(row, 1).Value = taiKhoan.tenTaiKhoan;
                    worksheet.Cell(row, 2).Value = taiKhoan.maPhanQuyen;
                    worksheet.Cell(row, 3).Value = taiKhoan.matKhau;
                    worksheet.Cell(row, 4).Value = taiKhoan.trangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelNhanVien(List<NhanVien> listNhanVien)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã nhân viên";
                worksheet.Cell(1, 2).Value = "Tên tài khoản";
                worksheet.Cell(1, 3).Value = "Tên nhân viên";
                worksheet.Cell(1, 4).Value = "Giới tính";
                worksheet.Cell(1, 5).Value = "Ngày sinh";
                worksheet.Cell(1, 6).Value = "Số điện thoại";
                worksheet.Cell(1, 7).Value = "Email";
                worksheet.Cell(1, 8).Value = "Địa chỉ";
                worksheet.Cell(1, 9).Value = "Trạng thái";

                int row = 2;
                foreach (NhanVien nhanVien in listNhanVien)
                {
                    worksheet.Cell(row, 1).Value = nhanVien.maNhanVien;
                    worksheet.Cell(row, 2).Value = nhanVien.tenTaiKhoan;
                    worksheet.Cell(row, 3).Value = nhanVien.hoTen;
                    worksheet.Cell(row, 4).Value = nhanVien.gioiTinh;
                    worksheet.Cell(row, 5).Value = nhanVien.ngaySinh?.ToString("dd/MM/yyyy");
                    worksheet.Cell(row, 6).Value = nhanVien.soDienThoai;
                    worksheet.Cell(row, 7).Value = nhanVien.email;
                    worksheet.Cell(row, 8).Value = nhanVien.diaChi;
                    worksheet.Cell(row, 9).Value = nhanVien.trangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelKhachHang(List<KhachHang> listKhachHang)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã khách hàng";
                worksheet.Cell(1, 2).Value = "Tên khách hàng";
                worksheet.Cell(1, 3).Value = "Giới tính";
                worksheet.Cell(1, 4).Value = "Ngày sinh";
                worksheet.Cell(1, 5).Value = "Số điện thoại";
                worksheet.Cell(1, 6).Value = "Email";
                worksheet.Cell(1, 7).Value = "Địa chỉ";
                worksheet.Cell(1, 8).Value = "Bậc thành viên";
                worksheet.Cell(1, 9).Value = "Điểm tích lũy";

                int row = 2;
                foreach (KhachHang khachHang in listKhachHang)
                {
                    worksheet.Cell(row, 1).Value = khachHang.maKhachHang;
                    worksheet.Cell(row, 2).Value = khachHang.hoTen;
                    worksheet.Cell(row, 3).Value = khachHang.gioiTinh;
                    worksheet.Cell(row, 4).Value = khachHang.ngaySinh?.ToString("dd/MM/yyyy");
                    worksheet.Cell(row, 5).Value = khachHang.soDienThoai;
                    worksheet.Cell(row, 6).Value = khachHang.email;
                    worksheet.Cell(row, 7).Value = khachHang.diaChi;
                    worksheet.Cell(row, 8).Value = khachHang.bacThanhVien;
                    worksheet.Cell(row, 9).Value = khachHang.diemTichLuy;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelNhaCungCap(List<NhaCungCap> listNhaCungCap)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã nhà cung cấp";
                worksheet.Cell(1, 2).Value = "Tên nhà cung cấp";
                worksheet.Cell(1, 3).Value = "Số điện thoại";
                worksheet.Cell(1, 4).Value = "Email";
                worksheet.Cell(1, 5).Value = "Địa chỉ";

                int row = 2;
                foreach (NhaCungCap nhaCungCap in listNhaCungCap)
                {
                    worksheet.Cell(row, 1).Value = nhaCungCap.maNhaCungCap;
                    worksheet.Cell(row, 2).Value = nhaCungCap.tenNhaCungCap;
                    worksheet.Cell(row, 3).Value = nhaCungCap.soDienThoai;
                    worksheet.Cell(row, 4).Value = nhaCungCap.email;
                    worksheet.Cell(row, 5).Value = nhaCungCap.diaChi;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelLoaiSanPham(List<LoaiSanPham> listLoaiSanPham)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã loại sản phẩm";
                worksheet.Cell(1, 2).Value = "Tên loại sản phẩm";
                worksheet.Cell(1, 3).Value = "Trạng thái";

                int row = 2;
                foreach (LoaiSanPham loaiSanPham in listLoaiSanPham)
                {
                    worksheet.Cell(row, 1).Value = loaiSanPham.maLoaiSanPham;
                    worksheet.Cell(row, 2).Value = loaiSanPham.tenLoaiSanPham;
                    worksheet.Cell(row, 3).Value = loaiSanPham.trangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelSanPham(List<SanPham> listSanPham)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã sản phẩm";
                worksheet.Cell(1, 2).Value = "Mã loại sản phẩm";
                worksheet.Cell(1, 3).Value = "Mã nhà cung cấp";
                worksheet.Cell(1, 4).Value = "Tên sản phẩm";
                worksheet.Cell(1, 5).Value = "Đơn vị tính";
                worksheet.Cell(1, 6).Value = "Số lượng";
                worksheet.Cell(1, 7).Value = "Giá bán";
                worksheet.Cell(1, 8).Value = "Trạng thái";

                int row = 2;
                foreach (SanPham sanPham in listSanPham)
                {
                    worksheet.Cell(row, 1).Value = sanPham.maSanPham;
                    worksheet.Cell(row, 2).Value = sanPham.maLoaiSanPham;
                    worksheet.Cell(row, 3).Value = sanPham.maNhaCungCap;
                    worksheet.Cell(row, 4).Value = sanPham.tenSanPham;
                    worksheet.Cell(row, 5).Value = sanPham.donViTinh;
                    worksheet.Cell(row, 6).Value = sanPham.soLuong;
                    worksheet.Cell(row, 7).Value = sanPham.giaBan;
                    worksheet.Cell(row, 8).Value = sanPham.trangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelKhuyenMai(List<KhuyenMai> listKhuyenMai)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã khuyến mãi";
                worksheet.Cell(1, 2).Value = "Tên khuyến mãi";
                worksheet.Cell(1, 3).Value = "Thời gian bắt đầu";
                worksheet.Cell(1, 4).Value = "Thời gian kết thúc";
                worksheet.Cell(1, 5).Value = "Loại giá trị";
                worksheet.Cell(1, 6).Value = "Giá trị áp dụng";

                int row = 2;
                foreach (KhuyenMai khuyenMai in listKhuyenMai)
                {
                    worksheet.Cell(row, 1).Value = khuyenMai.maKhuyenMai;
                    worksheet.Cell(row, 2).Value = khuyenMai.tenKhuyenMai;
                    worksheet.Cell(row, 3).Value = khuyenMai.thoiGianBatDau.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 4).Value = khuyenMai.thoiGianKetThuc.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 5).Value = khuyenMai.loaiGiaTri;
                    worksheet.Cell(row, 6).Value = khuyenMai.giaTriApDung;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelHoaDon(List<HoaDon> listHoaDon)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã hóa đơn";
                worksheet.Cell(1, 2).Value = "Mã nhân viên";
                worksheet.Cell(1, 3).Value = "Mã khách hàng";
                worksheet.Cell(1, 4).Value = "Mã khuyến mãi";
                worksheet.Cell(1, 5).Value = "Thời gian tạo";
                worksheet.Cell(1, 6).Value = "Tổng tiền";
                worksheet.Cell(1, 7).Value = "Giảm giá";
                worksheet.Cell(1, 8).Value = "Thành tiền";
                worksheet.Cell(1, 9).Value = "Tiền nhận";
                worksheet.Cell(1, 10).Value = "Tiền thừa";

                int row = 2;
                foreach (HoaDon hoaDon in listHoaDon)
                {
                    worksheet.Cell(row, 1).Value = hoaDon.maHoaDon;
                    worksheet.Cell(row, 2).Value = hoaDon.maNhanVien;
                    worksheet.Cell(row, 3).Value = hoaDon.maKhachHang;
                    worksheet.Cell(row, 4).Value = hoaDon.maKhuyenMai;
                    worksheet.Cell(row, 5).Value = hoaDon.thoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 6).Value = hoaDon.tongTien;
                    worksheet.Cell(row, 7).Value = hoaDon.giamGia;
                    worksheet.Cell(row, 8).Value = hoaDon.thanhTien;
                    worksheet.Cell(row, 9).Value = hoaDon.tienNhan;
                    worksheet.Cell(row, 10).Value = hoaDon.tienThua;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelPhieuNhap(List<PhieuNhap> listPhieuNhap)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã phiếu nhập";
                worksheet.Cell(1, 2).Value = "Mã nhà cung cấp";
                worksheet.Cell(1, 3).Value = "Mã nhân viên";
                worksheet.Cell(1, 4).Value = "Mã quản lí";
                worksheet.Cell(1, 5).Value = "Thời gian tạo";
                worksheet.Cell(1, 6).Value = "Thời gian duyệt";
                worksheet.Cell(1, 7).Value = "Thành tiền";
                worksheet.Cell(1, 8).Value = "Trạng thái duyệt";

                int row = 2;
                foreach (PhieuNhap phieuNhap in listPhieuNhap)
                {
                    worksheet.Cell(row, 1).Value = phieuNhap.maPhieuNhap;
                    worksheet.Cell(row, 2).Value = phieuNhap.maNhaCungCap;
                    worksheet.Cell(row, 3).Value = phieuNhap.maNhanVien;
                    worksheet.Cell(row, 4).Value = phieuNhap.maQuanLi;
                    worksheet.Cell(row, 5).Value = phieuNhap.thoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 6).Value = phieuNhap.thoiGianDuyet?.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 7).Value = phieuNhap.thanhTien;
                    worksheet.Cell(row, 8).Value = phieuNhap.trangThaiDuyet;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }
    }
}

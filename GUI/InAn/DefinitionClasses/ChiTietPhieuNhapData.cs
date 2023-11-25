using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.InAn.DefinitionClasses
{
    public class ChiTietPhieuNhapData
    {
        public ChiTietPhieuNhapData()
        {
        }

        public ChiTietPhieuNhapData(string soThuTu, string tenSanPham, string donViTinh, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.soThuTu = soThuTu;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public static DataTable GetChiTietPhieuNhapDataTable(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapBUS().LayDanhSachChiTietPhieuNhap(maPhieuNhap);

            DataTable table = new DataTable();

            table.Columns.Add("stt", typeof(int));
            table.Columns.Add("tenSanPham", typeof(string));
            table.Columns.Add("donViTinh", typeof(string));
            table.Columns.Add("soLuong", typeof(int));
            table.Columns.Add("donGia", typeof(decimal));
            table.Columns.Add("thanhTien", typeof(decimal));

            for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
            {
                DataRow row = table.NewRow();

                row["stt"] = i + 1;
                row["tenSanPham"] = new SanPhamBUS().LaySanPhamTheoMa(listChiTietPhieuNhap[i].maSanPham).tenSanPham;
                row["donViTinh"] = listChiTietPhieuNhap[i].donViTinh;
                row["soLuong"] = listChiTietPhieuNhap[i].soLuong;
                row["donGia"] = listChiTietPhieuNhap[i].donGia;
                row["thanhTien"] = listChiTietPhieuNhap[i].thanhTien;

                table.Rows.Add(row);
            }

            return table;
        }

        public string soThuTu { get; set; }
        public string tenSanPham { get; set; }
        public string donViTinh { get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien { get; set; }
    }
}

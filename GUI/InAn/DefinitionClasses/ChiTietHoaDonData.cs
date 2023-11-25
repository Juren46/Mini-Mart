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
    public class ChiTietHoaDonData
    {
        public string soThuTu {  get; set; }
        public string tenSanPham { get; set; }
        public string donViTinh { get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien { get; set; }

        public static DataTable GetChiTietHoaDonDataTable(string maHoaDon)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new ChiTietHoaDonBUS().LayDanhSachChiTietHoaDon(maHoaDon);

            DataTable table = new DataTable();

            table.Columns.Add("stt", typeof(int));
            table.Columns.Add("tenSanPham", typeof(string));
            table.Columns.Add("donViTinh", typeof(string));
            table.Columns.Add("soLuong", typeof(int));
            table.Columns.Add("donGia", typeof(decimal));
            table.Columns.Add("thanhTien", typeof(decimal));

            for(int i = 0; i < listChiTietHoaDon.Count; i++) 
            { 
                DataRow row = table.NewRow();

                row["stt"] = i + 1;
                row["tenSanPham"] = new SanPhamBUS().LaySanPhamTheoMa(listChiTietHoaDon[i].maSanPham).tenSanPham;
                row["donViTinh"] = listChiTietHoaDon[i].donViTinh;
                row["soLuong"] = listChiTietHoaDon[i].soLuong;
                row["donGia"] = listChiTietHoaDon[i].donGia;
                row["thanhTien"] = listChiTietHoaDon[i].thanhTien;

                table.Rows.Add(row);
            }

            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.OtherFunctions;
using DAO;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
namespace TestGUI
{
    public partial class TestXemSanPham : Form
    {
        List<SanPham> listSanPham;
        SanPhamBUS sanPhamBUS;
        public TestXemSanPham()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();
        }

        private void TestXemSanPham_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            sanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                sanPhamDataGridView.Rows.Add(1);
                sanPhamDataGridView.Rows[i].Cells["maSanPham"].Value = listSanPham[i].maSanPham;
                sanPhamDataGridView.Rows[i].Cells["maLoaiSanPham"].Value = listSanPham[i].maLoaiSanPham;
                sanPhamDataGridView.Rows[i].Cells["maNhaCungCap"].Value = listSanPham[i].maNhaCungCap;
                sanPhamDataGridView.Rows[i].Cells["tenSanPham"].Value = listSanPham[i].tenSanPham;
                sanPhamDataGridView.Rows[i].Cells["donViTinh"].Value = listSanPham[i].donViTinh;
                sanPhamDataGridView.Rows[i].Cells["soLuong"].Value = listSanPham[i].soLuong;
                sanPhamDataGridView.Rows[i].Cells["giaBan"].Value = listSanPham[i].giaBan.ToString("#,##0") + " VNĐ";
                sanPhamDataGridView.Rows[i].Cells["duLieuAnh"].Value = ImageHelper.ByteArrayToImage(listSanPham[i].duLieuAnh);
                sanPhamDataGridView.Rows[i].Cells["trangThai"].Value = listSanPham[i].trangThai;
            }
        }

        private void sanPhamDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô nào được double click
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SanPham sanPham = new SanPhamBUS().LaySanPhamTheoMa(sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString());

                new TestSuaSanPham(sanPham).Show();
            }
        }
    }
}

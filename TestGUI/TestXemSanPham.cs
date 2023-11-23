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
                sanPhamDataGridView.Rows[i].Cells["duLieuAnh"].Value = ByteArrayToImage(listSanPham[i].duLieuAnh);
                sanPhamDataGridView.Rows[i].Cells["trangThai"].Value = listSanPham[i].trangThai;
            }
        }

        private Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    // Thử chuyển đổi dữ liệu byte thành hình ảnh
                    try
                    {
                        Image image = Image.FromStream(memoryStream);
                        return image;
                    }
                    catch (ArgumentException ex)
                    {
                        Debug.WriteLine("Lỗi: " + ex.Message);
                        return null;
                    }
                }
            }
            else
            {
                Debug.WriteLine("Dữ liệu hình ảnh không hợp lệ!");
                return null;
            }
        }

        private void sanPhamDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô nào được double click
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                /*DataGridViewCell selectedCell = sanPhamDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Xử lý dữ liệu trong ô được double click
                if (selectedCell.Value != null)
                {
                    // Ví dụ: hiển thị giá trị của ô được double click
                    MessageBox.Show("Giá trị ô: " + selectedCell.Value.ToString());
                }*/

                SanPham sanPham = new SanPhamBUS().LaySanPhamTheoMa(sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString());

                new TestSuaSanPham(sanPham).Show();
            }
        }
    }
}

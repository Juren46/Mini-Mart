using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SanPhamForm : Form
    {
        List<SanPham> listSanPham;
        SanPhamBUS sanPhamBUS;

        public SanPhamForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listSanPham);
        }

        private void LoadDataToDataGridView(List<SanPham> listSanPham)
        {
            sanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                sanPhamDataGridView.Rows.Add(1);
                sanPhamDataGridView.Rows[i].Cells[0].Value = i + 1;
                sanPhamDataGridView.Rows[i].Cells[1].Value = listSanPham[i].maSanPham;
                sanPhamDataGridView.Rows[i].Cells[2].Value = listSanPham[i].tenSanPham;
                sanPhamDataGridView.Rows[i].Cells[3].Value = new LoaiSanPhamBUS().LayLoaiSanPhamTheoMa(listSanPham[i].maLoaiSanPham).tenLoaiSanPham;
                sanPhamDataGridView.Rows[i].Cells[4].Value = listSanPham[i].maNhaCungCap;
                sanPhamDataGridView.Rows[i].Cells[5].Value = listSanPham[i].donViTinh;
                sanPhamDataGridView.Rows[i].Cells[6].Value = listSanPham[i].soLuong;
                sanPhamDataGridView.Rows[i].Cells[7].Value = listSanPham[i].giaBan.ToString("#,##0") + " VNĐ";
            }
        }

        private void sanPhamDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex >= 0)
            {
                // Kiểm tra giá trị của cell có phải là hình ảnh không.
                if (e.Value is Image)
                {
                    // Thiết lập kích thước mới cho hình ảnh.
                    int newWidth = 25; // Kích thước mới theo chiều rộng
                    int newHeight = 25; // Kích thước mới theo chiều cao

                    // Đổi kích thước hình ảnh.
                    Image originalImage = (Image)e.Value;
                    Image resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                    // Gán hình ảnh mới vào cell.
                    e.Value = resizedImage;
                }
            }
        }

        private void sanPhamDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < sanPhamDataGridView.Columns.Count - numberOfColumnsToSkip)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Đặt màu cho đường kẻ giữa các cột (nếu không thuộc vào cột cuối cùng)
                using (Pen pen = new Pen(Color.FromArgb(242, 245, 250), 5))
                {
                    int x = e.CellBounds.Right - 1;
                    int y1 = e.CellBounds.Top;
                    int y2 = e.CellBounds.Bottom;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }

                e.Handled = true;
            }
        }

        private void sanPhamDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra số lượng dòng được chọn
            if (sanPhamDataGridView.SelectedRows.Count > 1)
            {
                // Nếu nhiều hơn 1 dòng được chọn, hiển thị nút xoá tất cả
                xoaTatCaButton.Visible = true;
            }
            else
            {
                // Nếu không có hoặc chỉ có 1 dòng được chọn, ẩn nút xoá tất cả
                xoaTatCaButton.Visible = false;
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            ChiTietSanPhamForm chitietsanphamfrom = new ChiTietSanPhamForm();
            chitietsanphamfrom.ShowDialog();
        }
    }
}

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
using System.Windows.Input;

namespace GUI
{
    public partial class LoaiSanPhamForm : Form
    {
        List<LoaiSanPham> listLoaiSanPham;
        LoaiSanPhamBUS loaiSanPhamBUS;

        public LoaiSanPhamForm()
        {
            InitializeComponent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            listLoaiSanPham = loaiSanPhamBUS.LayDanhSachLoaiSanPham();
        }

        private void LoaiSanPhamForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void LoadDataToDataGridView(List<LoaiSanPham> listLoaiSanPham)
        {
            for (int i = 0; i < listLoaiSanPham.Count; i++)
            {
                loaiSanPhamDataGridView.Rows.Add(1);
                loaiSanPhamDataGridView.Rows[i].Cells[0].Value = string.Format("{0:d3}", i + 1);
                loaiSanPhamDataGridView.Rows[i].Cells[1].Value = listLoaiSanPham[i].maLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[2].Value = listLoaiSanPham[i].tenLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[3].Value = listLoaiSanPham[i].trangThai;
            }
        }

        private void ResetDataGridView(List<LoaiSanPham> listLoaiSanPham)
        {
            loaiSanPhamDataGridView.Rows.Clear();

            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void loaiSanPhamDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6) && e.RowIndex >= 0)
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

        private void loaiSanPhamDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < loaiSanPhamDataGridView.Columns.Count - numberOfColumnsToSkip)
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

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham(tuKhoa);

            ResetDataGridView(listLoaiSanPham);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (timKiemTextBox.Text.Equals(""))
            {
                listLoaiSanPham = loaiSanPhamBUS.LayDanhSachLoaiSanPham();

                ResetDataGridView(listLoaiSanPham);
            }
        }
    }
}

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
    public partial class KhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        List<KhuyenMai> listKhuyenMai;

        public KhuyenMaiForm()
        {
            InitializeComponent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();
        }

        private void KhuyenMaiForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void LoadDataToDataGridView(List<KhuyenMai> listKhuyenMai)
        {
            khuyenMaiDataGridView.Rows.Clear();

            for (int i = 0; i < listKhuyenMai.Count; i++)
            {
                khuyenMaiDataGridView.Rows.Add(1);
                khuyenMaiDataGridView.Rows[i].Cells[0].Value = i + 1;
                khuyenMaiDataGridView.Rows[i].Cells[1].Value = listKhuyenMai[i].maKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[2].Value = listKhuyenMai[i].tenKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[3].Value = listKhuyenMai[i].thoiGianBatDau.ToString("dd/MM/yyyy");
                khuyenMaiDataGridView.Rows[i].Cells[4].Value = listKhuyenMai[i].thoiGianKetThuc.ToString("dd/MM/yyyy");
                khuyenMaiDataGridView.Rows[i].Cells[5].Value = listKhuyenMai[i].loaiGiaTri;
                khuyenMaiDataGridView.Rows[i].Cells[6].Value = listKhuyenMai[i].giaTriApDung;
            }
        }

        private void khuyenMaiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
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

        private void khuyenMaiDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < khuyenMaiDataGridView.Columns.Count - numberOfColumnsToSkip)
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
    }
}

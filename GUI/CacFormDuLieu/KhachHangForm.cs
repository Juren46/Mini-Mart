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
    public partial class KhachHangForm : Form
    {
        KhachHangBUS khachHangBUS;
        List<KhachHang> listKhachHang;

        public KhachHangForm()
        {
            InitializeComponent();

            khachHangBUS = new KhachHangBUS();
            listKhachHang = khachHangBUS.LayDanhSachKhachHang();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhachHang);
        }

        private void LoadDataToDataGridView(List<KhachHang> listKhachHang)
        {
            khachHangDataGridView.Rows.Clear();

            for (int i = 0; i < listKhachHang.Count; i++)
            {
                khachHangDataGridView.Rows.Add(1);
                khachHangDataGridView.Rows[i].Cells[0].Value = i + 1;
                khachHangDataGridView.Rows[i].Cells[1].Value = listKhachHang[i].maKhachHang;
                khachHangDataGridView.Rows[i].Cells[2].Value = listKhachHang[i].hoTen;
                khachHangDataGridView.Rows[i].Cells[3].Value = listKhachHang[i].gioiTinh;
                khachHangDataGridView.Rows[i].Cells[4].Value = listKhachHang[i].ngaySinh?.ToString("dd/MM/yyyy");
                khachHangDataGridView.Rows[i].Cells[5].Value = listKhachHang[i].soDienThoai;
                khachHangDataGridView.Rows[i].Cells[6].Value = listKhachHang[i].bacThanhVien;
                khachHangDataGridView.Rows[i].Cells[7].Value = listKhachHang[i].diemTichLuy;
            }
        }

        private void khachHangDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
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

        private void khachHangDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 2; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < khachHangDataGridView.Columns.Count - numberOfColumnsToSkip)
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

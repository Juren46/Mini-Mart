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

namespace GUI.CacFormDuLieu
{
    public partial class NhanVienForm : Form
    {
        NhanVienBUS nhanVienBUS;
        List<NhanVien> listNhanVien;

        public NhanVienForm()
        {
            InitializeComponent();

            nhanVienBUS = new NhanVienBUS();
            listNhanVien = nhanVienBUS.LayDanhSachNhanVien();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhanVien);
        }

        private void LoadDataToDataGridView(List<NhanVien> listNhanVien)
        {
            nhanVienDataGridView.Rows.Clear();

            for (int i = 0; i < listNhanVien.Count; i++)
            {
                nhanVienDataGridView.Rows.Add(1);
                nhanVienDataGridView.Rows[i].Cells[0].Value = i + 1;
                nhanVienDataGridView.Rows[i].Cells[1].Value = listNhanVien[i].maNhanVien;
                nhanVienDataGridView.Rows[i].Cells[2].Value = listNhanVien[i].tenTaiKhoan;
                nhanVienDataGridView.Rows[i].Cells[3].Value = listNhanVien[i].hoTen;
                nhanVienDataGridView.Rows[i].Cells[4].Value = listNhanVien[i].gioiTinh;
                nhanVienDataGridView.Rows[i].Cells[5].Value = listNhanVien[i].ngaySinh?.ToString("dd/MM/yyyy");
                nhanVienDataGridView.Rows[i].Cells[6].Value = listNhanVien[i].soDienThoai;
                nhanVienDataGridView.Rows[i].Cells[7].Value = listNhanVien[i].email;
                nhanVienDataGridView.Rows[i].Cells[8].Value = listNhanVien[i].diaChi;
                nhanVienDataGridView.Rows[i].Cells[9].Value = listNhanVien[i].trangThai;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ChiTietNhanVienForm chiTietNhanVienForm = new ChiTietNhanVienForm();
            chiTietNhanVienForm.ShowDialog();
        }

        private void nhanVienDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 10 || e.ColumnIndex == 11 || e.ColumnIndex == 12) && e.RowIndex >= 0)
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

        private void nhanVienDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < nhanVienDataGridView.Columns.Count - numberOfColumnsToSkip)
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

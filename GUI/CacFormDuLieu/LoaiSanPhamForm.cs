using BUS;
using BUS.OtherFunctions;
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
            loaiSanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listLoaiSanPham.Count; i++)
            {
                loaiSanPhamDataGridView.Rows.Add(1);
                loaiSanPhamDataGridView.Rows[i].Cells[0].Value = i + 1;
                loaiSanPhamDataGridView.Rows[i].Cells[1].Value = listLoaiSanPham[i].maLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[2].Value = listLoaiSanPham[i].tenLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[3].Value = listLoaiSanPham[i].trangThai;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham(tuKhoa);

            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();

            listLoaiSanPham = loaiSanPhamBUS.LayDanhSachLoaiSanPham();

            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelLoaiSanPham(listLoaiSanPham);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new chiTietLoaiSanPhamForm("Thêm", this).Show();
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {

        }

        private void loaiSanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoaiSanPham loaiSanPham = loaiSanPhamBUS.LayLoaiSanPhamTheoMa(loaiSanPhamDataGridView["maLoaiSanPhamColumn", e.RowIndex].Value.ToString());

            string columnName = loaiSanPhamDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("deleteButtonColumn"))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại sản phẩm không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string message = loaiSanPhamBUS.XoaLoaiSanPham(loaiSanPham.maLoaiSanPham);

                    MessageBox.Show(message);

                    lamMoiButton_Click(sender, e);
                }
            }

            if (columnName.Equals("infoButtonColumn"))
            {
                new chiTietLoaiSanPhamForm(loaiSanPham, "Chi tiết", this).Show();
            }

            if (columnName.Equals("editButtonColumn"))
            {
                new chiTietLoaiSanPhamForm(loaiSanPham, "Sửa", this).Show();
            }
        }

        private void sanPhamDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra số lượng dòng được chọn
            if (loaiSanPhamDataGridView.SelectedRows.Count > 1)
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
    }
}

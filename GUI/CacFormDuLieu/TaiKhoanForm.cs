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

namespace GUI
{
    public partial class TaiKhoanForm : Form
    {
        TaiKhoanBUS taiKhoanBUS;
        List<TaiKhoan> listTaiKhoan;

        public TaiKhoanForm()
        {
            InitializeComponent();

            taiKhoanBUS = new TaiKhoanBUS();
            listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();
        }


        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listTaiKhoan);
        }

        private void LoadDataToDataGridView(List<TaiKhoan> listTaiKhoan)
        {
            taiKhoanDataGridView.Rows.Clear();

            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                taiKhoanDataGridView.Rows.Add(1);
                taiKhoanDataGridView.Rows[i].Cells[0].Value = i + 1;
                taiKhoanDataGridView.Rows[i].Cells[1].Value = listTaiKhoan[i].tenTaiKhoan;
                taiKhoanDataGridView.Rows[i].Cells[2].Value = new PhanQuyenBUS().LayPhanQuyenTheoMa(listTaiKhoan[i].maPhanQuyen).tenPhanQuyen;
                taiKhoanDataGridView.Rows[i].Cells[3].Value = listTaiKhoan[i].matKhau;
                taiKhoanDataGridView.Rows[i].Cells[4].Value = listTaiKhoan[i].trangThai;
            }
        }
        private void sanPhamDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7) && e.RowIndex >= 0)
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

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < taiKhoanDataGridView.Columns.Count - numberOfColumnsToSkip)
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();

            LoadDataToDataGridView(listTaiKhoan);
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listTaiKhoan = taiKhoanBUS.TimKiemTaiKhoan(tuKhoa);

            LoadDataToDataGridView(listTaiKhoan);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            List<string> listTenTaiKhoan = new List<string>();
            for (int i = 0; i < taiKhoanDataGridView.Rows.Count; i++)
            {
                listTenTaiKhoan.Add(taiKhoanDataGridView.Rows[i].Cells[1].Value.ToString());
            }
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();
            foreach (string tenTaiKhoan in listTenTaiKhoan)
            {
                TaiKhoan taiKhoan = taiKhoanBUS.LayTaiKhoanTheoTen(tenTaiKhoan);
                listTaiKhoan.Add(taiKhoan);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelTaiKhoan(listTaiKhoan);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

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
    public partial class PhanQuyenForm : Form
    {
        List<PhanQuyen> listPhanQuyen;
        PhanQuyenBUS phanQuyenBUS;
        public PhanQuyenForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += PhanQuyenForm_KeyDown;

            phanQuyenBUS = new PhanQuyenBUS();
            listPhanQuyen = phanQuyenBUS.LayDanhSachPhanQuyen();

            LoadDataToDataGridView(listPhanQuyen);
        }

        private void LoadDataToDataGridView(List<PhanQuyen> listPhanQuyen)
        {
            dgvPhanQuyen.Rows.Clear();
            for (int i = 0; i < listPhanQuyen.Count; i++)
            {
                dgvPhanQuyen.Rows.Add(1);
                dgvPhanQuyen.Rows[i].Cells[0].Value = i + 1;
                dgvPhanQuyen.Rows[i].Cells[1].Value = listPhanQuyen[i].maPhanQuyen;
                dgvPhanQuyen.Rows[i].Cells[2].Value = listPhanQuyen[i].tenPhanQuyen;
            }
        }

        private void phanQuyenDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5) && e.RowIndex >= 0)
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

        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < dgvPhanQuyen.Columns.Count - numberOfColumnsToSkip)
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
            timKiemTextBox.Clear();

            listPhanQuyen = phanQuyenBUS.LayDanhSachPhanQuyen();

            LoadDataToDataGridView(listPhanQuyen);
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listPhanQuyen = phanQuyenBUS.TimKiemPhanQuyen(tuKhoa);

            LoadDataToDataGridView(listPhanQuyen);
        }

        private void PhanQuyenForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && timKiemTextBox.Text.Length > 0)
            {
                timKiemButton_Click(sender, e);
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            List<string> listMaPhanQuyen = new List<string>();
            for (int i = 0; i < dgvPhanQuyen.Rows.Count; i++)
            {
                listMaPhanQuyen.Add(dgvPhanQuyen.Rows[i].Cells[1].Value.ToString());
            }
            List<PhanQuyen> listPhanQuyen = new List<PhanQuyen>();
            foreach (string maPhanQuyen in listMaPhanQuyen)
            {
                PhanQuyen phanQuyen = phanQuyenBUS.LayPhanQuyenTheoMa(maPhanQuyen);
                listPhanQuyen.Add(phanQuyen);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelPhanQuyen(listPhanQuyen);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

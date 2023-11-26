using BUS;
using BUS.OtherFunctions;
using DocumentFormat.OpenXml.Wordprocessing;
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
        List<PhanQuyen> listPhanQuyen;

        public TaiKhoanForm()
        {
            InitializeComponent();

            taiKhoanBUS = new TaiKhoanBUS();
            listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();
            listPhanQuyen = new PhanQuyenBUS().LayDanhSachPhanQuyen();
        }


        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listTaiKhoan);


            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;
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

        private void phanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedIndex != -1)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                string maPhanQuyen = phanQuyen.maPhanQuyen;

                listTaiKhoan = taiKhoanBUS.TimKiemTaiKhoan("", maPhanQuyen, "");

                LoadDataToDataGridView(listTaiKhoan);
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string maPhanQuyen = "";
            if (phanQuyenComboBox.SelectedValue != null)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                maPhanQuyen = phanQuyen.maPhanQuyen;
            }
            string trangThai = "";  //CHỜ CHUYỂN TOGGLE SWITCH TRẠNG THÁI THÀNH COMBO BOX
            /*if (trangThaiComboBox.SelectedValue != null)
            {
                trangThai = trangThaiComboBox.SelectedItem;
            }*/

            listTaiKhoan = taiKhoanBUS.TimKiemTaiKhoan(tuKhoa, maPhanQuyen, trangThai);

            LoadDataToDataGridView(listTaiKhoan);
        }


        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        private void lamMoiButton_Click(object sender, EventArgs e)
        {
            phanQuyenComboBox.SelectedItem = null;
            phanQuyenComboBox.SelectedIndex = -1;
            timKiemTextBox.Clear();

            listTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();

            LoadDataToDataGridView(listTaiKhoan);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
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

        private void themMoiButton_Click(object sender, EventArgs e)
        {

        }

        private void taiKhoanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == taiKhoanDataGridView.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string tenTaiKhoan = taiKhoanDataGridView.Rows[e.RowIndex].Cells["tenTaiKhoanColumn"].Value.ToString();

                    MessageBox.Show(taiKhoanBUS.XoaTaiKhoan(tenTaiKhoan));

                    lamMoiButton_Click(sender, e);
                }
            }
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {

        }

        private void taiKhoanDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void taiKhoanDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < taiKhoanDataGridView.Columns.Count - numberOfColumnsToSkip)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Đặt màu cho đường kẻ giữa các cột (nếu không thuộc vào cột cuối cùng)
                using (Pen pen = new Pen(System.Drawing.Color.FromArgb(242, 245, 250), 5))
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

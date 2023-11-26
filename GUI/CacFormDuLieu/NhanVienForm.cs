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

namespace GUI.CacFormDuLieu
{
    public partial class NhanVienForm : Form
    {
        NhanVienBUS nhanVienBUS;
        List<NhanVien> listNhanVien;
        List<PhanQuyen> listPhanQuyen;

        public NhanVienForm()
        {
            InitializeComponent();

            nhanVienBUS = new NhanVienBUS();
            listNhanVien = nhanVienBUS.LayDanhSachNhanVien();
            listPhanQuyen = new PhanQuyenBUS().LayDanhSachPhanQuyen();
            foreach (PhanQuyen phanQuyen in listPhanQuyen)
            {
                if (!phanQuyen.maPhanQuyen.Equals("PQ03") && !phanQuyen.maPhanQuyen.Equals("PQ04"))
                    listPhanQuyen.Remove(phanQuyen);
            }
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhanVien);

            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;
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
                nhanVienDataGridView.Rows[i].Cells[4].Value = new PhanQuyenBUS().LayPhanQuyenTheoTenTaiKhoan(listNhanVien[i].tenTaiKhoan).tenPhanQuyen;
                nhanVienDataGridView.Rows[i].Cells[5].Value = listNhanVien[i].gioiTinh;
                nhanVienDataGridView.Rows[i].Cells[6].Value = listNhanVien[i].ngaySinh?.ToString("dd/MM/yyyy");
                nhanVienDataGridView.Rows[i].Cells[7].Value = listNhanVien[i].trangThai;
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
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
            string trangThai = "";
            if (trangThaiToggleSwitch.Checked)
                trangThai = "TRUE";
            else
                trangThai = "FALSE";

            listNhanVien = nhanVienBUS.TimKiemNhanVien(tuKhoa, maPhanQuyen, trangThai);

            LoadDataToDataGridView(listNhanVien);
        }

        private void lamMoiButton_Click(object sender, EventArgs e)
        {
            phanQuyenComboBox.SelectedItem = null;
            phanQuyenComboBox.SelectedIndex = -1;
            timKiemTextBox.Clear();

            listNhanVien = nhanVienBUS.LayDanhSachNhanVien();

            LoadDataToDataGridView(listNhanVien);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                new XuatExcel(filePath).XuatExcelNhanVien(listNhanVien);

                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new ChiTietNhanVienForm("Thêm", this).Show();
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nhanVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanVien = nhanVienBUS.LayNhanVienTheoMa(nhanVienDataGridView["maNhanVienColumn", e.RowIndex].Value.ToString());

            string columnName = nhanVienDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("deleteButtonColumn"))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string message = nhanVienBUS.XoaNhanVien(nhanVien.maNhanVien);

                    MessageBox.Show(message);

                    lamMoiButton_Click(sender, e);
                }
            }

            if (columnName.Equals("infoButtonColumn"))
            {
                new ChiTietNhanVienForm(nhanVien, "Chi tiết", this).Show();
            }

            if (columnName.Equals("editButtonColumn"))
            {
                new ChiTietNhanVienForm(nhanVien, "Sửa", this).Show();
            }
        }

        private void phanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedIndex != -1)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                string maPhanQuyen = phanQuyen.maPhanQuyen;

                listNhanVien = nhanVienBUS.TimKiemNhanVien("", maPhanQuyen, "");

                LoadDataToDataGridView(listNhanVien);
            }
        }

        private void nhanVienDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex >= 0)
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

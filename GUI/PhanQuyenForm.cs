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

       

        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

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
            if (e.KeyCode == Keys.Enter)
            {
                timKiemButton_Click(sender, e);
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }
    }
}

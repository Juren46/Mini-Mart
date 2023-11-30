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

namespace GUI.CacFormChon
{
    public partial class ChonLoaiSanPham : Form
    {
        LoaiSanPhamBUS loaiSanPhamBUS;
        List<LoaiSanPham> listLoaiSanPham;
        ChiTietSanPhamForm form;

        public ChonLoaiSanPham(ChiTietSanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();
            loaiSanPhamBUS = new LoaiSanPhamBUS();
            listLoaiSanPham = loaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.form = form;
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TestChonLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void LoadDataToDataGridView(List<LoaiSanPham> listLoaiSanPham)
        {
            loaiSanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listLoaiSanPham.Count; i++)
            {
                loaiSanPhamDataGridView.Rows.Add(1);
                loaiSanPhamDataGridView.Rows[i].Cells[0].Value = listLoaiSanPham[i].maLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[1].Value = listLoaiSanPham[i].tenLoaiSanPham;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham(tuKhoa, "");

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

        private void loaiSanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoaiSanPham loaiSanPham = loaiSanPhamBUS.LayLoaiSanPhamTheoMa(loaiSanPhamDataGridView["maLoaiSanPhamColumn", e.RowIndex].Value.ToString());

            string columnName = loaiSanPhamDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("chonLoaiSanPhamButtonColumn"))
            {
                form.loaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                this.Close();
            }
        }
        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

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

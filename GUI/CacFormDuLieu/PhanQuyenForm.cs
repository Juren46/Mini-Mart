﻿using BUS;
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
        PhanQuyenBUS phanQuyenBUS;
        List<PhanQuyen> listPhanQuyen;

        public PhanQuyenForm()
        {
            InitializeComponent();

            phanQuyenBUS = new PhanQuyenBUS();
            listPhanQuyen = phanQuyenBUS.LayDanhSachPhanQuyen();
        }

        private void PhanQuyenForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listPhanQuyen);
        }

        private void LoadDataToDataGridView(List<PhanQuyen> listPhanQuyen)
        {
            phanQuyenDataGridView.Rows.Clear();

            for (int i = 0; i < listPhanQuyen.Count; i++)
            {
                phanQuyenDataGridView.Rows.Add(1);
                phanQuyenDataGridView.Rows[i].Cells[0].Value = i + 1;
                phanQuyenDataGridView.Rows[i].Cells[1].Value = listPhanQuyen[i].maPhanQuyen;
                phanQuyenDataGridView.Rows[i].Cells[2].Value = listPhanQuyen[i].maPhanQuyen;
            }
        }

        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < phanQuyenDataGridView.Columns.Count - numberOfColumnsToSkip)
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

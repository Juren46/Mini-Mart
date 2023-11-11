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
    public partial class SanPhamForm : Form
    {
        public SanPhamForm()
        {
            InitializeComponent();
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[0].Cells[1].Value = "DCT12190";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Bánh mì susu";
            guna2DataGridView1.Rows[0].Cells[3].Value = "thực phẩm";
            guna2DataGridView1.Rows[0].Cells[4].Value = "ABC bakery";
            guna2DataGridView1.Rows[0].Cells[5].Value = "gói";
            guna2DataGridView1.Rows[0].Cells[6].Value = "10";
            guna2DataGridView1.Rows[0].Cells[7].Value = "10.000";

            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[1].Cells[1].Value = "DCT12190";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Bánh mì susu";
            guna2DataGridView1.Rows[1].Cells[3].Value = "thực phẩm";
            guna2DataGridView1.Rows[1].Cells[4].Value = "ABC bakery";
            guna2DataGridView1.Rows[1].Cells[5].Value = "gói";
            guna2DataGridView1.Rows[1].Cells[6].Value = "10";
            guna2DataGridView1.Rows[1].Cells[7].Value = "10.000";

            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[3].Cells[1].Value = "DCT12190";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Bánh mì susu";
            guna2DataGridView1.Rows[3].Cells[3].Value = "thực phẩm";
            guna2DataGridView1.Rows[3].Cells[4].Value = "ABC bakery";
            guna2DataGridView1.Rows[3].Cells[5].Value = "gói";
            guna2DataGridView1.Rows[3].Cells[6].Value = "10";
            guna2DataGridView1.Rows[3].Cells[7].Value = "10.000";

            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[4].Cells[1].Value = "DCT12190";
            guna2DataGridView1.Rows[4].Cells[2].Value = "Bánh mì susu";
            guna2DataGridView1.Rows[4].Cells[3].Value = "thực phẩm";
            guna2DataGridView1.Rows[4].Cells[4].Value = "ABC bakery";
            guna2DataGridView1.Rows[4].Cells[5].Value = "gói";
            guna2DataGridView1.Rows[4].Cells[6].Value = "10";
            guna2DataGridView1.Rows[4].Cells[7].Value = "10.000";

            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[5].Cells[1].Value = "DCT12190";
            guna2DataGridView1.Rows[5].Cells[2].Value = "Bánh mì susu";
            guna2DataGridView1.Rows[5].Cells[3].Value = "thực phẩm";
            guna2DataGridView1.Rows[5].Cells[4].Value = "ABC bakery";
            guna2DataGridView1.Rows[5].Cells[5].Value = "gói";
            guna2DataGridView1.Rows[5].Cells[6].Value = "10";
            guna2DataGridView1.Rows[5].Cells[7].Value = "10.000";


        }

        private void guna2DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < guna2DataGridView1.Columns.Count - numberOfColumnsToSkip)
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

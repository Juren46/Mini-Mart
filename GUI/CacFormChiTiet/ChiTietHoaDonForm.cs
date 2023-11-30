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

namespace GUI.CacFormChiTiet
{
    public partial class ChiTietHoaDonForm : Form
    {
        HoaDonBUS hoaDonBUS;
        HoaDon hoaDon;
        ChiTietHoaDonBUS chiTietHoaDonBUS;
        List<ChiTietHoaDon> listChiTietHoaDon;
        public ChiTietHoaDonForm(string maHoaDon)
        {
            InitializeComponent();
            CenterToParent();
            hoaDonBUS = new HoaDonBUS();
            chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            hoaDon = hoaDonBUS.LayHoaDonTheoMa(maHoaDon);
        }
        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < chiTietHoaDonDataGridView.Columns.Count - numberOfColumnsToSkip)
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

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
    public partial class DonDatHangControl : UserControl
    {
        SanPham sanPham;
        public DonDatHangControl(SanPham sanPham)
        {
            InitializeComponent();

            this.sanPham = sanPham;
        }

        private void DonDatHangControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            tongGiaLabel.Text = sanPham.giaBan.ToString("#,##0") + " VNĐ";
        }

        private void soLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tongGiaLabel.Text = (sanPham.giaBan * soLuongNumericUpDown.Value).ToString("#,##0") + " VNĐ";
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;

            if (parent != null)
            {
                parent.Controls.Remove(this);
            }
        }
    }
}

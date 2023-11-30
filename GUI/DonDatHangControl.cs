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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class DonDatHangControl : UserControl
    {
        internal SanPham sanPham;
        BanHangForm banHangForm;

        public DonDatHangControl(SanPham sanPham, BanHangForm banHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.banHangForm = banHangForm;
        }

        private void DonDatHangControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            tongGiaLabel.Text = sanPham.giaBan.ToString("#,##0") + " VNĐ";

            TinhTien();
        }

        private void TinhTien()
        {
            decimal tongTien = 0;
            foreach (Control control in banHangForm.chiTietDonHangFlowLayoutPanel.Controls)
            {
                if (control is DonDatHangControl)
                {
                    DonDatHangControl donDatHangControl = (DonDatHangControl)control;
                    decimal tongGia = Decimal.Parse((donDatHangControl.tongGiaLabel.Text.Where(char.IsDigit).ToArray()));
                    tongTien += tongGia;
                }
            }
            decimal giamGia = Decimal.Parse((banHangForm.chietKhauLabel.Text.Where(char.IsDigit).ToArray()));
            decimal thanhTien = tongTien - giamGia;

            banHangForm.tongTienLabel.Text = tongTien.ToString("#,##0") + " VNĐ";
            banHangForm.thanhTienLabel.Text = thanhTien.ToString("#,##0") + " VNĐ";
        }

        private void soLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tongGiaLabel.Text = (sanPham.giaBan * soLuongNumericUpDown.Value).ToString("#,##0") + " VNĐ";

            TinhTien();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            banHangForm.listSanPhamDonHang.Remove(sanPham);
            banHangForm.chiTietDonHangFlowLayoutPanel.Controls.Remove(this);

            TinhTien();

            this.Dispose();
        }
    }
}

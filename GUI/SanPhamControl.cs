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
    public partial class SanPhamControl : UserControl
    {
        SanPham sanPham;
        BanHangForm form;
        public SanPhamControl(SanPham sanPham, BanHangForm form)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.form = form;
        }

        private void SanPhamControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            giaBanLabel.Text = sanPham.giaBan.ToString("#,##0") + " VNĐ";
            anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
        }

        private void chonButton_Click(object sender, EventArgs e)
        {
            form.chiTietDonHangFlowLayoutPanel.Controls.Add(new DonDatHangControl(sanPham));
        }
    }
}

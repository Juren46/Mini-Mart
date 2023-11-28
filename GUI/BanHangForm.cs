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
    public partial class BanHangForm : Form
    {
        SanPhamBUS sanPhamBUS;
        List<SanPham> listSanPham;
        public BanHangForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            foreach(SanPham sanPham in listSanPham)
            {
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamControl(sanPham, this));
            }           
        }
    }
}

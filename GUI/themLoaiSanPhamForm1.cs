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
    public partial class themLoaiSanPhamForm1 : Form
    {
        LoaiSanPham loaiSanPham;
        public themLoaiSanPhamForm1(LoaiSanPham loaiSanPham)
        {
            InitializeComponent();
            CenterToParent();

            this.loaiSanPham = loaiSanPham;
        }

        private void themLoaiSanPhamForm1_Load(object sender, EventArgs e)
        {
            txtMaSanPham.Text = loaiSanPham.maLoaiSanPham;
            txtTenSanPham.Text = loaiSanPham.tenLoaiSanPham;

        }
    }
}

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
    public partial class chiTietLoaiSanPhamForm : Form
    {
        LoaiSanPham loaiSanPham;
        string context;
        public chiTietLoaiSanPhamForm(LoaiSanPham loaiSanPham, string context)
        {
            InitializeComponent();
            CenterToParent();

            this.loaiSanPham = loaiSanPham;
            this.context = context;
        }

        public chiTietLoaiSanPhamForm(string context)
        {
            InitializeComponent();
            CenterToParent();

            this.context = context;
        }

        private void themLoaiSanPhamForm1_Load(object sender, EventArgs e)
        {
            if (context.Equals("Chi tiết"))
            {
                txtMaSanPham.Text = loaiSanPham.maLoaiSanPham;
                txtTenSanPham.Text = loaiSanPham.tenLoaiSanPham;

                txtMaSanPham.Enabled = false;
                txtTenSanPham.Enabled = false;
            }

            if (context.Equals("Thêm"))
            {
                txtMaSanPham.Text = IDGenerator.GenerateLoaiSanPhamID();
                txtMaSanPham.Enabled = false;
            }

            if (context.Equals("Sửa"))
            {
                txtMaSanPham.Text = loaiSanPham.maLoaiSanPham;
                txtTenSanPham.Text = loaiSanPham.tenLoaiSanPham;

                txtMaSanPham.Enabled = false;
            }
        }
    }
}

using BUS.OtherFunctions;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.context = context;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void themLoaiSanPhamForm1_Load(object sender, EventArgs e)
        {
            if (context.Equals("Chi tiết"))
            {
                txtMaSanPham.Text = loaiSanPham.maLoaiSanPham;
                txtTenSanPham.Text = loaiSanPham.tenLoaiSanPham;

                txtMaSanPham.ReadOnly = true;
                txtTenSanPham.ReadOnly = true;
                btnHuyBo.Visible = false;
                btnLuu.Visible = false;
                this.Size = new System.Drawing.Size(656, 230);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

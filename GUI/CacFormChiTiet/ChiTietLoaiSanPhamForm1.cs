using BUS;
using BUS.OtherFunctions;
using DTO;
using Guna.UI2.WinForms;
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
        LoaiSanPhamBUS loaiSanPhamBUS;
        LoaiSanPhamForm form;

        public chiTietLoaiSanPhamForm(LoaiSanPham loaiSanPham, string context, LoaiSanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            this.loaiSanPham = loaiSanPham;
            this.context = context;
            this.form = form;
        }

        public chiTietLoaiSanPhamForm(string context, LoaiSanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            this.context = context;
            this.form = form;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void chiTietLoaiSanPhamForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.tenLoaiSanPham;
                    //CHỜ THÊM TRẠNG THÁI

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    tenLoaiSanPhamTextBox.ReadOnly = true;
                    luuButton.Visible = false;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = IDGenerator.GenerateLoaiSanPhamID();

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    //CHỜ THÊM TRẠNG THÁI
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chi tiết loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.tenLoaiSanPham;
                    //CHỜ THÊM TRẠNG THÁI

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    break;
            }
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            string maLoaiSanPham = maLoaiSanPhamTextBox.Text;
            string tenLoaiSanPham = tenLoaiSanPhamTextBox.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn lưu loại sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                switch (context)
                {
                    case "Thêm":
                        MessageBox.Show(loaiSanPhamBUS.ThemLoaiSanPham(maLoaiSanPham, tenLoaiSanPham));
                        break;

                    case "Sửa":
                        MessageBox.Show(loaiSanPhamBUS.SuaLoaiSanPham(maLoaiSanPham, tenLoaiSanPham));
                        break;
                }

                form.lamMoiButton_Click(sender, e);
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

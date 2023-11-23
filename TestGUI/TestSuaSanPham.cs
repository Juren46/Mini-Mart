using BUS.OtherFunctions;
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class TestSuaSanPham : Form
    {
        SanPham sanPham;

        public TestSuaSanPham(SanPham sanPham)
        {
            InitializeComponent();
            
            this.sanPham = sanPham;
        }

        private void TestSuaSanPham_Load(object sender, EventArgs e)
        {
            maSanPhamTextBox.Text = sanPham.maSanPham;
            maLoaiSanPhamTextBox.Text = sanPham.maLoaiSanPham;
            maNhaCungCapTextBox.Text = sanPham.maNhaCungCap;
            tenSanPhamTextBox.Text = sanPham.tenSanPham;
            donViTinhTextBox.Text = sanPham.donViTinh;
            giaBanTextBox.Text = sanPham.giaBan.ToString();
            pictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = new Bitmap(openFileDialog.FileName);

                // Scale ảnh theo kích thước của PictureBox
                pictureBox.Image = ImageHelper.ScaleImage(selectedImage, pictureBox.Width, pictureBox.Height);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string maSanPham = maSanPhamTextBox.Text;
            string maLoaiSanPham = maLoaiSanPhamTextBox.Text;
            string maNhaCungCap = maNhaCungCapTextBox.Text;
            string tenSanPham = tenSanPhamTextBox.Text;
            string donViTinh = donViTinhTextBox.Text;
            string giaBan = giaBanTextBox.Text;
            byte[] duLieuAnh = ImageHelper.ImageToByteArray(pictureBox.Image);

            string message = new SanPhamBUS().SuaSanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, giaBan, duLieuAnh);

            MessageBox.Show(message);
        }
    }
}

using BUS;
using BUS.OtherFunctions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class TestThemSanPham : Form
    {
        public TestThemSanPham()
        {
            InitializeComponent();
        }

        private void TestThemSanPham_Load(object sender, EventArgs e)
        {
            maSanPhamTextBox.Text = IDGenerator.GenerateSanPhamID();
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

            string message = new SanPhamBUS().ThemSanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, giaBan, duLieuAnh);

            MessageBox.Show(message);

            maSanPhamTextBox.Text = IDGenerator.GenerateSanPhamID();
            maLoaiSanPhamTextBox.Clear();
            maNhaCungCapTextBox.Clear();
            tenSanPhamTextBox.Clear();
            donViTinhTextBox.Clear();
            giaBanTextBox.Clear();
            pictureBox.Image = null;
        }
    }
}

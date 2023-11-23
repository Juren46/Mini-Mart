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
            pictureBox.Image = ByteArrayToImage(sanPham.duLieuAnh);

        }

        private Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    // Thử chuyển đổi dữ liệu byte thành hình ảnh
                    try
                    {
                        Image image = Image.FromStream(memoryStream);
                        return image;
                    }
                    catch (ArgumentException ex)
                    {
                        Debug.WriteLine("Lỗi: " + ex.Message);
                        return null;
                    }
                }
            }
            else
            {
                Debug.WriteLine("Dữ liệu hình ảnh không hợp lệ!");
                return null;
            }
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}

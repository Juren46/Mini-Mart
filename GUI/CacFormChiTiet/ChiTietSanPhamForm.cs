using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormChon;
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
    public partial class ChiTietSanPhamForm : Form
    {
        SanPhamBUS sanPhamBUS;
        SanPham sanPham;
        string context;
        SanPhamForm form;

        public ChiTietSanPhamForm(SanPham sanPham, string context, SanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            sanPhamBUS = new SanPhamBUS();
            this.sanPham = sanPham;
            this.context = context;
            this.form = form;
        }

        public ChiTietSanPhamForm(string context, SanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            sanPhamBUS = new SanPhamBUS();
            this.context = context;
            this.form = form;
        }

        private void ChiTietSanPhamForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết sản phẩm";

                    maSanPhamTextBox.Text = sanPham.maSanPham;
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    loaiSanPhamTextBox.Text = sanPham.maLoaiSanPham;
                    nhaCungCapTextBox.Text = sanPham.maNhaCungCap;
                    donViTextBox.Text = sanPham.donViTinh;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ScaleImage(ImageHelper.ByteArrayToImage(sanPham.duLieuAnh), anhSanPhamPictureBox.Width, anhSanPhamPictureBox.Height);

                    maSanPhamTextBox.ReadOnly = true;
                    tenSanPhamTextBox.ReadOnly = true;
                    loaiSanPhamTextBox.ReadOnly = true;
                    nhaCungCapTextBox.ReadOnly = true;
                    donViTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;
                    giaBanTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    chonAnhButton.Visible = false;
                    chonLoaiSanPhamButton.Visible = false;
                    chonNhaCungCapButton.Visible = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm sản phẩm";

                    maSanPhamTextBox.Text = IDGenerator.GenerateSanPhamID();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Chờ xử lý"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;
                    trangThaiComboBox.Enabled = false;
                    loaiSanPhamTextBox.ReadOnly = true;
                    nhaCungCapTextBox.ReadOnly = true;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin sản phẩm";

                    maSanPhamTextBox.Text = sanPham.maSanPham;
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    loaiSanPhamTextBox.Text = sanPham.maLoaiSanPham;
                    nhaCungCapTextBox.Text = sanPham.maNhaCungCap;
                    donViTextBox.Text = sanPham.donViTinh;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;
                    trangThaiComboBox.Enabled = false;
                    loaiSanPhamTextBox.ReadOnly = true;
                    nhaCungCapTextBox.ReadOnly = true;

                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chonAnhButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = new Bitmap(openFileDialog.FileName);

                anhSanPhamPictureBox.Image = ImageHelper.ScaleImage(selectedImage, anhSanPhamPictureBox.Width, anhSanPhamPictureBox.Height);
            }
        }

        private void chonLoaiSanPhamButton_Click(object sender, EventArgs e)
        {
            new TestChonLoaiSanPham(this).Show();
        }

        private void chonNhaCungCapButton_Click(object sender, EventArgs e)
        {
            new TestChonNhaCungCap(this).Show();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    loaiSanPhamTextBox.Text = sanPham.maLoaiSanPham;
                    nhaCungCapTextBox.Text = sanPham.maNhaCungCap;
                    donViTextBox.Text = sanPham.donViTinh;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
                }
                else if (context.Equals("Thêm"))
                {
                    tenSanPhamTextBox.Clear();
                    loaiSanPhamTextBox.Clear();
                    nhaCungCapTextBox.Clear();
                    donViTextBox.Clear();
                    giaBanTextBox.Clear();
                    anhSanPhamPictureBox.Image = null;
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string maSanPham = maSanPhamTextBox.Text;
                string tenSanPham = tenSanPhamTextBox.Text;
                string maLoaiSanPham = loaiSanPhamTextBox.Text;
                string maNhaCungCap = nhaCungCapTextBox.Text;
                string donVi = nhaCungCapTextBox.Text;
                string giaBan = giaBanTextBox.Text;
                byte[] duLieuAnh;
                try
                {
                    duLieuAnh = ImageHelper.ImageToByteArray(anhSanPhamPictureBox.Image);
                }
                catch 
                {
                    duLieuAnh = sanPham.duLieuAnh;
                }

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = sanPhamBUS.ThemSanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donVi, giaBan, duLieuAnh);
                        break;
                    case "Sửa":
                        message = sanPhamBUS.SuaSanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donVi, giaBan, duLieuAnh);
                        break;
                }

                MessageBox.Show(message);

                if (message.Equals("Thêm sản phẩm thành công!") || message.Equals("Chỉnh sửa thông tin sản phẩm thành công!"))
                {
                    form.lamMoiButton_Click(sender, e);

                    this.Close();
                }
            }
        }
    }
}

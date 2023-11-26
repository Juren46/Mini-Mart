using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormDuLieu;
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
    public partial class ChiTietNhanVienForm : Form
    {
        NhanVien nhanVien;
        NhanVienBUS nhanVienBUS;
        string context;
        NhanVienForm form;

        public ChiTietNhanVienForm(NhanVien nhanVien, string context, NhanVienForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhanVienBUS = new NhanVienBUS();
            this.nhanVien = nhanVien;
            this.context = context;
        }

        public ChiTietNhanVienForm(string context, NhanVienForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhanVienBUS = new NhanVienBUS();
            this.context = context;
        }

        private void ChiTietNhanVienForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết nhân viên";

                    maNhanVienTextBox.Text = nhanVien.maNhanVien;
                    tenTaiKhoanTextBox.Text = nhanVien.tenTaiKhoan;
                    tenNhanVienTextBox.Text = nhanVien.hoTen;
                    phanQuyenTextBox.Text = new PhanQuyenBUS().LayPhanQuyenTheoTenTaiKhoan(nhanVien.tenTaiKhoan).tenPhanQuyen;
                    if (nhanVien.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else
                        nuRadioButton.Checked = true;
                    if (nhanVien.ngaySinh != null)
                    {
                        ngaySinhDateTimePicker.Checked = true;
                        ngaySinhDateTimePicker.Value = nhanVien.ngaySinh.Value;
                    }
                    soDienThoaiTextBox.Text = nhanVien.soDienThoai;
                    emailTextBox.Text = nhanVien.email;
                    diaChiTextBox.Text = nhanVien.diaChi;
                    trangThaiToggleSwitch.Checked = nhanVien.trangThai;

                    maNhanVienTextBox.ReadOnly = true;
                    tenTaiKhoanTextBox.ReadOnly = true;
                    phanQuyenTextBox.ReadOnly = true;
                    tenNhanVienTextBox.ReadOnly = true;
                    namRadioButton.Enabled = false;
                    nuRadioButton.Enabled = false;
                    ngaySinhDateTimePicker.Enabled = false;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    trangThaiToggleSwitch.Enabled = false;

                    chonTaiKhoanButton.Visible = false;
                    luuButton.Visible = false;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm nhân viên";

                    maNhanVienTextBox.ReadOnly = true;
                    tenTaiKhoanTextBox.ReadOnly= true;
                    phanQuyenTextBox.ReadOnly = true;

                    trangThaiToggleSwitch.Visible = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin nhân viên";

                    maNhanVienTextBox.Text = nhanVien.maNhanVien;
                    tenTaiKhoanTextBox.Text = nhanVien.tenTaiKhoan;
                    tenNhanVienTextBox.Text = nhanVien.hoTen;
                    phanQuyenTextBox.Text = new PhanQuyenBUS().LayPhanQuyenTheoTenTaiKhoan(nhanVien.tenTaiKhoan).tenPhanQuyen;
                    if (nhanVien.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else
                        nuRadioButton.Checked = true;
                    if (nhanVien.ngaySinh != null)
                    {
                        ngaySinhDateTimePicker.Checked = true;
                        ngaySinhDateTimePicker.Value = nhanVien.ngaySinh.Value;
                    }
                    soDienThoaiTextBox.Text = nhanVien.soDienThoai;
                    emailTextBox.Text = nhanVien.email;
                    diaChiTextBox.Text = nhanVien.diaChi;
                    trangThaiToggleSwitch.Checked = nhanVien.trangThai;

                    maNhanVienTextBox.ReadOnly = true;
                    phanQuyenTextBox.ReadOnly = true;
                    tenTaiKhoanTextBox.ReadOnly = true;
                    trangThaiToggleSwitch.Enabled = false;
                    chonTaiKhoanButton.Visible = false;
                    tenNhanVienTextBox.ReadOnly = true;
                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            /*string maNhanVien = maNhanVienTextBox.Text;
            string tenNhanVien = tenNhanVienTextBox.Text;
            string tenTaiKhoan = tenTaiKhoanTextBox.Text;
            string gioiTinh = "";
            if (namRadioButton.Checked)
                gioiTinh = "Nam";
            if (nuRadioButton.Checked)
                gioiTinh = "Nữ";

            DialogResult result = MessageBox.Show("Bạn có muốn lưu loại sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo);

            string message = "";

            if (result == DialogResult.Yes)
            {
                switch (context)
                {
                    case "Thêm":
                        message = loaiSanPhamBUS.ThemLoaiSanPham(maLoaiSanPham, tenLoaiSanPham);
                        MessageBox.Show(message);
                        break;

                    case "Sửa":
                        message = loaiSanPhamBUS.SuaLoaiSanPham(maLoaiSanPham, tenLoaiSanPham);
                        MessageBox.Show(message);
                        break;
                }

                if (message.Equals("Thêm loại sản phẩm thành công!") || message.Equals("Sửa thông tin loại sản phẩm thành công!"))
                {
                    form.lamMoiButton_Click(sender, e);
                    this.Close();
                }
            }*/
        }

        private void chonTaiKhoanButton_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using BUS;
using DTO;
using FontAwesome.Sharp;
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
    public partial class TrangChuForm : Form
    {
        TaiKhoanBUS taiKhoanBUS;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public TrangChuForm()
        {
            InitializeComponent();
            CenterToScreen();

            taiKhoanBUS = new TaiKhoanBUS();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void HideSideMenu()
        {
            btnBanHang.Visible = false;
            btnSanPham.Visible = false;
            btnKhuyenMai.Visible = false;
            btnNhanVien.Visible = false;
            btnPhieuNhap.Visible = false;
            btnThongKe.Visible = false;
            btnLoaiSanPham.Visible = false;
            btnKhachHang.Visible = false;
            btnHoaDon.Visible = false;
            btnPhanQuyen.Visible = false;
            btnNhaCungCap.Visible = false;
            btnTaiKhoan.Visible = false;
        }

        private void HienThiSideMenuTheoPhanQuyen()
        {
            switch (DangNhapForm.taiKhoan.maPhanQuyen)
            {
                case "PQ01":
                    btnPhanQuyen.Visible = true;
                    btnTaiKhoan.Visible = true;
                    break;

                case "PQ02":
                    btnNhanVien.Visible = true;
                    btnSanPham.Visible = true;
                    btnLoaiSanPham.Visible = true;
                    btnNhaCungCap.Visible = true;
                    btnPhieuNhap.Visible = true;
                    btnHoaDon.Visible = true;
                    btnKhuyenMai.Visible = true;
                    btnKhachHang.Visible = true;
                    btnThongKe.Visible = true;
                    break;

                case "PQ03":
                    btnBanHang.Visible = true;
                    btnSanPham.Visible = true;
                    btnLoaiSanPham.Visible = true;
                    btnKhuyenMai.Visible = true;
                    btnHoaDon.Visible = true;
                    break;

                case "PQ04":
                    btnSanPham.Visible = true;
                    btnLoaiSanPham.Visible = true;
                    btnNhaCungCap.Visible = true;
                    btnPhieuNhap.Visible = true;
                    break;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 192, 203);
            //Màu hồng phấn
            public static Color color2 = Color.FromArgb(255, 255, 255);
            //Màu xanh phấn
            public static Color color3 = Color.FromArgb(255, 245, 179);
            //Màu vàng phấn
            public static Color color4 = Color.FromArgb(186, 255, 186);
            //Màu xanh lá phấn
            public static Color color5 = Color.FromArgb(255, 180, 125);
            //Màu cam phấn
            public static Color color6 = Color.FromArgb(221, 160, 221);
            //Màu tím phấn
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 71, 107);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 79, 111);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new SanPhamForm());
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new LoaiSanPhamForm());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new TaiKhoanForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void dangXuatButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                DangNhapForm dangNhap = new DangNhapForm();
                dangNhap.Show();
            }
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            HideSideMenu();
            HienThiSideMenuTheoPhanQuyen();

            switch (DangNhapForm.taiKhoan.maPhanQuyen)
            {
                case "PQ01":
                    tenNguoiDungLabel.Text = new AdminBUS().LayAdminTheoTenTaiKhoan(DangNhapForm.taiKhoan.tenTaiKhoan).hoTen;
                    break;

                case "PQ02":
                    tenNguoiDungLabel.Text = new QuanLiBUS().LayQuanLiTheoTenTaiKhoan(DangNhapForm.taiKhoan.tenTaiKhoan).hoTen;
                    break;

                case "PQ03":
                    tenNguoiDungLabel.Text = new NhanVienBUS().LayNhanVienTheoTenTaiKhoan(DangNhapForm.taiKhoan.tenTaiKhoan).hoTen;
                    break;

                case "PQ04":
                    tenNguoiDungLabel.Text = new NhanVienBUS().LayNhanVienTheoTenTaiKhoan(DangNhapForm.taiKhoan.tenTaiKhoan).hoTen;
                    break;
            }

            tenPhanQuyenLabel.Text = new PhanQuyenBUS().LayPhanQuyenTheoMa(DangNhapForm.taiKhoan.maPhanQuyen).tenPhanQuyen;
        }
    }
}

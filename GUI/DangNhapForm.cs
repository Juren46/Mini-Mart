using BUS;
using DTO;
using GUI.CacFormThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GUI
{
    public partial class DangNhapForm : Form
    {
        public static TaiKhoan taiKhoan;
        TaiKhoanBUS taiKhoanBUS;
        public DangNhapForm()
        {
            InitializeComponent();
            CenterToScreen();

            taiKhoanBUS = new TaiKhoanBUS();

            this.KeyPreview = true;
            this.KeyDown += DangNhapForm_KeyDown;
        }

        private void DangNhapForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhapButton_Click(sender, e);
            }
        }

        private void tenTaiKhoanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar == ' ' || !char.IsAscii(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void matKhauTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar == ' ' || !char.IsAscii(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dangNhapButton_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = tenTaiKhoanTextBox.Text.Trim();
            string matKhau = matKhauTextBox.Text.Trim();

            string message = taiKhoanBUS.KiemTraDangNhap(tenTaiKhoan, matKhau);

           

            CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);

            if (message.Equals("Đăng nhập thành công!"))
            {
                DangNhapForm.taiKhoan = taiKhoanBUS.LayTaiKhoanTheoTen(tenTaiKhoan);
                TrangChuForm form = new TrangChuForm();
                form.Show();

                this.Hide();
            }
            else
            {
                tenTaiKhoanTextBox.BorderColor = Color.Red;
                matKhauTextBox.BorderColor = Color.Red;
            }
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ImageCheckBox1.Checked == true)
            {
                matKhauTextBox.PasswordChar = '\0';
                matKhauTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                matKhauTextBox.PasswordChar = '●';
                matKhauTextBox.UseSystemPasswordChar = true;
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

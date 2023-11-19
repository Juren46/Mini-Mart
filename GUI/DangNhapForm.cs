using BUS;
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

            Console.WriteLine(message);

            MessageBox.Show(message);

            if (message.Equals("Đăng nhập thành công!"))
            {
                DangNhapForm.taiKhoan = taiKhoanBUS.LayTaiKhoanTheoTen(tenTaiKhoan);
                LoadingForm form = new LoadingForm();
                form.Show();
                this.Hide();
            }
        }
    }
}

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

namespace GUI.CacFormChiTiet
{
    public partial class TestChiTietTaiKhoanForm : Form
    {
        TaiKhoanBUS taiKhoanBUS;
        TaiKhoan taiKhoan;
        TaiKhoanForm form;
        string context;
        List<PhanQuyen> listPhanQuyen;

        public TestChiTietTaiKhoanForm(TaiKhoan taiKhoan, TaiKhoanForm form, string context)
        {
            InitializeComponent();
            CenterToParent();

            taiKhoanBUS = new TaiKhoanBUS();
            this.taiKhoan = taiKhoan;
            this.form = form;
            this.context = context;
            listPhanQuyen = new PhanQuyenBUS().LayDanhSachPhanQuyen();
            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
        }

        public TestChiTietTaiKhoanForm(TaiKhoanForm form, string context)
        {
            InitializeComponent();
            CenterToParent();

            taiKhoanBUS = new TaiKhoanBUS();
            this.form = form;
            this.context = context;
            listPhanQuyen = new PhanQuyenBUS().LayDanhSachPhanQuyen();
            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
        }

        private void TestChiTietTaiKhoanForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết tài khoản";
                    tenTaiKhoanTextBox.Text = taiKhoan.tenTaiKhoan;
                    matKhauTextBox.Text = taiKhoan.matKhau;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(taiKhoan.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;
                        if (phanQuyen.maPhanQuyen.Equals(taiKhoan.maPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    phanQuyenComboBox.Enabled = false;
                    trangThaiComboBox.Enabled = false;
                    tenTaiKhoanTextBox.ReadOnly = true;
                    matKhauTextBox.ReadOnly = true;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm tài khoản";
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Chờ xử lý"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    phanQuyenComboBox.SelectedIndex = -1;

                    trangThaiComboBox.Enabled = false;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin tài khoản";
                    tenTaiKhoanTextBox.Text = taiKhoan.tenTaiKhoan;
                    matKhauTextBox.Text = taiKhoan.matKhau;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(taiKhoan.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;
                        if (phanQuyen.maPhanQuyen.Equals(taiKhoan.maPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    phanQuyenComboBox.Enabled = false;
                    tenTaiKhoanTextBox.ReadOnly = true;

                    break;
            }
        }

        private void dongButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenTaiKhoanTextBox.Text = taiKhoan.tenTaiKhoan;
                    matKhauTextBox.Text = taiKhoan.matKhau;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(taiKhoan.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;
                        if (phanQuyen.maPhanQuyen.Equals(taiKhoan.maPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (context.Equals("Thêm"))
                {
                    tenTaiKhoanTextBox.Clear();
                    matKhauTextBox.Clear();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Chờ xử lý"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    phanQuyenComboBox.SelectedIndex = -1;
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string tenTaiKhoan = tenTaiKhoanTextBox.Text;
                string matKhau = matKhauTextBox.Text;
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                string maPhanQuyen = phanQuyen.maPhanQuyen;
                string trangThai = trangThaiComboBox.SelectedItem.ToString();

                if (context.Equals("Thêm"))
                {
                    string message = taiKhoanBUS.ThemTaiKhoan(maPhanQuyen, tenTaiKhoan, matKhau);

                    MessageBox.Show(message);

                    if (message.Equals("Thêm tài khoản thành công!"))
                    {
                        form.lamMoiButton_Click(sender, e);

                        this.Close();
                    }
                }
                    
                else if (context.Equals("Sửa"))
                {
                    string message = taiKhoanBUS.SuaTaiKhoan(tenTaiKhoan, matKhau, trangThai);

                    MessageBox.Show(message);

                    if (message.Equals("Chỉnh sửa thông tin tài khoản thành công!"))
                    {
                        form.lamMoiButton_Click(sender, e);

                        this.Close();
                    }
                }
            }
        }
    }
}
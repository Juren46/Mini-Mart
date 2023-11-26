using BUS;
using BUS.OtherFunctions;
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

namespace GUI
{
    public partial class ChiTietNhaCungCapForm : Form
    {
        NhaCungCap nhaCungCap;
        string context;
        NhaCungCapBUS nhaCungCapBUS;
        NhaCungCapForm form;

        public ChiTietNhaCungCapForm(NhaCungCap nhaCungCap, string context, NhaCungCapForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhaCungCapBUS = new NhaCungCapBUS();
            this.nhaCungCap = nhaCungCap;
            this.context = context;
            this.form = form;
        }

        public ChiTietNhaCungCapForm(string context, NhaCungCapForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhaCungCapBUS = new NhaCungCapBUS();
            this.context = context;
            this.form = form;
        }

        private void ChiTietNhaCungCapForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết nhà cung cấp";

                    maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.soDienThoai;
                    emailTextBox.Text = nhaCungCap.email;
                    diaChiTextBox.Text = nhaCungCap.diaChi;

                    maNhaCungCapTextBox.ReadOnly = true;
                    tenNhaCungCapTextBox.ReadOnly = true;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    luuButton.Visible = false;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm nhà cung cấp";

                    maNhaCungCapTextBox.Text = IDGenerator.GenerateNhaCungCapID();

                    maNhaCungCapTextBox.ReadOnly = true;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin nhà cung cấp";

                    maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.soDienThoai;
                    emailTextBox.Text = nhaCungCap.email;
                    diaChiTextBox.Text = nhaCungCap.diaChi;

                    maNhaCungCapTextBox.ReadOnly = true;
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
            string maNhaCungCap = maNhaCungCapTextBox.Text;
            string tenNhaCungCap = tenNhaCungCapTextBox.Text;
            string soDienThoai = soDienThoaiTextBox.Text;
            string email = emailTextBox.Text;
            string diaChi = diaChiTextBox.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin nhà cung cấp không?", "Xác nhận", MessageBoxButtons.YesNo);

            string message = "";

            if (result == DialogResult.Yes)
            {
                switch (context)
                {
                    case "Thêm":
                        message = nhaCungCapBUS.ThemNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);
                        MessageBox.Show(message);
                        break;

                    case "Sửa":
                        message = nhaCungCapBUS.SuaNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);
                        MessageBox.Show(message);
                        break;
                }

                if (message.Equals("Thêm nhà cung cấp thành công!") || message.Equals("Sửa thông tin nhà cung cấp thành công!"))
                {
                    form.lamMoiButton_Click(sender, e);
                    this.Close();
                }
            }
        }
    }
}

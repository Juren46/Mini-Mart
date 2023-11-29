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

namespace GUI.CacFormChiTiet
{
    public partial class TestChiTietKhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        KhuyenMai khuyenMai;
        KhuyenMaiForm khuyenMaiForm;
        string context;

        public TestChiTietKhuyenMaiForm(KhuyenMai khuyenMai, string context, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.khuyenMai = khuyenMai;
            this.khuyenMaiForm = khuyenMaiForm;
            this.context = context;
        }

        public TestChiTietKhuyenMaiForm(string context, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.khuyenMaiForm = khuyenMaiForm;
            this.context = context;
        }

        public TestChiTietKhuyenMaiForm()
        {
        }

        private void TestChiTietKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết khuyến mãi";

                    maKhuyenMaiTextBox.Text = khuyenMai.maKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTriApDung.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;
                    tenKhuyenMaiTextBox.ReadOnly = true;
                    phanTramRadioButton.Enabled = false;
                    cuTheRadioButton.Enabled = false;
                    giaTriKhuyenMaiTextBox.ReadOnly = true;
                    thoiGianBatDauDateTimePicker.Enabled = false;
                    thoiGianBatDauTimePicker.Enabled = false;
                    thoiGianKetThucDateTimePicker.Enabled = false;
                    thoiGianKetThucTimePicker.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm khuyến mãi";

                    maKhuyenMaiTextBox.Text = IDGenerator.GenerateKhuyenMaiID();

                    maKhuyenMaiTextBox.ReadOnly = true;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin khuyến mãi";

                    maKhuyenMaiTextBox.Text = khuyenMai.maKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTriApDung.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;

                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
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
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTriApDung.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;
                }
                else if (context.Equals("Thêm"))
                {
                    tenKhuyenMaiTextBox.Clear();
                    phanTramRadioButton.Checked = false;
                    cuTheRadioButton.Checked = false;
                    giaTriKhuyenMaiTextBox.Clear();
                    thoiGianBatDauDateTimePicker.Value = DateTime.Now;
                    thoiGianKetThucDateTimePicker.Value = DateTime.Now;
                    thoiGianBatDauTimePicker.Value = DateTime.Now;
                    thoiGianKetThucTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin khuyến mãi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string maKhuyenMai = maKhuyenMaiTextBox.Text;
                string tenKhuyenMai = tenKhuyenMaiTextBox.Text;
                string loaiGiaTri = "";
                if (phanTramRadioButton.Checked)
                    loaiGiaTri = "Phần trăm";
                if (cuTheRadioButton.Checked)
                    loaiGiaTri = "Cụ thể";
                string giaTriApDung = giaTriKhuyenMaiTextBox.Text;
                string thoiGianBatDau = thoiGianBatDauDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
                string thoiGianKetThuc = thoiGianKetThucDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = khuyenMaiBUS.ThemKhuyenMai(maKhuyenMai, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung);
                        break;
                    case "Sửa":
                        message = khuyenMaiBUS.SuaKhuyenMai(maKhuyenMai, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung);
                        break;
                }

                MessageBox.Show(message);

                if (message.Equals("Thêm khuyến mãi thành công!") || message.Equals("Chỉnh sửa thông tin khuyến mãi thành công!"))
                {
                    khuyenMaiForm.lamMoiButton_Click(sender, e);

                    this.Close();
                }
            }
        }
    }
}

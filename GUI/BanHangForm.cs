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

namespace GUI
{
    public partial class BanHangForm : Form
    {
        SanPhamBUS sanPhamBUS;
        List<SanPham> listSanPham;
        internal List<SanPham> listSanPhamDonHang;
        internal KhachHang khachHang;

        public BanHangForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();
            listSanPhamDonHang = new List<SanPham>();
            loaiSanPhamComboBox.DataSource = new LoaiSanPhamBUS().LayDanhSachLoaiSanPham();
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToFlowLayout(listSanPham);
        }

        private void LoadDataToFlowLayout(List<SanPham> listSanPham)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in sanPhamFlowLayoutPanel.Controls)
            {
                controlsToRemove.Add(control);
            }

            foreach (Control control in controlsToRemove)
            {
                sanPhamFlowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }

            foreach (SanPham sanPham in listSanPham)
            {
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamControl(sanPham, this));
            }
        }

        private void timKiemSanPhamButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemSanPhamTextBox.Text;
            string maLoaiSanPham = "";
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.maLoaiSanPham;
            }

            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, maLoaiSanPham, "", "", "");

            LoadDataToFlowLayout(listSanPham);
        }

        private void timKiemSanPhamTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemSanPhamButton_Click(sender, e);
        }

        private void loaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                timKiemSanPhamTextBox.Clear();
                timKiemSanPhamButton_Click(sender, e);
            }
        }

        private void lamMoiSanPhamButton_Click(object sender, EventArgs e)
        {
            timKiemSanPhamTextBox.Clear();
            loaiSanPhamComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedIndex = -1;

            listSanPham = sanPhamBUS.LayDanhSachSanPham();

            LoadDataToFlowLayout(listSanPham);
        }

        private void timKiemKhachHangButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemKhachHangTextBox.Text;
            List<KhachHang> listKhachHang = new KhachHangBUS().TimKiemKhachHang(tuKhoa, "", "");
            if (listKhachHang.Count == 1 && listKhachHang[0].soDienThoai.Equals(tuKhoa))
            {
                khachHang = listKhachHang[0];
                tenKhachHangLabel.Text = khachHang.hoTen;
                soDienThoaiLabel.Text = khachHang.soDienThoai;
                bacThanhVienLabel.Text = khachHang.bacThanhVien;
                diemTichLuyLabel.Text = khachHang.diemTichLuy.ToString();
            }
        }

        private void timKiemKhachHangTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemKhachHangButton_Click(sender, e);
        }

        private void lamMoiKhachHangButton_Click(object sender, EventArgs e)
        {
            khachHang = null;
            timKiemKhachHangTextBox.Clear();
            tenKhachHangLabel.Text = string.Empty;
            soDienThoaiLabel.Text = string.Empty;
            bacThanhVienLabel.Text = string.Empty;
            diemTichLuyLabel.Text = "0";
            if (khuyenMaiThanhVienButton.Checked)
            {
                khuyenMaiThanhVienButton.Checked = false;
                tenKhuyenMaiLabel.Text = string.Empty;
            }
        }

        private void TinhTien()
        {
            decimal tongTien = 0;
            foreach (Control control in chiTietDonHangFlowLayoutPanel.Controls)
            {
                if (control is DonDatHangControl)
                {
                    DonDatHangControl donDatHangControl = (DonDatHangControl)control;
                    decimal tongGia = Decimal.Parse((donDatHangControl.tongGiaLabel.Text.Where(char.IsDigit).ToArray()));
                    tongTien += tongGia;
                }
            }
            decimal giamGia = Decimal.Parse((chietKhauLabel.Text.Where(char.IsDigit).ToArray()));
            decimal thanhTien = tongTien - giamGia;

            tongTienLabel.Text = tongTien.ToString("#,##0") + " VNĐ";
            thanhTienLabel.Text = thanhTien.ToString("#,##0") + " VNĐ";
        }

        private void khuyenMaiThanhVienButton_CheckedChanged(object sender, EventArgs e)
        {
            if (khuyenMaiThanhVienButton.Checked && khachHang != null)
            {
                decimal tongTien = Decimal.Parse((tongTienLabel.Text.Where(char.IsDigit).ToArray()));
                decimal giamGia = new KhachHangBUS().GiamGiaThanhVien(khachHang.maKhachHang, tongTien.ToString("0"));
                chietKhauLabel.Text = giamGia.ToString("#,##0") + " VNĐ";
                thanhTienLabel.Text = (tongTien - giamGia).ToString("#,##0") + " VNĐ";
                switch (khachHang.bacThanhVien)
                {
                    case "Đồng":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng đồng 2% tổng hóa đơn!)";
                        break;
                    case "Bạc":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng bạc 3% tổng hóa đơn!)";
                        break;
                    case "Vàng":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng vàng 5% tổng hóa đơn!)";
                        break;
                }
            }
            else
            {
                chietKhauLabel.Text = "0 VNĐ";
                thanhTienLabel.Text = tongTienLabel.Text;
                tenKhuyenMaiLabel.Text = string.Empty;
            }
        }

        private void lamMoiKhuyenMaiButton_Click(object sender, EventArgs e)
        {
            khuyenMaiThanhVienButton.Checked = false;
            khuyenMaiKhacButton.Checked = false;
        }
    }
}

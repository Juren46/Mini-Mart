using BUS;
using BUS.OtherFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class TestExcel : Form
    {
        public TestExcel()
        {
            InitializeComponent();
        }



        private void excelBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                /*new XuatExcel(filePath).XuatExcelPhanQuyen(new PhanQuyenBUS().LayDanhSachPhanQuyen());*/
                /*new XuatExcel(filePath).XuatExcelTaiKhoan(new TaiKhoanBUS().LayDanhSachTaiKhoan());*/
                /*new XuatExcel(filePath).XuatExcelNhanVien(new NhanVienBUS().LayDanhSachNhanVien());*/
                /*new XuatExcel(filePath).XuatExcelKhachHang(new KhachHangBUS().LayDanhSachKhachHang());*/
                //new XuatExcel(filePath).XuatExcelNhaCungCap(new NhaCungCapBUS().LayDanhSachNhaCungCap());
                /*new XuatExcel(filePath).XuatExcelLoaiSanPham(new LoaiSanPhamBUS().LayDanhSachLoaiSanPham());*/
                //new XuatExcel(filePath).XuatExcelSanPham(new SanPhamBUS().LayDanhSachSanPham());
                //new XuatExcel(filePath).XuatExcelKhuyenMai(new KhuyenMaiBUS().LayDanhSachKhuyenMai());
               /* new XuatExcel(filePath).XuatExcelHoaDon(new HoaDonBUS().LayDanhSachHoaDon());*/
                new XuatExcel(filePath).XuatExcelPhieuNhap(new PhieuNhapBUS().LayDanhSachPhieuNhap());
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

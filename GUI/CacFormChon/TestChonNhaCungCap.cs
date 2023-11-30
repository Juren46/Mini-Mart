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

namespace GUI.CacFormChon
{
    public partial class TestChonNhaCungCap : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;
        ChiTietSanPhamForm chiTietSanPhamForm;
        NhapHangForm nhapHangForm;

        public TestChonNhaCungCap(ChiTietSanPhamForm chiTietSanPhamForm)
        {
            InitializeComponent();
            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();
            this.chiTietSanPhamForm = chiTietSanPhamForm;
        }

        public TestChonNhaCungCap(NhapHangForm nhapHangForm)
        {
            InitializeComponent();
            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();
            this.nhapHangForm = nhapHangForm;
        }

        private void TestChonNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            nhaCungCapDataGridView.Rows.Clear();

            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                nhaCungCapDataGridView.Rows.Add(1);
                nhaCungCapDataGridView.Rows[i].Cells[0].Value = listNhaCungCap[i].maNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[1].Value = listNhaCungCap[i].tenNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[2].Value = listNhaCungCap[i].soDienThoai;
                nhaCungCapDataGridView.Rows[i].Cells[3].Value = listNhaCungCap[i].email;
                nhaCungCapDataGridView.Rows[i].Cells[4].Value = listNhaCungCap[i].diaChi;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(tuKhoa);

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();

            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void nhaCungCapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < nhaCungCapDataGridView.Rows.Count - 1) 
            {
                NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(nhaCungCapDataGridView["maNhaCungCapColumn", e.RowIndex].Value.ToString());

                string columnName = nhaCungCapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chonNhaCungCapButtonColumn"))
                {
                    if (nhapHangForm != null)
                    {
                        nhapHangForm.nhaCungCap = nhaCungCap;
                        nhapHangForm.listSanPham = new SanPhamBUS().TimKiemSanPham("", "", nhaCungCap.maNhaCungCap, "", "");
                        nhapHangForm.maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                        nhapHangForm.tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                        nhapHangForm.canhBaoLabel.Visible = false;
                    }
                        
                    if (chiTietSanPhamForm != null)
                        chiTietSanPhamForm.nhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                    this.Close();
                }
            }
        }
    }
}

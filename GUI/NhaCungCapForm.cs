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
    public partial class NhaCungCapForm : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;

        public NhaCungCapForm()
        {
            InitializeComponent();

            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            dgvNhaCungCap.Rows.Clear();
            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                dgvNhaCungCap.Rows.Add(1);
                dgvNhaCungCap.Rows[i].Cells[0].Value = i + 1;
                dgvNhaCungCap.Rows[i].Cells[1].Value = listNhaCungCap[i].maNhaCungCap;
                dgvNhaCungCap.Rows[i].Cells[2].Value = listNhaCungCap[i].tenNhaCungCap;
                dgvNhaCungCap.Rows[i].Cells[3].Value = listNhaCungCap[i].soDienThoai;
                dgvNhaCungCap.Rows[i].Cells[4].Value = listNhaCungCap[i].email;
                dgvNhaCungCap.Rows[i].Cells[5].Value = listNhaCungCap[i].diaChi;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;

            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(tuKhoa);

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void NhaCungCapForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnNhapXuatExcel_Click(object sender, EventArgs e)
        {
            List<string> listMaNhaCungCap = new List<string>();
            for (int i = 0; i < dgvNhaCungCap.Rows.Count; i++)
            {
                listMaNhaCungCap.Add(dgvNhaCungCap.Rows[i].Cells[1].Value.ToString());
            }
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
            foreach (string maNhaCungCap in listMaNhaCungCap)
            {
                NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(maNhaCungCap);
                listNhaCungCap.Add(nhaCungCap);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelNhaCungCap(listNhaCungCap);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

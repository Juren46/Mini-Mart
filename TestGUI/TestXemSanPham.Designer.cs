namespace TestGUI
{
    partial class TestXemSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sanPhamDataGridView = new DataGridView();
            maSanPham = new DataGridViewTextBoxColumn();
            maLoaiSanPham = new DataGridViewTextBoxColumn();
            maNhaCungCap = new DataGridViewTextBoxColumn();
            tenSanPham = new DataGridViewTextBoxColumn();
            donViTinh = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            giaBan = new DataGridViewTextBoxColumn();
            duLieuAnh = new DataGridViewImageColumn();
            trangThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).BeginInit();
            SuspendLayout();
            // 
            // sanPhamDataGridView
            // 
            sanPhamDataGridView.AllowUserToAddRows = false;
            sanPhamDataGridView.AllowUserToDeleteRows = false;
            sanPhamDataGridView.AllowUserToOrderColumns = true;
            sanPhamDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sanPhamDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sanPhamDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            sanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, soLuong, giaBan, duLieuAnh, trangThai });
            sanPhamDataGridView.Dock = DockStyle.Fill;
            sanPhamDataGridView.Location = new Point(0, 0);
            sanPhamDataGridView.Name = "sanPhamDataGridView";
            sanPhamDataGridView.Size = new Size(1188, 498);
            sanPhamDataGridView.TabIndex = 0;
            sanPhamDataGridView.CellDoubleClick += sanPhamDataGridView_CellDoubleClick;
            // 
            // maSanPham
            // 
            maSanPham.HeaderText = "Mã sản phẩm";
            maSanPham.Name = "maSanPham";
            // 
            // maLoaiSanPham
            // 
            maLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            maLoaiSanPham.Name = "maLoaiSanPham";
            // 
            // maNhaCungCap
            // 
            maNhaCungCap.HeaderText = "Mã nhà cung cấp";
            maNhaCungCap.Name = "maNhaCungCap";
            // 
            // tenSanPham
            // 
            tenSanPham.HeaderText = "Tên sản phẩm";
            tenSanPham.Name = "tenSanPham";
            // 
            // donViTinh
            // 
            donViTinh.HeaderText = "Đơn vị tính";
            donViTinh.Name = "donViTinh";
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số lượng";
            soLuong.Name = "soLuong";
            // 
            // giaBan
            // 
            giaBan.HeaderText = "Giá bán";
            giaBan.Name = "giaBan";
            // 
            // duLieuAnh
            // 
            duLieuAnh.HeaderText = "Dữ liệu ảnh";
            duLieuAnh.Name = "duLieuAnh";
            // 
            // trangThai
            // 
            trangThai.HeaderText = "Trạng thái";
            trangThai.Name = "trangThai";
            // 
            // TestXemSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 498);
            Controls.Add(sanPhamDataGridView);
            Name = "TestXemSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestXemSanPham";
            Load += TestXemSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView sanPhamDataGridView;
        private DataGridViewTextBoxColumn maSanPham;
        private DataGridViewTextBoxColumn maLoaiSanPham;
        private DataGridViewTextBoxColumn maNhaCungCap;
        private DataGridViewTextBoxColumn tenSanPham;
        private DataGridViewTextBoxColumn donViTinh;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn giaBan;
        private DataGridViewImageColumn duLieuAnh;
        private DataGridViewTextBoxColumn trangThai;
    }
}
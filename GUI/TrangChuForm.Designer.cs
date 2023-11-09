namespace GUI
{
    partial class TrangChuForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnLoaiSanPham = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            btnPhieuNhap = new FontAwesome.Sharp.IconButton();
            btnBanHang = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            btnKhoHang = new FontAwesome.Sharp.IconButton();
            btnKhachhang = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 79, 111);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnLoaiSanPham);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnKhuyenMai);
            panelMenu.Controls.Add(btnPhieuNhap);
            panelMenu.Controls.Add(btnBanHang);
            panelMenu.Controls.Add(btnNhaCungCap);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnKhoHang);
            panelMenu.Controls.Add(btnKhachhang);
            panelMenu.CustomizableEdges = customizableEdges3;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(5);
            panelMenu.Name = "panelMenu";
            panelMenu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelMenu.Size = new Size(201, 861);
            panelMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(0, 79, 111);
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnThongKe.IconColor = Color.White;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.IconSize = 40;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(3, 653);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 20, 0);
            btnThongKe.Size = new Size(198, 50);
            btnThongKe.TabIndex = 15;
            btnThongKe.Text = "Thống kê ";
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnLoaiSanPham.IconColor = Color.White;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.IconSize = 40;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(3, 595);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 20, 0);
            btnLoaiSanPham.Size = new Size(198, 50);
            btnLoaiSanPham.TabIndex = 16;
            btnLoaiSanPham.Text = "Loại sản phẩm";
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(0, 79, 111);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnNhanVien.IconColor = Color.White;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.IconSize = 40;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(3, 537);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 20, 0);
            btnNhanVien.Size = new Size(198, 50);
            btnNhanVien.TabIndex = 14;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.BackColor = Color.FromArgb(0, 79, 111);
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhuyenMai.ForeColor = Color.White;
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnKhuyenMai.IconColor = Color.White;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.IconSize = 40;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(3, 479);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(198, 50);
            btnKhuyenMai.TabIndex = 13;
            btnKhuyenMai.Text = "Khuyến mãi ";
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = false;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.FromArgb(0, 79, 111);
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnPhieuNhap.IconColor = Color.White;
            btnPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhieuNhap.IconSize = 40;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(0, 421);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 20, 0);
            btnPhieuNhap.Size = new Size(198, 50);
            btnPhieuNhap.TabIndex = 11;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += iconButton4_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.FromArgb(0, 79, 111);
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnBanHang.IconColor = Color.White;
            btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBanHang.IconSize = 40;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 131);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 20, 0);
            btnBanHang.Size = new Size(198, 50);
            btnBanHang.TabIndex = 7;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += iconButton1_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(0, 79, 111);
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnNhaCungCap.IconColor = Color.White;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 40;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(0, 363);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 20, 0);
            btnNhaCungCap.Size = new Size(198, 50);
            btnNhaCungCap.TabIndex = 12;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += iconButton5_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(0, 79, 111);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            btnHoaDon.IconColor = Color.White;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.IconSize = 40;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 189);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 20, 0);
            btnHoaDon.Size = new Size(198, 50);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Hoá đơn";
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += iconButton3_Click;
            // 
            // btnKhoHang
            // 
            btnKhoHang.BackColor = Color.FromArgb(0, 79, 111);
            btnKhoHang.FlatAppearance.BorderSize = 0;
            btnKhoHang.FlatStyle = FlatStyle.Flat;
            btnKhoHang.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhoHang.ForeColor = Color.White;
            btnKhoHang.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnKhoHang.IconColor = Color.White;
            btnKhoHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhoHang.IconSize = 40;
            btnKhoHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoHang.Location = new Point(0, 305);
            btnKhoHang.Name = "btnKhoHang";
            btnKhoHang.Padding = new Padding(10, 0, 20, 0);
            btnKhoHang.Size = new Size(198, 50);
            btnKhoHang.TabIndex = 10;
            btnKhoHang.Text = "Kho hàng";
            btnKhoHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhoHang.UseVisualStyleBackColor = false;
            btnKhoHang.Click += iconButton6_Click;
            // 
            // btnKhachhang
            // 
            btnKhachhang.BackColor = Color.FromArgb(0, 79, 111);
            btnKhachhang.FlatAppearance.BorderSize = 0;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachhang.ForeColor = Color.White;
            btnKhachhang.IconChar = FontAwesome.Sharp.IconChar.User;
            btnKhachhang.IconColor = Color.White;
            btnKhachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachhang.IconSize = 40;
            btnKhachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachhang.Location = new Point(0, 247);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Padding = new Padding(10, 0, 20, 0);
            btnKhachhang.Size = new Size(198, 50);
            btnKhachhang.TabIndex = 8;
            btnKhachhang.Text = "Khách hàng";
            btnKhachhang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachhang.UseVisualStyleBackColor = false;
            btnKhachhang.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 107);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(201, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 40);
            panel1.TabIndex = 1;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton9);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(iconButton7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1012, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 40);
            panel2.TabIndex = 0;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = Color.FromArgb(128, 171, 196);
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton9.IconSize = 20;
            iconButton9.Location = new Point(63, 9);
            iconButton9.Name = "iconButton9";
            iconButton9.Padding = new Padding(0, 3, 0, 0);
            iconButton9.Size = new Size(45, 25);
            iconButton9.TabIndex = 11;
            iconButton9.UseVisualStyleBackColor = false;
            iconButton9.Click += btnMaximize_Click;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.LightPink;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton8.IconSize = 20;
            iconButton8.Location = new Point(114, 9);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(0, 3, 0, 0);
            iconButton8.Size = new Size(45, 25);
            iconButton8.TabIndex = 9;
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += btnExit_Click;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(155, 203, 171);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton7.IconSize = 20;
            iconButton7.Location = new Point(12, 9);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(0, 3, 0, 0);
            iconButton7.Size = new Size(45, 25);
            iconButton7.TabIndex = 10;
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Click += btnMinimize_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(0, 71, 107);
            iconCurrentChildForm.Dock = DockStyle.Left;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(0, 0);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Padding = new Padding(10, 0, 0, 0);
            iconCurrentChildForm.Size = new Size(89, 40);
            iconCurrentChildForm.SizeMode = PictureBoxSizeMode.CenterImage;
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(201, 40);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1183, 821);
            panelDesktop.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1384, 861);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "TrangChuForm";
            Text = "TrangChuForm";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private FontAwesome.Sharp.IconButton btnKhachhang;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnPhieuNhap;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnKhoHang;
        private Panel panel1;
        private Panel panelDesktop;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
    }
}
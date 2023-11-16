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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelNav = new Guna.UI2.WinForms.Guna2Panel();
            panelMenu = new Panel();
            fllMenu = new FlowLayoutPanel();
            btnBanHang = new FontAwesome.Sharp.IconButton();
            btnLoaiSanPham = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            btnPhieuNhap = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnKhachhang = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTitleChildForm = new Label();
            panel2 = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            panelNav.SuspendLayout();
            panelMenu.SuspendLayout();
            fllMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 79, 111);
            panelNav.Controls.Add(panelMenu);
            panelNav.CustomizableEdges = customizableEdges1;
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Margin = new Padding(5);
            panelNav.Name = "panelNav";
            panelNav.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelNav.Size = new Size(201, 861);
            panelNav.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(fllMenu);
            panelMenu.Dock = DockStyle.Bottom;
            panelMenu.Location = new Point(0, 154);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(201, 707);
            panelMenu.TabIndex = 20;
            // 
            // fllMenu
            // 
            fllMenu.Controls.Add(btnBanHang);
            fllMenu.Controls.Add(btnLoaiSanPham);
            fllMenu.Controls.Add(btnKhuyenMai);
            fllMenu.Controls.Add(btnNhanVien);
            fllMenu.Controls.Add(btnPhieuNhap);
            fllMenu.Controls.Add(btnThongKe);
            fllMenu.Controls.Add(iconButton1);
            fllMenu.Controls.Add(btnKhachhang);
            fllMenu.Controls.Add(btnHoaDon);
            fllMenu.Controls.Add(iconButton3);
            fllMenu.Controls.Add(btnNhaCungCap);
            fllMenu.Controls.Add(iconButton2);
            fllMenu.Dock = DockStyle.Fill;
            fllMenu.Location = new Point(0, 0);
            fllMenu.Name = "fllMenu";
            fllMenu.Size = new Size(201, 707);
            fllMenu.TabIndex = 0;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.FromArgb(0, 79, 111);
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnBanHang.IconColor = Color.White;
            btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBanHang.IconSize = 40;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(3, 3);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 20, 0);
            btnBanHang.Size = new Size(198, 50);
            btnBanHang.TabIndex = 7;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += iconButton1_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            btnLoaiSanPham.IconColor = Color.White;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.IconSize = 40;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(3, 59);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 20, 0);
            btnLoaiSanPham.Size = new Size(198, 50);
            btnLoaiSanPham.TabIndex = 16;
            btnLoaiSanPham.Text = "Sản phẩm";
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.BackColor = Color.FromArgb(0, 79, 111);
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhuyenMai.ForeColor = Color.White;
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnKhuyenMai.IconColor = Color.White;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.IconSize = 40;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(3, 115);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(198, 50);
            btnKhuyenMai.TabIndex = 13;
            btnKhuyenMai.Text = "Khuyến mãi ";
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = false;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(0, 79, 111);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnNhanVien.IconColor = Color.White;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.IconSize = 40;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(3, 171);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 20, 0);
            btnNhanVien.Size = new Size(198, 50);
            btnNhanVien.TabIndex = 14;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.FromArgb(0, 79, 111);
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnPhieuNhap.IconColor = Color.White;
            btnPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhieuNhap.IconSize = 40;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(3, 227);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 20, 0);
            btnPhieuNhap.Size = new Size(198, 50);
            btnPhieuNhap.TabIndex = 11;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += iconButton4_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(0, 79, 111);
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnThongKe.IconColor = Color.White;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.IconSize = 40;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(3, 283);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 20, 0);
            btnThongKe.Size = new Size(198, 50);
            btnThongKe.TabIndex = 15;
            btnThongKe.Text = "Thống kê ";
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 79, 111);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Untappd;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 339);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(198, 50);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Loại sản phẩm";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // btnKhachhang
            // 
            btnKhachhang.BackColor = Color.FromArgb(0, 79, 111);
            btnKhachhang.FlatAppearance.BorderSize = 0;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachhang.ForeColor = Color.White;
            btnKhachhang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnKhachhang.IconColor = Color.White;
            btnKhachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachhang.IconSize = 40;
            btnKhachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachhang.Location = new Point(3, 395);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Padding = new Padding(10, 0, 20, 0);
            btnKhachhang.Size = new Size(198, 50);
            btnKhachhang.TabIndex = 8;
            btnKhachhang.Text = "Khách hàng";
            btnKhachhang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachhang.UseVisualStyleBackColor = false;
            btnKhachhang.Click += iconButton2_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(0, 79, 111);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnHoaDon.IconColor = Color.White;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.IconSize = 40;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(3, 451);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 20, 0);
            btnHoaDon.Size = new Size(198, 50);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Hoá đơn";
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += iconButton3_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(0, 79, 111);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(3, 507);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(198, 50);
            iconButton3.TabIndex = 19;
            iconButton3.Text = "Phân quyền";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(0, 79, 111);
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnNhaCungCap.IconColor = Color.White;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 40;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(3, 563);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 20, 0);
            btnNhaCungCap.Size = new Size(198, 50);
            btnNhaCungCap.TabIndex = 12;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += iconButton5_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 79, 111);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(3, 619);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(198, 50);
            iconButton2.TabIndex = 18;
            iconButton2.Text = "Tài khoản";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 107);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(201, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 40);
            panel1.TabIndex = 1;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(61, 9);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(97, 24);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Trang chủ";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleLeft;
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
            iconButton9.BackColor = Color.FromArgb(0, 71, 107);
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 91, 127);
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton9.IconSize = 20;
            iconButton9.Location = new Point(63, 3);
            iconButton9.Name = "iconButton9";
            iconButton9.Padding = new Padding(0, 3, 0, 0);
            iconButton9.Size = new Size(45, 34);
            iconButton9.TabIndex = 11;
            iconButton9.UseVisualStyleBackColor = false;
            iconButton9.Click += btnMaximize_Click;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(0, 71, 107);
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 91, 127);
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton8.IconSize = 20;
            iconButton8.Location = new Point(114, 3);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(0, 3, 0, 0);
            iconButton8.Size = new Size(45, 34);
            iconButton8.TabIndex = 9;
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += btnExit_Click;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(0, 71, 107);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 91, 127);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton7.IconSize = 20;
            iconButton7.Location = new Point(12, 3);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(0, 3, 0, 0);
            iconButton7.Size = new Size(45, 34);
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
            iconCurrentChildForm.Size = new Size(55, 40);
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
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1384, 861);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelNav);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "TrangChuForm";
            Text = "TrangChuForm";
            panelNav.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            fllMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private FontAwesome.Sharp.IconButton btnKhachhang;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnPhieuNhap;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private Panel panel1;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelMenu;
        private FlowLayoutPanel fllMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
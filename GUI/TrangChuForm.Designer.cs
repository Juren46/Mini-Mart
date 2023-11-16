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
            btnSanPham = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            btnPhieuNhap = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnLoaiSanPham = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            btnPhanQuyen = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTitleChildForm = new Label();
            panel2 = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
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
            fllMenu.Controls.Add(btnSanPham);
            fllMenu.Controls.Add(btnKhuyenMai);
            fllMenu.Controls.Add(btnNhanVien);
            fllMenu.Controls.Add(btnPhieuNhap);
            fllMenu.Controls.Add(btnThongKe);
            fllMenu.Controls.Add(btnLoaiSanPham);
            fllMenu.Controls.Add(btnKhachHang);
            fllMenu.Controls.Add(btnHoaDon);
            fllMenu.Controls.Add(btnPhanQuyen);
            fllMenu.Controls.Add(btnNhaCungCap);
            fllMenu.Controls.Add(btnTaiKhoan);
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
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            btnSanPham.IconColor = Color.White;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.IconSize = 40;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(3, 59);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 20, 0);
            btnSanPham.Size = new Size(198, 50);
            btnSanPham.TabIndex = 16;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
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
            btnPhieuNhap.Click += btnPhieuNhap_Click;
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
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.Untappd;
            btnLoaiSanPham.IconColor = Color.White;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.IconSize = 40;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(3, 339);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 20, 0);
            btnLoaiSanPham.Size = new Size(198, 50);
            btnLoaiSanPham.TabIndex = 17;
            btnLoaiSanPham.Text = "Loại sản phẩm";
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(0, 79, 111);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnKhachHang.IconColor = Color.White;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.IconSize = 40;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(3, 395);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 20, 0);
            btnKhachHang.Size = new Size(198, 50);
            btnKhachHang.TabIndex = 8;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
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
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnPhanQuyen
            // 
            btnPhanQuyen.BackColor = Color.FromArgb(0, 79, 111);
            btnPhanQuyen.FlatAppearance.BorderSize = 0;
            btnPhanQuyen.FlatStyle = FlatStyle.Flat;
            btnPhanQuyen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhanQuyen.ForeColor = Color.White;
            btnPhanQuyen.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnPhanQuyen.IconColor = Color.White;
            btnPhanQuyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhanQuyen.IconSize = 40;
            btnPhanQuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhanQuyen.Location = new Point(3, 507);
            btnPhanQuyen.Name = "btnPhanQuyen";
            btnPhanQuyen.Padding = new Padding(10, 0, 20, 0);
            btnPhanQuyen.Size = new Size(198, 50);
            btnPhanQuyen.TabIndex = 19;
            btnPhanQuyen.Text = "Phân quyền";
            btnPhanQuyen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhanQuyen.UseVisualStyleBackColor = false;
            btnPhanQuyen.Click += btnPhanQuyen_Click;
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
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = Color.FromArgb(0, 79, 111);
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaiKhoan.ForeColor = Color.White;
            btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnTaiKhoan.IconColor = Color.White;
            btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaiKhoan.IconSize = 40;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(3, 619);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(10, 0, 20, 0);
            btnTaiKhoan.Size = new Size(198, 50);
            btnTaiKhoan.TabIndex = 18;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiKhoan.UseVisualStyleBackColor = false;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
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
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
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
        private FontAwesome.Sharp.IconButton btnKhachHang;
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
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
        private Panel panelMenu;
        private FlowLayoutPanel fllMenu;
        private FontAwesome.Sharp.IconButton btnPhanQuyen;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}
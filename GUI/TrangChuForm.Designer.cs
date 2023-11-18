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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            panel2 = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel3 = new Panel();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            label2 = new Label();
            panelNav.SuspendLayout();
            panelMenu.SuspendLayout();
            fllMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 79, 111);
            panelNav.Controls.Add(panelMenu);
            panelNav.Controls.Add(panel5);
            panelNav.Controls.Add(panel4);
            panelNav.CustomizableEdges = customizableEdges2;
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Margin = new Padding(5);
            panelNav.Name = "panelNav";
            panelNav.ShadowDecoration.CustomizableEdges = customizableEdges3;
            panelNav.Size = new Size(241, 911);
            panelNav.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(fllMenu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 180);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(241, 674);
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
            fllMenu.Size = new Size(241, 674);
            fllMenu.TabIndex = 0;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.FromArgb(0, 79, 111);
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnBanHang.IconColor = Color.White;
            btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBanHang.IconSize = 40;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(3, 3);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 20, 0);
            btnBanHang.Size = new Size(238, 50);
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
            btnSanPham.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            btnSanPham.IconColor = Color.White;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.IconSize = 40;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(3, 59);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 20, 0);
            btnSanPham.Size = new Size(238, 50);
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
            btnKhuyenMai.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhuyenMai.ForeColor = Color.White;
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnKhuyenMai.IconColor = Color.White;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.IconSize = 40;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(3, 115);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(238, 50);
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
            btnNhanVien.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnNhanVien.IconColor = Color.White;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.IconSize = 40;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(3, 171);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 20, 0);
            btnNhanVien.Size = new Size(238, 50);
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
            btnPhieuNhap.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnPhieuNhap.IconColor = Color.White;
            btnPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhieuNhap.IconSize = 40;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(3, 227);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 20, 0);
            btnPhieuNhap.Size = new Size(238, 50);
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
            btnThongKe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnThongKe.IconColor = Color.White;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.IconSize = 40;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(3, 283);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 20, 0);
            btnThongKe.Size = new Size(238, 50);
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
            btnLoaiSanPham.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.Untappd;
            btnLoaiSanPham.IconColor = Color.White;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.IconSize = 40;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(3, 339);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 20, 0);
            btnLoaiSanPham.Size = new Size(238, 50);
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
            btnKhachHang.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnKhachHang.IconColor = Color.White;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.IconSize = 40;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(3, 395);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 20, 0);
            btnKhachHang.Size = new Size(238, 50);
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
            btnHoaDon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnHoaDon.IconColor = Color.White;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.IconSize = 40;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(3, 451);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 20, 0);
            btnHoaDon.Size = new Size(238, 50);
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
            btnPhanQuyen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhanQuyen.ForeColor = Color.White;
            btnPhanQuyen.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnPhanQuyen.IconColor = Color.White;
            btnPhanQuyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhanQuyen.IconSize = 40;
            btnPhanQuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhanQuyen.Location = new Point(3, 507);
            btnPhanQuyen.Name = "btnPhanQuyen";
            btnPhanQuyen.Padding = new Padding(10, 0, 20, 0);
            btnPhanQuyen.Size = new Size(238, 50);
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
            btnNhaCungCap.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnNhaCungCap.IconColor = Color.White;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 40;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(3, 563);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 20, 0);
            btnNhaCungCap.Size = new Size(238, 50);
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
            btnTaiKhoan.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaiKhoan.ForeColor = Color.White;
            btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnTaiKhoan.IconColor = Color.White;
            btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaiKhoan.IconSize = 40;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(3, 619);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(10, 0, 20, 0);
            btnTaiKhoan.Size = new Size(238, 50);
            btnTaiKhoan.TabIndex = 18;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiKhoan.UseVisualStyleBackColor = false;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 107);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(241, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 90);
            panel1.TabIndex = 1;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton9);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(iconButton7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(972, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 90);
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
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(241, 90);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1143, 821);
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
            // panel3
            // 
            panel3.Controls.Add(lblTitleChildForm);
            panel3.Controls.Add(iconCurrentChildForm);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 90);
            panel3.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(91, 27);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(299, 37);
            lblTitleChildForm.TabIndex = 3;
            lblTitleChildForm.Text = "Quản lý loại sản phẩm";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(0, 71, 107);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 60;
            iconCurrentChildForm.Location = new Point(25, 15);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Padding = new Padding(10, 0, 0, 0);
            iconCurrentChildForm.Size = new Size(60, 60);
            iconCurrentChildForm.SizeMode = PictureBoxSizeMode.Zoom;
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(guna2CirclePictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 180);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(iconButton1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 854);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 57);
            panel5.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 79, 111);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(1, 7);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(240, 50);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Đăng xuất ";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(31, 42);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(70, 70);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 68);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Ngọc Tín";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(31, 115);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 2;
            label2.Text = "nhân viên bán hàng";
            // 
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1384, 911);
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
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
        private Panel panelMenu;
        private FlowLayoutPanel fllMenu;
        private FontAwesome.Sharp.IconButton btnPhanQuyen;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Panel panel3;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label2;
        private Label label1;
    }
}
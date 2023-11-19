namespace GUI
{
    partial class KhachHangForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewImageColumn();
            Column14 = new DataGridViewImageColumn();
            tsTrangThai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label3 = new Label();
            label1 = new Label();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            btnNhapXuatExcel = new FontAwesome.Sharp.IconButton();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 1040);
            panel1.TabIndex = 0;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvKhachHang.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.LightBlue;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle10.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvKhachHang.ColumnHeadersHeight = 40;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle15;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.GridColor = Color.FromArgb(242, 245, 250);
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.Margin = new Padding(3, 4, 3, 4);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.DividerHeight = 3;
            dgvKhachHang.RowTemplate.Height = 50;
            dgvKhachHang.Size = new Size(1330, 866);
            dgvKhachHang.TabIndex = 43;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvKhachHang.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhachHang.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvKhachHang.ThemeStyle.HeaderStyle.Height = 40;
            dgvKhachHang.ThemeStyle.ReadOnly = true;
            dgvKhachHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.ThemeStyle.RowsStyle.Height = 50;
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle11;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 51;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 126.881325F;
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 152.257629F;
            Column3.HeaderText = "Tên khách hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 152.257629F;
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 152.257629F;
            Column5.HeaderText = "Ngày sinh";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle12;
            Column6.FillWeight = 63.4406624F;
            Column6.HeaderText = "Số điện thoại";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle13;
            Column7.FillWeight = 88.31249F;
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle14;
            Column8.FillWeight = 126.881325F;
            Column8.HeaderText = "Địa chỉ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 98.12499F;
            Column9.HeaderText = "Bậc thành viên";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 98.12499F;
            Column10.HeaderText = "Điểm thành viên";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 98.12499F;
            Column11.HeaderText = "Điểm tích lũy";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.FillWeight = 30F;
            Column12.HeaderText = "";
            Column12.Image = Properties.Resources._003_information;
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 6;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column13.FillWeight = 30F;
            Column13.HeaderText = "";
            Column13.Image = Properties.Resources._002_pencil;
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 6;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column14.FillWeight = 30F;
            Column14.HeaderText = "";
            Column14.Image = Properties.Resources._001_delete;
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 6;
            // 
            // tsTrangThai
            // 
            tsTrangThai.BackColor = Color.FromArgb(223, 243, 252);
            tsTrangThai.Checked = true;
            tsTrangThai.CheckedState.BorderColor = Color.FromArgb(0, 71, 107);
            tsTrangThai.CheckedState.BorderRadius = 10;
            tsTrangThai.CheckedState.FillColor = Color.FromArgb(0, 71, 107);
            tsTrangThai.CheckedState.InnerBorderColor = Color.White;
            tsTrangThai.CheckedState.InnerColor = Color.White;
            tsTrangThai.CustomizableEdges = customizableEdges7;
            tsTrangThai.Location = new Point(25, 41);
            tsTrangThai.Margin = new Padding(3, 4, 3, 4);
            tsTrangThai.Name = "tsTrangThai";
            tsTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges8;
            tsTrangThai.Size = new Size(75, 31);
            tsTrangThai.TabIndex = 42;
            tsTrangThai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.InnerBorderColor = Color.White;
            tsTrangThai.UncheckedState.InnerColor = Color.White;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(152, 5);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 41;
            label3.Text = "Sắp xếp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 40;
            label1.Text = "Trạng thái";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(226, 153, 48);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimKiem.IconColor = Color.White;
            btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimKiem.IconSize = 20;
            btnTimKiem.Location = new Point(1027, 98);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(49, 48);
            btnTimKiem.TabIndex = 39;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnNhapXuatExcel
            // 
            btnNhapXuatExcel.BackColor = Color.FromArgb(33, 31, 48);
            btnNhapXuatExcel.FlatAppearance.BorderSize = 0;
            btnNhapXuatExcel.FlatStyle = FlatStyle.Flat;
            btnNhapXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhapXuatExcel.ForeColor = Color.White;
            btnNhapXuatExcel.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnNhapXuatExcel.IconColor = Color.White;
            btnNhapXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhapXuatExcel.IconSize = 20;
            btnNhapXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapXuatExcel.Location = new Point(410, 34);
            btnNhapXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnNhapXuatExcel.Name = "btnNhapXuatExcel";
            btnNhapXuatExcel.Size = new Size(192, 48);
            btnNhapXuatExcel.TabIndex = 38;
            btnNhapXuatExcel.Text = "Nhập xuất excel";
            btnNhapXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(226, 153, 48);
            btnThemMoi.FlatAppearance.BorderSize = 0;
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btnThemMoi.IconColor = Color.White;
            btnThemMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemMoi.IconSize = 20;
            btnThemMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMoi.Location = new Point(609, 34);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(131, 48);
            btnThemMoi.TabIndex = 37;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges9;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(15, 98);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTimKiem.Size = new Size(1006, 48);
            txtTimKiem.TabIndex = 36;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges11;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(144, 34);
            cbbSapXep.Margin = new Padding(3, 4, 3, 4);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbSapXep.Size = new Size(259, 36);
            cbbSapXep.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNhapXuatExcel);
            panel2.Controls.Add(cbbSapXep);
            panel2.Controls.Add(tsTrangThai);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnThemMoi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnTimKiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 174);
            panel2.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvKhachHang);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(1330, 866);
            panel3.TabIndex = 45;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 1043);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTrangThai;
        private Label label3;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnNhapXuatExcel;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewImageColumn Column12;
        private DataGridViewImageColumn Column13;
        private DataGridViewImageColumn Column14;
        private Panel panel3;
        private Panel panel2;
    }
}
namespace GUI
{
    partial class HoaDonForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tsTrangThai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label3 = new Label();
            label1 = new Label();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            btnNhapXuatExcel = new FontAwesome.Sharp.IconButton();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            tsTrangThai.CustomizableEdges = customizableEdges1;
            tsTrangThai.Location = new Point(26, 45);
            tsTrangThai.Margin = new Padding(3, 4, 3, 4);
            tsTrangThai.Name = "tsTrangThai";
            tsTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tsTrangThai.Size = new Size(75, 31);
            tsTrangThai.TabIndex = 50;
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
            label3.Location = new Point(153, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 49;
            label3.Text = "Sắp xếp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 48;
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
            btnTimKiem.Location = new Point(1029, 102);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(49, 48);
            btnTimKiem.TabIndex = 47;
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
            btnNhapXuatExcel.Location = new Point(411, 38);
            btnNhapXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnNhapXuatExcel.Name = "btnNhapXuatExcel";
            btnNhapXuatExcel.Size = new Size(192, 48);
            btnNhapXuatExcel.TabIndex = 46;
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
            btnThemMoi.Location = new Point(610, 38);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(131, 48);
            btnThemMoi.TabIndex = 45;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges3;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(16, 102);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTimKiem.Size = new Size(1006, 48);
            txtTimKiem.TabIndex = 44;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges5;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(145, 38);
            cbbSapXep.Margin = new Padding(3, 4, 3, 4);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbSapXep.Size = new Size(259, 36);
            cbbSapXep.TabIndex = 43;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.ColumnHeadersHeight = 40;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle7;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.GridColor = Color.FromArgb(242, 245, 250);
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.DividerHeight = 3;
            dgvHoaDon.RowTemplate.Height = 50;
            dgvHoaDon.Size = new Size(1334, 866);
            dgvHoaDon.TabIndex = 51;
            dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHoaDon.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvHoaDon.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHoaDon.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            dgvHoaDon.ThemeStyle.ReadOnly = true;
            dgvHoaDon.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHoaDon.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHoaDon.ThemeStyle.RowsStyle.Height = 50;
            dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 46;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 126.881325F;
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 152.257629F;
            Column3.HeaderText = "Mã nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 152.257629F;
            Column4.HeaderText = "Mã khách hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 152.257629F;
            Column5.HeaderText = "Mã khuyến mãi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.FillWeight = 63.4406624F;
            Column6.HeaderText = "thời gian tạo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.FillWeight = 88.31249F;
            Column7.HeaderText = "Tổng tiền";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.FillWeight = 126.881325F;
            Column8.HeaderText = "Giá trị khuyến mãi";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 98.12499F;
            Column9.HeaderText = "Thành tiền";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 98.12499F;
            Column10.HeaderText = "Tiền nhận";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 98.12499F;
            Column11.HeaderText = "Tiền thừa";
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
            // panel1
            // 
            panel1.Controls.Add(cbbSapXep);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(tsTrangThai);
            panel1.Controls.Add(btnThemMoi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnNhapXuatExcel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 177);
            panel1.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHoaDon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(1334, 866);
            panel2.TabIndex = 53;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1334, 1043);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HoaDonForm";
            Text = "HoaDonForm";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTrangThai;
        private Label label3;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnNhapXuatExcel;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
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
        private Panel panel1;
        private Panel panel2;
    }
}
namespace GUI
{
    partial class NhaCungCapForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            dgvNhaCungCap = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            Column8 = new DataGridViewImageColumn();
            Column9 = new DataGridViewImageColumn();
            label3 = new Label();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            btnNhapXuatExcel = new FontAwesome.Sharp.IconButton();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            tsTrangThai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1336, 1044);
            panel1.TabIndex = 0;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvNhaCungCap.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightBlue;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvNhaCungCap.ColumnHeadersHeight = 40;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle11;
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.GridColor = Color.FromArgb(242, 245, 250);
            dgvNhaCungCap.Location = new Point(0, 0);
            dgvNhaCungCap.Margin = new Padding(3, 4, 3, 4);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvNhaCungCap.RowHeadersVisible = false;
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.RowTemplate.DividerHeight = 3;
            dgvNhaCungCap.RowTemplate.Height = 50;
            dgvNhaCungCap.Size = new Size(1336, 878);
            dgvNhaCungCap.TabIndex = 36;
            dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvNhaCungCap.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvNhaCungCap.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvNhaCungCap.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvNhaCungCap.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhaCungCap.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvNhaCungCap.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvNhaCungCap.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvNhaCungCap.ThemeStyle.HeaderStyle.Height = 40;
            dgvNhaCungCap.ThemeStyle.ReadOnly = true;
            dgvNhaCungCap.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvNhaCungCap.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhaCungCap.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvNhaCungCap.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvNhaCungCap.ThemeStyle.RowsStyle.Height = 50;
            dgvNhaCungCap.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvNhaCungCap.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle9;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 51;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã nhà cung cấp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên nhà cung cấp";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 155.167023F;
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle10;
            Column6.FillWeight = 64.65291F;
            Column6.HeaderText = "Địa chỉ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.FillWeight = 30F;
            Column7.HeaderText = "";
            Column7.Image = Properties.Resources._003_info;
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 6;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.FillWeight = 30F;
            Column8.HeaderText = "";
            Column8.Image = Properties.Resources._002_pencil;
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 6;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.FillWeight = 30F;
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources._001_bin;
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(157, 11);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 35;
            label3.Text = "Sắp xếp";
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
            btnTimKiem.Location = new Point(1032, 105);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(49, 48);
            btnTimKiem.TabIndex = 33;
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
            btnNhapXuatExcel.Location = new Point(415, 41);
            btnNhapXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnNhapXuatExcel.Name = "btnNhapXuatExcel";
            btnNhapXuatExcel.Size = new Size(192, 48);
            btnNhapXuatExcel.TabIndex = 32;
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
            btnThemMoi.Location = new Point(614, 41);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(131, 48);
            btnThemMoi.TabIndex = 31;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges7;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(20, 105);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTimKiem.Size = new Size(1006, 48);
            txtTimKiem.TabIndex = 30;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges9;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(149, 41);
            cbbSapXep.Margin = new Padding(3, 4, 3, 4);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbbSapXep.Size = new Size(259, 36);
            cbbSapXep.TabIndex = 29;
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
            tsTrangThai.CustomizableEdges = customizableEdges11;
            tsTrangThai.Location = new Point(22, 58);
            tsTrangThai.Margin = new Padding(3, 4, 3, 4);
            tsTrangThai.Name = "tsTrangThai";
            tsTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges12;
            tsTrangThai.Size = new Size(75, 31);
            tsTrangThai.TabIndex = 27;
            tsTrangThai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.InnerBorderColor = Color.White;
            tsTrangThai.UncheckedState.InnerColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 24;
            label1.Text = "Trạng thái";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThemMoi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tsTrangThai);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(cbbSapXep);
            panel2.Controls.Add(btnNhapXuatExcel);
            panel2.Controls.Add(txtTimKiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1336, 166);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvNhaCungCap);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(1336, 878);
            panel3.TabIndex = 38;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 1043);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhaCungCapForm";
            Text = "NhaCungCapForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTrangThai;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnNhapXuatExcel;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhaCungCap;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private Panel panel2;
        private Panel panel3;
    }
}
namespace GUI
{
    partial class PhieuNhapForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            phieuNhapDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tsDangTonTai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            btnNhapXuatExcel = new FontAwesome.Sharp.IconButton();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 831);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(phieuNhapDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 751);
            panel3.TabIndex = 45;
            // 
            // phieuNhapDataGridView
            // 
            phieuNhapDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            phieuNhapDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            phieuNhapDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            phieuNhapDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            phieuNhapDataGridView.ColumnHeadersHeight = 40;
            phieuNhapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            phieuNhapDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            phieuNhapDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            phieuNhapDataGridView.Dock = DockStyle.Fill;
            phieuNhapDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            phieuNhapDataGridView.Location = new Point(0, 0);
            phieuNhapDataGridView.Name = "phieuNhapDataGridView";
            phieuNhapDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            phieuNhapDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            phieuNhapDataGridView.RowHeadersVisible = false;
            phieuNhapDataGridView.RowHeadersWidth = 51;
            phieuNhapDataGridView.RowTemplate.DividerHeight = 3;
            phieuNhapDataGridView.RowTemplate.Height = 50;
            phieuNhapDataGridView.Size = new Size(1183, 751);
            phieuNhapDataGridView.TabIndex = 43;
            phieuNhapDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            phieuNhapDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phieuNhapDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            phieuNhapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            phieuNhapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            phieuNhapDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            phieuNhapDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            phieuNhapDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            phieuNhapDataGridView.ThemeStyle.ReadOnly = true;
            phieuNhapDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            phieuNhapDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            phieuNhapDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phieuNhapDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            phieuNhapDataGridView.ThemeStyle.RowsStyle.Height = 50;
            phieuNhapDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            phieuNhapDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            phieuNhapDataGridView.CellPainting += phieuNhapDataGridView_CellPainting;
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
            Column2.Width = 42;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã phiếu nhập";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 120F;
            Column3.HeaderText = "Tên nhà cung cấp";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 60F;
            Column4.HeaderText = "Nhân viên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 80F;
            Column5.HeaderText = "Quản lý";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Thời gian tạo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.HeaderText = "Thời gian duyệt";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.HeaderText = "Thành tiền";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Trạng thái duyệt";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(tsDangTonTai);
            panel2.Controls.Add(btnNhapXuatExcel);
            panel2.Controls.Add(cbbSapXep);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnTimKiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 80);
            panel2.TabIndex = 44;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges1;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(343, 27);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(367, 36);
            timKiemTextBox.TabIndex = 86;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(33, 31, 48);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(767, 27);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(43, 36);
            iconButton2.TabIndex = 84;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // tsDangTonTai
            // 
            tsDangTonTai.Checked = true;
            tsDangTonTai.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.CheckedState.InnerColor = Color.White;
            tsDangTonTai.CustomizableEdges = customizableEdges3;
            tsDangTonTai.Location = new Point(28, 40);
            tsDangTonTai.Name = "tsDangTonTai";
            tsDangTonTai.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tsDangTonTai.Size = new Size(44, 23);
            tsDangTonTai.TabIndex = 83;
            tsDangTonTai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.UncheckedState.InnerColor = Color.White;
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
            btnNhapXuatExcel.Location = new Point(816, 27);
            btnNhapXuatExcel.Name = "btnNhapXuatExcel";
            btnNhapXuatExcel.Size = new Size(115, 36);
            btnNhapXuatExcel.TabIndex = 80;
            btnNhapXuatExcel.Text = "Xuất excel";
            btnNhapXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapXuatExcel.UseVisualStyleBackColor = false;
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
            cbbSapXep.Location = new Point(108, 27);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbSapXep.Size = new Size(227, 36);
            cbbSapXep.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 82;
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
            btnTimKiem.Location = new Point(718, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(43, 36);
            btnTimKiem.TabIndex = 81;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // PhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 831);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "PhieuNhapForm";
            Text = "PhieuNhapForm";
            Load += PhieuNhapForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView phieuNhapDataGridView;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsDangTonTai;
        private FontAwesome.Sharp.IconButton btnNhapXuatExcel;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
namespace GUI
{
    partial class TaiKhoanForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel4 = new Panel();
            panel3 = new Panel();
            dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            excelButton = new FontAwesome.Sharp.IconButton();
            refreshButton = new FontAwesome.Sharp.IconButton();
            phanQuyenComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            btnDeleteAll = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1183, 821);
            panel4.TabIndex = 77;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvTaiKhoan);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 680);
            panel3.TabIndex = 76;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTaiKhoan.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaiKhoan.ColumnHeadersHeight = 40;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column7, Column8, Column4, Column5, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.GridColor = Color.FromArgb(242, 245, 250);
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.Margin = new Padding(5);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.DividerHeight = 3;
            dgvTaiKhoan.RowTemplate.Height = 50;
            dgvTaiKhoan.Size = new Size(1183, 680);
            dgvTaiKhoan.TabIndex = 64;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvTaiKhoan.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 40;
            dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 50;
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvTaiKhoan.CellFormatting += sanPhamDataGridView_CellFormatting;
            dgvTaiKhoan.CellPainting += sanPhamDataGridView_CellPainting;
            // 
            // panel2
            // 
            panel2.Controls.Add(excelButton);
            panel2.Controls.Add(refreshButton);
            panel2.Controls.Add(phanQuyenComboBox);
            panel2.Controls.Add(btnDeleteAll);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(guna2ToggleSwitch1);
            panel2.Controls.Add(themMoiButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 141);
            panel2.TabIndex = 75;
            // 
            // excelButton
            // 
            excelButton.AllowDrop = true;
            excelButton.BackColor = Color.FromArgb(33, 31, 48);
            excelButton.FlatAppearance.BorderSize = 0;
            excelButton.FlatStyle = FlatStyle.Flat;
            excelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            excelButton.ForeColor = Color.White;
            excelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            excelButton.IconColor = Color.White;
            excelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            excelButton.IconSize = 20;
            excelButton.ImageAlign = ContentAlignment.MiddleLeft;
            excelButton.Location = new Point(419, 37);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(168, 36);
            excelButton.TabIndex = 68;
            excelButton.Text = "Xuất excel";
            excelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            excelButton.UseVisualStyleBackColor = false;
            excelButton.Click += excelButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(33, 31, 48);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            refreshButton.IconColor = Color.White;
            refreshButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            refreshButton.IconSize = 20;
            refreshButton.Location = new Point(1002, 85);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(43, 36);
            refreshButton.TabIndex = 74;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.BackColor = Color.Transparent;
            phanQuyenComboBox.CustomizableEdges = customizableEdges1;
            phanQuyenComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            phanQuyenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phanQuyenComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phanQuyenComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            phanQuyenComboBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            phanQuyenComboBox.ItemHeight = 30;
            phanQuyenComboBox.Location = new Point(180, 37);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            phanQuyenComboBox.Size = new Size(227, 36);
            phanQuyenComboBox.TabIndex = 65;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.IndianRed;
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btnDeleteAll.IconColor = Color.White;
            btnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteAll.IconSize = 20;
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(714, 37);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(115, 36);
            btnDeleteAll.TabIndex = 73;
            btnDeleteAll.Text = "xoá tất cả ";
            btnDeleteAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges3;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(76, 85);
            timKiemTextBox.Margin = new Padding(4, 4, 4, 4);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(870, 36);
            timKiemTextBox.TabIndex = 66;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.BackColor = Color.FromArgb(223, 243, 252);
            guna2ToggleSwitch1.Checked = true;
            guna2ToggleSwitch1.CheckedState.BorderColor = Color.FromArgb(0, 71, 107);
            guna2ToggleSwitch1.CheckedState.BorderRadius = 10;
            guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(0, 71, 107);
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.CustomizableEdges = customizableEdges5;
            guna2ToggleSwitch1.Location = new Point(76, 42);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ToggleSwitch1.Size = new Size(66, 23);
            guna2ToggleSwitch1.TabIndex = 72;
            guna2ToggleSwitch1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White;
            // 
            // themMoiButton
            // 
            themMoiButton.BackColor = Color.FromArgb(226, 153, 48);
            themMoiButton.FlatAppearance.BorderSize = 0;
            themMoiButton.FlatStyle = FlatStyle.Flat;
            themMoiButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            themMoiButton.ForeColor = Color.White;
            themMoiButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiButton.IconColor = Color.White;
            themMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiButton.IconSize = 20;
            themMoiButton.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiButton.Location = new Point(593, 37);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 67;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(187, 15);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 71;
            label3.Text = "Phân quyền ";
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.FromArgb(226, 153, 48);
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            timKiemButton.IconColor = Color.White;
            timKiemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            timKiemButton.IconSize = 20;
            timKiemButton.Location = new Point(953, 85);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 69;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 70;
            label1.Text = "Trạng thái";
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
            Column1.FillWeight = 50F;
            Column1.HeaderText = "Tên tài khoản";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Tên phân quyền";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.FillWeight = 50F;
            Column7.HeaderText = "Mật khẩu";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.FillWeight = 50F;
            Column8.HeaderText = "Trạng thái";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.FillWeight = 30F;
            Column4.HeaderText = "";
            Column4.Image = Properties.Resources._003_info;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 6;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.FillWeight = 30F;
            Column5.HeaderText = "";
            Column5.Image = Properties.Resources._002_pencil1;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 6;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.FillWeight = 30F;
            Column6.HeaderText = "";
            Column6.Image = Properties.Resources._001_bin1;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 6;
            // 
            // TaiKhoanForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "TaiKhoanForm";
            Text = "TaiKhoanForm";
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton excelButton;
        private FontAwesome.Sharp.IconButton refreshButton;
        private Guna.UI2.WinForms.Guna2ComboBox phanQuyenComboBox;
        private FontAwesome.Sharp.IconButton btnDeleteAll;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private Label label3;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Label label1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}
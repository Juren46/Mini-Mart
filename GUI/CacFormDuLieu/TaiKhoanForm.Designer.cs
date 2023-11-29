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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel4 = new Panel();
            panel3 = new Panel();
            taiKhoanDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            tenTaiKhoanColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn = new DataGridViewImageColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            phanQuyenComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taiKhoanDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            panel3.Controls.Add(taiKhoanDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 727);
            panel3.TabIndex = 76;
            // 
            // taiKhoanDataGridView
            // 
            taiKhoanDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            taiKhoanDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            taiKhoanDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            taiKhoanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            taiKhoanDataGridView.ColumnHeadersHeight = 40;
            taiKhoanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            taiKhoanDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, tenTaiKhoanColumn, Column3, Column7, Column8, infoButtonColumn, editButtonColumn, deleteButtonColumn });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            taiKhoanDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            taiKhoanDataGridView.Dock = DockStyle.Fill;
            taiKhoanDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            taiKhoanDataGridView.Location = new Point(0, 0);
            taiKhoanDataGridView.Margin = new Padding(5);
            taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            taiKhoanDataGridView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            taiKhoanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            taiKhoanDataGridView.RowHeadersVisible = false;
            taiKhoanDataGridView.RowHeadersWidth = 51;
            taiKhoanDataGridView.RowTemplate.DividerHeight = 3;
            taiKhoanDataGridView.RowTemplate.Height = 50;
            taiKhoanDataGridView.Size = new Size(1183, 727);
            taiKhoanDataGridView.TabIndex = 64;
            taiKhoanDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            taiKhoanDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            taiKhoanDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            taiKhoanDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            taiKhoanDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            taiKhoanDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            taiKhoanDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            taiKhoanDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            taiKhoanDataGridView.ThemeStyle.ReadOnly = true;
            taiKhoanDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            taiKhoanDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            taiKhoanDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            taiKhoanDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            taiKhoanDataGridView.ThemeStyle.RowsStyle.Height = 50;
            taiKhoanDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            taiKhoanDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            taiKhoanDataGridView.CellContentClick += taiKhoanDataGridView_CellContentClick;
            taiKhoanDataGridView.CellFormatting += taiKhoanDataGridView_CellFormatting;
            taiKhoanDataGridView.CellPainting += taiKhoanDataGridView_CellPainting;
            taiKhoanDataGridView.SelectionChanged += taiKhoanDataGridView_SelectionChanged;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle8;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 46;
            // 
            // tenTaiKhoanColumn
            // 
            tenTaiKhoanColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenTaiKhoanColumn.FillWeight = 50F;
            tenTaiKhoanColumn.HeaderText = "Tên tài khoản";
            tenTaiKhoanColumn.MinimumWidth = 6;
            tenTaiKhoanColumn.Name = "tenTaiKhoanColumn";
            tenTaiKhoanColumn.ReadOnly = true;
            tenTaiKhoanColumn.Resizable = DataGridViewTriState.True;
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
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info;
            infoButtonColumn.MinimumWidth = 6;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 6;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.MinimumWidth = 6;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 6;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteButtonColumn.FillWeight = 30F;
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Image = Properties.Resources._001_bin1;
            deleteButtonColumn.MinimumWidth = 6;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.ReadOnly = true;
            deleteButtonColumn.Width = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2HtmlLabel5);
            panel2.Controls.Add(guna2HtmlLabel4);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(trangThaiComboBox);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(phanQuyenComboBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 94);
            panel2.TabIndex = 75;
            // 
            // panel1
            // 
            panel1.Controls.Add(xoaTatCaButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1051, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 94);
            panel1.TabIndex = 99;
            // 
            // xoaTatCaButton
            // 
            xoaTatCaButton.Anchor = AnchorStyles.Right;
            xoaTatCaButton.BackColor = Color.IndianRed;
            xoaTatCaButton.FlatAppearance.BorderSize = 0;
            xoaTatCaButton.FlatStyle = FlatStyle.Flat;
            xoaTatCaButton.Font = new Font("Microsoft Sans Serif", 12F);
            xoaTatCaButton.ForeColor = Color.White;
            xoaTatCaButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            xoaTatCaButton.IconColor = Color.White;
            xoaTatCaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xoaTatCaButton.IconSize = 20;
            xoaTatCaButton.ImageAlign = ContentAlignment.MiddleLeft;
            xoaTatCaButton.Location = new Point(5, 49);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 94;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
            xoaTatCaButton.Click += xoaTatCaButton_Click;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.BackColor = Color.Transparent;
            trangThaiComboBox.CustomizableEdges = customizableEdges7;
            trangThaiComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            trangThaiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trangThaiComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.Font = new Font("Segoe UI", 10F);
            trangThaiComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            trangThaiComboBox.ItemHeight = 30;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Chờ xử lý", "Tạm đình chỉ", "Đã xóa" });
            trangThaiComboBox.Location = new Point(12, 49);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            trangThaiComboBox.Size = new Size(180, 36);
            trangThaiComboBox.TabIndex = 96;
            trangThaiComboBox.SelectionChangeCommitted += trangThaiComboBox_SelectionChangeCommitted;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges9;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(391, 49);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            timKiemTextBox.Size = new Size(312, 36);
            timKiemTextBox.TabIndex = 95;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
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
            timKiemButton.Location = new Point(711, 49);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 90;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.FromArgb(33, 31, 48);
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            lamMoiButton.IconColor = Color.White;
            lamMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lamMoiButton.IconSize = 20;
            lamMoiButton.Location = new Point(760, 49);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 93;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // themMoiButton
            // 
            themMoiButton.BackColor = Color.FromArgb(226, 153, 48);
            themMoiButton.FlatAppearance.BorderSize = 0;
            themMoiButton.FlatStyle = FlatStyle.Flat;
            themMoiButton.Font = new Font("Microsoft Sans Serif", 12F);
            themMoiButton.ForeColor = Color.White;
            themMoiButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiButton.IconColor = Color.White;
            themMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiButton.IconSize = 20;
            themMoiButton.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiButton.Location = new Point(930, 49);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 88;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // xuatExcelButton
            // 
            xuatExcelButton.BackColor = Color.FromArgb(33, 31, 48);
            xuatExcelButton.FlatAppearance.BorderSize = 0;
            xuatExcelButton.FlatStyle = FlatStyle.Flat;
            xuatExcelButton.Font = new Font("Microsoft Sans Serif", 12F);
            xuatExcelButton.ForeColor = Color.White;
            xuatExcelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            xuatExcelButton.IconColor = Color.White;
            xuatExcelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatExcelButton.IconSize = 20;
            xuatExcelButton.ImageAlign = ContentAlignment.MiddleLeft;
            xuatExcelButton.Location = new Point(809, 49);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(115, 36);
            xuatExcelButton.TabIndex = 89;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.BackColor = Color.Transparent;
            phanQuyenComboBox.CustomizableEdges = customizableEdges11;
            phanQuyenComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            phanQuyenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phanQuyenComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.Font = new Font("Segoe UI", 10F);
            phanQuyenComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            phanQuyenComboBox.ItemHeight = 30;
            phanQuyenComboBox.Location = new Point(199, 49);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            phanQuyenComboBox.Size = new Size(180, 36);
            phanQuyenComboBox.TabIndex = 87;
            phanQuyenComboBox.SelectionChangeCommitted += phanQuyenComboBox_SelectionChangeCommitted;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 14.25F);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(0, 79, 111);
            guna2HtmlLabel5.Location = new Point(199, 14);
            guna2HtmlLabel5.Margin = new Padding(5);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(89, 27);
            guna2HtmlLabel5.TabIndex = 101;
            guna2HtmlLabel5.Text = "Trạng thái";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 14.25F);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(0, 79, 111);
            guna2HtmlLabel4.Location = new Point(14, 14);
            guna2HtmlLabel4.Margin = new Padding(5);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(103, 27);
            guna2HtmlLabel4.TabIndex = 100;
            guna2HtmlLabel4.Text = "Phân quyền";
            // 
            // TaiKhoanForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "TaiKhoanForm";
            Text = "QUẢN LÝ TÀI KHOẢN";
            Load += TaiKhoanForm_Load;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taiKhoanDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView taiKhoanDataGridView;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn Column6;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn tenTaiKhoanColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
        private DataGridViewImageColumn deleteButtonColumn;
        internal Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        internal FontAwesome.Sharp.IconButton lamMoiButton;
        internal Guna.UI2.WinForms.Guna2ComboBox phanQuyenComboBox;
        internal Guna.UI2.WinForms.Guna2ComboBox trangThaiComboBox;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
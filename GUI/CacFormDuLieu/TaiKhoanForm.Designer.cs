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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            phanQuyenComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taiKhoanDataGridView).BeginInit();
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
            dataGridViewCellStyle1.BackColor = Color.White;
            taiKhoanDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            taiKhoanDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            taiKhoanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            taiKhoanDataGridView.ColumnHeadersHeight = 40;
            taiKhoanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            taiKhoanDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, tenTaiKhoanColumn, Column3, Column7, Column8, infoButtonColumn, editButtonColumn, deleteButtonColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            taiKhoanDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            taiKhoanDataGridView.Dock = DockStyle.Fill;
            taiKhoanDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            taiKhoanDataGridView.Location = new Point(0, 0);
            taiKhoanDataGridView.Margin = new Padding(5);
            taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            taiKhoanDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            taiKhoanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            panel2.Controls.Add(guna2HtmlLabel2);
            panel2.Controls.Add(guna2HtmlLabel1);
            panel2.Controls.Add(trangThaiComboBox);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(xoaTatCaButton);
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
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(199, 21);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(66, 17);
            guna2HtmlLabel2.TabIndex = 98;
            guna2HtmlLabel2.Text = "Phân quyền";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(12, 21);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(56, 17);
            guna2HtmlLabel1.TabIndex = 97;
            guna2HtmlLabel1.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.Anchor = AnchorStyles.None;
            trangThaiComboBox.BackColor = Color.Transparent;
            trangThaiComboBox.CustomizableEdges = customizableEdges1;
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
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            trangThaiComboBox.Size = new Size(180, 36);
            trangThaiComboBox.TabIndex = 96;
            trangThaiComboBox.SelectionChangeCommitted += trangThaiComboBox_SelectionChangeCommitted;
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
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(438, 36);
            timKiemTextBox.TabIndex = 95;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // xoaTatCaButton
            // 
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
            xoaTatCaButton.Location = new Point(1056, 7);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 94;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
            xoaTatCaButton.Click += xoaTatCaButton_Click;
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
            timKiemButton.Location = new Point(837, 49);
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
            lamMoiButton.Location = new Point(886, 49);
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
            themMoiButton.Location = new Point(1056, 49);
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
            xuatExcelButton.Location = new Point(935, 49);
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
            phanQuyenComboBox.CustomizableEdges = customizableEdges5;
            phanQuyenComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            phanQuyenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phanQuyenComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.Font = new Font("Segoe UI", 10F);
            phanQuyenComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            phanQuyenComboBox.ItemHeight = 30;
            phanQuyenComboBox.Location = new Point(199, 49);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            phanQuyenComboBox.Size = new Size(180, 36);
            phanQuyenComboBox.TabIndex = 87;
            phanQuyenComboBox.SelectionChangeCommitted += phanQuyenComboBox_SelectionChangeCommitted;
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
            Text = "TaiKhoanForm";
            Load += TaiKhoanForm_Load;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taiKhoanDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
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
    }
}
namespace GUI
{
    partial class SanPhamForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            sanPhamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewImageColumn();
            Column10 = new DataGridViewImageColumn();
            Column11 = new DataGridViewImageColumn();
            panel2 = new Panel();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            trangThaiToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            sapXepComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            nhomSanPhamComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 821);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(sanPhamDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 704);
            panel3.TabIndex = 29;
            // 
            // sanPhamDataGridView
            // 
            sanPhamDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            sanPhamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            sanPhamDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.LightBlue;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle10.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            sanPhamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            sanPhamDataGridView.ColumnHeadersHeight = 40;
            sanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            sanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            sanPhamDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            sanPhamDataGridView.Dock = DockStyle.Fill;
            sanPhamDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.Location = new Point(0, 0);
            sanPhamDataGridView.Name = "sanPhamDataGridView";
            sanPhamDataGridView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            sanPhamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            sanPhamDataGridView.RowHeadersVisible = false;
            sanPhamDataGridView.RowHeadersWidth = 62;
            sanPhamDataGridView.RowTemplate.DividerHeight = 3;
            sanPhamDataGridView.RowTemplate.Height = 50;
            sanPhamDataGridView.Size = new Size(1183, 704);
            sanPhamDataGridView.TabIndex = 28;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            sanPhamDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            sanPhamDataGridView.ThemeStyle.ReadOnly = true;
            sanPhamDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            sanPhamDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sanPhamDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sanPhamDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            sanPhamDataGridView.ThemeStyle.RowsStyle.Height = 50;
            sanPhamDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            sanPhamDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            sanPhamDataGridView.CellFormatting += sanPhamDataGridView_CellFormatting;
            sanPhamDataGridView.CellPainting += sanPhamDataGridView_CellPainting;
            sanPhamDataGridView.SelectionChanged += sanPhamDataGridView_SelectionChanged;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle11;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 43;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên sản phẩm";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Loại sản phẩm";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 155.167023F;
            Column5.HeaderText = "Nhà cung cấp ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle12;
            Column6.FillWeight = 64.65291F;
            Column6.HeaderText = "Đơn vị ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle13;
            Column7.FillWeight = 103.444656F;
            Column7.HeaderText = "Số lượng ";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle14;
            Column8.FillWeight = 129.305817F;
            Column8.HeaderText = "Giá bán ";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.FillWeight = 30F;
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources._003_info;
            Column9.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 8;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.FillWeight = 30F;
            Column10.HeaderText = "";
            Column10.Image = Properties.Resources._002_pencil1;
            Column10.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 8;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.FillWeight = 30F;
            Column11.HeaderText = "";
            Column11.Image = Properties.Resources._001_bin;
            Column11.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(xoaTatCaButton);
            panel2.Controls.Add(trangThaiToggleSwitch);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(sapXepComboBox);
            panel2.Controls.Add(nhomSanPhamComboBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 117);
            panel2.TabIndex = 28;
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
            lamMoiButton.Location = new Point(984, 75);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 64;
            lamMoiButton.UseVisualStyleBackColor = false;
            // 
            // xoaTatCaButton
            // 
            xoaTatCaButton.BackColor = Color.IndianRed;
            xoaTatCaButton.FlatAppearance.BorderSize = 0;
            xoaTatCaButton.FlatStyle = FlatStyle.Flat;
            xoaTatCaButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xoaTatCaButton.ForeColor = Color.White;
            xoaTatCaButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            xoaTatCaButton.IconColor = Color.White;
            xoaTatCaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xoaTatCaButton.IconSize = 20;
            xoaTatCaButton.ImageAlign = ContentAlignment.MiddleLeft;
            xoaTatCaButton.Location = new Point(1033, 75);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 37;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
            // 
            // trangThaiToggleSwitch
            // 
            trangThaiToggleSwitch.BackColor = Color.FromArgb(223, 243, 252);
            trangThaiToggleSwitch.Checked = true;
            trangThaiToggleSwitch.CheckedState.BorderColor = Color.FromArgb(0, 71, 107);
            trangThaiToggleSwitch.CheckedState.BorderRadius = 10;
            trangThaiToggleSwitch.CheckedState.FillColor = Color.FromArgb(0, 71, 107);
            trangThaiToggleSwitch.CheckedState.InnerBorderColor = Color.White;
            trangThaiToggleSwitch.CheckedState.InnerColor = Color.White;
            trangThaiToggleSwitch.CustomizableEdges = customizableEdges9;
            trangThaiToggleSwitch.Location = new Point(58, 32);
            trangThaiToggleSwitch.Name = "trangThaiToggleSwitch";
            trangThaiToggleSwitch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            trangThaiToggleSwitch.Size = new Size(66, 23);
            trangThaiToggleSwitch.TabIndex = 36;
            trangThaiToggleSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            trangThaiToggleSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            trangThaiToggleSwitch.UncheckedState.InnerBorderColor = Color.White;
            trangThaiToggleSwitch.UncheckedState.InnerColor = Color.White;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(169, 5);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 35;
            label3.Text = "Sắp xếp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(402, 5);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 34;
            label2.Text = "Nhóm sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(49, 5);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 33;
            label1.Text = "Trạng thái";
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
            timKiemButton.Location = new Point(935, 75);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 32;
            timKiemButton.UseVisualStyleBackColor = false;
            // 
            // xuatExcelButton
            // 
            xuatExcelButton.BackColor = Color.FromArgb(33, 31, 48);
            xuatExcelButton.FlatAppearance.BorderSize = 0;
            xuatExcelButton.FlatStyle = FlatStyle.Flat;
            xuatExcelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xuatExcelButton.ForeColor = Color.White;
            xuatExcelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            xuatExcelButton.IconColor = Color.White;
            xuatExcelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatExcelButton.IconSize = 20;
            xuatExcelButton.ImageAlign = ContentAlignment.MiddleLeft;
            xuatExcelButton.Location = new Point(689, 27);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(168, 36);
            xuatExcelButton.TabIndex = 31;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
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
            themMoiButton.Location = new Point(863, 27);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 30;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges11;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(49, 75);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            timKiemTextBox.Size = new Size(880, 36);
            timKiemTextBox.TabIndex = 29;
            // 
            // sapXepComboBox
            // 
            sapXepComboBox.BackColor = Color.Transparent;
            sapXepComboBox.CustomizableEdges = customizableEdges13;
            sapXepComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sapXepComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sapXepComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            sapXepComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sapXepComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sapXepComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            sapXepComboBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            sapXepComboBox.ItemHeight = 30;
            sapXepComboBox.Location = new Point(162, 27);
            sapXepComboBox.Name = "sapXepComboBox";
            sapXepComboBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            sapXepComboBox.Size = new Size(227, 36);
            sapXepComboBox.TabIndex = 28;
            // 
            // nhomSanPhamComboBox
            // 
            nhomSanPhamComboBox.BackColor = Color.Transparent;
            nhomSanPhamComboBox.CustomizableEdges = customizableEdges15;
            nhomSanPhamComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            nhomSanPhamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nhomSanPhamComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            nhomSanPhamComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nhomSanPhamComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nhomSanPhamComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            nhomSanPhamComboBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            nhomSanPhamComboBox.ItemHeight = 30;
            nhomSanPhamComboBox.Location = new Point(395, 27);
            nhomSanPhamComboBox.Name = "nhomSanPhamComboBox";
            nhomSanPhamComboBox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            nhomSanPhamComboBox.Size = new Size(288, 36);
            nhomSanPhamComboBox.TabIndex = 27;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "SanPhamForm";
            Text = "QUẢN LÝ SẢN PHẨM";
            Load += SanPhamForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView sanPhamDataGridView;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch trangThaiToggleSwitch;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox sapXepComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox nhomSanPhamComboBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Column9;
        private DataGridViewImageColumn Column10;
        private DataGridViewImageColumn Column11;
    }
}
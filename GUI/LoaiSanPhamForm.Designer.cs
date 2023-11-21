namespace GUI
{
    partial class LoaiSanPhamForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            excelButton = new FontAwesome.Sharp.IconButton();
            themMoiBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            loaiSanPhamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            infoBtn = new DataGridViewImageColumn();
            editBtn = new DataGridViewImageColumn();
            deleteBtn = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            timKiemButton.Location = new Point(592, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 32;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // excelButton
            // 
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
            excelButton.Location = new Point(811, 13);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(116, 36);
            excelButton.TabIndex = 31;
            excelButton.Text = "Xuất Excel";
            excelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            excelButton.UseVisualStyleBackColor = false;
            excelButton.Click += excelButton_Click;
            // 
            // themMoiBtn
            // 
            themMoiBtn.BackColor = Color.FromArgb(226, 153, 48);
            themMoiBtn.FlatAppearance.BorderSize = 0;
            themMoiBtn.FlatStyle = FlatStyle.Flat;
            themMoiBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            themMoiBtn.ForeColor = Color.White;
            themMoiBtn.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiBtn.IconColor = Color.White;
            themMoiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiBtn.IconSize = 20;
            themMoiBtn.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiBtn.Location = new Point(690, 13);
            themMoiBtn.Name = "themMoiBtn";
            themMoiBtn.Size = new Size(115, 36);
            themMoiBtn.TabIndex = 30;
            themMoiBtn.Text = "Thêm mới";
            themMoiBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiBtn.UseVisualStyleBackColor = false;
            themMoiBtn.Click += themMoiBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(refreshBtn);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(excelButton);
            panel2.Controls.Add(themMoiBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 60);
            panel2.TabIndex = 28;
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
            timKiemTextBox.Location = new Point(14, 12);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(570, 36);
            timKiemTextBox.TabIndex = 70;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(33, 31, 48);
            refreshBtn.FlatAppearance.BorderSize = 0;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            refreshBtn.IconColor = Color.White;
            refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            refreshBtn.IconSize = 20;
            refreshBtn.Location = new Point(641, 12);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(43, 36);
            refreshBtn.TabIndex = 68;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(loaiSanPhamDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 722);
            panel3.TabIndex = 29;
            // 
            // loaiSanPhamDataGridView
            // 
            loaiSanPhamDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            loaiSanPhamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            loaiSanPhamDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            loaiSanPhamDataGridView.ColumnHeadersHeight = 40;
            loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            loaiSanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, infoBtn, editBtn, deleteBtn });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            loaiSanPhamDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            loaiSanPhamDataGridView.Dock = DockStyle.Fill;
            loaiSanPhamDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.Location = new Point(0, 0);
            loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            loaiSanPhamDataGridView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            loaiSanPhamDataGridView.RowHeadersVisible = false;
            loaiSanPhamDataGridView.RowTemplate.DividerHeight = 3;
            loaiSanPhamDataGridView.RowTemplate.Height = 50;
            loaiSanPhamDataGridView.Size = new Size(1167, 722);
            loaiSanPhamDataGridView.TabIndex = 28;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            loaiSanPhamDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            loaiSanPhamDataGridView.ThemeStyle.ReadOnly = true;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.Height = 50;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            loaiSanPhamDataGridView.CellContentClick += loaiSanPhamDataGridView_CellContentClick;
            loaiSanPhamDataGridView.CellFormatting += loaiSanPhamDataGridView_CellFormatting;
            loaiSanPhamDataGridView.CellPainting += loaiSanPhamDataGridView_CellPainting;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 782);
            panel1.TabIndex = 2;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle8;
            Column2.HeaderText = "#";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 43;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã loại sản phẩm ";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên loại sản phẩm ";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Trạng thái";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // infoBtn
            // 
            infoBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoBtn.FillWeight = 30F;
            infoBtn.HeaderText = "";
            infoBtn.Image = Properties.Resources._003_info1;
            infoBtn.Name = "infoBtn";
            infoBtn.ReadOnly = true;
            infoBtn.Width = 5;
            // 
            // editBtn
            // 
            editBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editBtn.FillWeight = 30F;
            editBtn.HeaderText = "";
            editBtn.Image = Properties.Resources._002_pencil1;
            editBtn.Name = "editBtn";
            editBtn.ReadOnly = true;
            editBtn.Width = 5;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteBtn.FillWeight = 30F;
            deleteBtn.HeaderText = "";
            deleteBtn.Image = Properties.Resources._001_bin;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ReadOnly = true;
            deleteBtn.Width = 5;
            // 
            // LoaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1167, 782);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LoaiSanPhamForm";
            Text = "LoaiSanPhamForm";
            Load += LoaiSanPhamForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton excelButton;
        private FontAwesome.Sharp.IconButton themMoiBtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView loaiSanPhamDataGridView;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn infoBtn;
        private DataGridViewImageColumn editBtn;
        private DataGridViewImageColumn deleteBtn;
    }
}
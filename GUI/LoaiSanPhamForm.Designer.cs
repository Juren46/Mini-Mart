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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSanPhamForm));
            timKiemButton = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            loaiSanPhamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewImageColumn();
            Column10 = new DataGridViewImageColumn();
            Column11 = new DataGridViewImageColumn();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
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
            timKiemButton.Location = new Point(635, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 32;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(33, 31, 48);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(729, 13);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(168, 36);
            iconButton4.TabIndex = 31;
            iconButton4.Text = "Nhập xuất excel";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(226, 153, 48);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(901, 13);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(115, 36);
            iconButton3.TabIndex = 30;
            iconButton3.Text = "Thêm mới";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
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
            timKiemTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(55, 12);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(574, 36);
            timKiemTextBox.TabIndex = 29;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 60);
            panel2.TabIndex = 28;
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
            dataGridViewCellStyle1.BackColor = Color.White;
            loaiSanPhamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            loaiSanPhamDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            loaiSanPhamDataGridView.ColumnHeadersHeight = 40;
            loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            loaiSanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column9, Column10, Column11 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            loaiSanPhamDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            loaiSanPhamDataGridView.Dock = DockStyle.Fill;
            loaiSanPhamDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.Location = new Point(0, 0);
            loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            loaiSanPhamDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            loaiSanPhamDataGridView.CellFormatting += loaiSanPhamDataGridView_CellFormatting;
            loaiSanPhamDataGridView.CellPainting += loaiSanPhamDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            Column4.HeaderText = "trạng thái";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.FillWeight = 30F;
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources._003_information;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 5;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.FillWeight = 30F;
            Column10.HeaderText = "";
            Column10.Image = (Image)resources.GetObject("Column10.Image");
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 5;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.FillWeight = 30F;
            Column11.HeaderText = "";
            Column11.Image = Properties.Resources._001_delete;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 5;
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
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(33, 31, 48);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(682, 13);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(43, 36);
            iconButton2.TabIndex = 68;
            iconButton2.UseVisualStyleBackColor = false;
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
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView loaiSanPhamDataGridView;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column9;
        private DataGridViewImageColumn Column10;
        private DataGridViewImageColumn Column11;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
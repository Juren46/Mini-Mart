namespace GUI
{
    partial class PhanQuyenForm
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
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvPhanQuyen = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            excelButton = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanQuyen).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            timKiemTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(12, 11);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(821, 36);
            timKiemTextBox.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(refreshBtn);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(excelButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 70);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvPhanQuyen);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 70);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 751);
            panel3.TabIndex = 29;
            // 
            // dgvPhanQuyen
            // 
            dgvPhanQuyen.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPhanQuyen.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPhanQuyen.ColumnHeadersHeight = 40;
            dgvPhanQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPhanQuyen.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvPhanQuyen.DefaultCellStyle = dataGridViewCellStyle9;
            dgvPhanQuyen.Dock = DockStyle.Fill;
            dgvPhanQuyen.GridColor = Color.FromArgb(242, 245, 250);
            dgvPhanQuyen.Location = new Point(0, 0);
            dgvPhanQuyen.Margin = new Padding(5, 5, 5, 5);
            dgvPhanQuyen.Name = "dgvPhanQuyen";
            dgvPhanQuyen.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvPhanQuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvPhanQuyen.RowHeadersVisible = false;
            dgvPhanQuyen.RowTemplate.DividerHeight = 3;
            dgvPhanQuyen.RowTemplate.Height = 50;
            dgvPhanQuyen.Size = new Size(1143, 751);
            dgvPhanQuyen.TabIndex = 28;
            dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvPhanQuyen.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvPhanQuyen.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvPhanQuyen.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvPhanQuyen.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPhanQuyen.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPhanQuyen.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvPhanQuyen.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPhanQuyen.ThemeStyle.HeaderStyle.Height = 40;
            dgvPhanQuyen.ThemeStyle.ReadOnly = true;
            dgvPhanQuyen.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPhanQuyen.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhanQuyen.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPhanQuyen.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPhanQuyen.ThemeStyle.RowsStyle.Height = 50;
            dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvPhanQuyen.CellPainting += loaiSanPhamDataGridView_CellPainting;
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
            Column1.HeaderText = "Mã phân quyền";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên phân quyền";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 821);
            panel1.TabIndex = 3;
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
            refreshBtn.Location = new Point(883, 11);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(43, 36);
            refreshBtn.TabIndex = 72;
            refreshBtn.UseVisualStyleBackColor = false;
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
            timKiemButton.Location = new Point(834, 11);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 71;
            timKiemButton.UseVisualStyleBackColor = false;
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
            excelButton.Location = new Point(932, 11);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(116, 36);
            excelButton.TabIndex = 70;
            excelButton.Text = "Xuất Excel";
            excelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            excelButton.UseVisualStyleBackColor = false;
            // 
            // PhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1143, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "PhanQuyenForm";
            Text = "PhanQuyenForm";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhanQuyen).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhanQuyen;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton excelButton;
    }
}
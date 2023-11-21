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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            NhaCungCapDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            infoBtn = new DataGridViewImageColumn();
            editBtn = new DataGridViewImageColumn();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            excelButton = new FontAwesome.Sharp.IconButton();
            themMoiBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)NhaCungCapDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NhaCungCapDataGridView
            // 
            NhaCungCapDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            NhaCungCapDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            NhaCungCapDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            NhaCungCapDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            NhaCungCapDataGridView.ColumnHeadersHeight = 40;
            NhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            NhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, infoBtn, editBtn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            NhaCungCapDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            NhaCungCapDataGridView.Dock = DockStyle.Fill;
            NhaCungCapDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            NhaCungCapDataGridView.Location = new Point(0, 0);
            NhaCungCapDataGridView.Name = "NhaCungCapDataGridView";
            NhaCungCapDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            NhaCungCapDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            NhaCungCapDataGridView.RowHeadersVisible = false;
            NhaCungCapDataGridView.RowTemplate.DividerHeight = 3;
            NhaCungCapDataGridView.RowTemplate.Height = 50;
            NhaCungCapDataGridView.Size = new Size(1183, 761);
            NhaCungCapDataGridView.TabIndex = 28;
            NhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            NhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            NhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            NhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            NhaCungCapDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            NhaCungCapDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            NhaCungCapDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            NhaCungCapDataGridView.ThemeStyle.ReadOnly = true;
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.Height = 50;
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            NhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            NhaCungCapDataGridView.CellFormatting += sanPhamDataGridView_CellFormatting;
            NhaCungCapDataGridView.CellPainting += sanPhamDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 46;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã nhà cung cấp";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên nhà cung cấp";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Số điện thoại";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Địa chỉ";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
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
            excelButton.Location = new Point(811, 12);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(116, 36);
            excelButton.TabIndex = 31;
            excelButton.Text = "Xuất Excel";
            excelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            excelButton.UseVisualStyleBackColor = false;
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
            themMoiBtn.Location = new Point(690, 11);
            themMoiBtn.Name = "themMoiBtn";
            themMoiBtn.Size = new Size(115, 36);
            themMoiBtn.TabIndex = 30;
            themMoiBtn.Text = "Thêm mới";
            themMoiBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(refreshBtn);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(excelButton);
            panel2.Controls.Add(themMoiBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 60);
            panel2.TabIndex = 28;
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
            timKiemTextBox.Location = new Point(14, 12);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(570, 36);
            timKiemTextBox.TabIndex = 69;
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
            // 
            // panel3
            // 
            panel3.Controls.Add(NhaCungCapDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 761);
            panel3.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 821);
            panel1.TabIndex = 3;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "NhaCungCapForm";
            Text = "QUẢN LÝ NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)NhaCungCapDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView NhaCungCapDataGridView;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton excelButton;
        private FontAwesome.Sharp.IconButton themMoiBtn;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn infoBtn;
        private DataGridViewImageColumn editBtn;
    }
}
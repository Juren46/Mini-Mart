namespace GUI
{
    partial class HoaDonForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            hoaDonDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            tsDangTonTai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(hoaDonDataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 741);
            panel2.TabIndex = 55;
            // 
            // hoaDonDataGridView
            // 
            hoaDonDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            hoaDonDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            hoaDonDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            hoaDonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            hoaDonDataGridView.ColumnHeadersHeight = 40;
            hoaDonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            hoaDonDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            hoaDonDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            hoaDonDataGridView.Dock = DockStyle.Fill;
            hoaDonDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.Location = new Point(0, 0);
            hoaDonDataGridView.Name = "hoaDonDataGridView";
            hoaDonDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            hoaDonDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            hoaDonDataGridView.RowHeadersVisible = false;
            hoaDonDataGridView.RowHeadersWidth = 51;
            hoaDonDataGridView.RowTemplate.DividerHeight = 3;
            hoaDonDataGridView.RowTemplate.Height = 50;
            hoaDonDataGridView.Size = new Size(1183, 741);
            hoaDonDataGridView.TabIndex = 51;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            hoaDonDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            hoaDonDataGridView.ThemeStyle.ReadOnly = true;
            hoaDonDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            hoaDonDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            hoaDonDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hoaDonDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            hoaDonDataGridView.ThemeStyle.RowsStyle.Height = 50;
            hoaDonDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            hoaDonDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            hoaDonDataGridView.CellFormatting += hoaDonDataGridView_CellFormatting;
            hoaDonDataGridView.CellPainting += hoaDonDataGridView_CellPainting;
            hoaDonDataGridView.SelectionChanged += hoaDonDataGridView_SelectionChanged;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges1;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(98, 27);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbbSapXep.Size = new Size(227, 36);
            cbbSapXep.TabIndex = 43;
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
            themMoiButton.Location = new Point(935, 27);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 45;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
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
            xuatExcelButton.Location = new Point(815, 27);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(114, 36);
            xuatExcelButton.TabIndex = 46;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 48;
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
            timKiemButton.Location = new Point(714, 27);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 47;
            timKiemButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(timKiemTextBox);
            panel1.Controls.Add(tsDangTonTai);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(xoaTatCaButton);
            panel1.Controls.Add(cbbSapXep);
            panel1.Controls.Add(themMoiButton);
            panel1.Controls.Add(xuatExcelButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(timKiemButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 80);
            panel1.TabIndex = 54;
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
            timKiemTextBox.Location = new Point(333, 27);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(373, 36);
            timKiemTextBox.TabIndex = 87;
            // 
            // tsDangTonTai
            // 
            tsDangTonTai.Checked = true;
            tsDangTonTai.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.CheckedState.InnerColor = Color.White;
            tsDangTonTai.CustomizableEdges = customizableEdges5;
            tsDangTonTai.Location = new Point(22, 37);
            tsDangTonTai.Name = "tsDangTonTai";
            tsDangTonTai.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tsDangTonTai.Size = new Size(52, 23);
            tsDangTonTai.TabIndex = 74;
            tsDangTonTai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.UncheckedState.InnerColor = Color.White;
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
            lamMoiButton.Location = new Point(765, 27);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 66;
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
            xoaTatCaButton.Location = new Point(1056, 27);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 65;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
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
            Column2.Width = 39;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Mã nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 120F;
            Column4.HeaderText = "Mã khách hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 120F;
            Column5.HeaderText = "Mã khuyến mãi";
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
            Column7.FillWeight = 80F;
            Column7.HeaderText = "Tổng tiền";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.HeaderText = "Chiết khấu ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 80F;
            Column9.HeaderText = "Thành tiền";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 80F;
            Column10.HeaderText = "Tiền nhận";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 80F;
            Column11.HeaderText = "Tiền thừa";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.FillWeight = 30F;
            Column12.HeaderText = "";
            Column12.Image = Properties.Resources._003_information;
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 6;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "HoaDonForm";
            Text = "QUẢN LÝ HOÁ ĐƠN";
            Load += HoaDonForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView hoaDonDataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private Label label1;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsDangTonTai;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewImageColumn Column12;
    }
}
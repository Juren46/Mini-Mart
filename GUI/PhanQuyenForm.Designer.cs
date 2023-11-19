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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label3 = new Label();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvPhanQuyen = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPhanQuyen).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(27, 17);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 62;
            label3.Text = "Sắp xếp";
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
            btnTimKiem.Location = new Point(1040, 102);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(49, 48);
            btnTimKiem.TabIndex = 61;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(226, 153, 48);
            btnThemMoi.FlatAppearance.BorderSize = 0;
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btnThemMoi.IconColor = Color.White;
            btnThemMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemMoi.IconSize = 20;
            btnThemMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMoi.Location = new Point(294, 46);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(131, 48);
            btnThemMoi.TabIndex = 60;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges5;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(27, 102);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTimKiem.Size = new Size(1006, 48);
            txtTimKiem.TabIndex = 59;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges7;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(27, 46);
            cbbSapXep.Margin = new Padding(3, 4, 3, 4);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbbSapXep.Size = new Size(259, 36);
            cbbSapXep.TabIndex = 58;
            // 
            // dgvPhanQuyen
            // 
            dgvPhanQuyen.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPhanQuyen.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPhanQuyen.ColumnHeadersHeight = 40;
            dgvPhanQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPhanQuyen.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6 });
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
            dgvPhanQuyen.Margin = new Padding(3, 4, 3, 4);
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
            dgvPhanQuyen.RowHeadersWidth = 51;
            dgvPhanQuyen.RowTemplate.DividerHeight = 3;
            dgvPhanQuyen.RowTemplate.Height = 50;
            dgvPhanQuyen.Size = new Size(1334, 874);
            dgvPhanQuyen.TabIndex = 63;
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
            Column2.Width = 51;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã phân quyền";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên phân quyền";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.FillWeight = 30F;
            Column4.HeaderText = "";
            Column4.Image = Properties.Resources._003_information;
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
            Column5.Image = Properties.Resources._002_pencil;
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
            Column6.Image = Properties.Resources._001_delete;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbSapXep);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnThemMoi);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 169);
            panel1.TabIndex = 64;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPhanQuyen);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1334, 874);
            panel2.TabIndex = 65;
            // 
            // PhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1334, 1043);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhanQuyenForm";
            Text = "PhanQuyenForm";
            ((System.ComponentModel.ISupportInitialize)dgvPhanQuyen).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhanQuyen;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private Panel panel1;
        private Panel panel2;
    }
}
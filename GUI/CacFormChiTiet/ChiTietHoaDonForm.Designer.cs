namespace GUI.CacFormChiTiet
{
    partial class ChiTietHoaDonForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            panel3 = new Panel();
            chiTietHoaDonDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maKhachHangColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            quayLaiButton = new FontAwesome.Sharp.IconButton();
            tieuDeFormLabel = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(chiTietHoaDonDataGridView);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 517);
            panel3.TabIndex = 52;
            // 
            // chiTietHoaDonDataGridView
            // 
            chiTietHoaDonDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            chiTietHoaDonDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            chiTietHoaDonDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            chiTietHoaDonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            chiTietHoaDonDataGridView.ColumnHeadersHeight = 40;
            chiTietHoaDonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            chiTietHoaDonDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maKhachHangColumn, Column3, Column4, Column6, Column9 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            chiTietHoaDonDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            chiTietHoaDonDataGridView.Dock = DockStyle.Fill;
            chiTietHoaDonDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            chiTietHoaDonDataGridView.Location = new Point(0, 66);
            chiTietHoaDonDataGridView.Name = "chiTietHoaDonDataGridView";
            chiTietHoaDonDataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            chiTietHoaDonDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            chiTietHoaDonDataGridView.RowHeadersVisible = false;
            chiTietHoaDonDataGridView.RowHeadersWidth = 51;
            chiTietHoaDonDataGridView.RowTemplate.DividerHeight = 3;
            chiTietHoaDonDataGridView.RowTemplate.Height = 50;
            chiTietHoaDonDataGridView.Size = new Size(1008, 451);
            chiTietHoaDonDataGridView.TabIndex = 72;
            chiTietHoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            chiTietHoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            chiTietHoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            chiTietHoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            chiTietHoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            chiTietHoaDonDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            chiTietHoaDonDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            chiTietHoaDonDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            chiTietHoaDonDataGridView.ThemeStyle.ReadOnly = true;
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.Height = 50;
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            chiTietHoaDonDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle9;
            Column2.HeaderText = "Mã hóa đơn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 137;
            // 
            // maKhachHangColumn
            // 
            maKhachHangColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHangColumn.HeaderText = "Mã sản phẩm";
            maKhachHangColumn.MinimumWidth = 6;
            maKhachHangColumn.Name = "maKhachHangColumn";
            maKhachHangColumn.ReadOnly = true;
            maKhachHangColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 120F;
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 60F;
            Column4.HeaderText = "Đơn vị";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle10;
            Column6.HeaderText = "Giá bán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 70F;
            Column9.HeaderText = "Thành tiền";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(quayLaiButton);
            panel1.Controls.Add(tieuDeFormLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 66);
            panel1.TabIndex = 71;
            // 
            // quayLaiButton
            // 
            quayLaiButton.Dock = DockStyle.Right;
            quayLaiButton.FlatAppearance.BorderSize = 0;
            quayLaiButton.FlatStyle = FlatStyle.Flat;
            quayLaiButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            quayLaiButton.IconColor = Color.White;
            quayLaiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quayLaiButton.Location = new Point(879, 0);
            quayLaiButton.Name = "quayLaiButton";
            quayLaiButton.Size = new Size(129, 66);
            quayLaiButton.TabIndex = 1;
            quayLaiButton.UseVisualStyleBackColor = true;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(38, 19);
            tieuDeFormLabel.Margin = new Padding(5, 0, 5, 0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(196, 29);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Chi tiết hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 14.25F);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 517);
            panel2.TabIndex = 6;
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 517);
            Controls.Add(panel2);
            Name = "ChiTietHoaDon";
            Text = "ChiTietHoaDon";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Panel panel3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton quayLaiButton;
        private Label tieuDeFormLabel;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView chiTietHoaDonDataGridView;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maKhachHangColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
    }
}
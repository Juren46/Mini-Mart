namespace GUI.CacFormChon
{
    partial class TestChonNhaCungCap
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
            nhaCungCapDataGridView = new DataGridView();
            timKiemButton = new Button();
            lamMoiButton = new Button();
            timKiemTextBox = new TextBox();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            chonNhaCungCapButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { maNhaCungCapColumn, Column1, Column2, Column3, Column4, chonNhaCungCapButtonColumn });
            nhaCungCapDataGridView.Location = new Point(12, 41);
            nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            nhaCungCapDataGridView.RowTemplate.Height = 25;
            nhaCungCapDataGridView.Size = new Size(776, 397);
            nhaCungCapDataGridView.TabIndex = 0;
            nhaCungCapDataGridView.CellContentClick += nhaCungCapDataGridView_CellContentClick;
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(632, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(75, 23);
            timKiemButton.TabIndex = 1;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(713, 12);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(75, 23);
            lamMoiButton.TabIndex = 2;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 12);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.Size = new Size(614, 23);
            timKiemTextBox.TabIndex = 3;
            timKiemTextBox.Click += timKiemTextBox_TextChanged;
            // 
            // maNhaCungCapColumn
            // 
            maNhaCungCapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhaCungCapColumn.HeaderText = "Mã nhà cung cấp";
            maNhaCungCapColumn.Name = "maNhaCungCapColumn";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên nhà cung cấp";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Số điện thoại";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Địa chỉ";
            Column4.Name = "Column4";
            // 
            // chonNhaCungCapButtonColumn
            // 
            chonNhaCungCapButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chonNhaCungCapButtonColumn.HeaderText = "Chọn nhà cung cấp";
            chonNhaCungCapButtonColumn.Name = "chonNhaCungCapButtonColumn";
            chonNhaCungCapButtonColumn.Text = "Chọn";
            chonNhaCungCapButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // TestChonNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timKiemTextBox);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemButton);
            Controls.Add(nhaCungCapDataGridView);
            Name = "TestChonNhaCungCap";
            Text = "TestChonNhaCungCap";
            Load += TestChonNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView nhaCungCapDataGridView;
        private Button timKiemButton;
        private Button lamMoiButton;
        private TextBox timKiemTextBox;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn chonNhaCungCapButtonColumn;
    }
}
namespace GUI.CacFormChon
{
    partial class TestChonLoaiSanPham
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
            loaiSanPhamDataGridView = new DataGridView();
            maLoaiSanPhamColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            chonLoaiSanPhamButtonColumn = new DataGridViewButtonColumn();
            timKiemTextBox = new TextBox();
            timKiemButton = new Button();
            lamMoiButton = new Button();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).BeginInit();
            SuspendLayout();
            // 
            // loaiSanPhamDataGridView
            // 
            loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loaiSanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { maLoaiSanPhamColumn, Column1, chonLoaiSanPhamButtonColumn });
            loaiSanPhamDataGridView.Location = new Point(12, 41);
            loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            loaiSanPhamDataGridView.RowTemplate.Height = 25;
            loaiSanPhamDataGridView.Size = new Size(776, 242);
            loaiSanPhamDataGridView.TabIndex = 0;
            loaiSanPhamDataGridView.CellContentClick += loaiSanPhamDataGridView_CellContentClick;
            // 
            // maLoaiSanPhamColumn
            // 
            maLoaiSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiSanPhamColumn.HeaderText = "Mã loại sản phẩm";
            maLoaiSanPhamColumn.Name = "maLoaiSanPhamColumn";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên loại sản phẩm";
            Column1.Name = "Column1";
            // 
            // chonLoaiSanPhamButtonColumn
            // 
            chonLoaiSanPhamButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chonLoaiSanPhamButtonColumn.HeaderText = "Chọn loại sản phẩm";
            chonLoaiSanPhamButtonColumn.Name = "chonLoaiSanPhamButtonColumn";
            chonLoaiSanPhamButtonColumn.Text = "Chọn";
            chonLoaiSanPhamButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 12);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.Size = new Size(614, 23);
            timKiemTextBox.TabIndex = 1;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(632, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(75, 23);
            timKiemButton.TabIndex = 2;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(713, 12);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(75, 23);
            lamMoiButton.TabIndex = 3;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // TestChonLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 292);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemButton);
            Controls.Add(timKiemTextBox);
            Controls.Add(loaiSanPhamDataGridView);
            Name = "TestChonLoaiSanPham";
            Text = "TestChonLoaiSanPham";
            Load += TestChonLoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView loaiSanPhamDataGridView;
        private DataGridViewTextBoxColumn maLoaiSanPhamColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn chonLoaiSanPhamButtonColumn;
        private TextBox timKiemTextBox;
        private Button timKiemButton;
        private Button lamMoiButton;
    }
}
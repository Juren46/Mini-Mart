namespace TestGUI
{
    partial class TestThemSanPham
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
            pictureBox = new PictureBox();
            maSanPhamTextBox = new TextBox();
            maLoaiSanPhamTextBox = new TextBox();
            maNhaCungCapTextBox = new TextBox();
            tenSanPhamTextBox = new TextBox();
            donViTinhTextBox = new TextBox();
            giaBanTextBox = new TextBox();
            chooseImageButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(163, 132);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // maSanPhamTextBox
            // 
            maSanPhamTextBox.Location = new Point(191, 12);
            maSanPhamTextBox.Multiline = true;
            maSanPhamTextBox.Name = "maSanPhamTextBox";
            maSanPhamTextBox.PlaceholderText = "Mã sản phẩm";
            maSanPhamTextBox.ReadOnly = true;
            maSanPhamTextBox.Size = new Size(146, 23);
            maSanPhamTextBox.TabIndex = 1;
            // 
            // maLoaiSanPhamTextBox
            // 
            maLoaiSanPhamTextBox.Location = new Point(191, 58);
            maLoaiSanPhamTextBox.Multiline = true;
            maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            maLoaiSanPhamTextBox.PlaceholderText = "Mã loại sản phẩm";
            maLoaiSanPhamTextBox.Size = new Size(146, 23);
            maLoaiSanPhamTextBox.TabIndex = 2;
            // 
            // maNhaCungCapTextBox
            // 
            maNhaCungCapTextBox.Location = new Point(191, 108);
            maNhaCungCapTextBox.Multiline = true;
            maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            maNhaCungCapTextBox.PlaceholderText = "Mã nhà cung cấp";
            maNhaCungCapTextBox.Size = new Size(146, 23);
            maNhaCungCapTextBox.TabIndex = 3;
            // 
            // tenSanPhamTextBox
            // 
            tenSanPhamTextBox.Location = new Point(191, 157);
            tenSanPhamTextBox.Multiline = true;
            tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            tenSanPhamTextBox.PlaceholderText = "Tên sản phẩm";
            tenSanPhamTextBox.Size = new Size(146, 23);
            tenSanPhamTextBox.TabIndex = 4;
            // 
            // donViTinhTextBox
            // 
            donViTinhTextBox.Location = new Point(380, 12);
            donViTinhTextBox.Multiline = true;
            donViTinhTextBox.Name = "donViTinhTextBox";
            donViTinhTextBox.PlaceholderText = "Đơn vị tính";
            donViTinhTextBox.Size = new Size(137, 23);
            donViTinhTextBox.TabIndex = 6;
            // 
            // giaBanTextBox
            // 
            giaBanTextBox.Location = new Point(380, 58);
            giaBanTextBox.Multiline = true;
            giaBanTextBox.Name = "giaBanTextBox";
            giaBanTextBox.PlaceholderText = "Giá bán";
            giaBanTextBox.Size = new Size(137, 23);
            giaBanTextBox.TabIndex = 8;
            // 
            // chooseImageButton
            // 
            chooseImageButton.Location = new Point(12, 157);
            chooseImageButton.Name = "chooseImageButton";
            chooseImageButton.Size = new Size(163, 28);
            chooseImageButton.TabIndex = 10;
            chooseImageButton.Text = "Chọn ảnh";
            chooseImageButton.UseVisualStyleBackColor = true;
            chooseImageButton.Click += chooseImageButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(191, 211);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(146, 23);
            saveButton.TabIndex = 11;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // TestThemSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 250);
            Controls.Add(saveButton);
            Controls.Add(chooseImageButton);
            Controls.Add(giaBanTextBox);
            Controls.Add(donViTinhTextBox);
            Controls.Add(tenSanPhamTextBox);
            Controls.Add(maNhaCungCapTextBox);
            Controls.Add(maLoaiSanPhamTextBox);
            Controls.Add(maSanPhamTextBox);
            Controls.Add(pictureBox);
            Name = "TestThemSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestThemSanPham";
            Load += TestThemSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TextBox maSanPhamTextBox;
        private TextBox maLoaiSanPhamTextBox;
        private TextBox maNhaCungCapTextBox;
        private TextBox tenSanPhamTextBox;
        private TextBox donViTinhTextBox;
        private TextBox textBox7;
        private TextBox giaBanTextBox;
        private Button chooseImageButton;
        private Button saveButton;
    }
}
namespace TestGUI
{
    partial class TestSuaSanPham
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
            saveButton = new Button();
            chooseImageButton = new Button();
            giaBanTextBox = new TextBox();
            donViTinhTextBox = new TextBox();
            tenSanPhamTextBox = new TextBox();
            maNhaCungCapTextBox = new TextBox();
            maLoaiSanPhamTextBox = new TextBox();
            maSanPhamTextBox = new TextBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(191, 211);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(146, 23);
            saveButton.TabIndex = 20;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // chooseImageButton
            // 
            chooseImageButton.Location = new Point(12, 157);
            chooseImageButton.Name = "chooseImageButton";
            chooseImageButton.Size = new Size(163, 28);
            chooseImageButton.TabIndex = 19;
            chooseImageButton.Text = "Chọn ảnh";
            chooseImageButton.UseVisualStyleBackColor = true;
            chooseImageButton.Click += chooseImageButton_Click;
            // 
            // giaBanTextBox
            // 
            giaBanTextBox.Location = new Point(354, 58);
            giaBanTextBox.Multiline = true;
            giaBanTextBox.Name = "giaBanTextBox";
            giaBanTextBox.PlaceholderText = "Giá bán";
            giaBanTextBox.Size = new Size(137, 23);
            giaBanTextBox.TabIndex = 18;
            // 
            // donViTinhTextBox
            // 
            donViTinhTextBox.Location = new Point(354, 12);
            donViTinhTextBox.Multiline = true;
            donViTinhTextBox.Name = "donViTinhTextBox";
            donViTinhTextBox.PlaceholderText = "Đơn vị tính";
            donViTinhTextBox.Size = new Size(137, 23);
            donViTinhTextBox.TabIndex = 17;
            // 
            // tenSanPhamTextBox
            // 
            tenSanPhamTextBox.Location = new Point(191, 157);
            tenSanPhamTextBox.Multiline = true;
            tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            tenSanPhamTextBox.PlaceholderText = "Tên sản phẩm";
            tenSanPhamTextBox.Size = new Size(146, 23);
            tenSanPhamTextBox.TabIndex = 16;
            // 
            // maNhaCungCapTextBox
            // 
            maNhaCungCapTextBox.Location = new Point(191, 108);
            maNhaCungCapTextBox.Multiline = true;
            maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            maNhaCungCapTextBox.PlaceholderText = "Mã nhà cung cấp";
            maNhaCungCapTextBox.Size = new Size(146, 23);
            maNhaCungCapTextBox.TabIndex = 15;
            // 
            // maLoaiSanPhamTextBox
            // 
            maLoaiSanPhamTextBox.Location = new Point(191, 58);
            maLoaiSanPhamTextBox.Multiline = true;
            maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            maLoaiSanPhamTextBox.PlaceholderText = "Mã loại sản phẩm";
            maLoaiSanPhamTextBox.Size = new Size(146, 23);
            maLoaiSanPhamTextBox.TabIndex = 14;
            // 
            // maSanPhamTextBox
            // 
            maSanPhamTextBox.Location = new Point(191, 12);
            maSanPhamTextBox.Multiline = true;
            maSanPhamTextBox.Name = "maSanPhamTextBox";
            maSanPhamTextBox.PlaceholderText = "Mã sản phẩm";
            maSanPhamTextBox.ReadOnly = true;
            maSanPhamTextBox.Size = new Size(146, 23);
            maSanPhamTextBox.TabIndex = 13;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(163, 132);
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // TestSuaSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 249);
            Controls.Add(saveButton);
            Controls.Add(chooseImageButton);
            Controls.Add(giaBanTextBox);
            Controls.Add(donViTinhTextBox);
            Controls.Add(tenSanPhamTextBox);
            Controls.Add(maNhaCungCapTextBox);
            Controls.Add(maLoaiSanPhamTextBox);
            Controls.Add(maSanPhamTextBox);
            Controls.Add(pictureBox);
            Name = "TestSuaSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestSuaSanPham";
            Load += TestSuaSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button chooseImageButton;
        private TextBox giaBanTextBox;
        private TextBox donViTinhTextBox;
        private TextBox tenSanPhamTextBox;
        private TextBox maNhaCungCapTextBox;
        private TextBox maLoaiSanPhamTextBox;
        private TextBox maSanPhamTextBox;
        private PictureBox pictureBox;
    }
}
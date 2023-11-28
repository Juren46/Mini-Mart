namespace GUI
{
    partial class DonNhapHangUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            soLuongNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            xoaButton = new FontAwesome.Sharp.IconButton();
            tenSanPhamLabel = new Label();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            tongGiaLabel = new Label();
            label1 = new Label();
            guna2ShadowPanel1.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2CustomGradientPanel1);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 30;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(575, 100);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderRadius = 10;
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.Controls.Add(tongGiaLabel);
            guna2CustomGradientPanel1.Controls.Add(timKiemTextBox);
            guna2CustomGradientPanel1.Controls.Add(soLuongNumericUpDown);
            guna2CustomGradientPanel1.Controls.Add(xoaButton);
            guna2CustomGradientPanel1.Controls.Add(tenSanPhamLabel);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor2 = Color.WhiteSmoke;
            guna2CustomGradientPanel1.FillColor4 = Color.WhiteSmoke;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Size = new Size(575, 100);
            guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // soLuongNumericUpDown
            // 
            soLuongNumericUpDown.BackColor = Color.Transparent;
            soLuongNumericUpDown.BorderRadius = 5;
            soLuongNumericUpDown.CustomizableEdges = customizableEdges3;
            soLuongNumericUpDown.Font = new Font("Segoe UI", 9F);
            soLuongNumericUpDown.Location = new Point(218, 10);
            soLuongNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            soLuongNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.Name = "soLuongNumericUpDown";
            soLuongNumericUpDown.ShadowDecoration.CustomizableEdges = customizableEdges4;
            soLuongNumericUpDown.Size = new Size(72, 34);
            soLuongNumericUpDown.TabIndex = 13;
            soLuongNumericUpDown.UpDownButtonFillColor = Color.FromArgb(0, 50, 90);
            soLuongNumericUpDown.UpDownButtonForeColor = Color.White;
            soLuongNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // xoaButton
            // 
            xoaButton.BackColor = Color.Transparent;
            xoaButton.Dock = DockStyle.Right;
            xoaButton.FlatAppearance.BorderSize = 0;
            xoaButton.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            xoaButton.FlatStyle = FlatStyle.Flat;
            xoaButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            xoaButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            xoaButton.IconColor = Color.IndianRed;
            xoaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            xoaButton.IconSize = 25;
            xoaButton.Location = new Point(524, 0);
            xoaButton.Name = "xoaButton";
            xoaButton.Padding = new Padding(0, 3, 0, 0);
            xoaButton.Size = new Size(51, 100);
            xoaButton.TabIndex = 12;
            xoaButton.UseVisualStyleBackColor = false;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.BackColor = Color.Transparent;
            tenSanPhamLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tenSanPhamLabel.ForeColor = SystemColors.ActiveCaptionText;
            tenSanPhamLabel.Location = new Point(3, 6);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(209, 85);
            tenSanPhamLabel.TabIndex = 7;
            tenSanPhamLabel.Text = "Sữa tắm bảo vệ khỏi vi khuẩn lifebuoy chăm sóc da 980ml";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(314, 10);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập giá bán";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(173, 36);
            timKiemTextBox.TabIndex = 89;
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.BackColor = Color.Transparent;
            tongGiaLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tongGiaLabel.ForeColor = Color.FromArgb(0, 50, 90);
            tongGiaLabel.Location = new Point(314, 61);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new Size(165, 30);
            tongGiaLabel.TabIndex = 90;
            tongGiaLabel.Text = "10.000.000 VNĐ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(218, 65);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 91;
            label1.Text = "Tổng giá";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DonNhapHangUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "DonNhapHangUserControl";
            Size = new Size(575, 100);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown soLuongNumericUpDown;
        private FontAwesome.Sharp.IconButton xoaButton;
        private Label tenSanPhamLabel;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Label label1;
        private Label tongGiaLabel;
    }
}

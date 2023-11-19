namespace GUI
{
    partial class DangNhapForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tenTaiKhoanTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            matKhauTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            dangNhapButton = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tenTaiKhoanTextBox
            // 
            tenTaiKhoanTextBox.BorderColor = Color.FromArgb(0, 71, 107);
            tenTaiKhoanTextBox.BorderRadius = 17;
            tenTaiKhoanTextBox.CustomizableEdges = customizableEdges1;
            tenTaiKhoanTextBox.DefaultText = "";
            tenTaiKhoanTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tenTaiKhoanTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tenTaiKhoanTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.FocusedState.BorderColor = Color.Teal;
            tenTaiKhoanTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tenTaiKhoanTextBox.ForeColor = Color.Black;
            tenTaiKhoanTextBox.HoverState.BorderColor = Color.SteelBlue;
            tenTaiKhoanTextBox.Location = new Point(497, 181);
            tenTaiKhoanTextBox.Margin = new Padding(5, 5, 5, 5);
            tenTaiKhoanTextBox.Name = "tenTaiKhoanTextBox";
            tenTaiKhoanTextBox.PasswordChar = '\0';
            tenTaiKhoanTextBox.PlaceholderText = "Tên đăng nhập";
            tenTaiKhoanTextBox.SelectedText = "";
            tenTaiKhoanTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tenTaiKhoanTextBox.Size = new Size(271, 40);
            tenTaiKhoanTextBox.TabIndex = 4;
            tenTaiKhoanTextBox.KeyPress += tenTaiKhoanTextBox_KeyPress;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.BorderColor = Color.FromArgb(0, 71, 107);
            matKhauTextBox.BorderRadius = 17;
            matKhauTextBox.CustomizableEdges = customizableEdges3;
            matKhauTextBox.DefaultText = "";
            matKhauTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matKhauTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matKhauTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.FocusedState.BorderColor = Color.Teal;
            matKhauTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matKhauTextBox.ForeColor = Color.Black;
            matKhauTextBox.HoverState.BorderColor = Color.SteelBlue;
            matKhauTextBox.Location = new Point(497, 238);
            matKhauTextBox.Margin = new Padding(5, 5, 5, 5);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.PasswordChar = '●';
            matKhauTextBox.PlaceholderText = "Mật khẩu";
            matKhauTextBox.SelectedText = "";
            matKhauTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            matKhauTextBox.Size = new Size(271, 40);
            matKhauTextBox.TabIndex = 5;
            matKhauTextBox.UseSystemPasswordChar = true;
            matKhauTextBox.KeyPress += matKhauTextBox_KeyPress;
            // 
            // dangNhapButton
            // 
            dangNhapButton.BorderRadius = 15;
            dangNhapButton.CustomizableEdges = customizableEdges5;
            dangNhapButton.DisabledState.BorderColor = Color.DarkGray;
            dangNhapButton.DisabledState.CustomBorderColor = Color.DarkGray;
            dangNhapButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dangNhapButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dangNhapButton.FillColor = Color.FromArgb(0, 71, 107);
            dangNhapButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dangNhapButton.ForeColor = Color.White;
            dangNhapButton.Location = new Point(497, 295);
            dangNhapButton.Name = "dangNhapButton";
            dangNhapButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dangNhapButton.Size = new Size(271, 40);
            dangNhapButton.TabIndex = 6;
            dangNhapButton.Text = "Đăng nhập";
            dangNhapButton.Click += dangNhapButton_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Dock = DockStyle.Left;
            guna2PictureBox1.FillColor = Color.FromArgb(0, 71, 107);
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(425, 425);
            guna2PictureBox1.TabIndex = 7;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2ImageCheckBox1
            // 
            guna2ImageCheckBox1.BackColor = Color.White;
            guna2ImageCheckBox1.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            guna2ImageCheckBox1.Image = (Image)resources.GetObject("guna2ImageCheckBox1.Image");
            guna2ImageCheckBox1.ImageOffset = new Point(0, 0);
            guna2ImageCheckBox1.ImageRotate = 0F;
            guna2ImageCheckBox1.Location = new Point(730, 247);
            guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            guna2ImageCheckBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ImageCheckBox1.Size = new Size(24, 24);
            guna2ImageCheckBox1.TabIndex = 8;
            guna2ImageCheckBox1.CheckedChanged += guna2ImageCheckBox1_CheckedChanged;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(223, 243, 252);
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton8.IconColor = Color.FromArgb(0, 71, 107);
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton8.IconSize = 20;
            iconButton8.Location = new Point(806, 0);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(0, 3, 0, 0);
            iconButton8.Size = new Size(45, 34);
            iconButton8.TabIndex = 10;
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(850, 425);
            Controls.Add(iconButton8);
            Controls.Add(guna2ImageCheckBox1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(dangNhapButton);
            Controls.Add(matKhauTextBox);
            Controls.Add(tenTaiKhoanTextBox);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "DangNhapForm";
            Text = "DangNhapForm";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tenTaiKhoanTextBox;
        private Guna.UI2.WinForms.Guna2TextBox matKhauTextBox;
        private Guna.UI2.WinForms.Guna2Button dangNhapButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private FontAwesome.Sharp.IconButton iconButton8;
    }
}
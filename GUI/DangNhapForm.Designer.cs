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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            tenTaiKhoanTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            matKhauTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            dangNhapButton = new Guna.UI2.WinForms.Guna2Button();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(472, 43);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(350, 350);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 9;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // tenTaiKhoanTextBox
            // 
            tenTaiKhoanTextBox.BorderRadius = 17;
            tenTaiKhoanTextBox.CustomizableEdges = customizableEdges2;
            tenTaiKhoanTextBox.DefaultText = "";
            tenTaiKhoanTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tenTaiKhoanTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tenTaiKhoanTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tenTaiKhoanTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tenTaiKhoanTextBox.ForeColor = Color.Black;
            tenTaiKhoanTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tenTaiKhoanTextBox.Location = new Point(62, 141);
            tenTaiKhoanTextBox.Name = "tenTaiKhoanTextBox";
            tenTaiKhoanTextBox.PasswordChar = '\0';
            tenTaiKhoanTextBox.PlaceholderText = "Tên đăng nhập";
            tenTaiKhoanTextBox.SelectedText = "";
            tenTaiKhoanTextBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            tenTaiKhoanTextBox.Size = new Size(271, 36);
            tenTaiKhoanTextBox.TabIndex = 4;
            tenTaiKhoanTextBox.KeyPress += tenTaiKhoanTextBox_KeyPress;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.BorderRadius = 17;
            matKhauTextBox.CustomizableEdges = customizableEdges4;
            matKhauTextBox.DefaultText = "";
            matKhauTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matKhauTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matKhauTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            matKhauTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            matKhauTextBox.ForeColor = Color.Black;
            matKhauTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            matKhauTextBox.Location = new Point(62, 183);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.PasswordChar = '●';
            matKhauTextBox.PlaceholderText = "Mật khẩu";
            matKhauTextBox.SelectedText = "";
            matKhauTextBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            matKhauTextBox.Size = new Size(271, 36);
            matKhauTextBox.TabIndex = 5;
            matKhauTextBox.UseSystemPasswordChar = true;
            matKhauTextBox.KeyPress += matKhauTextBox_KeyPress;
            // 
            // dangNhapButton
            // 
            dangNhapButton.BorderRadius = 15;
            dangNhapButton.CustomizableEdges = customizableEdges6;
            dangNhapButton.DisabledState.BorderColor = Color.DarkGray;
            dangNhapButton.DisabledState.CustomBorderColor = Color.DarkGray;
            dangNhapButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dangNhapButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dangNhapButton.FillColor = Color.FromArgb(0, 71, 107);
            dangNhapButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dangNhapButton.ForeColor = Color.White;
            dangNhapButton.Location = new Point(62, 245);
            dangNhapButton.Name = "dangNhapButton";
            dangNhapButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            dangNhapButton.Size = new Size(271, 33);
            dangNhapButton.TabIndex = 6;
            dangNhapButton.Text = "Đăng nhập";
            dangNhapButton.Click += dangNhapButton_Click;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.FillColor = Color.FromArgb(0, 71, 107);
            guna2vSeparator1.FillThickness = 2;
            guna2vSeparator1.Location = new Point(412, 43);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 350);
            guna2vSeparator1.TabIndex = 1;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(834, 436);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(dangNhapButton);
            Controls.Add(matKhauTextBox);
            Controls.Add(tenTaiKhoanTextBox);
            Controls.Add(guna2vSeparator1);
            Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "DangNhapForm";
            Text = "DangNhapForm";
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tenTaiKhoanTextBox;
        private Guna.UI2.WinForms.Guna2TextBox matKhauTextBox;
        private Guna.UI2.WinForms.Guna2Button dangNhapButton;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
    }
}
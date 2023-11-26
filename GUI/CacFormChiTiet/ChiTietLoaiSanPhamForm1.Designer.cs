namespace GUI
{
    partial class chiTietLoaiSanPhamForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            luuButton = new Guna.UI2.WinForms.Guna2Button();
            huyBoButton = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel3 = new Panel();
            quayLaiButton = new FontAwesome.Sharp.IconButton();
            tieuDeFormLabel = new Label();
            label5 = new Label();
            label2 = new Label();
            tenLoaiSanPhamTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            maLoaiSanPhamTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(luuButton);
            panel2.Controls.Add(huyBoButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tenLoaiSanPhamTextBox);
            panel2.Controls.Add(maLoaiSanPhamTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 278);
            panel2.TabIndex = 4;
            // 
            // luuButton
            // 
            luuButton.BorderRadius = 5;
            luuButton.CustomizableEdges = customizableEdges9;
            luuButton.DisabledState.BorderColor = Color.DarkGray;
            luuButton.DisabledState.CustomBorderColor = Color.DarkGray;
            luuButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            luuButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            luuButton.FillColor = Color.FromArgb(0, 79, 111);
            luuButton.Font = new Font("Microsoft Sans Serif", 12F);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(427, 190);
            luuButton.Name = "luuButton";
            luuButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            luuButton.Size = new Size(189, 53);
            luuButton.TabIndex = 42;
            luuButton.Text = "Lưu";
            luuButton.Click += luuButton_Click;
            // 
            // huyBoButton
            // 
            huyBoButton.BorderColor = Color.FromArgb(0, 79, 111);
            huyBoButton.BorderRadius = 5;
            huyBoButton.BorderThickness = 1;
            huyBoButton.CustomizableEdges = customizableEdges11;
            huyBoButton.DisabledState.BorderColor = Color.DarkGray;
            huyBoButton.DisabledState.CustomBorderColor = Color.DarkGray;
            huyBoButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            huyBoButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            huyBoButton.FillColor = Color.White;
            huyBoButton.Font = new Font("Microsoft Sans Serif", 12F);
            huyBoButton.ForeColor = Color.FromArgb(0, 79, 111);
            huyBoButton.Location = new Point(232, 190);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            huyBoButton.Size = new Size(189, 53);
            huyBoButton.TabIndex = 41;
            huyBoButton.Text = "Huỷ bỏ";
            huyBoButton.Click += huyBoButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tieuDeFormLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 66);
            panel1.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Controls.Add(quayLaiButton);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(440, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 66);
            panel3.TabIndex = 1;
            // 
            // quayLaiButton
            // 
            quayLaiButton.Dock = DockStyle.Right;
            quayLaiButton.FlatAppearance.BorderSize = 0;
            quayLaiButton.FlatStyle = FlatStyle.Flat;
            quayLaiButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            quayLaiButton.IconColor = Color.White;
            quayLaiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quayLaiButton.Location = new Point(71, 0);
            quayLaiButton.Name = "quayLaiButton";
            quayLaiButton.Size = new Size(129, 66);
            quayLaiButton.TabIndex = 2;
            quayLaiButton.UseVisualStyleBackColor = true;
            quayLaiButton.Click += quayLaiButton_Click;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(38, 19);
            tieuDeFormLabel.Margin = new Padding(5, 0, 5, 0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(271, 29);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Chi tiết loại sản phẩm ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.ForeColor = Color.FromArgb(0, 79, 111);
            label5.Location = new Point(326, 91);
            label5.Name = "label5";
            label5.Size = new Size(171, 24);
            label5.TabIndex = 31;
            label5.Text = "Tên loại sản phẩm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 28;
            label2.Text = "Mã loại sản phẩm ";
            // 
            // tenLoaiSanPhamTextBox
            // 
            tenLoaiSanPhamTextBox.BorderColor = Color.FromArgb(0, 79, 111);
            tenLoaiSanPhamTextBox.BorderRadius = 5;
            tenLoaiSanPhamTextBox.CustomizableEdges = customizableEdges13;
            tenLoaiSanPhamTextBox.DefaultText = "";
            tenLoaiSanPhamTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tenLoaiSanPhamTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tenLoaiSanPhamTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tenLoaiSanPhamTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tenLoaiSanPhamTextBox.FocusedState.BorderColor = SystemColors.Highlight;
            tenLoaiSanPhamTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            tenLoaiSanPhamTextBox.Location = new Point(326, 120);
            tenLoaiSanPhamTextBox.Margin = new Padding(5, 5, 5, 5);
            tenLoaiSanPhamTextBox.Name = "tenLoaiSanPhamTextBox";
            tenLoaiSanPhamTextBox.PasswordChar = '\0';
            tenLoaiSanPhamTextBox.PlaceholderText = "";
            tenLoaiSanPhamTextBox.SelectedText = "";
            tenLoaiSanPhamTextBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            tenLoaiSanPhamTextBox.Size = new Size(290, 40);
            tenLoaiSanPhamTextBox.TabIndex = 24;
            // 
            // maLoaiSanPhamTextBox
            // 
            maLoaiSanPhamTextBox.BorderColor = Color.FromArgb(0, 79, 111);
            maLoaiSanPhamTextBox.BorderRadius = 5;
            maLoaiSanPhamTextBox.CustomizableEdges = customizableEdges15;
            maLoaiSanPhamTextBox.DefaultText = "";
            maLoaiSanPhamTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            maLoaiSanPhamTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            maLoaiSanPhamTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            maLoaiSanPhamTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            maLoaiSanPhamTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            maLoaiSanPhamTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            maLoaiSanPhamTextBox.Location = new Point(26, 120);
            maLoaiSanPhamTextBox.Margin = new Padding(5, 5, 5, 5);
            maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            maLoaiSanPhamTextBox.PasswordChar = '\0';
            maLoaiSanPhamTextBox.PlaceholderText = "";
            maLoaiSanPhamTextBox.SelectedText = "";
            maLoaiSanPhamTextBox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            maLoaiSanPhamTextBox.Size = new Size(290, 40);
            maLoaiSanPhamTextBox.TabIndex = 23;
            // 
            // chiTietLoaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 278);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "chiTietLoaiSanPhamForm";
            Load += chiTietLoaiSanPhamForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label5;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tenLoaiSanPhamTextBox;
        private Guna.UI2.WinForms.Guna2TextBox maLoaiSanPhamTextBox;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton quayLaiButton;
        private Label tieuDeFormLabel;
        private Guna.UI2.WinForms.Guna2Button luuButton;
        private Guna.UI2.WinForms.Guna2Button huyBoButton;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
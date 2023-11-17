namespace GUI
{
    partial class themLoaiSanPhamForm1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label8 = new Label();
            tsTrangThai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label5 = new Label();
            label2 = new Label();
            txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnHuyBo = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tsTrangThai);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenSanPham);
            panel2.Controls.Add(txtMaSanPham);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 483);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 66);
            panel1.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(370, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 66);
            panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(36, 9);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(129, 48);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết loại sản phẩm ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 79, 111);
            label8.Location = new Point(437, 142);
            label8.Name = "label8";
            label8.Size = new Size(94, 24);
            label8.TabIndex = 39;
            label8.Text = "Trạng thái";
            // 
            // tsTrangThai
            // 
            tsTrangThai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            tsTrangThai.Checked = true;
            tsTrangThai.CheckedState.BorderColor = Color.FromArgb(0, 79, 111);
            tsTrangThai.CheckedState.BorderRadius = 15;
            tsTrangThai.CheckedState.FillColor = Color.FromArgb(0, 79, 111);
            tsTrangThai.CheckedState.InnerBorderColor = Color.White;
            tsTrangThai.CheckedState.InnerBorderRadius = 12;
            tsTrangThai.CheckedState.InnerColor = Color.White;
            tsTrangThai.CustomizableEdges = customizableEdges11;
            tsTrangThai.Location = new Point(436, 169);
            tsTrangThai.Name = "tsTrangThai";
            tsTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges12;
            tsTrangThai.Size = new Size(95, 36);
            tsTrangThai.TabIndex = 35;
            tsTrangThai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.BorderRadius = 15;
            tsTrangThai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsTrangThai.UncheckedState.InnerBorderColor = Color.White;
            tsTrangThai.UncheckedState.InnerBorderRadius = 12;
            tsTrangThai.UncheckedState.InnerColor = Color.White;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 79, 111);
            label5.Location = new Point(29, 233);
            label5.Name = "label5";
            label5.Size = new Size(137, 24);
            label5.TabIndex = 31;
            label5.Text = "Tên sản phẩm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 28;
            label2.Text = "Mã sản phẩm ";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.BorderColor = Color.FromArgb(0, 79, 111);
            txtTenSanPham.BorderRadius = 5;
            txtTenSanPham.CustomizableEdges = customizableEdges13;
            txtTenSanPham.DefaultText = "";
            txtTenSanPham.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenSanPham.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenSanPham.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenSanPham.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenSanPham.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSanPham.Location = new Point(29, 272);
            txtTenSanPham.Margin = new Padding(5, 5, 5, 5);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PasswordChar = '\0';
            txtTenSanPham.PlaceholderText = "";
            txtTenSanPham.SelectedText = "";
            txtTenSanPham.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtTenSanPham.Size = new Size(502, 58);
            txtTenSanPham.TabIndex = 24;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.BorderColor = Color.FromArgb(0, 79, 111);
            txtMaSanPham.BorderRadius = 5;
            txtMaSanPham.CustomizableEdges = customizableEdges15;
            txtMaSanPham.DefaultText = "";
            txtMaSanPham.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaSanPham.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaSanPham.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaSanPham.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaSanPham.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSanPham.Location = new Point(29, 147);
            txtMaSanPham.Margin = new Padding(5, 5, 5, 5);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.PasswordChar = '\0';
            txtMaSanPham.PlaceholderText = "";
            txtMaSanPham.SelectedText = "";
            txtMaSanPham.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtMaSanPham.Size = new Size(245, 58);
            txtMaSanPham.TabIndex = 23;
            // 
            // btnLuu
            // 
            btnLuu.CustomizableEdges = customizableEdges17;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.FromArgb(0, 79, 111);
            btnLuu.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(342, 379);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnLuu.Size = new Size(189, 53);
            btnLuu.TabIndex = 42;
            btnLuu.Text = "Lưu";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BorderColor = Color.FromArgb(0, 79, 111);
            btnHuyBo.BorderThickness = 1;
            btnHuyBo.CustomizableEdges = customizableEdges19;
            btnHuyBo.DisabledState.BorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHuyBo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHuyBo.FillColor = Color.White;
            btnHuyBo.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyBo.ForeColor = Color.FromArgb(0, 79, 111);
            btnHuyBo.Location = new Point(147, 379);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnHuyBo.Size = new Size(189, 53);
            btnHuyBo.TabIndex = 41;
            btnHuyBo.Text = "Huỷ bỏ";
            // 
            // themLoaiSanPhamForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 483);
            Controls.Add(panel2);
            Name = "themLoaiSanPhamForm1";
            Text = "them Loai San Pham";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTrangThai;
        private Label label5;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        private Label label8;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuyBo;
    }
}
namespace GUI
{
    partial class themPhanQuyenForm
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 66);
            panel1.TabIndex = 72;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(506, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(129, 66);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 29);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết phân quyền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 79, 111);
            label3.Location = new Point(172, 164);
            label3.Name = "label3";
            label3.Size = new Size(113, 18);
            label3.TabIndex = 76;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(174, 68);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 75;
            label2.Text = "Mã Khách hàng";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderColor = Color.FromArgb(0, 79, 111);
            txtTenKhachHang.BorderRadius = 5;
            txtTenKhachHang.CustomizableEdges = customizableEdges1;
            txtTenKhachHang.DefaultText = "";
            txtTenKhachHang.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenKhachHang.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenKhachHang.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenKhachHang.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenKhachHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhachHang.Location = new Point(172, 185);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.PasswordChar = '\0';
            txtTenKhachHang.PlaceholderText = "";
            txtTenKhachHang.SelectedText = "";
            txtTenKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTenKhachHang.Size = new Size(290, 40);
            txtTenKhachHang.TabIndex = 74;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderColor = Color.FromArgb(0, 79, 111);
            txtMaKhachHang.BorderRadius = 5;
            txtMaKhachHang.CustomizableEdges = customizableEdges3;
            txtMaKhachHang.DefaultText = "";
            txtMaKhachHang.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaKhachHang.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaKhachHang.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaKhachHang.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaKhachHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(172, 89);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.PasswordChar = '\0';
            txtMaKhachHang.PlaceholderText = "";
            txtMaKhachHang.SelectedText = "";
            txtMaKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMaKhachHang.Size = new Size(290, 40);
            txtMaKhachHang.TabIndex = 73;
            // 
            // themPhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 292);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "themPhanQuyenForm";
            Text = "themPhanQuyenForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKhachHang;
    }
}
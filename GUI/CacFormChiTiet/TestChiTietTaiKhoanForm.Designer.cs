namespace GUI.CacFormChiTiet
{
    partial class TestChiTietTaiKhoanForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            phanQuyenComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            phanQuyenBindingSource = new BindingSource(components);
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tenTaiKhoanTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            matKhauTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            dongButton = new Guna.UI2.WinForms.Guna2Button();
            huyBoButton = new Guna.UI2.WinForms.Guna2Button();
            luuButton = new Guna.UI2.WinForms.Guna2Button();
            tieuDeFormLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)phanQuyenBindingSource).BeginInit();
            SuspendLayout();
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.BackColor = Color.Transparent;
            phanQuyenComboBox.CustomizableEdges = customizableEdges1;
            phanQuyenComboBox.DataSource = phanQuyenBindingSource;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
            phanQuyenComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            phanQuyenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phanQuyenComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.Font = new Font("Segoe UI", 10F);
            phanQuyenComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            phanQuyenComboBox.ItemHeight = 30;
            phanQuyenComboBox.Location = new Point(36, 60);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            phanQuyenComboBox.Size = new Size(140, 36);
            phanQuyenComboBox.TabIndex = 0;
            // 
            // phanQuyenBindingSource
            // 
            phanQuyenBindingSource.DataSource = typeof(DTO.PhanQuyen);
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.BackColor = Color.Transparent;
            trangThaiComboBox.CustomizableEdges = customizableEdges3;
            trangThaiComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            trangThaiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trangThaiComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.Font = new Font("Segoe UI", 10F);
            trangThaiComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            trangThaiComboBox.ItemHeight = 30;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Chờ xử lý", "Tạm đình chỉ", "Đã xóa" });
            trangThaiComboBox.Location = new Point(208, 60);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            trangThaiComboBox.Size = new Size(140, 36);
            trangThaiComboBox.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(64, 184);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(68, 23);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Mật khẩu";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(36, 124);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(96, 23);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "Tên tài khoản";
            // 
            // tenTaiKhoanTextBox
            // 
            tenTaiKhoanTextBox.CustomizableEdges = customizableEdges5;
            tenTaiKhoanTextBox.DefaultText = "";
            tenTaiKhoanTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tenTaiKhoanTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tenTaiKhoanTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tenTaiKhoanTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tenTaiKhoanTextBox.Font = new Font("Segoe UI", 9F);
            tenTaiKhoanTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tenTaiKhoanTextBox.Location = new Point(148, 111);
            tenTaiKhoanTextBox.Name = "tenTaiKhoanTextBox";
            tenTaiKhoanTextBox.PasswordChar = '\0';
            tenTaiKhoanTextBox.PlaceholderText = "";
            tenTaiKhoanTextBox.SelectedText = "";
            tenTaiKhoanTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tenTaiKhoanTextBox.Size = new Size(200, 36);
            tenTaiKhoanTextBox.TabIndex = 6;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.CustomizableEdges = customizableEdges7;
            matKhauTextBox.DefaultText = "";
            matKhauTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matKhauTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matKhauTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matKhauTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            matKhauTextBox.Font = new Font("Segoe UI", 9F);
            matKhauTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            matKhauTextBox.Location = new Point(148, 171);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.PasswordChar = '*';
            matKhauTextBox.PlaceholderText = "";
            matKhauTextBox.SelectedText = "";
            matKhauTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            matKhauTextBox.Size = new Size(200, 36);
            matKhauTextBox.TabIndex = 7;
            // 
            // dongButton
            // 
            dongButton.CustomizableEdges = customizableEdges9;
            dongButton.DisabledState.BorderColor = Color.DarkGray;
            dongButton.DisabledState.CustomBorderColor = Color.DarkGray;
            dongButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dongButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dongButton.Font = new Font("Segoe UI", 9F);
            dongButton.ForeColor = Color.White;
            dongButton.Location = new Point(330, 3);
            dongButton.Name = "dongButton";
            dongButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dongButton.Size = new Size(48, 33);
            dongButton.TabIndex = 8;
            dongButton.Text = "X";
            dongButton.Click += dongButton_Click;
            // 
            // huyBoButton
            // 
            huyBoButton.CustomizableEdges = customizableEdges11;
            huyBoButton.DisabledState.BorderColor = Color.DarkGray;
            huyBoButton.DisabledState.CustomBorderColor = Color.DarkGray;
            huyBoButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            huyBoButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            huyBoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            huyBoButton.ForeColor = Color.White;
            huyBoButton.Location = new Point(34, 225);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            huyBoButton.Size = new Size(142, 45);
            huyBoButton.TabIndex = 9;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.Click += huyBoButton_Click;
            // 
            // luuButton
            // 
            luuButton.CustomizableEdges = customizableEdges13;
            luuButton.DisabledState.BorderColor = Color.DarkGray;
            luuButton.DisabledState.CustomBorderColor = Color.DarkGray;
            luuButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            luuButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            luuButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(208, 225);
            luuButton.Name = "luuButton";
            luuButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            luuButton.Size = new Size(140, 45);
            luuButton.TabIndex = 10;
            luuButton.Text = "Lưu";
            luuButton.Click += luuButton_Click;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.BackColor = Color.Transparent;
            tieuDeFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(3, 3);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(120, 23);
            tieuDeFormLabel.TabIndex = 11;
            tieuDeFormLabel.Text = "Chi tiết tài khoản";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(38, 36);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(85, 23);
            guna2HtmlLabel4.TabIndex = 12;
            guna2HtmlLabel4.Text = "Phân quyền";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.Location = new Point(210, 37);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(73, 23);
            guna2HtmlLabel5.TabIndex = 13;
            guna2HtmlLabel5.Text = "Trạng thái";
            // 
            // TestChiTietTaiKhoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 276);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(tieuDeFormLabel);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(dongButton);
            Controls.Add(matKhauTextBox);
            Controls.Add(tenTaiKhoanTextBox);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(trangThaiComboBox);
            Controls.Add(phanQuyenComboBox);
            Name = "TestChiTietTaiKhoanForm";
            Text = "TestChiTietTaiKhoan";
            Load += TestChiTietTaiKhoanForm_Load;
            ((System.ComponentModel.ISupportInitialize)phanQuyenBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox phanQuyenComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox trangThaiComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tenTaiKhoanTextBox;
        private Guna.UI2.WinForms.Guna2TextBox matKhauTextBox;
        private Guna.UI2.WinForms.Guna2Button dongButton;
        private Guna.UI2.WinForms.Guna2Button huyBoButton;
        private Guna.UI2.WinForms.Guna2Button luuButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel tieuDeFormLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private BindingSource phanQuyenBindingSource;
    }
}
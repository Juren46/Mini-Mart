namespace GUI
{
    partial class SanPhamNhapHangUserControl
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tenSanPhamLabel = new Label();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            chonButton = new FontAwesome.Sharp.IconButton();
            anhSanPhamPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)anhSanPhamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.BackColor = Color.FromArgb(223, 243, 252);
            tenSanPhamLabel.Font = new Font("Segoe UI", 11.25F);
            tenSanPhamLabel.ForeColor = SystemColors.ActiveCaptionText;
            tenSanPhamLabel.Location = new Point(89, 1);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(91, 93);
            tenSanPhamLabel.TabIndex = 5;
            tenSanPhamLabel.Text = "cà phê chả trà sữa bún đá ";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chonButton
            // 
            chonButton.BackColor = Color.FromArgb(0, 50, 90);
            chonButton.Dock = DockStyle.Bottom;
            chonButton.FlatAppearance.BorderSize = 0;
            chonButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            chonButton.ForeColor = Color.White;
            chonButton.IconChar = FontAwesome.Sharp.IconChar.None;
            chonButton.IconColor = Color.Black;
            chonButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            chonButton.Location = new Point(0, 97);
            chonButton.Name = "chonButton";
            chonButton.Size = new Size(183, 48);
            chonButton.TabIndex = 7;
            chonButton.Text = "Chọn";
            chonButton.UseVisualStyleBackColor = false;
            // 
            // anhSanPhamPictureBox
            // 
            anhSanPhamPictureBox.CustomizableEdges = customizableEdges1;
            anhSanPhamPictureBox.Image = Properties.Resources._004_lock;
            anhSanPhamPictureBox.ImageRotate = 0F;
            anhSanPhamPictureBox.Location = new Point(3, 1);
            anhSanPhamPictureBox.Name = "anhSanPhamPictureBox";
            anhSanPhamPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            anhSanPhamPictureBox.Size = new Size(80, 93);
            anhSanPhamPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            anhSanPhamPictureBox.TabIndex = 4;
            anhSanPhamPictureBox.TabStop = false;
            // 
            // SanPhamNhapHangUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tenSanPhamLabel);
            Controls.Add(chonButton);
            Controls.Add(anhSanPhamPictureBox);
            Name = "SanPhamNhapHangUserControl";
            Size = new Size(183, 145);
            ((System.ComponentModel.ISupportInitialize)anhSanPhamPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label tenSanPhamLabel;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private FontAwesome.Sharp.IconButton chonButton;
        private Guna.UI2.WinForms.Guna2PictureBox anhSanPhamPictureBox;
    }
}

namespace GUI
{
    partial class SanPhamControl
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
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources._004_lock;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(80, 80);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(223, 243, 252);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(89, 3);
            label1.Name = "label1";
            label1.Size = new Size(91, 80);
            label1.TabIndex = 1;
            label1.Text = "cà phê chả trà sữa bún đá ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(223, 243, 252);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 50, 90);
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 2;
            label2.Text = "1.000.000 VNĐ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 50, 90);
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 114);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(183, 31);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Chọn";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // SanPhamControl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SanPhamControl";
            Size = new Size(183, 145);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

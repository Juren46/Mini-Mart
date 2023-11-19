namespace TestGUI
{
    partial class TestExcel
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            excelBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // excelBtn
            // 
            excelBtn.CustomizableEdges = customizableEdges3;
            excelBtn.DisabledState.BorderColor = Color.DarkGray;
            excelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            excelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            excelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            excelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            excelBtn.ForeColor = Color.White;
            excelBtn.Location = new Point(298, 193);
            excelBtn.Name = "excelBtn";
            excelBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            excelBtn.Size = new Size(180, 45);
            excelBtn.TabIndex = 0;
            excelBtn.Text = "In Excel";
            // 
            // TestExcel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(excelBtn);
            Name = "TestExcel";
            Text = "TestExcel";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button excelBtn;
    }
}
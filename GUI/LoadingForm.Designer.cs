namespace GUI
{
    partial class LoadingForm
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            timer3 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(475, 409);
            label1.Name = "label1";
            label1.Size = new Size(464, 42);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng đợi trong giây lát... ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(269, 595);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 26);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 18);
            panel2.TabIndex = 2;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 4;
            timer3.Tick += timer3_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(185, 226, 239);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1384, 861);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LoadingForm";
            Text = "LoadingForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer3;
    }
}
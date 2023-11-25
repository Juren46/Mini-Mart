namespace ReportViewerTesting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            staffReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // staffReportViewer
            // 
            staffReportViewer.AutoSize = true;
            staffReportViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            staffReportViewer.Dock = DockStyle.Fill;
            staffReportViewer.Location = new Point(0, 0);
            staffReportViewer.Name = "ReportViewer";
            staffReportViewer.ServerReport.BearerToken = null;
            staffReportViewer.Size = new Size(800, 450);
            staffReportViewer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(staffReportViewer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer staffReportViewer;
    }
}

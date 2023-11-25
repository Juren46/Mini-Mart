namespace GUI.InAn.Forms
{
    partial class InPhieuNhapForm
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
            phieuNhapReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // phieuNhapReportViewer
            // 
            phieuNhapReportViewer.AutoSize = true;
            phieuNhapReportViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            phieuNhapReportViewer.Dock = DockStyle.Fill;
            phieuNhapReportViewer.Location = new Point(0, 0);
            phieuNhapReportViewer.Name = "ReportViewer";
            phieuNhapReportViewer.ServerReport.BearerToken = null;
            phieuNhapReportViewer.Size = new Size(630, 450);
            phieuNhapReportViewer.TabIndex = 0;
            // 
            // InPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(phieuNhapReportViewer);
            Name = "InPhieuNhapForm";
            Text = "InPhieuNhapForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer phieuNhapReportViewer;
    }
}
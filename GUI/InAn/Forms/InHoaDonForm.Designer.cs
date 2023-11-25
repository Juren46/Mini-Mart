namespace GUI.InAn.Forms
{
    partial class InHoaDonForm
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
            HoaDonReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // HoaDonReportViewer
            // 
            HoaDonReportViewer.AutoSize = true;
            HoaDonReportViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HoaDonReportViewer.Dock = DockStyle.Fill;
            HoaDonReportViewer.Location = new Point(0, 0);
            HoaDonReportViewer.Name = "ReportViewer";
            HoaDonReportViewer.ServerReport.BearerToken = null;
            HoaDonReportViewer.Size = new Size(800, 450);
            HoaDonReportViewer.TabIndex = 0;
            // 
            // InHoaDonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HoaDonReportViewer);
            Name = "InHoaDonForm";
            Text = "InHoaDonForm";
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer HoaDonReportViewer;
    }
}
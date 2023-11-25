using Microsoft.Reporting.WinForms;
using System.Data;

namespace ReportViewerTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable table = Staff.GetStaffDataTable();

            staffReportViewer.LocalReport.ReportEmbeddedResource = "ReportViewerTesting.StaffReport.rdlc";
            staffReportViewer.LocalReport.DataSources.Clear();
            staffReportViewer.LocalReport.DataSources.Add(new ReportDataSource("StaffDataSet", table));
            staffReportViewer.ProcessingMode = ProcessingMode.Local;
            staffReportViewer.RefreshReport();
        }
    }
}

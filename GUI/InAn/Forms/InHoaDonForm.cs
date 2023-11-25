using GUI.InAn.DefinitionClasses;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.InAn.Forms
{
    public partial class InHoaDonForm : Form
    {
        string maHoaDon;

        public InHoaDonForm(string maHoaDon)
        {
            InitializeComponent();

            this.maHoaDon = maHoaDon;

            DataTable table = ChiTietHoaDonData.GetChiTietHoaDonDataTable(maHoaDon);

            HoaDonReportViewer.LocalReport.ReportEmbeddedResource = "GUI.InAn.Reports.HoaDonReport.rdlc";
            HoaDonReportViewer.LocalReport.DataSources.Clear();
            HoaDonReportViewer.LocalReport.DataSources.Add(new ReportDataSource("HoaDonDataSet", table));
            HoaDonReportViewer.ProcessingMode = ProcessingMode.Local;
            HoaDonReportViewer.RefreshReport();
            
        }
    }
}

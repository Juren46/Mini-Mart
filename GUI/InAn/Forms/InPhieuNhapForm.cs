using DTO;
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
    public partial class InPhieuNhapForm : Form
    {
        string maPhieuNhap;

        public InPhieuNhapForm(string maPhieuNhap)
        {
            InitializeComponent();

            this.maPhieuNhap = maPhieuNhap;

            DataTable table = ChiTietPhieuNhapData.GetChiTietPhieuNhapDataTable(maPhieuNhap);

            phieuNhapReportViewer.LocalReport.ReportEmbeddedResource = "GUI.InAn.Reports.PhieuNhapReport.rdlc";
            phieuNhapReportViewer.LocalReport.DataSources.Clear();
            phieuNhapReportViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapDataSet", table));
            phieuNhapReportViewer.ProcessingMode = ProcessingMode.Local;
            phieuNhapReportViewer.RefreshReport();
            this.maPhieuNhap = maPhieuNhap;
        }
    }
}

using Microsoft.Reporting.WinForms;
using Parking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Forms.Reports
{
    public partial class frmReport : Form
    {
        private DataView _dv = null;
        private String _fileName = string.Empty;
        private List<KeyValuePair<String, String>> _para = null;
        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(DataView dv, String fileName)
        {
            _dv = dv;
            _fileName = fileName;
            InitializeComponent();
        }

        public frmReport(DataView dv, String fileName, Dictionary<String, String> para)
        {
            _dv = dv;
            _fileName = fileName;
            _para = para.ToList();
            InitializeComponent();
        }

        private void frmReportMain_Load(object sender, EventArgs e)
        {
            ReportDataSource reportData = new ReportDataSource("dsCar", _dv);
            rptMain.LocalReport.ReportEmbeddedResource = _fileName;
            rptMain.LocalReport.EnableExternalImages = true;
            rptMain.LocalReport.DataSources.Add(reportData);

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 1;
            pg.Margins.Bottom = 1;
            pg.Margins.Left = 1;
            pg.Margins.Right = 0;
            pg.PrinterSettings.DefaultPageSettings.Landscape = true;
            pg.Landscape = true;
            //PaperSize size = new PaperSize();
            //size.RawKind = (int)PaperKind.A4;
            //pg.PaperSize = size;
            rptMain.SetPageSettings(pg);

            if ((_para != null) && (_para.Count > 0))
            {
                ReportParameter[] rptParameter = new ReportParameter[_para.Count];
                for (Int32 i = 0; i < _para.Count; i++)
                {
                    rptParameter[i] = new ReportParameter(_para[i].Key, _para[i].Value);
                }
                rptMain.LocalReport.SetParameters(rptParameter);
                rptMain.LocalReport.Refresh();
            }
            this.rptMain.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Services.Protocols;
using Microsoft.Reporting.WinForms;
using System.Configuration;

namespace DowntownBoiseAssociation
{
    public partial class report_Main : Form
    {
        private string _ReportServer;
        private string _ReportPath;
        private string _ReportName;
        private string _ReportTitle;

        public report_Main(string ReportServer, string ReportPath, string ReportName, string ReportTitle)
        {
            InitializeComponent();
            _ReportServer = ReportServer;
            _ReportPath = ReportPath;
            _ReportName = ReportName;
            _ReportTitle = ReportTitle;

            this.Text = "Report - " + _ReportTitle;
        }

        private List<ReportParameter> reportParameters = new List<ReportParameter>();

        public report_Main(string ReportServer, string ReportPath, string ReportName, string ReportTitle, IEnumerable<ReportParameter> ReportParameters) :
            this(ReportServer, ReportPath, ReportName, ReportTitle)
        {
            reportParameters = new List<ReportParameter>();
            reportParameters.AddRange(ReportParameters as IEnumerable<ReportParameter>);
        }

        private void report_Main_Load(object sender, EventArgs e)
        {
            string _ReportUserName = ConfigurationManager.AppSettings["DBA_ReportUserName"].ToString();
            string _ReportUserPassword = ConfigurationManager.AppSettings["DBA_ReportUserPassword"].ToString(); 
            string _ReportUserDomain = ConfigurationManager.AppSettings["DBA_ReportUserDomain"].ToString();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = 
                new System.Net.NetworkCredential(_ReportUserName, _ReportUserPassword, _ReportUserDomain);

            this.reportViewer1.ServerReport.ReportServerUrl = new Uri(_ReportServer);
            this.reportViewer1.ServerReport.ReportPath = _ReportPath + "/" + _ReportName;
            if (reportParameters.Count() > 0)
                try
                {
                    this.reportViewer1.ServerReport.SetParameters(reportParameters);
                }
                catch (System.ArgumentException)
                {
                    this.reportViewer1.ServerReport.SetParameters(new List<ReportParameter>());
                }
            this.reportViewer1.RefreshReport();
        }
    }
}

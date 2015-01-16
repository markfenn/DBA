using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DowntownBoiseAssociation.Reports.ReportServer;
using System.Configuration;

namespace DowntownBoiseAssociation
{
    public partial class report_ReportsList : Form
    {
        private string _ReportServer = ConfigurationManager.AppSettings["DBA_ReportServer"].ToString();
        private string _ReportPath = ConfigurationManager.AppSettings["DBA_ReportPath"].ToString();        
        private string _ReportPrefix;
        
        public report_ReportsList(string ReportPrefix)
        {
            InitializeComponent();
            _ReportPrefix = ReportPrefix;
        }

        private void report_ReportsList_Load(object sender, EventArgs e)
        {
            ReportingService2005 rs = new ReportingService2005();
            rs.Credentials = System.Net.CredentialCache.DefaultCredentials;

            CatalogItem[] Items = null;

            SearchCondition RSSearch = new SearchCondition();
            RSSearch.Condition = ConditionEnum.Contains;
            RSSearch.ConditionSpecified = true;
            RSSearch.Name = "Name";
            RSSearch.Value = _ReportPrefix;

            SearchCondition[] RSSearches = new SearchCondition[1];
            RSSearches[0] = RSSearch;

            Items = rs.FindItems(_ReportPath, BooleanOperatorEnum.Or, RSSearches);
            lbReports.DisplayMember = "SearchText";

            foreach (CatalogItem Item in Items)
            {
                Classes.SearchList NewSearch = new Classes.SearchList();
                NewSearch.IdString = Item.Name;
                NewSearch.SearchText = Item.Name.Remove(0, _ReportPrefix.Length).Trim();
                lbReports.Items.Add(NewSearch);
            }
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            if (lbReports.SelectedItems.Count > 0)
            {
                Classes.SearchList SearchItem = (Classes.SearchList)lbReports.SelectedItem;

                report_Main NewReport = new report_Main(_ReportServer, _ReportPath, SearchItem.IdString, SearchItem.IdString.Remove(0, _ReportPrefix.Length).Trim());
                frmDBAContainer RptContainer = (frmDBAContainer)this.ParentForm;
                RptContainer.AddMDIChildForm(NewReport);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

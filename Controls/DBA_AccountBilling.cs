using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace DowntownBoiseAssociation.Controls
{
    public partial class DBA_AccountBilling : UserControl
    {
        private Guid _ObjectGuid;
        private string _accountNumber;

        private string _ReportServer;
        private string _ReportPath;
        private string _InvoiceReport;
        private string _StatementReport;
        private string _AdjustmentQuery = "";
        private string _AdjustmentType = "";
        private string _AdjustmentText = "Add Adjustment";

        
        
        public DBA_AccountBilling()
        {
            InitializeComponent();
            lnkAdjustment.Text = _AdjustmentText;
            try
            {
                _ReportServer = ConfigurationManager.AppSettings["DBA_ReportServer"].ToString();
                _ReportPath = ConfigurationManager.AppSettings["DBA_ReportPath"].ToString();
                _InvoiceReport = ConfigurationManager.AppSettings["DBA_InvoiceReport"].ToString();
                _StatementReport = ConfigurationManager.AppSettings["DBA_StatementReport"].ToString();
            }
            catch
            {
            }
        }

        public string AdjustmentText
        {
            set
            {
                _AdjustmentText = value;
                lnkAdjustment.Text = _AdjustmentText;
            }
        }

        public string AdjustmentQuery
        {
            set
            {
                _AdjustmentQuery = value;
                lnkAdjustment.Text = _AdjustmentQuery;
            }
        }
                
        public Guid ObjectGuid
        {
            get { return _ObjectGuid; }
            set
            {
                _ObjectGuid = value;
                _accountNumber = null;
                LoadBillingData();
            }
        }

        private string AccountNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_accountNumber))
                {
                    DBADataContext dc = new DBADataContext();

                    _accountNumber = (from le in dc.LegalEntities
                                      where le.Guid == _ObjectGuid
                                      select le.AccountNumber).FirstOrDefault();
                }
                return _accountNumber;
            }
        }

        /// <summary>
        /// Retrieve and display the current year's billing data
        /// </summary>
        private void LoadBillingData()
        {
            DBADataContext db = new DBADataContext();
            fnGetAccountStatementResultBindingSource.DataSource = db.fn_GetAccountStatement(ObjectGuid, _AdjustmentQuery);
        }

        public string AdjustmentType
        {
            get { return _AdjustmentType; }
            set
            {
                _AdjustmentType = value;
                LoadBillingData();
            }
        }

        /// <summary>
        /// Show the adjustment dialog window and allow the user to adjust the account they're viewing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAdjustment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogAddAdjustment form = new dialogAddAdjustment();
            form.AdjustmentType = AdjustmentType;
            if (form.ShowDialog() == DialogResult.OK)
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                string login = id.Name;
                DBADataContext dc = new DBADataContext();
                dc.sp_InsAdjustment(AccountNumber, form.Date, form.Note, form.Category, login, form.Amount);
                LoadBillingData();
            }
        }

        private void runReport(string ReportName, string ReportTitle, List<ReportParameter> rptParms)
        {
            Form target = this.ParentForm;
            while (!(target is frmDBAContainer)) { target = target.ParentForm; }
            if (target is frmDBAContainer)
            {
                report_Main tmpForm = new report_Main(_ReportServer, _ReportPath, ReportName, ReportTitle, rptParms);
                (target as frmDBAContainer).AddMDIChildForm(tmpForm);
            }
        }

        /// <summary>
        /// Modify this procedure to include the correct parameter name for the statement report on the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkPrintStatement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<ReportParameter> rptParms = new List<ReportParameter>();
            rptParms.Add(new ReportParameter("AccountNumber", AccountNumber));
            rptParms.Add(new ReportParameter("Quarter", "1"));
            runReport(_StatementReport, string.Format("Statement {0}", rptParms), rptParms);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DowntownBoiseAssociation.fn_GetAccountStatementResult data = (dataGridView1.Rows[e.RowIndex].DataBoundItem as DowntownBoiseAssociation.fn_GetAccountStatementResult);
                DBADataContext dc = new DBADataContext();
                switch (data.Type)
                {
                    case "LATE FEE":
                       
                        if (data.ReferenceGuid.HasValue && !data.ReferenceGuid.Value.Equals(Guid.Empty))
                        {
                            var trans = (from t in dc.Transactions
                                         where t.ReferenceGuid.Equals(data.ReferenceGuid)
                                         select t).FirstOrDefault();

                            var adjust = (from a in dc.Adjustments
                                          where a.Guid.Equals(data.ReferenceGuid)
                                          select a).FirstOrDefault();

                            MessageBox.Show(
                                string.Format("Description:\t{0}\nUser:\t\t{2}\nAmount:\t\t{3:c}", adjust.Note, trans.LegalEntity.AccountNumber, trans.Username, trans.Amount),
                                trans.Description,
                                MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(
                                string.Format("Amount:\t\t{0:c}", 0),
                                "STARTING BALANCE",
                                MessageBoxButtons.OK);
                        }
                        break;
                    case "INVOICE":
                        string[] InvoiceDesc = data.Description.Split(Convert.ToChar(" "));
                        int InvoiceNum = Convert.ToInt32(InvoiceDesc[1]);

                        var InvoiceList = from a in dc.InvoiceDetails
                                          join b in dc.Invoices
                                          on a.InvoiceId equals b.Id
                                          where a.InvoiceId == InvoiceNum
                                          select new
                                          {
                                              b.PostingDate,
                                              a.Description,
                                              a.Amount
                                          };

                        if (InvoiceList.Count() == 0) break;

                        string itxt;
                        List<string> StringInvoiseList = new List<string>();
                        decimal TotalAmount = 0;

                        foreach (var Item in InvoiceList)
                        {
                            itxt = "";
                            itxt += Item.PostingDate.ToString("MM/dd/yyyy");
                            itxt += "     " + Item.Amount.Value.ToString("$###,###,##0.00");
                            itxt += "     " + Item.Description + "\r\n";

                            TotalAmount += Item.Amount.Value;
                            StringInvoiseList.Add(itxt);
                        }

                        dialogSimpleListBox NewListBox = new dialogSimpleListBox("Invoice List Total - " + TotalAmount.ToString("$###,###,##0.00"), StringInvoiseList);
                        NewListBox.ShowDialog();
                        
                        break;
                    case "INVOICE ADJUSTMENT":
                        // run the Invoice report 
                        char[] delimiters = new char[] { ' ' };
                        string invNum = data.Description.Split(delimiters).Last();
                        List<ReportParameter> rptParms = new List<ReportParameter>();
                        //rptParms.Add(new ReportParameter("InvoiceId", invNum));
                        rptParms.Add(new ReportParameter("AccountNumber", AccountNumber));
                        rptParms.Add(new ReportParameter("Quarter", "5"));
                        runReport(_InvoiceReport, string.Format("{0} {1}", data.Type, AccountNumber), rptParms);
                        break;
                    case "BEGINNING BALANCE":
                    case "ADJUSTMENT":
                    case "COLLECTIONS":
                    case "PAYMENT":                    
                    case "WRITE-OFF":                        
                        if (data.ReferenceGuid.HasValue && !data.ReferenceGuid.Value.Equals(Guid.Empty))
                        {

                            var trans = (from t in dc.Transactions
                                         where t.ReferenceGuid.Equals(data.ReferenceGuid)
                                         select t).FirstOrDefault();

                            MessageBox.Show(
                                string.Format("Account Name:\t{0}\nAccount Number:\t{1}\nUser:\t\t{2}\nAmount:\t\t{3:c}", trans.LegalEntity.Name, trans.LegalEntity.AccountNumber, trans.Username, trans.Amount),
                                trans.Description,
                                MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(
                                string.Format("Amount:\t\t{0:c}", 0),
                                "STARTING BALANCE",
                                MessageBoxButtons.OK);
                        }
                        break;
                }
            }
        }

       
    }
}

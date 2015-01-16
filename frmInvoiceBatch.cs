using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Security.Principal;

namespace DowntownBoiseAssociation
{
    partial class frmInvoiceBatch : Form
    {
        public frmInvoiceBatch()
        {
            InitializeComponent();

            dateTimePicker1.MaxDate = DateTime.Today;

            DBADataContext dc = new DBADataContext();

            DateTime? accountingDate = dc.fn_GetAccountingPeriod();
            label4.Text = string.Format("Current accounting period is {0}", accountingDate.Value.ToString("MMMM yyyy"));

            var result = (from p in dc.vw_UnpostedInvoices
                          group p.Amount by true
                              into g
                              select new
                              {
                                  NoOfInvoices = g.Count(),
                                  SumOfInvoices = g.Sum()
                              }).FirstOrDefault();

            if (result != null)
            {
                lblCount.Text = result.NoOfInvoices.ToString();
                lblAmount.Text = string.Format("{0:c}", result.SumOfInvoices);
                okButton.Enabled = true;
            }

        }

        /// <summary>
        /// Before closing the form, post the invoices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            string login = id.Name;

            DBADataContext dc = new DBADataContext();
            dc.sp_PostInvoiceTransactions(login, dateTimePicker1.Value.Date);
        }
    }
}

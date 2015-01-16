using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Principal;

namespace DowntownBoiseAssociation
{
    public partial class frmLateFeeProcessing : Form
    {
        private string _Year;
        private int _Quarter;
        private DateTime _Date;
        DBADataContext db = new DBADataContext();
        
        public frmLateFeeProcessing(string FeeYear, int FeeQuarter, DateTime AccountingDate)
        {
            InitializeComponent();

            _Year = FeeYear;
            _Quarter = FeeQuarter;
            _Date = AccountingDate;

            this.Text = "Late Fee Processing for Quarter " + FeeQuarter.ToString() + " in " + FeeYear;
        }

        private void frmLateFeeProcessing_Load(object sender, EventArgs e)
        {            
            FillAccountList();
        }

       
        private void FillAccountList()
        {
            decimal LateFee = Convert.ToDecimal(ConfigurationManager.AppSettings["LateFee"].ToString());

            var Accounts = from a in db.sp_LateFees(_Quarter, LateFee, _Year)
                           select a;

            foreach (var Item in Accounts)
            {
                ListViewItem tmpItem = lvAccounts.Items.Add(new ListViewItem(Item.Name, 0));
                tmpItem.SubItems.Add(Item.AccountNumber.ToString());
                tmpItem.SubItems.Add(Item.AmountOwed.Value.ToString("###,##0.00"));
                tmpItem.SubItems.Add(Item.QuaterlyOwed.Value.ToString("###,##0.00"));
                tmpItem.SubItems.Add(Item.LateFee.Value.ToString("###,##0.00"));

                tmpItem.Checked = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in lvAccounts.Items)
            {
                Item.Checked = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in lvAccounts.Items)
            {
                Item.Checked = true;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string AccountNumber;
            decimal FeeAmount;

            WindowsIdentity id = WindowsIdentity.GetCurrent();
            string login = id.Name;

            pbProcessing.Minimum = 0;
            pbProcessing.Maximum = lvAccounts.Items.Count;
            int Counter = 0;
            foreach (ListViewItem Item in lvAccounts.Items)
            {
                Counter++;
                pbProcessing.Value = Counter;

                if (Item.Checked)
                {
                    AccountNumber = Item.SubItems[1].Text;
                    string FeeAmountStr = Item.SubItems[4].Text;

                    FeeAmount = Convert.ToDecimal(FeeAmountStr);

                    db.sp_InsAdjustment(AccountNumber, _Date, "LATE FEE - Quarter " + _Quarter.ToString() + " - " + _Year, "LATE FEE", login, FeeAmount);
                    Item.Checked = false;
                }
            }
            MessageBox.Show("Processing Done.");
            this.Close();
        }
    }   
}

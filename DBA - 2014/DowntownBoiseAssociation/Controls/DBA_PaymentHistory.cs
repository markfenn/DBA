using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    public partial class DBA_PaymentHistory : UserControl
    {
        int _LegalEntityId;

        public DBA_PaymentHistory()
        {
            InitializeComponent();
        }

        private void DBA_PaymentHistory_Load(object sender, EventArgs e)
        {
            FillDropDown();
        }

        public int LegalEntityId
        {
            get { return _LegalEntityId; }
            set { _LegalEntityId = value; }
        }

        public void FillDropDown()
        {
            DBADataContext db = new DBADataContext();

            var BillingPeriods = from a in db.Transactions
                                 where a.LegalEntityId == _LegalEntityId &&
                                 a.Type == "BEGINNING BALANCE"
                                 select a;


            if (BillingPeriods.Count() == 0)
            {
                ComboBoxItem NewItem = new ComboBoxItem();
                NewItem.DisplayValue = "BEGINNING BALANCE - New";
                NewItem.ItemValueInt = 0;

                cbBillingPeriod.Items.Add(NewItem);
            }

            foreach (var Item in BillingPeriods)
            {
                ComboBoxItem NewItem = new ComboBoxItem();
                NewItem.DisplayValue = Item.Type + " - " + Item.PostingDate.Value.ToString("MM yyyy");
                NewItem.ItemValueInt = Item.Id;

                cbBillingPeriod.Items.Add(NewItem);
            }

            cbBillingPeriod.DisplayMember = "DisplayValue";
            cbBillingPeriod.ValueMember = "ItemValueInt";
        }

        private void cbBillingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBADataContext db = new DBADataContext();

            int BeginningTransactionId;
            int EndingTransactionId;

            int LastTransactionId = (from a in db.Transactions
                                     where a.LegalEntityId == _LegalEntityId                                     
                                     select a.Id).Max();
            
            BeginningTransactionId = (cbBillingPeriod.Items[cbBillingPeriod.SelectedIndex] as ComboBoxItem).ItemValueInt;
            try
            {
                EndingTransactionId = (cbBillingPeriod.Items[cbBillingPeriod.SelectedIndex + 1] as ComboBoxItem).ItemValueInt - 1;
            }
            catch
            {
                try
                {
                    EndingTransactionId = LastTransactionId;
                }
                catch
                {
                    EndingTransactionId = 0;
                }
            }
                        
            var TransactionHistory = from a in db.Transactions
                                     where a.LegalEntityId == _LegalEntityId &&
                                     a.Id >= BeginningTransactionId &&
                                     a.Id <= EndingTransactionId
                                     select a;

            if (TransactionHistory.Count() == 0) return;

            List<TransactionItem> TransactionList = new List<TransactionItem>();

            decimal Bal = 0;
            foreach (var Item in TransactionHistory)
            {
                TransactionItem NewItem = new TransactionItem();
                NewItem.AccountingDate = Item.AccountingDate.Value.ToString("MM/dd/yyyy");
                NewItem.Amount = Item.Amount.Value;
                NewItem.Description = Item.Description;
                NewItem.Id = Item.Id;
                NewItem.PostingDate = Item.PostingDate.Value.ToString("MM/dd/yyyy");
                NewItem.Type = Item.Type;

                Bal += Item.Amount.Value;
                NewItem.Balance = Bal;

                TransactionList.Add(NewItem);
            }

            dgStatement.DataSource = TransactionList;            
        }
    }

    public class TransactionItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string PostingDate { get; set; }
        public string AccountingDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
    }

    public class ComboBoxItem
    {
        public string DisplayValue { get; set; }
        public int ItemValueInt { get; set; }
        public string ItemValueStr { get; set; }
    }
}

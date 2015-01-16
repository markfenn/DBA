using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation
{
    public partial class dialogMisappliedPayment : Form
    {
        DBADataContext db = new DBADataContext();

        public dialogMisappliedPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lblLegalEntity.Text.Trim() == "")
            {
                MessageBox.Show("Legal Entity Account Number must have a valid value.");
                return;
            }

            if (lblPayment.Text.Trim() == "")
            {
                MessageBox.Show("Payment Number must have a valid value.");
                return;
            }

            if (MessageBox.Show("Continue with payment change?", "Misapplied Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            DBADataContext db2 = new DBADataContext();

            int PaymentNo = 0;
            try
            {
                PaymentNo = int.Parse(txtPaymentNumber.Text);
            }
            catch { return; }

            Payment PaymentItem = (from a in db2.Payments
                                   where a.Id == PaymentNo
                                   select a).FirstOrDefault();
            if (PaymentItem == null)
            {
                MessageBox.Show("Incorrect Payment Number.");
                return;
            }

            LegalEntity LEItem = (from a in db.LegalEntities
                                  where a.AccountNumber == txtAccountNumber.Text.Trim().Replace("-", "")
                                  select a).FirstOrDefault();
            if (LEItem == null)
            {
                MessageBox.Show("Incorrect Legal Entity Account Number.");
                return;
            }

            Transaction TransactionItem = (from a in db2.Transactions
                                           where a.Description == "PAYMENT " + txtPaymentNumber.Text.Trim()
                                           select a).FirstOrDefault();
            if (TransactionItem == null)
            {
                MessageBox.Show("Incorrect Transaction Record.");
                return;
            }

            PaymentItem.LegalEntityId = LEItem.Id;
            TransactionItem.LegalEntityId = LEItem.Id;
            db2.SubmitChanges();

            MessageBox.Show("Complete.");
            this.Close();
        }

        private void dialogMisappliedPayment_Load(object sender, EventArgs e)
        {            
        }

        private void txtPaymentNumber_Leave(object sender, EventArgs e)
        {
            lblPayment.Text = "";
            btnAccept.Enabled = false;

            int PaymentNo = 0;
            try
            {
                PaymentNo = int.Parse(txtPaymentNumber.Text);
            }
            catch { return; }

            Payment PaymentItem = (from a in db.Payments
                            where a.Id == PaymentNo
                            select a).FirstOrDefault();
            if (PaymentItem == null) return;

            LegalEntity LEItem = (from a in db.LegalEntities
                                  where a.Id == PaymentItem.LegalEntityId
                                  select a).FirstOrDefault();

            lblPayment.Text = PaymentItem.Date.Value.ToString("MM/dd/yyyy") + " - " + LEItem.AccountNumber.Trim() + " - " + PaymentItem.Amount.Value.ToString("$###,###,##0.00") +
                "\r\n" + LEItem.Name.Trim();
                        
            if ((lblLegalEntity.Text.Trim() != "") && (lblPayment.Text.Trim() != "")) btnAccept.Enabled = true;
        }

        private void txtAccountNumber_Leave(object sender, EventArgs e)
        {
            lblLegalEntity.Text = "";
            btnAccept.Enabled = false;

            LegalEntity LEItem = (from a in db.LegalEntities
                                  where a.AccountNumber == txtAccountNumber.Text.Trim().Replace("-","")
                                  select a).FirstOrDefault();
            if (LEItem == null) return;

            lblLegalEntity.Text = LEItem.Name.Trim();
                        
            if ((lblLegalEntity.Text.Trim() != "") && (lblPayment.Text.Trim() != "")) btnAccept.Enabled = true;
        }
    }
}

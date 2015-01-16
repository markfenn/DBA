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
    public partial class dialogAddAdjustment : Form
    {
        public dialogAddAdjustment()
        {
            InitializeComponent();
            DBADataContext dc = new DBADataContext();
            DateTime? accountingDate = dc.fn_GetAccountingPeriod();
            label5.Text = string.Format("Current accounting period is {0}", accountingDate.Value.ToString("MMMM yyyy"));
            DateInput.MaxDate = DateTime.Today;
        }

        public String AdjustmentType {
            set { CategoryInput.DataSource = value.Split(Convert.ToChar(",")); }                 
        }

        private void AmountInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] myChars = { '\b', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '.' };
            char c = e.KeyChar;
            e.Handled = !myChars.Contains(c);
        }

        private void dialogAddAdjustment_Shown(object sender, EventArgs e)
        {
            CategoryInput.SelectedIndex = 0;
        }

        private void DescriptionInput_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                errorProvider1.SetError((Control)sender, "");
            }
            else
            {
                errorProvider1.SetError((Control)sender, "Required Field");
                e.Cancel = true;
            }
        }

        private void AmountInput_Validating(object sender, CancelEventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(AmountInput.Text, out amount))
            {
                errorProvider1.SetError((Control)sender, "");
            }
            else
            {
                errorProvider1.SetError((Control)sender, "Invalid Amount");
                e.Cancel = true;
            }
        }

        private void dialogAddAdjustment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                e.Cancel = (!string.IsNullOrEmpty(errorProvider1.GetError(AmountInput)) || !string.IsNullOrEmpty(errorProvider1.GetError(NoteInput)));
            }
        }

        public decimal Amount
        {
            get
            {
                decimal tmp;
                if (decimal.TryParse(AmountInput.Text, out tmp))
                {
                    return tmp;
                }
                else return 0m;
            }
        }

        public String Category
        {
            get { return CategoryInput.Text; }
        }

        public DateTime Date
        {
            get { return DateInput.Value.Date; }
        }

        public string Note
        {
            get { return NoteInput.Text; }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
             
    }
}

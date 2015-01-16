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
    public partial class frmLateFeeProcessingDialog : Form
    {
        public frmLateFeeProcessingDialog()
        {
            InitializeComponent();
        }

        private void frmLateFeeProcessingDialog_Load(object sender, EventArgs e)
        {
            cbYear.Items.Add("- Select Value -");
            cbYear.Items.Add(DateTime.Now.AddYears(-1).Year.ToString());
            cbYear.Items.Add(DateTime.Now.Year.ToString());

            cbQuarter.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if ((cbYear.Text.Trim() == "- Select Value -") ||
                (cbQuarter.Text.Trim() == "- Select Value -"))
            {
                MessageBox.Show("Please select a value for Year and Quarter.");
                return;
            }

            frmDBAContainer ThisParent = (frmDBAContainer)this.Tag;

            frmLateFeeProcessing newform = new frmLateFeeProcessing(cbYear.Text, cbQuarter.SelectedIndex, DateInput.Value.Date);
            ThisParent.AddMDIChildForm(newform);

            this.Close();
        }
    }
}

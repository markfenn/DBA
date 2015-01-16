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
    public partial class dialogPerformBilling : Form
    {
        public dialogPerformBilling()
        {
            InitializeComponent();
            cboYear.Items.Add(DateTime.Today.Year - 1);
            cboYear.Items.Add(DateTime.Today.Year);
            cboYear.Items.Add(DateTime.Today.Year + 1);
            cboYear.SelectedIndex = 1;
        }

        private void rbSpaces_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                dialogSearchAddress dlg = new dialogSearchAddress();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    (sender as Control).Tag = dlg.AddressId;
                }
                else
                {
                    rbEverything.Checked = true;
                }
            }
        }

        private void rbLegalEntity_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                dialogSearchLegalEntity dlg = new dialogSearchLegalEntity();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    (sender as Control).Tag = dlg.LegalEntityId;
                }
                else
                {
                    rbEverything.Checked = true;
                }
            }
        }

        public int Year
        {
            get
            {
                int year;
                if (int.TryParse(cboYear.SelectedItem.ToString(), out year))
                    return year;
                else
                    return DateTime.Today.Year;
            }
        }

        public ProcessingType ProcessingType
        {
            get
            {
                if (rbEverything.Checked)
                    return ProcessingType.All;
                else if (rbLegalEntity.Checked)
                    return ProcessingType.LegalEntity;
                else
                    return ProcessingType.SelectedSpace;
            }
        }

        public int AddressId
        {
            get
            {
                if (ProcessingType == ProcessingType.SelectedSpace)
                    return (int)rbSpaces.Tag;
                else
                    throw new Exception("There is no valid address Id selected");
            }
        }

        public int LegalEntityId
        {
            get
            {
                if (ProcessingType == ProcessingType.LegalEntity)
                    return (int)rbLegalEntity.Tag;
                else
                    throw new Exception("There is no valid legal entity Id selected");
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }

    public enum BillingType { Bills, Adjustments }

    public enum ProcessingType { All, LegalEntity, SelectedSpace }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation
{
    public partial class frmMaintainRates : Form
    {
        DBADataContext dc = null;

        public frmMaintainRates()
        {
            InitializeComponent();
            dateTimePicker1.Value = Convert.ToDateTime("01/01/2000");
        }

        private void UpdateGridView(DateTime AsOfDate)
        {
            if ((dc != null) && (dc.Changed()))
            {
                switch (MessageBox.Show("There are unsaved changes. Do you want to save your changes first?", "Save Changes?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        SaveChanges();
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }
            dc = new DBADataContext();
            rateFrequencyDataGridViewTextBoxColumn.DataSource = dc.AttributeNames();
            zoneBindingSource.DataSource = dc.vw_Zones;
            rateMasterBindingSource.DataSource = from r in dc.fn_GetRateMaster(AsOfDate)
                                                 orderby r.RateCode
                                                 select r;
        }

        private void dateValueChanged(object sender, EventArgs e)
        {
            UpdateGridView(dateTimePicker1.Value.Date);
        }

        private void frmMaintainRates_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dc.Changed())
            {
                switch (MessageBox.Show("The rates data has changed. Do you want to save the changes before closing?", "Save Changes?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        SaveChanges();
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveChanges()
        {
            try
            {
                // before saving, change the AsOfDate to be the currently selected date
                List<object> changes = new List<object>(dc.GetChangeSet().Inserts);
                changes.InsertRange(0, dc.GetChangeSet().Updates);

                foreach (var item in changes)
                {
                    if (item is RateMaster)
                    {
                        (item as RateMaster).AsOfDate = dateTimePicker1.Value.Date;
                    }
                }

                dc.SubmitChanges();
            }
            catch
            {
                foreach (var item in dc.ChangeConflicts)
                {
                    MessageBox.Show(item.Object.ToString());
                }
            }
            rateMasterBindingSource.DataSource = from r in dc.fn_GetRateMaster(dateTimePicker1.Value.Date)
                                                 orderby r.RateCode
                                                 select r;
        }

        /// <summary>
        /// Launch rules editor for this Rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DowntownBoiseAssociation.RateMaster rm = (dataGridView1.Rows[e.RowIndex].DataBoundItem as RateMaster);
                switch (e.ColumnIndex)
                {
                    case 6:
                        frmRateMasterRules frm = new frmRateMasterRules(rm);
                        frm.ShowDialog();
                        break;
                    case 7:
                        dateTimePicker1.Value = rm.AsOfDate;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(
@"You are about to delete the version of the rate master record you are currently viewing. 
You will need to accept changes or cancel before any earlier record for this rate code is visible.
Do you want to delete this version of the rate master record?",
                                   "Confirm Delete",
                                   MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    try
                    {
                        rateMasterBindingSource.RemoveCurrent();
                    }
                    catch (Exception ex)
                    {
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (rateMasterBindingSource.Current == null);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

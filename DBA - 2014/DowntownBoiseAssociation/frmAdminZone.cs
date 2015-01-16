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
    public partial class frmAdminZone : Form
    {
        DBADataContext dc = new DBADataContext();
        int _ZoneId = 0;
        int _BlockId;
        int _BuildingId;
        
        public frmAdminZone()
        {
            InitializeComponent();
            zoneBindingSource.DataSource = dc.Zones;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public int ZoneId
        {
            get { return _ZoneId; }
            set 
            { 
                _ZoneId = value;
                //LookupEntry();
            }
        }

        public int BlockId
        {
            get { return _BlockId; }
            set 
            { 
                _BlockId = value;
                //LookupEntry();
            }
        }

        public int BuildingId
        {
            get { return _BuildingId; }
            set 
            {
                //zoneBindingSource.DataSource = null;
                _BuildingId = value;
                zoneBindingSource.DataSource = dc.Zones;
                //LookupEntry();
            }
        }

        private void SaveChanges()
        {
            try
            {
                dc.SubmitChanges();
            }
            catch 
            {
                foreach (var item in dc.ChangeConflicts)
                {
                    MessageBox.Show(item.Object.ToString());
                }
            }
        }

        private void frmAdminZone_Load(object sender, EventArgs e)
        {
            LookupEntry();
        }

        public void LookupEntry()
        {           
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;

            if (_ZoneId > 0)
            {
                dataGridView1.Select();
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                {
                    if (dataGridView1.Rows[x].Cells[0].Value.ToString() == _ZoneId.ToString())
                    {
                        dataGridView1.Rows[x].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[x].Cells[1];

                        dataGridView1.Refresh();
                        dataGridView2.Refresh();
                        dataGridView3.Refresh();

                        break;
                    }
                }
            }

            if (_BlockId > 0)
            {
                dataGridView2.Select();
                for (int x = 0; x < dataGridView2.Rows.Count; x++)
                {
                    if (dataGridView2.Rows[x].Cells[0].Value.ToString() == _BlockId.ToString())
                    {
                        dataGridView2.CurrentCell = dataGridView2.Rows[x].Cells[1];
                        dataGridView2.Rows[x].Selected = true;

                        dataGridView1.Refresh();
                        dataGridView2.Refresh();
                        dataGridView3.Refresh();

                        break;
                    }
                }
            }

            if (_BuildingId > 0)
            {
                dataGridView3.Select();
                for (int x = 0; x < dataGridView3.Rows.Count; x++)
                {
                    if (dataGridView3.Rows[x].Cells[0].Value.ToString() == _BuildingId.ToString())
                    {
                        dataGridView3.CurrentCell = dataGridView3.Rows[x].Cells[1];
                        dataGridView3.Rows[x].Selected = true;

                        dataGridView1.Refresh();
                        dataGridView2.Refresh();
                        dataGridView3.Refresh();

                        break;
                    }
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, zoneBindingSource.DataSource);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Make sure they have the chance to save any changes to this window before it closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdminZone_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing");
            if (dc.Changed())
            {
                switch (MessageBox.Show("The zone data has changed. Do you want to save the changes before closing?", "Save Changes?", MessageBoxButtons.YesNoCancel))
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

        /// <summary>
        /// Show a modal edit dialog that sets the streets for the block just clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("you clicked on a cell");
        }

        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("BindingComplete");
        }

        private void dataGridView3_BindingContextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("BindingContextChanged");
        }       
    }
}

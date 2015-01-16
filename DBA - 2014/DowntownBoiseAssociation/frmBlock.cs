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
    public partial class frmBlock : Form
    {
        DBADataContext dc = new DBADataContext();

        private int _BlockNo = 0;
        private Block _CurrentBlock;

        // private  DataSet dcBlockSelect();
        public frmBlock(int BlockNo)
        {
            InitializeComponent();

            _BlockNo = BlockNo;

            if (_BlockNo == 0)
            {
            }
            else
            {

                GetBlockInformation(_BlockNo);

                linkBlockSelect.Enabled = false;

                ReloadData();
            }

            cmbSubdivision.DataSource = dc.vw_SubdivisionNames;
            cmbSubdivision.DisplayMember = "SUBNM";
            cmbSubdivision.ValueMember = "SUBNM";

            cmbSubdivision.SelectedIndex = -1;                       
        }

        private void frmBlock_Load(object sender, EventArgs e)
        {
            zoneBindingSource.DataSource = dc.Zones;
                       
            DataGridViewComboBoxColumn dgcStreet = grdStreets.Columns[0] as DataGridViewComboBoxColumn;
            dgcStreet.DataSource = dc.Streets;
            dgcStreet.DisplayMember = "Name";
            dgcStreet.ValueMember = "Id";

            cmbSubdivision.SelectedValue = "";
            cboZoneId.SelectedValue = "";
            
            grdStreets.AutoGenerateColumns = false;          
        }



        private void ReloadData()
        {
            dc = new DBADataContext();
            blockBindingSource.DataSource = from c in dc.Blocks
                                            orderby c.Name
                                            where c.BlockNumber == _BlockNo
                                            select c;
        }
           

        private void btnApply_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
            MessageBox.Show("Block Saved.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();          
        }

        private void grdStreets_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = (e.ColumnIndex == 0);
        }
      
        private void grdBuildings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bldgid = (int)grdBuildings.Rows[e.RowIndex].Cells[0].Value;
            frmBuilding fBldg = new frmBuilding(bldgid);
            
            frmDBAContainer dbaCont = this.MdiParent as frmDBAContainer;
            dbaCont.AddMDIChildForm(fBldg);
        }
        
        private void txtCityBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48) || (e.KeyValue > 57))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void frmBlock_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dc.Changed())
            {
                switch (MessageBox.Show("The data has changed. Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        dc.SubmitChanges();
                        break;

                }
            }
        }

        private void linkBlockSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmBlockSelector NewListForm;

            NewListForm = new frmBlockSelector(SelectionType.Block, true, false);
            NewListForm.ShowDialog();

            if (NewListForm.SelectedObjects.Count() == 0) return;
            
            _BlockNo = Convert.ToInt32(NewListForm.SelectedObjects[0]);

            GetBlockInformation(_BlockNo);

            ReloadData();
        }

        private void GetBlockInformation(int BlockId)
        {
            _CurrentBlock = (from a in dc.Blocks
                             where a.BlockNumber == _BlockNo
                             select a).FirstOrDefault();

            if (_CurrentBlock == null)
            {
                _BlockNo = 0;
                btnApply.Enabled = false;
                return;
            }

            linkBlockSelect.Text = _CurrentBlock.BlockNumber.ToString();

            //linkBlockSelect.Enabled = false;
            this.Text = "Block - " + _BlockNo.ToString();
            btnApply.Enabled = true;
        }    
    }
}




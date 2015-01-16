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
    public partial class frmZoneMaint : Form
    {
        DBADataContext db = new DBADataContext();
        private int _ZoneId = 0;
        private bool _NewWindow = true;
               
        public frmZoneMaint(int ZoneId)
        {
            InitializeComponent();

            _ZoneId = ZoneId;
        }

        private void FillList()
        {
            var ZoneList = from a in db.Zones
                           select new
                           {
                               ZoneName = a.Id.ToString() + "     " + a.Name,
                               ZoneId = a.Id
                           };

            lbZones.DataSource = ZoneList;
            lbZones.DisplayMember = "ZoneName";
            lbZones.ValueMember = "ZoneId";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if ((txtId.Text.Trim() == "") || (txtName.Text.Trim() == ""))
            {
                MessageBox.Show("Id and Name must have a value.");
                return;
            }

            int tempInt;
            try 
            {
                tempInt = Convert.ToInt32(txtId.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("Id must be a number greater than zero.");
                return;
            }

            if (tempInt <= 0)
            {
                MessageBox.Show("Id must be a number greater than zero.");
                return;
            }


            if (_NewWindow)
            {
                Zone NewZone = new Zone
                {
                    Id = tempInt,
                    Name = txtName.Text.Trim()
                };

                db.Zones.InsertOnSubmit(NewZone);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                Zone EditZone = (from a in db.Zones
                                 where a.Id == tempInt
                                 select a).FirstOrDefault();

                EditZone.Name = txtName.Text.Trim();
                db.SubmitChanges();
            }
            
            FillList();

            MessageBox.Show("Zone Saved.");
        }

        private void dialogZoneMaint_Load(object sender, EventArgs e)
        {
            if (_ZoneId == 0) _NewWindow = true;
            else _NewWindow = false;

            SetupWindow();
            FillList();

            txtId.Focus();

        }

        private void SetupWindow()
        {
            if (_NewWindow)
            {
                this.Text = "Zone - New";
                btnDelete.Visible = false;
            }
            else
            {
                Zone CurrentZone = (from a in db.Zones
                                    where a.Id == _ZoneId
                                    select a).FirstOrDefault();

                if (CurrentZone == null)
                {
                    _NewWindow = true;
                    this.Text = "Zone - New";
                    _ZoneId = 0;
                    return;
                }

                this.Text = "Zone - " + CurrentZone.Name;
                txtId.Text = CurrentZone.Id.ToString();
                txtName.Text = CurrentZone.Name;
                txtId.Enabled = false;

                btnDelete.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var AffectedBlocks = from a in db.Blocks
                                 where a.ZoneId == _ZoneId
                                 select a;

            Zone CurrentZone = (from a in db.Zones
                                where a.Id == _ZoneId
                                select a).FirstOrDefault();

            if (CurrentZone == null) return;

            if (AffectedBlocks.Count() > 0)
            {
                MessageBox.Show("This Zone has " + AffectedBlocks.Count().ToString() + 
                    " Blocks associated with it. It can not be deleted until the Blocks " +
                    "are deleted or moved to a differenct Zone.");
                return;
            }
            
            if (MessageBox.Show("Deleting Zone - " + CurrentZone.Name + "\r\n\r\n" +
                "Do you wish to continue?", "Delete Zone", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                 DialogResult.No)
            {
                return;
            }
            
            db.Zones.DeleteOnSubmit(CurrentZone);
            db.SubmitChanges();

            FillList();

            MessageBox.Show("Delete of Zone complete.");
        }

        private void btnEditZone_Click(object sender, EventArgs e)
        {
            if (lbZones.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a Zone first.");
                return;
            }

            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)ParentForm;

            frmZoneMaint NewZone = new frmZoneMaint((int)lbZones.SelectedValue);

            NewContainer.AddMDIChildForm(NewZone);        
        }

       
    }
}

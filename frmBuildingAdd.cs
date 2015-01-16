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
    public partial class frmBuildingAdd : Form
    {
        DBADataContext db = new DBADataContext();
        DBA.DataClassesSmallDataContext dbsmall = new DBA.DataClassesSmallDataContext();
        int BlockNumber = 0;
        int AddressId = 0;
       
        public frmBuildingAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {           

            if (BlockNumber == 0)
            {
                MessageBox.Show("Please select a Block.");
                return;
            }

            if (AddressId == 0)
            {
                MessageBox.Show("Please select an Address.");
                return;
            }

            if (txtBuildingName.Text.Trim() == "")
            {
                MessageBox.Show("Building must have a name.");
                return;
            }


            // DOES THE BUILDING NAME ALREADY EXIST
            Building ExistingBuilding = (from a in db.Buildings
                                   where a.Name.Trim().ToUpper() == txtBuildingName.Text.Trim().ToUpper()
                                   select a).FirstOrDefault();

            if (ExistingBuilding != null)
            {
                MessageBox.Show("Building Name already exists, please enter a different one.");
                return;
            }

            // CREATE THE NEW BUILDING
            // Get the current block
            Block ExistingBlock = (from a in db.Blocks
                                   where a.BlockNumber == BlockNumber
                                   select a).FirstOrDefault();


            DBA.Building NewBuilding = new DBA.Building
            {
                Name = txtBuildingName.Text.Trim(),
                BlockId = ExistingBlock.Id,
                AddressId = AddressId
            };

            dbsmall.Buildings.InsertOnSubmit(NewBuilding);
            dbsmall.SubmitChanges();
                        
            MessageBox.Show("Building Added.");

            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)this.Tag;

            frmBuilding EditBuilding = new frmBuilding(NewBuilding.Id);
            NewContainer.AddMDIChildForm(EditBuilding);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBlockSelector SelectZone = new frmBlockSelector(SelectionType.Block, true, false);
            SelectZone.ShowDialog();

            List<string> SelectedZones = SelectZone.SelectedGroups;

            if (SelectedZones.Count() == 0) return;

            string[] ZoneArray = SelectedZones[0].Split(Convert.ToChar("-"));

            Block GetBlock = (from a in db.Blocks
                              where a.BlockNumber == SelectZone.SelectedObjects[0]
                              select a).FirstOrDefault();
            
            if (GetBlock == null) return;

            BlockNumber = GetBlock.BlockNumber;

            linkZone.Text = GetBlock.BlockNumber.ToString();


        }

        private void linkAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchAddress GetAddress = new dialogSearchAddress();
            GetAddress.ShowDialog();

            if (GetAddress.AddressId == 0) return;

            Address FindAddress = (from a in db.Addresses
                                   where a.Id == GetAddress.AddressId
                                   select a).FirstOrDefault();

            if (FindAddress == null) return;

            AddressId = FindAddress.Id;

            linkAddress.Text = Classes.AddressHelper.FormatAddress(AddressId);


        }
    }
}

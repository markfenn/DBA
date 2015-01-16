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
    public partial class frmBuilding : Form
    {
        DBADataContext dc = new DBADataContext();
        DBA.DataClassesSmallDataContext dbsmall = new DBA.DataClassesSmallDataContext();

        int SpacesCount;
        int VacantCount;
        int AddressId;
        int BillingLE;
       
        int _BuildingId;
        Building _Building;
        Block _Block;
        Form _MyParent;

        public int BuildingId
        {
            get
            {
                return _BuildingId;
            }
        }
        public Form MyParent
        {
            get
            {
                return _MyParent;
            }
            set
            { 
                _MyParent = value; 
            }
        }

        public void AppInfo()
        {
            StringBuilder itxt = new StringBuilder();
            itxt.Append("BUILDING INFORMATION");
            itxt.Append("\r\n\r\n");
            itxt.Append("Building Id: " + _Building.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Block Id: " + _Building.Block.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Address Id: " + _Building.AddressId.ToString());
            itxt.Append("\r\n");
            itxt.Append("Guid: " + _Building.Guid.ToString());
            

            txtAppInfo.Text = itxt.ToString();
        }

        public frmBuilding(int BuildingId)
        {
            //MessageBox.Show("1");
            _BuildingId = BuildingId;

            InitializeComponent();
            
            buildingBindingSource.DataSource = from c in dc.Buildings
                                               orderby c.Name
                                               where c.Id.Equals(BuildingId)
                                               select c;
            //MessageBox.Show("2");
            _Building = (from a in dc.Buildings
                         where a.Id == BuildingId
                         select a).FirstOrDefault();

           // MessageBox.Show("3");
            _Block = (from a in dc.Blocks
                      where a.Id == _Building.BlockId
                      select a).FirstOrDefault();

            //MessageBox.Show("4");
            this.Text = "Building - " + _Building.Name;

            CommentDisplayBuilding.ObjectGuid = _Building.Guid.Value;
            ContactDisplayBuilding.ObjectGuid = _Building.Guid.Value;
            editProperties1.ObjectGuid = _Building.Guid.Value;
            grdTenants.AutoGenerateColumns = false;

           // MessageBox.Show("5");
            DBA.Building BuildingSmall = (from a in dbsmall.Buildings
                                          where a.Id == BuildingId
                                          select a).FirstOrDefault();


            //MessageBox.Show("6");
            if (BuildingSmall == null) return;
            if (BuildingSmall.AddressId == null) return;

            AddressId = BuildingSmall.AddressId.Value;

            linkAddress.Text = Classes.AddressHelper.FormatAddress(BuildingSmall.AddressId.Value);
            //MessageBox.Show("7");
            AppInfo();
            
        }

        private void GetBuildingBillingLE()
        {
            var SpaceList = from a in dc.Spaces
                            where a.BuildingId == _BuildingId
                            select a;

            linkBuildingBillingLE.Text = "Not Found";
            linkBuildingBillingLE.Enabled = false;

            if (SpaceList.Count() > 0)
            {
                foreach (Space Item in SpaceList)
                {
                    if (frmTenant.GetPropertyValue(Item.Guid.Value, "Space Type") == "Building Regular")
                    {
                        try
                        {
                            SpaceOwner SpaceOwnerItem = (from a in dc.SpaceOwners
                                                         where a.SpaceId == Item.Id
                                                         orderby a.AsOfDate descending
                                                         select a).FirstOrDefault();

                            LegalEntity LegalEntityItem = (from a in dc.LegalEntities
                                                           where a.Id == SpaceOwnerItem.LegalEntityId
                                                           select a).FirstOrDefault();

                            BillingLE = LegalEntityItem.Id;
                            linkBuildingBillingLE.Enabled = true;
                            linkBuildingBillingLE.Text = LegalEntityItem.Name;
                        }
                        catch { }
                    }
                }
                if (linkBuildingBillingLE.Text == "Not Found")
                {
                    foreach (Space Item in SpaceList)
                    {
                        if ((frmTenant.GetPropertyValue(Item.Guid.Value, "Space Type") == "Building") || (frmTenant.GetPropertyValue(Item.Guid.Value, "Space Type") == "Parking"))
                        {
                            try
                            {
                                SpaceOwner SpaceOwnerItem = (from a in dc.SpaceOwners
                                                             where a.SpaceId == Item.Id
                                                             orderby a.AsOfDate descending
                                                             select a).FirstOrDefault();

                                LegalEntity LegalEntityItem = (from a in dc.LegalEntities
                                                               where a.Id == SpaceOwnerItem.LegalEntityId
                                                               select a).FirstOrDefault();

                                BillingLE = LegalEntityItem.Id;
                                linkBuildingBillingLE.Enabled = true;
                                linkBuildingBillingLE.Text = LegalEntityItem.Name;
                            }
                            catch { }
                        }
                    }
                }
            }                        
        }


        private void frmBuilding_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("8");
            buildingBindingSource.DataSource = from c in dc.Buildings
                                               orderby c.Name
                                               where c.Id.Equals(BuildingId)
                                               select c;
            //MessageBox.Show("9");

            var Spaces = from a in dc.vw_Spaces
                         where a.BuildingId == _BuildingId
                         select a;

            //MessageBox.Show("10");

            grdTenants.DataSource = Spaces;


            //MessageBox.Show("11");

            foreach (var Item in Spaces)
            {
                SpacesCount++;
                if (Item.TenantId == 0) { VacantCount++; }
            }
            lblSpaces.Text = string.Format("This building contains {0} Spaces, of which {1} are vacant.", SpacesCount, VacantCount);

            //MessageBox.Show("12");

            if (_Block == null)
            {
                btnBlock.Text = "1";
            }
            else
            {
                btnBlock.Text = _Block.BlockNumber.ToString();
            }

            //MessageBox.Show("13");
            try
            {
                (this.ParentForm as frmDBAContainer).AddControlListItem("BUILDING", this.Text, 0);
            }
            catch { }

            GetBuildingBillingLE();
        }
         
        private void grdTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            if (grdTenants.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "VACANT") 
            { return; }

            frmDBAContainer dbaContainer = this.MdiParent as frmDBAContainer;

            if (e.ColumnIndex == 0)
            {                
                int SpaceId = (int)grdTenants.Rows[e.RowIndex].Cells[2].Value;
                frmSpace formSpace = new frmSpace(SpaceId, _BuildingId);
                dbaContainer.AddMDIChildForm(formSpace);
            }

            if (e.ColumnIndex == 1)
            {                
                int TenantId = (int)grdTenants.Rows[e.RowIndex].Cells[3].Value;
                frmTenant formTenant = new frmTenant(TenantId);
                dbaContainer.AddMDIChildForm(formTenant);
            }            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int NewAddressId = 0;

            int NewBlockId = (from a in dc.Blocks
                              where a.BlockNumber == Convert.ToInt32(btnBlock.Text)
                              select a.Id).FirstOrDefault();

            if (NewBlockId == 0)
            {
                MessageBox.Show("Building save error: bad Block Number");
                return;
            }

            if (AddressId == 0)
            {
                MessageBox.Show("Building save error: No address.");
                return;
            }   

            _Building.BlockId = NewBlockId;
            dc.SubmitChanges();

            dbsmall = new DBA.DataClassesSmallDataContext();
            DBA.Building NewBuilding = (from a in dbsmall.Buildings
                                        where a.Id == _Building.Id
                                        select a).FirstOrDefault();

            NewBuilding.AddressId = AddressId;
            dbsmall.SubmitChanges();
            editProperties1.SaveChanges();

            MessageBox.Show("Building Saved.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void ReloadData()
        {           
            buildingBindingSource.DataSource = from c in dc.Buildings
                                               orderby c.Name
                                               where c.Id.Equals(BuildingId)
                                               select c;
                     
            vwTenantListingbyBuildingBindingSource.DataSource = from b in dc.vw_TenantListingbyBuildings
                                                                orderby b.Name
                                                                where b.BuildingId.Equals(BuildingId)
                                                                select b;
        }

        private void grdTenants_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (grdTenants.Rows[e.RowIndex].Cells[1].Value.ToString() == "VACANT")
            {
                DataGridViewCell Cell = new DataGridViewLinkCell();
                (grdTenants.Rows[e.RowIndex].Cells[1] as DataGridViewLinkCell).LinkBehavior = LinkBehavior.NeverUnderline;
                (grdTenants.Rows[e.RowIndex].Cells[1] as DataGridViewLinkCell).LinkColor = System.Drawing.Color.Black;
                (grdTenants.Rows[e.RowIndex].Cells[1] as DataGridViewLinkCell).VisitedLinkColor = System.Drawing.Color.Black;                
            }
        }

        private void btnCreateSpace_Click(object sender, EventArgs e)
        {            
            frmSpace NewSpace = new frmSpace(0, _BuildingId);
            NewSpace.ShowDialog();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            frmBlockSelector NewBlock = new frmBlockSelector(SelectionType.Block, true, false);
            List<int> SelectedBlock = new List<int>();

            SelectedBlock.Add(Convert.ToInt32(btnBlock.Text));

            NewBlock.SelectedObjects = SelectedBlock;

            NewBlock.ShowDialog();

            if (NewBlock.DialogResult == DialogResult.OK)
            {
                btnBlock.Text = NewBlock.SelectedObjects[0].ToString();
            }
            else
            {
                MessageBox.Show("No Selection");
            }
        }
        
        private void linkAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchAddress GetAddress = new dialogSearchAddress();
            GetAddress.ShowDialog();

            if (GetAddress.AddressId == 0) return;

            Address FindAddress = (from a in dc.Addresses
                                   where a.Id == GetAddress.AddressId
                                   select a).FirstOrDefault();

            if (FindAddress == null) return;

            AddressId = FindAddress.Id;

            linkAddress.Text = Classes.AddressHelper.FormatAddress(AddressId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SpaceCount = from a in dc.Spaces
                             where a.BuildingId == _BuildingId
                             select a;

            if (SpaceCount.Count() > 0)
            {
                MessageBox.Show("There are spaces associated with this building. You must first delete all the spaces then you can delete the building.","Delete Building",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Are you sure you want to delete this building?", "Delete Building",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
            
            try
            {
                Building CurrentBuilding = (from a in dc.Buildings
                                            where a.Id == _BuildingId
                                            select a).FirstOrDefault();
                dc.Buildings.DeleteOnSubmit(CurrentBuilding);
                dc.SubmitChanges();

                MessageBox.Show("Building Deleted.", "Delete Building", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Building: " + ex.Message, "Delete Building", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBuilding_Load(sender, e);
        }

        private void frmBuilding_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).RemoveControlListItem(this.Text);
            }
            catch { }
        }

        private void linkBuildingBillingLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLegalEntity NewLE = new frmLegalEntity(BillingLE, false);

            (this.MdiParent as frmDBAContainer).AddMDIChildForm(NewLE);
        }

       
      
    }
}

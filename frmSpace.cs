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
    public partial class frmSpace : Form
    {
        DBADataContext dba = new DBADataContext();

        private Space _Space;
        private Building _Building;
        private Address _Address;
        private int _AddressId;
        private int _SpaceId;
        private int _BuildingId;

        private bool NewSpace = true;

        public frmSpace(int SpaceId, int BuildingId)
        {
            InitializeComponent();

            _SpaceId = SpaceId;
            _BuildingId = BuildingId;

            FillForm();

            btnDeleteOwner.Visible = false;
            btnEditOwner.Visible = false;
            btnNewOwner.Visible = false;

            AppInfo();
        }

        public void AppInfo()
        {
            StringBuilder itxt = new StringBuilder();
            itxt.Append("SPACE INFORMATION");
            itxt.Append("\r\n\r\n");
            if (_Space == null)
            {
                itxt.Append("Not created yet.");
            }
            else
            {
                itxt.Append("Space Id: " + _Space.Id.ToString());
                itxt.Append("\r\n");

                var SpaceTenantList = from a in dba.SpaceTennants
                                      where a.SpaceId == _SpaceId
                                      orderby a.StartDate descending
                                      select a;

                if ((SpaceTenantList.Count() != 0))
                {
                    try
                    {
                        itxt.Append("SpaceTenant Id: " + SpaceTenantList.FirstOrDefault().Id.ToString());
                        itxt.Append("\r\n");
                    }
                    catch { }
                }

                itxt.Append("Building Id: " + _Space.BuildingId.ToString());
                itxt.Append("\r\n");
                itxt.Append("Address Id: " + _Space.AddressId.ToString());
                itxt.Append("\r\n");
                itxt.Append("Guid: " + _Space.Guid.ToString());
            }

            txtAppInfo.Text = itxt.ToString();
        }

        private string FormatAddress()
        {
            return
                ((((
                _Address.StreetNumber.Trim() + " " +
                _Address.StreetDirection.Trim()
                ).Trim() + " " +
                _Address.StreetName.Trim()
                ).Trim() + " " +
                _Address.StreetSuffix.Trim()
                ).Trim() + " " +
                _Address.StreetSuite.Trim()
                ).Trim();
        }

        private void FillForm()
        {
            _Space = (from a in dba.Spaces
                      where a.Id == _SpaceId
                      select a).FirstOrDefault();

            if (_Space == null)
            {
                _Building = (from a in dba.Buildings
                             where a.Id == _BuildingId
                             select a).FirstOrDefault();

                if (_Building == null)
                {
                    MessageBox.Show("This Space requires a valid Building.");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }

                NewSpace = true;
                this.Text = "Space - " + _Building.Name + " - NEW SPACE";
                this.StartPosition = FormStartPosition.CenterParent;

                try
                {
                    this.tabControl1.TabPages.Remove(this.tabControl1.TabPages["TabNotes"]);
                    this.tabControl1.TabPages.Remove(this.tabControl1.TabPages["TabOwners"]);
                }
                catch { }

                btnNewOwner.Enabled = false;
                _AddressId = 0;
                btnSaveSpace.Text = "C&reate";
            }
            else
            {
                NewSpace = false;
                _Building = _Space.Building;
                _Address = (from a in dba.Addresses
                            where a.Id == _Space.AddressId
                            select a).FirstOrDefault();

                this.Text = "Space - " + _Building.Name + " - " + FormatAddress() + " (" + _SpaceId.ToString() + ")";

                AddressSpace.AddressId = _Space.AddressId;
                CommentDisplaySpace.ObjectGuid = _Space.Guid.Value;
                ContactDisplaySpace.ObjectGuid = _Space.Guid.Value;
                PropertiesSpace.ObjectGuid = _Space.Guid.Value;

                FillTenants();
                FillOwners();
                txtParcelNo.Text = _Space.ParcelNo;
                txtSqFt.Text = _Space.SqFt.Value.ToString();
                btnNewOwner.Enabled = true;
                _AddressId = _Space.AddressId;
                btnSaveSpace.Text = "&Save";
            }

            AddressSpace.LinkVisible = true;
            txtBuilding.Text = _Building.Name;
        }

        private void FillTenants()
        {
            dataGridViewTenant.AutoGenerateColumns = false;
            var AllTenants = from a in dba.SpaceTennants
                             join b in dba.Tenants
                             on a.TenantId equals b.Id
                             join c in dba.LegalEntities
                             on b.LegalEntityId equals c.Id
                             where a.SpaceId == _Space.Id
                             orderby a.StartDate descending
                             select new
                             {
                                 TenantId = b.Id,
                                 TenantName = c.Name,
                                 SpaceTenantId = a.Id,
                                 a.EndDate,
                                 a.StartDate
                             };
            dataGridViewTenant.DataSource = AllTenants;

            if (AllTenants.Count() == 0)
            {
                txtTenant.Text = "VACANT";
                return;
            }

            if (AllTenants.FirstOrDefault().EndDate == null)
            {
                txtTenant.Text = AllTenants.FirstOrDefault().TenantName;
            }
            else
            {
                txtTenant.Text = "VACANT";
            }
        }

        private void FillOwners()
        {
            dataGridViewOwner.AutoGenerateColumns = false;
            var AllOwners = from a in dba.SpaceOwners
                            join b in dba.LegalEntities
                            on a.LegalEntityId equals b.Id
                            where a.SpaceId == _Space.Id
                            orderby a.Id descending
                            select new
                            {
                                OwnerId = b.Id,
                                SpaceOwnerId = a.Id,
                                a.AsOfDate,
                                OwnerName = b.Name
                            };
            dataGridViewOwner.DataSource = AllOwners;

            if (AllOwners.Count() == 0)
            {
                txtOwner.Text = "NO OWNER";
                return;
            }

            txtOwner.Text = AllOwners.FirstOrDefault().OwnerName;
        }

        private void dataGridViewTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTenant NewTenant = new frmTenant((int)dataGridViewTenant.Rows[e.RowIndex].Cells[3].Value);

            frmDBAContainer dbaContainer = (this.ParentForm as frmDBAContainer);
            dbaContainer.AddMDIChildForm(NewTenant);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void AddressSpace_AddressChange(object source, int AddressId)
        {
            _AddressId = AddressId;
        }

        private void btnSaveSpace_Click(object sender, EventArgs e)
        {
            if (_AddressId == 0)
            {
                MessageBox.Show("You must select an address first.");
                return;
            }

            try { int SQ = Convert.ToInt32(txtSqFt.Text); }
            catch
            {
                MessageBox.Show("Square Feet(SqFt) not an integer number, please correct.");
                return;
            }

            if (txtSqFt.Text.Trim() == "") { txtSqFt.Text = "0"; }

            if (NewSpace)
            {
                CreateSpace();
            }
            else
            {
                SaveChanges();
            }
        }

        private void CreateSpace()
        {
            Space NewSpace = new Space
            {
                SqFt = Convert.ToInt32(txtSqFt.Text),
                ParcelNo = txtParcelNo.Text,
                AddressId = _AddressId,
                BuildingId = _BuildingId
            };

            dba.Spaces.InsertOnSubmit(NewSpace);
            dba.SubmitChanges();

            _SpaceId = NewSpace.Id;

            FillForm();

            MessageBox.Show("New Space created.");
        }

        private void SaveChanges()
        {
            _Space.SqFt = Convert.ToInt32(txtSqFt.Text);
            _Space.ParcelNo = txtParcelNo.Text;
            try
            {
                _Space.AddressId = _AddressId;
            }
            catch { }

            dba.SubmitChanges();
            PropertiesSpace.SaveChanges();

            FillForm();

            MessageBox.Show("Space changes saved.");
        }

        private void btnNewOwner_Click(object sender, EventArgs e)
        {
            dialogSpaceOwner NewSpaceOwner = new dialogSpaceOwner(0, _SpaceId);
            NewSpaceOwner.ShowDialog();

            FillForm();
        }

        private void PropertiesSpace_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteSpace_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting this space will also delete the associated SpaceTenant and SpaceOwner records. Are you sure you wish to continue?", "Delete Space", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var AllSpaceTenants = from a in dba.SpaceTennants
                                  where a.SpaceId == _Space.Id
                                  select a;

            var AllSpaceOwners = from a in dba.SpaceOwners
                                 where a.SpaceId == _Space.Id
                                 select a;

            dba.SpaceOwners.DeleteAllOnSubmit(AllSpaceOwners);
            dba.SpaceTennants.DeleteAllOnSubmit(AllSpaceTenants);
            dba.Spaces.DeleteOnSubmit(_Space);

            dba.SubmitChanges();

            MessageBox.Show("Delete of Space Complete.");

            this.Close();
        }

        private void btnEditOwner_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Owner to Edit.");
                return;
            }

            var bob = Cast(dataGridViewOwner.SelectedRows[0].DataBoundItem,
                new
                {
                    OwnerId = 0,
                    SpaceOwnerId = 0,
                    AsOfDate = new DateTime(),
                    OwnerName = ""
                });

            dialogSpaceOwner NewSpaceOwner = new dialogSpaceOwner(bob.SpaceOwnerId, _SpaceId);
            NewSpaceOwner.ShowDialog();
            FillForm();
        }


        // A generic Anonymous Type caster
        public T Cast<T>(object anonymous, T typeExpression)
        {
            return (T)anonymous;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteOwner.Visible = false;
            btnEditOwner.Visible = false;
            btnNewOwner.Visible = false;

            if (tabControl1.SelectedIndex == 1)
            {
                btnDeleteOwner.Visible = true;
                btnEditOwner.Visible = true;
                btnNewOwner.Visible = true;
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Owner to Delete.");
                return;
            }

            var bob = Cast(dataGridViewOwner.SelectedRows[0].DataBoundItem,
                new
                {
                    OwnerId = 0,
                    SpaceOwnerId = 0,
                    AsOfDate = new DateTime(),
                    OwnerName = ""
                });

            LegalEntity DeleteLegalEntity = (from a in dba.LegalEntities
                                             where a.Id == bob.OwnerId
                                             select a).FirstOrDefault();

            if (DeleteLegalEntity == null)
            {
                MessageBox.Show("Owner not found.");
                return;
            }

            if (MessageBox.Show("Delete this Owner: " + DeleteLegalEntity.Name + " ?", "Delete Owner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }


            SpaceOwner DeleteSpaceOwner = (from a in dba.SpaceOwners
                                           where a.Id == bob.SpaceOwnerId
                                           select a).FirstOrDefault();

            if (DeleteSpaceOwner == null)
            {
                MessageBox.Show("Space Owner record doesn't exist.");
                return;
            }

            dba.SpaceOwners.DeleteOnSubmit(DeleteSpaceOwner);
            dba.SubmitChanges();
            FillForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillForm();
        }

        private void frmSpace_Load(object sender, EventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).AddControlListItem("SPACE", this.Text, 0);
            }
            catch { }
        }

        private void frmSpace_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).RemoveControlListItem(this.Text);
            }
            catch { }
        }
    }   
}

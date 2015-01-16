using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    public partial class DBA_TenantSpaces : UserControl
    {
        int _tenantId = 0;
        DBADataContext DataContext;

        public int TenantId
        {
            get
            {
                return _tenantId;
            }
            set
            {
                if (!value.Equals(_tenantId))
                {
                    _tenantId = value;
                    LoadTenantSpaceData(_tenantId);
                }
            }
        }

        public DBA_TenantSpaces()
        {
            InitializeComponent();
        }

        public void CancelChanges()
        {
            LoadTenantSpaceData(TenantId);
        }

        public void LoadTenantSpaceData(int tenantId)
        {
            DataContext = new DBADataContext();

            var tenants = DataContext.fn_GetTenantActiveSpaces(tenantId);

            dgSpaces.DataSource = tenants;

            lblTotalSpace.Text = string.Format("{0} total square feet", tenants.Sum(st => st.SqFt));
        }

        private void AddControlToDBAContainer(Form aForm)
        {
            Control ctl = this.Parent;
            while (!(ctl is frmDBAContainer) && ctl != null)
            {
                ctl = ctl.Parent;
            }
            if (ctl is frmDBAContainer)
                (ctl as frmDBAContainer).AddMDIChildForm(aForm);
        }

        /// <summary>
        /// Link to the Building, Space, or move them out of a space.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgSpaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DowntownBoiseAssociation.fn_GetTenantSpacesResult rm = (dgSpaces.Rows[e.RowIndex].DataBoundItem as fn_GetTenantSpacesResult);
                DowntownBoiseAssociation.fn_GetTenantActiveSpacesResult rm = (dgSpaces.Rows[e.RowIndex].DataBoundItem as fn_GetTenantActiveSpacesResult);
                switch (e.ColumnIndex)
                {
                    case 1:
                        // Show the building information
                        frmBuilding bldg = new frmBuilding(rm.BuildingId);
                        AddControlToDBAContainer(bldg);
                        break;
                    case 2:
                        // Show the space information
                        frmSpace space = new frmSpace(rm.SpaceId, rm.BuildingId);
                        AddControlToDBAContainer(space);
                        break;
                    case 5:
                        // Edit this space
                        dialogSpaceTenant NewSpaceTenant = new dialogSpaceTenant(0, rm.Id);
                        NewSpaceTenant.ShowDialog();
                        
                        // Refresh the data
                        LoadTenantSpaceData(TenantId);
                        break;
                    case 6:
                        dialogSpaceVacate NewSpaceVacate = new dialogSpaceVacate(rm.Id);
                        NewSpaceVacate.ShowDialog();
                    
                        //// Vacate the space
                        //if (MessageBox.Show("Do you wish to vacate the space: " + rm.Address + " ?","Vacate Space", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                        //CloseSpace(rm.Id);

                        // Refresh the data
                        LoadTenantSpaceData(TenantId);
                        break;
                }
            }

        }

        /// <summary>
        /// Find a new space to add to their list of spaces (could be a move in for a new)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAssign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSpaceTenant NewSpaceTenant = new dialogSpaceTenant(_tenantId, 0);
            NewSpaceTenant.ShowDialog();

            LoadTenantSpaceData(TenantId);
        }

        public void CloseSpaces(int TenantId)
        {
            DataContext = new DBADataContext();

            var SpaceTenantList = from a in DataContext.SpaceTennants
                                  where a.TenantId == TenantId &&
                                  a.EndDate == null
                                  select a;

            foreach (var SpaceTenantItem in SpaceTenantList)
            {
                SpaceTenantItem.EndDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                DataContext.SubmitChanges();
            }

            LoadTenantSpaceData(TenantId);
        }

        private void CloseSpace(int SpaceTenantId)
        {
            DataContext = new DBADataContext();

            SpaceTennant CloseST = (from a in DataContext.SpaceTennants
                                    where a.Id == SpaceTenantId
                                    select a).FirstOrDefault();

            CloseST.EndDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));

            DataContext.SubmitChanges();
        }
    }
}
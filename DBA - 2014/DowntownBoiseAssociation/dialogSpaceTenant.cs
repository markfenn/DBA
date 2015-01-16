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
    public partial class dialogSpaceTenant : Form
    {
        private DBADataContext dba = new DBADataContext();        
        private bool _ExistingSpaceTenant;

        private Tenant _Tenant;
        private Space _Space;
        private SpaceTennant _SpaceTenant;

        private int _SpaceId;
        private int _TenantId;
        private int _BillToLegalEntityId;
        private DateTime _StartDate;
        private DateTime? _EndDate;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="TenantId">If value is zero, then there must be a value for SpaceTenantId. Set this parameter to zero if there is a value for Space Tenant. If there is a value in SpaceTenantId then this paramater is ignored. Fill this for when you are creating a new Space Tenant.</param>
        /// <param name="SpaceTenantId">Used for when you wish to edit a Space Tenant. Set this parameter equal to zero, if you are creating a Space Tenant.</param>
        public dialogSpaceTenant(int TenantId, int SpaceTenantId)
        {
            InitializeComponent();

            if ((SpaceTenantId == 0) && (TenantId == 0))
            {
                MessageBox.Show("Either SpaceTenantId must have a value, or TenantId must have a value.");
                this.Close();
            }
            else
            {
                if (SpaceTenantId == 0)
                {
                    _Tenant = (from a in dba.Tenants
                               where a.Id == TenantId
                               select a).FirstOrDefault();
                
                    _ExistingSpaceTenant = false;
                    _Space = null;
                    _SpaceTenant = null;

                    _BillToLegalEntityId = _Tenant.LegalEntityId;

                    this.Text = "Add a new Space to Tenant: " + _Tenant.LegalEntity.Name;
                }
                else
                {
                    _ExistingSpaceTenant = true;

                    _SpaceTenant = (from a in dba.SpaceTennants
                                    where a.Id == SpaceTenantId
                                    select a).FirstOrDefault();

                    _Space = (from a in dba.Spaces
                              where a.Id == _SpaceTenant.SpaceId
                              select a).FirstOrDefault();

                    _SpaceId = _Space.Id;
                    _BillToLegalEntityId = _SpaceTenant.BillToLegalEntityId;

                    _Tenant = _SpaceTenant.Tenant;

                    this.Text = "Edit Space: " + Classes.AddressHelper.FormatAddress(Classes.AddressHelper.SpaceAddressId(_Space.Id));                    
                }
            }

            FillForm();
        }

        private void FillForm()
        {
            if (_ExistingSpaceTenant)
            {
                linkSpace.Text = Classes.AddressHelper.FormatAddress(Classes.AddressHelper.SpaceAddressId(_SpaceId)) + 
                    "  (" + _SpaceId.ToString() + ")";
                linkBillTo.Text = BillToName(_BillToLegalEntityId);
                dtpStartDate.Value = _SpaceTenant.StartDate;
                dtpEndDate.Value = _SpaceTenant.EndDate;
            }
            else
            {
                linkBillTo.Text = BillToName(_BillToLegalEntityId);
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = null;
                dtpEndDate.Enabled = false;
            }
        }

        private string BillToName(int LegalEntityId)
        {
            return (from a in dba.LegalEntities
                    where a.Id == LegalEntityId
                    select a.Name).FirstOrDefault();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void linkSpace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int NewSpaceId = 0;

            dialogSearchSpace NewSpace = new dialogSearchSpace("Vacant Spaces");
            NewSpace.ShowDialog();

            if (NewSpace.SpaceId > 0) _SpaceId = NewSpace.SpaceId;

            linkSpace.Text = Classes.AddressHelper.FormatAddress(Classes.AddressHelper.SpaceAddressId(_SpaceId)) + 
                "   (" + _SpaceId.ToString() + ")";
        }

        private void linkBillTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int NewBillToLegalEntityId = 0;

            dialogSearchLegalEntity NewLE = new dialogSearchLegalEntity();
            NewLE.ShowDialog();

            if (NewLE.LegalEntityId > 0) _BillToLegalEntityId = NewLE.LegalEntityId;

            linkBillTo.Text = BillToName(_BillToLegalEntityId);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_SpaceId == 0)
            {
                MessageBox.Show("Please select a Vacant Space.");
                return;
            }

            DateTime TempDate;
            try
            {
                TempDate = (DateTime)dtpStartDate.Value;
            }
            catch
            {
                MessageBox.Show("Please enter a valid Start Date.");
                return;
            }

            try
            {
                if (dtpEndDate.Value != null)
                {
                    TempDate = (DateTime)dtpEndDate.Value;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid End Date.");
                return;
            }


            DateTime? NewDate;
            if (dtpEndDate.Value == null) NewDate = null;
            else NewDate = Convert.ToDateTime(Convert.ToDateTime(dtpEndDate.Value).ToString("MM/dd/yyyy"));  

            if (_ExistingSpaceTenant)
            {   
                _SpaceTenant.TenantId = _Tenant.Id;
                _SpaceTenant.SpaceId = _SpaceId;
                _SpaceTenant.BillToLegalEntityId = _BillToLegalEntityId;
                _SpaceTenant.StartDate = Convert.ToDateTime(Convert.ToDateTime(dtpStartDate.Value).ToString("MM/dd/yyyy"));
                _SpaceTenant.EndDate = NewDate;             
            }
            else
            {
                SpaceTennant NewSpaceTenant = new SpaceTennant
                {
                    TenantId = _Tenant.Id,
                    SpaceId = _SpaceId,
                    BillToLegalEntityId = _BillToLegalEntityId,
                    StartDate = Convert.ToDateTime(Convert.ToDateTime(dtpStartDate.Value).ToString("MM/dd/yyyy")),
                    EndDate = NewDate
                };

                dba.SpaceTennants.InsertOnSubmit(NewSpaceTenant);                
            }
            
            dba.SubmitChanges();
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

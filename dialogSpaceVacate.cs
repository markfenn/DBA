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
    public partial class dialogSpaceVacate : Form
    {
        private DBADataContext dba = new DBADataContext();        
        //private bool _ExistingSpaceTenant;
                
        //private Space _Space;
        private SpaceTennant _SpaceTenant;

        //private int _SpaceId;
        private int _TenantId;
        private int _BillToLegalEntityId;
        private DateTime _StartDate;
        private DateTime? _EndDate;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="TenantId">If value is zero, then there must be a value for SpaceTenantId. Set this parameter to zero if there is a value for Space Tenant. If there is a value in SpaceTenantId then this paramater is ignored. Fill this for when you are creating a new Space Tenant.</param>
        /// <param name="SpaceTenantId">Used for when you wish to edit a Space Tenant. Set this parameter equal to zero, if you are creating a Space Tenant.</param>
        public dialogSpaceVacate(int SpaceTenantId)
        {
            InitializeComponent();

            if ((SpaceTenantId == 0))
            {
                MessageBox.Show("SpaceTenantId must have a value.");
                this.Close();
            }
            else
            {     
                _SpaceTenant = (from a in dba.SpaceTennants
                                where a.Id == SpaceTenantId
                                select a).FirstOrDefault();
                               
                this.Text = "Vacate Space Tenant: ";        
            }

            FillForm();
        }

        private void FillForm()
        {           
                dtpStartDate.Value = _SpaceTenant.StartDate;
                dtpEndDate.Value = _SpaceTenant.EndDate;         
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
               
        private void btnAccept_Click(object sender, EventArgs e)
        {
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
            else NewDate = (DateTime)dtpEndDate.Value;   
            
            _SpaceTenant.StartDate = (DateTime)dtpStartDate.Value;
            _SpaceTenant.EndDate = NewDate;             
      
            
            dba.SubmitChanges();
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

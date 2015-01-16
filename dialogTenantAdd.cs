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
    public partial class dialogTenantAdd : Form
    {
        DBADataContext dba = new DBADataContext();

        int _TenantLegalEntityId = 0;
        int _BillToLegalEntityId = 0;
        int _TenantSpaceId = 0;
        int _AddressId = 0;
        int _TenantId = 0;
        

        public dialogTenantAdd()
        {
            InitializeComponent();
        }

        private void linkTenantLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchLegalEntity NewForm = new dialogSearchLegalEntity();
            NewForm.ShowDialog();

            if (NewForm.LegalEntityId > 0)
            {
                _TenantLegalEntityId = NewForm.LegalEntityId;

                string Name = (from a in dba.LegalEntities
                               where a.Id == _TenantLegalEntityId
                               select a.Name).FirstOrDefault();

                linkTenantLE.Text = Name;

                // Set the Bill To the the default
                _BillToLegalEntityId = _TenantLegalEntityId;
            }
        }

        private void linkVacantLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchSpace NewForm = new dialogSearchSpace("Vacant Spaces");
            NewForm.ShowDialog();

            if (NewForm.SpaceId > 0)
            {
                _TenantSpaceId = NewForm.SpaceId;

                linkVacantLocation.Text = Classes.AddressHelper.FormatAddress(
                    Classes.AddressHelper.SpaceAddressId(_TenantSpaceId));

                // Set the address to the default.
                _AddressId = Classes.AddressHelper.SpaceAddressId(_TenantSpaceId);
            }
        }

        private void cbAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddress.Checked) { linkTenantAddress.Visible = false; }
            else { linkTenantAddress.Visible = true; }
        }

        private void cbBillTo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBillTo.Checked) { linkBillTo.Visible = false; }
            else { linkBillTo.Visible = true; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void linkTenantAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchAddress NewForm = new dialogSearchAddress();
            NewForm.ShowDialog();

            if (NewForm.AddressId > 0)
            {
                _AddressId = NewForm.AddressId;

                linkTenantAddress.Text = Classes.AddressHelper.FormatAddress(_AddressId);
            }
        }

        private void linkBillTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchLegalEntity NewForm = new dialogSearchLegalEntity();
            NewForm.ShowDialog();

            if (NewForm.LegalEntityId > 0)
            {
                _BillToLegalEntityId = NewForm.LegalEntityId;

                string Name = (from a in dba.LegalEntities
                               where a.Id == _BillToLegalEntityId
                               select a.Name).FirstOrDefault();

                linkBillTo.Text = Name;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!IsValidated()) { return; }

            if (!CreateTenantRecord()) { return; }
            if (!CreateSpaceTenantRecord()) { return; };
                        
            frmTenant NewForm = new frmTenant(_TenantId);
            (this.Tag as frmDBAContainer).AddMDIChildForm(NewForm);
            this.Close();
        }

        private bool IsValidated()
        {
            if (_TenantLegalEntityId == 0)
            {
                MessageBox.Show("Legal Entity is not selected.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (_TenantSpaceId == 0)
            {
                MessageBox.Show("A vacant Tenant Space is not selected.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }                

            return true;
        }

        private bool CreateTenantRecord()
        {
            try
            {
                Tenant NewTenant = new Tenant
                {
                    LegalEntityId = _TenantLegalEntityId,
                    DateOpened = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    PublishedAddressId = _AddressId,
                    IsPublished = true,
                    IsAssessed = true,
                    Votes = 1,
                    Name = linkTenantLE.Text.Trim()
                };

                dba.Tenants.InsertOnSubmit(NewTenant);
                dba.SubmitChanges();

                _TenantId = NewTenant.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show("Tenant Creation error (1): " + e.Message);
                return false;
            }

            return true;
        }

        private bool CreateSpaceTenantRecord()
        {
            if (_TenantId == 0) return false;

            try
            {
                SpaceTennant NewSpaceTenant = new SpaceTennant
                {
                    TenantId = _TenantId,
                    SpaceId = _TenantSpaceId,
                    BillToLegalEntityId = _BillToLegalEntityId,
                    StartDate = DateTime.Now
                };

                dba.SpaceTennants.InsertOnSubmit(NewSpaceTenant);
                dba.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Tenant Creation error (2): " + e.Message);
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DowntownBoiseAssociation
{
    public partial class frmTenantView : Form
    {
        private int _TenantId;
        private DBADataContext dba = new DBADataContext();
        private LegalEntity _LegalEntity;
        private Tenant _Tenant;

        public frmTenantView(int TenantId)
        {
            InitializeComponent();

            _TenantId = TenantId;

            GetTenantInformation();

            FillFormValues();
        }

        public frmTenantView(string AccountNo)
        {
            InitializeComponent();

            _TenantId = (from a in dba.LegalEntities
                         join b in dba.Tenants
                         on a.Id equals b.LegalEntityId
                         where a.AccountNumber == AccountNo
                         select b.Id).FirstOrDefault();

            GetTenantInformation();

            FillFormValues();
        }

        private void GetTenantInformation()
        {
            dba = new DBADataContext();

            _Tenant = (from a in dba.Tenants
                       where a.Id == _TenantId
                       select a).FirstOrDefault();

            _LegalEntity = (from a in dba.LegalEntities
                            where a.Id == _Tenant.LegalEntityId
                            select a).FirstOrDefault();

            //var SpaceTenantList = from a in dba.SpaceTennants
            //                      where a.TenantId == _Tenant.Id
            //                      orderby a.StartDate descending
            //                      select a;

            //if ((SpaceTenantList != null) || (SpaceTenantList.Count() == 0))
            //{
            //    _SpaceTenant = SpaceTenantList.FirstOrDefault();

            //    _BillToLegalEntity = (from a in dba.SpaceTennants
            //                          join b in dba.LegalEntities
            //                          on a.BillToLegalEntityId equals b.Id
            //                          where a.Id == _SpaceTenant.Id
            //                          select b).FirstOrDefault();

            //    _Space = _SpaceTenant.Space;
            //}
        }

        private void FillFormValues()
        {
            string ClosedText = "";

            if (_Tenant.DateClosed != null) ClosedText = " - CLOSED";

            this.Text = "Tenant - " + _LegalEntity.Name + " - " + _LegalEntity.AccountNumber + ClosedText;
            locationTenant.TenantId = _TenantId;

            // Load the tenantSpaces user control
            dba_TenantSpaces1.TenantId = _TenantId;

            legalEntityTenant.LegalEntityId = _LegalEntity.Id;
            //legalEntityBillTo.LegalEntityId = _BillToLegalEntity.Id;
            AddressTenant.AddressId = _Tenant.PublishedAddressId.Value;
            AddressTenant.LinkVisible = true;

            editPropertiesTenant.ObjectGuid = _Tenant.Guid;
            CommentDisplayTenant.ObjectGuid = _Tenant.Guid;
            ContactDisplayTenant.ObjectGuid = _Tenant.Guid;
            editPropertiesOther.ObjectGuid = _Tenant.Guid;
            editPropertiesBusiness.ObjectGuid = _Tenant.Guid;

            ClassCategoryTenant.TenantId = _Tenant.Id;

            blockBlock.TenantId = _Tenant.Id;

            dtpDateOpened.Value = _Tenant.DateOpened;
            dtpDateClosed.Value = _Tenant.DateClosed;

            

            linkLegalEntity.Text = _LegalEntity.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //legalEntityTenant.Save();

            DBADataContext NewDBA = new DBADataContext();

            Tenant NewTenant = (from a in NewDBA.Tenants
                                where a.Id == _TenantId
                                select a).FirstOrDefault();
            _Tenant = null;
            NewTenant.LegalEntityId = legalEntityTenant.LegalEntityId;
            NewTenant.DateOpened = (DateTime)dtpDateOpened.Value;
            NewDBA.SubmitChanges();
            _Tenant = NewTenant;
            //legalEntityBillTo.Save();
            editPropertiesTenant.SaveChanges();
            SaveOtherFormData();
            editPropertiesBusiness.SaveChanges();
            editPropertiesOther.SaveChanges();
            AddressTenant.Save();



            GetTenantInformation();
            FillFormValues();

            MessageBox.Show("Tenant Saved.");
        }

        private void frmTenantView_Load(object sender, EventArgs e)
        {
            string GoogleMaps;

            GoogleMaps = "http://maps.google.com/maps?q=" + Classes.AddressHelper.FormatAddressExtended(_Tenant.Address.Id);

            linkLabel1.Links.Remove(linkLabel1.Links[0]);
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, GoogleMaps);
        }

        private void SaveOtherFormData()
        {
            if (dtpDateClosed.Value == null) { _Tenant.DateClosed = null; }
            else { _Tenant.DateClosed = (DateTime)dtpDateClosed.Value; }

            if (dtpDateOpened.Value == null) { _Tenant.DateOpened = null; }
            else { _Tenant.DateOpened = (DateTime)dtpDateOpened.Value; }

            _Tenant.DateUpdated = DateTime.Now;           
            dba.SubmitChanges();


            DBADataContext db1 = new DBADataContext();
            Tenant SaveTenant = (from a in db1.Tenants
                                 where a.Id == _TenantId
                                 select a).FirstOrDefault();

            SaveTenant.PublishedAddressId = AddressTenant.AddressId;
            db1.SubmitChanges();

            
        }

        private void legalEntityTenant_LegalEntityChange(object source, int LegalEntityId)
        {
            if (LegalEntityId == _LegalEntity.Id) { return; }

            if (MessageBox.Show("WARNING! You are about to change the name of this Tenant, do you wish to continue?", "Alert.", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                legalEntityTenant.LegalEntityId = _LegalEntity.Id;
                return;
            }

            _Tenant.LegalEntityId = LegalEntityId;

        }


        private void btnCloseTenant_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void legalEntityBillTo_Load(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string Mess = "WARNING! This will move this Tenant from all current Spaces (Making them vacant)\nto another already vacant Space.\n\nDo you wish to continue?   ";
            bool ChangeAddress = false;

            if (MessageBox.Show(Mess, "Moving a Tenant...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return; }

            dialogSearchSpace NewSpace = new dialogSearchSpace("STEP 1 of 3: Select a vacant space");
            NewSpace.ShowDialog();

            if (NewSpace.SpaceId == 0) { return; }

            DialogResult StepQuestion = MessageBox.Show("Do you want this Tenant's address to be changed to the Space you are moving it to?", "STEP 2 of 3: Change or keep the Address", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (StepQuestion == DialogResult.Yes) { ChangeAddress = true; }
            else if (StepQuestion == DialogResult.No) { ChangeAddress = false; }
            else { return; }

            string MessApp = "Keeping the address unchanged";
            if (ChangeAddress) { MessApp = "Changing the address to the new Space"; }

            Mess = "Moving Tenant:\n\n     " + _LegalEntity.Name + "     \n\n" +
                "To Space\n\n     " + Classes.AddressHelper.FormatAddress(Classes.AddressHelper.SpaceAddressId(NewSpace.SpaceId)) + "     \n\n" +
                MessApp + "     \n\n" +
                "Do you wish to continue?";

            if (MessageBox.Show(Mess, "STEP 3 of 3: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return; }

            //===================================================
            // CHANGE THE CURRENT SPACE TENANT TO BE VACANT
            //===================================================
            //_SpaceTenant.EndDate = DateTime.Now;
            dba_TenantSpaces1.CloseSpaces(_Tenant.Id);


            // Load the selected space
            //Space sSpace = (from a in dba.Spaces
            //               where a.Id == NewSpace.SpaceId
            //               select a).FirstOrDefault();

            //===================================================
            // CREATE THE NEW SPACE TENANT RECORD ASSOCIATED
            // WITH THE NEW SPACE
            //===================================================
            SpaceTennant NewSpaceTenant = new SpaceTennant
            {
                TenantId = _Tenant.Id,
                SpaceId = NewSpace.SpaceId,
                BillToLegalEntityId = _Tenant.LegalEntityId,
                StartDate = DateTime.Now
            };

            dba.SpaceTennants.InsertOnSubmit(NewSpaceTenant);

            //===================================================
            // DO WE UPDATE THE ADDRESS?
            //===================================================
            if (ChangeAddress)
            {
                DBADataContext dba1 = new DBADataContext();

                Tenant NewAddressTenant = (from a in dba1.Tenants
                                           where a.Id == _TenantId
                                           select a).FirstOrDefault();

                NewAddressTenant.PublishedAddressId = Classes.AddressHelper.SpaceAddressId(NewSpace.SpaceId);
                //_Tenant.PublishedAddressId = Classes.AddressHelper.SpaceAddressId(NewSpace.SpaceId);
                dba1.SubmitChanges();
            }

            //===================================================
            // APPLY THE CHANGES
            //===================================================
            dba.SubmitChanges();

            _TenantId = _Tenant.Id;

            GetTenantInformation();

            FillFormValues();

            dba_TenantSpaces1.LoadTenantSpaceData(_Tenant.Id);
            MessageBox.Show("Move Complete.");
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close out this Tenant?", "Close Tenant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return; }

            _Tenant.DateClosed = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyy"));
            _Tenant.DateUpdated = DateTime.Now;

            //_SpaceTenant.EndDate = DateTime.Now;

            dba.SubmitChanges();

            dba_TenantSpaces1.CloseSpaces(_Tenant.Id);

            GetTenantInformation();

            FillFormValues();

            MessageBox.Show("Close out complete.");
        }

        //private void linkSpace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    frmSpace NewSpace = new frmSpace(_Space.Id, _Space.BuildingId);

        //    (this.ParentForm as frmDBAContainer).AddMDIChildForm(NewSpace);
        //}

        private void linkLegalEntity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUtilityLegalEntityMaintain NewLE = new frmUtilityLegalEntityMaintain(_LegalEntity.Id, false);
            (this.ParentForm as frmDBAContainer).AddMDIChildForm(NewLE);
        }

        private void frmTenantView_Shown(object sender, EventArgs e)
        {
            (this.ParentForm as frmDBAContainer).AddRecentTenant(_Tenant.LegalEntity.Name, _TenantId);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }

    }
}

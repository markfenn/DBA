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
    public partial class frmTenant : Form
    {
        private int _TenantId;
        private DBADataContext dba = new DBADataContext();
        private LegalEntity _LegalEntity;
        private Tenant _Tenant;
        private string SpaceType = "TENANT";
        private string ClosedText = "";

        public frmTenant(int TenantId)
        {
            InitializeComponent();

            _TenantId = TenantId;

            GetTenantInformation();

            FillFormValues();
        }

        public frmTenant(string AccountNo)
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

          AppInfo();
        }

        public void AppInfo()
        {
            StringBuilder itxt = new StringBuilder();
            itxt.Append("TENANT INFORMATION");
            itxt.Append("\r\n\r\n");
            itxt.Append("Tenant Id: " + _Tenant.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Legal Entity Id: " + _Tenant.LegalEntityId.ToString());
            itxt.Append("\r\n");
            itxt.Append("Address Id: " + _Tenant.PublishedAddressId.ToString());
            itxt.Append("\r\n");



            var SpaceTenantList = from a in dba.SpaceTennants
                                  where a.TenantId == _Tenant.Id
                                  orderby a.StartDate descending
                                  select a;

            if ((SpaceTenantList != null) && (SpaceTenantList.Count() != 0))
            {               
                itxt.Append("SpaceTenant Id: " + SpaceTenantList.FirstOrDefault().Id.ToString());
                itxt.Append("\r\n");
                itxt.Append("Space Id: " + SpaceTenantList.FirstOrDefault().SpaceId.ToString());
                itxt.Append("\r\n");

                Space ThisSpace = (from a in dba.Spaces
                                   where a.Id == SpaceTenantList.FirstOrDefault().SpaceId
                                   select a).FirstOrDefault();

                SpaceType = GetPropertyValue(ThisSpace.Guid.Value, "Space Type");
            }
                        
            itxt.Append("Guid: " + _Tenant.Guid.ToString());

            txtAppInfo.Text = itxt.ToString();
        }
        private void FillFormValues()
        {
            if (_Tenant.DateClosed != null) ClosedText = " - CLOSED";

            
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
            txtName.Text = _Tenant.Name;
            if (_Tenant.Name == null || _Tenant.Name.Trim() == "") txtName.Text = _LegalEntity.Name;

            this.Text = "Tenant - " + txtName.Text + " - " + _LegalEntity.AccountNumber + ClosedText;

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
            NewTenant.Name = txtName.Text;
            NewTenant.LegalEntityId = legalEntityTenant.LegalEntityId;
            NewTenant.DateOpened = (DateTime)dtpDateOpened.Value;
            if (dtpDateClosed.Value == null) NewTenant.DateClosed = null;
            else NewTenant.DateClosed = (DateTime)dtpDateClosed.Value;
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

            try
            {
                if (SpaceType.Trim().ToUpper() == "PARKING")
                {
                    this.Text = "Parking - " + txtName.Text + " - " + _LegalEntity.AccountNumber + ClosedText;
                    (this.ParentForm as frmDBAContainer).AddControlListItem("PARKING", this.Text, _TenantId);
                    this.Icon = Properties.Resources.parkingIcon;
                }
                else if (SpaceType.Trim().ToUpper() == "GOVERNMENT TENANT")
                {
                    this.Text = "Government - " + txtName.Text + " - " + _LegalEntity.AccountNumber + ClosedText;
                    (this.ParentForm as frmDBAContainer).AddControlListItem("GOVERNMENT", this.Text, _TenantId);
                    this.Icon = Properties.Resources.GovernmentIcon;
                }
                else if (SpaceType.Trim().ToUpper() == "GOVERNMENT BUILDING")
                {
                    this.Text = "Government - " + txtName.Text + " - " + _LegalEntity.AccountNumber + ClosedText;
                    (this.ParentForm as frmDBAContainer).AddControlListItem("GOVERNMENT", this.Text, _TenantId);
                    this.Icon = Properties.Resources.GovernmentIcon;
                }
                else
                {
                    (this.ParentForm as frmDBAContainer).AddControlListItem("TENANT", this.Text, _TenantId);    
                    this.Icon = Properties.Resources.TenantIcon;
                }                
            }
            catch { }
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

      
        private void linkLegalEntity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLegalEntity NewLE = new frmLegalEntity(_LegalEntity.Id, false);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetTenantInformation();

            FillFormValues();
        }

        private void frmTenant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).RemoveControlListItem(this.Text);
            }
            catch { }
        }

        private void txtAppInfo_DoubleClick(object sender, EventArgs e)
        {   
            frmTenantNew NewTenantNew = new frmTenantNew(_TenantId);
            (this.ParentForm as frmDBAContainer).AddMDIChildForm(NewTenantNew);            
        }

        public static string GetPropertyValue(Guid InGuid, string Key)
        {
            DBADataContext db = new DBADataContext();
            string GetValue = (from a in db.AttributeValues
                              join b in db.Attributes
                              on a.AttributeId equals b.Id
                              where a.ObjectGuid == InGuid &&
                              b.Name == Key 
                              select a.Value).FirstOrDefault();

            return string.IsNullOrEmpty(GetValue) ? "" : GetValue.Trim();
        }

    }
}

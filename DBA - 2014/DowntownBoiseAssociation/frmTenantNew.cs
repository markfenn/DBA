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
    public partial class frmTenantNew : Form
    {
        DBADataContext db = new DBADataContext();
        int _TenantId;
        
        Tenant _TenantRecord;
        LegalEntity _LegalEntity;

        int Blinking = 0;

        public frmTenantNew(int TenantId)
        {
            InitializeComponent();
            _TenantId = TenantId;
        }

        private void frmTenantNew_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Tenant Address: " + _TenantRecord.PublishedAddressId.ToString());
            SetupForm();

            try
            {
                (this.ParentForm as frmDBAContainer).AddControlListItem("TENANT", this.Text, _TenantId);
            }
            catch { }
            
        }
        public void SetupForm()
        {
            GetTenantInformation();
            FillForm();
        }

        public void GetTenantInformation()
        {
            db = null;
            db = new DBADataContext();


            _TenantRecord = (from a in db.Tenants
                             where a.Id == _TenantId
                             select a).FirstOrDefault();

            _LegalEntity = (from a in db.LegalEntities
                            where a.Id == _TenantRecord.LegalEntityId
                            select a).FirstOrDefault();
                      
        }

        public void FillForm()
        {
            // Set the form Title
            string ClosedText = "";
            if (_TenantRecord.DateClosed != null) ClosedText = " - CLOSED";
            this.Text = "Tenant - " + GetTenantName() + " - " + _LegalEntity.AccountNumber + ClosedText;

            // Set Location Bar
            dbaLocation.TenantId = _TenantId;

            // Fields
            txtName.Text = GetTenantName();

            AddressTenant.AddressId = _TenantRecord.PublishedAddressId.Value;
            AddressTenant.LinkVisible = true;

            txtDateBegin.Text = _TenantRecord.DateOpened.HasValue ? _TenantRecord.DateOpened.Value.ToString("MM/dd/yyyy") : DateTime.Today.ToString("MM/dd/yyyy");
            txtDateClosed.Text = _TenantRecord.DateClosed.HasValue ? _TenantRecord.DateClosed.Value.ToString("MM/dd/yyyy") : "";

            ddDateBegin.Value = Convert.ToDateTime(txtDateBegin.Text);
            if (txtDateClosed.Text.Trim() != "") ddDateClosed.Value = Convert.ToDateTime(txtDateClosed.Text);

            linkLegalEntity.Text = _LegalEntity.Name;



            AppInfo();
                        
        }


        public void Refresh()
        {
            GetTenantInformation();
            FillForm();
            BlinkForm();
        }

        public void BlinkForm()
        {
            Blink.Enabled = true;  
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string GetTenantName()
        {
            if (_TenantRecord.Name.Trim() == "") return _LegalEntity.Name.Trim();
            return _TenantRecord.Name.Trim();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("New Tenant Address: " + AddressTenant.AddressId.ToString());

            DBADataContext NewDBA = new DBADataContext();
            Tenant NewTenant = (from a in NewDBA.Tenants
                                where a.Id == _TenantId
                                select a).FirstOrDefault();

            SpaceTennant NewSpaceTenant = (from a in NewDBA.SpaceTennants
                                  where a.TenantId == _TenantId
                                  orderby a.StartDate descending
                                  select a).FirstOrDefault();



            DateTime? bDate;
            DateTime? eDate;

            bDate = Convert.ToDateTime(txtDateBegin.Text);

            if (txtDateClosed.Text.Trim() == "") eDate = null;
            else eDate = Convert.ToDateTime(txtDateClosed.Text);
            
            NewTenant.DateOpened = bDate;
            NewTenant.DateClosed = eDate;
            NewTenant.Name = txtName.Text.Trim();
            NewTenant.DateUpdated = DateTime.Now;
            NewTenant.PublishedAddressId = AddressTenant.AddressId;

            NewSpaceTenant.StartDate = bDate.Value;
            NewSpaceTenant.EndDate = eDate;

            NewDBA.SubmitChanges();            

            Refresh();
            //MessageBox.Show("Tenant Saved.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void AppInfo()
        {
            StringBuilder itxt = new StringBuilder();
            itxt.Append("TENANT INFORMATION");
            itxt.Append("\r\n\r\n");
            itxt.Append("Tenant Id: " + _TenantRecord.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Tenant Open Date: " + _TenantRecord.DateOpened.Value.ToString("MM/dd/yyyy hh:mm:ss"));
            itxt.Append("\r\n");
            itxt.Append("Tenant Close Date: " + ((_TenantRecord.DateClosed.HasValue) ? _TenantRecord.DateClosed.Value.ToString("MM/dd/yyyy hh:mm:ss") : ""));
            itxt.Append("\r\n");
            itxt.Append("Tenant Address Id: " + _TenantRecord.PublishedAddressId.ToString());
            itxt.Append("\r\n");
            itxt.Append("Tenant Guid: " + _TenantRecord.Guid.ToString());
            itxt.Append("\r\n");
            itxt.Append("\r\n");

            itxt.Append("Legal Entity Id: " + _LegalEntity.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Legal Entity Guid: " + _LegalEntity.Guid.ToString());
            itxt.Append("\r\n");            
            itxt.Append("\r\n");

            var SpaceTenantList = from a in db.SpaceTennants
                                  where a.TenantId == _TenantId
                                  orderby a.StartDate descending
                                  select a;

            if ((SpaceTenantList != null) && (SpaceTenantList.Count() != 0))
            {
                itxt.Append("SpaceTenant Id: " + SpaceTenantList.FirstOrDefault().Id.ToString());
                itxt.Append("\r\n");
                itxt.Append("SpaceTenant Start Date: " + SpaceTenantList.FirstOrDefault().StartDate.ToString("MM/dd/yyyy hh:mm:ss"));
                itxt.Append("\r\n");
                itxt.Append("SpaceTenant End Date: " + ((SpaceTenantList.FirstOrDefault().EndDate.HasValue) ? SpaceTenantList.FirstOrDefault().EndDate.Value.ToString("MM/dd/yyyy hh:mm:ss") : ""));
                itxt.Append("\r\n");
                itxt.Append("\r\n");

                itxt.Append("Space Id: " + SpaceTenantList.FirstOrDefault().SpaceId.ToString());
                itxt.Append("\r\n");
                itxt.Append("\r\n");
            }

            txtAppInfo.Text = itxt.ToString();
        }

        private void ddDateBegin_ValueChanged(object sender, EventArgs e)
        {
            txtDateBegin.Text = ddDateBegin.Value.ToString("MM/dd/yyyy");
        }

        private void ddDateClosed_ValueChanged(object sender, EventArgs e)
        {
            if (txtDateClosed.Text.Trim() == "")
            {
                MessageBox.Show("If you are trying to close out this Tenant, please use the Close out Tenant button, to ensure all tables are updated.", "Tenant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtDateClosed.Text = ddDateClosed.Value.ToString("MM/dd/yyyy");
        }

        private void btnDateClosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDateClosed.Text = "";
        }

        private void linkLegalEntity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLegalEntity NewLE = new frmLegalEntity(_LegalEntity.Id, false);
            (this.ParentForm as frmDBAContainer).AddMDIChildForm(NewLE);
        }

        private void Blink_Tick(object sender, EventArgs e)
        {
            Blinking++;

            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }

            if (Blinking > 4)
            {
                this.BackColor = SystemColors.Control;
                Blinking = 0;
                Blink.Enabled = false;
            }
        }

        private void frmTenantNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).RemoveControlListItem(this.Text);
            }
            catch { }
        }

        private void frmOldForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTenant NewForm = new frmTenant(_TenantId);
            (this.ParentForm as frmDBAContainer).AddMDIChildForm(NewForm);
        }
 
    }
}

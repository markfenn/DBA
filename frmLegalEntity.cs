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
    public partial class frmLegalEntity : Form
    {
        private int _LegalEntityId;
        private bool _AdminMode = false;

        private const int ExpandedHeight = 500;
        private const int ReducedHeight = 200;

        public frmLegalEntity(int LegalEntityId, bool AdminMode)
        {
            InitializeComponent();
            _AdminMode = AdminMode;
            SetAdminMode();

            if (LegalEntityId == 0)
            {
                this.StartPosition = FormStartPosition.CenterParent;

                tabControl1.Visible = false;
                this.MinimumSize = new Size(this.Width, ReducedHeight);
                this.Height = ReducedHeight;

                return;
            }

            _LegalEntityId = LegalEntityId;
            GetLegalEntity(LegalEntityId);

            AppInfo();
        }

        public void AppInfo()
        {
            LegalEntity le = RetrieveLegalEntity();

            StringBuilder itxt = new StringBuilder();
            itxt.Append("LEGAL ENTITY INFORMATION");
            itxt.Append("\r\n\r\n");
            itxt.Append("Legal Entity Id: " + le.Id.ToString());
            itxt.Append("\r\n");
            itxt.Append("Guid: " + le.Guid.ToString());
            
            txtAppInfo.Text = itxt.ToString();
        }

        public int LegalEntityId
        {
            get { return _LegalEntityId; }
            set
            {
                _LegalEntityId = value;
                GetLegalEntity(_LegalEntityId);
            }
        }

        public bool AdminMode
        {
            set
            {
                _AdminMode = value;
                SetAdminMode();
            }
        }

        private void SetAdminMode()
        {
            if (_AdminMode)
            {
                legalEntity1.AdminMode = true;
                tabControl1.Visible = false;
                this.Height = ReducedHeight;
            }
            else
            {
                legalEntity1.AdminMode = false;
                this.Height = ExpandedHeight;
            }
        }

        private void GetLegalEntity(int LegalEntityId)
        {

            if (LegalEntityId > 0)
            {
                legalEntity1.LegalEntityId = LegalEntityId;

                if (_AdminMode) { this.StartPosition = FormStartPosition.CenterParent; }

                LegalEntity le = RetrieveLegalEntity();
                CommentDisplay1.ObjectGuid = le.Guid;
                ContactDisplay1.ObjectGuid = le.Guid;

                BillingDisplay1.AdjustmentType = "WRITE-OFF,ADJUSTMENT";
                BillingDisplay1.AdjustmentQuery = "WRITE-OFF,BEGINNING BALANCE,INVOICE ADJUSTMENT,PAYMENT";
                BillingDisplay1.AdjustmentText = "Add Adjustment";
                BillingDisplay1.ObjectGuid = le.Guid;

                CollectionDisplay.AdjustmentType = "COLLECTIONS";
                CollectionDisplay.AdjustmentQuery = "COLLECTIONS";
                CollectionDisplay.AdjustmentText = "Add Collection";
                CollectionDisplay.ObjectGuid = le.Guid;

                CollBillDisplay.AdjustmentType = "WRITE-OFF,ADJUSTMENT,COLLECTIONS,COLLECTIONS FEE";
                CollBillDisplay.AdjustmentQuery = "WRITE-OFF,BEGINNING BALANCE,INVOICE ADJUSTMENT,PAYMENT,COLLECTIONS,LATE FEE";
                CollBillDisplay.AdjustmentText = "Add Adjustment or Collection";
                CollBillDisplay.ObjectGuid = le.Guid;

                collectionsEditProperties.ObjectGuid = le.Guid;

                BillingHistory.LegalEntityId = LegalEntityId;

                if (_AdminMode) { this.Text = "Legal Entity - " + legalEntity1.LegalEntityName + " - " + le.AccountNumber + " - Edit"; }
                else { this.Text = "Legal Entity - " + legalEntity1.LegalEntityName + " - " + le.AccountNumber; }
            }
            else
            {
                this.Text = "Legal Entity - New";
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            collectionsEditProperties.SaveChanges();
            if (!legalEntity1.Save())
            {
                return;
            }

            _LegalEntityId = legalEntity1.LegalEntityId;

            if (_AdminMode)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbnContacts_Click(object sender, EventArgs e)
        {
            LegalEntity le = RetrieveLegalEntity();
            if (le == null)
                return;

            dialogSearchContact listContact = new dialogSearchContact();
            listContact.ObjectGuid = le.Guid;
            listContact.AddressId = le.MailingAddressId.Value;
            listContact.LoadSearchByObjectGuid = true;
            listContact.ShowDialog();
        }

        private LegalEntity RetrieveLegalEntity()
        {
            DBADataContext dba = new DBADataContext();
            LegalEntity le = (from l in dba.LegalEntities
                              where l.Id == LegalEntityId
                              select l).FirstOrDefault();
            return le;
        }

        private void frmUtilityLegalEntityMaintain_Shown(object sender, EventArgs e)
        {
            LegalEntity le = RetrieveLegalEntity();
            if (this.ParentForm != null)
                (this.ParentForm as frmDBAContainer).AddRecentLegalEntity(le.Name, le.Id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string iMess = "";

            if (GetLECounts(CountType.All) == 0)
            {
                iMess = "This Legal Entity has no relationships to other areas and can be deleted.\r\n\r\nDo you wish to delete?";
                if (MessageBox.Show(iMess, "Delete " + this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;

                DBADataContext dba = new DBADataContext();
                LegalEntity le = (from a in dba.LegalEntities
                                 where a.Id == LegalEntityId
                                 select a).FirstOrDefault();

                dba.LegalEntities.DeleteOnSubmit(le);
                dba.SubmitChanges();

                this.Close();
                return;
            }

            iMess += "This Legal Entity has the following relationships:\r\n\r\n" +
                "Tenants: " + GetLECounts(CountType.Tenant).ToString() + "\r\n" +
                "Space Owners: " + GetLECounts(CountType.SpaceOwner).ToString() + "\r\n" +
                "Payments: " + GetLECounts(CountType.Payment).ToString() + "\r\n" +
                "Invoices: " + GetLECounts(CountType.Invoice).ToString() + "\r\n" +
                "Transactions: " + GetLECounts(CountType.Transacton).ToString() + "\r\n" +
                "Adjustments: " + GetLECounts(CountType.Adjustment).ToString() + "\r\n\r\n" +
                "and can not be deleted.";
            MessageBox.Show(iMess, "Delete " + this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private int GetLECounts(CountType ReturnType)
        {
            DBADataContext dba = new DBADataContext();
            int SOCnt = 0;
            int TCnt = 0;
            int PCnt = 0;
            int ICnt = 0;
            int TrCnt = 0;
            int ACnt = 0;

            if (ReturnType == CountType.SpaceOwner || ReturnType == CountType.All)
            {
                SOCnt = (from a in dba.SpaceOwners
                         where a.LegalEntityId == LegalEntityId
                         select a).Count();
            }

            if (ReturnType == CountType.Tenant || ReturnType == CountType.All)
            {
                TCnt = (from a in dba.Tenants
                        where a.LegalEntityId == LegalEntityId
                        select a).Count();
            }

            if (ReturnType == CountType.Payment || ReturnType == CountType.All)
            {
                PCnt = (from a in dba.Payments
                        where a.LegalEntityId == LegalEntityId
                        select a).Count();
            }

            if (ReturnType == CountType.Invoice || ReturnType == CountType.All)
            {
                ICnt = (from a in dba.Invoices
                        where a.LegalEntityId == LegalEntityId
                        select a).Count();
            }

            if (ReturnType == CountType.Transacton || ReturnType == CountType.All)
            {
                TrCnt = (from a in dba.Transactions
                         where a.LegalEntityId == LegalEntityId
                         select a).Count();
            }

            if (ReturnType == CountType.Adjustment || ReturnType == CountType.All)
            {
                ACnt = (from a in dba.Adjustments
                        where a.LegalEntityId == LegalEntityId
                        select a).Count();
            }
                        
            return SOCnt + TCnt + PCnt + ICnt + TrCnt + ACnt + ACnt;
        }

        enum CountType { SpaceOwner, Payment, Invoice, Transacton, Adjustment, Tenant, All };

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetLegalEntity(_LegalEntityId);
        }

        private void frmLegalEntity_Load(object sender, EventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).AddControlListItem("LEGALENTITY", this.Text, 0);
            }
            catch{ }
        }

        private void frmLegalEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.ParentForm as frmDBAContainer).RemoveControlListItem(this.Text);
            }
            catch { }
        }

       
    }
}

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
    public partial class frmUtilityLegalEntityMaintain : Form
    {
        private int _LegalEntityId;
        private bool _AdminMode = false;

        private const int ExpandedHeight = 500;
        private const int ReducedHeight = 200;

        public frmUtilityLegalEntityMaintain(int LegalEntityId, bool AdminMode)
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


    }
}

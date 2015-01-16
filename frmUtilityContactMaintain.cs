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
    public partial class frmUtilityContactMaintain : Form
    {
        DBADataContext dba = new DBADataContext();
        
        private int _ContactId;
        private bool _ExistingAddress;
        private bool _AdminMode = false;
        private Guid _ObjectGuid;
        

        public frmUtilityContactMaintain(int ContactId)
        {
            InitializeComponent();

            if (ContactId == 0)
            {
                _ExistingAddress = false;
                this.Text = "Contact - New";
                return;
            }
            _ExistingAddress = true;
            this.Text = "Contact - " + contactEdit.ContactName + " - Edit";
            _ContactId = ContactId;
            GetContact(ContactId);
        }

        public int ContactId
        {
            get { return _ContactId; }
            set
            {
                _ContactId = value;
                GetContact(_ContactId);
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

        public Guid ObjectGuid
        {
            get { return _ObjectGuid; }
            set 
            { 
                _ObjectGuid = value;
                contactEdit.ObjectGuid = _ObjectGuid;
            }
        }

        private void SetAdminMode()
        {
            if (_AdminMode)
            {
                contactEdit.AdminMode = true;
            }
            else
            {
                contactEdit.AdminMode = false;
            }
        }

        private void GetContact(int ContactId)
        {
            if (ContactId > 0)
            {
                contactEdit.ContactId = ContactId;
                this.Text = "Contact - " + contactEdit.ContactName + " - Edit";
                _ExistingAddress = true;
            }
            else
            {
                this.Text = "Contact - New";
                _ExistingAddress = false;
                contactEdit.ObjectGuid = _ObjectGuid;
            }
        }

        void contactEdit_ContactChange(object source, int ContactId)
        {
            _ContactId = ContactId;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                contactEdit.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _ContactId = contactEdit.ContactId;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void contactEdit_Load(object sender, EventArgs e)
        {
            contactEdit.ContactChange += new DowntownBoiseAssociation.Controls.ContactChangeEventHandler(contactEdit_ContactChange);
        }

        private void frmUtilityContactMaintain_Load(object sender, EventArgs e)
        {
            dbA_Contact1.ContactId = _ContactId;
            dbA_Contact1.AdminMode = true;
        }

        private void dbA_Contact1_Load(object sender, EventArgs e)
        {

        }

    }
}

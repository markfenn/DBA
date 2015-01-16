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
    public partial class frmMaintainContactsNew : Form
    {
        private bool _ExistingAddress;
        private int _ContactId;                
        private Guid _ObjectGuid;
        private int _AddressId = 0;
        private DBADataContext dba = new DBADataContext();

        public frmMaintainContactsNew(int ContactId, Guid ContactGuid)
        {
            InitializeComponent();
            _ObjectGuid = ContactGuid;
            GetContact(ContactId);
        }

        private void frmMaintainContactsNew_Load(object sender, EventArgs e)
        {
            var _ContactType = from a in dba.ContactTypes
                               orderby a.ContactType1
                               select a;

            foreach (ContactType Item in _ContactType)
            {
                ddlContactDescription.Items.Add(Item.ContactType1);
            }
            ddlContactDescription.Sorted = true;
        }

        private void GetContact(int ContactId)
        {
            if (ContactId > 0)
            {                
                this.Text = "Edit Contact";
                _ExistingAddress = true;
                _ContactId = ContactId;
                FillForm();
            }
            else
            {
                this.Text = "New Contact";
                _ExistingAddress = false;             
                _ContactId = 0;
                _AddressId = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtContactName.Text.Trim() == "")
            {
                MessageBox.Show("You must have a name.");
                txtContactName.Focus();
                return;
            }

            if (_AddressId == 0)
            {
                MessageBox.Show("You must select an address.");                
                return;
            }

            if (!_ExistingAddress)
            {
                Contact _ContactInfo = new Contact
                {
                    Description = ddlContactDescription.Text.Trim(),
                    Email = txtContactEmail.Text.Trim(),
                    Name = txtContactName.Text.Trim(),
                    Phone = txtContactPhone.Text.Trim(),
                    ObjectGuid = _ObjectGuid,
                    AddressId = _AddressId
                };

                dba.Contacts.InsertOnSubmit(_ContactInfo);
                dba.SubmitChanges();                
            }
            else
            {
                Contact _ContactInfo = (from a in dba.Contacts
                                        where a.Id == _ContactId
                                        select a).FirstOrDefault();

                _ContactInfo.Description = ddlContactDescription.Text.Trim(); 
                _ContactInfo.Email = txtContactEmail.Text.Trim();
                _ContactInfo.Name = txtContactName.Text.Trim();
                _ContactInfo.Phone = txtContactPhone.Text.Trim();
                _ContactInfo.AddressId = _AddressId;

                dba.SubmitChanges();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FillForm()
        {
            Contact NewContact = (from a in dba.Contacts
                                  where a.Id == _ContactId
                                  select a).FirstOrDefault();
            if (NewContact == null)
            {
                this.Text = "New Contact";
                _ExistingAddress = false;
                _ContactId = 0;
                return;
            }

            txtContactName.Text = NewContact.Name;
            txtContactEmail.Text = NewContact.Email;
            txtContactPhone.Text = NewContact.Phone;

            ddlContactDescription.Items.Remove(NewContact.Description);
            ddlContactDescription.Items.Add(NewContact.Description);
            ddlContactDescription.Sorted = true;
            ddlContactDescription.SelectedItem = NewContact.Description;

            if (NewContact.AddressId != null) _AddressId = NewContact.AddressId.Value;

            FillAddress();

            this.Text = "Edit Contact - " + NewContact.Name;
        }

        private void FillAddress()
        {
            Address NewAddress = (from a in dba.Addresses
                                  where a.Id == _AddressId
                                  select a).FirstOrDefault();

            if (NewAddress == null)
            {
                return;
            }

            _AddressId = NewAddress.Id;

            lblAddress.Text = NewAddress.AddressLine + "\r\n" +
                NewAddress.City + ", " + NewAddress.State + "   " + NewAddress.ZipCode;
        }


        private void btnFillContact_Click(object sender, EventArgs e)
        {
            int _OldContactId = _ContactId;

            dialogSearchContact NewContact = new dialogSearchContact();
            NewContact.ObjectGuid = _ObjectGuid;
            NewContact.AddressId = _AddressId;
            NewContact.ShowDialog();

            DialogResult = DialogResult.None;

            if (NewContact.ContactId == 0) { return; }

            _ContactId = NewContact.ContactId;
            
            FillForm();

            _ContactId = _OldContactId;
        }

        private void btnSelectAddress_Click(object sender, EventArgs e)
        {
            dialogSearchAddress FindAddress = new dialogSearchAddress();
            FindAddress.ShowDialog();

            DialogResult = DialogResult.None;

            if (FindAddress.AddressId == 0) { return; }

            _AddressId = FindAddress.AddressId;

            FillAddress();           
        }
    }
}

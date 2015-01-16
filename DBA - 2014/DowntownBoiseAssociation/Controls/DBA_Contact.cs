using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    public delegate void ContactChangeEventHandler(object source, int ContactId);

    public partial class DBA_Contact : UserControl
    {
        public event ContactChangeEventHandler ContactChange;
        
        private DBADataContext dba = new DBADataContext();
        private Contact _ContactInfo;

        private Guid _objectGuid = Guid.Empty;
        private int _ContactId;
        private bool _AdminMode = false;
        private bool _ExistingItem;
        private int _AddressId;
        
        public DBA_Contact()
        {
            InitializeComponent();
            _ExistingItem = false;
            SetAdminMode();
        }

        public Boolean IsCreateContactLinkVisible
        {
            get { return linkChangeContact.Visible; }
            set { linkChangeContact.Visible = value; }
        }

        public String ContactName
        {
            get
            {
                return _ContactInfo.Name;
            }
        }

        public int ContactId
        {
            set
            {
                _ContactId = value;

                if (_ContactId == 0) { _ExistingItem = false; }
                else { _ExistingItem = true; }

                FillForm();
            }
            get { return _ContactId; }
        }

        public int AddressId
        {
            set { _AddressId = value; }
            get { return _AddressId; }
        }

        public Guid ObjectGuid
        {
            set { _objectGuid = value; }
            get { return _objectGuid; }
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
                txtContactDescription.ReadOnly = false;
                ddlContactDescription.Enabled = true;
                txtContactPhone.ReadOnly = false;
                txtContactEmail.ReadOnly = false;
                txtContactName.ReadOnly = false;

                addressLE.LinkVisible = true;
                linkFillFromExisting.Visible = true;
            }
            else
            {
                txtContactDescription.ReadOnly = true;
                ddlContactDescription.Enabled = false;
                txtContactPhone.ReadOnly = true;
                txtContactEmail.ReadOnly = true;
                txtContactName.ReadOnly = true;

                addressLE.LinkVisible = false;
                linkFillFromExisting.Visible = false;
            }
        }

        private void FillForm()
        {
            dba = new DBADataContext();
            _ContactInfo = (from b in dba.Contacts
                            where b.Id == _ContactId
                            select b).FirstOrDefault();

            if (_ContactInfo == null)
            {
                _ExistingItem = false;
                _objectGuid = Guid.Empty;
                _ContactId = 0;
                return;
            }

            _ExistingItem = true;

            txtContactDescription.Text = _ContactInfo.Description;
            txtContactEmail.Text = _ContactInfo.Email;

            //int numPhone;
            //if (int.TryParse(_ContactInfo.Phone, out numPhone) == true)
            //    mtbContactPhone.Text = numPhone.ToString();
            //else
            //    mtbContactPhone.Text = "";
            txtContactPhone.Text = _ContactInfo.Phone;

            if (!String.IsNullOrEmpty(_ContactInfo.Name))
                txtContactName.Text = _ContactInfo.Name;
            else
                txtContactName.Text = "";

            try
            {
                addressLE.AddressId = _ContactInfo.AddressId.Value;
            }
            catch
            {
                addressLE.AddressId = 0;
            }
            addressLE.AddressChange += new AddressChangeEventHandler(addressLE_AddressChange);

            var _ContactType = from a in dba.ContactTypes
                               orderby a.ContactType1
                               select a;

            foreach (ContactType Item in _ContactType)
            {
                ddlContactDescription.Items.Add(Item.ContactType1);
            }
            ddlContactDescription.Items.Remove(_ContactInfo.Description);
            ddlContactDescription.Items.Add(_ContactInfo.Description);
            ddlContactDescription.Sorted = true;
            ddlContactDescription.SelectedItem = _ContactInfo.Description;
        }

        private void addressLE_AddressChange(object source, int AddressId)
        {
            _ContactInfo.AddressId = AddressId;
            _AddressId = AddressId;
        }

        public void Save()
        {
            if (addressLE.AddressId == 0)
            {
                throw new Exception("An address must be selected.");                
            }

            if (txtContactName.Text.Trim() == "")
            {
                throw new Exception("A name is required.");            
            }

            if (!_ExistingItem || _ContactInfo == null)
            {
                _ContactInfo = new Contact
                {
                    Description = ddlContactDescription.Text.Trim(), // txtContactDescription.Text.Trim(),
                    Email = txtContactEmail.Text.Trim(),
                    Name = txtContactName.Text.Trim(),
                    Phone = txtContactPhone.Text.Trim(),
                    ObjectGuid = _objectGuid,
                    AddressId = addressLE.AddressId
                };

                dba.Contacts.InsertOnSubmit(_ContactInfo);
                dba.SubmitChanges();
                _ContactId = _ContactInfo.Id;
            }
            else
            {
                _ContactInfo.Description = ddlContactDescription.Text.Trim(); // txtContactDescription.Text.Trim(),
                _ContactInfo.Email = txtContactEmail.Text.Trim();
                _ContactInfo.Name = txtContactName.Text.Trim();
                _ContactInfo.Phone = txtContactPhone.Text.Trim();
                _ContactInfo.AddressId = addressLE.AddressId;

                dba.SubmitChanges();
            }
        }

        private void lbnChangeContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchContact NewContact = new dialogSearchContact();
            NewContact.ObjectGuid = ObjectGuid;
            NewContact.AddressId = _AddressId;
            NewContact.ShowDialog();

            if (NewContact.ContactId == 0) { return; }

            _ContactId = NewContact.ContactId;
            _objectGuid = Guid.Empty;

            FillForm();

            ContactChange(this, _ContactId);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtContactName.Text.Trim() == "")
            {
                MessageBox.Show("There must be a value in Name to search.", "Contact Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmContactSearch NewSearch = new frmContactSearch(txtContactName.Text.Trim(), _ContactId);
            NewSearch.ShowDialog();

            if (NewSearch.DialogResult != DialogResult.OK) return;

            Contact CopyContact = (from a in dba.Contacts
                                   where a.Id == NewSearch.ContactId
                                   select a).FirstOrDefault();

            txtContactName.Text = CopyContact.Name;
            txtContactPhone.Text = CopyContact.Phone;
            txtContactEmail.Text = CopyContact.Email;
            txtContactDescription.Text = CopyContact.Description;
            addressLE.AddressId = CopyContact.AddressId.Value;
        }                        

    }
}

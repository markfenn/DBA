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
    public delegate void LegalEntityChangeEventHandler(object source, int LegalEntityId);

    public partial class DBA_LegalEntity : UserControl
    {
        DBADataContext dba = new DBADataContext();
        private int _LegalEntityId;
        private LegalEntity _LegalEntity;
        private int _AddressId = 0;
        private bool _AdminMode;
        private bool _ExistingItem;

        public event LegalEntityChangeEventHandler LegalEntityChange;

        public DBA_LegalEntity()
        {
            InitializeComponent();
            _ExistingItem = false;
            _AdminMode = false;
            SetAdminMode();

            addressLE.AddressId = 0;
            addressLE.AddressChange += new AddressChangeEventHandler(addressLE_AddressChange);
        }

        public int LegalEntityId
        {
            get { return _LegalEntityId; }
            set
            {
                _LegalEntityId = value;

                FillForm();
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
                txtEmail.ReadOnly = false;
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                btnNewLE.Visible = false;
                addressLE.LinkVisible = true;
            }
            else
            {
                txtEmail.ReadOnly = true;
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                btnNewLE.Visible = true;
                addressLE.LinkVisible = false;
            }
        }

        public string LegalEntityName
        { get { return txtName.Text.Trim(); } }

        private void FillForm()
        {
            dba = new DBADataContext();

            _LegalEntity = (from a in dba.LegalEntities
                            where a.Id == _LegalEntityId
                            select a).FirstOrDefault();

            if (_LegalEntity == null) 
            {
                _LegalEntityId = 0;
                _ExistingItem = false;
                return; 
            }
            _ExistingItem = true;

            txtName.Text = _LegalEntity.Name;
            txtPhone.Text = _LegalEntity.Phone;
            txtEmail.Text = _LegalEntity.Email;

            _AddressId = _LegalEntity.MailingAddressId.Value;

            addressLE.AddressId = _LegalEntity.MailingAddressId.Value;
            //addressLE.AddressChange += new AddressChangeEventHandler(addressLE_AddressChange);
        }

        private void addressLE_AddressChange(object source, int AddressId)
        {
            _AddressId = AddressId;
            //MessageBox.Show("Address Change");
        }
               
        public bool Save()
        {
            // Does the legal entity already exist?

            var LEExist = (from a in dba.LegalEntities
                           where a.Name.Trim().ToUpper() == txtName.Text.Trim().ToUpper()
                           select a).FirstOrDefault();

            int LEExistId = _LegalEntityId;

            if (LEExist != null) { LEExistId = LEExist.Id; }

            if (_ExistingItem)
            {
                // Are they saving this record with the same name as another?
                if (LEExistId != _LegalEntityId)
                {
                    MessageBox.Show("A different Legal Entity already has this name, please use a different name.");
                    return false;
                }

                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("A Legal Entity must have a Name and Address.");
                    return false;
                }

                if (_AddressId == 0)
                {
                    MessageBox.Show("An address must be selected first.");
                    return false;
                }
                
                _LegalEntity.Name = txtName.Text.Trim();
                _LegalEntity.Phone = txtPhone.Text.Trim();
                _LegalEntity.Email = txtEmail.Text.Trim();
                _LegalEntity.MailingAddressId = _AddressId;
                try
                {
                    dba.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("There was an error saving the legal entity address");
                }
                
            }
            else
            {
                if (LEExist != null)
                {
                    MessageBox.Show("A Legal Entity already exists with this name, please enter a different name.");
                    return false;
                }
                
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("A Legal Entity must have a Name and Address.");
                    return false;
                }

                if (_AddressId == 0)
                {
                    MessageBox.Show("An address must be selected first.");
                    return false;
                }

                LegalEntity newLE = new LegalEntity
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MailingAddressId = _AddressId,
                    AccountNumber = Convert.ToString(dba.GetNewTenantNumber())
                                    
                };

                dba.LegalEntities.InsertOnSubmit(newLE);
                dba.SubmitChanges();

                _LegalEntityId = newLE.Id;
            }

            return true;
        }

        private void btnNewLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchLegalEntity NewSearch = new dialogSearchLegalEntity();
            NewSearch.ShowDialog();

            if (NewSearch.LegalEntityId == 0) { return; }

            _LegalEntityId = NewSearch.LegalEntityId;

            FillForm();

            if (LegalEntityChange != null) LegalEntityChange(this, _LegalEntityId);
        }
    }
}

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
    public delegate void AddressChangeEventHandler(object source, int AddressId);

    public partial class DBA_Address : UserControl
    {       
        private int _AddressId;
        private bool _AdminMode = false;
        private bool _ExistingItem;
        private bool _LinkVisible;

        private DBADataContext dba = new DBADataContext();

        private Address LEInfo;

        public event AddressChangeEventHandler AddressChange;
        
        public DBA_Address()
        {
            InitializeComponent();            
            _ExistingItem = false;
            _LinkVisible = false;
            btnNewAddress.Visible = _LinkVisible;
            SetAdminMode();
        }

        private void FillForm()
        {
            cbStreetDirection.DataSource = Classes.ListValues.StreetDirections();
            cbStreetDirection.DisplayMember = "Text";
            cbStreetDirection.ValueMember = "Value";

            cbStreetSuffix.DataSource = Classes.ListValues.StreetSuffixes();
            cbStreetSuffix.DisplayMember = "Text";            
            cbStreetSuffix.ValueMember = "Value";

            LEInfo = (from b in dba.Addresses
                      where b.Id == _AddressId
                      select b).FirstOrDefault();

            if (LEInfo == null)
            {
                _ExistingItem = false;
                _AddressId = 0;
                return;
            }

            _ExistingItem = true;

            txtStreetNumber.Text = LEInfo.StreetNumber.Trim();
            txtStreetName.Text = LEInfo.StreetName.Trim();
            txtStreetSuite.Text = LEInfo.StreetSuite.Trim();
            txtCity.Text = LEInfo.City;
            txtState.Text = LEInfo.State;
            txtZipCode.Text = LEInfo.ZipCode;
            
            cbStreetDirection.DisplayMember = "Text";
            cbStreetDirection.SelectedValue = LEInfo.StreetDirection.Trim().ToUpper();
            
            cbStreetSuffix.DisplayMember = "Text";
            cbStreetSuffix.SelectedValue = LEInfo.StreetSuffix.Trim();

            Classes.cbItem dItem = (Classes.cbItem)cbStreetDirection.SelectedItem;
            if (dItem == null) { dItem = new Classes.cbItem("", ""); }

            Classes.cbItem sItem = (Classes.cbItem)cbStreetSuffix.SelectedItem;
            if (sItem == null) { sItem = new Classes.cbItem("", ""); }
                        
            txtAddressAll.Text = FormatAddress(txtStreetNumber.Text,
                dItem.Text,
                txtStreetName.Text,
                sItem.Text,
                txtStreetSuite.Text);
        }

        public int AddressId
        {
            set 
            { 
                _AddressId = value;

                if (_AddressId == 0) { _ExistingItem = false; }
                else { _ExistingItem = true; }

                FillForm();
                SetAdminMode();
            }
            get { return _AddressId; }
        }

        public bool AdminMode
        {
            set
            {
                _AdminMode = value;
                SetAdminMode();
            }
        }

        public bool LinkVisible
        {
            set
            {
                _LinkVisible = value;
                btnNewAddress.Visible = _LinkVisible;
            }
        }
                
        private void SetAdminMode()
        {
            if (_AdminMode)
            {
                txtCity.ReadOnly = false;
                txtState.ReadOnly = false;
                txtZipCode.ReadOnly = false;

                txtStreetNumber.Visible = true;
                txtStreetName.Visible = true;
                txtStreetSuite.Visible = true;
                cbStreetDirection.Visible = true;
                cbStreetSuffix.Visible = true;

                txtAddressAll.Visible = false;
            }
            else
            {
                txtCity.ReadOnly = true;
                txtState.ReadOnly = true;
                txtZipCode.ReadOnly = true;

                txtStreetNumber.Visible = false;
                txtStreetName.Visible = false;
                txtStreetSuite.Visible = false;
                cbStreetDirection.Visible = false;
                cbStreetSuffix.Visible = false;

                txtAddressAll.Visible = true;
            }
        }

        public void Save()
        {
            Classes.cbItem DirectionItem = (Classes.cbItem)cbStreetDirection.SelectedItem;
            if (DirectionItem == null) { DirectionItem = new Classes.cbItem("", ""); }

            Classes.cbItem SuffixItem = (Classes.cbItem)cbStreetSuffix.SelectedItem;
            if (SuffixItem == null) { SuffixItem = new Classes.cbItem("", ""); }
            
            Address AddressExists = (from a in dba.Addresses
                                     where a.StreetNumber == txtStreetNumber.Text.Trim() &&
                                     a.StreetDirection == DirectionItem.Text.Trim() &&
                                     a.StreetName == txtStreetName.Text.Trim() &&
                                     a.StreetSuffix == SuffixItem.Text.Trim() &&
                                     a.StreetSuite == txtStreetSuite.Text.Trim() &&
                                     a.City == txtCity.Text.Trim() &&
                                     a.State == txtState.Text.Trim() &&
                                     a.ZipCode == txtZipCode.Text.Trim()
                                     select a).FirstOrDefault();

            int ExistingAddressId;

            if (AddressExists == null) { ExistingAddressId = _AddressId; }
            else { ExistingAddressId = AddressExists.Id; }

            if (_ExistingItem)
            {
                if (ExistingAddressId != _AddressId)
                {
                    throw new Exception("This address already exists in a different record, and therefore can't be updated.");                    
                }

                LEInfo.StreetNumber = txtStreetNumber.Text.Trim().ToUpper();
                LEInfo.StreetDirection = DirectionItem.Text.Trim().ToUpper();
                LEInfo.StreetName = txtStreetName.Text.Trim().ToUpper();
                LEInfo.StreetSuffix = SuffixItem.Text.Trim().ToUpper();
                LEInfo.StreetSuite = txtStreetSuite.Text.Trim().ToUpper();
                LEInfo.City = txtCity.Text.Trim().ToUpper();
                LEInfo.State = txtState.Text.Trim().ToUpper();
                LEInfo.ZipCode = txtZipCode.Text.Trim().ToUpper();

                dba.SubmitChanges();
            }
            else
            {
                if (AddressExists != null)
                {
                    throw new Exception("This address already exists, and therefore can't be added again.");                    
                }

                Address NewAddress = new Address
                {
                    StreetNumber = txtStreetNumber.Text.Trim().ToUpper(),
                    StreetDirection = DirectionItem.Text.Trim().ToUpper(),
                    StreetName = txtStreetName.Text.Trim().ToUpper(),
                    StreetSuffix = SuffixItem.Text.Trim().ToUpper(),
                    StreetSuite = txtStreetSuite.Text.Trim().ToUpper(),
                    City = txtCity.Text.Trim().ToUpper(),
                    State = txtState.Text.Trim().ToUpper(),
                    ZipCode = txtZipCode.Text.Trim().ToUpper()
                };

                dba.Addresses.InsertOnSubmit(NewAddress);

                dba.SubmitChanges();

                _AddressId = NewAddress.Id;
            }    
        }                        
                                 
        private string FormatAddress(string sNumber, string sDirection, string sName, string sSuffix, string sSuite)
        {
            return (sNumber.Trim() + " " +
                sDirection.Trim() + " " +
                sName.Trim() + " " +
                sSuffix.Trim() + " " +
                sSuite.Trim()).Trim();                
        }
       
        private void btnNewAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogSearchAddress NewAddress = new dialogSearchAddress();
            NewAddress.ShowDialog();

            if (NewAddress.AddressId == 0) { return; }

            _AddressId = NewAddress.AddressId;

            FillForm();

            if (AddressChange != null)
            {
                AddressChange(this, _AddressId);
            }
        }                 
    }
}

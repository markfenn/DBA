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
    public partial class dialogSearchContact : Form
    {
        private DBADataContext dba = new DBADataContext();

        private int _ContactId;
        private Guid _objectGuid = Guid.Empty;
        private int _AddressId = 0;
        private Boolean _SearchLimited = false;

        public dialogSearchContact()
        {
            InitializeComponent();
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

        public int ContactId
        {
            get { return _ContactId; }
        }

        public Boolean LoadSearchByObjectGuid
        {
            get { return _SearchLimited; }
            set 
            { 
                _SearchLimited = value;
                if (value && !ObjectGuid.Equals(Guid.Empty))
                    loadContactsForObjectGuid();
            }
        }

        private void loadContactsForObjectGuid()
        {
            DoSearch();
            LoadSearchByObjectGuid = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String textSearchOn = "~~~";
            if (!String.IsNullOrEmpty(tbxContactSearch.Text.Trim()))
                textSearchOn = tbxContactSearch.Text.Trim();
            if (textSearchOn == "~~~" && !LoadSearchByObjectGuid)
            {
                MessageBox.Show("You must enter a search value.");
                return;
            }
            DoSearch();
        }

        private void DoSearch()
        {
            lbSearchResults.Items.Clear();

            String textSearchOn = "~~~";
            if (!String.IsNullOrEmpty(tbxContactSearch.Text.Trim()))
                textSearchOn = tbxContactSearch.Text.Trim();
            if (textSearchOn == "~~~" && !LoadSearchByObjectGuid)
            {
                LoadSearchByObjectGuid = true;
                return;
            }

            var AddList = from a in dba.Contacts
                          where a.Name.Contains(textSearchOn) ||
                                a.Phone.StartsWith(textSearchOn) ||
                                a.Email.Contains(textSearchOn)
                          orderby a.Name, a.Email, a.Phone
                          select a;

            if (LoadSearchByObjectGuid)
            {
                AddList = from a in dba.Contacts
                          where a.ObjectGuid == ObjectGuid
                          orderby a.Name, a.Email, a.Phone
                          select a;
            }

            foreach (var Item in AddList)
            {
                Classes.SearchList NewAdd = new Classes.SearchList();

                string AddNamePart = (Item.Name).Trim();
                
                string AddEmailPart = string.IsNullOrEmpty(Item.Email) ? "" : Item.Email.Trim();

                string AddPhonePart = string.IsNullOrEmpty(Item.Phone) ? "" : Item.Phone.Trim();
                

                string AddStreetAddressPart = "";
                string AddCityAddressPart = "";
                if (!String.IsNullOrEmpty(Item.AddressId.ToString()))
                {
                    AddStreetAddressPart = (Item.Address.StreetNumber + " " +
                        Item.Address.StreetDirection + " " +
                        Item.Address.StreetName + " " +
                        Item.Address.StreetSuffix + " " +
                        Item.Address.StreetSuite).Trim();

                    AddCityAddressPart = (Item.Address.City + ", " +
                       Item.Address.State + " " +
                       Item.Address.ZipCode).Trim();
                }

                String AddAddressPart = AddStreetAddressPart + " " + AddCityAddressPart;

                NewAdd.Id = Item.Id;
                NewAdd.SearchText = AddNamePart + " (" + GetGuidType(Item.ObjectGuid.Value) +  ") " + AddEmailPart + " " + AddAddressPart;

                lbSearchResults.DisplayMember = "SearchText";
                lbSearchResults.Items.Add(NewAdd);
            }
        }

        private void lbSearchResults_DoubleClick(object sender, EventArgs e)
        {
            //Classes.SearchList NewAdd = (Classes.SearchList)lbSearchResults.SelectedItem;

            //_ContactId = NewAdd.Id;
            //DialogResult = DialogResult.OK;
            //this.Close();


            if (lbSearchResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list.");

                return;
            }

            Classes.SearchList NewAdd = (Classes.SearchList)lbSearchResults.SelectedItem;

            _ContactId = NewAdd.Id;
            this.Close();
            //frmUtilityContactMaintain NewForm = new frmUtilityContactMaintain(_ContactId);
            //NewForm.AdminMode = true;
            //NewForm.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbSearchResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list.");

                return;
            }

            Classes.SearchList NewAdd = (Classes.SearchList)lbSearchResults.SelectedItem;

            _ContactId = NewAdd.Id;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ContactId = 0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmUtilityContactMaintain NewForm = new frmUtilityContactMaintain(0);
            NewForm.AdminMode = true;
            NewForm.ShowDialog();

            if (NewForm.DialogResult == DialogResult.OK)
            {
                FindExact(NewForm.ContactId);
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (lbSearchResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list.");

                return;
            }

            Classes.SearchList NewAdd = (Classes.SearchList)lbSearchResults.SelectedItem;

            _ContactId = NewAdd.Id;

            frmUtilityContactMaintain NewForm = new frmUtilityContactMaintain(_ContactId);
            NewForm.AdminMode = true;
            NewForm.ShowDialog();
        }

        private void FindExact(int ContactId)
        {
            dba = null;
            dba = new DBADataContext();

            Contact NewContact = (from a in dba.Contacts
                                  where a.Id == ContactId
                                  select a).FirstOrDefault();

            if (NewContact == null) { return; }
            else if (NewContact.AddressId == null)
            {
                NewContact.AddressId = AddressId;
                NewContact.ObjectGuid = ObjectGuid;
                dba.SubmitChanges();
            }

            tbxContactSearch.Text = NewContact.Name;

            DoSearch();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbSearchResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list.");
                //return;
            }
            else
            {
                if (MessageBox.Show("Really delete?","Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Classes.SearchList NewAdd = (Classes.SearchList)lbSearchResults.SelectedItem;
                    var delContact = (from a in dba.Contacts
                                  where a.Id == NewAdd.Id
                                  select a).FirstOrDefault();
                    lbSearchResults.SelectedItem = null;

                    dba.Contacts.DeleteOnSubmit(delContact);
                    dba.SubmitChanges();

                }
                DoSearch();
            }
        }

        private void dialogSearchContact_Shown(object sender, EventArgs e)
        {
            tbxContactSearch.Focus();
        }

        private string GetGuidType(Guid InObjectId)
        {
            Space SpaceItem = (from a in dba.Spaces
                               where a.Guid == InObjectId
                               select a).FirstOrDefault();
            if (SpaceItem != null)
            {
                return "Space - " + DowntownBoiseAssociation.Classes.AddressHelper.FormatAddress(SpaceItem.AddressId);
            }

            Building BuildingItem = (from a in dba.Buildings
                                     where a.Guid == InObjectId
                                     select a).FirstOrDefault();
            if (BuildingItem != null)
            {
                return "Building - " + BuildingItem.Name;
            }

            Tenant TenantItem = (from a in dba.Tenants
                                 where a.Guid == InObjectId
                                 select a).FirstOrDefault();
            if (TenantItem != null)
            {
                return "Tenant - " + TenantItem.Name;
            }

            LegalEntity LEItem = (from a in dba.LegalEntities
                                  where a.Guid == InObjectId
                                  select a).FirstOrDefault();
            if (BuildingItem != null)
            {
                return "Legal Entity - " + LEItem.Name;
            }

            return "Not Found";
        }

        private void lbSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

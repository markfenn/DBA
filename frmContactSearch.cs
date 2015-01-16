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
    public partial class frmContactSearch : Form
    {
        DBADataContext db = new DBADataContext();
        private int _CurrentContactId;
        private string _ContactName;
        private bool _BlankForm = true;

        public int ContactId { get; set; }

        public frmContactSearch()
        {
            InitializeComponent();
            _BlankForm = true;
        }

        public frmContactSearch(string ContactName, int CurrentContactId)
        {
            InitializeComponent();
            _BlankForm = false;

            _CurrentContactId = CurrentContactId;
            _ContactName = ContactName;

            txtSearch.Text = _ContactName;
        }

        private void frmContactSearch_Load(object sender, EventArgs e)
        {
            //List<ContactListItem> ContactsList = new List<ContactListItem>();
            var ContactList = from a in db.Contacts
                              where a.Id == 0
                              select a;
            if (_BlankForm)
            {
                ContactList = from a in db.Contacts
                              where a.Name.Contains(_ContactName.Trim()) 
                              select a;
            }
            else
            {
                int aId = 0;

                Contact CurrentContact = (from a in db.Contacts
                                          where a.Id == _CurrentContactId
                                          select a).FirstOrDefault();
                if (CurrentContact != null) aId = CurrentContact.AddressId.Value;

                // find all of the contacts with the same name OR the same address
                ContactList = from a in db.Contacts
                                  where a.Name.Contains(_ContactName.Trim()) ||
                                  a.AddressId == aId
                                  select a;

                
                //foreach (Contact Item in ContactList)
                //{
                //    ContactListItem NewItem = new ContactListItem();
                //    NewItem.ContactId = Item.Id;
                //    NewItem.ContactName = Item.Name;
                //    NewItem.ContactGuidType = GetGuidType(Item.ObjectGuid.Value);
                //    NewItem.ContactAddress = DowntownBoiseAssociation.Classes.AddressHelper.FormatAddress(Item.AddressId.Value);
                //    ContactsList.Add(NewItem);
                //}
            }
            //lbContacts.DataSource = ContactsList;
            //lbContacts.DisplayMember = "ContactName";
            //lbContacts.ValueMember = "ContactId";

            if (ContactList.Count() > 0)
            {
                foreach (Contact Item in ContactList)
                {
                    if (_CurrentContactId != Item.Id)
                    {
                        ListItem NewItem = new ListItem();
                        NewItem.Key = Item.Id;
                        NewItem.Value = Item.Name + " (" + GetGuidType(Item.ObjectGuid.Value) + " - " + Item.Description.Trim() + " - " + DowntownBoiseAssociation.Classes.AddressHelper.FormatAddress(Item.AddressId.Value) + ")";
                        lbContacts.Items.Add(NewItem);
                        lbContacts.DisplayMember = "Value";
                        lbContacts.ValueMember = "Key";
                    }
                }

                if (lbContacts.Items.Count == 0)
                {
                    lbContacts.Items.Add("No items found.");
                //    MessageBox.Show("No other contacts match search name.");
                //    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                //    this.Close();
                    btnAccept.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No other contacts match search name.");
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private string GetGuidType(Guid InObjectId)
        {
            Space SpaceItem = (from a in db.Spaces
                               where a.Guid == InObjectId
                               select a).FirstOrDefault();
            if (SpaceItem != null)
            {
                return "Space - " + DowntownBoiseAssociation.Classes.AddressHelper.FormatAddress(SpaceItem.AddressId);
            }

            Building BuildingItem = (from a in db.Buildings
                                     where a.Guid == InObjectId
                                     select a).FirstOrDefault();
            if (BuildingItem != null)
            {
                return "Building - " + BuildingItem.Name;
            }

            Tenant TenantItem = (from a in db.Tenants
                                 where a.Guid == InObjectId
                                 select a).FirstOrDefault();
            if (TenantItem != null)
            {
                return "Tenant - " + TenantItem.Name;
            }

            LegalEntity LEItem = (from a in db.LegalEntities
                                  where a.Guid == InObjectId
                                  select a).FirstOrDefault();
            if (BuildingItem != null)
            {
                return "Legal Entity - " + LEItem.Name;                
            }

            return "Not Found";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbContacts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Contact from the list.");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ContactId = (lbContacts.SelectedItem as ListItem).Key;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
    public class ListItem
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }

    public class ContactListItem
    {
        public string ContactName { get; set; }
        public string ContactGuidType { get; set; }
        public string ContactAddress { get; set; }
        public int ContactId { get; set; }
    }
}

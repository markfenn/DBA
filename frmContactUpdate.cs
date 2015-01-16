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
    public partial class frmContactUpdate : Form
    {
        DBADataContext db = new DBADataContext();
        private int _CurrentContactId;
        private string _ContactName;

        public int ContactId { get; set; }

        public frmContactUpdate(string ContactName, int CurrentContactId)
        {
            InitializeComponent();
            _CurrentContactId = CurrentContactId;
            _ContactName = ContactName;
        }

        private void frmContactUpdate_Load(object sender, EventArgs e)
        {
            int aId = 0;

            Contact CurrentContact = (from a in db.Contacts
                                      where a.Id == _CurrentContactId
                                      select a).FirstOrDefault();
            if (CurrentContact != null) aId = CurrentContact.AddressId.Value;

            var ContactList = from a in db.Contacts
                              where a.Name.Contains(_ContactName.Trim()) ||
                              a.AddressId == aId
                              select a;

            dataContacts.DataSource = ContactList;



            //if (ContactList.Count() > 0)
            //{
            //    foreach (Contact Item in ContactList)
            //    {
            //        if (_CurrentContactId != Item.Id)
            //        {
            //            ListItem NewItem = new ListItem();
            //            NewItem.Key = Item.Id;
            //            NewItem.Value = Item.Name + " (" + GetGuidType(Item.ObjectGuid.Value) + " - " + Item.Description.Trim() + " - " + DowntownBoiseAssociation.Classes.AddressHelper.FormatAddress(Item.AddressId.Value) + ")";
            //            lbContacts.Items.Add(NewItem);
            //            lbContacts.DisplayMember = "Value";
            //            lbContacts.ValueMember = "Key";
            //        }
            //    }

            //    if (lbContacts.Items.Count == 0)
            //    {
            //        MessageBox.Show("No other contacts match search name.");
            //        DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No other contacts match search name.");
            //    DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //    this.Close();
            //}
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

        }
    }
}

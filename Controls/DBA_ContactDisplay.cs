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
    public partial class DBA_ContactDisplay : UserControl
    {
        private DBADataContext dba = new DBADataContext();

        private Guid _ObjectGuid;

        public DBA_ContactDisplay()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEditContact.Enabled = false;
            dbA_Contact1.IsCreateContactLinkVisible = false;
        }

        public Guid ObjectGuid
        {
            get { return _ObjectGuid; }
            set
            {
                _ObjectGuid = value;
                LoadContactsList();
            }
        }

        private void LoadContactsList()
        {
            var contactsList = from a in dba.Contacts
                               where a.ObjectGuid == _ObjectGuid
                               orderby a.Name
                               select a;

            lbContacts.Items.Clear();
            if (contactsList.Count() <= 0)
            {
                lbContacts.SelectionMode = SelectionMode.None;
                Classes.SearchList NewAdd = new Classes.SearchList();

                NewAdd.Id = 1;
                NewAdd.SearchText = "-- No Contacts --";

                lbContacts.DisplayMember = "SearchText";
                lbContacts.Items.Add(NewAdd);

                btnEditContact.Enabled = false;
            }
            else
            {
                lbContacts.SelectionMode = SelectionMode.One;
                foreach (var Item in contactsList)
                {
                    Classes.SearchList NewAdd = new Classes.SearchList();
                    string AddNamePart = "-- No Name Given --";
                        
                    if (Item.Name != null) AddNamePart = (Item.Name).Trim();
                    
                    NewAdd.Id = Item.Id;
                    NewAdd.SearchText = AddNamePart;

                    lbContacts.DisplayMember = "SearchText";
                    lbContacts.Items.Add(NewAdd);
                }
            }
            //dbA_Contact1.IsCreateContactLinkVisible = true;
        }

        private void lbContacts_Click(object sender, EventArgs e)
        {
            Classes.SearchList NewAdd = (Classes.SearchList)lbContacts.SelectedItem;

            if (NewAdd == null) 
            {
                btnDelete.Enabled = false;
                btnEditContact.Enabled = false;
                return; 
            }

            btnDelete.Enabled = true;
            btnEditContact.Enabled = true;

            if (!NewAdd.SearchText.Equals("-- No Contacts --"))
                dbA_Contact1.ContactId = NewAdd.Id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmUtilityContactMaintain NewContact = new frmUtilityContactMaintain(0);
            frmMaintainContactsNew NewContact = new frmMaintainContactsNew(0, _ObjectGuid);
            //NewContact.AdminMode = true;
            //NewContact.ObjectGuid = _ObjectGuid;
            NewContact.ShowDialog();

            dba = new DBADataContext();
            LoadContactsList();

            btnDelete.Enabled = false;
            btnEditContact.Enabled = false;
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            Classes.SearchList NewAdd = (Classes.SearchList)lbContacts.SelectedItem;
            if (NewAdd == null) 
            {                    
                MessageBox.Show("Please select a Contact first.");
                return; 
            }

            if (NewAdd.SearchText.Equals("-- No Contacts --"))
            {
                MessageBox.Show("Please select a Contact first.");
                return;
            }

            //frmUtilityContactMaintain EditContact = new frmUtilityContactMaintain(dbA_Contact1.ContactId);
            frmMaintainContactsNew EditContact = new frmMaintainContactsNew(dbA_Contact1.ContactId, _ObjectGuid);
            //EditContact.AdminMode = true;
            //EditContact.ObjectGuid = _ObjectGuid;
            EditContact.ShowDialog();

            dba = new DBADataContext();
            LoadContactsList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Classes.SearchList NewAdd = (Classes.SearchList)lbContacts.SelectedItem;
            if (NewAdd == null)
            {
                MessageBox.Show("Please select a Contact first.");
                return;
            }

            if (NewAdd.SearchText.Equals("-- No Contacts --"))
            {
                MessageBox.Show("Please select a Contact first.");
                return;
            }

            if (MessageBox.Show("Delete " + NewAdd.SearchText + " ?", "Contact Delete", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            var DeleteMe = (from a in dba.Contacts
                            where a.Id == NewAdd.Id
                            select a).FirstOrDefault();

            dba.Contacts.DeleteOnSubmit(DeleteMe);
            dba.SubmitChanges();

            dba = new DBADataContext();
            LoadContactsList();

            btnDelete.Enabled = false;
            btnEditContact.Enabled = false;
        }      
    }
}

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
    public partial class reportMailingLabels : Form
    {
        private DBADataContext dba = new DBADataContext();
        List<int> _biuldingList;

        public reportMailingLabels()
        {
            InitializeComponent();
        }

        public List<int> BiuldingList 
        {
            get { return _biuldingList; }
            set 
            {
                _biuldingList = value;
                if (_biuldingList != null && _biuldingList.Count > 0)
                    LoadBiuldingsIntoList();
            }
        }

        private void reportMailingLabels_Load(object sender, EventArgs e)
        {
            cbxAreaSelect.SelectedIndex = 0;
            _biuldingList = new List<int>();

            listView1.Columns.Clear();
            listView1.Columns.Add("CompanyName", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("ContactName", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Street", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("CityStateZip", 100, HorizontalAlignment.Left);
        }

        private void LoadBiuldingsIntoList()
        {
            listBox1.Items.Clear();

            var biuldings = from b in dba.Buildings
                            where BiuldingList.Contains(b.Id)
                            select b;

            Classes.SearchList NewAdd;
            foreach (var a in biuldings)
            {
                NewAdd = new Classes.SearchList();

                NewAdd.Id = a.Id;
                NewAdd.SearchText = a.Name + "     " + a.Id;

                listBox1.DisplayMember = "SearchText";
                listBox1.Items.Add(NewAdd);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbxAreaSelect.SelectedIndex == 0)
            {
                dialogBiuldingSelector NewListForm = new dialogBiuldingSelector();
                NewListForm.ShowDialog();
                if (NewListForm.DialogResult == DialogResult.OK)
                {
                    BiuldingList = NewListForm.SelectedBiuldings;
                }
            }
        }

        private void cbxAreaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAreaSelect.SelectedIndex != 0)
            {
                MessageBox.Show(" Only Select by Biulding is available at this time. ");
                btnRunReport.Visible = false;
                btnSelect.Visible = false;
                btnSave.Visible = false;
                _biuldingList = new List<int>();
                return;
            }
            else
            {
                btnRunReport.Visible = true;
                btnSelect.Visible = true;
                btnSave.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1 != null && listView1.Items.Count > 0)
            {
                if (Classes.SaveListViewToFile.SaveThisListViewToFile(listView1))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(" Must be at least one entry in the 'Requested Report Information' List. ");
                return;
            }
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            Boolean isThereABoxChecked = cbxBillTo.Checked ||
                    cbxSpaceOwners.Checked || cbxTenants.Checked;

            if (isThereABoxChecked && (BiuldingList != null && BiuldingList.Count > 0))
            {
                ListViewItem reportListItem;
                listView1.Items.Clear();
                int index = 0;
                listView1.BeginUpdate();
                if (cbxSpaceOwners.Checked)
                {
                    var data = (from a in dba.Buildings
                               join b in dba.Spaces on a.Id equals b.BuildingId
                               join c in dba.SpaceOwners on b.Id equals c.SpaceId
                               join d in dba.LegalEntities on c.LegalEntityId equals d.Id
                               join f in dba.Contacts on d.Guid equals f.ObjectGuid into ps
                               from p in ps.DefaultIfEmpty()
                               join g in dba.Addresses on d.MailingAddressId equals g.Id
                               where BiuldingList.Contains(a.Id)
                               select new
                               {
                                   BusinessName = d.Name,
                                   ContactName = p == null ? "" : p.Name,
                                   StreetAddr = g.StreetNumber + " " + g.StreetDirection + " " + g.StreetName + " " + g.StreetSuffix + " " + g.StreetSuite,
                                   CityStateZipAddr = g.City + " " + g.State + " " + g.ZipCode
                               }).Distinct();
                    foreach(var item in data)
                    {
                        reportListItem = new ListViewItem();
                        reportListItem.Text = item.BusinessName;
                        reportListItem.Tag = index;
                        reportListItem.SubItems.Add(item.ContactName);
                        reportListItem.SubItems.Add(item.StreetAddr);
                        reportListItem.SubItems.Add(item.CityStateZipAddr);

                        listView1.Items.Add(reportListItem);
                        index++;
                    }
                }
                if (cbxBillTo.Checked)
                {
                    var data = from a in dba.Buildings
                               join b in dba.Spaces on a.Id equals b.BuildingId
                               join c in dba.SpaceTennants on b.Id equals c.SpaceId
                               join d in dba.LegalEntities on c.BillToLegalEntityId equals d.Id
                               join f in dba.Contacts on d.Guid equals f.ObjectGuid into ps
                               from p in ps.DefaultIfEmpty()
                               join g in dba.Addresses on d.MailingAddressId equals g.Id
                               where BiuldingList.Contains(a.Id)
                               select new
                               {
                                   BusinessName = d.Name,
                                   ContactName = p == null ? "" : p.Name,
                                   StreetAddr = g.StreetNumber + " " + g.StreetDirection + " " + g.StreetName + " " + g.StreetSuffix + " " + g.StreetSuite,
                                   CityStateZipAddr = g.City + " " + g.State + " " + g.ZipCode
                               };
                    foreach (var item in data)
                    {
                        reportListItem = new ListViewItem();
                        reportListItem.Text = item.BusinessName;
                        reportListItem.Tag = index;
                        reportListItem.SubItems.Add(item.ContactName);
                        reportListItem.SubItems.Add(item.StreetAddr);
                        reportListItem.SubItems.Add(item.CityStateZipAddr);

                        listView1.Items.Add(reportListItem);
                        index++;
                    }
                }
                if (cbxTenants.Checked)
                {
                    var data = from a in dba.Buildings
                               join b in dba.Spaces on a.Id equals b.BuildingId
                               join c in dba.SpaceTennants on b.Id equals c.SpaceId
                               join d in dba.Tenants on c.TenantId equals d.Id
                               join f in dba.LegalEntities on d.LegalEntityId equals f.Id
                               join g in dba.Contacts on f.Guid equals g.ObjectGuid into ps
                               from p in ps.DefaultIfEmpty()
                               join h in dba.Addresses on f.MailingAddressId equals h.Id
                               where BiuldingList.Contains(a.Id)
                               select new
                               {
                                   BusinessName = f.Name,
                                   ContactName = p == null ? "" : p.Name,
                                   StreetAddr = h.StreetNumber + " " + h.StreetDirection + " " + h.StreetName + " " + h.StreetSuffix + " " + h.StreetSuite,
                                   CityStateZipAddr = h.City + " " + h.State + " " + h.ZipCode
                               };
                    foreach (var item in data)
                    {
                        reportListItem = new ListViewItem();
                        reportListItem.Text = item.BusinessName;
                        reportListItem.Tag = index;
                        reportListItem.SubItems.Add(item.ContactName);
                        reportListItem.SubItems.Add(item.StreetAddr);
                        reportListItem.SubItems.Add(item.CityStateZipAddr);

                        listView1.Items.Add(reportListItem);
                        index++;
                    }
                }
                listView1.EndUpdate();

                ListView.ListViewItemCollection lvCollection = new ListView.ListViewItemCollection(listView1);
                List<ListViewItem> tempLVList = new List<ListViewItem>();

                foreach (ListViewItem item in lvCollection)
                    tempLVList.Add(item);

                listView1.Items.Clear();

                var newLV = from c in tempLVList
                            orderby c.SubItems[0].Text
                            select c;

                listView1.Update();
                foreach (ListViewItem lvi in newLV)
                    listView1.Items.Add(lvi);
                listView1.EndUpdate();
            }
            else
            {
                MessageBox.Show(" Must be Items in the Selected List & at least one person of interest must be checked. ");
                return;
            }
        }

    }
}

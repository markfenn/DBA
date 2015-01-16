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
    public partial class dialogBiuldingSelector : Form
    {
        private DBADataContext dba = new DBADataContext();

        private List<int> _selectedBiuldings = new List<int>();
        private Boolean _unselectAllFlag = true;

        public List<int> SelectedBiuldings
        {
            get { return _selectedBiuldings; }
            set { _selectedBiuldings = value; }
        }

        public dialogBiuldingSelector()
        {
            InitializeComponent();

            listView1.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Block Num", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Yr Built", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Yr Renovated", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Parcel No", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Floors", 80, HorizontalAlignment.Left);

            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;
        }

        private void LoadBiuldingsIntoList()
        {
            var dataList = from a in dba.Blocks
                           from b in dba.Buildings
                           where a.Id == b.BlockId
                           orderby b.Name
                           select new
                           {
                               b.Id,
                               a.BlockNumber,
                               b.Guid,
                               b.BlockId,
                               b.Name,
                               b.YearBuilt,
                               b.YearRenovated,
                               b.ParcelNo,
                               b.Floors
                           };

            listView1.Items.Clear();
            listView1.BeginUpdate();

            ListViewItem reportListItem;
            foreach (var c in dataList)
            {
                reportListItem = new ListViewItem();
                reportListItem.Text = c.Name;
                reportListItem.Tag = c.Id;
                reportListItem.SubItems.Add(c.BlockNumber.ToString());
                if (c.YearBuilt == null)
                    reportListItem.SubItems.Add("");
                else
                    reportListItem.SubItems.Add(c.YearBuilt.Value.ToString());
                if (c.YearRenovated == null)
                    reportListItem.SubItems.Add("");
                else
                    reportListItem.SubItems.Add(c.YearRenovated.Value.ToString());
                reportListItem.SubItems.Add(c.ParcelNo);
                if (c.Floors == null)
                    reportListItem.SubItems.Add("");
                else
                    reportListItem.SubItems.Add(c.Floors.Value.ToString());
                listView1.Items.Add(reportListItem);
            }
            listView1.EndUpdate();
        }

        private void SetPreselects()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (SelectedBiuldings.Contains((int)item.Tag))
                    item.Selected = true;
            }
        }

        private void dialogBiuldingSelector_Load(object sender, EventArgs e)
        {
            LoadBiuldingsIntoList();
            SetPreselects();
            cbxSelectAll.Checked = (listView1.Items.Count == listView1.SelectedItems.Count);
        }

        private void cbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSelectAll.Checked)
            {
                this.listView1.Focus();
                SendKeys.Send("{HOME} ");
                SendKeys.Send("+{END}");
            }
            else
            {
                if (_unselectAllFlag)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        item.Selected = false;
                        item.Checked = false;
                    }
                }
                _unselectAllFlag = true;
            }
            listView1.Refresh();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count != listView1.SelectedItems.Count)
                _unselectAllFlag = false;
            cbxSelectAll.Checked = (listView1.Items.Count == listView1.SelectedItems.Count);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            List<int> tempList = new List<int>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                    tempList.Add((int)item.Tag);
            }
            SelectedBiuldings = tempList;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}

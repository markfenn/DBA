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
    public partial class dialogSearchAddress : Form
    {
        DBADataContext dba = new DBADataContext();
        int _StreetId = 0;

        public dialogSearchAddress()
        {
            InitializeComponent();
        }

        public int AddressId
        { get { return _StreetId; } }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch()
        {
            Classes.cbItem dItem = (Classes.cbItem)cbStreetDirection.SelectedItem;
            if (dItem == null) { dItem = new Classes.cbItem("", ""); }

            Classes.cbItem sItem = (Classes.cbItem)cbStreetSuffix.SelectedItem;
            if (sItem == null) { sItem = new Classes.cbItem("", ""); }

            string sNumber = "~~";
            if (txtStreetNumber.Text.Trim() != "") { sNumber = txtStreetNumber.Text.Trim(); }

            string sName = "~~";
            if (txtStreetName.Text.Trim() != "") { sName = txtStreetName.Text.Trim(); }

            string sDirection = "~~";
            if (dItem.Text.Trim() != "") { sDirection = dItem.Text.Trim(); }

            string sSuffix = "~~";
            if (sItem.Text.Trim() != "") { sSuffix = sItem.Text.Trim(); }

            string sSuite = "~~";
            if (txtStreetSuite.Text.Trim() != "") { sSuite = txtStreetSuite.Text.Trim(); }


            if ((sName == "~~") &&
            (sNumber == "~~") &&
            (sSuffix == "~~") &&
            (sSuite == "~~") &&
            (sDirection == "~~"))
            {
                MessageBox.Show("You must enter a search value.");
                return;
            }

            var AddList = from a in dba.Addresses
                          where (a.StreetNumber.StartsWith(sNumber) ||
                              (sNumber == "~~")) &&

                              (a.StreetName.Contains(sName) ||
                              (sName == "~~")) &&

                              (a.StreetDirection == sDirection ||
                              (sDirection == "~~")) &&

                              (a.StreetSuffix == sSuffix ||
                              (sSuffix == "~~")) &&

                              (a.StreetSuite.Contains(sSuite) ||
                              (sSuite == "~~"))
                          orderby a.StreetName, a.StreetDirection, a.StreetNumber, a.StreetSuffix, a.StreetSuite
                          select a;

            lbSearch.Items.Clear();
            foreach (var Item in AddList)
            {
                Classes.SearchList NewAdd = new Classes.SearchList();

                string AddPart = (Item.StreetNumber + " " +
                    Item.StreetDirection + " " +
                    Item.StreetName + " " +
                    Item.StreetSuffix + " " +
                    Item.StreetSuite).Trim().PadRight(40);

                string CitPart = (Item.City + ", " +
                    Item.State + " " +
                    Item.ZipCode).Trim();

                NewAdd.Id = Item.Id;
                NewAdd.SearchText = AddPart + CitPart;

                lbSearch.DisplayMember = "SearchText";
                lbSearch.Items.Add(NewAdd);
            }
        }

        private void frmDialogSearchAddress_Load(object sender, EventArgs e)
        {
            cbStreetDirection.DataSource = Classes.ListValues.StreetDirections();
            cbStreetDirection.DisplayMember = "Text";
            cbStreetDirection.ValueMember = "Value";

            cbStreetSuffix.DataSource = Classes.ListValues.StreetSuffixes();
            cbStreetSuffix.DisplayMember = "Text";
            cbStreetSuffix.ValueMember = "Value";

        }

        private void lbSearch_DoubleClick(object sender, EventArgs e)
        {
            Classes.SearchList NewAdd = (Classes.SearchList)lbSearch.SelectedItem;

            _StreetId = NewAdd.Id;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list."); 
                
                return;
            }

            Classes.SearchList NewAdd = (Classes.SearchList)lbSearch.SelectedItem;

            _StreetId = NewAdd.Id;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _StreetId = 0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            frmUtilityAddressMaintain NewForm = new frmUtilityAddressMaintain(0);
            NewForm.ShowDialog();

            if (NewForm.DialogResult == DialogResult.OK)
            {
                FindExact(NewForm.AddressId);
            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the list.");

                return;
            }

            Classes.SearchList NewAdd = (Classes.SearchList)lbSearch.SelectedItem;

            _StreetId = NewAdd.Id;

            frmUtilityAddressMaintain NewForm = new frmUtilityAddressMaintain(_StreetId);
            NewForm.ShowDialog();

            if (NewForm.DialogResult == DialogResult.OK)
            {
                FindExact(NewForm.AddressId);
            }
        }

        private void FindExact(int AddressId)
        {
            dba = null;
            dba = new DBADataContext();
            //dba.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dba.Addresses);
                        
            Address NewAddress = (from a in dba.Addresses
                                  where a.Id == AddressId
                                  select a).FirstOrDefault();

            if (NewAddress == null) { return; }

            txtStreetNumber.Text = NewAddress.StreetNumber;
            txtStreetName.Text = NewAddress.StreetName;
            txtStreetSuite.Text = NewAddress.StreetSuite;

            cbStreetDirection.DisplayMember = "Text";
            cbStreetDirection.SelectedValue = NewAddress.StreetDirection;

            cbStreetSuffix.DisplayMember = "Text";
            cbStreetSuffix.SelectedValue = NewAddress.StreetSuffix;

            DoSearch();
        }
    }
}

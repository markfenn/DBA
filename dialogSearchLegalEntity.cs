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
    public partial class dialogSearchLegalEntity : Form
    {
        DBADataContext dba = new DBADataContext();
        int _LegalEntityId = 0;

        public dialogSearchLegalEntity()
        {
            InitializeComponent();
        }

        public int LegalEntityId
        { get { return _LegalEntityId; } }

        private void DoSearch()
        {
            dba = new DBADataContext();

            string lName = "~~";
            if (txtLegalEntityName.Text.Trim() != "") { lName = txtLegalEntityName.Text.Trim(); }
            
            if (lName == "~~")            
            {
                MessageBox.Show("You must enter a search value.");
                return;
            }

            var AddList = from a in dba.LegalEntities
                          where (a.Name.Contains(lName) || (lName == "~~"))
                          orderby a.Name
                          select a;

            lbSearch.Items.Clear();
            foreach (var Item in AddList)
            {
                Classes.SearchList NewAdd = new Classes.SearchList();

                string AddPart = Item.Name.Trim().PadRight(50) +
                    Item.AccountNumber;

                NewAdd.Id = Item.Id;
                NewAdd.SearchText = AddPart;

                lbSearch.DisplayMember = "SearchText";
                lbSearch.Items.Add(NewAdd);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _LegalEntityId = 0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void lbSearch_DoubleClick(object sender, EventArgs e)
        {
            Classes.SearchList SearchItem = (Classes.SearchList)lbSearch.SelectedItem;

            _LegalEntityId = SearchItem.Id;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an item first.");
                return;
            }

            Classes.SearchList SearchItem = (Classes.SearchList)lbSearch.SelectedItem;

            _LegalEntityId = SearchItem.Id;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddLegalEntity_Click(object sender, EventArgs e)
        {
            frmLegalEntity NewForm = new frmLegalEntity(0, true);
            NewForm.ShowDialog();

            if (NewForm.DialogResult == DialogResult.OK)
            {
                var LE = (from a in dba.LegalEntities
                          where a.Id == NewForm.LegalEntityId
                          select a).FirstOrDefault();

                if (LE != null)
                {
                    txtLegalEntityName.Text = LE.Name;
                    DoSearch();
                }
            }
        }

        private void btnEditLegalEntity_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an item first.");
                return;
            }

            Classes.SearchList SearchItem = (Classes.SearchList)lbSearch.SelectedItem;

            frmLegalEntity NewForm = new frmLegalEntity(SearchItem.Id, true);
            NewForm.ShowDialog();

            DoSearch();
        }
        
        private void dialogSearchLegalEntity_Shown(object sender, EventArgs e)
        {
            txtLegalEntityName.Focus();
        }
    }
}

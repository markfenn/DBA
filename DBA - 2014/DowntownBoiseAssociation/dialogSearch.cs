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
    public partial class dialogSearch : Form
    {
        DBADataContext g = new DBADataContext();
        private string _SearchValue;
        private Form _ContainerForm;
        private string _SearchOnlyType;
        private bool _OpenRelatedWindow;

        public dialogSearch(string SearchValue, Form ContainerForm, bool OpenRelatedWindow, string SearchOnlyType)
        {
            InitializeComponent();

            _SearchValue = SearchValue;
            _ContainerForm = ContainerForm;
            _SearchOnlyType = SearchOnlyType;
            _OpenRelatedWindow = OpenRelatedWindow;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("No search criteria.");
                return;
            }

            SearchMe(txtSearch.Text);
        }

        private void SearchMe(string SearchValue)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            flowSearch.Controls.Clear();
            Application.DoEvents();
            
            var s = from a in g.vw_Search_News
                    where a.NAME.Contains(SearchValue.Trim())
                    || a.ACCOUNT.Contains(SearchValue.Trim())
                    
                    select new { NAME = a.NAME, ID = a.ID, a.TYPE, a.ACCOUNT };

            lblTotal.Text = "Total Results: " + s.Count().ToString() + "   (max 200 shown)";
            
            progressBar1.Maximum = s.Count();
            if (s.Count() > 200) { progressBar1.Maximum = 201; }
            
            Application.DoEvents();
            foreach (var item in s)
            {
                Form NewForm = this;
                Form NewContainerForm = _ContainerForm;

                    DowntownBoiseAssociation.Controls.DBA_SearchItem NewItem = new DowntownBoiseAssociation.Controls.DBA_SearchItem(
                        GetDBAType(item.TYPE),
                        item.ID,
                        item.NAME,
                        item.ACCOUNT);
                    NewItem.ViewSelectionClick += new Controls.ViewSelectionEventHandler(DBA_SearchItem_ViewSelectionClick);

                flowSearch.Controls.Add(NewItem);

                progressBar1.Increment(1);

                if (progressBar1.Value > 200)
                {
                    break;
                }
            }

            //lbSearch.Items.Clear();
            //lbSearch.DisplayMember = "SearchText";
            
            //foreach (var item in s)
            //{
            //    string iText = item.NAME.Trim().PadRight(45) +
            //        item.ACCOUNT.Trim().PadRight(20) +
            //        item.TYPE.PadLeft(15);

            //    Classes.SearchList NewSearch = new DowntownBoiseAssociation.Classes.SearchList();
            //    NewSearch.Id = item.ID;
            //    NewSearch.SearchText = iText;
                                
            //    lbSearch.Items.Add(NewSearch);
            //}

            progressBar1.Visible = false;
            Application.DoEvents();
        }

        private void DBA_SearchItem_ViewSelectionClick(object sender, int ItemId, Controls.SearchItemType ItemType)
        {
            if (_OpenRelatedWindow)
            {
                if (ItemType == DowntownBoiseAssociation.Controls.SearchItemType.Tenant ||
                    ItemType == DowntownBoiseAssociation.Controls.SearchItemType.Government ||
                    ItemType == DowntownBoiseAssociation.Controls.SearchItemType.Parking)
                {
                    if (_OpenRelatedWindow)
                    {
                        frmTenant NewTenant = new frmTenant(ItemId);

                        frmDBAContainer NewForm = (frmDBAContainer)_ContainerForm;
                        NewForm.AddMDIChildForm(NewTenant);

                        //frmTenantNew NewTenantNew = new frmTenantNew(ItemId);
                        //NewForm.AddMDIChildForm(NewTenantNew);

                    }
                }
                else if (ItemType == DowntownBoiseAssociation.Controls.SearchItemType.LegalEntity)
                {
                    frmLegalEntity NewLegalEntity = new frmLegalEntity(ItemId, false);

                    frmDBAContainer NewForm = (frmDBAContainer)_ContainerForm;
                    NewForm.AddMDIChildForm(NewLegalEntity);
                }
                else if (ItemType == DowntownBoiseAssociation.Controls.SearchItemType.Building)
                {
                    frmBuilding NewBuilding = new frmBuilding(ItemId);
                    NewBuilding.MyParent = _ContainerForm;

                    frmDBAContainer NewForm = (frmDBAContainer)_ContainerForm;
                    NewForm.AddMDIChildForm(NewBuilding);
                }
            }
            this.Close();
        }

        private DowntownBoiseAssociation.Controls.SearchItemType GetDBAType(string Type)
        {
            if (Type == "BUILDING") { return DowntownBoiseAssociation.Controls.SearchItemType.Building; }
            if (Type == "TENANT") { return DowntownBoiseAssociation.Controls.SearchItemType.Tenant; }
            if (Type == "LEGALENTITY") { return DowntownBoiseAssociation.Controls.SearchItemType.LegalEntity; }
            if (Type == "PARKING") { return DowntownBoiseAssociation.Controls.SearchItemType.Parking; }
            if (Type == "GOVERNMENT") { return DowntownBoiseAssociation.Controls.SearchItemType.Government; }
            return DowntownBoiseAssociation.Controls.SearchItemType.Contact;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dialogSearch_Shown(object sender, EventArgs e)
        {
            if (_SearchValue.Trim() != "")
            {
                txtSearch.Text = _SearchValue;
                SearchMe(_SearchValue);
            }
        }
    }
}

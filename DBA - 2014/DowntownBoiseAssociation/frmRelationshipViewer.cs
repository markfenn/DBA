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
    public partial class frmRelationshipViewer : Form
    {
        private string _CurrentRelationship = "";
        private int _CurrentId = 0;
        private string _CurrentName = "";
        private List<string> _ViewHistory = new List<string>();
        private List<int> _ViewHistoryId = new List<int>();
        private List<string> _ViewName = new List<string>();
        private DBADataContext dba = new DBADataContext();
        private Form _ParentForm;

        private int _SelectId;
        private string _SelectName;

        public frmRelationshipViewer(Form ParentForm)
        {
            InitializeComponent();

            _ParentForm = ParentForm;
        }

        private void frmRelationshipViewer_Load(object sender, EventArgs e)
        {
            SetRelationship(cbRelation.Text, 0);             
            _ViewHistory.Add(_CurrentRelationship);
            _ViewHistoryId.Add(_CurrentId);            
            lblBreadCrumb.Text = ShowBreadCrumb();
        }

        private void BuildTreeZone(System.Windows.Forms.ListView View, int UniqueId)
        {
            View.Items.Clear();
            
            var AllItems = from a in dba.Zones                           
                           orderby a.Name
                           select a;

            foreach (var Item in AllItems)
            {
                string[] Cols = new string[4];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.Name;
                Cols[2] = "";
                Cols[3] = "";
                ListViewItem NewItem = new ListViewItem(Cols);
                View.Items.Add(NewItem);
            }
        }

        private void BuildTreeBlock(System.Windows.Forms.ListView View, int UniqueId)
        {
            View.Items.Clear();

            bool GetAll = false;
            if (UniqueId == 0) { GetAll = true; }

            var AllItems = from a in dba.Blocks
                           where a.ZoneId == UniqueId ||
                           GetAll
                           orderby a.Name
                           select a;

            foreach (var Item in AllItems)
            {
                string[] Cols = new string[4];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.Name;
                Cols[2] = Item.Description.Trim();
                Cols[3] = "";
                ListViewItem NewItem = new ListViewItem(Cols);
                View.Items.Add(NewItem);
            }                       
        }

        private void BuildTreeBuilding(System.Windows.Forms.ListView View, int UniqueId)
        {
            View.Items.Clear();

            bool GetAll = false;
            if (UniqueId == 0) { GetAll = true; }

            var AllItems = from a in dba.Buildings
                           where a.BlockId == UniqueId ||
                           GetAll
                           orderby a.Name
                           select a;

            foreach (var Item in AllItems)
            {
                string[] Cols = new string[4];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.Name;
                Cols[2] = (Item.TotalSqFt == null ? "0" : Item.TotalSqFt.Value.ToString()) + " SqFt";
                Cols[3] = (Item.Floors == null ? "?" : Item.Floors.ToString()) + " Floors";
                ListViewItem NewItem = new ListViewItem(Cols);
                View.Items.Add(NewItem);
            }
        }

        private void BuildTreeSpace(System.Windows.Forms.ListView View, int UniqueId)
        {
            View.Items.Clear();

            bool GetAll = false;
            if (UniqueId == 0) { GetAll = true; }

            var AllItems = from a in dba.Spaces
                           join b in dba.Addresses
                           on a.AddressId equals b.Id
                           join c in dba.SpaceTennants
                           on a.Id equals c.SpaceId
                           join d in dba.Tenants
                           on c.TenantId equals d.Id
                           join e in dba.LegalEntities
                           on d.LegalEntityId equals e.Id
                           where (a.BuildingId == UniqueId ||
                           GetAll) &&
                           c.StartDate == (from c1 in dba.SpaceTennants
                                          where c1.SpaceId == c.SpaceId
                                          select c1.StartDate).Max()                          
                           orderby b.StreetName, b.StreetNumber, b.StreetSuite
                           select new   
                           {
                               Id = a.Id,
                               Name = b.StreetNumber + " " + 
                                    b.StreetDirection + " " + 
                                    b.StreetName + " " +
                                    b.StreetSuffix + " " + 
                                    b.StreetSuite.Trim().Replace("  ", " "),
                               Misc1 = (a.SqFt.HasValue ? a.SqFt.Value.ToString().Trim() : "0") + " Sqft",
                               Misc2 = (c.EndDate != null ? "~VACANT~ " : e.Name + " ")
                           };
            
            foreach (var Item in AllItems)
            {
                string[] Cols = new string[4];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.Name;
                Cols[2] = Item.Misc1;
                Cols[3] = Item.Misc2;
                ListViewItem NewItem = new ListViewItem(Cols);
                View.Items.Add(NewItem);
            }
        }

        private void BuildTreeTenantSpace(System.Windows.Forms.ListView View, int UniqueId)
        {
            View.Items.Clear();

            bool GetAll = false;
            if (UniqueId == 0) { GetAll = true; }

            var AllItems = from c in dba.SpaceTennants                           
                           join d in dba.Tenants
                           on c.TenantId equals d.Id
                           join e in dba.LegalEntities
                           on d.LegalEntityId equals e.Id
                           where (c.SpaceId == UniqueId)
                           orderby c.StartDate descending
                           select new
                           {
                               Id = c.Id,
                               Name = e.Name,
                               Misc1 = c.StartDate,
                               Misc2 = c.EndDate
                           };

            foreach (var Item in AllItems)
            {
                string[] Cols = new string[4];

                Cols[0] = Item.Id.ToString();
                Cols[1] = Item.Name;
                Cols[2] = Item.Misc1.ToString("MM/dd/yyyy");
                Cols[3] = Item.Misc2 != null ? Item.Misc2.Value.ToString("MM/dd/yyyy") : "Current";
                ListViewItem NewItem = new ListViewItem(Cols);
                View.Items.Add(NewItem);
            }
        }

        private void cbRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ViewHistory.Clear();
            _ViewHistoryId.Clear();
            _ViewName.Clear();

            SetRelationship(cbRelation.Text, 0);
            _ViewHistory.Add(_CurrentRelationship);
            _ViewHistoryId.Add(0);
            
            lblBreadCrumb.Text = ShowBreadCrumb();
            btnBackLevel.Enabled = false;
        }

        private void SetRelationship(string RelationshipType, int RelationId)
        {
            if (RelationshipType.Trim().ToUpper() == "BLOCKS")
            {
                _CurrentRelationship = "BLOCKS";
                BuildTreeBlock(listRelation, RelationId);
            }

            if (RelationshipType.Trim().ToUpper() == "BUILDINGS")
            {
                _CurrentRelationship = "BUILDINGS";
                BuildTreeBuilding(listRelation, RelationId);
            }

            if (RelationshipType.Trim().ToUpper() == "ZONES")
            {
                _CurrentRelationship = "ZONES";
                BuildTreeZone(listRelation, RelationId);
            }

            if (RelationshipType.Trim().ToUpper() == "SPACES")
            {
                _CurrentRelationship = "SPACES";
                BuildTreeSpace(listRelation, RelationId);
            }

            if (RelationshipType.Trim().ToUpper() == "TENANTSPACES")
            {
                _CurrentRelationship = "TENANTSPACES";
                BuildTreeTenantSpace(listRelation, RelationId);
            }
        }

        private void listRelation_DoubleClick(object sender, EventArgs e)
        {
            if (_CurrentRelationship == "TENANTSPACES")
            {
                return;
            }

            _CurrentId = Convert.ToInt32(listRelation.SelectedItems[0].SubItems[0].Text);
            _CurrentName = listRelation.SelectedItems[0].SubItems[1].Text;
                                    
            SetRelationship(GetNextRelationship(_CurrentRelationship), _CurrentId);
            _ViewHistory.Add(_CurrentRelationship);
            _ViewHistoryId.Add(_CurrentId);
            _ViewName.Add(_CurrentName);
            lblBreadCrumb.Text = ShowBreadCrumb();

            btnBackLevel.Enabled = true;
        }

        private string GetNextRelationship(string CurrentRelationship)
        {            
            if (CurrentRelationship == "ZONES") { return "BLOCKS"; }
            if (CurrentRelationship == "BLOCKS") { return "BUILDINGS"; }
            if (CurrentRelationship == "BUILDINGS") { return "SPACES"; }
            if (CurrentRelationship == "SPACES") { return "TENANTSPACES"; }
            if (CurrentRelationship == "TENANTSPACES") { return "~NO MORE~"; }
            return "~NO MORE~";
        }

        private string ShowBreadCrumb()
        {
            string b = "";

            for(int x = 0; x < _ViewHistory.Count(); x++)                
            {
                string vName = "";

                if (x <= _ViewName.Count() - 1) { vName = " (" + _ViewName[x].Trim().ToUpper() + ")"; }
                
                b += _ViewHistory[x] + vName + " -> ";
            }

            return b.Substring(0, b.Length - 4).Trim();
        }

        private void btnBackLevel_Click(object sender, EventArgs e)
        {
            _ViewHistoryId.RemoveAt(_ViewHistoryId.Count() - 1);
            _ViewHistory.RemoveAt(_ViewHistory.Count() - 1);
            _ViewName.RemoveAt(_ViewName.Count() - 1);

            _CurrentRelationship = _ViewHistory[_ViewHistory.Count() - 1];
            _CurrentId = _ViewHistoryId[_ViewHistoryId.Count() - 1];

            try { _CurrentName = _ViewName[_ViewName.Count() - 1]; }
            catch { _CurrentName = ""; }

            lblBreadCrumb.Text = ShowBreadCrumb();
            SetRelationship(_CurrentRelationship, _CurrentId);

            if (_ViewHistoryId.Count() == 1) { btnBackLevel.Enabled = false; }
        }

        private void editThisItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDBAContainer PForm = (frmDBAContainer)_ParentForm;
                        
            if (_CurrentRelationship == "ZONES")
            {                
                frmZoneMaint NewForm = new frmZoneMaint(_SelectId);
                PForm.AddMDIChildForm(NewForm);             
            }

            if (_CurrentRelationship == "BLOCKS")
            {
                var hist = (from a in dba.Zones
                            join b in dba.Blocks
                            on a.Id equals b.ZoneId
                            where b.Id == _SelectId
                            select b).FirstOrDefault();
                frmAdminZone NewForm = new frmAdminZone();
                NewForm.ZoneId = hist.Zone.Id;
                NewForm.BlockId = _SelectId;
                NewForm.LookupEntry();
                PForm.AddMDIChildForm(NewForm);                
            }

            if (_CurrentRelationship == "BUILDINGS")
            {
                frmBuilding NewBuilding = new frmBuilding(_SelectId);
                PForm.AddMDIChildForm(NewBuilding);                
            }

            if (_CurrentRelationship == "SPACES")
            {
                if (listRelation.SelectedItems[0].SubItems[3].Text.Trim() != "~VACANT~")
                {

                    int TenantId = (from a in dba.Spaces
                                    join b in dba.SpaceTennants
                                    on a.Id equals b.SpaceId
                                    join c in dba.Tenants
                                    on b.TenantId equals c.Id
                                    where a.Id == Convert.ToInt32(listRelation.SelectedItems[0].SubItems[0].Text)
                                    select c.Id).FirstOrDefault();

                    frmTenantNew TForm = new frmTenantNew(TenantId);
                    PForm.AddMDIChildForm(TForm);
                }
            }

            if (_CurrentRelationship == "TENANTSPACES")
            {
                dialogSpaceTenant NewSpace = new dialogSpaceTenant(0, _SelectId);                
                PForm.AddMDIChildForm(NewSpace);
            }
        }

        private void menuRelationship_Opening(object sender, CancelEventArgs e)
        {          
            try
            {
                _SelectId = Convert.ToInt32(listRelation.SelectedItems[0].SubItems[0].Text);
                _SelectName = listRelation.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                _SelectName = "";
                _SelectId = 0;
            }

            if (_SelectName == "") { e.Cancel = true; }

            
            if (_CurrentRelationship == "SPACES")
            {
                if (listRelation.SelectedItems[0].SubItems[3].Text.Trim() != "~VACANT~")
                {
                    //menuRelationship.Items[0].Text = "Edit Space: " + _SelectName;
                    //menuRelationship.Items[1].Visible = true;
                    //menuRelationship.Items[1].Text = "Edit Tenant: " + listRelation.SelectedItems[0].SubItems[3].Text;
                    menuRelationship.Items[0].Text = "Edit Tenant: " + listRelation.SelectedItems[0].SubItems[3].Text + 
                        " (double-click to see Tenant Space entries)";
                }
                else
                {
                    menuRelationship.Items[0].Text = "(This space is vacant, please double-click to see Tenant Space entries)" ;
                    menuRelationship.Items[1].Visible = false;
                }
            }
            else
            {
                menuRelationship.Items[1].Visible = false;
                menuRelationship.Items[0].Text = "Edit: " + _SelectName;
            }
        }

        //private void editThisItemToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    int TenantId = (from a in dba.Spaces
        //                    join b in dba.SpaceTennants
        //                    on a.Id equals b.SpaceId
        //                    join c in dba.Tenants
        //                    on b.TenantId equals c.Id
        //                    where a.Id == Convert.ToInt32(listRelation.SelectedItems[0].SubItems[0].Text)
        //                    select c.Id).FirstOrDefault();

        //    frmDBAContainer PForm = (frmDBAContainer)_ParentForm;
        //    frmTenantView TForm = new frmTenantView(TenantId);
        //    PForm.AddMDIChildForm(TForm);
        //}
    }
}

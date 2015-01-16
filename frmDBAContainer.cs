using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DowntownBoiseAssociation.Reports.ReportServer;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace DowntownBoiseAssociation
{
    public partial class frmDBAContainer : Form
    {
   
        public Form ThisForm;
        private string _ReportServer = ConfigurationManager.AppSettings["DBA_ReportServer"].ToString();
        private string _ReportPath = ConfigurationManager.AppSettings["DBA_ReportPath"].ToString();
        
        private string _ReportUserName = ConfigurationManager.AppSettings["DBA_ReportUserName"].ToString();
        private string _ReportUserPassword = ConfigurationManager.AppSettings["DBA_ReportUserPassword"].ToString();
        private string _ReportUserDomain = ConfigurationManager.AppSettings["DBA_ReportUserDomain"].ToString();


        public string _ConnStr = ConfigurationManager.ConnectionStrings["DowntownBoiseAssociation.Properties.Settings.DBADevConnectionString"].ConnectionString;
        //private string[] _ConnArray;
        private string _ConnServer;
        private string _ConnDatabase; 
        
        private string _RegReportPrefix = "regrpt";
        private string _ARReportPrefix = "arrpt";

        private string TransInAction = "";

        public frmDBAContainer()
        {
            InitializeComponent();
            if (Properties.Settings.Default.RecentLegalEntities == null)
            {
                Properties.Settings.Default.RecentLegalEntities = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.RecentTenants = new System.Collections.Specialized.StringCollection();
            }

            string[] _ConnArray = _ConnStr.Split(Convert.ToChar(";"));
            _ConnServer = GetConnectionStringItem(_ConnArray, "Data Source");
            _ConnDatabase = GetConnectionStringItem(_ConnArray, "Initial Catalog");
            string txtTest = "";

          
            
            if (_ConnDatabase.ToUpper().Contains("TEST"))
            {
                tsSearch.BackColor = Color.LightBlue;
                txtTest = " - TESTING AREA - ";
            }

            this.Text = txtTest + Application.ProductName + " - V " + Application.ProductVersion + txtTest;
        }

        /// <summary>
        /// Add a created form as an MDI child if the toString() value
        /// for the form doesn't already exist in the MDI Child forms.
        /// </summary>
        /// <param name="aForm">The form that could be added</param>
        public void AddMDIChildForm(Form aForm)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form.ToString().Equals(aForm.ToString()))
                {
                    this.ActivateMdiChild(form);
                    if (form.WindowState == FormWindowState.Minimized) form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }
            aForm.MdiParent = this;
            aForm.Show();
        }

        private DowntownBoiseAssociation.Controls.SearchItemType GetDBAType(string Type)
        {
            if (Type == "BUILDING") { return DowntownBoiseAssociation.Controls.SearchItemType.Building; }
            if (Type == "TENANT") { return DowntownBoiseAssociation.Controls.SearchItemType.Tenant; }
            if (Type == "LEGALENTITY") { return DowntownBoiseAssociation.Controls.SearchItemType.LegalEntity; }
            if (Type == "SPACE") { return DowntownBoiseAssociation.Controls.SearchItemType.Space; }
            if (Type == "GOVERNMENT") { return DowntownBoiseAssociation.Controls.SearchItemType.Government; }
            if (Type == "PARKING") { return DowntownBoiseAssociation.Controls.SearchItemType.Parking; }
            return DowntownBoiseAssociation.Controls.SearchItemType.Contact;
        }
        public void AddControlListItem(string FormType, string FormName, int FormId)
        {
            DowntownBoiseAssociation.Controls.DBA_ControlListItem NewItem = new DowntownBoiseAssociation.Controls.DBA_ControlListItem(
                   GetDBAType(FormType),
                   FormId,
                   FormName);
            NewItem.ControlSelectionClick += new Controls.ControlSelectionEventHandler(DBA_ControlListItem_ViewSelectionClick);
            panelForms.Controls.Add(NewItem);
        }

        public void RemoveControlListItem(string FormName)
        {
            foreach (DowntownBoiseAssociation.Controls.DBA_ControlListItem Item in panelForms.Controls)
            {
                if (Item.ToString() == FormName)
                {
                    Item.ControlSelectionClick -= new Controls.ControlSelectionEventHandler(DBA_ControlListItem_ViewSelectionClick);
                    panelForms.Controls.Remove(Item);

                    ClosePanel();
                }
            }   
        }

        private void DBA_ControlListItem_ViewSelectionClick(object sender)
        {
            foreach (var Item in this.MdiChildren)
            {               
                if (Item.Text == sender.ToString())
                {
                    Item.Focus();
                    ClosePanel();
                }
            }   
        }








        /// <summary>
        /// Add a Legal Entity to the list of Recent Legal Entities
        /// </summary>
        /// <param name="Name">The Legal Entity Name</param>
        /// <param name="Id">The Legal Entity Id</param>
        public void AddRecentLegalEntity(string Name, int Id)
        {
            AddEntityToStringCollection(Name, Id, Properties.Settings.Default.RecentLegalEntities);
        }

        /// <summary>
        /// Add a Tenant to the list of Recent Tenants
        /// </summary>
        /// <param name="Name">The Tennant Name</param>
        /// <param name="Id">The Tenant Id</param>
        public void AddRecentTenant(string Name, int Id)
        {
            AddEntityToStringCollection(Name, Id, Properties.Settings.Default.RecentTenants);
        }

        private void AddEntityToStringCollection(string name, int id, StringCollection collection)
        {
            const int RECENT_LIST_SIZE = 5;
            string str = string.Format("{0},{1}", name, id);
            int idx = collection.IndexOf(str);
            if (idx >= 0) collection.RemoveAt(idx);
            collection.Insert(0, str);
            if (collection.Count > RECENT_LIST_SIZE) collection.RemoveAt(RECENT_LIST_SIZE);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogTenantAdd NewTenant = new dialogTenantAdd();
            NewTenant.Tag = this;
            NewTenant.ShowDialog();
        }

        private void zoneMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminZone zoneAdmin = new frmAdminZone();
            AddMDIChildForm(zoneAdmin);
        }

        private void arrangeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLookUps NewListForm = new frmAdminLookUps();
            AddMDIChildForm(NewListForm);
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainRates NewListForm = new frmMaintainRates();
            AddMDIChildForm(NewListForm);
        }

        private void tenantCategoriesAndClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkCats2Class NewListForm = new frmLinkCats2Class();
            AddMDIChildForm(NewListForm);
        }

        private void imagePointMainenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUtilityImageMaintain NewForm = new frmUtilityImageMaintain();
            AddMDIChildForm(NewForm);
        }

        private void blocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlock NewForm = new frmBlock(0);
            AddMDIChildForm(NewForm);
        }

        private void tsmiTennantList_Click(object sender, EventArgs e)
        {
            frmAttributeViewer NewForm = new frmAttributeViewer();
            AddMDIChildForm(NewForm);
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form NewForm = this;
            dialogSearch NewSearch = new dialogSearch("", NewForm, true, "");
            NewSearch.ShowDialog();
        }

        private void toolStriptxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                if (toolStriptxtSearch.Text.Trim() == "")
                {
                    MessageBox.Show("Search criteria is empty");
                    return;
                }
                dialogSearch NewSearch = new dialogSearch(toolStriptxtSearch.Text, ThisForm, true, "");
                NewSearch.ShowDialog();
            }
        }

        private void frmDBAContainer_Load_1(object sender, EventArgs e)
        {
            ThisForm = this;
            toolStriptxtSearch.Focus();
            LoadReportsMenu(_RegReportPrefix);
            LoadReportsMenu(_ARReportPrefix);          
        }

        private void frmDBAContainer_Shown(object sender, EventArgs e)
        {
            (this.Tag as Splash).Hide();
            toolStriptxtSearch.Focus();
        }

        private void relationshipViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelationshipViewer NewForm = new frmRelationshipViewer(this);
            AddMDIChildForm(NewForm);
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttributeMaster newForm = new frmAttributeMaster();
            AddMDIChildForm(newForm);
        }

        private void performBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerformBilling newform = new frmPerformBilling();
            AddMDIChildForm(newform);
        }

        private void blockContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBlockPersonsContactingInfo newForm = new reportBlockPersonsContactingInfo();
            AddMDIChildForm(newForm);
        }
        private void tenantByOpenOrClosedDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenantByDateRange newForm = new frmTenantByDateRange();
            AddMDIChildForm(newForm);
        }

        private void buildingsByBlcokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuildingsByBlock newForm = new frmBuildingsByBlock();
            AddMDIChildForm(newForm);
        }

        private void createInvoiceBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceBatch newForm = new frmInvoiceBatch();
            newForm.ShowDialog();
        }

        private void LoadReportsMenu(string ReportPrefix)
        {
            //ReportingService2005 rs = new ReportingService2005();
            ////rs.Credentials = System.Net.CredentialCache.DefaultCredentials;            
            //rs.Credentials = new System.Net.NetworkCredential(_ReportUserName, _ReportUserPassword, _ReportUserDomain);

            //CatalogItem[] Items = null;

            //SearchCondition RSSearch = new SearchCondition();
            //RSSearch.Condition = ConditionEnum.Contains;
            //RSSearch.ConditionSpecified = true;
            //RSSearch.Name = "Name";
            //RSSearch.Value = _RegReportPrefix;

            //SearchCondition[] RSSearches = new SearchCondition[1];
            //RSSearches[0] = RSSearch;

            //Items = rs.FindItems(_ReportPath, BooleanOperatorEnum.Or, RSSearches);

            ToolStripMenuItem ReportMenu = reportsToolStripMenuItem;

            //ToolStripSeparator NewBar1 = new ToolStripSeparator();
            //ReportMenu.DropDownItems.Add(NewBar1);

            //foreach (CatalogItem Item in Items)
            //{
            //    string DisplayName = Item.Name.Remove(0, _RegReportPrefix.Length).Trim().Replace("_", " ").Trim();
            //    ToolStripMenuItem NewMenu = new ToolStripMenuItem(DisplayName, null, ReportsMenu_Click, Item.Name);
            //    ReportMenu.DropDownItems.Add(NewMenu);
            //}


            //return;
            ToolStripSeparator NewBar2 = new ToolStripSeparator();
            ReportMenu.DropDownItems.Add(NewBar2);
            ReportsDataClassesDataContext rDB = new ReportsDataClassesDataContext();

            var RegReports = from a in rDB.Catalogs
                             where a.Type == 2 &&
                             a.Name.StartsWith(ReportPrefix) &&
                             a.Path.StartsWith(_ReportPath)
                             select a;

            if (RegReports.Count() == 0) return;

            foreach (var Item in RegReports)
            {
                string DisplayName = Item.Name.Remove(0, ReportPrefix.Length).Trim().Replace("_", " ").Trim();
                ToolStripMenuItem NewMenu = new ToolStripMenuItem(DisplayName, null, ReportsMenu_Click, Item.Name);
                ReportMenu.DropDownItems.Add(NewMenu);
            }

        }

       

        private void ReportsMenu_Click(object sender, EventArgs e)
        {
            ToolStripItem ReportMenu = (ToolStripItem)sender;

            report_Main NewReport = new report_Main(_ReportServer, _ReportPath, ReportMenu.Name, ReportMenu.Text);
            NewReport.MdiParent = this;
            NewReport.Show();
        }

       
        private void endOfMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBADataContext dc = new DBADataContext();
            DateTime actDate = dc.fn_GetAccountingPeriod().Value;
            DateTime closeDate = actDate.AddMonths(1);
            //MessageBox.Show(actDate.ToShortDateString());
            if (DateTime.Today < closeDate)
            {
                string text = string.Format("Accounting periods may only be closed when the actual time period has elapsed. \nClose this accounting period after {0}.", closeDate.ToString("MMMM dd, yyyy"));
                string message = string.Format("Unable to close {0}", actDate.ToString("MMMM yyyy"));
                MessageBox.Show(this, text, message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string text = string.Format("Make sure that all transactions to be posted in {0} have been entered.\nPress 'OK' to confirm this irreversable action.", actDate.ToString("MMMM yyyy"));
                string message = string.Format("Close {0}", actDate.ToString("MMMM yyyy"));
                if (MessageBox.Show(this, text, message, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dc.CloseAccountingPeriod();
                }
            }
        }

        private void mailingLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportMailingLabels newForm = new reportMailingLabels();
            AddMDIChildForm(newForm);
        }

        private void frmDBAContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            (this.Tag as Splash).Close();
        }

        private void PopulateRecentItemMenu(ToolStripMenuItem menu, StringCollection collection, EventHandler handler)
        {
            char[] delimiters = new char[] { ',' };
            menu.DropDownItems.Clear();
            foreach (var item in collection)
            {
                string[] values = item.Split(delimiters);
                ToolStripMenuItem tmpMnu = new ToolStripMenuItem(values.First());
                tmpMnu.Click += new EventHandler(handler);
                tmpMnu.Tag = int.Parse(values.Last());
                menu.DropDownItems.Add(tmpMnu);
            }
        }

        private void recentLegalEntitiesMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = sender as ToolStripMenuItem;
            PopulateRecentItemMenu(mnu, Properties.Settings.Default.RecentLegalEntities, LegalEntityMenu_click);
        }

        void LegalEntityMenu_click(object sender, EventArgs e)
        {
            int LegalEntityId = (int)(sender as ToolStripMenuItem).Tag;
            string EntityName = (sender as ToolStripMenuItem).Text;
            DBADataContext dc = new DBADataContext();
            var legalEntity = (from le in dc.LegalEntities
                              where (le.Id.Equals(LegalEntityId) || le.Name.Equals(EntityName))
                              select le.Id).FirstOrDefault();
            if (legalEntity != null)
            {
                frmLegalEntity tmpForm = new frmLegalEntity(legalEntity, false);
                AddMDIChildForm(tmpForm);
            }
            else
            {
                (sender as ToolStripMenuItem).Enabled = false;
            }
        }

        private void recentTennantsMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = sender as ToolStripMenuItem;
            PopulateRecentItemMenu(mnu, Properties.Settings.Default.RecentTenants, TenantEntityMenu_click);
        }

        void TenantEntityMenu_click(object sender, EventArgs e)
        {
            int TenantId = (int)(sender as ToolStripMenuItem).Tag;
            string TenantName = (sender as ToolStripMenuItem).Text;
            DBADataContext dc = new DBADataContext();
            var ten = (from t in dc.Tenants
                       where (t.Id.Equals(TenantId) || t.LegalEntity.Name.Equals(TenantName))
                       select t.Id).FirstOrDefault();
            if (ten != null)
            {
                frmTenant tmpForm = new frmTenant(ten);
                AddMDIChildForm(tmpForm);
            }
            else
            {
                (sender as ToolStripMenuItem).Enabled = false;
            }
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            recentLegalEntitiesMenuItem.Enabled = (Properties.Settings.Default.RecentLegalEntities.Count > 0);
            recentLegalEntitiesMenuItem.DropDownItems.Add("placeholder");
            recentTennantsMenuItem.Enabled = (Properties.Settings.Default.RecentTenants.Count > 0);
            recentTennantsMenuItem.DropDownItems.Add("placeholder");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void newLegalEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLegalEntity NewForm = new frmLegalEntity(0, true);
                NewForm.ShowDialog();
            }
            catch { }
        }

        private void connectionStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                

                MessageBox.Show("Server: " + _ConnServer + "\r\n" +
                    "Database: " + _ConnDatabase + "\r\n" +
                    "Report Server: " + _ReportServer + "\r\n" +
                    "Report Path: " + _ReportPath,
                    "Connection Information" 
                    );
            }
            catch
            {
                MessageBox.Show("No valid connection string.");
            }
        }

        private static string GetConnectionStringItem(string[] ConnectionArray, string ReturnItem)
        {
            string[] ItemArray;

            foreach (string Item in ConnectionArray)
            {
                ItemArray = Item.Split(Convert.ToChar("="));
                if (ItemArray[0].Trim().ToUpper() == ReturnItem.Trim().ToUpper()) return ItemArray[1];
            }

            return "";
        }

        private void newZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZoneMaint NewZone = new frmZoneMaint(0);
            
            AddMDIChildForm(NewZone);            
        }

        private void newBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlockAdd NewBlock = new frmBlockAdd();
            NewBlock.Tag = this;
            NewBlock.ShowDialog();
        }

        private void newBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuildingAdd NewBuilding = new frmBuildingAdd();
            NewBuilding.Tag = this;
            NewBuilding.ShowDialog();
        }

        private void frmDBAContainer_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void mapAndDirectoryCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Comma Dilimited |*.csv";
            saveFileDialog1.Title = "Save CSV to File";
            saveFileDialog1.SupportMultiDottedExtensions = false;
            saveFileDialog1.AddExtension = true;

            System.IO.StreamWriter sw = null; 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                try
                {
                    sw = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                    sw.AutoFlush = true;

                    DBA.DataClassesSmallDataContext sdb = new DBA.DataClassesSmallDataContext();

                    var MandDList = from a in sdb.vw_MapAndDirectory_CSVs
                                    select a;

                    foreach (var MandDItem in MandDList)
                    {
                        sw.WriteLine(MandDItem.CSVFile);
                    }
                }
                catch (Exception ex)
                {
                    sw.Close();
                }

                sw.Close();
            }
            else
            {
            }

            
        }

        private void lateFeeProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLateFeeProcessingDialog newform = new frmLateFeeProcessingDialog();
            newform.Tag = this;
            AddMDIChildForm(newform);
        }

        private void changeMisappliedPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogMisappliedPayment newform = new dialogMisappliedPayment();
            newform.ShowDialog();
        }

        private void panelForms_MouseEnter(object sender, EventArgs e)
        {
            OpenPanel();
        }

        private void SlideIn_Tick(object sender, EventArgs e)
        {
            ClosePanel();
        }

        public void OpenPanel()
        {
            if (panelForms.Controls.Count == 0) return;
            panelForms.Width = 300;
            SlideIn.Enabled = true;
        }

        public void ClosePanel()
        {
            panelForms.Width = 30;
            SlideIn.Enabled = false;
        }

        private bool mEntered;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point pos = this.panelForms.PointToClient(Cursor.Position);
            bool entered = this.panelForms.ClientRectangle.Contains(pos);
            if (entered != mEntered)
            {
                mEntered = entered;
                if (!entered)
                {
                    this.panelForms.Width = 30;
                }
            }
        }

        private void contactMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogSearchContact NewContact = new dialogSearchContact();
            NewContact.ShowDialog();
        }
 

     
    }

}

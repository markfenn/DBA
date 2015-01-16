namespace DowntownBoiseAssociation
{
    partial class frmDBAContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBAContainer));
            this.tsSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLegalEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.newBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentTennantsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentLegalEntitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.performBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endOfMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateFeeProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.changeMisappliedPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTennantList = new System.Windows.Forms.ToolStripMenuItem();
            this.relationshipViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePointMainenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantCategoriesAndClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.arrangeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsByBlcokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailingLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapAndDirectoryCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForms = new System.Windows.Forms.FlowLayoutPanel();
            this.SlideOut = new System.Windows.Forms.Timer(this.components);
            this.SlideIn = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manageContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSearch
            // 
            this.tsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStriptxtSearch});
            this.tsSearch.Location = new System.Drawing.Point(0, 24);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(984, 25);
            this.tsSearch.TabIndex = 0;
            this.tsSearch.Text = "Search";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Search";
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(200, 25);
            this.toolStriptxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStriptxtSearch_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newLegalEntityToolStripMenuItem,
            this.toolStripSeparator4,
            this.newBuildingToolStripMenuItem,
            this.newBlockToolStripMenuItem,
            this.newZoneToolStripMenuItem,
            this.toolStripSeparator1,
            this.recentTennantsMenuItem,
            this.recentLegalEntitiesMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newToolStripMenuItem.Text = "New &Tenant";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newLegalEntityToolStripMenuItem
            // 
            this.newLegalEntityToolStripMenuItem.Name = "newLegalEntityToolStripMenuItem";
            this.newLegalEntityToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newLegalEntityToolStripMenuItem.Text = "New &Legal Entity";
            this.newLegalEntityToolStripMenuItem.Click += new System.EventHandler(this.newLegalEntityToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // newBuildingToolStripMenuItem
            // 
            this.newBuildingToolStripMenuItem.Name = "newBuildingToolStripMenuItem";
            this.newBuildingToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newBuildingToolStripMenuItem.Text = "New Building";
            this.newBuildingToolStripMenuItem.Click += new System.EventHandler(this.newBuildingToolStripMenuItem_Click);
            // 
            // newBlockToolStripMenuItem
            // 
            this.newBlockToolStripMenuItem.Name = "newBlockToolStripMenuItem";
            this.newBlockToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newBlockToolStripMenuItem.Text = "New Block";
            this.newBlockToolStripMenuItem.Click += new System.EventHandler(this.newBlockToolStripMenuItem_Click);
            // 
            // newZoneToolStripMenuItem
            // 
            this.newZoneToolStripMenuItem.Name = "newZoneToolStripMenuItem";
            this.newZoneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newZoneToolStripMenuItem.Text = "New Zone";
            this.newZoneToolStripMenuItem.Click += new System.EventHandler(this.newZoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // recentTennantsMenuItem
            // 
            this.recentTennantsMenuItem.Name = "recentTennantsMenuItem";
            this.recentTennantsMenuItem.Size = new System.Drawing.Size(182, 22);
            this.recentTennantsMenuItem.Text = "Recent Tenants";
            this.recentTennantsMenuItem.DropDownOpening += new System.EventHandler(this.recentTennantsMenuItem_DropDownOpening);
            // 
            // recentLegalEntitiesMenuItem
            // 
            this.recentLegalEntitiesMenuItem.Name = "recentLegalEntitiesMenuItem";
            this.recentLegalEntitiesMenuItem.Size = new System.Drawing.Size(182, 22);
            this.recentLegalEntitiesMenuItem.Text = "Recent Legal Entities";
            this.recentLegalEntitiesMenuItem.DropDownOpening += new System.EventHandler(this.recentLegalEntitiesMenuItem_DropDownOpening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performBillingToolStripMenuItem,
            this.createInvoiceBatchToolStripMenuItem,
            this.endOfMonthToolStripMenuItem,
            this.lateFeeProcessingToolStripMenuItem,
            this.toolStripSeparator6,
            this.changeMisappliedPaymentToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "&Accounting";
            // 
            // performBillingToolStripMenuItem
            // 
            this.performBillingToolStripMenuItem.Name = "performBillingToolStripMenuItem";
            this.performBillingToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.performBillingToolStripMenuItem.Text = "Perform &Billing";
            this.performBillingToolStripMenuItem.Click += new System.EventHandler(this.performBillingToolStripMenuItem_Click);
            // 
            // createInvoiceBatchToolStripMenuItem
            // 
            this.createInvoiceBatchToolStripMenuItem.Name = "createInvoiceBatchToolStripMenuItem";
            this.createInvoiceBatchToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.createInvoiceBatchToolStripMenuItem.Text = "Create &Invoice Batch";
            this.createInvoiceBatchToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceBatchToolStripMenuItem_Click);
            // 
            // endOfMonthToolStripMenuItem
            // 
            this.endOfMonthToolStripMenuItem.Name = "endOfMonthToolStripMenuItem";
            this.endOfMonthToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.endOfMonthToolStripMenuItem.Text = "Close &Accounting Period";
            this.endOfMonthToolStripMenuItem.Click += new System.EventHandler(this.endOfMonthToolStripMenuItem_Click);
            // 
            // lateFeeProcessingToolStripMenuItem
            // 
            this.lateFeeProcessingToolStripMenuItem.Name = "lateFeeProcessingToolStripMenuItem";
            this.lateFeeProcessingToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.lateFeeProcessingToolStripMenuItem.Text = "Late Fee Processing";
            this.lateFeeProcessingToolStripMenuItem.Click += new System.EventHandler(this.lateFeeProcessingToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(223, 6);
            // 
            // changeMisappliedPaymentToolStripMenuItem
            // 
            this.changeMisappliedPaymentToolStripMenuItem.Name = "changeMisappliedPaymentToolStripMenuItem";
            this.changeMisappliedPaymentToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.changeMisappliedPaymentToolStripMenuItem.Text = "Change Misapplied Payment";
            this.changeMisappliedPaymentToolStripMenuItem.Click += new System.EventHandler(this.changeMisappliedPaymentToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageContactsToolStripMenuItem,
            this.tsmiTennantList,
            this.relationshipViewerToolStripMenuItem,
            this.zoneMaintenanceToolStripMenuItem,
            this.toolStripSeparator5,
            this.arrangeWindowsToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // tsmiTennantList
            // 
            this.tsmiTennantList.Name = "tsmiTennantList";
            this.tsmiTennantList.Size = new System.Drawing.Size(177, 22);
            this.tsmiTennantList.Text = "Attribute Viewer";
            this.tsmiTennantList.Visible = false;
            this.tsmiTennantList.Click += new System.EventHandler(this.tsmiTennantList_Click);
            // 
            // relationshipViewerToolStripMenuItem
            // 
            this.relationshipViewerToolStripMenuItem.Name = "relationshipViewerToolStripMenuItem";
            this.relationshipViewerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.relationshipViewerToolStripMenuItem.Text = "Relationship Viewer";
            this.relationshipViewerToolStripMenuItem.Click += new System.EventHandler(this.relationshipViewerToolStripMenuItem_Click);
            // 
            // zoneMaintenanceToolStripMenuItem
            // 
            this.zoneMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactMaintenanceToolStripMenuItem,
            this.attributesToolStripMenuItem,
            this.imagePointMainenanceToolStripMenuItem,
            this.tenantCategoriesAndClassesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.ratesToolStripMenuItem,
            this.zoneToolStripMenuItem,
            this.connectionStringToolStripMenuItem});
            this.zoneMaintenanceToolStripMenuItem.Name = "zoneMaintenanceToolStripMenuItem";
            this.zoneMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.zoneMaintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // contactMaintenanceToolStripMenuItem
            // 
            this.contactMaintenanceToolStripMenuItem.Name = "contactMaintenanceToolStripMenuItem";
            this.contactMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.contactMaintenanceToolStripMenuItem.Text = "Contact Maintenance";
            this.contactMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.contactMaintenanceToolStripMenuItem_Click);
            // 
            // attributesToolStripMenuItem
            // 
            this.attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            this.attributesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.attributesToolStripMenuItem.Text = "Attributes";
            this.attributesToolStripMenuItem.Click += new System.EventHandler(this.attributesToolStripMenuItem_Click);
            // 
            // imagePointMainenanceToolStripMenuItem
            // 
            this.imagePointMainenanceToolStripMenuItem.Name = "imagePointMainenanceToolStripMenuItem";
            this.imagePointMainenanceToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.imagePointMainenanceToolStripMenuItem.Text = "Image Point Mainenance";
            this.imagePointMainenanceToolStripMenuItem.Click += new System.EventHandler(this.imagePointMainenanceToolStripMenuItem_Click);
            // 
            // tenantCategoriesAndClassesToolStripMenuItem
            // 
            this.tenantCategoriesAndClassesToolStripMenuItem.Name = "tenantCategoriesAndClassesToolStripMenuItem";
            this.tenantCategoriesAndClassesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.tenantCategoriesAndClassesToolStripMenuItem.Text = "Link Tenant Categories To Classes";
            this.tenantCategoriesAndClassesToolStripMenuItem.Click += new System.EventHandler(this.tenantCategoriesAndClassesToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.categoriesToolStripMenuItem.Text = "Lookup Lists";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ratesToolStripMenuItem.Text = "Rates Master";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.zoneToolStripMenuItem.Text = "Zone";
            this.zoneToolStripMenuItem.Click += new System.EventHandler(this.zoneMaintenanceToolStripMenuItem_Click);
            // 
            // connectionStringToolStripMenuItem
            // 
            this.connectionStringToolStripMenuItem.Name = "connectionStringToolStripMenuItem";
            this.connectionStringToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.connectionStringToolStripMenuItem.Text = "Connection Information";
            this.connectionStringToolStripMenuItem.Click += new System.EventHandler(this.connectionStringToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
            // 
            // arrangeWindowsToolStripMenuItem
            // 
            this.arrangeWindowsToolStripMenuItem.Name = "arrangeWindowsToolStripMenuItem";
            this.arrangeWindowsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.arrangeWindowsToolStripMenuItem.Text = "Arrange Windows";
            this.arrangeWindowsToolStripMenuItem.Click += new System.EventHandler(this.arrangeWindowsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocksToolStripMenuItem,
            this.buildingsByBlcokToolStripMenuItem,
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // blocksToolStripMenuItem
            // 
            this.blocksToolStripMenuItem.Name = "blocksToolStripMenuItem";
            this.blocksToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.blocksToolStripMenuItem.Text = "Blocks";
            this.blocksToolStripMenuItem.Click += new System.EventHandler(this.blocksToolStripMenuItem_Click);
            // 
            // buildingsByBlcokToolStripMenuItem
            // 
            this.buildingsByBlcokToolStripMenuItem.Name = "buildingsByBlcokToolStripMenuItem";
            this.buildingsByBlcokToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.buildingsByBlcokToolStripMenuItem.Text = "Buildings by Block";
            this.buildingsByBlcokToolStripMenuItem.Click += new System.EventHandler(this.buildingsByBlcokToolStripMenuItem_Click);
            // 
            // tenantByOpenOrClosedDateRangeToolStripMenuItem
            // 
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem.Name = "tenantByOpenOrClosedDateRangeToolStripMenuItem";
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem.Text = "Tenant by Open or Closed Date Range";
            this.tenantByOpenOrClosedDateRangeToolStripMenuItem.Click += new System.EventHandler(this.tenantByOpenOrClosedDateRangeToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockContactsToolStripMenuItem,
            this.mailingLabelsToolStripMenuItem,
            this.mapAndDirectoryCSVToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // blockContactsToolStripMenuItem
            // 
            this.blockContactsToolStripMenuItem.Name = "blockContactsToolStripMenuItem";
            this.blockContactsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.blockContactsToolStripMenuItem.Text = "Block Contacts";
            this.blockContactsToolStripMenuItem.Click += new System.EventHandler(this.blockContactsToolStripMenuItem_Click);
            // 
            // mailingLabelsToolStripMenuItem
            // 
            this.mailingLabelsToolStripMenuItem.Name = "mailingLabelsToolStripMenuItem";
            this.mailingLabelsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mailingLabelsToolStripMenuItem.Text = "Mailing Labels";
            this.mailingLabelsToolStripMenuItem.Click += new System.EventHandler(this.mailingLabelsToolStripMenuItem_Click);
            // 
            // mapAndDirectoryCSVToolStripMenuItem
            // 
            this.mapAndDirectoryCSVToolStripMenuItem.Name = "mapAndDirectoryCSVToolStripMenuItem";
            this.mapAndDirectoryCSVToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mapAndDirectoryCSVToolStripMenuItem.Text = "Map and Directory - CSV";
            this.mapAndDirectoryCSVToolStripMenuItem.Click += new System.EventHandler(this.mapAndDirectoryCSVToolStripMenuItem_Click);
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForms.Location = new System.Drawing.Point(0, 49);
            this.panelForms.Name = "panelForms";
            this.panelForms.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelForms.Size = new System.Drawing.Size(30, 713);
            this.panelForms.TabIndex = 3;
            this.panelForms.MouseEnter += new System.EventHandler(this.panelForms_MouseEnter);
            // 
            // SlideOut
            // 
            this.SlideOut.Interval = 1;
            // 
            // SlideIn
            // 
            this.SlideIn.Interval = 5000;
            this.SlideIn.Tick += new System.EventHandler(this.SlideIn_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // manageContactsToolStripMenuItem
            // 
            this.manageContactsToolStripMenuItem.Name = "manageContactsToolStripMenuItem";
            this.manageContactsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.manageContactsToolStripMenuItem.Text = "Manage Contacts";
            this.manageContactsToolStripMenuItem.Click += new System.EventHandler(this.manageContactsToolStripMenuItem_Click);
            // 
            // frmDBAContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.gradContainer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.tsSearch);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmDBAContainer";
            this.Text = "Downtown Boise Association";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDBAContainer_FormClosed);
            this.Load += new System.EventHandler(this.frmDBAContainer_Load_1);
            this.Shown += new System.EventHandler(this.frmDBAContainer_Shown);
            this.Resize += new System.EventHandler(this.frmDBAContainer_Resize);
            this.tsSearch.ResumeLayout(false);
            this.tsSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLegalEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentTennantsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTennantList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem recentLegalEntitiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenantCategoriesAndClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagePointMainenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationshipViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem performBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenantByOpenOrClosedDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsByBlcokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endOfMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailingLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem newBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapAndDirectoryCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lateFeeProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem changeMisappliedPaymentToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelForms;
        private System.Windows.Forms.Timer SlideOut;
        private System.Windows.Forms.Timer SlideIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem contactMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageContactsToolStripMenuItem;
    }
}


namespace DowntownBoiseAssociation
{
    partial class frmBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuilding));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.lblParcelNumber = new System.Windows.Forms.Label();
            this.txtNumberOfFloors = new System.Windows.Forms.TextBox();
            this.lblNumberOfFloors = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblYearRenovated = new System.Windows.Forms.Label();
            this.txtYearRenovated = new System.Windows.Forms.TextBox();
            this.txtTotalSqFt = new System.Windows.Forms.TextBox();
            this.lblTotalSqFt = new System.Windows.Forms.Label();
            this.lblAverageRent = new System.Windows.Forms.Label();
            this.txtAverageRent = new System.Windows.Forms.TextBox();
            this.lblRentableSqFt = new System.Windows.Forms.Label();
            this.txtRentableSqrFt = new System.Windows.Forms.TextBox();
            this.lblUnbillableSqFt = new System.Windows.Forms.Label();
            this.txtUnbillableSqFt = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.SpaceName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TenantName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SpaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCounty = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yRBLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCCUPANCYDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEASABLESQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRFLSQFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALSQFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupCommercialParcelInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.txtAppInfo = new System.Windows.Forms.TextBox();
            this.txtParcelNumber = new System.Windows.Forms.TextBox();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.btnCreateSpace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.LinkLabel();
            this.vwParcelNumberLookUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkAddress = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vwTenantListingbyBuildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkBuildingBillingLE = new System.Windows.Forms.LinkLabel();
            this.editProperties1 = new DowntownBoiseAssociation.Controls.editProperties();
            this.CommentDisplayBuilding = new DowntownBoiseAssociation.Controls.DBA_CommentDisplay();
            this.ContactDisplayBuilding = new DowntownBoiseAssociation.Controls.DBA_ContactDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.tabCounty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCommercialParcelInfoBindingSource)).BeginInit();
            this.tabProperties.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwParcelNumberLookUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 0);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(605, 12);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "&Save";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(605, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "Name", true));
            this.txtBuildingName.Location = new System.Drawing.Point(109, 15);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuildingName.Size = new System.Drawing.Size(481, 20);
            this.txtBuildingName.TabIndex = 4;
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(DowntownBoiseAssociation.Building);
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildingName.Location = new System.Drawing.Point(13, 18);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(78, 13);
            this.lblBuildingName.TabIndex = 5;
            this.lblBuildingName.Text = "Building Name:";
            // 
            // lblParcelNumber
            // 
            this.lblParcelNumber.AutoSize = true;
            this.lblParcelNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblParcelNumber.Location = new System.Drawing.Point(13, 40);
            this.lblParcelNumber.Name = "lblParcelNumber";
            this.lblParcelNumber.Size = new System.Drawing.Size(80, 13);
            this.lblParcelNumber.TabIndex = 7;
            this.lblParcelNumber.Text = "Parcel Number:";
            // 
            // txtNumberOfFloors
            // 
            this.txtNumberOfFloors.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "Floors", true));
            this.txtNumberOfFloors.Location = new System.Drawing.Point(490, 37);
            this.txtNumberOfFloors.Name = "txtNumberOfFloors";
            this.txtNumberOfFloors.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfFloors.TabIndex = 8;
            // 
            // lblNumberOfFloors
            // 
            this.lblNumberOfFloors.AutoSize = true;
            this.lblNumberOfFloors.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfFloors.Location = new System.Drawing.Point(394, 40);
            this.lblNumberOfFloors.Name = "lblNumberOfFloors";
            this.lblNumberOfFloors.Size = new System.Drawing.Size(87, 13);
            this.lblNumberOfFloors.TabIndex = 9;
            this.lblNumberOfFloors.Text = "Number of Floors";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "YearBuilt", true));
            this.textBox1.Location = new System.Drawing.Point(281, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.BackColor = System.Drawing.Color.Transparent;
            this.lblYearBuilt.Location = new System.Drawing.Point(220, 65);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(52, 13);
            this.lblYearBuilt.TabIndex = 11;
            this.lblYearBuilt.Text = "Year Built";
            // 
            // lblYearRenovated
            // 
            this.lblYearRenovated.AutoSize = true;
            this.lblYearRenovated.BackColor = System.Drawing.Color.Transparent;
            this.lblYearRenovated.Location = new System.Drawing.Point(394, 62);
            this.lblYearRenovated.Name = "lblYearRenovated";
            this.lblYearRenovated.Size = new System.Drawing.Size(85, 13);
            this.lblYearRenovated.TabIndex = 12;
            this.lblYearRenovated.Text = "Year Renovated";
            // 
            // txtYearRenovated
            // 
            this.txtYearRenovated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "YearRenovated", true));
            this.txtYearRenovated.Location = new System.Drawing.Point(490, 59);
            this.txtYearRenovated.Name = "txtYearRenovated";
            this.txtYearRenovated.Size = new System.Drawing.Size(100, 20);
            this.txtYearRenovated.TabIndex = 13;
            // 
            // txtTotalSqFt
            // 
            this.txtTotalSqFt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "TotalSqFt", true));
            this.txtTotalSqFt.Location = new System.Drawing.Point(281, 81);
            this.txtTotalSqFt.Name = "txtTotalSqFt";
            this.txtTotalSqFt.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSqFt.TabIndex = 19;
            // 
            // lblTotalSqFt
            // 
            this.lblTotalSqFt.AutoSize = true;
            this.lblTotalSqFt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSqFt.Location = new System.Drawing.Point(220, 84);
            this.lblTotalSqFt.Name = "lblTotalSqFt";
            this.lblTotalSqFt.Size = new System.Drawing.Size(56, 13);
            this.lblTotalSqFt.TabIndex = 18;
            this.lblTotalSqFt.Text = "Total SqFt";
            // 
            // lblAverageRent
            // 
            this.lblAverageRent.AutoSize = true;
            this.lblAverageRent.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageRent.Location = new System.Drawing.Point(13, 62);
            this.lblAverageRent.Name = "lblAverageRent";
            this.lblAverageRent.Size = new System.Drawing.Size(67, 13);
            this.lblAverageRent.TabIndex = 17;
            this.lblAverageRent.Text = "Averge Rent";
            // 
            // txtAverageRent
            // 
            this.txtAverageRent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "AverageRent", true));
            this.txtAverageRent.Location = new System.Drawing.Point(109, 59);
            this.txtAverageRent.Name = "txtAverageRent";
            this.txtAverageRent.Size = new System.Drawing.Size(100, 20);
            this.txtAverageRent.TabIndex = 16;
            // 
            // lblRentableSqFt
            // 
            this.lblRentableSqFt.AutoSize = true;
            this.lblRentableSqFt.BackColor = System.Drawing.Color.Transparent;
            this.lblRentableSqFt.Location = new System.Drawing.Point(13, 84);
            this.lblRentableSqFt.Name = "lblRentableSqFt";
            this.lblRentableSqFt.Size = new System.Drawing.Size(75, 13);
            this.lblRentableSqFt.TabIndex = 15;
            this.lblRentableSqFt.Text = "Rentable SqFt";
            // 
            // txtRentableSqrFt
            // 
            this.txtRentableSqrFt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "RentableSqFt", true));
            this.txtRentableSqrFt.Location = new System.Drawing.Point(109, 81);
            this.txtRentableSqrFt.Name = "txtRentableSqrFt";
            this.txtRentableSqrFt.Size = new System.Drawing.Size(100, 20);
            this.txtRentableSqrFt.TabIndex = 14;
            // 
            // lblUnbillableSqFt
            // 
            this.lblUnbillableSqFt.AutoSize = true;
            this.lblUnbillableSqFt.BackColor = System.Drawing.Color.Transparent;
            this.lblUnbillableSqFt.Location = new System.Drawing.Point(560, 91);
            this.lblUnbillableSqFt.Name = "lblUnbillableSqFt";
            this.lblUnbillableSqFt.Size = new System.Drawing.Size(78, 13);
            this.lblUnbillableSqFt.TabIndex = 21;
            this.lblUnbillableSqFt.Text = "Unbillable SqFt";
            this.lblUnbillableSqFt.Visible = false;
            // 
            // txtUnbillableSqFt
            // 
            this.txtUnbillableSqFt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "UnbillableSqFt", true));
            this.txtUnbillableSqFt.Location = new System.Drawing.Point(563, 82);
            this.txtUnbillableSqFt.Name = "txtUnbillableSqFt";
            this.txtUnbillableSqFt.Size = new System.Drawing.Size(27, 20);
            this.txtUnbillableSqFt.TabIndex = 20;
            this.txtUnbillableSqFt.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabCounty);
            this.TabControl.Controls.Add(this.tabProperties);
            this.TabControl.Controls.Add(this.tabNotes);
            this.TabControl.Controls.Add(this.tabContacts);
            this.TabControl.Controls.Add(this.tabInfo);
            this.TabControl.Location = new System.Drawing.Point(12, 185);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(723, 343);
            this.TabControl.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdTenants);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Space and Tenant Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdTenants
            // 
            this.grdTenants.AllowUserToAddRows = false;
            this.grdTenants.AllowUserToDeleteRows = false;
            this.grdTenants.AllowUserToOrderColumns = true;
            this.grdTenants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpaceName,
            this.TenantName,
            this.SpaceId,
            this.TenantId});
            this.grdTenants.Location = new System.Drawing.Point(3, 6);
            this.grdTenants.MultiSelect = false;
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.ReadOnly = true;
            this.grdTenants.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdTenants.Size = new System.Drawing.Size(709, 308);
            this.grdTenants.TabIndex = 23;
            this.grdTenants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellContentClick);
            this.grdTenants.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdTenants_RowPrePaint);
            // 
            // SpaceName
            // 
            this.SpaceName.DataPropertyName = "SpaceName";
            this.SpaceName.HeaderText = "Space Name";
            this.SpaceName.Name = "SpaceName";
            this.SpaceName.ReadOnly = true;
            this.SpaceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SpaceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SpaceName.Width = 300;
            // 
            // TenantName
            // 
            this.TenantName.DataPropertyName = "TenantName";
            this.TenantName.HeaderText = "Tenant Name";
            this.TenantName.Name = "TenantName";
            this.TenantName.ReadOnly = true;
            this.TenantName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenantName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenantName.Width = 300;
            // 
            // SpaceId
            // 
            this.SpaceId.DataPropertyName = "SpaceId";
            this.SpaceId.HeaderText = "SpaceId";
            this.SpaceId.Name = "SpaceId";
            this.SpaceId.ReadOnly = true;
            this.SpaceId.Visible = false;
            // 
            // TenantId
            // 
            this.TenantId.DataPropertyName = "TenantId";
            this.TenantId.HeaderText = "TenantId";
            this.TenantId.Name = "TenantId";
            this.TenantId.ReadOnly = true;
            this.TenantId.Visible = false;
            // 
            // tabCounty
            // 
            this.tabCounty.Controls.Add(this.dataGridView1);
            this.tabCounty.Location = new System.Drawing.Point(4, 22);
            this.tabCounty.Name = "tabCounty";
            this.tabCounty.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounty.Size = new System.Drawing.Size(715, 317);
            this.tabCounty.TabIndex = 3;
            this.tabCounty.Text = "County Information";
            this.tabCounty.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yRBLTDataGridViewTextBoxColumn,
            this.rEMYEARDataGridViewTextBoxColumn,
            this.oCCUPANCYDDataGridViewTextBoxColumn,
            this.bUSNAMEDataGridViewTextBoxColumn,
            this.sTORIESDataGridViewTextBoxColumn,
            this.uNITSDataGridViewTextBoxColumn,
            this.lEASABLESQDataGridViewTextBoxColumn,
            this.gRFLSQFTDataGridViewTextBoxColumn,
            this.tOTALSQFTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lookupCommercialParcelInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(787, 386);
            this.dataGridView1.TabIndex = 23;
            // 
            // yRBLTDataGridViewTextBoxColumn
            // 
            this.yRBLTDataGridViewTextBoxColumn.DataPropertyName = "YRBLT";
            this.yRBLTDataGridViewTextBoxColumn.HeaderText = "Year Built";
            this.yRBLTDataGridViewTextBoxColumn.Name = "yRBLTDataGridViewTextBoxColumn";
            this.yRBLTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEMYEARDataGridViewTextBoxColumn
            // 
            this.rEMYEARDataGridViewTextBoxColumn.DataPropertyName = "REMYEAR";
            this.rEMYEARDataGridViewTextBoxColumn.HeaderText = "Year Renovated";
            this.rEMYEARDataGridViewTextBoxColumn.Name = "rEMYEARDataGridViewTextBoxColumn";
            this.rEMYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oCCUPANCYDDataGridViewTextBoxColumn
            // 
            this.oCCUPANCYDDataGridViewTextBoxColumn.DataPropertyName = "OCCUPANCYD";
            this.oCCUPANCYDDataGridViewTextBoxColumn.HeaderText = "Occupancy Date";
            this.oCCUPANCYDDataGridViewTextBoxColumn.Name = "oCCUPANCYDDataGridViewTextBoxColumn";
            this.oCCUPANCYDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUSNAMEDataGridViewTextBoxColumn
            // 
            this.bUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "BUSNAME";
            this.bUSNAMEDataGridViewTextBoxColumn.HeaderText = "Business Name";
            this.bUSNAMEDataGridViewTextBoxColumn.Name = "bUSNAMEDataGridViewTextBoxColumn";
            this.bUSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTORIESDataGridViewTextBoxColumn
            // 
            this.sTORIESDataGridViewTextBoxColumn.DataPropertyName = "STORIES";
            this.sTORIESDataGridViewTextBoxColumn.HeaderText = "Number of Stories";
            this.sTORIESDataGridViewTextBoxColumn.Name = "sTORIESDataGridViewTextBoxColumn";
            this.sTORIESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITSDataGridViewTextBoxColumn
            // 
            this.uNITSDataGridViewTextBoxColumn.DataPropertyName = "UNITS";
            this.uNITSDataGridViewTextBoxColumn.HeaderText = "Number of Units";
            this.uNITSDataGridViewTextBoxColumn.Name = "uNITSDataGridViewTextBoxColumn";
            this.uNITSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lEASABLESQDataGridViewTextBoxColumn
            // 
            this.lEASABLESQDataGridViewTextBoxColumn.DataPropertyName = "LEASABLESQ";
            this.lEASABLESQDataGridViewTextBoxColumn.HeaderText = "Leasable SqFt";
            this.lEASABLESQDataGridViewTextBoxColumn.Name = "lEASABLESQDataGridViewTextBoxColumn";
            this.lEASABLESQDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gRFLSQFTDataGridViewTextBoxColumn
            // 
            this.gRFLSQFTDataGridViewTextBoxColumn.DataPropertyName = "GRFLSQFT";
            this.gRFLSQFTDataGridViewTextBoxColumn.HeaderText = "Ground SqFt";
            this.gRFLSQFTDataGridViewTextBoxColumn.Name = "gRFLSQFTDataGridViewTextBoxColumn";
            this.gRFLSQFTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALSQFTDataGridViewTextBoxColumn
            // 
            this.tOTALSQFTDataGridViewTextBoxColumn.DataPropertyName = "TOTALSQFT";
            this.tOTALSQFTDataGridViewTextBoxColumn.HeaderText = "Total SqFt";
            this.tOTALSQFTDataGridViewTextBoxColumn.Name = "tOTALSQFTDataGridViewTextBoxColumn";
            this.tOTALSQFTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lookupCommercialParcelInfoBindingSource
            // 
            this.lookupCommercialParcelInfoBindingSource.DataSource = typeof(DowntownBoiseAssociation.LookupCommercialParcelInfo);
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.editProperties1);
            this.tabProperties.Location = new System.Drawing.Point(4, 22);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(715, 317);
            this.tabProperties.TabIndex = 4;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.CommentDisplayBuilding);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(715, 317);
            this.tabNotes.TabIndex = 2;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.ContactDisplayBuilding);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(715, 317);
            this.tabContacts.TabIndex = 1;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.White;
            this.tabInfo.Controls.Add(this.txtAppInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(715, 317);
            this.tabInfo.TabIndex = 5;
            this.tabInfo.Text = "App Info";
            // 
            // txtAppInfo
            // 
            this.txtAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppInfo.Location = new System.Drawing.Point(1, 4);
            this.txtAppInfo.Multiline = true;
            this.txtAppInfo.Name = "txtAppInfo";
            this.txtAppInfo.Size = new System.Drawing.Size(711, 313);
            this.txtAppInfo.TabIndex = 0;
            // 
            // txtParcelNumber
            // 
            this.txtParcelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "ParcelNo", true));
            this.txtParcelNumber.Location = new System.Drawing.Point(109, 37);
            this.txtParcelNumber.Name = "txtParcelNumber";
            this.txtParcelNumber.Size = new System.Drawing.Size(272, 20);
            this.txtParcelNumber.TabIndex = 23;
            // 
            // lblSpaces
            // 
            this.lblSpaces.AutoSize = true;
            this.lblSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaces.Location = new System.Drawing.Point(15, 163);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(0, 17);
            this.lblSpaces.TabIndex = 24;
            // 
            // btnCreateSpace
            // 
            this.btnCreateSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSpace.Location = new System.Drawing.Point(605, 124);
            this.btnCreateSpace.Name = "btnCreateSpace";
            this.btnCreateSpace.Size = new System.Drawing.Size(117, 23);
            this.btnCreateSpace.TabIndex = 25;
            this.btnCreateSpace.Text = "Create &New Space";
            this.btnCreateSpace.UseVisualStyleBackColor = true;
            this.btnCreateSpace.Click += new System.EventHandler(this.btnCreateSpace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(394, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Block";
            // 
            // btnBlock
            // 
            this.btnBlock.AutoSize = true;
            this.btnBlock.Location = new System.Drawing.Point(487, 84);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(34, 13);
            this.btnBlock.TabIndex = 27;
            this.btnBlock.TabStop = true;
            this.btnBlock.Text = "Block";
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // linkAddress
            // 
            this.linkAddress.AutoSize = true;
            this.linkAddress.Location = new System.Drawing.Point(106, 128);
            this.linkAddress.Name = "linkAddress";
            this.linkAddress.Size = new System.Drawing.Size(45, 13);
            this.linkAddress.TabIndex = 29;
            this.linkAddress.TabStop = true;
            this.linkAddress.Text = "Address";
            this.linkAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddress_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(605, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vwTenantListingbyBuildingBindingSource
            // 
            this.vwTenantListingbyBuildingBindingSource.DataSource = typeof(DowntownBoiseAssociation.vw_TenantListingbyBuilding);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(565, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 30);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Billing Legal Entity";
            // 
            // linkBuildingBillingLE
            // 
            this.linkBuildingBillingLE.AutoSize = true;
            this.linkBuildingBillingLE.Location = new System.Drawing.Point(106, 108);
            this.linkBuildingBillingLE.Name = "linkBuildingBillingLE";
            this.linkBuildingBillingLE.Size = new System.Drawing.Size(132, 13);
            this.linkBuildingBillingLE.TabIndex = 36;
            this.linkBuildingBillingLE.TabStop = true;
            this.linkBuildingBillingLE.Text = "Building Billing Legal Entity";
            this.linkBuildingBillingLE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuildingBillingLE_LinkClicked);
            // 
            // editProperties1
            // 
            this.editProperties1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editProperties1.AutoScroll = true;
            this.editProperties1.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editProperties1.DisplayGroups")));
            this.editProperties1.Location = new System.Drawing.Point(0, 0);
            this.editProperties1.Name = "editProperties1";
            this.editProperties1.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editProperties1.NonDisplayGroups")));
            this.editProperties1.Size = new System.Drawing.Size(709, 317);
            this.editProperties1.TabIndex = 0;
            // 
            // CommentDisplayBuilding
            // 
            this.CommentDisplayBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentDisplayBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CommentDisplayBuilding.Location = new System.Drawing.Point(3, 6);
            this.CommentDisplayBuilding.Name = "CommentDisplayBuilding";
            this.CommentDisplayBuilding.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CommentDisplayBuilding.Size = new System.Drawing.Size(712, 308);
            this.CommentDisplayBuilding.TabIndex = 0;
            // 
            // ContactDisplayBuilding
            // 
            this.ContactDisplayBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDisplayBuilding.Location = new System.Drawing.Point(3, 6);
            this.ContactDisplayBuilding.MinimumSize = new System.Drawing.Size(0, 275);
            this.ContactDisplayBuilding.Name = "ContactDisplayBuilding";
            this.ContactDisplayBuilding.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ContactDisplayBuilding.Size = new System.Drawing.Size(709, 308);
            this.ContactDisplayBuilding.TabIndex = 0;
            // 
            // frmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(742, 540);
            this.Controls.Add(this.linkBuildingBillingLE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateSpace);
            this.Controls.Add(this.lblSpaces);
            this.Controls.Add(this.txtParcelNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.lblUnbillableSqFt);
            this.Controls.Add(this.txtUnbillableSqFt);
            this.Controls.Add(this.txtTotalSqFt);
            this.Controls.Add(this.lblTotalSqFt);
            this.Controls.Add(this.lblAverageRent);
            this.Controls.Add(this.txtAverageRent);
            this.Controls.Add(this.lblRentableSqFt);
            this.Controls.Add(this.txtRentableSqrFt);
            this.Controls.Add(this.txtYearRenovated);
            this.Controls.Add(this.lblYearRenovated);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumberOfFloors);
            this.Controls.Add(this.txtNumberOfFloors);
            this.Controls.Add(this.lblParcelNumber);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmBuilding";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "`";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuilding_FormClosing);
            this.Load += new System.EventHandler(this.frmBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.tabCounty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCommercialParcelInfoBindingSource)).EndInit();
            this.tabProperties.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwParcelNumberLookUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label lblParcelNumber;
        private System.Windows.Forms.BindingSource vwParcelNumberLookUpBindingSource;
        private System.Windows.Forms.TextBox txtNumberOfFloors;
        private System.Windows.Forms.Label lblNumberOfFloors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblYearRenovated;
        private System.Windows.Forms.TextBox txtYearRenovated;
        private System.Windows.Forms.TextBox txtTotalSqFt;
        private System.Windows.Forms.Label lblTotalSqFt;
        private System.Windows.Forms.Label lblAverageRent;
        private System.Windows.Forms.TextBox txtAverageRent;
        private System.Windows.Forms.Label lblRentableSqFt;
        private System.Windows.Forms.TextBox txtRentableSqrFt;
        private System.Windows.Forms.Label lblUnbillableSqFt;
        private System.Windows.Forms.TextBox txtUnbillableSqFt;
        private System.Windows.Forms.BindingSource lookupCommercialParcelInfoBindingSource;
        private System.Windows.Forms.BindingSource vwTenantListingbyBuildingBindingSource;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.TabPage tabCounty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yRBLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCCUPANCYDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORIESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEASABLESQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRFLSQFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALSQFTDataGridViewTextBoxColumn;
        private DowntownBoiseAssociation.Controls.DBA_CommentDisplay CommentDisplayBuilding;
        private DowntownBoiseAssociation.Controls.DBA_ContactDisplay ContactDisplayBuilding;
        private System.Windows.Forms.TextBox txtParcelNumber;
        private System.Windows.Forms.DataGridViewLinkColumn SpaceName;
        private System.Windows.Forms.DataGridViewLinkColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantId;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.Button btnCreateSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnBlock;
        private System.Windows.Forms.LinkLabel linkAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabProperties;
        private Controls.editProperties editProperties1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TextBox txtAppInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkBuildingBillingLE;
    }
}
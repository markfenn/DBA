namespace DowntownBoiseAssociation
{
    partial class frmTenantByDateRange
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
            this.dfldOpenDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateOpenFrom = new System.Windows.Forms.Label();
            this.lblOpenDateTo = new System.Windows.Forms.Label();
            this.dfldOpenDateTo = new System.Windows.Forms.DateTimePicker();
            this.grpOpenDateRange = new System.Windows.Forms.GroupBox();
            this.lblClosedDateTo = new System.Windows.Forms.Label();
            this.lblClosedDateFrom = new System.Windows.Forms.Label();
            this.dfldClosedDateTo = new System.Windows.Forms.DateTimePicker();
            this.dfldClosedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.grpTenantClosedDateRange = new System.Windows.Forms.GroupBox();
            this.grpAndOr = new System.Windows.Forms.GroupBox();
            this.rbtOr = new System.Windows.Forms.RadioButton();
            this.rbtAnd = new System.Windows.Forms.RadioButton();
            this.brnGetTenants = new System.Windows.Forms.Button();
            this.grdTenantByBuilding = new System.Windows.Forms.DataGridView();
            this.BuildingName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buildingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateClosedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAssessedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwTenantListingbyBuildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpOpenDateRange.SuspendLayout();
            this.grpTenantClosedDateRange.SuspendLayout();
            this.grpAndOr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantByBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dfldOpenDateFrom
            // 
            this.dfldOpenDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldOpenDateFrom.Location = new System.Drawing.Point(48, 55);
            this.dfldOpenDateFrom.Name = "dfldOpenDateFrom";
            this.dfldOpenDateFrom.Size = new System.Drawing.Size(98, 20);
            this.dfldOpenDateFrom.TabIndex = 4;
            this.dfldOpenDateFrom.Value = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateOpenFrom
            // 
            this.lblDateOpenFrom.AutoSize = true;
            this.lblDateOpenFrom.Location = new System.Drawing.Point(45, 39);
            this.lblDateOpenFrom.Name = "lblDateOpenFrom";
            this.lblDateOpenFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateOpenFrom.TabIndex = 5;
            this.lblDateOpenFrom.Text = "Date From";
            // 
            // lblOpenDateTo
            // 
            this.lblOpenDateTo.AutoSize = true;
            this.lblOpenDateTo.Location = new System.Drawing.Point(45, 88);
            this.lblOpenDateTo.Name = "lblOpenDateTo";
            this.lblOpenDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblOpenDateTo.TabIndex = 7;
            this.lblOpenDateTo.Text = "Date To";
            // 
            // dfldOpenDateTo
            // 
            this.dfldOpenDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldOpenDateTo.Location = new System.Drawing.Point(18, 80);
            this.dfldOpenDateTo.Name = "dfldOpenDateTo";
            this.dfldOpenDateTo.Size = new System.Drawing.Size(98, 20);
            this.dfldOpenDateTo.TabIndex = 6;
            // 
            // grpOpenDateRange
            // 
            this.grpOpenDateRange.Controls.Add(this.dfldOpenDateTo);
            this.grpOpenDateRange.Location = new System.Drawing.Point(30, 24);
            this.grpOpenDateRange.Name = "grpOpenDateRange";
            this.grpOpenDateRange.Size = new System.Drawing.Size(148, 125);
            this.grpOpenDateRange.TabIndex = 8;
            this.grpOpenDateRange.TabStop = false;
            this.grpOpenDateRange.Text = "Tenant Open Date Range";
            // 
            // lblClosedDateTo
            // 
            this.lblClosedDateTo.AutoSize = true;
            this.lblClosedDateTo.Location = new System.Drawing.Point(309, 88);
            this.lblClosedDateTo.Name = "lblClosedDateTo";
            this.lblClosedDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblClosedDateTo.TabIndex = 11;
            this.lblClosedDateTo.Text = "Date To";
            // 
            // lblClosedDateFrom
            // 
            this.lblClosedDateFrom.AutoSize = true;
            this.lblClosedDateFrom.Location = new System.Drawing.Point(309, 39);
            this.lblClosedDateFrom.Name = "lblClosedDateFrom";
            this.lblClosedDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblClosedDateFrom.TabIndex = 10;
            this.lblClosedDateFrom.Text = "Date From";
            // 
            // dfldClosedDateTo
            // 
            this.dfldClosedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldClosedDateTo.Location = new System.Drawing.Point(18, 80);
            this.dfldClosedDateTo.Name = "dfldClosedDateTo";
            this.dfldClosedDateTo.Size = new System.Drawing.Size(98, 20);
            this.dfldClosedDateTo.TabIndex = 6;
            // 
            // dfldClosedDateFrom
            // 
            this.dfldClosedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldClosedDateFrom.Location = new System.Drawing.Point(18, 31);
            this.dfldClosedDateFrom.Name = "dfldClosedDateFrom";
            this.dfldClosedDateFrom.Size = new System.Drawing.Size(98, 20);
            this.dfldClosedDateFrom.TabIndex = 9;
            this.dfldClosedDateFrom.Value = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            // 
            // grpTenantClosedDateRange
            // 
            this.grpTenantClosedDateRange.Controls.Add(this.dfldClosedDateTo);
            this.grpTenantClosedDateRange.Controls.Add(this.dfldClosedDateFrom);
            this.grpTenantClosedDateRange.Location = new System.Drawing.Point(294, 24);
            this.grpTenantClosedDateRange.Name = "grpTenantClosedDateRange";
            this.grpTenantClosedDateRange.Size = new System.Drawing.Size(157, 125);
            this.grpTenantClosedDateRange.TabIndex = 12;
            this.grpTenantClosedDateRange.TabStop = false;
            this.grpTenantClosedDateRange.Text = "Tenant Closed Date Range";
            // 
            // grpAndOr
            // 
            this.grpAndOr.Controls.Add(this.rbtOr);
            this.grpAndOr.Controls.Add(this.rbtAnd);
            this.grpAndOr.Location = new System.Drawing.Point(199, 24);
            this.grpAndOr.Name = "grpAndOr";
            this.grpAndOr.Size = new System.Drawing.Size(75, 125);
            this.grpAndOr.TabIndex = 13;
            this.grpAndOr.TabStop = false;
            this.grpAndOr.Text = "And Or";
            // 
            // rbtOr
            // 
            this.rbtOr.AutoSize = true;
            this.rbtOr.Checked = true;
            this.rbtOr.Location = new System.Drawing.Point(6, 83);
            this.rbtOr.Name = "rbtOr";
            this.rbtOr.Size = new System.Drawing.Size(36, 17);
            this.rbtOr.TabIndex = 1;
            this.rbtOr.TabStop = true;
            this.rbtOr.Text = "Or";
            this.rbtOr.UseVisualStyleBackColor = true;
            // 
            // rbtAnd
            // 
            this.rbtAnd.AutoSize = true;
            this.rbtAnd.Location = new System.Drawing.Point(6, 33);
            this.rbtAnd.Name = "rbtAnd";
            this.rbtAnd.Size = new System.Drawing.Size(44, 17);
            this.rbtAnd.TabIndex = 0;
            this.rbtAnd.Text = "And";
            this.rbtAnd.UseVisualStyleBackColor = true;
            // 
            // brnGetTenants
            // 
            this.brnGetTenants.Location = new System.Drawing.Point(501, 78);
            this.brnGetTenants.Name = "brnGetTenants";
            this.brnGetTenants.Size = new System.Drawing.Size(75, 23);
            this.brnGetTenants.TabIndex = 14;
            this.brnGetTenants.Text = "Get Tenants";
            this.brnGetTenants.UseVisualStyleBackColor = true;
            this.brnGetTenants.Click += new System.EventHandler(this.brnGetTenants_Click);
            // 
            // grdTenantByBuilding
            // 
            this.grdTenantByBuilding.AllowUserToAddRows = false;
            this.grdTenantByBuilding.AllowUserToDeleteRows = false;
            this.grdTenantByBuilding.AllowUserToOrderColumns = true;
            this.grdTenantByBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTenantByBuilding.AutoGenerateColumns = false;
            this.grdTenantByBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenantByBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIdDataGridViewTextBoxColumn,
            this.tenantIdDataGridViewTextBoxColumn,
            this.BuildingName,
            this.nameDataGridViewTextBoxColumn,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.dateClosedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.votesDataGridViewTextBoxColumn,
            this.isAssessedDataGridViewTextBoxColumn,
            this.isPublishedDataGridViewTextBoxColumn});
            this.grdTenantByBuilding.DataSource = this.vwTenantListingbyBuildingBindingSource;
            this.grdTenantByBuilding.Location = new System.Drawing.Point(20, 184);
            this.grdTenantByBuilding.Name = "grdTenantByBuilding";
            this.grdTenantByBuilding.ReadOnly = true;
            this.grdTenantByBuilding.Size = new System.Drawing.Size(647, 346);
            this.grdTenantByBuilding.TabIndex = 15;
            this.grdTenantByBuilding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenantByBuilding_CellContentClick);
            // 
            // BuildingName
            // 
            this.BuildingName.DataPropertyName = "BuildingName";
            this.BuildingName.HeaderText = "Building";
            this.BuildingName.Name = "BuildingName";
            this.BuildingName.ReadOnly = true;
            this.BuildingName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BuildingName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buildingIdDataGridViewTextBoxColumn
            // 
            this.buildingIdDataGridViewTextBoxColumn.DataPropertyName = "BuildingId";
            this.buildingIdDataGridViewTextBoxColumn.HeaderText = "BuildingId";
            this.buildingIdDataGridViewTextBoxColumn.Name = "buildingIdDataGridViewTextBoxColumn";
            this.buildingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenantIdDataGridViewTextBoxColumn
            // 
            this.tenantIdDataGridViewTextBoxColumn.DataPropertyName = "TenantId";
            this.tenantIdDataGridViewTextBoxColumn.HeaderText = "TenantId";
            this.tenantIdDataGridViewTextBoxColumn.Name = "tenantIdDataGridViewTextBoxColumn";
            this.tenantIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenantIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tenant";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateClosedDataGridViewTextBoxColumn
            // 
            this.dateClosedDataGridViewTextBoxColumn.DataPropertyName = "DateClosed";
            this.dateClosedDataGridViewTextBoxColumn.HeaderText = "DateClosed";
            this.dateClosedDataGridViewTextBoxColumn.Name = "dateClosedDataGridViewTextBoxColumn";
            this.dateClosedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            this.dateUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // votesDataGridViewTextBoxColumn
            // 
            this.votesDataGridViewTextBoxColumn.DataPropertyName = "Votes";
            this.votesDataGridViewTextBoxColumn.HeaderText = "Votes";
            this.votesDataGridViewTextBoxColumn.Name = "votesDataGridViewTextBoxColumn";
            this.votesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAssessedDataGridViewTextBoxColumn
            // 
            this.isAssessedDataGridViewTextBoxColumn.DataPropertyName = "IsAssessed";
            this.isAssessedDataGridViewTextBoxColumn.HeaderText = "IsAssessed";
            this.isAssessedDataGridViewTextBoxColumn.Name = "isAssessedDataGridViewTextBoxColumn";
            this.isAssessedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isAssessedDataGridViewTextBoxColumn.Visible = false;
            // 
            // isPublishedDataGridViewTextBoxColumn
            // 
            this.isPublishedDataGridViewTextBoxColumn.DataPropertyName = "IsPublished";
            this.isPublishedDataGridViewTextBoxColumn.HeaderText = "IsPublished";
            this.isPublishedDataGridViewTextBoxColumn.Name = "isPublishedDataGridViewTextBoxColumn";
            this.isPublishedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isPublishedDataGridViewTextBoxColumn.Visible = false;
            // 
            // vwTenantListingbyBuildingBindingSource
            // 
            this.vwTenantListingbyBuildingBindingSource.DataSource = typeof(DowntownBoiseAssociation.vw_TenantListingbyBuilding);
            // 
            // frmTenantByDateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 542);
            this.Controls.Add(this.grdTenantByBuilding);
            this.Controls.Add(this.brnGetTenants);
            this.Controls.Add(this.grpAndOr);
            this.Controls.Add(this.lblClosedDateTo);
            this.Controls.Add(this.lblClosedDateFrom);
            this.Controls.Add(this.grpTenantClosedDateRange);
            this.Controls.Add(this.lblOpenDateTo);
            this.Controls.Add(this.lblDateOpenFrom);
            this.Controls.Add(this.dfldOpenDateFrom);
            this.Controls.Add(this.grpOpenDateRange);
            this.Name = "frmTenantByDateRange";
            this.Text = "Tenant Selection by Date Range";
            this.Load += new System.EventHandler(this.frmTenantByDateRange_Load);
            this.grpOpenDateRange.ResumeLayout(false);
            this.grpTenantClosedDateRange.ResumeLayout(false);
            this.grpAndOr.ResumeLayout(false);
            this.grpAndOr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantByBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dfldOpenDateFrom;
        private System.Windows.Forms.Label lblDateOpenFrom;
        private System.Windows.Forms.Label lblOpenDateTo;
        private System.Windows.Forms.DateTimePicker dfldOpenDateTo;
        private System.Windows.Forms.GroupBox grpOpenDateRange;
        private System.Windows.Forms.Label lblClosedDateTo;
        private System.Windows.Forms.Label lblClosedDateFrom;
        private System.Windows.Forms.DateTimePicker dfldClosedDateTo;
        private System.Windows.Forms.DateTimePicker dfldClosedDateFrom;
        private System.Windows.Forms.GroupBox grpTenantClosedDateRange;
        private System.Windows.Forms.GroupBox grpAndOr;
        private System.Windows.Forms.RadioButton rbtOr;
        private System.Windows.Forms.RadioButton rbtAnd;
        private System.Windows.Forms.Button brnGetTenants;
        private System.Windows.Forms.DataGridView grdTenantByBuilding;
        private System.Windows.Forms.BindingSource vwTenantListingbyBuildingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn BuildingName;
        private System.Windows.Forms.DataGridViewLinkColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateClosedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAssessedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPublishedDataGridViewTextBoxColumn;
    }
}
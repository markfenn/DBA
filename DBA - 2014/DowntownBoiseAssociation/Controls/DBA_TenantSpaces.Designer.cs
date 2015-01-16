namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_TenantSpaces
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgSpaces = new System.Windows.Forms.DataGridView();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SpaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqFtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lnkVacate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.fnGetTenantSpacesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkAssign = new System.Windows.Forms.LinkLabel();
            this.lblTotalSpace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnGetTenantSpacesResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSpaces
            // 
            this.dgSpaces.AllowUserToAddRows = false;
            this.dgSpaces.AllowUserToDeleteRows = false;
            this.dgSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSpaces.AutoGenerateColumns = false;
            this.dgSpaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSpaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.buildingNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.SpaceType,
            this.sqFtDataGridViewTextBoxColumn,
            this.lnkEdit,
            this.lnkVacate});
            this.dgSpaces.DataSource = this.fnGetTenantSpacesResultBindingSource;
            this.dgSpaces.Location = new System.Drawing.Point(0, 20);
            this.dgSpaces.Name = "dgSpaces";
            this.dgSpaces.ReadOnly = true;
            this.dgSpaces.RowHeadersVisible = false;
            this.dgSpaces.Size = new System.Drawing.Size(663, 375);
            this.dgSpaces.TabIndex = 0;
            this.dgSpaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSpaces_CellContentClick);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Date Opened";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 96;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "BuildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buildingNameDataGridViewTextBoxColumn.Width = 69;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addressDataGridViewTextBoxColumn.Width = 70;
            // 
            // SpaceType
            // 
            this.SpaceType.DataPropertyName = "SpaceType";
            this.SpaceType.HeaderText = "Space Type";
            this.SpaceType.Name = "SpaceType";
            this.SpaceType.ReadOnly = true;
            this.SpaceType.Width = 90;
            // 
            // sqFtDataGridViewTextBoxColumn
            // 
            this.sqFtDataGridViewTextBoxColumn.DataPropertyName = "SqFt";
            this.sqFtDataGridViewTextBoxColumn.HeaderText = "SqFt";
            this.sqFtDataGridViewTextBoxColumn.Name = "sqFtDataGridViewTextBoxColumn";
            this.sqFtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sqFtDataGridViewTextBoxColumn.Width = 54;
            // 
            // lnkEdit
            // 
            this.lnkEdit.HeaderText = "";
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.ReadOnly = true;
            this.lnkEdit.Text = "Edit";
            this.lnkEdit.UseColumnTextForLinkValue = true;
            this.lnkEdit.Width = 5;
            // 
            // lnkVacate
            // 
            this.lnkVacate.HeaderText = "";
            this.lnkVacate.Name = "lnkVacate";
            this.lnkVacate.ReadOnly = true;
            this.lnkVacate.Text = "Vacate";
            this.lnkVacate.TrackVisitedState = false;
            this.lnkVacate.UseColumnTextForLinkValue = true;
            this.lnkVacate.Width = 5;
            // 
            // fnGetTenantSpacesResultBindingSource
            // 
            this.fnGetTenantSpacesResultBindingSource.DataSource = typeof(DowntownBoiseAssociation.fn_GetTenantSpacesResult);
            // 
            // lnkAssign
            // 
            this.lnkAssign.AutoSize = true;
            this.lnkAssign.Location = new System.Drawing.Point(3, 4);
            this.lnkAssign.Name = "lnkAssign";
            this.lnkAssign.Size = new System.Drawing.Size(102, 13);
            this.lnkAssign.TabIndex = 1;
            this.lnkAssign.TabStop = true;
            this.lnkAssign.Text = "Assign a new space";
            this.lnkAssign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssign_LinkClicked);
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSpace.Location = new System.Drawing.Point(398, 4);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalSpace.Size = new System.Drawing.Size(262, 13);
            this.lblTotalSpace.TabIndex = 5;
            this.lblTotalSpace.Text = "0 sq feet";
            this.lblTotalSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DBA_TenantSpaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalSpace);
            this.Controls.Add(this.lnkAssign);
            this.Controls.Add(this.dgSpaces);
            this.Name = "DBA_TenantSpaces";
            this.Size = new System.Drawing.Size(663, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnGetTenantSpacesResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSpaces;
        private System.Windows.Forms.LinkLabel lnkAssign;
        private System.Windows.Forms.Label lblTotalSpace;
        private System.Windows.Forms.BindingSource fnGetTenantSpacesResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqFtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn lnkEdit;
        private System.Windows.Forms.DataGridViewLinkColumn lnkVacate;
    }
}

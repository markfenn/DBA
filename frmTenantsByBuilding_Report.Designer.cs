namespace DowntownBoiseAssociation
{
    partial class frmTenantsByBuilding_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vwTenantListingbyBuildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBADevDataSet1 = new DowntownBoiseAssociation.DBADevDataSet1();
            this.rptvTenantByBuilding = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_TenantListingbyBuildingTableAdapter = new DowntownBoiseAssociation.DBADevDataSet1TableAdapters.vw_TenantListingbyBuildingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // vwTenantListingbyBuildingBindingSource
            // 
            this.vwTenantListingbyBuildingBindingSource.DataMember = "vw_TenantListingbyBuilding";
            this.vwTenantListingbyBuildingBindingSource.DataSource = this.dBADevDataSet1;
            // 
            // dBADevDataSet1
            // 
            this.dBADevDataSet1.DataSetName = "DBADevDataSet1";
            this.dBADevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvTenantByBuilding
            // 
            this.rptvTenantByBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "vw_TenantListingbyBuilding";
            reportDataSource1.Value = this.vwTenantListingbyBuildingBindingSource;
            this.rptvTenantByBuilding.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvTenantByBuilding.LocalReport.ReportEmbeddedResource = "DowntownBoiseAssociation.Reports.rptTenantsByBuilding.rdlc";
            this.rptvTenantByBuilding.Location = new System.Drawing.Point(12, 4);
            this.rptvTenantByBuilding.Name = "rptvTenantByBuilding";
            this.rptvTenantByBuilding.Size = new System.Drawing.Size(568, 421);
            this.rptvTenantByBuilding.TabIndex = 0;
            this.rptvTenantByBuilding.Load += new System.EventHandler(this.rptvTenantByBuilding_Load);
            // 
            // vw_TenantListingbyBuildingTableAdapter
            // 
            this.vw_TenantListingbyBuildingTableAdapter.ClearBeforeFill = true;
            // 
            // frmTenantsByBuilding_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 437);
            this.Controls.Add(this.rptvTenantByBuilding);
            this.Name = "frmTenantsByBuilding_Report";
            this.Text = "frmTenantsByBuilding_Report";
            this.Load += new System.EventHandler(this.frmTenantsByBuilding_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantListingbyBuildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvTenantByBuilding;
        private DBADevDataSet1 dBADevDataSet1;
        private System.Windows.Forms.BindingSource vwTenantListingbyBuildingBindingSource;
        private DowntownBoiseAssociation.DBADevDataSet1TableAdapters.vw_TenantListingbyBuildingTableAdapter vw_TenantListingbyBuildingTableAdapter;
    }
}
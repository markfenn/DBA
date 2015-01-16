namespace DowntownBoiseAssociation
{
	partial class frmrptListofVotingMembers_Report
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
            this.vwTenantBillingAddressandVotingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBADevDataSetvw_TenantBillingAddressandVotingInfo = new DowntownBoiseAssociation.DBADevDataSetvw_TenantBillingAddressandVotingInfo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.dfldOpenDate = new System.Windows.Forms.DateTimePicker();
            this.lblOpenonorBefore = new System.Windows.Forms.Label();
            this.vw_TenantBillingAddressandVotingInfoTableAdapter = new DowntownBoiseAssociation.DBADevDataSetvw_TenantBillingAddressandVotingInfoTableAdapters.vw_TenantBillingAddressandVotingInfoTableAdapter();
            this.dfldClosedDate = new System.Windows.Forms.DateTimePicker();
            this.lblClosedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantBillingAddressandVotingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSetvw_TenantBillingAddressandVotingInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // vwTenantBillingAddressandVotingInfoBindingSource
            // 
            this.vwTenantBillingAddressandVotingInfoBindingSource.DataMember = "vw_TenantBillingAddressandVotingInfo";
            this.vwTenantBillingAddressandVotingInfoBindingSource.DataSource = this.dBADevDataSetvw_TenantBillingAddressandVotingInfo;
            // 
            // dBADevDataSetvw_TenantBillingAddressandVotingInfo
            // 
            this.dBADevDataSetvw_TenantBillingAddressandVotingInfo.DataSetName = "DBADevDataSetvw_TenantBillingAddressandVotingInfo";
            this.dBADevDataSetvw_TenantBillingAddressandVotingInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "vw_TenantBillingAddressandVotingInfo";
            reportDataSource1.Value = this.vwTenantBillingAddressandVotingInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DowntownBoiseAssociation.Reports.rptListofVotingMembers_2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(729, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(666, 28);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnRunReport.TabIndex = 1;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRunReport_MouseClick);
            // 
            // dfldOpenDate
            // 
            this.dfldOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldOpenDate.Location = new System.Drawing.Point(89, 32);
            this.dfldOpenDate.Name = "dfldOpenDate";
            this.dfldOpenDate.Size = new System.Drawing.Size(105, 20);
            this.dfldOpenDate.TabIndex = 2;
            // 
            // lblOpenonorBefore
            // 
            this.lblOpenonorBefore.AutoSize = true;
            this.lblOpenonorBefore.Location = new System.Drawing.Point(86, 13);
            this.lblOpenonorBefore.Name = "lblOpenonorBefore";
            this.lblOpenonorBefore.Size = new System.Drawing.Size(231, 13);
            this.lblOpenonorBefore.TabIndex = 3;
            this.lblOpenonorBefore.Text = "Voting Memeber Opened on or Before this Date";
            this.lblOpenonorBefore.Click += new System.EventHandler(this.label1_Click);
            // 
            // vw_TenantBillingAddressandVotingInfoTableAdapter
            // 
            this.vw_TenantBillingAddressandVotingInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dfldClosedDate
            // 
            this.dfldClosedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dfldClosedDate.Location = new System.Drawing.Point(370, 29);
            this.dfldClosedDate.Name = "dfldClosedDate";
            this.dfldClosedDate.Size = new System.Drawing.Size(105, 20);
            this.dfldClosedDate.TabIndex = 4;
            // 
            // lblClosedDate
            // 
            this.lblClosedDate.AutoSize = true;
            this.lblClosedDate.Location = new System.Drawing.Point(370, 13);
            this.lblClosedDate.Name = "lblClosedDate";
            this.lblClosedDate.Size = new System.Drawing.Size(216, 13);
            this.lblClosedDate.TabIndex = 5;
            this.lblClosedDate.Text = "Voting Memeber Closed on or After this Date";
            // 
            // frmrptListofVotingMembers_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.lblClosedDate);
            this.Controls.Add(this.dfldClosedDate);
            this.Controls.Add(this.lblOpenonorBefore);
            this.Controls.Add(this.dfldOpenDate);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrptListofVotingMembers_Report";
            this.Text = "frmrptListofVotingMembers_Report";
            this.Load += new System.EventHandler(this.frmrptListofVotingMembers_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwTenantBillingAddressandVotingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSetvw_TenantBillingAddressandVotingInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.DateTimePicker dfldOpenDate;
        private System.Windows.Forms.Label lblOpenonorBefore;
        private DBADevDataSetvw_TenantBillingAddressandVotingInfo dBADevDataSetvw_TenantBillingAddressandVotingInfo;
        private System.Windows.Forms.BindingSource vwTenantBillingAddressandVotingInfoBindingSource;
        private DowntownBoiseAssociation.DBADevDataSetvw_TenantBillingAddressandVotingInfoTableAdapters.vw_TenantBillingAddressandVotingInfoTableAdapter vw_TenantBillingAddressandVotingInfoTableAdapter;
        private System.Windows.Forms.DateTimePicker dfldClosedDate;
        private System.Windows.Forms.Label lblClosedDate;



    }
}
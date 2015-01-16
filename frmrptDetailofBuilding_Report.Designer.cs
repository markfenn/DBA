namespace DowntownBoiseAssociation
{
    partial class frmrptDetailofBuilding_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cmbBuildingSelect = new System.Windows.Forms.ComboBox();
            this.lblBuildingFrom = new System.Windows.Forms.Label();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRunReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dBADevDataSetvw_DetailofBuilding_Report = new DowntownBoiseAssociation.DBADevDataSetvw_DetailofBuilding_Report();
            this.vwDetailofBuildingReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DetailofBuilding_ReportTableAdapter = new DowntownBoiseAssociation.DBADevDataSetvw_DetailofBuilding_ReportTableAdapters.vw_DetailofBuilding_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSetvw_DetailofBuilding_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetailofBuildingReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuildingSelect
            // 
            this.cmbBuildingSelect.FormattingEnabled = true;
            this.cmbBuildingSelect.Location = new System.Drawing.Point(107, 11);
            this.cmbBuildingSelect.Name = "cmbBuildingSelect";
            this.cmbBuildingSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbBuildingSelect.Sorted = true;
            this.cmbBuildingSelect.TabIndex = 0;
            // 
            // lblBuildingFrom
            // 
            this.lblBuildingFrom.AutoSize = true;
            this.lblBuildingFrom.Location = new System.Drawing.Point(10, 15);
            this.lblBuildingFrom.Name = "lblBuildingFrom";
            this.lblBuildingFrom.Size = new System.Drawing.Size(86, 13);
            this.lblBuildingFrom.TabIndex = 1;
            this.lblBuildingFrom.Text = "Select a Building";
            this.lblBuildingFrom.Click += new System.EventHandler(this.lblBuildingFrom_Click);
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(DowntownBoiseAssociation.Building);
            // 
            // btnRunReport
            // 
            this.btnRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunReport.Location = new System.Drawing.Point(657, 10);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnRunReport.TabIndex = 5;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRunReport_MouseClick);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "vw_DetailofBuilding_Report";
            reportDataSource1.Value = this.vwDetailofBuildingReportBindingSource;
            reportDataSource2.Name = "DBADevDataSetvw_DetailofBuilding_Report_vw_DetailofBuilding_Report";
            reportDataSource2.Value = this.vwDetailofBuildingReportBindingSource;
            reportDataSource3.Name = "DetailsofBuildings_vw_DetailofBuilding_Report";
            reportDataSource3.Value = this.vwDetailofBuildingReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DowntownBoiseAssociation.Reports.rptDetailofBuilding_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 493);
            this.reportViewer1.TabIndex = 6;
            // 
            // dBADevDataSetvw_DetailofBuilding_Report
            // 
            this.dBADevDataSetvw_DetailofBuilding_Report.DataSetName = "DBADevDataSetvw_DetailofBuilding_Report";
            this.dBADevDataSetvw_DetailofBuilding_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDetailofBuildingReportBindingSource
            // 
            this.vwDetailofBuildingReportBindingSource.DataMember = "vw_DetailofBuilding_Report";
            this.vwDetailofBuildingReportBindingSource.DataSource = this.dBADevDataSetvw_DetailofBuilding_Report;
            // 
            // vw_DetailofBuilding_ReportTableAdapter
            // 
            this.vw_DetailofBuilding_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmrptDetailofBuilding_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 532);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.lblBuildingFrom);
            this.Controls.Add(this.cmbBuildingSelect);
            this.Name = "frmrptDetailofBuilding_Report";
            this.Text = "Detail of Building Report";
            this.Load += new System.EventHandler(this.frmrptDetailofBuilding_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADevDataSetvw_DetailofBuilding_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetailofBuildingReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuildingSelect;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private System.Windows.Forms.Label lblBuildingFrom;
        private System.Windows.Forms.Button btnRunReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBADevDataSetvw_DetailofBuilding_Report dBADevDataSetvw_DetailofBuilding_Report;
        private System.Windows.Forms.BindingSource vwDetailofBuildingReportBindingSource;
        private DowntownBoiseAssociation.DBADevDataSetvw_DetailofBuilding_ReportTableAdapters.vw_DetailofBuilding_ReportTableAdapter vw_DetailofBuilding_ReportTableAdapter;
    }
}
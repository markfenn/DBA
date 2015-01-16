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
     
    public partial class frmrptDetailofBuilding_Report : Form
    {
        DBADataContext dc = new DBADataContext();
        public frmrptDetailofBuilding_Report()
        {
            InitializeComponent();
            cmbBuildingSelect.DataSource = dc.vw_BuildingNamePickLists;
            cmbBuildingSelect.DisplayMember = "Name";
             cmbBuildingSelect.ValueMember = "Name";

             //cmbBuildingTo.DataSource = dc.vw_BuildingInformations;
             //cmbBuildingTo.DisplayMember = "Name";
             //cmbBuildingTo.ValueMember = "Name";
        }

        private void frmrptDetailofBuilding_Report_Load(object sender, EventArgs e)
        { // TODO: This line of code loads data into the 'DBADevDataSetvw_DetailofBuilding_Report.vw_DetailofBuilding_Report' table. You can move, or remove it, as needed.
            
           
        }

        private void btnRunReport_MouseClick(object sender, MouseEventArgs e)
        {
            String _BuildingId = cmbBuildingSelect.Text;
            if (_BuildingId == " All Buildings")
            {
                string BuildingFrom = cmbBuildingSelect.Text;
                vwDetailofBuildingReportBindingSource.DataSource = from c in dc.vw_DetailofBuilding_Reports
                 //                                                  where c.BuildingId>= _BuildingId 
                //                                                   //&&
                //                                                   //      c.BuildingName.Contains(BuildingTo)
                                                                   orderby c.BuildingName
                                                                   select c;
            }
            if (_BuildingId != " All Buildings")
            {
                string BuildingFrom = cmbBuildingSelect.Text;
                vwDetailofBuildingReportBindingSource.DataSource = from c in dc.vw_DetailofBuilding_Reports
                                                                   where c.BuildingName == _BuildingId 
                //                                                   //&&
                //                                                   //      c.BuildingName.Contains(BuildingTo)
                                                                   orderby c.BuildingName
                                                                   select c;
            }
            // TODO: This line of code loads data into the 'detailsofBuildings.vw_DetailofBuilding_Report' table. You can move, or remove it, as needed.
             // TODO: This line of code loads data into the 'dBADevDataSetvw_DetailofBuilding_Report.vw_DetailofBuilding_Report' table. You can move, or remove it, as needed.
           //  this.vw_DetailofBuilding_ReportTableAdapter.Fill(this.dBADevDataSetvw_DetailofBuilding_Report.vw_DetailofBuilding_Report);
            // TODO: This line of code loads data into the 'dBADevDataSetvw_DetailofBuilding_Report_2.vw_DetailofBuilding_Report' table. You can move, or remove it, as needed.
          //  this.vw_DetailofBuilding_ReportTableAdapter.Fill(this.dBADevDataSetvw_DetailofBuilding_Report_2.vw_DetailofBuilding_Report);
            this.vw_DetailofBuilding_ReportTableAdapter.Fill(this.dBADevDataSetvw_DetailofBuilding_Report.vw_DetailofBuilding_Report);

         
            this.reportViewer1.RefreshReport();
        }

        private void lblBuildingFrom_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmTenantsByBuilding_Report : Form
    {
        public frmTenantsByBuilding_Report()
        {
            InitializeComponent();
        }

        private void frmTenantsByBuilding_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBADevDataSet1.vw_TenantListingbyBuilding' table. You can move, or remove it, as needed.
            this.vw_TenantListingbyBuildingTableAdapter.Fill(this.dBADevDataSet1.vw_TenantListingbyBuilding);
            // TODO: This line of code loads data into the 'dBADevDataSet.vw_TenantListingbyBuilding' table. You can move, or remove it, as needed.
          //  this.vw_TenantListingbyBuildingTableAdapter.Fill(this.dBADevDataSet.vw_TenantListingbyBuilding);

            this.rptvTenantByBuilding.RefreshReport();
        }

        private void rptvTenantByBuilding_Load(object sender, EventArgs e)
        {

        }
    }
}

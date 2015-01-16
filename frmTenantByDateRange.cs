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
    public partial class frmTenantByDateRange : Form
    {
        DBADataContext dc = new DBADataContext();
        public frmTenantByDateRange()
        {
            InitializeComponent();
        }

        private void frmTenantByDateRange_Load(object sender, EventArgs e)
        {

        }

        private void brnGetTenants_Click(object sender, EventArgs e)
        {
          
            //  int bldgid = (int)grdBuildings.Rows[e.RowIndex].Cells[0].Value;
            DateTime dtDateOpenFrom = dfldOpenDateFrom.Value;
            DateTime dtDateOpenTo = dfldOpenDateTo.Value;
            DateTime dtDateClosedFrom = dfldClosedDateFrom.Value;
            DateTime dtDateClosedTo = dfldClosedDateTo.Value;
            String PickAnd = rbtAnd.Text;
            String PickOr = rbtOr.Text;
           

            if (rbtAnd.Checked)
            {
            vwTenantListingbyBuildingBindingSource.DataSource = from c in dc.vw_TenantListingbyBuildings
                                                                where c.DateOpened >= dtDateOpenFrom &&
                                                                c.DateOpened <= dtDateOpenTo &&
                                                                c.DateClosed >= dtDateClosedFrom &&
                                                                c.DateClosed <= dtDateClosedTo
                                                                orderby c.Name
                                                               select c;

            }
            if (rbtOr.Checked)
            {
                vwTenantListingbyBuildingBindingSource.DataSource = from c in dc.vw_TenantListingbyBuildings
                                                                    where (c.DateOpened >= dtDateOpenFrom &&
                                                                    c.DateOpened <= dtDateOpenTo) ||
                                                                    (c.DateClosed >= dtDateClosedFrom &&
                                                                    c.DateClosed <= dtDateClosedTo)
                                                                    orderby c.Name
                                                                    select c;
            }
        }

        private void grdTenantByBuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (grdTenantByBuilding.Rows[e.ColumnIndex].Index.Equals(2))
                {
                    int bldgid = (int)grdTenantByBuilding.Rows[e.RowIndex].Cells[0].Value;
                    frmBuilding fBldg = new frmBuilding(bldgid);

                    frmDBAContainer dbaCont = this.MdiParent as frmDBAContainer;
                    dbaCont.AddMDIChildForm(fBldg);
                }
                if (grdTenantByBuilding.Rows[e.ColumnIndex].Index.Equals(3))
                {

                    int tentid = (int)grdTenantByBuilding.Rows[e.RowIndex].Cells[1].Value;
                    frmTenant fTent = new frmTenant(tentid);

                    frmDBAContainer dbaCont = this.MdiParent as frmDBAContainer;
                    dbaCont.AddMDIChildForm(fTent);
                }
            }
        }

      
      
     
    }
}

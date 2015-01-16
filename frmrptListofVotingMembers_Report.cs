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
    public partial class frmrptListofVotingMembers_Report : Form
    { DBADataContext dc = new DBADataContext();
            
        public frmrptListofVotingMembers_Report()
        {
           InitializeComponent();
        }

        private void frmrptListofVotingMembers_Report_Load(object sender, EventArgs e)
        {
             
        }

        private void btnRunReport_MouseClick(object sender, MouseEventArgs e)
        {DateTime dtDateOpenTo = dfldOpenDate.Value;
        DateTime dtDateClosedOn = dfldClosedDate.Value;
          vwTenantBillingAddressandVotingInfoBindingSource.DataSource = from c in dc.vw_TenantBillingAddressandVotingInfos
                                                                where c.DateOpened <= dtDateOpenTo &&
                                                                      c.DateClosed >= dtDateClosedOn
                                                                        orderby c.Name
                                                                        select c;
            
            // TODO: This line of code loads data into the 'dBADevDataSet_sp_TenantBillingAddressVotingInfo.sp_TenantBillingAddressandVotingInfo' table. You can move, or remove it, as needed.
          //  this.sp_TenantBillingAddressandVotingInfoTableAdapter.Fill(this.dBADevDataSet_sp_TenantBillingAddressVotingInfo.sp_TenantBillingAddressandVotingInfo);
            // TODO: This line of code loads data into the 'dBADevDataSet5.sp_TenantBillingAddressandVotingInfo' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dBADevDataFred.vw_TenantBillingAddressandVotingInfo' table. You can move, or remove it, as needed.
            // this.vw_TenantBillingAddressandVotingInfoTableAdapter.Fill(this.dBADevDataFred.vw_TenantBillingAddressandVotingInfo);
            // this.vw_TenantBillingAddressandVotingInfoTableAdapter.Fill(this.dBADevDataFred.vw_TenantBillingAddressandVotingInfo);
            // TODO: This line of code loads data into the 'dBADevDataSetvw_TenantBillingAddressandVotingInfo.vw_TenantBillingAddressandVotingInfo' table. You can move, or remove it, as needed.
            this.vw_TenantBillingAddressandVotingInfoTableAdapter.Fill(this.dBADevDataSetvw_TenantBillingAddressandVotingInfo.vw_TenantBillingAddressandVotingInfo);
          //this.vw_TenantBillingAddressandVotingInfoTableAdapter.Fill(this.dc.);
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

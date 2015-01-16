using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    public partial class DBA_Location : UserControl
    {
        private int _ZoneId;
        private int _BlockId;
        private int _BuildingId;
        private int _TenantId;
        private string _BlockName;
        private DBADataContext dba = new DBADataContext();

        public DBA_Location()
        {
            InitializeComponent();
        }
        
        public int TenantId
        {            
            set { 
                _TenantId = value;

                var TenantInfo = (from a in dba.vw_Tenant_to_Zone_Lookups
                                  where a.TENANTID == _TenantId
                                  select a).FirstOrDefault();

                if (TenantInfo != null)
                {
                    linkZone.Text = TenantInfo.ZONENAME;
                    linkBlock.Text = TenantInfo.BLOCKNAME;
                    linkBuilding.Text = TenantInfo.BUILDINGNAME;
                    _ZoneId = TenantInfo.ZoneId;
                    _BlockId = TenantInfo.BlockId;
                    _BuildingId = TenantInfo.BuildingId;
                    _BlockName = TenantInfo.BLOCKNAME;
                }
                else
                {
                    
                    linkBuilding.Enabled = false;
                    linkZone.Enabled = false;
                    linkBlock.Enabled = false;
                }
            }
        }
        
        private void linkBuilding_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)ParentForm.MdiParent;
            
            frmBuilding NewBuilding = new frmBuilding(_BuildingId);
            
            NewContainer.AddMDIChildForm(NewBuilding);            
        }
              

        private void linkZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)ParentForm.MdiParent;

            frmZoneMaint NewZone = new frmZoneMaint(_ZoneId);

            NewContainer.AddMDIChildForm(NewZone);        
        }

        private void linkBlock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)ParentForm.MdiParent;

            frmBlock NewBlock = new frmBlock(Convert.ToInt32(_BlockName));

            NewContainer.AddMDIChildForm(NewBlock);        
        }
    }
}

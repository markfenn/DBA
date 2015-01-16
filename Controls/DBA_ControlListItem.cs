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
    public delegate void ControlSelectionEventHandler(object source);

    public partial class DBA_ControlListItem : UserControl
    {
        private SearchItemType _ItemType;
        private int _ItemId;
        private string _ItemTitle;        
       
        public event ControlSelectionEventHandler ControlSelectionClick;

        public DBA_ControlListItem(SearchItemType ItemType, 
            int ItemId, 
            string ItemTitle)       
        {
            InitializeComponent();

            _ItemId = ItemId;
            _ItemType = ItemType;
            _ItemTitle = ItemTitle;            
        }

        public override string ToString()
        {
 	         return _ItemTitle;
        }
        private void DBA_ControlListItem_Load(object sender, EventArgs e)
        {
            lblItemTitle.Text = _ItemTitle;
                       

            if (_ItemType == SearchItemType.Building)
            {
                picBuilding.Visible = true;
                picLegalEntity.Visible = false;
                picTenant.Visible = false;
                picSpace.Visible = false;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightSalmon;
            }
            else if (_ItemType == SearchItemType.Tenant)
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = false;
                picTenant.Visible = true;
                picSpace.Visible = false;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightBlue;
            }
            else if (_ItemType == SearchItemType.Space)
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = false;
                picTenant.Visible = false;
                picSpace.Visible = true;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.MediumPurple;
            }
            else if (_ItemType == SearchItemType.Government)
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = false;
                picTenant.Visible = false;
                picGovernment.Visible = true;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightBlue;
            }
            else if (_ItemType == SearchItemType.Parking)
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = false;
                picTenant.Visible = false;
                picGovernment.Visible = false;
                picParking.Visible = true;                
                btnItemAccept.BackColor = Color.LightBlue;
            }
            else
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = true;
                picTenant.Visible = false;
                picSpace.Visible = false;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightGray;
            }
        }

        private void btnItemAccept_Click(object sender, EventArgs e)
        {
            if (ControlSelectionClick != null) ControlSelectionClick(this);            
        }

        private void DBA_ControlListItem_MouseEnter(object sender, EventArgs e)
        {
            (this.ParentForm as frmDBAContainer).OpenPanel();
        }                
    }

 
}

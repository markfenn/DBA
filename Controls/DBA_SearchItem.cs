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
    public delegate void ViewSelectionEventHandler(object source, int ItemId, SearchItemType ItemType);

    public partial class DBA_SearchItem : UserControl
    {
        private SearchItemType _ItemType;
        private int _ItemId;
        private string _ItemTitle;
        private string _ItemAccount;
       
        public event ViewSelectionEventHandler ViewSelectionClick;        

        public DBA_SearchItem(SearchItemType ItemType, 
            int ItemId, 
            string ItemTitle, 
            string ItemAccount)       
        {
            InitializeComponent();

            _ItemId = ItemId;
            _ItemType = ItemType;
            _ItemTitle = ItemTitle;
            _ItemAccount = ItemAccount;            
        }

        private void DBA_SearchItem_Load(object sender, EventArgs e)
        {
            lblItemTitle.Text = _ItemTitle;

            lblType.Text = _ItemType.ToString();
            lblAccount.Text = _ItemAccount;

            if (_ItemType == SearchItemType.Building)
            {
                picBuilding.Visible = true;
                picLegalEntity.Visible = false;
                picTenant.Visible = false;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightSalmon;
            }
            else if (_ItemType == SearchItemType.Tenant)
            {
                picBuilding.Visible = false;
                picLegalEntity.Visible = false;
                picTenant.Visible = true;
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightBlue;
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
                picGovernment.Visible = false;
                picParking.Visible = false;
                btnItemAccept.BackColor = Color.LightGray;
            }
        }

        private void btnItemAccept_Click(object sender, EventArgs e)
        {

            if (ViewSelectionClick != null) ViewSelectionClick(this, _ItemId, _ItemType);            
        }                
    }

    public enum SearchItemType { Tenant, LegalEntity, Building, Contact, Space, Parking, Government }
}

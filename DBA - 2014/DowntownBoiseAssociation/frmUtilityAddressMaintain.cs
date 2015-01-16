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
    public partial class frmUtilityAddressMaintain : Form
    {
        DBADataContext dba = new DBADataContext();
        private int _AddressId;
        private bool _ExistingAddress;

        public frmUtilityAddressMaintain(int AddressId)
        {
            InitializeComponent();
            _AddressId = AddressId;

            _ExistingAddress = false;
            if (_AddressId > 0) { _ExistingAddress = true; }

            addressEdit.AdminMode = true;
            addressEdit.AddressId = _AddressId;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                addressEdit.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmUtilityAddressMaint Error: " + ex.Message);
                return;
            }

            _AddressId = addressEdit.AddressId;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _AddressId = 0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmUitiltyAddressMaint_Load(object sender, EventArgs e)
        {
            if (addressEdit.AddressId == 0)
            {
                this.Text = "Add New Address";
            }
            else
            {
                this.Text = "Edit Address: " + _AddressId.ToString();
            }

            addressEdit.Focus();
        }

        public int AddressId
        { get { return _AddressId; } }
        
    }
}

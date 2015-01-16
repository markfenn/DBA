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
    public partial class dialogText : Form
    {
        private bool _RequireEntry = false;
        private DialogValidate _ValidateEntry;

        public dialogText(string LabelText, bool RequireEntry, DialogValidate ValidateEntry)
        {
            InitializeComponent();
                        
            lblMain.Text = LabelText;
            _ValidateEntry = ValidateEntry;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_RequireEntry)
            {
                MessageBox.Show("A value is requered.");
                return;
            }

            if (_ValidateEntry == DialogValidate.IntegerOnly)
            {
                try
                {
                    int TestInt = Convert.ToInt16(txtMain.Text);
                }
                catch
                {
                    MessageBox.Show("Value must be an integer.");
                    return;
                }
            }


            this.DialogResult = DialogResult.OK;
        }

        public override string ToString()
        {
            return txtMain.Text;
        }

        private void dialogText_Load(object sender, EventArgs e)
        {
            txtMain.Focus();
        }
    }
    public enum DialogValidate
    {
        Any = 0, IntegerOnly
    }
}

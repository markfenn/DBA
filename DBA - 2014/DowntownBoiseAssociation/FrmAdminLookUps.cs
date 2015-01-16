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
    public partial class frmAdminLookUps : Form
    {
        public frmAdminLookUps()
        {
            InitializeComponent();
        }

        DBADataContext dc = new DBADataContext();

        private void frmAdminLookUps_Load(object sender, EventArgs e)
        {
            classTypeBindingSource.DataSource = (from c in dc.Classes
                                                 orderby c.ClassType
                                                 select c.ClassType).Distinct();

            BindClassInfo();

            categoryBindingSource.DataSource = from c in dc.Categories
                                               orderby c.Name
                                               select c;
        }

        private void BindClassInfo()
        {
            QueryUpdate();

            classBindingSource.DataSource = from c in dc.Classes
                                            orderby c.Name
                                            where c.ClassType.Equals(cboClassTypeFilter.SelectedValue)
                                            select c;
        }

        private void QueryUpdate()
        {
            if (dc.Changed())
            {
                switch (MessageBox.Show("Data has changed, save changes before changing the filter?", "Save Changes", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        dc.SubmitChanges();
                        break;

                    case DialogResult.No:
                        break;
                }
            }
        }

        private void cboClassTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindClassInfo();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
            MessageBox.Show("Information Saved.");
        }

        private void frmAdminLookUps_FormClosing(object sender, FormClosingEventArgs e)
        {
            QueryUpdate();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

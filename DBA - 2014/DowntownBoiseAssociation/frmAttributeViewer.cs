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
    public partial class frmAttributeViewer : Form
    {
        public frmAttributeViewer()
        {
            InitializeComponent();
        }

        private void frmTennantList_Load(object sender, EventArgs e)
        {
            DBADataContext dc = new DBADataContext();
            tenantBindingSource.DataSource = dc.Tenants;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                editProperties1.ObjectGuid = (Guid)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editProperties1.SaveChanges();
        }
    }
}

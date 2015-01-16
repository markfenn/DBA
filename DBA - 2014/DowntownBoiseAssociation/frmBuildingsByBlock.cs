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
    public partial class frmBuildingsByBlock : Form
    {
           DBADataContext dc = new DBADataContext();
        public frmBuildingsByBlock()
        {
            InitializeComponent();
        }

     

        private void frmBuildingsByBlock_Load(object sender, EventArgs e)
        {
           blockBindingSource.DataSource = from c in dc.Blocks
                                               orderby c.Name
                                               //where c.Id.Equals(BuildingId)
                                               select c;
        }

        private void brnGetBuildings_Click(object sender, EventArgs e)
        {
            double  BlockFromV = Convert.ToInt32(mtxtBlockFrom.Text);
            double BlockToV =  Convert.ToInt32(mtxtBlockTo.Text);

            vwBuildingsByBlockBindingSource.DataSource = from b in dc.vw_BuildingsByBlocks
                                                         orderby b.BuildingName
                                                         where (b.BlockNumber >= BlockFromV &&
                                                         b.BlockNumber <= BlockToV) ||
                                                         b.BlockId.Equals(null)

                                                         select b;
        }

        private void mtxtBlockFrom_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtBlockTo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grdBuildingsByBlock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //   if (grdBuildingsByBlock.Rows[e.ColumnIndex].Index.Equals(3))
         
           // {
                int bldgid = (int)grdBuildingsByBlock.Rows[e.RowIndex].Cells[1].Value;
                frmBuilding fBldg = new frmBuilding(bldgid);

                frmDBAContainer dbaCont = this.MdiParent as frmDBAContainer;
                dbaCont.AddMDIChildForm(fBldg);
          //  }
           //if (grdBuildingsByBlock.Rows[e.ColumnIndex].Index.Equals(2))
           //{

           //    int blockid = (int)grdBuildingsByBlock.Rows[e.RowIndex].Cells[0].Value;
           //    frmBlock fBlock = new frmBlock();

           //    frmDBAContainer dbaCont = this.MdiParent as frmDBAContainer;
           //    dbaCont.AddMDIChildForm(fBlock);
           //}
        }
        

       
    }
}

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
    public partial class frmBlockAdd : Form
    {
        DBADataContext db = new DBADataContext();
        int ZoneId = 0;

        public frmBlockAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int BlockNumber;

            if (ZoneId == 0)
            {
                MessageBox.Show("Please select a zone.");
                return;
            }

            try
            {
                BlockNumber = Convert.ToInt32(txtBlockNumber.Text.Trim());
            }
            catch
            {
                MessageBox.Show("A number greater than zero, is expected for Block Number.");
                return;
            }

            if (BlockNumber < 1)
            {
                MessageBox.Show("A number greater than zero, is expected for Block Number.");
                return;
            }

            if (txtBlockDescription.Text.Trim() == "")
            {
                MessageBox.Show("Block must have a description.");
                return;
            }

            Block ExistingBlock = (from a in db.Blocks
                                   where a.BlockNumber == BlockNumber
                                   select a).FirstOrDefault();

            if (ExistingBlock != null)
            {
                MessageBox.Show("Block Number already exists, please enter a different one.");
                return;
            }

            Block NewBlock = new Block
            {
                BlockNumber = BlockNumber,
                Name = BlockNumber.ToString(),
                Description = txtBlockDescription.Text.Trim(),
                ZoneId = ZoneId
            };

            db.Blocks.InsertOnSubmit(NewBlock);
            db.SubmitChanges();

            MessageBox.Show("Block Added.");

            frmDBAContainer NewContainer;
            NewContainer = (frmDBAContainer)this.Tag;

            frmBlock EditBlock = new frmBlock(BlockNumber);

            NewContainer.AddMDIChildForm(EditBlock);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBlockSelector SelectZone = new frmBlockSelector(SelectionType.Zone, true, true);
            SelectZone.ShowDialog();

            List<string> SelectedZones = SelectZone.SelectedGroups;

            if (SelectedZones.Count() == 0) return;

            string[] ZoneArray = SelectedZones[0].Split(Convert.ToChar("-"));

            Zone GetZone = (from a in db.Zones
                            where a.Name.Trim().ToUpper().Replace(" ","") == ZoneArray[1].Trim().ToUpper().Replace(" ","")
                            select a).FirstOrDefault();

            if (GetZone == null) return;

            ZoneId = GetZone.Id;

            linkZone.Text = GetZone.Name;


        }
    }
}

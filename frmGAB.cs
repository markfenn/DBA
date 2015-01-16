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
    public partial class frmGAB : Form
    {
        public frmGAB()
        {

            InitializeComponent();
            //CreateViewMenu(btnView);
        }

        public View[] gbValidViewValues = { View.Details, View.LargeIcon, View.SmallIcon };


        private void CreateVeiwMenu(ToolStripSplitButton btnView)
        {
            foreach (View item in gbValidViewValues)
            {
                ToolStripMenuItem tmp = new ToolStripMenuItem(item.ToString());
                tmp.Tag = item;
                tmp.DisplayStyle = ToolStripItemDisplayStyle.Text;
                btnView.DropDownItems.Add(tmp);
            }
        }

        private void btnView_ButtonClick(object sender, EventArgs e)
        {
            textBox1.Text = "DropDownItemClicked";

        }

        private void btnView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void btnView_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in (sender as ToolStripSplitButton).DropDownItems)
            {
                //item.Checked = (textBox1  = (View)item.Tag);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbA_Address1_Load(object sender, EventArgs e)
        {
            dbA_Address1.AddressId   = (int)22818;

        }




    }
}
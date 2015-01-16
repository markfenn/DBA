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
    public partial class dialogSimpleListBox : Form
    {
        public dialogSimpleListBox(string Title, List<string> DisplayList)
        {
            InitializeComponent();

            this.Text = Title;

            foreach (string Item in DisplayList)
            {
                lbList.Items.Add(Item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

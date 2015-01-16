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
    public partial class frmOneQuestionDialogBox : Form
    {
        public frmOneQuestionDialogBox()
        {
            InitializeComponent();
        }

        public String Question 
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public String Answer
        { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("You must enter some text first.");
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

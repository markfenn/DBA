using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace DowntownBoiseAssociation.Controls
{
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(DowntownBoiseAssociation.Classes.URIString))]
    public partial class editURI : UserControl, IPropertyUserInterface
    {
        public editURI()
        {
            InitializeComponent();
        }

        #region IPropertyUserInterface Members

        public int PropertyId { get; set; }

        public Type DataType { get; set; }

        public string Label
        {
            set
            {
                label1.Text = string.Format("{0}:", value);
            }
        }

        public string Value
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        #endregion

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Value.Length > 0)
                {
                    Uri uri = new Uri(Value);
                    WebRequest wr = WebRequest.Create(uri);
                    wr.GetResponse();
                }
                errorProvider1.SetError(textBox1, string.Empty);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                return;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.String))]
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Int32))]
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Single))]
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Double))]
    public partial class editString : UserControl, IPropertyUserInterface
    {
        public editString()
        {
            InitializeComponent();
        }

        #region IPropertyUserInterface Members

        public int PropertyId { get; set; }

        public Type DataType
        {
            get { return maskedTextBox1.ValidatingType; }
            set
            {
                foreach (PropertyEditor pe in this.GetType().GetCustomAttributes(typeof(PropertyEditor), false))
                {
                    if (value.Equals(pe.ForType))
                    {
                        maskedTextBox1.ValidatingType = value;
                    }
                }
            }
        }

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
                return maskedTextBox1.Text;
            }
            set
            {
                maskedTextBox1.Text = value;
            }
        }

        #endregion

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput || maskedTextBox1.Text.Length == 0)
            {
                errorProvider1.SetError(maskedTextBox1, string.Empty);
            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, string.Format("{0} Needs a {1}.", e.Message, e.ValidatingType.Name));
            }
        }
    }
}

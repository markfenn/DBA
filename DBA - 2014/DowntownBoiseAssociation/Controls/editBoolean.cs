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
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Boolean))]
    public partial class EditBoolean : UserControl, IPropertyUserInterface
    {
        public EditBoolean()
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
                label1.Text = string.Format("{0}:",value);
            }
        }

        public string Value
        {
            get
            {
                return rbYes.Checked.ToString();
            }
            set
            {
                Boolean _value;
                if (Boolean.TryParse(value, out _value))
                {
                    rbYes.Checked = _value;
                    rbNo.Checked = !_value;
                }
            }
        }

        #endregion
    }
}

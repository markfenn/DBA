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
    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Enum))]
    public partial class editClass : UserControl, IPropertyUserInterface
    {
        public editClass()
        {
            InitializeComponent();
        }

        #region IPropertyUserInterface Members

        public int PropertyId { get; set; }

        public string Label
        {
            set { label1.Text = value + ":"; }
        }

        public string Value
        {
            get
            {
                return comboBox1.SelectedValue.ToString();
            }
            set
            {
                if (value != null)
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (value.Equals(comboBox1.Items[i].ToString()))
                            comboBox1.SelectedIndex = i; 
                    }
            }
        }

        private Type _type;

        public Type DataType
        {
            get
            {
                return _type;
            }
            set
            {
                comboBox1.DataSource = System.Enum.GetValues(value);
                _type = value;
            }
        }

        #endregion
    }
}

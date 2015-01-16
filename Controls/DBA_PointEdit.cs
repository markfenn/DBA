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
    public partial class DBA_PointEdit : UserControl
    {
        public DBA_PointEdit()
        {
            InitializeComponent();
        }
        
        public int X
        {
            set { numX.Value = (decimal)value; }
            get { return (int) numX.Value; }
        }

        public int Y
        {
            set { numY.Value = (decimal)value; }
            get { return (int)numY.Value; }
        }

       
    }
}

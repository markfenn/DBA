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
    public partial class dialogImagePointEdit : Form
    {
        DowntownBoiseAssociation.DAL.RecordDef.ImagePoints _ImageObject;
        List<DowntownBoiseAssociation.Controls.DBA_PointEdit> PointList = new List<DowntownBoiseAssociation.Controls.DBA_PointEdit>();

        public dialogImagePointEdit(DowntownBoiseAssociation.DAL.RecordDef.ImagePoints ImageObject)
        {
            InitializeComponent();
            _ImageObject = ImageObject;
        }

        private void dialogImagePointEdit_Load(object sender, EventArgs e)
        {
            txtIdentifier.Text = _ImageObject.Identifier.ToString();
                       

            for (int x = 0; x < _ImageObject.Points.Count(); x++)
            {
                DowntownBoiseAssociation.Controls.DBA_PointEdit NewEdit = new DowntownBoiseAssociation.Controls.DBA_PointEdit();
                NewEdit.X = _ImageObject.Points[x].X;
                NewEdit.Y = _ImageObject.Points[x].Y;
                NewEdit.Left = 20;
                NewEdit.Top = 35 + (x * 23);
                PointList.Add(NewEdit);

                this.Controls.Add(PointList[x]);
                this.Height = 125 + (x * 23);
            }                   

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int TestInt = Convert.ToInt16(txtIdentifier.Text);

                if (TestInt <= 0) 
                {
                    MessageBox.Show("Value must be greater than zero.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Value must be an integer.");
                return;
            }


            _ImageObject.Identifier = Convert.ToInt16(txtIdentifier.Text);

            List<Point> NewList = new List<Point>();
            foreach (DowntownBoiseAssociation.Controls.DBA_PointEdit item in PointList)
            {
                NewList.Add(new Point(item.X, item.Y));
            }

            _ImageObject.Points = NewList.ToArray();

            this.DialogResult = DialogResult.OK;
        }

        public DowntownBoiseAssociation.DAL.RecordDef.ImagePoints Value
        {
            get { return _ImageObject; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult Msgbox = MessageBox.Show("Delete this Object?", "", MessageBoxButtons.YesNo);

            if (MessageBox.Show("Delete this Object?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            { return; }

            this.DialogResult = DialogResult.Abort;
        }
    }
}

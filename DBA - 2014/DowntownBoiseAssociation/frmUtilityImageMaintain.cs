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
    public partial class frmUtilityImageMaintain : Form
    {
        bool ListLoaded = false;
        bool CreateNewObject = false;
        bool ImageLoaded = false;
        private List<DAL.RecordDef.ImagePoints> ImageObject;
        private List<Point> NewObjectPoints = new List<Point>();

        private bool IsOverObject = false;

        private int ClickedObject = 0;
        private int ObjectOver = 0;

        private Pen Pn = new Pen(Color.Green, 5);
        private Pen Pn1 = new Pen(Color.GreenYellow, 8);
        private Pen Pn2 = new Pen(Color.Blue, 5);

        public frmUtilityImageMaintain()
        {
            InitializeComponent();
        }
        
        private void frmUtiltiyImageMaintain_Load(object sender, EventArgs e)
        {
            try
            {
                pbImage.BackgroundImage = Image.FromFile(DowntownBoiseAssociation.BLL.Registry.LoadProfile("UtilityImage"));
                ImageLoaded = true;
                pbImage.Width = pbImage.BackgroundImage.Width;
                pbImage.Height = pbImage.BackgroundImage.Height;
                cbCategory.Enabled = true;
                btnNewCategory.Enabled = true;
            }
            catch { }

            openFileDialog1.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            cbCategory.Items.Add("");
            foreach (string item in DowntownBoiseAssociation.BLL.ImagePoints.GetCategories())
            {
                cbCategory.Items.Add(item);
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("No image loaded.");
                return;
            }

            ImageLoaded = true;

            pbImage.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

            pbImage.Width = pbImage.BackgroundImage.Width;
            pbImage.Height = pbImage.BackgroundImage.Height;

            DowntownBoiseAssociation.BLL.Registry.SaveProfile("UtilityImage", openFileDialog1.FileName);
                        
            cbCategory.Enabled = true;
            btnNewCategory.Enabled = true;
        }

        private void btnLoadPoints_Click(object sender, EventArgs e)
        {
            if (!ImageLoaded)
            {
                MessageBox.Show("No image loaded.");
                return;
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ImageLoaded)
            {
                MessageBox.Show("No image loaded.");
                try
                {
                    ImageObject.Clear();
                }
                catch { }
                cbCategory.SelectedItem = 0;
                return;
            }

            if (cbCategory.SelectedIndex > 0)
            {
                ListLoaded = true;
                ImageObject = BLL.ImagePoints.GetObjects(cbCategory.SelectedItem.ToString());
                btnNewObject.Enabled = true;
                btnSavePoints.Enabled = true;
            }
            else
            {
                ListLoaded = false;
                ImageObject.Clear();
                btnNewObject.Enabled = false;
                btnSavePoints.Enabled = false;
            }
            pbImage.Refresh();
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            if (ImageObject == null) { return; }

            Graphics g = e.Graphics;            

            for (int y = 0; y < ImageObject.Count; y++)
            {
                g.DrawPolygon(Pn, ImageObject[y].Points);
            }

            if (CreateNewObject)
            {
                if (NewObjectPoints.Count == 1)
                {
                    g.DrawLine(Pn2, NewObjectPoints[0], NewObjectPoints[0]);
                }
                else
                {
                    for (int x = 0; x < NewObjectPoints.Count - 1; x++)
                    {
                        g.DrawLine(Pn2, NewObjectPoints[x], NewObjectPoints[x + 1]);
                    }
                }
            }
            else
            {
                if ((IsOverObject) && (ImageObject != null)) 
                {
                    try
                    {
                        g.DrawPolygon(Pn1, ImageObject[ObjectOver].Points);
                    }
                    catch { }
                }
            }
        }

        private void btnNewObject_Click(object sender, EventArgs e)
        {
            if (!ImageLoaded)
            {
                MessageBox.Show("No image loaded.");
                return;
            }

            if (CreateNewObject)
            {
                dialogText NewDialog = new dialogText("Please enter the Identifier for " + cbCategory.SelectedItem.ToString(), true, DialogValidate.IntegerOnly);
                NewDialog.ShowDialog();

                int NewIdentifier = Convert.ToInt16(NewDialog.ToString());
                
                System.Drawing.Drawing2D.GraphicsPath NewPath = new System.Drawing.Drawing2D.GraphicsPath();
                NewPath.AddPolygon(NewObjectPoints.ToArray());

                DowntownBoiseAssociation.DAL.RecordDef.ImagePoints NewObject = new DowntownBoiseAssociation.DAL.RecordDef.ImagePoints(
                    cbCategory.SelectedItem.ToString(), NewIdentifier, NewObjectPoints.ToArray(), NewPath);

                ImageObject.Add(NewObject);
                
                CreateNewObject = false;
                btnNewObject.Text = "Create New Object";
                NewObjectPoints.Clear();
                pbImage.Refresh();
            }
            else
            {
                CreateNewObject = true;
                btnNewObject.Text = "End New Object";
            }
        }
        
        private void pbImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreateNewObject)
            {
                Point NewPoint = new Point(e.X, e.Y);
                NewObjectPoints.Add(NewPoint);
                pbImage.Refresh();

                txtPoints.Text = "";
                for (int x = 0; x < NewObjectPoints.Count; x++)
                {
                    txtPoints.Text += x.ToString() + ": " + NewObjectPoints[x].X.ToString() + ", " + NewObjectPoints[x].Y.ToString() + "\r\n";
                }
            }
            else
            {
                if (IsOverObject)
                {
                    dialogImagePointEdit EditForm = new dialogImagePointEdit(ImageObject[ObjectOver]);
                    EditForm.ShowDialog();

                    if (EditForm.DialogResult == DialogResult.OK)
                    {
                        ImageObject[ObjectOver] = EditForm.Value;
                        pbImage.Refresh();
                    }

                    if (EditForm.DialogResult == DialogResult.Abort)
                    {
                        ImageObject.RemoveAt(ObjectOver);
                    }
                }
            }
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (CreateNewObject)
            {
                tipMouse.Show("x: " + e.X.ToString() + " y: " + e.Y.ToString(), pbImage, e.X + 13, e.Y + 10);
            }
            else
            {
                tipMouse.Hide(pbImage);

                if (ImageObject != null)
                {
                    txtPoints.Text = "Image Object Count: " + ImageObject.Count.ToString();

                    for (int x = 0; x < ImageObject.Count; x++)
                    {
                        DAL.RecordDef.ImagePoints Item = ImageObject[x];

                        if (ImageObject[x].Path.IsVisible(e.X, e.Y))
                        {
                            IsOverObject = true;
                            ObjectOver = x;
                            ClickedObject = Item.Identifier;
                            txtPoints.Text = x.ToString();
                            break;
                        }
                        else
                        {
                            IsOverObject = false;
                        }
                    }
                }
                pbImage.Refresh();
            }
        }
        
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            dialogText NewCategory = new dialogText("Enter a new Category Title", true, DialogValidate.Any);
            NewCategory.ShowDialog();

            if (NewCategory.DialogResult == DialogResult.OK)
            {
                foreach (object item in cbCategory.Items)
                {
                    if ((string)item == NewCategory.ToString().ToUpper().Trim())
                    {
                        MessageBox.Show("Category already exists, please enter another.");
                        return;
                    }
                }
                
                cbCategory.Items.Add(NewCategory.ToString().ToUpper().Trim());
                cbCategory.SelectedItem = NewCategory.ToString().ToUpper().Trim();
            }
        }

        private void btnSavePoints_Click(object sender, EventArgs e)
        {
            DBADataContext SaveContext = new DBADataContext();
            
            
            var t = from x in SaveContext.ImagePoints
                    where x.PointCategory == cbCategory.SelectedItem.ToString()
                    select x;

            SaveContext.ImagePoints.DeleteAllOnSubmit(t);

            foreach (DAL.RecordDef.ImagePoints item in ImageObject)
            {
                int Ord = 0;
                foreach (Point PointItem in item.Points)
                {
                    ImagePoint NewRecord = new ImagePoint
                    {
                        PointCategory = item.Category,
                        x = PointItem.X,
                        y = PointItem.Y,
                        PointIdentifier = item.Identifier,
                        PointOrder = Ord
                    };

                    SaveContext.ImagePoints.InsertOnSubmit(NewRecord);
                    Ord++;                    
                }
            }
            SaveContext.SubmitChanges();
        }       
    }
}

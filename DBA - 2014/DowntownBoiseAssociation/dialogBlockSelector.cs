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
    public partial class frmBlockSelector : Form
    {
        private bool _IsSingleClick = false;

        private List<DAL.RecordDef.ImagePoints> ImageObject;
        private List<int> ObjectsClicked = new List<int>();
        private List<string> GroupsClicked = new List<string>();

        private string ClickedGroup = "";
        private int ClickedObject = 0;
        private int ObjectOver = 0;

        private bool IsFinishedLoading = false;
        private bool IsOverObject = false;

        private Pen Pn = new Pen(Color.Green, 5);
        private Pen Pn1 = new Pen(Color.GreenYellow, 8);

        private SelectionType _SelectArea;
        private bool _IsGrouped = false;
          
        public frmBlockSelector(SelectionType SelectArea, bool IsSingleSelect, bool IsGrouped)
        {
            InitializeComponent();

            _SelectArea = SelectArea;
            _IsSingleClick = IsSingleSelect;
            _IsGrouped = IsGrouped;
        }

        private void frmBlockSelector_Load(object sender, EventArgs e)
        {
            if (_SelectArea == SelectionType.Zone)
            {
                ImageObject = BLL.ImagePoints.GetObjectsByRange(1000, 9999);
                this.Text = "Zone Selector";
            }
            else if (_SelectArea == SelectionType.Street)
            {
                ImageObject = BLL.ImagePoints.GetObjectsByRange(10000, 99999);
                this.Text = "Street Selector";
            }
            else
            {
                ImageObject = BLL.ImagePoints.GetObjectsByRange(0, 999);
                this.Text = "Block Selector";
            }
        }
        
        private void pbDBA_Click(object sender, EventArgs e)
        {
            if (IsOverObject)
            {
                if (IsSelected(ClickedObject)) 
                { 
                    SelectedRemove(ClickedObject);
                    SelectedGroupRemove(ClickedGroup);
                }
                else 
                { 
                    SelectedAdd(ClickedObject);
                    SelectedGroupAdd(ClickedGroup);
                }
            }
        }

        private void SelectedGroupAdd(string ObjectCategory)
        {
            if (_IsSingleClick) { GroupsClicked.Clear(); }

            GroupsClicked.Add(ObjectCategory);
        }

        private void SelectedGroupRemove(string ObjectCategory)
        {
            List<string> NewClickedList = new List<string>();

            foreach (string ObjStr in GroupsClicked)
            {
                if (ObjStr != ObjectCategory) { NewClickedList.Add(ObjStr); }
            }

            GroupsClicked = NewClickedList;
        }

        private void SelectedRemove(int ObjectIdentifier)
        {
            List<int> NewClickedList = new List<int>();
            DAL.RecordDef.ImagePoints IP = GetImagePoint(ObjectIdentifier);

            foreach (int ObjNo in ObjectsClicked)
            {
                if (ObjNo != ObjectIdentifier) 
                {
                    if (_IsGrouped)
                    {                        
                        DAL.RecordDef.ImagePoints cl = GetImagePoint(ObjNo);

                        if (IP.Category != cl.Category)
                        {
                            NewClickedList.Add(ObjNo);
                        }
                    }
                    else
                    {
                        NewClickedList.Add(ObjNo);
                    }
                }
            }

            ObjectsClicked = NewClickedList;            
        }

        private void SelectedAdd(int ObjectIdentifier)
        {
            if (_IsSingleClick) { ObjectsClicked.Clear(); }

            ObjectsClicked.Add(ObjectIdentifier);

            if (_IsGrouped)
            {
                DAL.RecordDef.ImagePoints IP = GetImagePoint(ObjectIdentifier);

                foreach (DAL.RecordDef.ImagePoints item in ImageObject)
                {
                    if ((item.Category == IP.Category) &&
                    (item.Identifier != ObjectIdentifier))
                    {
                        ObjectsClicked.Add(item.Identifier);
                    }
                }
            }
        }

        private DAL.RecordDef.ImagePoints GetImagePoint(int ObjectIdentifier)
        {
            foreach (DAL.RecordDef.ImagePoints item in ImageObject)
            {
                if (item.Identifier == ObjectIdentifier) { return item; }
            }

            return null;
        }

        private bool IsSelected(int ObjectIdentifier)
        {
            if (ObjectsClicked == null) { return false; }

            foreach (int x in ObjectsClicked)
            {
                if (x == ObjectIdentifier) { return true; }
            }

            return false;
        }

        private void pbDBA_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (IsOverObject) 
            { 
                g.DrawPolygon(Pn1, ImageObject[ObjectOver].Points);

                if (_IsGrouped)
                {
                    for (int x = 0; x < ImageObject.Count(); x++)
                    {
                        if (ImageObject[x].Category == ImageObject[ObjectOver].Category)
                        {
                            g.DrawPolygon(Pn1, ImageObject[x].Points);
                        }
                    }
                }
            }

            for (int x = 0; x < ObjectsClicked.Count(); x++)
            {
                for (int y = 0; y < ImageObject.Count(); y++)
                {
                    if (ImageObject[y].Identifier == ObjectsClicked[x]) { g.DrawPolygon(Pn, ImageObject[y].Points); }
                }
            }

            IsFinishedLoading = true;
        }

        private void pbDBA_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsFinishedLoading) { return; }

            for (int x = 0; x < ImageObject.Count; x++)
            {
                DAL.RecordDef.ImagePoints Item = ImageObject[x];

                if (ImageObject[x].Path.IsVisible(e.X, e.Y))
                {
                    IsOverObject = true;
                    ObjectOver = x;
                    ClickedObject = Item.Identifier;
                    ClickedGroup = Item.Category;
                    break;
                }
                else
                {
                    IsOverObject = false;
                }
            }
            pbDBA.Refresh();
        }

        public bool IsSingleClickOnly
        {
            set { _IsSingleClick = value; }
            get { return _IsSingleClick; }
        }

        public List<int> SelectedObjects
        {
            set { ObjectsClicked = value; }
            get { return ObjectsClicked; }
        }

        public List<string> SelectedGroups
        {
            get { return GroupsClicked; }
            set { GroupsClicked = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //dcBlockSelect.Equals(ObjectsClicked);
          // dcBlockSelect = DataSet(ObjectsClicked);
           

          //  dcBlockSelect = new DataSet("ObjectsClicked");
            
            this.DialogResult = DialogResult.OK;
        } 
    }

    public enum SelectionType
    { Zone = 0, Block, Street }
}

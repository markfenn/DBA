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
    public delegate void EnterEditModeEventHandler(object source, int CommentId);

    public partial class DBA_Comments : UserControl
    {
        public event EnterEditModeEventHandler EnterEditMode;

        DBADataContext dba = new DBADataContext();
        
        private int _commentID;
        private Boolean _adminMode = true;
        private String _details;
        private Guid _objectGuid = Guid.Empty;

        public DBA_Comments()
        {
            InitializeComponent();
            SetAdminMode();
        }

        public String Details
        {
            get { return tbxDetails.Text; }
        }
        
        public String Subject
        {
            get { return tbxSubject.Text; }
        }
        
        public int CommentID
        {
            get { return _commentID; }
            set
            {
                _commentID = value;
                LoadControl();
            }
        }

        public Guid ObjectGuid
        {
            set { _objectGuid = value; }
            get { return _objectGuid; }
        }

        public String CreateDateAsString
        {
            get
            {
                var theDate = from d in dba.Comments
                              where d.ID == CommentID
                              select d.CreatedDate;
                if (theDate == null)
                    return "";
                return theDate.ToString();
            }
        }
        public Boolean EditLinkVisible
        {
            get { return lbnEditComment.Visible; }
            set { lbnEditComment.Visible = value; }
        }
        public Boolean AdminMode
        {
            get { return _adminMode; }
            set
            {
                _adminMode = value;
                SetAdminMode();
            }
        }

        private void SetAdminMode()
        {
            if (AdminMode)
            {
                tbxSubject.ReadOnly = false;
                tbxDetails.ReadOnly = false;
            }
            else
            {
                tbxSubject.ReadOnly = true;
                tbxDetails.ReadOnly = true;
            }
        }

        protected void lbnEditComment_Click(object sender, EventArgs e)
        {
            lbnEditComment.Visible = false;
            AdminMode = true;

            EnterEditMode(this,CommentID);
        }

        private void LoadControl()
        {
            AdminMode = false;
            EditLinkVisible = true;

            Comment data = (from d in dba.Comments
                           where d.ID == CommentID
                           select d).FirstOrDefault();
            if (data == null)
            {
                tbxSubject.Text = "";
                tbxDetails.Text = "";
                return;
            }
            tbxSubject.Text = data.Subject;
            _details = data.Details;
            tbxDetails.Text = _details;
        }

        public void Save()
        {
            if (ObjectGuid.Equals(Guid.Empty))
            {
                MessageBox.Show("Error in programming code: No ObjectGuid found.\n\n No save made.");
                return;
            }

            if (CommentID <= 0)
            {
                Comment commentInfo = new Comment
                {
                    ObjectGuid = _objectGuid,
                    Subject = tbxSubject.Text.Trim(),
                    Details = tbxDetails.Text.Trim(),
                    CreatedDate = DateTime.Now,
                    UserID = SystemInformation.UserName
                };

                dba.Comments.InsertOnSubmit(commentInfo);
                dba.SubmitChanges();
                CommentID = commentInfo.ID;
            }
            else
            {
                Comment Data = (from d in dba.Comments
                               where d.ID == CommentID
                               select d).FirstOrDefault();
                Data.Subject = tbxSubject.Text;
                if (!String.IsNullOrEmpty(tbxDetails.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(_details.Trim()) && !_details.Equals(tbxDetails))
                        Data.Details = tbxDetails.Text.Trim() + "\n\n" + Data.CreatedDate.ToString() +
                                "\t" + Data.UserID + "\n" + _details.Trim();
                    else
                        Data.Details = tbxDetails.Text.Trim();
                }
                else
                    Data.Details = Data.CreatedDate.ToString() +
                                "\t" + Data.UserID + "\n" + _details.Trim();
                Data.CreatedDate = DateTime.Now;
                Data.UserID = SystemInformation.UserName;

                dba.SubmitChanges();
            }
        }
    }
}

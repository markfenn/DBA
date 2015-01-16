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
    public partial class frmUtilityCommentMaintain : Form
    {
        DBADataContext dba = new DBADataContext();

        private int _currentViewedCommentID = -1;
        private int _indexViewedComment = -1;
        private Guid _objectGuid;
        private Comment[] _comments;
        private Comment _Comment;

        public frmUtilityCommentMaintain(Guid GUID)
        {
            InitializeComponent();

            _objectGuid = GUID;

            dbA_Comments1.ObjectGuid = _objectGuid;
            //LoadGuid();
        }

        public Guid ObjectGuid
        {
            get { return _objectGuid; }
            //set
            //{
            //    _currentViewedCommentID = -1;
            //    _indexViewedComment = -1;
            //    _objectGuid = value;
                
            //}
        }
        public int ViewCommentID
        {
            get { return _currentViewedCommentID; }
            set 
            { 
                _currentViewedCommentID = value;
                //if(!ObjectGuid.Equals(Guid.Empty))
                LoadViewingComment();
            }
        }
        public Boolean EditButtonsVisible
        {
            get { return btnNewComment.Visible; }
            set
            {
                btnNewComment.Visible = value;
                btnDelete.Visible = value;
                lbnNext.Visible = value;
                lbnPrevious.Visible = value;

                btnAccept.Visible = !value;
                SetFormForEditOrNewMode();
            }
        }

        private void SetFormForEditOrNewMode()
        {
            if (EditButtonsVisible)
            {
                dbA_Comments1.EditLinkVisible = true;
                dbA_Comments1.AdminMode = false;
                LoadViewingComment();
            }
            else
            {
                dbA_Comments1.EditLinkVisible = false;
                dbA_Comments1.AdminMode = true;
                lblCommentNumberOutOf.Text = "Creating / Editing";
            }
        }

        private void LoadViewingComment()
        {
            LoadGuid();

            Comment _Comment = (from a in dba.Comments
                                where a.ID == ViewCommentID
                                select a).FirstOrDefault();

            if (_Comment != null)
            {            
                tbxCreator.Text = _Comment.UserID;
                tbxCreatedDate.Text = DateTime.Now.ToString();
                dbA_Comments1.CommentID = _Comment.ID;
            }







            //if (_comments == null || _comments.Length == 0)
            //    return;

            //for (int i = 0; i < _comments.Length; i++)
            //{
            //    if (_comments[i].ID == _currentViewedCommentID)
            //    {
            //        dbA_Comments1.CommentID = _comments[i].ID;
            //        _indexViewedComment = i;
            //        lblCommentNumberOutOf.Text = String.Format("{0} of {1}", i + 1, _comments.Length);
            //        tbxCreator.Text = _comments[i].UserID;
            //        tbxCreatedDate.Text = _comments[i].CreatedDate.ToString();
            //        if (_comments.Length > 1)
            //        {
            //            if (_indexViewedComment > 0)
            //                lbnPrevious.Visible = true;
            //            else
            //                lbnPrevious.Visible = false;
            //            if (_indexViewedComment < _comments.Length - 1)
            //                lbnNext.Visible = true;
            //            else
            //                lbnNext.Visible = false;
            //        }
            //        else
            //        {
            //            lbnPrevious.Visible = false;
            //            lbnNext.Visible = false;
            //        }
            //        return;
            //    }
            //}
            //_indexViewedComment = 0;
            //_currentViewedCommentID = _comments[_indexViewedComment].ID;
            //dbA_Comments1.CommentID = _currentViewedCommentID;
            //lblCommentNumberOutOf.Text = String.Format("{0} of {1}", _indexViewedComment + 1, _comments.Length);
            //tbxCreator.Text = _comments[_indexViewedComment].UserID;
            //tbxCreatedDate.Text = _comments[_indexViewedComment].CreatedDate.ToString();
            //if (_comments.Length > 1)
            //{
            //    lbnNext.Visible = true;
            //    lbnPrevious.Visible = false;
            //}
            //else
            //{
            //    lbnNext.Visible = false;
            //    lbnPrevious.Visible = false;
            //}
        }

        private void LoadGuid()
        {
            

            //var Data = from c in dba.Comments
            //           where c.ObjectGuid == _objectGuid
            //           orderby c.CreatedDate descending
            //           select c;
            //_comments = new Comment[Data.Count()];
            //int index = 0;
            //foreach (Comment d in Data)
            //{
            //    _comments[index] = (Comment)d;
            //    index++;
            //}

            //if (_comments == null || _comments.Length == 0)
            //{
            //    _indexViewedComment = -1;
            //    _currentViewedCommentID = -1;
            //    dbA_Comments1.CommentID = _currentViewedCommentID;
            //    lblCommentNumberOutOf.Text = String.Format("{0} of {1}", _indexViewedComment + 1, _comments.Length);
            //    tbxCreator.Text = "";
            //    tbxCreatedDate.Text = "";
            //    EditButtonsVisible = false;
            //    return;
            //}

            //if (_currentViewedCommentID < 0)
            //{
            //    _indexViewedComment = 0;
            //    _currentViewedCommentID = _comments[_indexViewedComment].ID;
            //    dbA_Comments1.CommentID = _currentViewedCommentID;
            //    lblCommentNumberOutOf.Text = String.Format("{0} of {1}", _indexViewedComment + 1, _comments.Length);
            //    tbxCreator.Text = _comments[_indexViewedComment].UserID;
            //    tbxCreatedDate.Text = _comments[_indexViewedComment].CreatedDate.ToString();
            //    if (_comments.Length > 1)
            //    {
            //        lbnNext.Visible = true;
            //        lbnPrevious.Visible = false;
            //    }
            //    else
            //    {
            //        lbnNext.Visible = false;
            //        lbnPrevious.Visible = false;
            //    }
            //}
        }

        private void dbA_Comments1_Load(object sender, EventArgs e)
        {
            dbA_Comments1.EnterEditMode += new DowntownBoiseAssociation.Controls.EnterEditModeEventHandler(dbA_Comments1_EnterEditMode);
        }

        protected void dbA_Comments1_EnterEditMode(object source, int CommentId)
        {
            EditButtonsVisible = false;
        }

        private void lbnPrevious_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _comments.Length; i++)
            {
                if (i == _indexViewedComment - 1)
                {
                    _currentViewedCommentID = _comments[i].ID;
                    dbA_Comments1.CommentID = _currentViewedCommentID;
                    _indexViewedComment = i;
                    lblCommentNumberOutOf.Text = String.Format("{0} of {1}", i + 1, _comments.Length);
                    tbxCreator.Text = _comments[i].UserID;
                    tbxCreatedDate.Text = _comments[i].CreatedDate.ToString();
                    if (_indexViewedComment <= 0)
                        lbnPrevious.Visible = false;
                    if (_indexViewedComment < _comments.Length - 1)
                        lbnNext.Visible = true;
                    else
                        lbnNext.Visible = false;
                    return;
                }
            }
        }

        private void lbnNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _comments.Length; i++)
            {
                if (i == _indexViewedComment + 1)
                {
                    _currentViewedCommentID = _comments[i].ID;
                    dbA_Comments1.CommentID = _currentViewedCommentID;
                    _indexViewedComment = i;
                    lblCommentNumberOutOf.Text = String.Format("{0} of {1}", i + 1, _comments.Length);
                    tbxCreator.Text = _comments[i].UserID;
                    tbxCreatedDate.Text = _comments[i].CreatedDate.ToString();
                    if (_indexViewedComment >= _comments.Length - 1)
                        lbnNext.Visible = false;
                    if (_indexViewedComment > 0)
                        lbnPrevious.Visible = true;
                    else
                        lbnPrevious.Visible = false;
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (EditButtonsVisible)
            //{
                DialogResult = DialogResult.Cancel;
                this.Close();
            //}
            //else
            //{
            //    if (_comments == null || _comments.Length <= 0)
            //    {
            //        DialogResult = DialogResult.Cancel;
            //        this.Close();
            //    }
            //    EditButtonsVisible = true;
            //}
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                dbA_Comments1.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comment Error: " + ex.Message);
                return;
            }

            //_currentViewedCommentID = dbA_Comments1.CommentID;
            //EditButtonsVisible = true;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNewComment_Click(object sender, EventArgs e)
        {
            SetForNewComment();
        }

        public void SetForNewComment()
        {
            EditButtonsVisible = false;
            dbA_Comments1.CommentID = 0;
            tbxCreator.Text = "";
            tbxCreatedDate.Text = "";
            dbA_Comments1.EditLinkVisible = false;
            dbA_Comments1.AdminMode = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var delComment = (from a in dba.Comments
                                  where a.ID == _currentViewedCommentID
                                  select a).FirstOrDefault();

                dba.Comments.DeleteOnSubmit(delComment);
                dba.SubmitChanges();


                _indexViewedComment = -1;
                _currentViewedCommentID = -1;
                LoadGuid();
            }
        }


    }
}

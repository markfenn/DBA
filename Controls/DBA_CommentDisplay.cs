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
    public partial class DBA_CommentDisplay : UserControl
    {
        private Guid _GUID;
        private DBADataContext dba = new DBADataContext();


        public DBA_CommentDisplay()
        {
            InitializeComponent();
            
            lvwComments.Columns.Add("Subject", 150, HorizontalAlignment.Left);
            lvwComments.Columns.Add("Author", 150, HorizontalAlignment.Left);
            lvwComments.Columns.Add("CreateDate", 100, HorizontalAlignment.Center);
            lvwComments.View = View.Details;
            lvwComments.AllowColumnReorder = true;            
        }

        public Guid ObjectGuid
        {
            set 
            { 
                _GUID = value;
                SetupComments();
            }
            get { return _GUID; }
        }

        private void SetupComments()
        {
            loadCommentsList();
        }

        private void loadCommentsList()
        {
            dba = new DBADataContext();
            var commentData = from d in dba.Comments
                              where d.ObjectGuid == _GUID
                              orderby d.CreatedDate descending
                              select d;

            lvwComments.Items.Clear();
            tbxCommentsDetails.Text = "";
            lvwComments.BeginUpdate();

            ListViewItem reportListItem;
            foreach (Comment c in commentData)
            {
                reportListItem = new ListViewItem();
                reportListItem.Text = c.Subject;
                reportListItem.Tag = c.ID;
                reportListItem.SubItems.Add(c.UserID);
                reportListItem.SubItems.Add(c.CreatedDate.ToString());
                lvwComments.Items.Add(reportListItem);
            }
            lvwComments.EndUpdate();
        }

        private void btnCommentDelete_Click(object sender, EventArgs e)
        {
            if (lvwComments.Items.Count > 0 && lvwComments.FocusedItem != null)
            {
                if (MessageBox.Show("Delete " + lvwComments.FocusedItem.SubItems[0].ToString() + " ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var delComment = (from a in dba.Comments
                                      where a.ID == (int)lvwComments.FocusedItem.Tag
                                      select a).FirstOrDefault();

                    dba.Comments.DeleteOnSubmit(delComment);
                    dba.SubmitChanges();

                    loadCommentsList();
                }
            }
            else
                MessageBox.Show("You must enter a search value.");
        }

        private void btnCommentNewEdit_Click(object sender, EventArgs e)
        {
            frmUtilityCommentMaintain newForm = new frmUtilityCommentMaintain(_GUID);
            //newForm.ObjectGuid = _GUID;
            //if (lvwComments.Items.Count > 0 && lvwComments.FocusedItem != null)
            //{
            //    newForm.ViewCommentID = (int)lvwComments.FocusedItem.Tag;
            //    newForm.EditButtonsVisible = false;
            //}
            //else
            newForm.SetForNewComment();
            newForm.ShowDialog();

            if (newForm.DialogResult == DialogResult.OK)
            {
            }
            loadCommentsList();
        }

        private void lvwComments_Click(object sender, EventArgs e)
        {
            if (lvwComments.Items.Count > 0 && lvwComments.FocusedItem != null)
            {
                Comment data = (from d in dba.Comments
                                where d.ID == (int)lvwComments.FocusedItem.Tag
                                select d).FirstOrDefault();

                tbxCommentsDetails.Text = data.Details;
            }
        }

        private void lvwComments_DoubleClick(object sender, EventArgs e)
        {
            if (lvwComments.Items.Count > 0 && lvwComments.FocusedItem != null)
            {
                frmUtilityCommentMaintain newForm = new frmUtilityCommentMaintain(_GUID);
                //newForm.ObjectGuid = _GUID;
                newForm.ViewCommentID = (int)lvwComments.FocusedItem.Tag;
                newForm.EditButtonsVisible = false;
                newForm.ShowDialog();
                              
                loadCommentsList();
            }
        }      
    }
}

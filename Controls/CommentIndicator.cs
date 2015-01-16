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
    public partial class CommentIndicator : UserControl
    {
        private DBADataContext dba = new DBADataContext();

        private Guid _objectGuid = Guid.Empty;
        private String _indicatorColor = "Red";
        private String _indicatorOtherColor = "LightGray";
        private Boolean timerRunning = false;
        private Boolean timerFlag = true;

        public CommentIndicator()
        {
            InitializeComponent();
        }

        public String IndicatorColor
        {
            get { return _indicatorColor; }
            set
            {
                if (!Color.FromName(value).IsEmpty)
                    _indicatorColor = value;
            }
        }
        public String IndicatorOtherColor
        {
            get { return _indicatorOtherColor; }
            set
            {
                if (!Color.FromName(value).IsEmpty)
                    _indicatorOtherColor = value;
            }
        }
        public Guid ObjectGuid
        {
            set 
            { 
                _objectGuid = value;
                StartIndicator();
            }
            get { return _objectGuid; }
        }

        private void StartIndicator()
        {
            if (timerRunning)
            {
                flashTimer.Stop();
                timerRunning = false;
            }

            var Data = from c in dba.Comments
                       where c.ObjectGuid == _objectGuid
                       orderby c.CreatedDate descending
                       select c;

            if (Data.FirstOrDefault() != null)
            {
                flashTimer.Interval = 5000; // 5 seconds (1 sec = 1000 millisec.)
                flashTimer.Start();
                timerRunning = true;
                SetFlash();
            }
            else
            {
                if (timerRunning)
                    flashTimer.Stop();
                timerRunning = false;
                timerFlag = true;
                btnFlasher.BackColor = Color.White;
                btnFlasher.ForeColor = Color.White;
            }
        }

        private void flashTimer_Tick(object sender, System.EventArgs e)
        {
            SetFlash();
        }

        protected void SetFlash()
        {
            flashTimer.Stop();
            if (timerFlag)
            {
                btnFlasher.BackColor = Color.FromName(IndicatorOtherColor);
                btnFlasher.ForeColor = Color.FromName(IndicatorOtherColor);
                timerFlag = false;
                flashTimer.Interval = 4000; // 4 seconds
                flashTimer.Start();
            }
            else
            {
                btnFlasher.BackColor = Color.FromName(IndicatorColor);
                btnFlasher.ForeColor = Color.FromName(IndicatorColor);
                timerFlag = true;
                flashTimer.Interval = 5000; // 5 seconds
                flashTimer.Start();
            }
        }

        private void btnFlasher_MouseHover(object sender, EventArgs e)
        {
            // Show a tool tip of most current comment.

            ToolTip toolTip = new ToolTip();
            Comment Data = (from c in dba.Comments
                            where c.ObjectGuid == _objectGuid
                            orderby c.CreatedDate descending
                            select c).FirstOrDefault();
            if (Data == null)
            {
                toolTip.SetToolTip(btnFlasher, "Click this button to Create a new Comment.");
            }
            else
            {
                toolTip.SetToolTip(btnFlasher, String.Format("Name: {0}     Date: {1}\n" +
                        "{2}\n\nClick this button to View and Create Comments.",
                        Data.UserID, Data.CreatedDate, Data.Subject));
            }
        }

        private void btnFlasher_Click(object sender, EventArgs e)
        {
            // TODO: bring up creation and paging window.

            frmUtilityCommentMaintain newForm = new frmUtilityCommentMaintain(_objectGuid);
            //newForm.ObjectGuid = ObjectGuid;
            newForm.ShowDialog();

            if (newForm.DialogResult == DialogResult.OK)
            {
            }

                StartIndicator();
        }
    }
}

namespace DowntownBoiseAssociation
{
    partial class frmUtilityCommentMaintain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreator = new System.Windows.Forms.Label();
            this.tbxCreator = new System.Windows.Forms.TextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.tbxCreatedDate = new System.Windows.Forms.TextBox();
            this.lbnPrevious = new System.Windows.Forms.LinkLabel();
            this.lbnNext = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCommentNumberOutOf = new System.Windows.Forms.Label();
            this.btnNewComment = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dbA_Comments1 = new DowntownBoiseAssociation.Controls.DBA_Comments();
            this.SuspendLayout();
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.BackColor = System.Drawing.Color.Transparent;
            this.lblCreator.Location = new System.Drawing.Point(9, 14);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(41, 13);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "Creator";
            // 
            // tbxCreator
            // 
            this.tbxCreator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCreator.Location = new System.Drawing.Point(65, 11);
            this.tbxCreator.Name = "tbxCreator";
            this.tbxCreator.ReadOnly = true;
            this.tbxCreator.Size = new System.Drawing.Size(158, 20);
            this.tbxCreator.TabIndex = 10;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedDate.Location = new System.Drawing.Point(258, 14);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(30, 13);
            this.lblCreatedDate.TabIndex = 3;
            this.lblCreatedDate.Text = "Date";
            // 
            // tbxCreatedDate
            // 
            this.tbxCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCreatedDate.Location = new System.Drawing.Point(298, 11);
            this.tbxCreatedDate.Name = "tbxCreatedDate";
            this.tbxCreatedDate.ReadOnly = true;
            this.tbxCreatedDate.Size = new System.Drawing.Size(110, 20);
            this.tbxCreatedDate.TabIndex = 11;
            // 
            // lbnPrevious
            // 
            this.lbnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbnPrevious.AutoSize = true;
            this.lbnPrevious.Image = global::DowntownBoiseAssociation.Properties.Resources.leftArrow;
            this.lbnPrevious.Location = new System.Drawing.Point(10, 189);
            this.lbnPrevious.MinimumSize = new System.Drawing.Size(18, 20);
            this.lbnPrevious.Name = "lbnPrevious";
            this.lbnPrevious.Size = new System.Drawing.Size(18, 20);
            this.lbnPrevious.TabIndex = 2;
            this.lbnPrevious.Visible = false;
            this.lbnPrevious.Click += new System.EventHandler(this.lbnPrevious_Click);
            // 
            // lbnNext
            // 
            this.lbnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnNext.AutoSize = true;
            this.lbnNext.Image = global::DowntownBoiseAssociation.Properties.Resources.rightArrow;
            this.lbnNext.Location = new System.Drawing.Point(187, 189);
            this.lbnNext.MinimumSize = new System.Drawing.Size(18, 20);
            this.lbnNext.Name = "lbnNext";
            this.lbnNext.Size = new System.Drawing.Size(18, 20);
            this.lbnNext.TabIndex = 7;
            this.lbnNext.Visible = false;
            this.lbnNext.Click += new System.EventHandler(this.lbnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCommentNumberOutOf
            // 
            this.lblCommentNumberOutOf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCommentNumberOutOf.AutoSize = true;
            this.lblCommentNumberOutOf.Location = new System.Drawing.Point(209, 189);
            this.lblCommentNumberOutOf.Name = "lblCommentNumberOutOf";
            this.lblCommentNumberOutOf.Size = new System.Drawing.Size(34, 13);
            this.lblCommentNumberOutOf.TabIndex = 8;
            this.lblCommentNumberOutOf.Text = "0 of 0";
            this.lblCommentNumberOutOf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCommentNumberOutOf.Visible = false;
            // 
            // btnNewComment
            // 
            this.btnNewComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewComment.Location = new System.Drawing.Point(45, 186);
            this.btnNewComment.Name = "btnNewComment";
            this.btnNewComment.Size = new System.Drawing.Size(75, 23);
            this.btnNewComment.TabIndex = 3;
            this.btnNewComment.Text = "Add &New";
            this.btnNewComment.UseVisualStyleBackColor = true;
            this.btnNewComment.Visible = false;
            this.btnNewComment.Click += new System.EventHandler(this.btnNewComment_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(126, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(329, 186);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dbA_Comments1
            // 
            this.dbA_Comments1.AdminMode = false;
            this.dbA_Comments1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dbA_Comments1.BackColor = System.Drawing.Color.Transparent;
            this.dbA_Comments1.CommentID = 0;
            this.dbA_Comments1.EditLinkVisible = false;
            this.dbA_Comments1.Location = new System.Drawing.Point(0, 27);
            this.dbA_Comments1.MinimumSize = new System.Drawing.Size(420, 140);
            this.dbA_Comments1.Name = "dbA_Comments1";
            this.dbA_Comments1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.dbA_Comments1.Size = new System.Drawing.Size(420, 153);
            this.dbA_Comments1.TabIndex = 1;
            this.dbA_Comments1.Load += new System.EventHandler(this.dbA_Comments1_Load);
            // 
            // frmUtilityCommentMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(426, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewComment);
            this.Controls.Add(this.lblCommentNumberOutOf);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbnNext);
            this.Controls.Add(this.lbnPrevious);
            this.Controls.Add(this.tbxCreatedDate);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.tbxCreator);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.dbA_Comments1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilityCommentMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comment Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DowntownBoiseAssociation.Controls.DBA_Comments dbA_Comments1;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox tbxCreator;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.TextBox tbxCreatedDate;
        private System.Windows.Forms.LinkLabel lbnPrevious;
        private System.Windows.Forms.LinkLabel lbnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCommentNumberOutOf;
        private System.Windows.Forms.Button btnNewComment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAccept;

    }
}
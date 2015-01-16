namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_CommentDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommentDelete = new System.Windows.Forms.Button();
            this.btnCommentNewEdit = new System.Windows.Forms.Button();
            this.lvwComments = new System.Windows.Forms.ListView();
            this.tbxCommentsDetails = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommentDelete
            // 
            this.btnCommentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCommentDelete.Location = new System.Drawing.Point(3, 276);
            this.btnCommentDelete.Name = "btnCommentDelete";
            this.btnCommentDelete.Size = new System.Drawing.Size(105, 23);
            this.btnCommentDelete.TabIndex = 8;
            this.btnCommentDelete.Text = "Delete Comment";
            this.btnCommentDelete.UseVisualStyleBackColor = true;
            this.btnCommentDelete.Click += new System.EventHandler(this.btnCommentDelete_Click);
            // 
            // btnCommentNewEdit
            // 
            this.btnCommentNewEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommentNewEdit.Location = new System.Drawing.Point(218, 276);
            this.btnCommentNewEdit.Name = "btnCommentNewEdit";
            this.btnCommentNewEdit.Size = new System.Drawing.Size(104, 23);
            this.btnCommentNewEdit.TabIndex = 7;
            this.btnCommentNewEdit.Text = "Add Comment";
            this.btnCommentNewEdit.UseVisualStyleBackColor = true;
            this.btnCommentNewEdit.Click += new System.EventHandler(this.btnCommentNewEdit_Click);
            // 
            // lvwComments
            // 
            this.lvwComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwComments.FullRowSelect = true;
            this.lvwComments.Location = new System.Drawing.Point(3, 3);
            this.lvwComments.Name = "lvwComments";
            this.lvwComments.Size = new System.Drawing.Size(322, 140);
            this.lvwComments.TabIndex = 5;
            this.lvwComments.UseCompatibleStateImageBehavior = false;
            this.lvwComments.View = System.Windows.Forms.View.Details;
            this.lvwComments.DoubleClick += new System.EventHandler(this.lvwComments_DoubleClick);
            this.lvwComments.Click += new System.EventHandler(this.lvwComments_Click);
            // 
            // tbxCommentsDetails
            // 
            this.tbxCommentsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCommentsDetails.BackColor = System.Drawing.Color.White;
            this.tbxCommentsDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCommentsDetails.Location = new System.Drawing.Point(3, 3);
            this.tbxCommentsDetails.Name = "tbxCommentsDetails";
            this.tbxCommentsDetails.ReadOnly = true;
            this.tbxCommentsDetails.Size = new System.Drawing.Size(314, 112);
            this.tbxCommentsDetails.TabIndex = 9;
            this.tbxCommentsDetails.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbxCommentsDetails);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 120);
            this.panel1.TabIndex = 10;
            // 
            // DBA_CommentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCommentDelete);
            this.Controls.Add(this.btnCommentNewEdit);
            this.Controls.Add(this.lvwComments);
            this.Name = "DBA_CommentDisplay";
            this.Size = new System.Drawing.Size(328, 302);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommentDelete;
        private System.Windows.Forms.Button btnCommentNewEdit;
        private System.Windows.Forms.ListView lvwComments;
        private System.Windows.Forms.RichTextBox tbxCommentsDetails;
        private System.Windows.Forms.Panel panel1;
    }
}

namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_Comments
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnEditComment = new System.Windows.Forms.LinkLabel();
            this.tbxDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // tbxSubject
            // 
            this.tbxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSubject.Location = new System.Drawing.Point(65, 7);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(343, 20);
            this.tbxSubject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Details";
            // 
            // lbnEditComment
            // 
            this.lbnEditComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnEditComment.AutoSize = true;
            this.lbnEditComment.Location = new System.Drawing.Point(9, 58);
            this.lbnEditComment.Name = "lbnEditComment";
            this.lbnEditComment.Size = new System.Drawing.Size(72, 13);
            this.lbnEditComment.TabIndex = 3;
            this.lbnEditComment.TabStop = true;
            this.lbnEditComment.Text = "Edit Comment";
            this.lbnEditComment.Visible = false;
            this.lbnEditComment.Click += new System.EventHandler(this.lbnEditComment_Click);
            // 
            // tbxDetails
            // 
            this.tbxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDetails.Location = new System.Drawing.Point(65, 33);
            this.tbxDetails.Name = "tbxDetails";
            this.tbxDetails.Size = new System.Drawing.Size(343, 117);
            this.tbxDetails.TabIndex = 8;
            this.tbxDetails.Text = "";
            // 
            // DBA_Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbxDetails);
            this.Controls.Add(this.lbnEditComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(420, 140);
            this.Name = "DBA_Comments";
            this.Size = new System.Drawing.Size(420, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbnEditComment;
        private System.Windows.Forms.RichTextBox tbxDetails;
    }
}

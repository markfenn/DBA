﻿namespace DowntownBoiseAssociation.Controls
{
    partial class editProperties
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
            this.flowEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowEdit
            // 
            this.flowEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowEdit.AutoScroll = true;
            this.flowEdit.Location = new System.Drawing.Point(3, 3);
            this.flowEdit.Name = "flowEdit";
            this.flowEdit.Size = new System.Drawing.Size(321, 181);
            this.flowEdit.TabIndex = 0;
            // 
            // editProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowEdit);
            this.Name = "editProperties";
            this.Size = new System.Drawing.Size(327, 187);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowEdit;

    }
}

namespace DowntownBoiseAssociation
{
    partial class frmUtilityContactMaintain
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.contactEdit = new DowntownBoiseAssociation.Controls.DBA_Contact();
            this.dbA_Contact1 = new DowntownBoiseAssociation.Controls.DBA_Contact();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(374, 155);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // contactEdit
            // 
            this.contactEdit.AddressId = 0;
            this.contactEdit.BackColor = System.Drawing.Color.Transparent;
            this.contactEdit.ContactId = 0;
            this.contactEdit.IsCreateContactLinkVisible = false;
            this.contactEdit.Location = new System.Drawing.Point(13, 13);
            this.contactEdit.Name = "contactEdit";
            this.contactEdit.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.contactEdit.Size = new System.Drawing.Size(456, 141);
            this.contactEdit.TabIndex = 0;
            this.contactEdit.Load += new System.EventHandler(this.contactEdit_Load);
            // 
            // dbA_Contact1
            // 
            this.dbA_Contact1.AddressId = 0;
            this.dbA_Contact1.BackColor = System.Drawing.Color.Transparent;
            this.dbA_Contact1.ContactId = 0;
            this.dbA_Contact1.IsCreateContactLinkVisible = true;
            this.dbA_Contact1.Location = new System.Drawing.Point(13, 13);
            this.dbA_Contact1.Name = "dbA_Contact1";
            this.dbA_Contact1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.dbA_Contact1.Size = new System.Drawing.Size(451, 141);
            this.dbA_Contact1.TabIndex = 4;
            this.dbA_Contact1.Load += new System.EventHandler(this.dbA_Contact1_Load);
            // 
            // frmUtilityContactMaintain
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(474, 185);
            this.ControlBox = false;
            this.Controls.Add(this.dbA_Contact1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUtilityContactMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Maintenance";
            this.Load += new System.EventHandler(this.frmUtilityContactMaintain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DowntownBoiseAssociation.Controls.DBA_Contact contactEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private Controls.DBA_Contact dbA_Contact1;
    }
}
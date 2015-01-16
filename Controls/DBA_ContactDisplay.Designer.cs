namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_ContactDisplay
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
            this.gbxContacts = new System.Windows.Forms.GroupBox();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.gbxContactInformation = new System.Windows.Forms.GroupBox();
            this.dbA_Contact1 = new DowntownBoiseAssociation.Controls.DBA_Contact();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxContacts.SuspendLayout();
            this.gbxContactInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContacts
            // 
            this.gbxContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxContacts.Controls.Add(this.lbContacts);
            this.gbxContacts.Location = new System.Drawing.Point(3, 3);
            this.gbxContacts.Name = "gbxContacts";
            this.gbxContacts.Size = new System.Drawing.Size(480, 77);
            this.gbxContacts.TabIndex = 3;
            this.gbxContacts.TabStop = false;
            this.gbxContacts.Text = "Contacts";
            // 
            // lbContacts
            // 
            this.lbContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.Location = new System.Drawing.Point(7, 20);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(467, 43);
            this.lbContacts.TabIndex = 0;
            this.lbContacts.Click += new System.EventHandler(this.lbContacts_Click);
            // 
            // gbxContactInformation
            // 
            this.gbxContactInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxContactInformation.Controls.Add(this.dbA_Contact1);
            this.gbxContactInformation.Location = new System.Drawing.Point(3, 86);
            this.gbxContactInformation.Name = "gbxContactInformation";
            this.gbxContactInformation.Size = new System.Drawing.Size(480, 160);
            this.gbxContactInformation.TabIndex = 2;
            this.gbxContactInformation.TabStop = false;
            this.gbxContactInformation.Text = "Information";
            // 
            // dbA_Contact1
            // 
            this.dbA_Contact1.AddressId = 0;
            this.dbA_Contact1.BackColor = System.Drawing.Color.Transparent;
            this.dbA_Contact1.ContactId = 0;
            this.dbA_Contact1.IsCreateContactLinkVisible = false;
            this.dbA_Contact1.Location = new System.Drawing.Point(7, 16);
            this.dbA_Contact1.Name = "dbA_Contact1";
            this.dbA_Contact1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.dbA_Contact1.Size = new System.Drawing.Size(467, 139);
            this.dbA_Contact1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(407, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditContact.Location = new System.Drawing.Point(326, 249);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 23);
            this.btnEditContact.TabIndex = 2;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(3, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DBA_ContactDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.gbxContacts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxContactInformation);
            this.MinimumSize = new System.Drawing.Size(0, 275);
            this.Name = "DBA_ContactDisplay";
            this.Size = new System.Drawing.Size(486, 275);
            this.gbxContacts.ResumeLayout(false);
            this.gbxContactInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContacts;
        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.GroupBox gbxContactInformation;
        private DBA_Contact dbA_Contact1;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

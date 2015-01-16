namespace DowntownBoiseAssociation
{
    partial class frmLegalEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegalEntity));
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBoth = new System.Windows.Forms.TabPage();
            this.CollBillDisplay = new DowntownBoiseAssociation.Controls.DBA_AccountBilling();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.BillingDisplay1 = new DowntownBoiseAssociation.Controls.DBA_AccountBilling();
            this.tabCollections = new System.Windows.Forms.TabPage();
            this.CollectionDisplay = new DowntownBoiseAssociation.Controls.DBA_AccountBilling();
            this.tabCollectionsNote = new System.Windows.Forms.TabPage();
            this.collectionsEditProperties = new DowntownBoiseAssociation.Controls.editProperties();
            this.tabBillingHistory = new System.Windows.Forms.TabPage();
            this.BillingHistory = new DowntownBoiseAssociation.Controls.DBA_PaymentHistory();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.ContactDisplay1 = new DowntownBoiseAssociation.Controls.DBA_ContactDisplay();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.CommentDisplay1 = new DowntownBoiseAssociation.Controls.DBA_CommentDisplay();
            this.tabAppInfo = new System.Windows.Forms.TabPage();
            this.txtAppInfo = new System.Windows.Forms.TextBox();
            this.legalEntity1 = new DowntownBoiseAssociation.Controls.DBA_LegalEntity();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBoth.SuspendLayout();
            this.tabBilling.SuspendLayout();
            this.tabCollections.SuspendLayout();
            this.tabCollectionsNote.SuspendLayout();
            this.tabBillingHistory.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(594, 13);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "&Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(594, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabBoth);
            this.tabControl1.Controls.Add(this.tabBilling);
            this.tabControl1.Controls.Add(this.tabCollections);
            this.tabControl1.Controls.Add(this.tabCollectionsNote);
            this.tabControl1.Controls.Add(this.tabBillingHistory);
            this.tabControl1.Controls.Add(this.tabContacts);
            this.tabControl1.Controls.Add(this.tabNotes);
            this.tabControl1.Controls.Add(this.tabAppInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 395);
            this.tabControl1.TabIndex = 3;
            // 
            // tabBoth
            // 
            this.tabBoth.Controls.Add(this.CollBillDisplay);
            this.tabBoth.Location = new System.Drawing.Point(4, 22);
            this.tabBoth.Name = "tabBoth";
            this.tabBoth.Size = new System.Drawing.Size(689, 369);
            this.tabBoth.TabIndex = 5;
            this.tabBoth.Text = "Billing and Collections";
            this.tabBoth.UseVisualStyleBackColor = true;
            // 
            // CollBillDisplay
            // 
            this.CollBillDisplay.AdjustmentType = "ADJUSTMENT,WRITE-OFF,COLLECTION";
            this.CollBillDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollBillDisplay.Location = new System.Drawing.Point(0, 0);
            this.CollBillDisplay.Name = "CollBillDisplay";
            this.CollBillDisplay.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CollBillDisplay.Size = new System.Drawing.Size(689, 369);
            this.CollBillDisplay.TabIndex = 1;
            // 
            // tabBilling
            // 
            this.tabBilling.Controls.Add(this.BillingDisplay1);
            this.tabBilling.Location = new System.Drawing.Point(4, 22);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Padding = new System.Windows.Forms.Padding(3);
            this.tabBilling.Size = new System.Drawing.Size(689, 369);
            this.tabBilling.TabIndex = 2;
            this.tabBilling.Text = "Billing";
            this.tabBilling.UseVisualStyleBackColor = true;
            // 
            // BillingDisplay1
            // 
            this.BillingDisplay1.AdjustmentType = "";
            this.BillingDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillingDisplay1.Location = new System.Drawing.Point(3, 3);
            this.BillingDisplay1.Name = "BillingDisplay1";
            this.BillingDisplay1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.BillingDisplay1.Size = new System.Drawing.Size(683, 363);
            this.BillingDisplay1.TabIndex = 0;
            // 
            // tabCollections
            // 
            this.tabCollections.Controls.Add(this.CollectionDisplay);
            this.tabCollections.Location = new System.Drawing.Point(4, 22);
            this.tabCollections.Name = "tabCollections";
            this.tabCollections.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollections.Size = new System.Drawing.Size(689, 369);
            this.tabCollections.TabIndex = 4;
            this.tabCollections.Text = "Collections";
            this.tabCollections.UseVisualStyleBackColor = true;
            // 
            // CollectionDisplay
            // 
            this.CollectionDisplay.AdjustmentType = "";
            this.CollectionDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionDisplay.Location = new System.Drawing.Point(3, 3);
            this.CollectionDisplay.Name = "CollectionDisplay";
            this.CollectionDisplay.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CollectionDisplay.Size = new System.Drawing.Size(683, 363);
            this.CollectionDisplay.TabIndex = 1;
            // 
            // tabCollectionsNote
            // 
            this.tabCollectionsNote.Controls.Add(this.collectionsEditProperties);
            this.tabCollectionsNote.Location = new System.Drawing.Point(4, 22);
            this.tabCollectionsNote.Name = "tabCollectionsNote";
            this.tabCollectionsNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollectionsNote.Size = new System.Drawing.Size(689, 369);
            this.tabCollectionsNote.TabIndex = 3;
            this.tabCollectionsNote.Text = "Collections Note";
            this.tabCollectionsNote.UseVisualStyleBackColor = true;
            // 
            // collectionsEditProperties
            // 
            this.collectionsEditProperties.AutoScroll = true;
            this.collectionsEditProperties.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("collectionsEditProperties.DisplayGroups")));
            this.collectionsEditProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionsEditProperties.Location = new System.Drawing.Point(3, 3);
            this.collectionsEditProperties.Name = "collectionsEditProperties";
            this.collectionsEditProperties.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("collectionsEditProperties.NonDisplayGroups")));
            this.collectionsEditProperties.Size = new System.Drawing.Size(683, 363);
            this.collectionsEditProperties.TabIndex = 0;
            // 
            // tabBillingHistory
            // 
            this.tabBillingHistory.Controls.Add(this.BillingHistory);
            this.tabBillingHistory.Location = new System.Drawing.Point(4, 22);
            this.tabBillingHistory.Name = "tabBillingHistory";
            this.tabBillingHistory.Size = new System.Drawing.Size(689, 369);
            this.tabBillingHistory.TabIndex = 6;
            this.tabBillingHistory.Text = "Billing History";
            this.tabBillingHistory.UseVisualStyleBackColor = true;
            // 
            // BillingHistory
            // 
            this.BillingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillingHistory.LegalEntityId = 0;
            this.BillingHistory.Location = new System.Drawing.Point(0, 0);
            this.BillingHistory.Name = "BillingHistory";
            this.BillingHistory.Size = new System.Drawing.Size(689, 369);
            this.BillingHistory.TabIndex = 0;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.ContactDisplay1);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(689, 369);
            this.tabContacts.TabIndex = 1;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // ContactDisplay1
            // 
            this.ContactDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDisplay1.Location = new System.Drawing.Point(6, 6);
            this.ContactDisplay1.MinimumSize = new System.Drawing.Size(0, 275);
            this.ContactDisplay1.Name = "ContactDisplay1";
            this.ContactDisplay1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ContactDisplay1.Size = new System.Drawing.Size(680, 357);
            this.ContactDisplay1.TabIndex = 0;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.CommentDisplay1);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(689, 369);
            this.tabNotes.TabIndex = 0;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // CommentDisplay1
            // 
            this.CommentDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CommentDisplay1.Location = new System.Drawing.Point(3, 6);
            this.CommentDisplay1.Name = "CommentDisplay1";
            this.CommentDisplay1.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CommentDisplay1.Size = new System.Drawing.Size(683, 357);
            this.CommentDisplay1.TabIndex = 0;
            // 
            // tabAppInfo
            // 
            this.tabAppInfo.Controls.Add(this.txtAppInfo);
            this.tabAppInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAppInfo.Name = "tabAppInfo";
            this.tabAppInfo.Size = new System.Drawing.Size(689, 369);
            this.tabAppInfo.TabIndex = 7;
            this.tabAppInfo.Text = "App Info";
            this.tabAppInfo.UseVisualStyleBackColor = true;
            // 
            // txtAppInfo
            // 
            this.txtAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppInfo.Location = new System.Drawing.Point(2, 1);
            this.txtAppInfo.Multiline = true;
            this.txtAppInfo.Name = "txtAppInfo";
            this.txtAppInfo.Size = new System.Drawing.Size(686, 371);
            this.txtAppInfo.TabIndex = 0;
            // 
            // legalEntity1
            // 
            this.legalEntity1.BackColor = System.Drawing.Color.Transparent;
            this.legalEntity1.LegalEntityId = 0;
            this.legalEntity1.Location = new System.Drawing.Point(13, 13);
            this.legalEntity1.Name = "legalEntity1";
            this.legalEntity1.Size = new System.Drawing.Size(469, 144);
            this.legalEntity1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(594, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(680, 119);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmLegalEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(721, 570);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.legalEntity1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(590, 520);
            this.Name = "frmLegalEntity";
            this.Text = "Legal Entity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLegalEntity_FormClosing);
            this.Load += new System.EventHandler(this.frmLegalEntity_Load);
            this.Shown += new System.EventHandler(this.frmUtilityLegalEntityMaintain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabBoth.ResumeLayout(false);
            this.tabBilling.ResumeLayout(false);
            this.tabCollections.ResumeLayout(false);
            this.tabCollectionsNote.ResumeLayout(false);
            this.tabBillingHistory.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabAppInfo.ResumeLayout(false);
            this.tabAppInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private DowntownBoiseAssociation.Controls.DBA_LegalEntity legalEntity1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.TabPage tabContacts;
        private DowntownBoiseAssociation.Controls.DBA_ContactDisplay ContactDisplay1;
        private DowntownBoiseAssociation.Controls.DBA_CommentDisplay CommentDisplay1;
        private DowntownBoiseAssociation.Controls.DBA_AccountBilling dbA_AccountBilling1;
        private System.Windows.Forms.TabPage tabBilling;
        private DowntownBoiseAssociation.Controls.DBA_AccountBilling BillingDisplay1;
        private System.Windows.Forms.TabPage tabCollectionsNote;
        private DowntownBoiseAssociation.Controls.editProperties collectionsEditProperties;
        private System.Windows.Forms.TabPage tabCollections;
        private Controls.DBA_AccountBilling CollectionDisplay;
        private System.Windows.Forms.TabPage tabBoth;
        private Controls.DBA_AccountBilling CollBillDisplay;
        private System.Windows.Forms.TabPage tabBillingHistory;
        private Controls.DBA_PaymentHistory BillingHistory;
        private System.Windows.Forms.TabPage tabAppInfo;
        private System.Windows.Forms.TextBox txtAppInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}
namespace DowntownBoiseAssociation
{
    partial class frmTenantView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTenantView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTentant = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dtpDateClosed = new DowntownBoiseAssociation.Controls.DBA_NullableDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOpened = new DowntownBoiseAssociation.Controls.DBA_NullableDateTimePicker();
            this.blockBlock = new DowntownBoiseAssociation.Controls.DBA_Block();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.tabSpaces = new System.Windows.Forms.TabPage();
            this.dba_TenantSpaces1 = new DowntownBoiseAssociation.Controls.DBA_TenantSpaces();
            this.tabLegalEntity = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLegalEntity = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.legalEntityTenant = new DowntownBoiseAssociation.Controls.DBA_LegalEntity();
            this.tabBusiness = new System.Windows.Forms.TabPage();
            this.editPropertiesBusiness = new DowntownBoiseAssociation.Controls.editProperties();
            this.tabDirectory = new System.Windows.Forms.TabPage();
            this.editPropertiesTenant = new DowntownBoiseAssociation.Controls.editProperties();
            this.ClassCategoryTenant = new DowntownBoiseAssociation.Controls.DBA_ClassCategoryItem();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.editPropertiesOther = new DowntownBoiseAssociation.Controls.editProperties();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.CommentDisplayTenant = new DowntownBoiseAssociation.Controls.DBA_CommentDisplay();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.ContactDisplayTenant = new DowntownBoiseAssociation.Controls.DBA_ContactDisplay();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCloseTenant = new System.Windows.Forms.Button();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddressTenant = new DowntownBoiseAssociation.Controls.DBA_Address();
            this.locationTenant = new DowntownBoiseAssociation.Controls.DBA_Location();
            this.tabControl1.SuspendLayout();
            this.tabTentant.SuspendLayout();
            this.tabSpaces.SuspendLayout();
            this.tabLegalEntity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBusiness.SuspendLayout();
            this.tabDirectory.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTentant);
            this.tabControl1.Controls.Add(this.tabSpaces);
            this.tabControl1.Controls.Add(this.tabLegalEntity);
            this.tabControl1.Controls.Add(this.tabBusiness);
            this.tabControl1.Controls.Add(this.tabDirectory);
            this.tabControl1.Controls.Add(this.tabOther);
            this.tabControl1.Controls.Add(this.tabNotes);
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Location = new System.Drawing.Point(7, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 397);
            this.tabControl1.TabIndex = 1;
            // 
            // tabTentant
            // 
            this.tabTentant.Controls.Add(this.linkLabel1);
            this.tabTentant.Controls.Add(this.dtpDateClosed);
            this.tabTentant.Controls.Add(this.label3);
            this.tabTentant.Controls.Add(this.label2);
            this.tabTentant.Controls.Add(this.dtpDateOpened);
            this.tabTentant.Controls.Add(this.blockBlock);
            this.tabTentant.Controls.Add(this.btnClose);
            this.tabTentant.Controls.Add(this.btnMove);
            this.tabTentant.Location = new System.Drawing.Point(4, 22);
            this.tabTentant.Name = "tabTentant";
            this.tabTentant.Size = new System.Drawing.Size(672, 371);
            this.tabTentant.TabIndex = 13;
            this.tabTentant.Text = "Tenant";
            this.tabTentant.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(517, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Google Map Link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dtpDateClosed
            // 
            this.dtpDateClosed.CustomFormat = "MM/dd/yyyy";
            this.dtpDateClosed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateClosed.Location = new System.Drawing.Point(76, 47);
            this.dtpDateClosed.Name = "dtpDateClosed";
            this.dtpDateClosed.Size = new System.Drawing.Size(108, 20);
            this.dtpDateClosed.TabIndex = 36;
            this.dtpDateClosed.Value = new System.DateTime(2009, 1, 20, 11, 38, 37, 921);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Opened";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Closed";
            // 
            // dtpDateOpened
            // 
            this.dtpDateOpened.CustomFormat = "MM/dd/yyyy";
            this.dtpDateOpened.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOpened.Location = new System.Drawing.Point(76, 21);
            this.dtpDateOpened.Name = "dtpDateOpened";
            this.dtpDateOpened.Size = new System.Drawing.Size(108, 20);
            this.dtpDateOpened.TabIndex = 29;
            this.dtpDateOpened.Value = new System.DateTime(2009, 1, 20, 11, 38, 37, 921);
            // 
            // blockBlock
            // 
            this.blockBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blockBlock.BackColor = System.Drawing.Color.Transparent;
            this.blockBlock.Location = new System.Drawing.Point(471, 47);
            this.blockBlock.Name = "blockBlock";
            this.blockBlock.Size = new System.Drawing.Size(183, 243);
            this.blockBlock.TabIndex = 28;
            this.blockBlock.TenantId = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(25, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Closeout This Tenant";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(25, 96);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(134, 23);
            this.btnMove.TabIndex = 26;
            this.btnMove.Text = "Move This Tenant";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tabSpaces
            // 
            this.tabSpaces.Controls.Add(this.dba_TenantSpaces1);
            this.tabSpaces.Location = new System.Drawing.Point(4, 22);
            this.tabSpaces.Name = "tabSpaces";
            this.tabSpaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpaces.Size = new System.Drawing.Size(672, 371);
            this.tabSpaces.TabIndex = 12;
            this.tabSpaces.Text = "Spaces";
            this.tabSpaces.UseVisualStyleBackColor = true;
            // 
            // dba_TenantSpaces1
            // 
            this.dba_TenantSpaces1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dba_TenantSpaces1.Location = new System.Drawing.Point(3, 6);
            this.dba_TenantSpaces1.Name = "dba_TenantSpaces1";
            this.dba_TenantSpaces1.Size = new System.Drawing.Size(666, 359);
            this.dba_TenantSpaces1.TabIndex = 0;
            this.dba_TenantSpaces1.TenantId = 0;
            // 
            // tabLegalEntity
            // 
            this.tabLegalEntity.Controls.Add(this.label7);
            this.tabLegalEntity.Controls.Add(this.linkLegalEntity);
            this.tabLegalEntity.Controls.Add(this.groupBox2);
            this.tabLegalEntity.Location = new System.Drawing.Point(4, 22);
            this.tabLegalEntity.Name = "tabLegalEntity";
            this.tabLegalEntity.Size = new System.Drawing.Size(672, 371);
            this.tabLegalEntity.TabIndex = 11;
            this.tabLegalEntity.Text = "Legal Entity";
            this.tabLegalEntity.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Link to";
            // 
            // linkLegalEntity
            // 
            this.linkLegalEntity.AutoSize = true;
            this.linkLegalEntity.Location = new System.Drawing.Point(50, 197);
            this.linkLegalEntity.Name = "linkLegalEntity";
            this.linkLegalEntity.Size = new System.Drawing.Size(79, 13);
            this.linkLegalEntity.TabIndex = 32;
            this.linkLegalEntity.TabStop = true;
            this.linkLegalEntity.Text = "No Legal Entity";
            this.linkLegalEntity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLegalEntity_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.legalEntityTenant);
            this.groupBox2.Location = new System.Drawing.Point(8, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 183);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Legal Entity";
            // 
            // legalEntityTenant
            // 
            this.legalEntityTenant.BackColor = System.Drawing.Color.Transparent;
            this.legalEntityTenant.LegalEntityId = 0;
            this.legalEntityTenant.Location = new System.Drawing.Point(9, 19);
            this.legalEntityTenant.Name = "legalEntityTenant";
            this.legalEntityTenant.Size = new System.Drawing.Size(423, 145);
            this.legalEntityTenant.TabIndex = 27;
            // 
            // tabBusiness
            // 
            this.tabBusiness.Controls.Add(this.editPropertiesBusiness);
            this.tabBusiness.Location = new System.Drawing.Point(4, 22);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusiness.Size = new System.Drawing.Size(672, 371);
            this.tabBusiness.TabIndex = 10;
            this.tabBusiness.Text = "Business";
            this.tabBusiness.UseVisualStyleBackColor = true;
            // 
            // editPropertiesBusiness
            // 
            this.editPropertiesBusiness.AutoScroll = true;
            this.editPropertiesBusiness.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesBusiness.DisplayGroups")));
            this.editPropertiesBusiness.Location = new System.Drawing.Point(6, 6);
            this.editPropertiesBusiness.Name = "editPropertiesBusiness";
            this.editPropertiesBusiness.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesBusiness.NonDisplayGroups")));
            this.editPropertiesBusiness.Size = new System.Drawing.Size(660, 353);
            this.editPropertiesBusiness.TabIndex = 0;
            // 
            // tabDirectory
            // 
            this.tabDirectory.BackColor = System.Drawing.Color.Transparent;
            this.tabDirectory.Controls.Add(this.editPropertiesTenant);
            this.tabDirectory.Controls.Add(this.ClassCategoryTenant);
            this.tabDirectory.Location = new System.Drawing.Point(4, 22);
            this.tabDirectory.Name = "tabDirectory";
            this.tabDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectory.Size = new System.Drawing.Size(672, 371);
            this.tabDirectory.TabIndex = 1;
            this.tabDirectory.Text = "Directory";
            this.tabDirectory.UseVisualStyleBackColor = true;
            // 
            // editPropertiesTenant
            // 
            this.editPropertiesTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPropertiesTenant.AutoScroll = true;
            this.editPropertiesTenant.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesTenant.DisplayGroups")));
            this.editPropertiesTenant.Location = new System.Drawing.Point(1, 6);
            this.editPropertiesTenant.Name = "editPropertiesTenant";
            this.editPropertiesTenant.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesTenant.NonDisplayGroups")));
            this.editPropertiesTenant.Size = new System.Drawing.Size(331, 362);
            this.editPropertiesTenant.TabIndex = 2;
            // 
            // ClassCategoryTenant
            // 
            this.ClassCategoryTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassCategoryTenant.Location = new System.Drawing.Point(338, 6);
            this.ClassCategoryTenant.Name = "ClassCategoryTenant";
            this.ClassCategoryTenant.Size = new System.Drawing.Size(331, 362);
            this.ClassCategoryTenant.TabIndex = 1;
            this.ClassCategoryTenant.TenantId = 0;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.editPropertiesOther);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(672, 371);
            this.tabOther.TabIndex = 9;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // editPropertiesOther
            // 
            this.editPropertiesOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPropertiesOther.AutoScroll = true;
            this.editPropertiesOther.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesOther.DisplayGroups")));
            this.editPropertiesOther.Location = new System.Drawing.Point(3, 6);
            this.editPropertiesOther.Name = "editPropertiesOther";
            this.editPropertiesOther.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("editPropertiesOther.NonDisplayGroups")));
            this.editPropertiesOther.Size = new System.Drawing.Size(663, 359);
            this.editPropertiesOther.TabIndex = 0;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.CommentDisplayTenant);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(672, 371);
            this.tabNotes.TabIndex = 5;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // CommentDisplayTenant
            // 
            this.CommentDisplayTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentDisplayTenant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CommentDisplayTenant.Location = new System.Drawing.Point(3, 3);
            this.CommentDisplayTenant.Name = "CommentDisplayTenant";
            this.CommentDisplayTenant.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CommentDisplayTenant.Size = new System.Drawing.Size(666, 365);
            this.CommentDisplayTenant.TabIndex = 0;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.ContactDisplayTenant);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(672, 371);
            this.tabContact.TabIndex = 8;
            this.tabContact.Text = "Contacts";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // ContactDisplayTenant
            // 
            this.ContactDisplayTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDisplayTenant.Location = new System.Drawing.Point(4, 4);
            this.ContactDisplayTenant.MinimumSize = new System.Drawing.Size(0, 300);
            this.ContactDisplayTenant.Name = "ContactDisplayTenant";
            this.ContactDisplayTenant.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ContactDisplayTenant.Size = new System.Drawing.Size(665, 361);
            this.ContactDisplayTenant.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(571, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseTenant
            // 
            this.btnCloseTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTenant.Location = new System.Drawing.Point(571, 53);
            this.btnCloseTenant.Name = "btnCloseTenant";
            this.btnCloseTenant.Size = new System.Drawing.Size(109, 23);
            this.btnCloseTenant.TabIndex = 27;
            this.btnCloseTenant.Text = "&Close";
            this.btnCloseTenant.UseVisualStyleBackColor = true;
            this.btnCloseTenant.Click += new System.EventHandler(this.btnCloseTenant_Click);
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataSource = typeof(DowntownBoiseAssociation.Tenant);
            // 
            // AddressTenant
            // 
            this.AddressTenant.AddressId = 0;
            this.AddressTenant.BackColor = System.Drawing.Color.Transparent;
            this.AddressTenant.Location = new System.Drawing.Point(7, 33);
            this.AddressTenant.Name = "AddressTenant";
            this.AddressTenant.Size = new System.Drawing.Size(420, 68);
            this.AddressTenant.TabIndex = 28;
            // 
            // locationTenant
            // 
            this.locationTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTenant.Location = new System.Drawing.Point(0, 0);
            this.locationTenant.Name = "locationTenant";
            this.locationTenant.Size = new System.Drawing.Size(697, 22);
            this.locationTenant.TabIndex = 20;
            // 
            // frmTenantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 516);
            this.Controls.Add(this.AddressTenant);
            this.Controls.Add(this.btnCloseTenant);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.locationTenant);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "frmTenantView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Some Tenant - Account #12345-01";
            this.Load += new System.EventHandler(this.frmTenantView_Load);
            this.Shown += new System.EventHandler(this.frmTenantView_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabTentant.ResumeLayout(false);
            this.tabTentant.PerformLayout();
            this.tabSpaces.ResumeLayout(false);
            this.tabLegalEntity.ResumeLayout(false);
            this.tabLegalEntity.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabBusiness.ResumeLayout(false);
            this.tabDirectory.ResumeLayout(false);
            this.tabOther.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

          

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDirectory;
        private System.Windows.Forms.TabPage tabNotes;
        private DowntownBoiseAssociation.Controls.DBA_Location locationTenant;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabContact;
        private DowntownBoiseAssociation.Controls.DBA_ContactDisplay ContactDisplayTenant;
        private DowntownBoiseAssociation.Controls.DBA_CommentDisplay CommentDisplayTenant;
        private DowntownBoiseAssociation.Controls.DBA_ClassCategoryItem ClassCategoryTenant;
        private DowntownBoiseAssociation.Controls.editProperties editPropertiesTenant;
        private System.Windows.Forms.TabPage tabOther;
        private DowntownBoiseAssociation.Controls.editProperties editPropertiesOther;
        private System.Windows.Forms.TabPage tabBusiness;
        private DowntownBoiseAssociation.Controls.editProperties editPropertiesBusiness;
        private System.Windows.Forms.Button btnCloseTenant;
        private System.Windows.Forms.TabPage tabLegalEntity;
        private DowntownBoiseAssociation.Controls.DBA_Address AddressTenant;
        private System.Windows.Forms.LinkLabel linkLegalEntity;
        private System.Windows.Forms.GroupBox groupBox2;
        private DowntownBoiseAssociation.Controls.DBA_LegalEntity legalEntityTenant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabSpaces;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private DowntownBoiseAssociation.Controls.DBA_TenantSpaces dba_TenantSpaces1;
        private System.Windows.Forms.TabPage tabTentant;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMove;
        private DowntownBoiseAssociation.Controls.DBA_Block blockBlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DowntownBoiseAssociation.Controls.DBA_NullableDateTimePicker dtpDateOpened;
        private DowntownBoiseAssociation.Controls.DBA_NullableDateTimePicker dtpDateClosed;
        private System.Windows.Forms.LinkLabel linkLabel1;
        
        

    }
}
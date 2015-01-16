namespace DowntownBoiseAssociation
{
    partial class reportBlockPersonsContactingInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.cbxAddress = new System.Windows.Forms.CheckBox();
            this.cbxPhone = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSpaceOwners = new System.Windows.Forms.CheckBox();
            this.cbxBlockCaptains = new System.Windows.Forms.CheckBox();
            this.cbxTenants = new System.Windows.Forms.CheckBox();
            this.cbxContacts = new System.Windows.Forms.CheckBox();
            this.cbxBillTo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxBlocksSelected = new System.Windows.Forms.ListBox();
            this.menuRelationship = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editThisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThisItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectBlocks = new System.Windows.Forms.Button();
            this.lblBlocksSelectedYesNo = new System.Windows.Forms.Label();
            this.lvwToBeSaved = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tclRequestedInformation = new System.Windows.Forms.TabControl();
            this.tpgToBeSavedList = new System.Windows.Forms.TabPage();
            this.tpgRemovedList = new System.Windows.Forms.TabPage();
            this.lvwRemoved = new System.Windows.Forms.ListView();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuRelationship.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tclRequestedInformation.SuspendLayout();
            this.tpgToBeSavedList.SuspendLayout();
            this.tpgRemovedList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEmail);
            this.groupBox1.Controls.Add(this.cbxAddress);
            this.groupBox1.Controls.Add(this.cbxPhone);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Location = new System.Drawing.Point(6, 43);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(71, 17);
            this.cbxEmail.TabIndex = 2;
            this.cbxEmail.Text = "Get Email";
            this.cbxEmail.UseVisualStyleBackColor = true;
            this.cbxEmail.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxAddress
            // 
            this.cbxAddress.AutoSize = true;
            this.cbxAddress.Location = new System.Drawing.Point(6, 20);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(84, 17);
            this.cbxAddress.TabIndex = 1;
            this.cbxAddress.Text = "Get Address";
            this.cbxAddress.UseVisualStyleBackColor = true;
            this.cbxAddress.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxPhone
            // 
            this.cbxPhone.AutoSize = true;
            this.cbxPhone.Location = new System.Drawing.Point(6, 66);
            this.cbxPhone.Name = "cbxPhone";
            this.cbxPhone.Size = new System.Drawing.Size(87, 17);
            this.cbxPhone.TabIndex = 3;
            this.cbxPhone.Text = "Get Phone #";
            this.cbxPhone.UseVisualStyleBackColor = true;
            this.cbxPhone.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSpaceOwners);
            this.groupBox2.Controls.Add(this.cbxBlockCaptains);
            this.groupBox2.Controls.Add(this.cbxTenants);
            this.groupBox2.Controls.Add(this.cbxContacts);
            this.groupBox2.Controls.Add(this.cbxBillTo);
            this.groupBox2.Location = new System.Drawing.Point(156, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persons of Interest";
            // 
            // cbxSpaceOwners
            // 
            this.cbxSpaceOwners.AutoSize = true;
            this.cbxSpaceOwners.Location = new System.Drawing.Point(94, 43);
            this.cbxSpaceOwners.Name = "cbxSpaceOwners";
            this.cbxSpaceOwners.Size = new System.Drawing.Size(96, 17);
            this.cbxSpaceOwners.TabIndex = 8;
            this.cbxSpaceOwners.Text = "Space Owners";
            this.cbxSpaceOwners.UseVisualStyleBackColor = true;
            this.cbxSpaceOwners.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxBlockCaptains
            // 
            this.cbxBlockCaptains.AutoSize = true;
            this.cbxBlockCaptains.Location = new System.Drawing.Point(94, 20);
            this.cbxBlockCaptains.Name = "cbxBlockCaptains";
            this.cbxBlockCaptains.Size = new System.Drawing.Size(97, 17);
            this.cbxBlockCaptains.TabIndex = 7;
            this.cbxBlockCaptains.Text = "Block Captains";
            this.cbxBlockCaptains.UseVisualStyleBackColor = true;
            this.cbxBlockCaptains.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxTenants
            // 
            this.cbxTenants.AutoSize = true;
            this.cbxTenants.Location = new System.Drawing.Point(7, 66);
            this.cbxTenants.Name = "cbxTenants";
            this.cbxTenants.Size = new System.Drawing.Size(65, 17);
            this.cbxTenants.TabIndex = 6;
            this.cbxTenants.Text = "Tenants";
            this.cbxTenants.UseVisualStyleBackColor = true;
            this.cbxTenants.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxContacts
            // 
            this.cbxContacts.AutoSize = true;
            this.cbxContacts.Location = new System.Drawing.Point(7, 43);
            this.cbxContacts.Name = "cbxContacts";
            this.cbxContacts.Size = new System.Drawing.Size(68, 17);
            this.cbxContacts.TabIndex = 5;
            this.cbxContacts.Text = "Contacts";
            this.cbxContacts.UseVisualStyleBackColor = true;
            this.cbxContacts.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbxBillTo
            // 
            this.cbxBillTo.AutoSize = true;
            this.cbxBillTo.Location = new System.Drawing.Point(7, 20);
            this.cbxBillTo.Name = "cbxBillTo";
            this.cbxBillTo.Size = new System.Drawing.Size(55, 17);
            this.cbxBillTo.TabIndex = 4;
            this.cbxBillTo.Text = "Bill To";
            this.cbxBillTo.UseVisualStyleBackColor = true;
            this.cbxBillTo.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbxBlocksSelected);
            this.groupBox3.Controls.Add(this.btnSelectBlocks);
            this.groupBox3.Controls.Add(this.lblBlocksSelectedYesNo);
            this.groupBox3.Location = new System.Drawing.Point(378, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blocks Selected";
            // 
            // lbxBlocksSelected
            // 
            this.lbxBlocksSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxBlocksSelected.ContextMenuStrip = this.menuRelationship;
            this.lbxBlocksSelected.FormattingEnabled = true;
            this.lbxBlocksSelected.Location = new System.Drawing.Point(103, 14);
            this.lbxBlocksSelected.Name = "lbxBlocksSelected";
            this.lbxBlocksSelected.Size = new System.Drawing.Size(123, 69);
            this.lbxBlocksSelected.TabIndex = 0;
            this.lbxBlocksSelected.Visible = false;
            // 
            // menuRelationship
            // 
            this.menuRelationship.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editThisItemToolStripMenuItem,
            this.editThisItemToolStripMenuItem1});
            this.menuRelationship.Name = "menuRelationship";
            this.menuRelationship.Size = new System.Drawing.Size(149, 48);
            this.menuRelationship.Text = "Edit this Item";
            this.menuRelationship.Opening += new System.ComponentModel.CancelEventHandler(this.menuRelationship_Opening);
            // 
            // editThisItemToolStripMenuItem
            // 
            this.editThisItemToolStripMenuItem.Name = "editThisItemToolStripMenuItem";
            this.editThisItemToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editThisItemToolStripMenuItem.Text = "Edit this Item";
            this.editThisItemToolStripMenuItem.Click += new System.EventHandler(this.editThisItemToolStripMenuItem_Click);
            // 
            // editThisItemToolStripMenuItem1
            // 
            this.editThisItemToolStripMenuItem1.Name = "editThisItemToolStripMenuItem1";
            this.editThisItemToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.editThisItemToolStripMenuItem1.Text = "Edit this Item";
            this.editThisItemToolStripMenuItem1.Click += new System.EventHandler(this.editThisItemToolStripMenuItem1_Click);
            // 
            // btnSelectBlocks
            // 
            this.btnSelectBlocks.Location = new System.Drawing.Point(6, 62);
            this.btnSelectBlocks.Name = "btnSelectBlocks";
            this.btnSelectBlocks.Size = new System.Drawing.Size(91, 23);
            this.btnSelectBlocks.TabIndex = 10;
            this.btnSelectBlocks.Text = "Select Blocks";
            this.btnSelectBlocks.UseVisualStyleBackColor = true;
            this.btnSelectBlocks.Click += new System.EventHandler(this.btnSelectBlocks_Click);
            // 
            // lblBlocksSelectedYesNo
            // 
            this.lblBlocksSelectedYesNo.AutoSize = true;
            this.lblBlocksSelectedYesNo.Location = new System.Drawing.Point(35, 20);
            this.lblBlocksSelectedYesNo.Name = "lblBlocksSelectedYesNo";
            this.lblBlocksSelectedYesNo.Size = new System.Drawing.Size(21, 13);
            this.lblBlocksSelectedYesNo.TabIndex = 0;
            this.lblBlocksSelectedYesNo.Text = "No";
            // 
            // lvwToBeSaved
            // 
            this.lvwToBeSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwToBeSaved.ContextMenuStrip = this.menuRelationship;
            this.lvwToBeSaved.FullRowSelect = true;
            this.lvwToBeSaved.Location = new System.Drawing.Point(0, 6);
            this.lvwToBeSaved.MultiSelect = false;
            this.lvwToBeSaved.Name = "lvwToBeSaved";
            this.lvwToBeSaved.Size = new System.Drawing.Size(576, 117);
            this.lvwToBeSaved.TabIndex = 3;
            this.lvwToBeSaved.UseCompatibleStateImageBehavior = false;
            this.lvwToBeSaved.View = System.Windows.Forms.View.Details;
            this.lvwToBeSaved.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(454, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(535, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tclRequestedInformation);
            this.groupBox4.Location = new System.Drawing.Point(13, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 181);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Requested Informantion";
            // 
            // tclRequestedInformation
            // 
            this.tclRequestedInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tclRequestedInformation.Controls.Add(this.tpgToBeSavedList);
            this.tclRequestedInformation.Controls.Add(this.tpgRemovedList);
            this.tclRequestedInformation.Location = new System.Drawing.Point(7, 20);
            this.tclRequestedInformation.Name = "tclRequestedInformation";
            this.tclRequestedInformation.SelectedIndex = 0;
            this.tclRequestedInformation.Size = new System.Drawing.Size(584, 155);
            this.tclRequestedInformation.TabIndex = 0;
            this.tclRequestedInformation.Visible = false;
            // 
            // tpgToBeSavedList
            // 
            this.tpgToBeSavedList.Controls.Add(this.lvwToBeSaved);
            this.tpgToBeSavedList.Location = new System.Drawing.Point(4, 22);
            this.tpgToBeSavedList.Name = "tpgToBeSavedList";
            this.tpgToBeSavedList.Padding = new System.Windows.Forms.Padding(3);
            this.tpgToBeSavedList.Size = new System.Drawing.Size(576, 129);
            this.tpgToBeSavedList.TabIndex = 0;
            this.tpgToBeSavedList.Text = "Requested";
            this.tpgToBeSavedList.UseVisualStyleBackColor = true;
            // 
            // tpgRemovedList
            // 
            this.tpgRemovedList.Controls.Add(this.lvwRemoved);
            this.tpgRemovedList.Location = new System.Drawing.Point(4, 22);
            this.tpgRemovedList.Name = "tpgRemovedList";
            this.tpgRemovedList.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRemovedList.Size = new System.Drawing.Size(576, 129);
            this.tpgRemovedList.TabIndex = 1;
            this.tpgRemovedList.Text = "Removed";
            this.tpgRemovedList.UseVisualStyleBackColor = true;
            // 
            // lvwRemoved
            // 
            this.lvwRemoved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRemoved.ContextMenuStrip = this.menuRelationship;
            this.lvwRemoved.FullRowSelect = true;
            this.lvwRemoved.Location = new System.Drawing.Point(0, 6);
            this.lvwRemoved.MultiSelect = false;
            this.lvwRemoved.Name = "lvwRemoved";
            this.lvwRemoved.Size = new System.Drawing.Size(576, 117);
            this.lvwRemoved.TabIndex = 4;
            this.lvwRemoved.UseCompatibleStateImageBehavior = false;
            this.lvwRemoved.View = System.Windows.Forms.View.Details;
            this.lvwRemoved.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // btnRunReport
            // 
            this.btnRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRunReport.Location = new System.Drawing.Point(12, 309);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "&Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // reportBlockPersonsContactingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 341);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(630, 300);
            this.Name = "reportBlockPersonsContactingInfo";
            this.Text = "Report - Block Persons Contact Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuRelationship.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tclRequestedInformation.ResumeLayout(false);
            this.tpgToBeSavedList.ResumeLayout(false);
            this.tpgRemovedList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxPhone;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.CheckBox cbxAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxBillTo;
        private System.Windows.Forms.CheckBox cbxTenants;
        private System.Windows.Forms.CheckBox cbxContacts;
        private System.Windows.Forms.CheckBox cbxSpaceOwners;
        private System.Windows.Forms.CheckBox cbxBlockCaptains;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectBlocks;
        private System.Windows.Forms.Label lblBlocksSelectedYesNo;
        private System.Windows.Forms.ListBox lbxBlocksSelected;
        private System.Windows.Forms.ListView lvwToBeSaved;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tclRequestedInformation;
        private System.Windows.Forms.TabPage tpgToBeSavedList;
        private System.Windows.Forms.TabPage tpgRemovedList;
        private System.Windows.Forms.ListView lvwRemoved;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.ContextMenuStrip menuRelationship;
        private System.Windows.Forms.ToolStripMenuItem editThisItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThisItemToolStripMenuItem1;
    }
}
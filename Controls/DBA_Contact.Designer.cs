namespace DowntownBoiseAssociation.Controls
{
	partial class DBA_Contact
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactDescription = new System.Windows.Forms.TextBox();
            this.linkChangeContact = new System.Windows.Forms.LinkLabel();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.ddlContactDescription = new System.Windows.Forms.ComboBox();
            this.linkFillFromExisting = new System.Windows.Forms.LinkLabel();
            this.addressLE = new DowntownBoiseAssociation.Controls.DBA_Address();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(79, 23);
            this.txtContactPhone.Mask = "(999) 000-0000";
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(93, 20);
            this.txtContactPhone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(216, 23);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(217, 20);
            this.txtContactEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role";
            // 
            // txtContactDescription
            // 
            this.txtContactDescription.Location = new System.Drawing.Point(79, 46);
            this.txtContactDescription.Multiline = true;
            this.txtContactDescription.Name = "txtContactDescription";
            this.txtContactDescription.Size = new System.Drawing.Size(265, 21);
            this.txtContactDescription.TabIndex = 4;
            this.txtContactDescription.Visible = false;
            // 
            // linkChangeContact
            // 
            this.linkChangeContact.AutoSize = true;
            this.linkChangeContact.Location = new System.Drawing.Point(344, 49);
            this.linkChangeContact.Name = "linkChangeContact";
            this.linkChangeContact.Size = new System.Drawing.Size(89, 13);
            this.linkChangeContact.TabIndex = 10;
            this.linkChangeContact.TabStop = true;
            this.linkChangeContact.Text = "Add/Edit Contact";
            this.linkChangeContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbnChangeContact_LinkClicked);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(3, 3);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(35, 13);
            this.lblContactName.TabIndex = 11;
            this.lblContactName.Text = "Name";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(79, 0);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(265, 20);
            this.txtContactName.TabIndex = 1;
            // 
            // ddlContactDescription
            // 
            this.ddlContactDescription.FormattingEnabled = true;
            this.ddlContactDescription.Location = new System.Drawing.Point(79, 46);
            this.ddlContactDescription.Name = "ddlContactDescription";
            this.ddlContactDescription.Size = new System.Drawing.Size(265, 21);
            this.ddlContactDescription.Sorted = true;
            this.ddlContactDescription.TabIndex = 14;
            // 
            // linkFillFromExisting
            // 
            this.linkFillFromExisting.AutoSize = true;
            this.linkFillFromExisting.Location = new System.Drawing.Point(353, 3);
            this.linkFillFromExisting.Name = "linkFillFromExisting";
            this.linkFillFromExisting.Size = new System.Drawing.Size(80, 13);
            this.linkFillFromExisting.TabIndex = 15;
            this.linkFillFromExisting.TabStop = true;
            this.linkFillFromExisting.Text = "Fill from existing";
            this.linkFillFromExisting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // addressLE
            // 
            this.addressLE.AddressId = 0;
            this.addressLE.BackColor = System.Drawing.Color.Transparent;
            this.addressLE.Location = new System.Drawing.Point(3, 70);
            this.addressLE.Name = "addressLE";
            this.addressLE.Size = new System.Drawing.Size(448, 68);
            this.addressLE.TabIndex = 16;
            // 
            // DBA_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.addressLE);
            this.Controls.Add(this.linkFillFromExisting);
            this.Controls.Add(this.ddlContactDescription);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.linkChangeContact);
            this.Controls.Add(this.txtContactDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.label3);
            this.Name = "DBA_Contact";
            this.Size = new System.Drawing.Size(451, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtContactPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactDescription;
        private System.Windows.Forms.LinkLabel linkChangeContact;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.ComboBox ddlContactDescription;
        private System.Windows.Forms.LinkLabel linkFillFromExisting;
        private DBA_Address addressLE;
	}
}

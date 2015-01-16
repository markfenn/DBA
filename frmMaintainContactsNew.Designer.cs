namespace DowntownBoiseAssociation
{
    partial class frmMaintainContactsNew
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
            this.ddlContactDescription = new System.Windows.Forms.ComboBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.btnFillContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlContactDescription
            // 
            this.ddlContactDescription.FormattingEnabled = true;
            this.ddlContactDescription.Location = new System.Drawing.Point(85, 58);
            this.ddlContactDescription.Name = "ddlContactDescription";
            this.ddlContactDescription.Size = new System.Drawing.Size(354, 21);
            this.ddlContactDescription.Sorted = true;
            this.ddlContactDescription.TabIndex = 25;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(85, 12);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(354, 20);
            this.txtContactName.TabIndex = 16;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(9, 15);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(35, 13);
            this.lblContactName.TabIndex = 24;
            this.lblContactName.Text = "Name";
            // 
            // txtContactDescription
            // 
            this.txtContactDescription.Location = new System.Drawing.Point(85, 58);
            this.txtContactDescription.Multiline = true;
            this.txtContactDescription.Name = "txtContactDescription";
            this.txtContactDescription.Size = new System.Drawing.Size(265, 21);
            this.txtContactDescription.TabIndex = 19;
            this.txtContactDescription.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Role";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(222, 35);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(217, 20);
            this.txtContactEmail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(85, 35);
            this.txtContactPhone.Mask = "(999) 000-0000";
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(93, 20);
            this.txtContactPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(368, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAddress.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectAddress.Location = new System.Drawing.Point(162, 137);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(96, 23);
            this.btnSelectAddress.TabIndex = 29;
            this.btnSelectAddress.Text = "Select Address";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnSelectAddress_Click);
            // 
            // btnFillContact
            // 
            this.btnFillContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFillContact.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFillContact.Location = new System.Drawing.Point(12, 137);
            this.btnFillContact.Name = "btnFillContact";
            this.btnFillContact.Size = new System.Drawing.Size(144, 23);
            this.btnFillContact.TabIndex = 30;
            this.btnFillContact.Text = "Fill From Existing Contact";
            this.btnFillContact.UseVisualStyleBackColor = true;
            this.btnFillContact.Click += new System.EventHandler(this.btnFillContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(85, 86);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 13);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Select Address";
            // 
            // frmMaintainContactsNew
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 172);
            this.ControlBox = false;
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFillContact);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ddlContactDescription);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.txtContactDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMaintainContactsNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMaintainContactsNew";
            this.Load += new System.EventHandler(this.frmMaintainContactsNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlContactDescription;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtContactPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Button btnFillContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress;
    }
}
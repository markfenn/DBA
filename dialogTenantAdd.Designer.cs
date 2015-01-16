namespace DowntownBoiseAssociation
{
    partial class dialogTenantAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.linkTenantLE = new System.Windows.Forms.LinkLabel();
            this.linkTenantAddress = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkVacantLocation = new System.Windows.Forms.LinkLabel();
            this.linkBillTo = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBillTo = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 77);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address";
            // 
            // linkTenantLE
            // 
            this.linkTenantLE.AutoSize = true;
            this.linkTenantLE.BackColor = System.Drawing.Color.Transparent;
            this.linkTenantLE.Location = new System.Drawing.Point(77, 11);
            this.linkTenantLE.Name = "linkTenantLE";
            this.linkTenantLE.Size = new System.Drawing.Size(95, 13);
            this.linkTenantLE.TabIndex = 2;
            this.linkTenantLE.TabStop = true;
            this.linkTenantLE.Text = "Select Legal Entity";
            this.linkTenantLE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTenantLE_LinkClicked);
            // 
            // linkTenantAddress
            // 
            this.linkTenantAddress.AutoSize = true;
            this.linkTenantAddress.Location = new System.Drawing.Point(198, 77);
            this.linkTenantAddress.Name = "linkTenantAddress";
            this.linkTenantAddress.Size = new System.Drawing.Size(115, 13);
            this.linkTenantAddress.TabIndex = 3;
            this.linkTenantAddress.TabStop = true;
            this.linkTenantAddress.Text = "Select Tenant Address";
            this.linkTenantAddress.Visible = false;
            this.linkTenantAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTenantAddress_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // linkVacantLocation
            // 
            this.linkVacantLocation.AutoSize = true;
            this.linkVacantLocation.BackColor = System.Drawing.Color.Transparent;
            this.linkVacantLocation.Location = new System.Drawing.Point(77, 34);
            this.linkVacantLocation.Name = "linkVacantLocation";
            this.linkVacantLocation.Size = new System.Drawing.Size(108, 13);
            this.linkVacantLocation.TabIndex = 5;
            this.linkVacantLocation.TabStop = true;
            this.linkVacantLocation.Text = "Select Vacant Space";
            this.linkVacantLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVacantLocation_LinkClicked);
            // 
            // linkBillTo
            // 
            this.linkBillTo.AutoSize = true;
            this.linkBillTo.Location = new System.Drawing.Point(198, 99);
            this.linkBillTo.Name = "linkBillTo";
            this.linkBillTo.Size = new System.Drawing.Size(127, 13);
            this.linkBillTo.TabIndex = 7;
            this.linkBillTo.TabStop = true;
            this.linkBillTo.Text = "Select Bill To Legal Entity";
            this.linkBillTo.Visible = false;
            this.linkBillTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBillTo_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bill To";
            // 
            // cbBillTo
            // 
            this.cbBillTo.AutoSize = true;
            this.cbBillTo.Checked = true;
            this.cbBillTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBillTo.Location = new System.Drawing.Point(80, 99);
            this.cbBillTo.Name = "cbBillTo";
            this.cbBillTo.Size = new System.Drawing.Size(99, 17);
            this.cbBillTo.TabIndex = 8;
            this.cbBillTo.Text = "Same As Name";
            this.cbBillTo.UseVisualStyleBackColor = true;
            this.cbBillTo.CheckedChanged += new System.EventHandler(this.cbBillTo_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(258, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(339, 144);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.Checked = true;
            this.cbAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddress.Location = new System.Drawing.Point(80, 76);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(112, 17);
            this.cbAddress.TabIndex = 11;
            this.cbAddress.Text = "Same As Location";
            this.cbAddress.UseVisualStyleBackColor = true;
            this.cbAddress.CheckedChanged += new System.EventHandler(this.cbAddress_CheckedChanged);
            // 
            // dialogTenantAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(426, 179);
            this.ControlBox = false;
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbBillTo);
            this.Controls.Add(this.linkBillTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkVacantLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkTenantAddress);
            this.Controls.Add(this.linkTenantLE);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogTenantAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a new Tenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.LinkLabel linkTenantLE;
        private System.Windows.Forms.LinkLabel linkTenantAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkVacantLocation;
        private System.Windows.Forms.LinkLabel linkBillTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbBillTo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.CheckBox cbAddress;
    }
}
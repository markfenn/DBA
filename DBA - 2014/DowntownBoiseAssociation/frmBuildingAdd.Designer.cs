namespace DowntownBoiseAssociation
{
    partial class frmBuildingAdd
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkZone = new System.Windows.Forms.LinkLabel();
            this.linkAddress = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(105, 54);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(210, 20);
            this.txtBuildingName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Building Name";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(237, 80);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(156, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Block";
            // 
            // linkZone
            // 
            this.linkZone.AutoSize = true;
            this.linkZone.BackColor = System.Drawing.Color.Transparent;
            this.linkZone.Location = new System.Drawing.Point(102, 9);
            this.linkZone.Name = "linkZone";
            this.linkZone.Size = new System.Drawing.Size(89, 13);
            this.linkZone.TabIndex = 27;
            this.linkZone.TabStop = true;
            this.linkZone.Text = "NOT SELECTED";
            this.linkZone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkZone_LinkClicked);
            // 
            // linkAddress
            // 
            this.linkAddress.AutoSize = true;
            this.linkAddress.BackColor = System.Drawing.Color.Transparent;
            this.linkAddress.Location = new System.Drawing.Point(102, 32);
            this.linkAddress.Name = "linkAddress";
            this.linkAddress.Size = new System.Drawing.Size(89, 13);
            this.linkAddress.TabIndex = 29;
            this.linkAddress.TabStop = true;
            this.linkAddress.Text = "NOT SELECTED";
            this.linkAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddress_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Address";
            // 
            // frmBuildingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(324, 115);
            this.ControlBox = false;
            this.Controls.Add(this.linkAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuildingAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Building - Add New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkZone;
        private System.Windows.Forms.LinkLabel linkAddress;
        private System.Windows.Forms.Label label1;
    }
}
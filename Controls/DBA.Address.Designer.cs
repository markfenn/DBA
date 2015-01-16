namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_Address
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtStreetSuite = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.cbStreetDirection = new System.Windows.Forms.ComboBox();
            this.cbStreetSuffix = new System.Windows.Forms.ComboBox();
            this.txtAddressAll = new System.Windows.Forms.TextBox();
            this.btnNewAddress = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(76, 0);
            this.txtStreetNumber.MaxLength = 10;
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(54, 20);
            this.txtStreetNumber.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(76, 23);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(356, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(76, 46);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(40, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(178, 46);
            this.txtZipCode.MaxLength = 15;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(106, 20);
            this.txtZipCode.TabIndex = 7;
            // 
            // txtStreetSuite
            // 
            this.txtStreetSuite.Location = new System.Drawing.Point(378, 0);
            this.txtStreetSuite.MaxLength = 10;
            this.txtStreetSuite.Name = "txtStreetSuite";
            this.txtStreetSuite.Size = new System.Drawing.Size(54, 20);
            this.txtStreetSuite.TabIndex = 4;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(185, 0);
            this.txtStreetName.MaxLength = 50;
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(135, 20);
            this.txtStreetName.TabIndex = 2;
            // 
            // cbStreetDirection
            // 
            this.cbStreetDirection.FormattingEnabled = true;
            this.cbStreetDirection.Location = new System.Drawing.Point(136, 0);
            this.cbStreetDirection.Name = "cbStreetDirection";
            this.cbStreetDirection.Size = new System.Drawing.Size(46, 21);
            this.cbStreetDirection.TabIndex = 1;
            // 
            // cbStreetSuffix
            // 
            this.cbStreetSuffix.FormattingEnabled = true;
            this.cbStreetSuffix.Location = new System.Drawing.Point(326, 0);
            this.cbStreetSuffix.Name = "cbStreetSuffix";
            this.cbStreetSuffix.Size = new System.Drawing.Size(46, 21);
            this.cbStreetSuffix.TabIndex = 3;
            // 
            // txtAddressAll
            // 
            this.txtAddressAll.Location = new System.Drawing.Point(76, 0);
            this.txtAddressAll.MaxLength = 50;
            this.txtAddressAll.Name = "txtAddressAll";
            this.txtAddressAll.ReadOnly = true;
            this.txtAddressAll.Size = new System.Drawing.Size(356, 20);
            this.txtAddressAll.TabIndex = 0;
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Location = new System.Drawing.Point(326, 49);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(106, 18);
            this.btnNewAddress.TabIndex = 39;
            this.btnNewAddress.TabStop = true;
            this.btnNewAddress.Text = "Select New Address";
            this.btnNewAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNewAddress.Visible = false;
            this.btnNewAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnNewAddress_LinkClicked);
            // 
            // DBA_Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtAddressAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewAddress);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.cbStreetSuffix);
            this.Controls.Add(this.cbStreetDirection);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.txtStreetSuite);
            this.Name = "DBA_Address";
            this.Size = new System.Drawing.Size(448, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStreetSuite;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.ComboBox cbStreetDirection;
        private System.Windows.Forms.ComboBox cbStreetSuffix;
        private System.Windows.Forms.TextBox txtAddressAll;
        private System.Windows.Forms.LinkLabel btnNewAddress;
    }
}

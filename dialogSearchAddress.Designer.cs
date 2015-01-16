namespace DowntownBoiseAssociation
{
    partial class dialogSearchAddress
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
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.cbStreetSuffix = new System.Windows.Forms.ComboBox();
            this.cbStreetDirection = new System.Windows.Forms.ComboBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtStreetSuite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(62, 12);
            this.txtStreetNumber.MaxLength = 10;
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(54, 20);
            this.txtStreetNumber.TabIndex = 0;
            // 
            // cbStreetSuffix
            // 
            this.cbStreetSuffix.FormattingEnabled = true;
            this.cbStreetSuffix.Location = new System.Drawing.Point(330, 11);
            this.cbStreetSuffix.Name = "cbStreetSuffix";
            this.cbStreetSuffix.Size = new System.Drawing.Size(60, 21);
            this.cbStreetSuffix.TabIndex = 3;
            // 
            // cbStreetDirection
            // 
            this.cbStreetDirection.FormattingEnabled = true;
            this.cbStreetDirection.Location = new System.Drawing.Point(122, 11);
            this.cbStreetDirection.Name = "cbStreetDirection";
            this.cbStreetDirection.Size = new System.Drawing.Size(61, 21);
            this.cbStreetDirection.TabIndex = 1;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(189, 12);
            this.txtStreetName.MaxLength = 50;
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(135, 20);
            this.txtStreetName.TabIndex = 2;
            // 
            // txtStreetSuite
            // 
            this.txtStreetSuite.Location = new System.Drawing.Point(396, 11);
            this.txtStreetSuite.MaxLength = 10;
            this.txtStreetSuite.Name = "txtStreetSuite";
            this.txtStreetSuite.Size = new System.Drawing.Size(54, 20);
            this.txtStreetSuite.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(507, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 14;
            this.lbSearch.Location = new System.Drawing.Point(14, 48);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(568, 326);
            this.lbSearch.TabIndex = 49;
            this.lbSearch.DoubleClick += new System.EventHandler(this.lbSearch_DoubleClick);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(507, 386);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 50;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(426, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewAddress.Location = new System.Drawing.Point(12, 386);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(87, 23);
            this.btnNewAddress.TabIndex = 52;
            this.btnNewAddress.Text = "&New Address";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new System.EventHandler(this.btnNewAddress_Click);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditAddress.Location = new System.Drawing.Point(105, 386);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(87, 23);
            this.btnEditAddress.TabIndex = 53;
            this.btnEditAddress.Text = "&Edit Address";
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // dialogSearchAddress
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(594, 418);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditAddress);
            this.Controls.Add(this.btnNewAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.cbStreetSuffix);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbStreetDirection);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.txtStreetSuite);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogSearchAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Address Search";
            this.Load += new System.EventHandler(this.frmDialogSearchAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.ComboBox cbStreetSuffix;
        private System.Windows.Forms.ComboBox cbStreetDirection;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtStreetSuite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSearch;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewAddress;
        private System.Windows.Forms.Button btnEditAddress;
    }
}
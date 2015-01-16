namespace DowntownBoiseAssociation
{
    partial class frmTenantNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTenantNew));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.linkBlank = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneralInformation = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.AddressTenant = new DowntownBoiseAssociation.Controls.DBA_Address();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLegalEntity = new System.Windows.Forms.LinkLabel();
            this.btnDateClosed = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.ddDateClosed = new System.Windows.Forms.DateTimePicker();
            this.txtDateClosed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddDateBegin = new System.Windows.Forms.DateTimePicker();
            this.txtDateBegin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.txtAppInfo = new System.Windows.Forms.TextBox();
            this.Blink = new System.Windows.Forms.Timer(this.components);
            this.dbaLocation = new DowntownBoiseAssociation.Controls.DBA_Location();
            this.frmOldForm = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneralInformation.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.linkBlank);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel4);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel5);
            this.flowLayoutPanel1.Controls.Add(this.frmOldForm);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 487);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "TENANT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(13, 115);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(125, 23);
            this.linkLabel2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(13, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 23);
            this.linkLabel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Close out Tenant";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(13, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 14;
            this.button5.Text = "Move this Tenant";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // linkBlank
            // 
            this.linkBlank.Location = new System.Drawing.Point(13, 269);
            this.linkBlank.Name = "linkBlank";
            this.linkBlank.Size = new System.Drawing.Size(125, 23);
            this.linkBlank.TabIndex = 2;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Location = new System.Drawing.Point(13, 292);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(125, 23);
            this.linkLabel4.TabIndex = 17;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Change Legal Entity";
            // 
            // linkLabel5
            // 
            this.linkLabel5.Location = new System.Drawing.Point(13, 315);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(125, 23);
            this.linkLabel5.TabIndex = 18;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Change Bill To Entity";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(177, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 460);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeneralInformation);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneralInformation
            // 
            this.tabGeneralInformation.Controls.Add(this.label4);
            this.tabGeneralInformation.Controls.Add(this.label3);
            this.tabGeneralInformation.Controls.Add(this.linkLabel3);
            this.tabGeneralInformation.Controls.Add(this.AddressTenant);
            this.tabGeneralInformation.Controls.Add(this.label7);
            this.tabGeneralInformation.Controls.Add(this.linkLegalEntity);
            this.tabGeneralInformation.Controls.Add(this.btnDateClosed);
            this.tabGeneralInformation.Controls.Add(this.label6);
            this.tabGeneralInformation.Controls.Add(this.ddDateClosed);
            this.tabGeneralInformation.Controls.Add(this.txtDateClosed);
            this.tabGeneralInformation.Controls.Add(this.label5);
            this.tabGeneralInformation.Controls.Add(this.ddDateBegin);
            this.tabGeneralInformation.Controls.Add(this.txtDateBegin);
            this.tabGeneralInformation.Controls.Add(this.txtName);
            this.tabGeneralInformation.Controls.Add(this.label2);
            this.tabGeneralInformation.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralInformation.Name = "tabGeneralInformation";
            this.tabGeneralInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInformation.Size = new System.Drawing.Size(587, 430);
            this.tabGeneralInformation.TabIndex = 0;
            this.tabGeneralInformation.Text = "General Information";
            this.tabGeneralInformation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "(Only important if this Tenant is set to recieve a bill and not the building)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Bill To Entity";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(90, 248);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(79, 13);
            this.linkLabel3.TabIndex = 52;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "No Legal Entity";
            // 
            // AddressTenant
            // 
            this.AddressTenant.AddressId = 0;
            this.AddressTenant.BackColor = System.Drawing.Color.Transparent;
            this.AddressTenant.Location = new System.Drawing.Point(18, 95);
            this.AddressTenant.Name = "AddressTenant";
            this.AddressTenant.Size = new System.Drawing.Size(448, 68);
            this.AddressTenant.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Legal Entity";
            // 
            // linkLegalEntity
            // 
            this.linkLegalEntity.AutoSize = true;
            this.linkLegalEntity.Location = new System.Drawing.Point(90, 57);
            this.linkLegalEntity.Name = "linkLegalEntity";
            this.linkLegalEntity.Size = new System.Drawing.Size(79, 13);
            this.linkLegalEntity.TabIndex = 49;
            this.linkLegalEntity.TabStop = true;
            this.linkLegalEntity.Text = "No Legal Entity";
            this.linkLegalEntity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLegalEntity_LinkClicked);
            // 
            // btnDateClosed
            // 
            this.btnDateClosed.AutoSize = true;
            this.btnDateClosed.Location = new System.Drawing.Point(204, 210);
            this.btnDateClosed.Name = "btnDateClosed";
            this.btnDateClosed.Size = new System.Drawing.Size(33, 13);
            this.btnDateClosed.TabIndex = 48;
            this.btnDateClosed.TabStop = true;
            this.btnDateClosed.Text = "blank";
            this.btnDateClosed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDateClosed_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Closed";
            // 
            // ddDateClosed
            // 
            this.ddDateClosed.Location = new System.Drawing.Point(183, 207);
            this.ddDateClosed.Name = "ddDateClosed";
            this.ddDateClosed.Size = new System.Drawing.Size(18, 20);
            this.ddDateClosed.TabIndex = 46;
            this.ddDateClosed.ValueChanged += new System.EventHandler(this.ddDateClosed_ValueChanged);
            // 
            // txtDateClosed
            // 
            this.txtDateClosed.Enabled = false;
            this.txtDateClosed.Location = new System.Drawing.Point(93, 207);
            this.txtDateClosed.Name = "txtDateClosed";
            this.txtDateClosed.Size = new System.Drawing.Size(92, 20);
            this.txtDateClosed.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Opened";
            // 
            // ddDateBegin
            // 
            this.ddDateBegin.Location = new System.Drawing.Point(183, 184);
            this.ddDateBegin.Name = "ddDateBegin";
            this.ddDateBegin.Size = new System.Drawing.Size(18, 20);
            this.ddDateBegin.TabIndex = 42;
            this.ddDateBegin.ValueChanged += new System.EventHandler(this.ddDateBegin_ValueChanged);
            // 
            // txtDateBegin
            // 
            this.txtDateBegin.Enabled = false;
            this.txtDateBegin.Location = new System.Drawing.Point(93, 184);
            this.txtDateBegin.Name = "txtDateBegin";
            this.txtDateBegin.Size = new System.Drawing.Size(92, 20);
            this.txtDateBegin.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 20);
            this.txtName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.txtAppInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(587, 430);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Technical Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // txtAppInfo
            // 
            this.txtAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppInfo.Location = new System.Drawing.Point(6, 9);
            this.txtAppInfo.Multiline = true;
            this.txtAppInfo.Name = "txtAppInfo";
            this.txtAppInfo.Size = new System.Drawing.Size(575, 415);
            this.txtAppInfo.TabIndex = 1;
            // 
            // Blink
            // 
            this.Blink.Interval = 200;
            this.Blink.Tick += new System.EventHandler(this.Blink_Tick);
            // 
            // dbaLocation
            // 
            this.dbaLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbaLocation.Location = new System.Drawing.Point(177, 12);
            this.dbaLocation.Name = "dbaLocation";
            this.dbaLocation.Size = new System.Drawing.Size(595, 21);
            this.dbaLocation.TabIndex = 2;
            // 
            // frmOldForm
            // 
            this.frmOldForm.Location = new System.Drawing.Point(13, 338);
            this.frmOldForm.Name = "frmOldForm";
            this.frmOldForm.Size = new System.Drawing.Size(125, 23);
            this.frmOldForm.TabIndex = 19;
            this.frmOldForm.TabStop = true;
            this.frmOldForm.Text = "Old Form";
            this.frmOldForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frmOldForm_LinkClicked);
            // 
            // frmTenantNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.dbaLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmTenantNew";
            this.Text = "frmTenantNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTenantNew_FormClosing);
            this.Load += new System.EventHandler(this.frmTenantNew_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneralInformation.ResumeLayout(false);
            this.tabGeneralInformation.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkBlank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private Controls.DBA_Location dbaLocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneralInformation;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppInfo;
        private System.Windows.Forms.DateTimePicker ddDateBegin;
        private System.Windows.Forms.TextBox txtDateBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btnDateClosed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ddDateClosed;
        private System.Windows.Forms.TextBox txtDateClosed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLegalEntity;
        private Controls.DBA_Address AddressTenant;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Timer Blink;
        private System.Windows.Forms.LinkLabel frmOldForm;


    }
}
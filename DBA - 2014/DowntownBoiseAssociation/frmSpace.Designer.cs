namespace DowntownBoiseAssociation
{
    partial class frmSpace
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpace));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddressSpace = new DowntownBoiseAssociation.Controls.DBA_Address();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtParcelNo = new System.Windows.Forms.TextBox();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTenant = new System.Windows.Forms.TabPage();
            this.dataGridViewTenant = new System.Windows.Forms.DataGridView();
            this.TenantName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaceTenantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOwners = new System.Windows.Forms.TabPage();
            this.dataGridViewOwner = new System.Windows.Forms.DataGridView();
            this.colOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.PropertiesSpace = new DowntownBoiseAssociation.Controls.editProperties();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.CommentDisplaySpace = new DowntownBoiseAssociation.Controls.DBA_CommentDisplay();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.ContactDisplaySpace = new DowntownBoiseAssociation.Controls.DBA_ContactDisplay();
            this.tabAppInfo = new System.Windows.Forms.TabPage();
            this.txtAppInfo = new System.Windows.Forms.TextBox();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSpace = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewOwner = new System.Windows.Forms.Button();
            this.btnDeleteSpace = new System.Windows.Forms.Button();
            this.btnEditOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).BeginInit();
            this.tabOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).BeginInit();
            this.tabProperties.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tabAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressSpace);
            this.groupBox1.Location = new System.Drawing.Point(18, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Space Address";
            // 
            // AddressSpace
            // 
            this.AddressSpace.AddressId = 0;
            this.AddressSpace.BackColor = System.Drawing.Color.Transparent;
            this.AddressSpace.Location = new System.Drawing.Point(6, 19);
            this.AddressSpace.Name = "AddressSpace";
            this.AddressSpace.Size = new System.Drawing.Size(447, 68);
            this.AddressSpace.TabIndex = 0;
            this.AddressSpace.AddressChange += new DowntownBoiseAssociation.Controls.AddressChangeEventHandler(this.AddressSpace_AddressChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Building";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(99, 12);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.ReadOnly = true;
            this.txtBuilding.Size = new System.Drawing.Size(341, 20);
            this.txtBuilding.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtParcelNo);
            this.groupBox6.Controls.Add(this.txtSqFt);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(18, 181);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 46);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Space Properties";
            // 
            // txtParcelNo
            // 
            this.txtParcelNo.Location = new System.Drawing.Point(222, 16);
            this.txtParcelNo.Name = "txtParcelNo";
            this.txtParcelNo.Size = new System.Drawing.Size(194, 20);
            this.txtParcelNo.TabIndex = 19;
            // 
            // txtSqFt
            // 
            this.txtSqFt.Location = new System.Drawing.Point(61, 16);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.Size = new System.Drawing.Size(100, 20);
            this.txtSqFt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SqFt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parcel No";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTenant);
            this.tabControl1.Controls.Add(this.tabOwners);
            this.tabControl1.Controls.Add(this.tabProperties);
            this.tabControl1.Controls.Add(this.tabNotes);
            this.tabControl1.Controls.Add(this.tabContacts);
            this.tabControl1.Controls.Add(this.tabAppInfo);
            this.tabControl1.Location = new System.Drawing.Point(18, 237);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 313);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTenant
            // 
            this.tabTenant.Controls.Add(this.dataGridViewTenant);
            this.tabTenant.Location = new System.Drawing.Point(4, 22);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenant.Size = new System.Drawing.Size(646, 287);
            this.tabTenant.TabIndex = 0;
            this.tabTenant.Text = "Tenant List";
            this.tabTenant.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTenant
            // 
            this.dataGridViewTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantName,
            this.StartDate,
            this.EndDate,
            this.TenantId,
            this.SpaceTenantId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTenant.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTenant.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTenant.MultiSelect = false;
            this.dataGridViewTenant.Name = "dataGridViewTenant";
            this.dataGridViewTenant.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTenant.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTenant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTenant.Size = new System.Drawing.Size(648, 278);
            this.dataGridViewTenant.TabIndex = 0;
            this.dataGridViewTenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTenant_CellContentClick);
            // 
            // TenantName
            // 
            this.TenantName.DataPropertyName = "TenantName";
            this.TenantName.HeaderText = "Tenant Name";
            this.TenantName.Name = "TenantName";
            this.TenantName.ReadOnly = true;
            this.TenantName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenantName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenantName.Width = 250;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle2.Format = "MM/dd/yyyy";
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Format = "MM/dd/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // TenantId
            // 
            this.TenantId.DataPropertyName = "TenantId";
            this.TenantId.HeaderText = "TenantId";
            this.TenantId.Name = "TenantId";
            this.TenantId.ReadOnly = true;
            this.TenantId.Visible = false;
            // 
            // SpaceTenantId
            // 
            this.SpaceTenantId.DataPropertyName = "SpaceTenantId";
            this.SpaceTenantId.HeaderText = "SpaceTenantId";
            this.SpaceTenantId.Name = "SpaceTenantId";
            this.SpaceTenantId.ReadOnly = true;
            this.SpaceTenantId.Visible = false;
            // 
            // tabOwners
            // 
            this.tabOwners.Controls.Add(this.dataGridViewOwner);
            this.tabOwners.Location = new System.Drawing.Point(4, 22);
            this.tabOwners.Name = "tabOwners";
            this.tabOwners.Padding = new System.Windows.Forms.Padding(3);
            this.tabOwners.Size = new System.Drawing.Size(646, 287);
            this.tabOwners.TabIndex = 1;
            this.tabOwners.Text = "Owner List";
            this.tabOwners.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOwner
            // 
            this.dataGridViewOwner.AllowUserToAddRows = false;
            this.dataGridViewOwner.AllowUserToDeleteRows = false;
            this.dataGridViewOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOwner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOwnerName,
            this.colAsOfDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOwner.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOwner.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOwner.MultiSelect = false;
            this.dataGridViewOwner.Name = "dataGridViewOwner";
            this.dataGridViewOwner.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOwner.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOwner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOwner.Size = new System.Drawing.Size(648, 285);
            this.dataGridViewOwner.TabIndex = 1;
            // 
            // colOwnerName
            // 
            this.colOwnerName.DataPropertyName = "OwnerName";
            this.colOwnerName.HeaderText = "Owner Name";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.ReadOnly = true;
            this.colOwnerName.Width = 250;
            // 
            // colAsOfDate
            // 
            this.colAsOfDate.DataPropertyName = "AsOfDate";
            this.colAsOfDate.HeaderText = "As Of Date";
            this.colAsOfDate.Name = "colAsOfDate";
            this.colAsOfDate.ReadOnly = true;
            this.colAsOfDate.Width = 150;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.PropertiesSpace);
            this.tabProperties.Location = new System.Drawing.Point(4, 22);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Size = new System.Drawing.Size(646, 287);
            this.tabProperties.TabIndex = 3;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // PropertiesSpace
            // 
            this.PropertiesSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertiesSpace.AutoScroll = true;
            this.PropertiesSpace.DisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("PropertiesSpace.DisplayGroups")));
            this.PropertiesSpace.Location = new System.Drawing.Point(3, 3);
            this.PropertiesSpace.Name = "PropertiesSpace";
            this.PropertiesSpace.NonDisplayGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("PropertiesSpace.NonDisplayGroups")));
            this.PropertiesSpace.Size = new System.Drawing.Size(648, 282);
            this.PropertiesSpace.TabIndex = 0;
            this.PropertiesSpace.Load += new System.EventHandler(this.PropertiesSpace_Load);
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.CommentDisplaySpace);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(646, 287);
            this.tabNotes.TabIndex = 2;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // CommentDisplaySpace
            // 
            this.CommentDisplaySpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentDisplaySpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CommentDisplaySpace.Location = new System.Drawing.Point(3, 3);
            this.CommentDisplaySpace.Name = "CommentDisplaySpace";
            this.CommentDisplaySpace.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.CommentDisplaySpace.Size = new System.Drawing.Size(640, 281);
            this.CommentDisplaySpace.TabIndex = 0;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.ContactDisplaySpace);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Size = new System.Drawing.Size(646, 287);
            this.tabContacts.TabIndex = 4;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // ContactDisplaySpace
            // 
            this.ContactDisplaySpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDisplaySpace.Location = new System.Drawing.Point(2, 0);
            this.ContactDisplaySpace.MinimumSize = new System.Drawing.Size(0, 275);
            this.ContactDisplaySpace.Name = "ContactDisplaySpace";
            this.ContactDisplaySpace.ObjectGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ContactDisplaySpace.Size = new System.Drawing.Size(649, 280);
            this.ContactDisplaySpace.TabIndex = 0;
            // 
            // tabAppInfo
            // 
            this.tabAppInfo.Controls.Add(this.txtAppInfo);
            this.tabAppInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAppInfo.Name = "tabAppInfo";
            this.tabAppInfo.Size = new System.Drawing.Size(646, 287);
            this.tabAppInfo.TabIndex = 5;
            this.tabAppInfo.Text = "App Info";
            this.tabAppInfo.UseVisualStyleBackColor = true;
            // 
            // txtAppInfo
            // 
            this.txtAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppInfo.Location = new System.Drawing.Point(0, 0);
            this.txtAppInfo.Multiline = true;
            this.txtAppInfo.Name = "txtAppInfo";
            this.txtAppInfo.Size = new System.Drawing.Size(650, 291);
            this.txtAppInfo.TabIndex = 0;
            // 
            // txtTenant
            // 
            this.txtTenant.Location = new System.Drawing.Point(99, 35);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.ReadOnly = true;
            this.txtTenant.Size = new System.Drawing.Size(341, 20);
            this.txtTenant.TabIndex = 24;
            this.txtTenant.Text = "No Tenant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Current Tenant";
            // 
            // btnSaveSpace
            // 
            this.btnSaveSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSpace.Location = new System.Drawing.Point(565, 12);
            this.btnSaveSpace.Name = "btnSaveSpace";
            this.btnSaveSpace.Size = new System.Drawing.Size(102, 23);
            this.btnSaveSpace.TabIndex = 25;
            this.btnSaveSpace.Text = "&Save";
            this.btnSaveSpace.UseVisualStyleBackColor = true;
            this.btnSaveSpace.Click += new System.EventHandler(this.btnSaveSpace_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(565, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(99, 58);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(341, 20);
            this.txtOwner.TabIndex = 28;
            this.txtOwner.Text = "No Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current Owner";
            // 
            // btnNewOwner
            // 
            this.btnNewOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOwner.Location = new System.Drawing.Point(566, 152);
            this.btnNewOwner.Name = "btnNewOwner";
            this.btnNewOwner.Size = new System.Drawing.Size(102, 23);
            this.btnNewOwner.TabIndex = 29;
            this.btnNewOwner.Text = "&Add New Owner";
            this.btnNewOwner.UseVisualStyleBackColor = true;
            this.btnNewOwner.Click += new System.EventHandler(this.btnNewOwner_Click);
            // 
            // btnDeleteSpace
            // 
            this.btnDeleteSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSpace.Location = new System.Drawing.Point(566, 82);
            this.btnDeleteSpace.Name = "btnDeleteSpace";
            this.btnDeleteSpace.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteSpace.TabIndex = 30;
            this.btnDeleteSpace.Text = "&Delete";
            this.btnDeleteSpace.UseVisualStyleBackColor = true;
            this.btnDeleteSpace.Click += new System.EventHandler(this.btnDeleteSpace_Click);
            // 
            // btnEditOwner
            // 
            this.btnEditOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOwner.Location = new System.Drawing.Point(566, 181);
            this.btnEditOwner.Name = "btnEditOwner";
            this.btnEditOwner.Size = new System.Drawing.Size(102, 23);
            this.btnEditOwner.TabIndex = 31;
            this.btnEditOwner.Text = "&Edit Owner";
            this.btnEditOwner.UseVisualStyleBackColor = true;
            this.btnEditOwner.Click += new System.EventHandler(this.btnEditOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOwner.Location = new System.Drawing.Point(566, 210);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteOwner.TabIndex = 32;
            this.btnDeleteOwner.Text = "Delete &Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(642, 116);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 30);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnEditOwner);
            this.Controls.Add(this.btnDeleteSpace);
            this.Controls.Add(this.btnNewOwner);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveSpace);
            this.Controls.Add(this.txtTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtBuilding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "frmSpace";
            this.Text = "frmSpace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSpace_FormClosing);
            this.Load += new System.EventHandler(this.frmSpace_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).EndInit();
            this.tabOwners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).EndInit();
            this.tabProperties.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.tabAppInfo.ResumeLayout(false);
            this.tabAppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private DowntownBoiseAssociation.Controls.DBA_Address AddressSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtParcelNo;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTenant;
        private System.Windows.Forms.TabPage tabOwners;
        private System.Windows.Forms.TabPage tabNotes;
        private DowntownBoiseAssociation.Controls.DBA_CommentDisplay CommentDisplaySpace;
        private System.Windows.Forms.DataGridView dataGridViewTenant;
        private System.Windows.Forms.DataGridView dataGridViewOwner;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewLinkColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaceTenantId;
        private System.Windows.Forms.Button btnSaveSpace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewOwner;
        private System.Windows.Forms.TabPage tabProperties;
        private System.Windows.Forms.TabPage tabContacts;
        private DowntownBoiseAssociation.Controls.DBA_ContactDisplay ContactDisplaySpace;
        private DowntownBoiseAssociation.Controls.editProperties PropertiesSpace;
        private System.Windows.Forms.Button btnDeleteSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsOfDate;
        private System.Windows.Forms.Button btnEditOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.TabPage tabAppInfo;
        private System.Windows.Forms.TextBox txtAppInfo;
        private System.Windows.Forms.Button btnRefresh;
    }
}
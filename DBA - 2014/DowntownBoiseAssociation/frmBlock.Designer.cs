namespace DowntownBoiseAssociation
{
    partial class frmBlock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.blockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetBlocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSubdivisionNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.minAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaxAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCityBlock = new System.Windows.Forms.Label();
            this.LblLotFrom = new System.Windows.Forms.Label();
            this.txtLotTo = new System.Windows.Forms.TextBox();
            this.txtCityBlock = new System.Windows.Forms.TextBox();
            this.txtLotFrom = new System.Windows.Forms.TextBox();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.lblBlockName = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.grpStreets = new System.Windows.Forms.GroupBox();
            this.grdStreets = new System.Windows.Forms.DataGridView();
            this.StreetId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboZoneId = new System.Windows.Forms.ComboBox();
            this.cmbSubdivision = new System.Windows.Forms.ComboBox();
            this.lblSubdivision = new System.Windows.Forms.Label();
            this.grpBuildings = new System.Windows.Forms.GroupBox();
            this.grdBuildings = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblLotTo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkBlockSelect = new System.Windows.Forms.LinkLabel();
            this.SelectedBlocksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBlocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubdivisionNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            this.grpStreets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStreets)).BeginInit();
            this.grpBuildings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuildings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(584, 488);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(503, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // blockBindingSource
            // 
            this.blockBindingSource.DataSource = typeof(DowntownBoiseAssociation.Block);
            // 
            // streetBlocksBindingSource
            // 
            this.streetBlocksBindingSource.DataMember = "StreetBlocks";
            this.streetBlocksBindingSource.DataSource = this.blockBindingSource;
            // 
            // zoneBindingSource
            // 
            this.zoneBindingSource.DataSource = typeof(DowntownBoiseAssociation.Zone);
            // 
            // vwSubdivisionNameBindingSource
            // 
            this.vwSubdivisionNameBindingSource.DataSource = typeof(DowntownBoiseAssociation.vw_SubdivisionName);
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "StreetId";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.streetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.streetDataGridViewTextBoxColumn.Width = 250;
            // 
            // minAddressDataGridViewTextBoxColumn
            // 
            this.minAddressDataGridViewTextBoxColumn.DataPropertyName = "MinAddress";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.minAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.minAddressDataGridViewTextBoxColumn.HeaderText = "Address From";
            this.minAddressDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.minAddressDataGridViewTextBoxColumn.Name = "minAddressDataGridViewTextBoxColumn";
            this.minAddressDataGridViewTextBoxColumn.Width = 75;
            // 
            // maxAddressDataGridViewTextBoxColumn
            // 
            this.maxAddressDataGridViewTextBoxColumn.DataPropertyName = "MaxAddress";
            this.maxAddressDataGridViewTextBoxColumn.HeaderText = "Address To";
            this.maxAddressDataGridViewTextBoxColumn.Name = "maxAddressDataGridViewTextBoxColumn";
            // 
            // streetIdDataGridViewTextBoxColumn
            // 
            this.streetIdDataGridViewTextBoxColumn.DataPropertyName = "StreetId";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.streetIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.streetIdDataGridViewTextBoxColumn.HeaderText = "StreetId";
            this.streetIdDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.streetIdDataGridViewTextBoxColumn.Name = "streetIdDataGridViewTextBoxColumn";
            this.streetIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.streetIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaxAddress
            // 
            this.MaxAddress.DataPropertyName = "MaxAddress";
            this.MaxAddress.HeaderText = "MaxAddress";
            this.MaxAddress.Name = "MaxAddress";
            // 
            // MinAddress
            // 
            this.MinAddress.DataPropertyName = "MinAddress";
            this.MinAddress.HeaderText = "MinAddress";
            this.MinAddress.Name = "MinAddress";
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.blockBindingSource;
            // 
            // lblCityBlock
            // 
            this.lblCityBlock.AutoSize = true;
            this.lblCityBlock.Location = new System.Drawing.Point(304, 70);
            this.lblCityBlock.Name = "lblCityBlock";
            this.lblCityBlock.Size = new System.Drawing.Size(57, 13);
            this.lblCityBlock.TabIndex = 21;
            this.lblCityBlock.Text = "City Block:";
            this.lblCityBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblLotFrom
            // 
            this.LblLotFrom.AutoSize = true;
            this.LblLotFrom.Location = new System.Drawing.Point(448, 70);
            this.LblLotFrom.Name = "LblLotFrom";
            this.LblLotFrom.Size = new System.Drawing.Size(51, 13);
            this.LblLotFrom.TabIndex = 22;
            this.LblLotFrom.Text = "Lot From:";
            this.LblLotFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLotTo
            // 
            this.txtLotTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockBindingSource, "LotTo", true));
            this.txtLotTo.Location = new System.Drawing.Point(595, 66);
            this.txtLotTo.MaxLength = 5;
            this.txtLotTo.Name = "txtLotTo";
            this.txtLotTo.Size = new System.Drawing.Size(42, 20);
            this.txtLotTo.TabIndex = 20;
            this.txtLotTo.Tag = "Block Name:";
            // 
            // txtCityBlock
            // 
            this.txtCityBlock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockBindingSource, "CityBlockNo", true));
            this.txtCityBlock.Location = new System.Drawing.Point(373, 66);
            this.txtCityBlock.MaxLength = 10;
            this.txtCityBlock.Name = "txtCityBlock";
            this.txtCityBlock.Size = new System.Drawing.Size(37, 20);
            this.txtCityBlock.TabIndex = 18;
            this.txtCityBlock.Tag = "City Block:";
            this.txtCityBlock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCityBlock_KeyDown);
            // 
            // txtLotFrom
            // 
            this.txtLotFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockBindingSource, "LotFrom", true));
            this.txtLotFrom.Location = new System.Drawing.Point(505, 66);
            this.txtLotFrom.MaxLength = 5;
            this.txtLotFrom.Name = "txtLotFrom";
            this.txtLotFrom.Size = new System.Drawing.Size(38, 20);
            this.txtLotFrom.TabIndex = 19;
            this.txtLotFrom.Tag = "Block Name:";
            // 
            // txtBlockName
            // 
            this.txtBlockName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockBindingSource, "Name", true));
            this.txtBlockName.Enabled = false;
            this.txtBlockName.Location = new System.Drawing.Point(86, 19);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(200, 20);
            this.txtBlockName.TabIndex = 2;
            this.txtBlockName.Tag = "Block Name:";
            // 
            // lblBlockName
            // 
            this.lblBlockName.AutoSize = true;
            this.lblBlockName.Location = new System.Drawing.Point(12, 22);
            this.lblBlockName.Name = "lblBlockName";
            this.lblBlockName.Size = new System.Drawing.Size(68, 13);
            this.lblBlockName.TabIndex = 3;
            this.lblBlockName.Text = "Block Name:";
            this.lblBlockName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(12, 93);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(35, 13);
            this.lblZone.TabIndex = 14;
            this.lblZone.Text = "Zone:";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStreets
            // 
            this.grpStreets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStreets.Controls.Add(this.grdStreets);
            this.grpStreets.Location = new System.Drawing.Point(5, 170);
            this.grpStreets.Name = "grpStreets";
            this.grpStreets.Size = new System.Drawing.Size(654, 165);
            this.grpStreets.TabIndex = 9;
            this.grpStreets.TabStop = false;
            this.grpStreets.Text = "Streets";
            // 
            // grdStreets
            // 
            this.grdStreets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStreets.AutoGenerateColumns = false;
            this.grdStreets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStreets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StreetId,
            this.directionDataGridViewTextBoxColumn,
            this.minAddressDataGridViewTextBoxColumn1,
            this.maxAddressDataGridViewTextBoxColumn1});
            this.grdStreets.DataSource = this.streetBlocksBindingSource;
            this.grdStreets.Location = new System.Drawing.Point(15, 19);
            this.grdStreets.Name = "grdStreets";
            this.grdStreets.ShowCellErrors = false;
            this.grdStreets.ShowRowErrors = false;
            this.grdStreets.Size = new System.Drawing.Size(622, 134);
            this.grdStreets.TabIndex = 10;
            this.grdStreets.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdStreets_DataError);
            // 
            // StreetId
            // 
            this.StreetId.DataPropertyName = "StreetId";
            this.StreetId.HeaderText = "Street";
            this.StreetId.Name = "StreetId";
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            // 
            // minAddressDataGridViewTextBoxColumn1
            // 
            this.minAddressDataGridViewTextBoxColumn1.DataPropertyName = "MinAddress";
            this.minAddressDataGridViewTextBoxColumn1.HeaderText = "MinAddress";
            this.minAddressDataGridViewTextBoxColumn1.Name = "minAddressDataGridViewTextBoxColumn1";
            // 
            // maxAddressDataGridViewTextBoxColumn1
            // 
            this.maxAddressDataGridViewTextBoxColumn1.DataPropertyName = "MaxAddress";
            this.maxAddressDataGridViewTextBoxColumn1.HeaderText = "MaxAddress";
            this.maxAddressDataGridViewTextBoxColumn1.Name = "maxAddressDataGridViewTextBoxColumn1";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blockBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(373, 19);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 41);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Tag = "Block Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(304, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // cboZoneId
            // 
            this.cboZoneId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.blockBindingSource, "ZoneId", true));
            this.cboZoneId.DataSource = this.zoneBindingSource;
            this.cboZoneId.DisplayMember = "Name";
            this.cboZoneId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoneId.FormattingEnabled = true;
            this.cboZoneId.Location = new System.Drawing.Point(86, 90);
            this.cboZoneId.Name = "cboZoneId";
            this.cboZoneId.Size = new System.Drawing.Size(200, 21);
            this.cboZoneId.TabIndex = 6;
            this.cboZoneId.ValueMember = "Id";
            // 
            // cmbSubdivision
            // 
            this.cmbSubdivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.blockBindingSource, "Subdivision", true));
            this.cmbSubdivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.blockBindingSource, "Subdivision", true));
            this.cmbSubdivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubdivision.Location = new System.Drawing.Point(86, 66);
            this.cmbSubdivision.Name = "cmbSubdivision";
            this.cmbSubdivision.Size = new System.Drawing.Size(200, 21);
            this.cmbSubdivision.TabIndex = 4;
            // 
            // lblSubdivision
            // 
            this.lblSubdivision.AutoSize = true;
            this.lblSubdivision.Location = new System.Drawing.Point(12, 69);
            this.lblSubdivision.Name = "lblSubdivision";
            this.lblSubdivision.Size = new System.Drawing.Size(64, 13);
            this.lblSubdivision.TabIndex = 6;
            this.lblSubdivision.Text = "Subdivision:";
            this.lblSubdivision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpBuildings
            // 
            this.grpBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuildings.Controls.Add(this.grdBuildings);
            this.grpBuildings.Location = new System.Drawing.Point(5, 341);
            this.grpBuildings.Name = "grpBuildings";
            this.grpBuildings.Size = new System.Drawing.Size(654, 141);
            this.grpBuildings.TabIndex = 11;
            this.grpBuildings.TabStop = false;
            this.grpBuildings.Text = "Buildings";
            // 
            // grdBuildings
            // 
            this.grdBuildings.AllowUserToAddRows = false;
            this.grdBuildings.AllowUserToDeleteRows = false;
            this.grdBuildings.AllowUserToOrderColumns = true;
            this.grdBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBuildings.AutoGenerateColumns = false;
            this.grdBuildings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdBuildings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuildings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn});
            this.grdBuildings.DataSource = this.buildingsBindingSource;
            this.grdBuildings.Location = new System.Drawing.Point(15, 19);
            this.grdBuildings.Name = "grdBuildings";
            this.grdBuildings.ReadOnly = true;
            this.grdBuildings.Size = new System.Drawing.Size(622, 116);
            this.grdBuildings.TabIndex = 12;
            this.grdBuildings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuildings_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.FillWeight = 400F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // lblLotTo
            // 
            this.lblLotTo.AutoSize = true;
            this.lblLotTo.Location = new System.Drawing.Point(549, 70);
            this.lblLotTo.Name = "lblLotTo";
            this.lblLotTo.Size = new System.Drawing.Size(41, 13);
            this.lblLotTo.TabIndex = 23;
            this.lblLotTo.Text = "Lot To:";
            this.lblLotTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblSubdivision);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtLotTo);
            this.groupBox1.Controls.Add(this.cmbSubdivision);
            this.groupBox1.Controls.Add(this.LblLotFrom);
            this.groupBox1.Controls.Add(this.lblBlockName);
            this.groupBox1.Controls.Add(this.txtLotFrom);
            this.groupBox1.Controls.Add(this.txtBlockName);
            this.groupBox1.Controls.Add(this.lblCityBlock);
            this.groupBox1.Controls.Add(this.cboZoneId);
            this.groupBox1.Controls.Add(this.lblZone);
            this.groupBox1.Controls.Add(this.lblLotTo);
            this.groupBox1.Controls.Add(this.txtCityBlock);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 123);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block Information";
            // 
            // linkBlockSelect
            // 
            this.linkBlockSelect.AutoSize = true;
            this.linkBlockSelect.BackColor = System.Drawing.Color.Transparent;
            this.linkBlockSelect.Location = new System.Drawing.Point(105, 17);
            this.linkBlockSelect.Name = "linkBlockSelect";
            this.linkBlockSelect.Size = new System.Drawing.Size(89, 13);
            this.linkBlockSelect.TabIndex = 25;
            this.linkBlockSelect.TabStop = true;
            this.linkBlockSelect.Text = "NOT SELECTED";
            this.linkBlockSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBlockSelect_LinkClicked);
            // 
            // SelectedBlocksLabel
            // 
            this.SelectedBlocksLabel.AutoSize = true;
            this.SelectedBlocksLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectedBlocksLabel.Location = new System.Drawing.Point(12, 17);
            this.SelectedBlocksLabel.Name = "SelectedBlocksLabel";
            this.SelectedBlocksLabel.Size = new System.Drawing.Size(82, 13);
            this.SelectedBlocksLabel.TabIndex = 1;
            this.SelectedBlocksLabel.Text = "Selected Block:";
            // 
            // frmBlock
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(671, 522);
            this.Controls.Add(this.linkBlockSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStreets);
            this.Controls.Add(this.grpBuildings);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.SelectedBlocksLabel);
            this.Name = "frmBlock";
            this.Text = "Block Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBlock_FormClosed);
            this.Load += new System.EventHandler(this.frmBlock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBlocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubdivisionNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            this.grpStreets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStreets)).EndInit();
            this.grpBuildings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuildings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource blockBindingSource;
        private System.Windows.Forms.BindingSource streetBlocksBindingSource;
        private System.Windows.Forms.BindingSource zoneBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn streetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinAddress;
        private System.Windows.Forms.BindingSource vwSubdivisionNameBindingSource;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Label lblBlockName;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.GroupBox grpStreets;
        private System.Windows.Forms.DataGridView grdStreets;
        private System.Windows.Forms.DataGridViewComboBoxColumn StreetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboZoneId;
        private System.Windows.Forms.ComboBox cmbSubdivision;
        private System.Windows.Forms.Label lblSubdivision;
        private System.Windows.Forms.GroupBox grpBuildings;
        private System.Windows.Forms.DataGridView grdBuildings;
        private System.Windows.Forms.Label lblCityBlock;
        private System.Windows.Forms.TextBox txtCityBlock;
        private System.Windows.Forms.Label lblLotTo;
        private System.Windows.Forms.Label LblLotFrom;
        private System.Windows.Forms.TextBox txtLotTo;
        private System.Windows.Forms.TextBox txtLotFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewLinkColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkBlockSelect;
        private System.Windows.Forms.Label SelectedBlocksLabel;
    }
}
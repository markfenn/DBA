namespace DowntownBoiseAssociation
{
    partial class frmAdminZone
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.zoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBuiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearRenovatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentableSqFtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZoneId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captainPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captainEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBlockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Streets = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // zoneBindingSource
            // 
            this.zoneBindingSource.DataSource = typeof(DowntownBoiseAssociation.Zone);
            // 
            // blocksBindingSource
            // 
            this.blocksBindingSource.DataMember = "Blocks";
            this.blocksBindingSource.DataSource = this.zoneBindingSource;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.blocksBindingSource;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 29);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(804, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.frmAdminZone_Load);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(723, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Apply";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zoneBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 121);
            this.dataGridView1.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Zone Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 150);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(882, 3);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ZoneId1,
            this.nameDataGridViewTextBoxColumn1,
            this.blockNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.captainNameDataGridViewTextBoxColumn,
            this.captainPhoneDataGridViewTextBoxColumn,
            this.captainEmailDataGridViewTextBoxColumn,
            this.subdivisionDataGridViewTextBoxColumn,
            this.cityBlockNoDataGridViewTextBoxColumn,
            this.lotFromDataGridViewTextBoxColumn,
            this.lotToDataGridViewTextBoxColumn,
            this.Streets});
            this.dataGridView2.DataSource = this.blocksBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 153);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(882, 165);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 318);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(882, 3);
            this.splitter2.TabIndex = 18;
            this.splitter2.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.BlockId1,
            this.nameDataGridViewTextBoxColumn2,
            this.parcelNoDataGridViewTextBoxColumn,
            this.floorsDataGridViewTextBoxColumn,
            this.yearBuiltDataGridViewTextBoxColumn,
            this.yearRenovatedDataGridViewTextBoxColumn,
            this.rentableSqFtDataGridViewTextBoxColumn,
            this.averageRentDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.buildingsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 321);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(882, 186);
            this.dataGridView3.TabIndex = 19;
            this.dataGridView3.BindingContextChanged += new System.EventHandler(this.dataGridView3_BindingContextChanged);
            this.dataGridView3.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView3_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // BlockId1
            // 
            this.BlockId1.DataPropertyName = "BlockId";
            this.BlockId1.HeaderText = "BlockId";
            this.BlockId1.Name = "BlockId1";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Building Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // parcelNoDataGridViewTextBoxColumn
            // 
            this.parcelNoDataGridViewTextBoxColumn.DataPropertyName = "ParcelNo";
            this.parcelNoDataGridViewTextBoxColumn.HeaderText = "ParcelNo";
            this.parcelNoDataGridViewTextBoxColumn.Name = "parcelNoDataGridViewTextBoxColumn";
            // 
            // floorsDataGridViewTextBoxColumn
            // 
            this.floorsDataGridViewTextBoxColumn.DataPropertyName = "Floors";
            this.floorsDataGridViewTextBoxColumn.HeaderText = "Floors";
            this.floorsDataGridViewTextBoxColumn.Name = "floorsDataGridViewTextBoxColumn";
            // 
            // yearBuiltDataGridViewTextBoxColumn
            // 
            this.yearBuiltDataGridViewTextBoxColumn.DataPropertyName = "YearBuilt";
            this.yearBuiltDataGridViewTextBoxColumn.HeaderText = "YearBuilt";
            this.yearBuiltDataGridViewTextBoxColumn.Name = "yearBuiltDataGridViewTextBoxColumn";
            // 
            // yearRenovatedDataGridViewTextBoxColumn
            // 
            this.yearRenovatedDataGridViewTextBoxColumn.DataPropertyName = "YearRenovated";
            this.yearRenovatedDataGridViewTextBoxColumn.HeaderText = "YearRenovated";
            this.yearRenovatedDataGridViewTextBoxColumn.Name = "yearRenovatedDataGridViewTextBoxColumn";
            // 
            // rentableSqFtDataGridViewTextBoxColumn
            // 
            this.rentableSqFtDataGridViewTextBoxColumn.DataPropertyName = "RentableSqFt";
            this.rentableSqFtDataGridViewTextBoxColumn.HeaderText = "RentableSqFt";
            this.rentableSqFtDataGridViewTextBoxColumn.Name = "rentableSqFtDataGridViewTextBoxColumn";
            // 
            // averageRentDataGridViewTextBoxColumn
            // 
            this.averageRentDataGridViewTextBoxColumn.DataPropertyName = "AverageRent";
            this.averageRentDataGridViewTextBoxColumn.HeaderText = "AverageRent";
            this.averageRentDataGridViewTextBoxColumn.Name = "averageRentDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ZoneId1
            // 
            this.ZoneId1.DataPropertyName = "ZoneId";
            this.ZoneId1.HeaderText = "ZoneId";
            this.ZoneId1.Name = "ZoneId1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Lot Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // blockNumberDataGridViewTextBoxColumn
            // 
            this.blockNumberDataGridViewTextBoxColumn.DataPropertyName = "BlockNumber";
            this.blockNumberDataGridViewTextBoxColumn.HeaderText = "BlockNumber";
            this.blockNumberDataGridViewTextBoxColumn.Name = "blockNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // captainNameDataGridViewTextBoxColumn
            // 
            this.captainNameDataGridViewTextBoxColumn.DataPropertyName = "CaptainName";
            this.captainNameDataGridViewTextBoxColumn.HeaderText = "CaptainName";
            this.captainNameDataGridViewTextBoxColumn.Name = "captainNameDataGridViewTextBoxColumn";
            // 
            // captainPhoneDataGridViewTextBoxColumn
            // 
            this.captainPhoneDataGridViewTextBoxColumn.DataPropertyName = "CaptainPhone";
            this.captainPhoneDataGridViewTextBoxColumn.HeaderText = "CaptainPhone";
            this.captainPhoneDataGridViewTextBoxColumn.Name = "captainPhoneDataGridViewTextBoxColumn";
            // 
            // captainEmailDataGridViewTextBoxColumn
            // 
            this.captainEmailDataGridViewTextBoxColumn.DataPropertyName = "CaptainEmail";
            this.captainEmailDataGridViewTextBoxColumn.HeaderText = "CaptainEmail";
            this.captainEmailDataGridViewTextBoxColumn.Name = "captainEmailDataGridViewTextBoxColumn";
            // 
            // subdivisionDataGridViewTextBoxColumn
            // 
            this.subdivisionDataGridViewTextBoxColumn.DataPropertyName = "Subdivision";
            this.subdivisionDataGridViewTextBoxColumn.HeaderText = "Subdivision";
            this.subdivisionDataGridViewTextBoxColumn.Name = "subdivisionDataGridViewTextBoxColumn";
            // 
            // cityBlockNoDataGridViewTextBoxColumn
            // 
            this.cityBlockNoDataGridViewTextBoxColumn.DataPropertyName = "CityBlockNo";
            this.cityBlockNoDataGridViewTextBoxColumn.HeaderText = "CityBlockNo";
            this.cityBlockNoDataGridViewTextBoxColumn.Name = "cityBlockNoDataGridViewTextBoxColumn";
            // 
            // lotFromDataGridViewTextBoxColumn
            // 
            this.lotFromDataGridViewTextBoxColumn.DataPropertyName = "LotFrom";
            this.lotFromDataGridViewTextBoxColumn.HeaderText = "LotFrom";
            this.lotFromDataGridViewTextBoxColumn.Name = "lotFromDataGridViewTextBoxColumn";
            // 
            // lotToDataGridViewTextBoxColumn
            // 
            this.lotToDataGridViewTextBoxColumn.DataPropertyName = "LotTo";
            this.lotToDataGridViewTextBoxColumn.HeaderText = "LotTo";
            this.lotToDataGridViewTextBoxColumn.Name = "lotToDataGridViewTextBoxColumn";
            // 
            // Streets
            // 
            this.Streets.HeaderText = "Streets";
            this.Streets.Name = "Streets";
            this.Streets.Text = "(edit)";
            this.Streets.UseColumnTextForLinkValue = true;
            // 
            // frmAdminZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 507);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAdminZone";
            this.Text = "Zone Maintenance";
            this.Load += new System.EventHandler(this.frmAdminZone_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminZone_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zoneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adaCoParcelNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renovatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentableSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn field8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aveRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource blocksBindingSource;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqFtDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearRenovatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentableSqFtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZoneId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn captainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn captainPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn captainEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityBlockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Streets;
    }
}
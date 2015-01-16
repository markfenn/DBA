namespace DowntownBoiseAssociation
{
    partial class frmBuildingsByBlock
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
            this.blockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBlockFrom = new System.Windows.Forms.Label();
            this.lblBlockTo = new System.Windows.Forms.Label();
            this.grdBuildingsByBlock = new System.Windows.Forms.DataGridView();
            this.vwBuildingsByBlockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brnGetBuildings = new System.Windows.Forms.Button();
            this.mtxtBlockFrom = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBlockTo = new System.Windows.Forms.MaskedTextBox();
            this.blockIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuildingsByBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBuildingsByBlockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // blockBindingSource
            // 
            this.blockBindingSource.DataSource = typeof(DowntownBoiseAssociation.Block);
            // 
            // lblBlockFrom
            // 
            this.lblBlockFrom.AutoSize = true;
            this.lblBlockFrom.Location = new System.Drawing.Point(61, 8);
            this.lblBlockFrom.Name = "lblBlockFrom";
            this.lblBlockFrom.Size = new System.Drawing.Size(100, 13);
            this.lblBlockFrom.TabIndex = 1;
            this.lblBlockFrom.Text = "Block Number From";
            // 
            // lblBlockTo
            // 
            this.lblBlockTo.AutoSize = true;
            this.lblBlockTo.Location = new System.Drawing.Point(230, 8);
            this.lblBlockTo.Name = "lblBlockTo";
            this.lblBlockTo.Size = new System.Drawing.Size(90, 13);
            this.lblBlockTo.TabIndex = 3;
            this.lblBlockTo.Text = "Block Number To";
            // 
            // grdBuildingsByBlock
            // 
            this.grdBuildingsByBlock.AllowUserToAddRows = false;
            this.grdBuildingsByBlock.AllowUserToDeleteRows = false;
            this.grdBuildingsByBlock.AllowUserToOrderColumns = true;
            this.grdBuildingsByBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdBuildingsByBlock.AutoGenerateColumns = false;
            this.grdBuildingsByBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuildingsByBlock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockIdDataGridViewTextBoxColumn,
            this.buildingIdDataGridViewTextBoxColumn,
            this.blockNumberDataGridViewTextBoxColumn,
            this.buildingNameDataGridViewTextBoxColumn});
            this.grdBuildingsByBlock.DataSource = this.vwBuildingsByBlockBindingSource;
            this.grdBuildingsByBlock.Location = new System.Drawing.Point(61, 74);
            this.grdBuildingsByBlock.Name = "grdBuildingsByBlock";
            this.grdBuildingsByBlock.ReadOnly = true;
            this.grdBuildingsByBlock.Size = new System.Drawing.Size(503, 380);
            this.grdBuildingsByBlock.TabIndex = 4;
            this.grdBuildingsByBlock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuildingsByBlock_CellContentClick);
            // 
            // vwBuildingsByBlockBindingSource
            // 
            this.vwBuildingsByBlockBindingSource.DataSource = typeof(DowntownBoiseAssociation.vw_BuildingsByBlock);
            // 
            // brnGetBuildings
            // 
            this.brnGetBuildings.Location = new System.Drawing.Point(446, 27);
            this.brnGetBuildings.Name = "brnGetBuildings";
            this.brnGetBuildings.Size = new System.Drawing.Size(118, 23);
            this.brnGetBuildings.TabIndex = 15;
            this.brnGetBuildings.Text = "Get Buildings";
            this.brnGetBuildings.UseVisualStyleBackColor = true;
            this.brnGetBuildings.Click += new System.EventHandler(this.brnGetBuildings_Click);
            // 
            // mtxtBlockFrom
            // 
            this.mtxtBlockFrom.Location = new System.Drawing.Point(64, 29);
            this.mtxtBlockFrom.Mask = "00000";
            this.mtxtBlockFrom.Name = "mtxtBlockFrom";
            this.mtxtBlockFrom.PromptChar = ' ';
            this.mtxtBlockFrom.Size = new System.Drawing.Size(47, 20);
            this.mtxtBlockFrom.TabIndex = 16;
            this.mtxtBlockFrom.Text = "1";
            this.mtxtBlockFrom.ValidatingType = typeof(int);
            this.mtxtBlockFrom.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtBlockFrom_MaskInputRejected);
            // 
            // mtxtBlockTo
            // 
            this.mtxtBlockTo.Location = new System.Drawing.Point(233, 29);
            this.mtxtBlockTo.Mask = "00";
            this.mtxtBlockTo.Name = "mtxtBlockTo";
            this.mtxtBlockTo.PromptChar = ' ';
            this.mtxtBlockTo.Size = new System.Drawing.Size(47, 20);
            this.mtxtBlockTo.TabIndex = 17;
            this.mtxtBlockTo.Text = "1";
            this.mtxtBlockTo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtBlockTo_MaskInputRejected);
            // 
            // blockIdDataGridViewTextBoxColumn
            // 
            this.blockIdDataGridViewTextBoxColumn.DataPropertyName = "BlockId";
            this.blockIdDataGridViewTextBoxColumn.HeaderText = "BlockId";
            this.blockIdDataGridViewTextBoxColumn.Name = "blockIdDataGridViewTextBoxColumn";
            this.blockIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.blockIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // buildingIdDataGridViewTextBoxColumn
            // 
            this.buildingIdDataGridViewTextBoxColumn.DataPropertyName = "BuildingId";
            this.buildingIdDataGridViewTextBoxColumn.HeaderText = "BuildingId";
            this.buildingIdDataGridViewTextBoxColumn.Name = "buildingIdDataGridViewTextBoxColumn";
            this.buildingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // blockNumberDataGridViewTextBoxColumn
            // 
            this.blockNumberDataGridViewTextBoxColumn.DataPropertyName = "BlockNumber";
            this.blockNumberDataGridViewTextBoxColumn.HeaderText = "Block Number";
            this.blockNumberDataGridViewTextBoxColumn.Name = "blockNumberDataGridViewTextBoxColumn";
            this.blockNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.blockNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "BuildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "Building Name";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmBuildingsByBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 475);
            this.Controls.Add(this.grdBuildingsByBlock);
            this.Controls.Add(this.mtxtBlockTo);
            this.Controls.Add(this.mtxtBlockFrom);
            this.Controls.Add(this.brnGetBuildings);
            this.Controls.Add(this.lblBlockTo);
            this.Controls.Add(this.lblBlockFrom);
            this.Name = "frmBuildingsByBlock";
            this.Text = "Buildings by Block";
            this.Load += new System.EventHandler(this.frmBuildingsByBlock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuildingsByBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBuildingsByBlockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource blockBindingSource;
        private System.Windows.Forms.Label lblBlockFrom;
        private System.Windows.Forms.Label lblBlockTo;
        private System.Windows.Forms.DataGridView grdBuildingsByBlock;
        private System.Windows.Forms.BindingSource vwBuildingsByBlockBindingSource;
        private System.Windows.Forms.Button brnGetBuildings;
        private System.Windows.Forms.MaskedTextBox mtxtBlockFrom;
        private System.Windows.Forms.MaskedTextBox mtxtBlockTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn buildingNameDataGridViewTextBoxColumn;
    }
}
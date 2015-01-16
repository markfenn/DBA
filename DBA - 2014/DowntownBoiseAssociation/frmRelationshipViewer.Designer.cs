namespace DowntownBoiseAssociation
{
    partial class frmRelationshipViewer
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
            this.cbRelation = new System.Windows.Forms.ComboBox();
            this.listRelation = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMisc1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMisc2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuRelationship = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editThisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThisItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBreadCrumb = new System.Windows.Forms.Label();
            this.btnBackLevel = new System.Windows.Forms.Button();
            this.menuRelationship.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRelation
            // 
            this.cbRelation.FormattingEnabled = true;
            this.cbRelation.Items.AddRange(new object[] {
            "Zones",
            "Blocks",
            "Buildings",
            "Legal Entities",
            "Spaces"});
            this.cbRelation.Location = new System.Drawing.Point(12, 12);
            this.cbRelation.Name = "cbRelation";
            this.cbRelation.Size = new System.Drawing.Size(121, 21);
            this.cbRelation.TabIndex = 0;
            this.cbRelation.Text = "Zones";
            this.cbRelation.SelectedIndexChanged += new System.EventHandler(this.cbRelation_SelectedIndexChanged);
            // 
            // listRelation
            // 
            this.listRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listRelation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colMisc1,
            this.colMisc2});
            this.listRelation.ContextMenuStrip = this.menuRelationship;
            this.listRelation.FullRowSelect = true;
            this.listRelation.Location = new System.Drawing.Point(12, 68);
            this.listRelation.MultiSelect = false;
            this.listRelation.Name = "listRelation";
            this.listRelation.Size = new System.Drawing.Size(915, 361);
            this.listRelation.TabIndex = 2;
            this.listRelation.UseCompatibleStateImageBehavior = false;
            this.listRelation.View = System.Windows.Forms.View.Details;
            this.listRelation.DoubleClick += new System.EventHandler(this.listRelation_DoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 400;
            // 
            // colMisc1
            // 
            this.colMisc1.Text = "";
            this.colMisc1.Width = 150;
            // 
            // colMisc2
            // 
            this.colMisc2.Text = "";
            this.colMisc2.Width = 250;
            // 
            // menuRelationship
            // 
            this.menuRelationship.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editThisItemToolStripMenuItem,
            this.editThisItemToolStripMenuItem1});
            this.menuRelationship.Name = "menuRelationship";
            this.menuRelationship.Size = new System.Drawing.Size(153, 70);
            this.menuRelationship.Text = "Edit this Item";
            this.menuRelationship.Opening += new System.ComponentModel.CancelEventHandler(this.menuRelationship_Opening);
            // 
            // editThisItemToolStripMenuItem
            // 
            this.editThisItemToolStripMenuItem.Name = "editThisItemToolStripMenuItem";
            this.editThisItemToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editThisItemToolStripMenuItem.Text = "Edit this Item";
            this.editThisItemToolStripMenuItem.Click += new System.EventHandler(this.editThisItemToolStripMenuItem_Click);
            // 
            // editThisItemToolStripMenuItem1
            // 
            this.editThisItemToolStripMenuItem1.Name = "editThisItemToolStripMenuItem1";
            this.editThisItemToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editThisItemToolStripMenuItem1.Text = "Edit this Item";
            //this.editThisItemToolStripMenuItem1.Click += new System.EventHandler(this.editThisItemToolStripMenuItem1_Click);
            // 
            // lblBreadCrumb
            // 
            this.lblBreadCrumb.AutoSize = true;
            this.lblBreadCrumb.Location = new System.Drawing.Point(139, 45);
            this.lblBreadCrumb.Name = "lblBreadCrumb";
            this.lblBreadCrumb.Size = new System.Drawing.Size(30, 13);
            this.lblBreadCrumb.TabIndex = 3;
            this.lblBreadCrumb.Text = "Root";
            // 
            // btnBackLevel
            // 
            this.btnBackLevel.Enabled = false;
            this.btnBackLevel.Location = new System.Drawing.Point(12, 40);
            this.btnBackLevel.Name = "btnBackLevel";
            this.btnBackLevel.Size = new System.Drawing.Size(121, 23);
            this.btnBackLevel.TabIndex = 4;
            this.btnBackLevel.Text = "<-- Back a level";
            this.btnBackLevel.UseVisualStyleBackColor = true;
            this.btnBackLevel.Click += new System.EventHandler(this.btnBackLevel_Click);
            // 
            // frmRelationshipViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.ClientSize = new System.Drawing.Size(939, 442);
            this.Controls.Add(this.btnBackLevel);
            this.Controls.Add(this.lblBreadCrumb);
            this.Controls.Add(this.listRelation);
            this.Controls.Add(this.cbRelation);
            this.Name = "frmRelationshipViewer";
            this.Text = "Relationship Viewer";
            this.Load += new System.EventHandler(this.frmRelationshipViewer_Load);
            this.menuRelationship.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRelation;
        private System.Windows.Forms.ListView listRelation;
        private System.Windows.Forms.Label lblBreadCrumb;
        private System.Windows.Forms.Button btnBackLevel;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colMisc1;
        private System.Windows.Forms.ColumnHeader colMisc2;
        private System.Windows.Forms.ContextMenuStrip menuRelationship;
        private System.Windows.Forms.ToolStripMenuItem editThisItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThisItemToolStripMenuItem1;
    }
}
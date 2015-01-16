namespace DowntownBoiseAssociation
{
    partial class frmLateFeeProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLateFeeProcessing));
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccountNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalanceFwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuarterlyOwed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLateFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnSelectNone = new System.Windows.Forms.ToolStripButton();
            this.btnPost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pbProcessing = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAccounts
            // 
            this.lvAccounts.CheckBoxes = true;
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAccountNo,
            this.colBalanceFwd,
            this.colQuarterlyOwed,
            this.colLateFee});
            this.lvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.Location = new System.Drawing.Point(0, 25);
            this.lvAccounts.MultiSelect = false;
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(684, 536);
            this.lvAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAccounts.TabIndex = 3;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colAccountNo
            // 
            this.colAccountNo.Text = "Account No";
            this.colAccountNo.Width = 120;
            // 
            // colBalanceFwd
            // 
            this.colBalanceFwd.Text = "Balance";
            this.colBalanceFwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBalanceFwd.Width = 80;
            // 
            // colQuarterlyOwed
            // 
            this.colQuarterlyOwed.Text = "Quarterly Amount";
            this.colQuarterlyOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colQuarterlyOwed.Width = 100;
            // 
            // colLateFee
            // 
            this.colLateFee.Text = "Late Fee";
            this.colLateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colLateFee.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnSelectAll,
            this.btnSelectNone,
            this.btnPost,
            this.toolStripSeparator3,
            this.pbProcessing,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::DowntownBoiseAssociation.Properties.Resources.CheckBoxChecked;
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 22);
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Image = global::DowntownBoiseAssociation.Properties.Resources.checkboxUnchecked;
            this.btnSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(90, 22);
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnPost
            // 
            this.btnPost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(48, 22);
            this.btnPost.Text = "Accept";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pbProcessing
            // 
            this.pbProcessing.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbProcessing.Enabled = false;
            this.pbProcessing.Name = "pbProcessing";
            this.pbProcessing.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Processing";
            // 
            // frmLateFeeProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.lvAccounts);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "frmLateFeeProcessing";
            this.Text = "Late Fee Processing";
            this.Load += new System.EventHandler(this.frmLateFeeProcessing_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripButton btnSelectNone;
        private System.Windows.Forms.ToolStripButton btnPost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripProgressBar pbProcessing;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAccountNo;
        private System.Windows.Forms.ColumnHeader colBalanceFwd;
        private System.Windows.Forms.ColumnHeader colLateFee;
        private System.Windows.Forms.ColumnHeader colQuarterlyOwed;
    }
}
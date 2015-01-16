namespace DowntownBoiseAssociation
{
    partial class frmUtilityImageMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilityImageMaintain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.btnSavePoints = new System.Windows.Forms.ToolStripButton();
            this.btnNewObject = new System.Windows.Forms.ToolStripButton();
            this.btnNewCategory = new System.Windows.Forms.ToolStripButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblPointList = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.tipMouse = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenImage,
            this.btnSavePoints,
            this.btnNewCategory,
            this.toolStripSeparator1,
            this.btnNewObject});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenImage.Image")));
            this.btnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(70, 22);
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSavePoints
            // 
            this.btnSavePoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSavePoints.Enabled = false;
            this.btnSavePoints.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePoints.Image")));
            this.btnSavePoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePoints.Name = "btnSavePoints";
            this.btnSavePoints.Size = new System.Drawing.Size(67, 22);
            this.btnSavePoints.Text = "Save Points";
            this.btnSavePoints.Click += new System.EventHandler(this.btnSavePoints_Click);
            // 
            // btnNewObject
            // 
            this.btnNewObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewObject.Enabled = false;
            this.btnNewObject.Image = ((System.Drawing.Image)(resources.GetObject("btnNewObject.Image")));
            this.btnNewObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewObject.Name = "btnNewObject";
            this.btnNewObject.Size = new System.Drawing.Size(103, 22);
            this.btnNewObject.Text = "Create New Object";
            this.btnNewObject.Click += new System.EventHandler(this.btnNewObject_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewCategory.Enabled = false;
            this.btnNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCategory.Image")));
            this.btnNewCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(80, 22);
            this.btnNewCategory.Text = "New Category";
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(7, 60);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(132, 111);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseClick);
            this.pbImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImage_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.lblPointList);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 28);
            this.panel1.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Enabled = false;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(60, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(177, 21);
            this.cbCategory.Sorted = true;
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblPointList
            // 
            this.lblPointList.AutoSize = true;
            this.lblPointList.Location = new System.Drawing.Point(4, 6);
            this.lblPointList.Name = "lblPointList";
            this.lblPointList.Size = new System.Drawing.Size(49, 13);
            this.lblPointList.TabIndex = 0;
            this.lblPointList.Text = "Category";
            // 
            // txtPoints
            // 
            this.txtPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtPoints.Location = new System.Drawing.Point(633, 60);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPoints.Size = new System.Drawing.Size(116, 263);
            this.txtPoints.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmUtiltiyImageMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(750, 590);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUtiltiyImageMaintain";
            this.Text = "Image Maintenance Utility";
            this.Load += new System.EventHandler(this.frmUtiltiyImageMaintain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btnNewObject;
        private System.Windows.Forms.ToolStripButton btnOpenImage;
        private System.Windows.Forms.ToolStripButton btnSavePoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblPointList;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.ToolTip tipMouse;
        private System.Windows.Forms.ToolStripButton btnNewCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
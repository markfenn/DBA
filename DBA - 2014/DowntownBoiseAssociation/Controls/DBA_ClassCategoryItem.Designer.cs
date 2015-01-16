namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_ClassCategoryItem
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
            this.lvClassCategory = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnClass = new System.Windows.Forms.ColumnHeader();
            this.columnCategory = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvClassCategory
            // 
            this.lvClassCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClassCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnClass,
            this.columnCategory});
            this.lvClassCategory.FullRowSelect = true;
            this.lvClassCategory.Location = new System.Drawing.Point(6, 7);
            this.lvClassCategory.MultiSelect = false;
            this.lvClassCategory.Name = "lvClassCategory";
            this.lvClassCategory.Size = new System.Drawing.Size(290, 101);
            this.lvClassCategory.TabIndex = 0;
            this.lvClassCategory.UseCompatibleStateImageBehavior = false;
            this.lvClassCategory.View = System.Windows.Forms.View.Details;
            this.lvClassCategory.SelectedIndexChanged += new System.EventHandler(this.lvClassCategory_SelectedIndexChanged);
            this.lvClassCategory.Click += new System.EventHandler(this.lvClassCategory_Click);
            // 
            // columnID
            // 
            this.columnID.DisplayIndex = 2;
            this.columnID.Text = "Id";
            this.columnID.Width = 0;
            // 
            // columnClass
            // 
            this.columnClass.DisplayIndex = 0;
            this.columnClass.Text = "Class";
            this.columnClass.Width = 90;
            // 
            // columnCategory
            // 
            this.columnCategory.DisplayIndex = 1;
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 175;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(220, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(6, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DBA_ClassCategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvClassCategory);
            this.Name = "DBA_ClassCategoryItem";
            this.Size = new System.Drawing.Size(303, 141);
            this.Leave += new System.EventHandler(this.DBA_ClassCategoryItem_Leave);
            this.Resize += new System.EventHandler(this.DBA_ClassCategoryItem_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvClassCategory;
        private System.Windows.Forms.ColumnHeader columnClass;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnID;
    }
}

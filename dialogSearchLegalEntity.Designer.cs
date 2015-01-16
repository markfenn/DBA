namespace DowntownBoiseAssociation
{
    partial class dialogSearchLegalEntity
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnEditLegalEntity = new System.Windows.Forms.Button();
            this.btnAddLegalEntity = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLegalEntityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(426, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(507, 383);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnEditLegalEntity
            // 
            this.btnEditLegalEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditLegalEntity.Location = new System.Drawing.Point(123, 383);
            this.btnEditLegalEntity.Name = "btnEditLegalEntity";
            this.btnEditLegalEntity.Size = new System.Drawing.Size(96, 23);
            this.btnEditLegalEntity.TabIndex = 2;
            this.btnEditLegalEntity.Text = "&Edit Legal Entity";
            this.btnEditLegalEntity.UseVisualStyleBackColor = true;
            this.btnEditLegalEntity.Click += new System.EventHandler(this.btnEditLegalEntity_Click);
            // 
            // btnAddLegalEntity
            // 
            this.btnAddLegalEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLegalEntity.Location = new System.Drawing.Point(12, 383);
            this.btnAddLegalEntity.Name = "btnAddLegalEntity";
            this.btnAddLegalEntity.Size = new System.Drawing.Size(105, 23);
            this.btnAddLegalEntity.TabIndex = 3;
            this.btnAddLegalEntity.Text = "&New Legal Entity";
            this.btnAddLegalEntity.UseVisualStyleBackColor = true;
            this.btnAddLegalEntity.Click += new System.EventHandler(this.btnAddLegalEntity_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(507, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLegalEntityName
            // 
            this.txtLegalEntityName.Location = new System.Drawing.Point(80, 13);
            this.txtLegalEntityName.MaxLength = 50;
            this.txtLegalEntityName.Name = "txtLegalEntityName";
            this.txtLegalEntityName.Size = new System.Drawing.Size(374, 20);
            this.txtLegalEntityName.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Legal Entity";
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 14;
            this.lbSearch.Location = new System.Drawing.Point(15, 43);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(567, 326);
            this.lbSearch.TabIndex = 50;
            this.lbSearch.DoubleClick += new System.EventHandler(this.lbSearch_DoubleClick);
            // 
            // dialogSearchLegalEntity
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad2;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(594, 418);
            this.ControlBox = false;
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtLegalEntityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddLegalEntity);
            this.Controls.Add(this.btnEditLegalEntity);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogSearchLegalEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legal Entity Search";
            this.Shown += new System.EventHandler(this.dialogSearchLegalEntity_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnEditLegalEntity;
        private System.Windows.Forms.Button btnAddLegalEntity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLegalEntityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSearch;
    }
}
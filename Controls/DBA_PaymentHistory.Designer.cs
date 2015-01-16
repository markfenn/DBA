namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_PaymentHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBillingPeriod = new System.Windows.Forms.ComboBox();
            this.dgStatement = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Period";
            // 
            // cbBillingPeriod
            // 
            this.cbBillingPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBillingPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBillingPeriod.FormattingEnabled = true;
            this.cbBillingPeriod.Location = new System.Drawing.Point(68, 3);
            this.cbBillingPeriod.Name = "cbBillingPeriod";
            this.cbBillingPeriod.Size = new System.Drawing.Size(464, 21);
            this.cbBillingPeriod.TabIndex = 1;
            this.cbBillingPeriod.SelectedIndexChanged += new System.EventHandler(this.cbBillingPeriod_SelectedIndexChanged);
            // 
            // dgStatement
            // 
            this.dgStatement.AllowUserToAddRows = false;
            this.dgStatement.AllowUserToDeleteRows = false;
            this.dgStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PostingDate,
            this.AccountingDate,
            this.Description,
            this.Type,
            this.Amount,
            this.Balance});
            this.dgStatement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStatement.Location = new System.Drawing.Point(3, 27);
            this.dgStatement.MultiSelect = false;
            this.dgStatement.Name = "dgStatement";
            this.dgStatement.ReadOnly = true;
            this.dgStatement.RowHeadersVisible = false;
            this.dgStatement.Size = new System.Drawing.Size(529, 400);
            this.dgStatement.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PostingDate
            // 
            this.PostingDate.DataPropertyName = "PostingDate";
            this.PostingDate.HeaderText = "Posting Date";
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.ReadOnly = true;
            this.PostingDate.Width = 70;
            // 
            // AccountingDate
            // 
            this.AccountingDate.DataPropertyName = "AccountingDate";
            this.AccountingDate.HeaderText = "Accounting Date";
            this.AccountingDate.Name = "AccountingDate";
            this.AccountingDate.ReadOnly = true;
            this.AccountingDate.Width = 70;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 175;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 70;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle2;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 70;
            // 
            // DBA_PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgStatement);
            this.Controls.Add(this.cbBillingPeriod);
            this.Controls.Add(this.label1);
            this.Name = "DBA_PaymentHistory";
            this.Size = new System.Drawing.Size(536, 432);
            this.Load += new System.EventHandler(this.DBA_PaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBillingPeriod;
        private System.Windows.Forms.DataGridView dgStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}

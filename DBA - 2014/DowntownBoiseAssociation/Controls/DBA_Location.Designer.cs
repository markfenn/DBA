namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_Location
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkZone = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkBlock = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkBuilding = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.grad;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.linkZone);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.linkBlock);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.linkBuilding);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 24);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ZONE";
            // 
            // linkZone
            // 
            this.linkZone.AutoSize = true;
            this.linkZone.BackColor = System.Drawing.Color.Transparent;
            this.linkZone.Location = new System.Drawing.Point(49, 7);
            this.linkZone.Name = "linkZone";
            this.linkZone.Size = new System.Drawing.Size(49, 13);
            this.linkZone.TabIndex = 0;
            this.linkZone.TabStop = true;
            this.linkZone.Text = "No Zone";
            this.linkZone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkZone_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(104, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BLOCK";
            // 
            // linkBlock
            // 
            this.linkBlock.AutoSize = true;
            this.linkBlock.BackColor = System.Drawing.Color.Transparent;
            this.linkBlock.Location = new System.Drawing.Point(152, 7);
            this.linkBlock.Name = "linkBlock";
            this.linkBlock.Size = new System.Drawing.Size(51, 13);
            this.linkBlock.TabIndex = 1;
            this.linkBlock.TabStop = true;
            this.linkBlock.Text = "No Block";
            this.linkBlock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBlock_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(209, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "BUILDING";
            // 
            // linkBuilding
            // 
            this.linkBuilding.AutoSize = true;
            this.linkBuilding.BackColor = System.Drawing.Color.Transparent;
            this.linkBuilding.Location = new System.Drawing.Point(273, 7);
            this.linkBuilding.Name = "linkBuilding";
            this.linkBuilding.Size = new System.Drawing.Size(61, 13);
            this.linkBuilding.TabIndex = 2;
            this.linkBuilding.TabStop = true;
            this.linkBuilding.Text = "No Building";
            this.linkBuilding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuilding_LinkClicked);
            // 
            // DBA_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DBA_Location";
            this.Size = new System.Drawing.Size(507, 16);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkZone;
        private System.Windows.Forms.LinkLabel linkBlock;
        private System.Windows.Forms.LinkLabel linkBuilding;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}

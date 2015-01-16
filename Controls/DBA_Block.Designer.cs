namespace DowntownBoiseAssociation.Controls
{
    partial class DBA_Block
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
            this.lblBlockName = new System.Windows.Forms.Label();
            this.lblStreetSouth = new System.Windows.Forms.Label();
            this.lblStreetNorth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStreetEast = new DowntownBoiseAssociation.Controls.DBA_OrientedTextLabel();
            this.lblStreetWest = new DowntownBoiseAssociation.Controls.DBA_OrientedTextLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBlockName
            // 
            this.lblBlockName.BackColor = System.Drawing.Color.Transparent;
            this.lblBlockName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBlockName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockName.Location = new System.Drawing.Point(0, 177);
            this.lblBlockName.Name = "lblBlockName";
            this.lblBlockName.Size = new System.Drawing.Size(183, 52);
            this.lblBlockName.TabIndex = 10;
            this.lblBlockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreetSouth
            // 
            this.lblStreetSouth.BackColor = System.Drawing.Color.LightGray;
            this.lblStreetSouth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetSouth.Location = new System.Drawing.Point(27, 152);
            this.lblStreetSouth.Name = "lblStreetSouth";
            this.lblStreetSouth.Size = new System.Drawing.Size(125, 25);
            this.lblStreetSouth.TabIndex = 9;
            this.lblStreetSouth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreetNorth
            // 
            this.lblStreetNorth.BackColor = System.Drawing.Color.LightGray;
            this.lblStreetNorth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNorth.Location = new System.Drawing.Point(27, 2);
            this.lblStreetNorth.Name = "lblStreetNorth";
            this.lblStreetNorth.Size = new System.Drawing.Size(125, 25);
            this.lblStreetNorth.TabIndex = 8;
            this.lblStreetNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DowntownBoiseAssociation.Properties.Resources.dbaBuilding;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblStreetEast
            // 
            this.lblStreetEast.BackColor = System.Drawing.Color.LightGray;
            this.lblStreetEast.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetEast.Location = new System.Drawing.Point(153, 27);
            this.lblStreetEast.Name = "lblStreetEast";
            this.lblStreetEast.RotationAngle = 90D;
            this.lblStreetEast.Size = new System.Drawing.Size(25, 125);
            this.lblStreetEast.TabIndex = 7;
            this.lblStreetEast.Text = null;
            this.lblStreetEast.TextDirection = DowntownBoiseAssociation.Controls.Direction.Clockwise;
            this.lblStreetEast.TextOrientation = DowntownBoiseAssociation.Controls.Orientation.Rotate;
            // 
            // lblStreetWest
            // 
            this.lblStreetWest.BackColor = System.Drawing.Color.LightGray;
            this.lblStreetWest.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetWest.Location = new System.Drawing.Point(1, 27);
            this.lblStreetWest.Name = "lblStreetWest";
            this.lblStreetWest.RotationAngle = 90D;
            this.lblStreetWest.Size = new System.Drawing.Size(25, 125);
            this.lblStreetWest.TabIndex = 6;
            this.lblStreetWest.Text = null;
            this.lblStreetWest.TextDirection = DowntownBoiseAssociation.Controls.Direction.Clockwise;
            this.lblStreetWest.TextOrientation = DowntownBoiseAssociation.Controls.Orientation.Rotate;
            // 
            // DBA_Block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblStreetSouth);
            this.Controls.Add(this.lblStreetNorth);
            this.Controls.Add(this.lblStreetEast);
            this.Controls.Add(this.lblStreetWest);
            this.Controls.Add(this.lblBlockName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DBA_Block";
            this.Size = new System.Drawing.Size(183, 229);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBlockName;
        private System.Windows.Forms.Label lblStreetSouth;
        private System.Windows.Forms.Label lblStreetNorth;
        private DBA_OrientedTextLabel lblStreetEast;
        private DBA_OrientedTextLabel lblStreetWest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

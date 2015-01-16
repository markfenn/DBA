namespace DowntownBoiseAssociation.Controls
{
    partial class CommentIndicator
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
            this.components = new System.ComponentModel.Container();
            this.btnFlasher = new System.Windows.Forms.Button();
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnFlasher
            // 
            this.btnFlasher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlasher.AutoSize = true;
            this.btnFlasher.Location = new System.Drawing.Point(3, 3);
            this.btnFlasher.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnFlasher.MinimumSize = new System.Drawing.Size(12, 12);
            this.btnFlasher.Name = "btnFlasher";
            this.btnFlasher.Size = new System.Drawing.Size(12, 12);
            this.btnFlasher.TabIndex = 0;
            this.btnFlasher.UseVisualStyleBackColor = true;
            this.btnFlasher.Click += new System.EventHandler(this.btnFlasher_Click);
            this.btnFlasher.MouseHover += new System.EventHandler(this.btnFlasher_MouseHover);
            // 
            // flashTimer
            // 
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // CommentIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnFlasher);
            this.MaximumSize = new System.Drawing.Size(60, 60);
            this.MinimumSize = new System.Drawing.Size(19, 19);
            this.Name = "CommentIndicator";
            this.Size = new System.Drawing.Size(19, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlasher;
        private System.Windows.Forms.Timer flashTimer;
    }
}

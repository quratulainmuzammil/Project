namespace Frmregistration
{
    partial class ucuserprofile
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
            this.p1 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Image = global::Frmregistration.Properties.Resources.Chrysanthemum;
            this.p1.Location = new System.Drawing.Point(89, 44);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 50);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(86, 122);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(55, 13);
            this.L1.TabIndex = 1;
            this.L1.TabStop = true;
            this.L1.Text = "linkLabel1";
            // 
            // ucuserprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.L1);
            this.Controls.Add(this.p1);
            this.Name = "ucuserprofile";
            this.Size = new System.Drawing.Size(236, 212);
            this.Load += new System.EventHandler(this.ucuserprofile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.LinkLabel L1;
    }
}

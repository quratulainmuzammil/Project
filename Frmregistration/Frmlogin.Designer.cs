namespace Frmregistration
{
    partial class Frmlogin
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassward = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassward = new System.Windows.Forms.Label();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.cmdregistration = new System.Windows.Forms.Button();
            this.cmdresetpassward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(155, 28);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassward
            // 
            this.txtpassward.Location = new System.Drawing.Point(155, 84);
            this.txtpassward.Name = "txtpassward";
            this.txtpassward.Size = new System.Drawing.Size(100, 20);
            this.txtpassward.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(59, 28);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(60, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User Name";
            // 
            // lblpassward
            // 
            this.lblpassward.AutoSize = true;
            this.lblpassward.Location = new System.Drawing.Point(59, 91);
            this.lblpassward.Name = "lblpassward";
            this.lblpassward.Size = new System.Drawing.Size(52, 13);
            this.lblpassward.TabIndex = 3;
            this.lblpassward.Text = "passward";
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(245, 146);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(75, 23);
            this.cmdlogin.TabIndex = 4;
            this.cmdlogin.Text = "Login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // cmdregistration
            // 
            this.cmdregistration.Location = new System.Drawing.Point(44, 146);
            this.cmdregistration.Name = "cmdregistration";
            this.cmdregistration.Size = new System.Drawing.Size(75, 23);
            this.cmdregistration.TabIndex = 5;
            this.cmdregistration.Text = "Registration";
            this.cmdregistration.UseVisualStyleBackColor = true;
            this.cmdregistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdresetpassward
            // 
            this.cmdresetpassward.Location = new System.Drawing.Point(245, 189);
            this.cmdresetpassward.Name = "cmdresetpassward";
            this.cmdresetpassward.Size = new System.Drawing.Size(75, 23);
            this.cmdresetpassward.TabIndex = 6;
            this.cmdresetpassward.Text = "ResetPassward";
            this.cmdresetpassward.UseVisualStyleBackColor = true;
            this.cmdresetpassward.Click += new System.EventHandler(this.cmdresetpassward_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 262);
            this.Controls.Add(this.cmdresetpassward);
            this.Controls.Add(this.cmdregistration);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.lblpassward);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassward);
            this.Controls.Add(this.txtusername);
            this.Name = "Frmlogin";
            this.Text = "Frmlogin";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassward;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassward;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Button cmdregistration;
        private System.Windows.Forms.Button cmdresetpassward;
    }
}
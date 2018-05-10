namespace Frmregistration
{
    partial class Form1
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
            this.cmdsignup = new System.Windows.Forms.Button();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassward = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassward = new System.Windows.Forms.TextBox();
            this.lblsercretquestion = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.txtanswers = new System.Windows.Forms.TextBox();
            this.comboBoxSecretques = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdsignup
            // 
            this.cmdsignup.Location = new System.Drawing.Point(280, 202);
            this.cmdsignup.Name = "cmdsignup";
            this.cmdsignup.Size = new System.Drawing.Size(75, 23);
            this.cmdsignup.TabIndex = 0;
            this.cmdsignup.Text = "Sign Up";
            this.cmdsignup.UseVisualStyleBackColor = true;
            this.cmdsignup.Click += new System.EventHandler(this.cmdsignup_Click);
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(98, 202);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(75, 23);
            this.cmdlogin.TabIndex = 1;
            this.cmdlogin.Text = "Login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(95, 56);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(60, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User Name";
            // 
            // lblpassward
            // 
            this.lblpassward.AutoSize = true;
            this.lblpassward.Location = new System.Drawing.Point(95, 94);
            this.lblpassward.Name = "lblpassward";
            this.lblpassward.Size = new System.Drawing.Size(53, 13);
            this.lblpassward.TabIndex = 3;
            this.lblpassward.Text = "Passward";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(255, 49);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassward
            // 
            this.txtpassward.Location = new System.Drawing.Point(255, 94);
            this.txtpassward.Name = "txtpassward";
            this.txtpassward.Size = new System.Drawing.Size(100, 20);
            this.txtpassward.TabIndex = 5;
            // 
            // lblsercretquestion
            // 
            this.lblsercretquestion.AutoSize = true;
            this.lblsercretquestion.Location = new System.Drawing.Point(95, 128);
            this.lblsercretquestion.Name = "lblsercretquestion";
            this.lblsercretquestion.Size = new System.Drawing.Size(83, 13);
            this.lblsercretquestion.TabIndex = 6;
            this.lblsercretquestion.Text = "Secret Question";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(95, 162);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(42, 13);
            this.lblanswer.TabIndex = 7;
            this.lblanswer.Text = "Answer";
            // 
            // txtanswers
            // 
            this.txtanswers.Location = new System.Drawing.Point(255, 162);
            this.txtanswers.Name = "txtanswers";
            this.txtanswers.Size = new System.Drawing.Size(100, 20);
            this.txtanswers.TabIndex = 9;
            // 
            // comboBoxSecretques
            // 
            this.comboBoxSecretques.FormattingEnabled = true;
            this.comboBoxSecretques.Items.AddRange(new object[] {
            "what is your nickname?",
            "what is your fav color?",
            "what is your hobby?",
            "what is your fav food?"});
            this.comboBoxSecretques.Location = new System.Drawing.Point(255, 128);
            this.comboBoxSecretques.Name = "comboBoxSecretques";
            this.comboBoxSecretques.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSecretques.TabIndex = 10;
            this.comboBoxSecretques.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecretques_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(459, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Upload image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Show all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSecretques);
            this.Controls.Add(this.txtanswers);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblsercretquestion);
            this.Controls.Add(this.txtpassward);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassward);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.cmdsignup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdsignup;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassward;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassward;
        private System.Windows.Forms.Label lblsercretquestion;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.TextBox txtanswers;
        private System.Windows.Forms.ComboBox comboBoxSecretques;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


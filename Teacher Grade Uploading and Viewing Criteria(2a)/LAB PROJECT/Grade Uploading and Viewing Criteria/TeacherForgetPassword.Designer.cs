namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class TeacherForgetPassword
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
            this.txtsecret = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.bbsave = new System.Windows.Forms.Button();
            this.lblsecret = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsecret
            // 
            this.txtsecret.Location = new System.Drawing.Point(124, 113);
            this.txtsecret.Name = "txtsecret";
            this.txtsecret.Size = new System.Drawing.Size(121, 20);
            this.txtsecret.TabIndex = 9;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(124, 65);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 20);
            this.txtusername.TabIndex = 8;
            // 
            // bbsave
            // 
            this.bbsave.Location = new System.Drawing.Point(84, 163);
            this.bbsave.Name = "bbsave";
            this.bbsave.Size = new System.Drawing.Size(104, 23);
            this.bbsave.TabIndex = 7;
            this.bbsave.Text = "Save Changes";
            this.bbsave.UseVisualStyleBackColor = true;
            this.bbsave.Click += new System.EventHandler(this.bbsave_Click);
            // 
            // lblsecret
            // 
            this.lblsecret.AutoSize = true;
            this.lblsecret.Location = new System.Drawing.Point(35, 120);
            this.lblsecret.Name = "lblsecret";
            this.lblsecret.Size = new System.Drawing.Size(66, 13);
            this.lblsecret.TabIndex = 6;
            this.lblsecret.Text = "Secret Code";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(35, 72);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "UserName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 27);
            this.button1.TabIndex = 67;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsecret);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.bbsave);
            this.Controls.Add(this.lblsecret);
            this.Controls.Add(this.lblusername);
            this.Name = "TeacherForgetPassword";
            this.Text = "TeacherForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsecret;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button bbsave;
        private System.Windows.Forms.Label lblsecret;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button button1;
    }
}
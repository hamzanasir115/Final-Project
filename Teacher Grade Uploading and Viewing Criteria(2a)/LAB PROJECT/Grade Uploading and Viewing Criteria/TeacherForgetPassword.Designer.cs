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
            this.SuspendLayout();
            // 
            // txtsecret
            // 
            this.txtsecret.Location = new System.Drawing.Point(125, 91);
            this.txtsecret.Name = "txtsecret";
            this.txtsecret.Size = new System.Drawing.Size(121, 20);
            this.txtsecret.TabIndex = 9;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(125, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 20);
            this.txtusername.TabIndex = 8;
            // 
            // bbsave
            // 
            this.bbsave.Location = new System.Drawing.Point(85, 141);
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
            this.lblsecret.Location = new System.Drawing.Point(36, 98);
            this.lblsecret.Name = "lblsecret";
            this.lblsecret.Size = new System.Drawing.Size(66, 13);
            this.lblsecret.TabIndex = 6;
            this.lblsecret.Text = "Secret Code";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(36, 50);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "UserName";
            // 
            // TeacherForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}
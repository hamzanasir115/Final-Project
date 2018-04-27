namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class TeacherResetPassword
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
            this.components = new System.ComponentModel.Container();
            this.bbreset = new System.Windows.Forms.Button();
            this.lnklogin = new System.Windows.Forms.LinkLabel();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bbreset
            // 
            this.bbreset.Location = new System.Drawing.Point(148, 130);
            this.bbreset.Name = "bbreset";
            this.bbreset.Size = new System.Drawing.Size(75, 23);
            this.bbreset.TabIndex = 11;
            this.bbreset.Text = "Reset";
            this.bbreset.UseVisualStyleBackColor = true;
            this.bbreset.Click += new System.EventHandler(this.bbreset_Click);
            // 
            // lnklogin
            // 
            this.lnklogin.AutoSize = true;
            this.lnklogin.Location = new System.Drawing.Point(46, 140);
            this.lnklogin.Name = "lnklogin";
            this.lnklogin.Size = new System.Drawing.Size(43, 13);
            this.lnklogin.TabIndex = 10;
            this.lnklogin.TabStop = true;
            this.lnklogin.Text = "LOG IN";
            this.lnklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklogin_LinkClicked);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(36, 88);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(36, 42);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "UserName";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(137, 81);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(112, 20);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(137, 35);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(112, 20);
            this.txtusername.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TeacherResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bbreset);
            this.Controls.Add(this.lnklogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "TeacherResetPassword";
            this.Text = "TeacherResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bbreset;
        private System.Windows.Forms.LinkLabel lnklogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
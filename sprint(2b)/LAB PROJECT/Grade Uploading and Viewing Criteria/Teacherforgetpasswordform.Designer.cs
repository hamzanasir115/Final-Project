namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class Teacherforgetpasswordform
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblsecret = new System.Windows.Forms.Label();
            this.bbsave = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtsecret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(42, 45);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "UserName";
            // 
            // lblsecret
            // 
            this.lblsecret.AutoSize = true;
            this.lblsecret.Location = new System.Drawing.Point(42, 93);
            this.lblsecret.Name = "lblsecret";
            this.lblsecret.Size = new System.Drawing.Size(66, 13);
            this.lblsecret.TabIndex = 1;
            this.lblsecret.Text = "Secret Code";
            // 
            // bbsave
            // 
            this.bbsave.Location = new System.Drawing.Point(91, 136);
            this.bbsave.Name = "bbsave";
            this.bbsave.Size = new System.Drawing.Size(104, 23);
            this.bbsave.TabIndex = 2;
            this.bbsave.Text = "Save Changes";
            this.bbsave.UseVisualStyleBackColor = true;
            this.bbsave.Click += new System.EventHandler(this.bbsave_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(131, 38);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 20);
            this.txtusername.TabIndex = 3;
            // 
            // txtsecret
            // 
            this.txtsecret.Location = new System.Drawing.Point(131, 86);
            this.txtsecret.Name = "txtsecret";
            this.txtsecret.Size = new System.Drawing.Size(121, 20);
            this.txtsecret.TabIndex = 4;
            // 
            // Teacherforgetpasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.txtsecret);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.bbsave);
            this.Controls.Add(this.lblsecret);
            this.Controls.Add(this.lblusername);
            this.Name = "Teacherforgetpasswordform";
            this.Text = "Teacherforgetpasswordform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblsecret;
        private System.Windows.Forms.Button bbsave;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtsecret;
    }
}
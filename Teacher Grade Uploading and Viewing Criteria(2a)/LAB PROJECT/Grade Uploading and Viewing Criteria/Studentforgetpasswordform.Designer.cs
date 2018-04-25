namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class Studentforgetpasswordform
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
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.cmbquestions = new System.Windows.Forms.ComboBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblsecret = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(113, 22);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(144, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(113, 80);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(144, 20);
            this.txtanswer.TabIndex = 1;
            // 
            // cmbquestions
            // 
            this.cmbquestions.FormattingEnabled = true;
            this.cmbquestions.Items.AddRange(new object[] {
            "What is your nickname?",
            "Enter your marks in last examination you have passed?",
            "What is you favorite color?",
            "In which section do you read?",
            "What is your pet name?",
            "What is your hobby?"});
            this.cmbquestions.Location = new System.Drawing.Point(113, 48);
            this.cmbquestions.Name = "cmbquestions";
            this.cmbquestions.Size = new System.Drawing.Size(144, 21);
            this.cmbquestions.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(20, 29);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "UserName";
            // 
            // lblsecret
            // 
            this.lblsecret.AutoSize = true;
            this.lblsecret.Location = new System.Drawing.Point(20, 56);
            this.lblsecret.Name = "lblsecret";
            this.lblsecret.Size = new System.Drawing.Size(83, 13);
            this.lblsecret.TabIndex = 4;
            this.lblsecret.Text = "Secret Question";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(20, 87);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(42, 13);
            this.lblanswer.TabIndex = 5;
            this.lblanswer.Text = "Answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Studentforgetpasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblsecret);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cmbquestions);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtusername);
            this.Name = "Studentforgetpasswordform";
            this.Text = "Studenrforgetpasswordform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.ComboBox cmbquestions;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblsecret;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Button button1;
    }
}
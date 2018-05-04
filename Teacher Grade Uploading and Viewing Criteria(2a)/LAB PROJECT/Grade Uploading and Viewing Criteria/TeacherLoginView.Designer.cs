namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class TeacherLoginView
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(81, 47);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(142, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View Registered Subjects";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(80, 136);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 25);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Offered subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnView);
            this.Name = "TeacherLoginView";
            this.Text = "TeacherLoginView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
    }
}
namespace Grade_Uploading_and_Viewing_Criteria
{
    partial class StudentDMC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.service11 = new Grade_Uploading_and_Viewing_Criteria.localhost.Service1();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // service11
            // 
            this.service11.Url = "http://localhost:8017/Service1.svc";
            this.service11.UseDefaultCredentials = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(113, 12);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(129, 20);
            this.txtusername.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(13, 18);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "UserName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "See DMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentDMC";
            this.Text = "StudentDMC";
            this.Load += new System.EventHandler(this.StudentDMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private localhost.Service1 service11;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button button1;
    }
}
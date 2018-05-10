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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // service11
            // 
            this.service11.Url = "http://localhost:8017/Service1.svc";
            this.service11.UseDefaultCredentials = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(284, 34);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(129, 20);
            this.txtusername.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(114, 37);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(57, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "UserName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "See DMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentDMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 355);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
    }
}
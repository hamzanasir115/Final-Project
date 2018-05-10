using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Uploading_and_Viewing_Criteria
{
    public partial class TeacherUploadReport : Form
    {
        public TeacherUploadReport()
        {
            InitializeComponent();
        }

        public TeacherUploadReport(string strtext)
        {
            InitializeComponent();
            label3.Text = strtext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtraView frm = new ExtraView();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool isValidUpload;
            bool isValidUploadSpecified;
            bool isValidTeacherResult;
            bool isValidTeacherResultSpecified;
            service.isValidTeacher(textBox1.Text, out isValidTeacherResult, out isValidTeacherResultSpecified);
            if (isValidTeacherResult)
            {
                service.UploadReport(textBox2.Text, textBox1.Text, label3.Text, comboBox1.Text, textBox4.Text, out isValidUpload, out isValidUploadSpecified);
                if (isValidUpload)
                {
                    MessageBox.Show("Report has been uploaded");
                }
                else
                {
                    MessageBox.Show("Invalid Information");
                }
            }
            else
            {
                MessageBox.Show("Invalid Teacher");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherUploadedReport r = new TeacherUploadedReport();
            this.Hide();
            r.Show();
        }
    }
}

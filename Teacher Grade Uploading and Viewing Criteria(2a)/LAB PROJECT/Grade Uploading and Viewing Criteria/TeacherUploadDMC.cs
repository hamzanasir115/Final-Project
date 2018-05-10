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
    public partial class TeacherUploadDMC : Form
    {
        public TeacherUploadDMC()
        {
            InitializeComponent();
        }

        public TeacherUploadDMC(string strtextbox)
        {
            InitializeComponent();
            label3.Text = strtextbox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherViewStudent form = new TeacherViewStudent();
            this.Hide();
            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isValidUpload;
            bool isValidUploadSpecified;
            bool isValidTeacherResult;
            bool isValidTeacherResultSpecified;
            ser.isValidTeacher(txtTeacherName.Text, out isValidTeacherResult, out isValidTeacherResultSpecified);
            if (isValidTeacherResult)
            {
                ser.UploadDMC(txtStudentName.Text, txtTeacherName.Text, cmbGrade.Text, label3.Text, out isValidUpload, out isValidUploadSpecified);
                if (isValidUpload)
                {
                    MessageBox.Show("Grade has been uploaded");
                }
                else
                {
                    MessageBox.Show("Invalid Data");
                }
            }
            else
            {
                MessageBox.Show("Invalid Teacher Name");
            }
        }

        private void TeacherUploadDMC_Load(object sender, EventArgs e)
        {
           
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherUploadedDMCform dm = new TeacherUploadedDMCform();
            this.Hide();
            dm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

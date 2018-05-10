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
    public partial class StudentLoginViewForm : Form
    {
        public StudentLoginViewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDMC dmc = new StudentDMC();
            this.Hide();
            dmc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OfferedSubjectsform sub = new OfferedSubjectsform();
            this.Hide();
            sub.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            localhost.Service1 ser = new localhost.Service1();
            bool StudentLogoutResult;
            bool StudentLogoutResultSpecified;
            ser.StudentLogout(out StudentLogoutResult, out StudentLogoutResultSpecified);
            if (StudentLogoutResult)
            {
                StudentLoginform login = new StudentLoginform();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRegisterSubject form = new StudentRegisterSubject();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentAttendanceReport form = new StudentAttendanceReport();
            this.Hide();
            form.Show();
        }

        private void btnsubject_Click(object sender, EventArgs e)
        {
            StudentViewSubjectInformation form = new StudentViewSubjectInformation();
            this.Hide();
            form.Show();
        }
    }
}

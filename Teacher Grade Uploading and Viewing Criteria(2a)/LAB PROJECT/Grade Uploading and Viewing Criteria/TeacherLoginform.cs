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
    public partial class TeacherLoginform : Form
    {
        public TeacherLoginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isvalidteacher;
            bool isvalidteacherpassed;
            ser.IsLoginTeacher(txtusername.Text, txtpassword.Text, out isvalidteacher, out isvalidteacherpassed);
            if (isvalidteacher)
            {
                TeacherLoginView form = new TeacherLoginView();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Teacher");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeacherRegistrationform frm = new TeacherRegistrationform();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForgetPassword frm = new TeacherForgetPassword();
            this.Hide();
            frm.Show();
        }
    }
}

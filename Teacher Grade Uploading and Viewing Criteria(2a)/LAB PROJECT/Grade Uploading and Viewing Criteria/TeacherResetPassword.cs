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
    public partial class TeacherResetPassword : Form
    {
        public TeacherResetPassword()
        {
            InitializeComponent();
        }

        private void lnklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeacherLoginform rf = new TeacherLoginform();
            this.Hide();
            rf.Show();
        }

        private void bbreset_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            if (txtpassword.Text.Length >= 6)
            {
                server.resetPassTeacher(txtusername.Text, txtpassword.Text);
                MessageBox.Show("password has been reset");
            }
            else
            {
                MessageBox.Show("Length of password is incorrect");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Length < 6)
            {
                errorProvider1.SetError(txtpassword, "Invalid Password");
            }
            else
            {
                errorProvider1.SetError(txtpassword, "");
            }
        }
    }
}

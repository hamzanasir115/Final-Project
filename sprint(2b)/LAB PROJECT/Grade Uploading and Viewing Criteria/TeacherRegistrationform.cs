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
    public partial class TeacherRegistrationform : Form
    {
        public TeacherRegistrationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isalreadyexist;
            bool isalreadyexistpassed;
            ser.IsTeacherAlreadyExists(txtusername.Text, txtpassword.Text, out isalreadyexist, out isalreadyexistpassed);
            if (isalreadyexist)
            {
                MessageBox.Show("Teacher already exists");
                txtemail.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirmpassword.Text = "";
                txtsecretcode.Text = "";
            }
            else
            {
                if (txtpassword.Text == txtconfirmpassword.Text && txtpassword.Text.Length >= 6)
                {
                    if (txtsecretcode.Text.Length >= 4 && txtsecretcode.Text.Length <= 7)
                    {
                        ser.RegisterTeacher(txtusername.Text, txtpassword.Text, txtsecretcode.Text);
                        MessageBox.Show("Teacher Has Been Registered");
                        txtemail.Text = "";
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        txtconfirmpassword.Text = "";
                        txtsecretcode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Secret code ");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Password Length or mismatch password");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeacherLoginform login = new TeacherLoginform();
            this.Hide();
            login.Show();
        }

        private void TeacherRegistrationform_Load(object sender, EventArgs e)
        {

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

        private void txtsecretcode_TextChanged(object sender, EventArgs e)
        {
            if (txtsecretcode.Text.Length < 4 || txtsecretcode.Text.Length > 7)
                {
                    errorProvider2.SetError(txtsecretcode, "Invalid Secret Code");
                }
            else
            {
                errorProvider2.SetError(txtsecretcode, "");
            }
        }
    }
}

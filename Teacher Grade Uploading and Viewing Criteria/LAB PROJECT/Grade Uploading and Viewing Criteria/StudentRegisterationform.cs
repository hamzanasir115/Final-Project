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
    public partial class StudentRegisterationform : Form
    {
        public StudentRegisterationform()
        {
            InitializeComponent();
        }

        private void lnklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLoginform login = new StudentLoginform();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isalreadyexist;
            bool isalreadyexistpassed;
            ser.IsAlreadyExist(txtusername.Text, txtpassword.Text, cmbtxt.Text, txtanswer.Text,out isalreadyexist, out isalreadyexistpassed );
            if (isalreadyexist)
            {
                MessageBox.Show("User already exits");
                txtemail.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirm.Text = "";
                txtanswer.Text = "";
                cmbtxt.Text = "";
            }
            else
            {
                if (txtpassword.Text == txtconfirm.Text && txtpassword.Text.Length >= 6)
                {
                    ser.RegisterStd(txtusername.Text, txtpassword.Text, cmbtxt.Text, txtanswer.Text);
                    MessageBox.Show("User has been Registered");
                    txtemail.Text = "";
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtconfirm.Text = "";
                    txtanswer.Text = "";
                    cmbtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Password Length or mismatch password");
                }
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

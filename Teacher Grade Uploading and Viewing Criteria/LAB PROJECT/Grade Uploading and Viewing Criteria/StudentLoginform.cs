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
    public partial class StudentLoginform : Form
    {
        public StudentLoginform()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRegisterationform register = new StudentRegisterationform();
            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isvaliduser;
            bool isvaliduserpassed;
            ser.isValidUser(txtusername.Text, txtpassword.Text, out isvaliduser, out isvaliduserpassed);
            
                if (isvaliduser)
                {
                    MessageBox.Show("Valid User");
                }
                else
                {
                    MessageBox.Show("InValid User");
                }

            
        }
    }
}

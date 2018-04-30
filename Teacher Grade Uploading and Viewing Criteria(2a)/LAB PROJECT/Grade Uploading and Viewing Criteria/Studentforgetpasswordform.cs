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
    public partial class Studentforgetpasswordform : Form
    {
        public Studentforgetpasswordform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalidreset;
            bool isvalidresetpassed;
            localhost.Service1 ser = new localhost.Service1();
            ser.ValidReset(txtusername.Text, cmbquestions.Text,txtanswer.Text, out isvalidreset, out isvalidresetpassed);
            if (isvalidreset)
            {
                MessageBox.Show("Valid Data");
            }
            else
            {
                MessageBox.Show("Invalid information");
            }
        }

        private void bblogin_Click(object sender, EventArgs e)
        {
            StudentLoginform login = new StudentLoginform();
            this.Hide();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isF;
            bool isFF;
            localhost.Service1 ser = new localhost.Service1();
            ser.SetPassword(txtusername.Text, cmbquestions.Text, txtanswer.Text, out isF, out isFF);
            if (isF == true)
            {
                Reset_Password rf = new Reset_Password();
                this.Hide();
                rf.Show();
            }
            else
            {
                MessageBox.Show("wrong answer");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentLoginform login = new StudentLoginform();
            this.Hide();
            login.Show();
        }
    }
}

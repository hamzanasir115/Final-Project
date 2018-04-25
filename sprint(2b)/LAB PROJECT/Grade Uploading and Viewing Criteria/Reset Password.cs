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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.resetPass(textBox1.Text, textBox2.Text);
            MessageBox.Show("password has been reset");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLoginform form = new StudentLoginform();
            form.Show();
            this.Hide();
        }
    }
}

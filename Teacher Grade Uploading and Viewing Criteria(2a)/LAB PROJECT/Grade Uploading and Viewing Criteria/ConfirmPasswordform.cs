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
    public partial class ConfirmPasswordform : Form
    {
        public ConfirmPasswordform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                StudentLoginform form = new StudentLoginform();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}

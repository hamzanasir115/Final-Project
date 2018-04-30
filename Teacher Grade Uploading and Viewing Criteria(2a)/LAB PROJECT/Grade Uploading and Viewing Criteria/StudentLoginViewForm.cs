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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OfferedSubjectsform sub = new OfferedSubjectsform();
            this.Hide();
            sub.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentLoginform login = new StudentLoginform();
            this.Hide();
            login.Show();
        }
    }
}

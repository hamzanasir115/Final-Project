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
    public partial class StudentViewSubjectInformation : Form
    {
        public StudentViewSubjectInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLoginViewForm form = new StudentLoginViewForm();
            this.Hide();
            form.Show();
        }
    }
}

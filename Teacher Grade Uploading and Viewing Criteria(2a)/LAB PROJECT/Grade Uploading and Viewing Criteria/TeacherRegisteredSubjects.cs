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
    public partial class TeacherRegisteredSubjects : Form
    {
        public TeacherRegisteredSubjects()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherLoginView form = new TeacherLoginView();
            this.Hide();
            form.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            TeacherViewSubjects form = new TeacherViewSubjects();
            this.Hide();
            form.Show();
        }
    }
}

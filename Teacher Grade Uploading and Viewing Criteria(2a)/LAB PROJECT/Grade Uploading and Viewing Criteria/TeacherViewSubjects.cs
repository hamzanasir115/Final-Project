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
    public partial class TeacherViewSubjects : Form
    {
        public TeacherViewSubjects()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            ser.TeacherShowSubject(txtUserName.Text);
            source.DataSource = ser.TeacherShowSubject(txtUserName.Text);
            dataGridView1.DataSource = source;
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isvalidTeacherResult;
            bool isValidTeacherResultSpecified;
            BindingSource source = new BindingSource();
            ser.isValidTeacher(txtUserName.Text, out isvalidTeacherResult, out isValidTeacherResultSpecified);
            if (isvalidTeacherResult)
            {
                ser.TeacherShowSubject(txtUserName.Text);
                source.DataSource = ser.TeacherShowSubject(txtUserName.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Invalid Teacher");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherRegisteredSubjects form = new TeacherRegisteredSubjects();
            form.Show();
            this.Hide();
        }
    }
}

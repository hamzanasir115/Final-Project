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
    public partial class StudentAttendanceReport : Form
    {
        public StudentAttendanceReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLoginViewForm form = new StudentLoginViewForm();
            this.Hide();
            form.Show();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool Validstu;
            bool ValidStudent;
            ser.isValidStudent(txtusername.Text, out Validstu, out ValidStudent);
            BindingSource source = new BindingSource();
            if (Validstu)
            {
                source.DataSource = ser.StudentViewReport(txtusername.Text);
                ser.StudentViewReport(txtusername.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Invalid Student");
            }
        }
    }
}

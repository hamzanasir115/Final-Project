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
    public partial class TeacherUploadedReport : Form
    {
        public TeacherUploadedReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool isValidsub;
            bool isValidsubject;
            service.isTeacherValidSubject(comboBox1.Text, out isValidsubject, out isValidsub);
            BindingSource source = new BindingSource();
            if (isValidsubject)
            {
                source.DataSource = service.TeacherViewReport(comboBox1.Text);
                service.TeacherViewReport(comboBox1.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Invalid Subject");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherUploadReport r = new TeacherUploadReport();
            this.Hide();
            r.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}

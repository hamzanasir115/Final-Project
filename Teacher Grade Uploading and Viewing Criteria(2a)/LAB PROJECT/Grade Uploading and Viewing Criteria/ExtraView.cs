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
    public partial class ExtraView : Form
    {
        public ExtraView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource source = new BindingSource();
            service.ShowBySubject(comboBox1.Text);
            source.DataSource = service.ShowBySubject(comboBox1.Text);
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool isvalidSub;
            bool isvalidsubject;
            service.isValidSubject(comboBox1.Text, out isvalidsubject, out isvalidSub);
            BindingSource source = new BindingSource();
            if (isvalidsubject)
            {
                service.ShowBySubject(comboBox1.Text);
                source.DataSource = service.ShowBySubject(comboBox1.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Subject not Registered");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherLoginView t = new TeacherLoginView();
            this.Hide();
            t.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            localhost.Service1 service = new localhost.Service1();
            bool isvalidsub;
            bool isvalidsubject;
            service.isTeacherValidSubject(comboBox1.Text, out isvalidsubject, out isvalidsub);
            if (isvalidsubject)
            {
                TeacherUploadReport r = new TeacherUploadReport(comboBox1.Text);
                this.Hide();
                r.Show();
            }
            else
            {
                MessageBox.Show("Teacher has not registered this subject.");
            }
            
        }
    }
}

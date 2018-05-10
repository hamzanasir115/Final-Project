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
    public partial class TeacherViewStudent : Form
    {
        public TeacherViewStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource source = new BindingSource();
            service.ShowBySubject(cmbsubject.Text);
            source.DataSource = service.ShowBySubject(cmbsubject.Text);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool isvalidSub;
            bool isvalidsubject;
            service.isValidSubject(cmbsubject.Text, out isvalidsubject, out isvalidSub);
            BindingSource source = new BindingSource();
            if (isvalidsubject)
            {
                service.ShowBySubject(cmbsubject.Text);
                source.DataSource = service.ShowBySubject(cmbsubject.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Subject Not Registered");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherLoginView v = new TeacherLoginView();
            this.Hide();
            v.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            // MessageBox.Show(item.ToString());
            TeacherUploadDMC form = new TeacherUploadDMC(cmbsubject.Text);
            this.Hide();
            form.Show();
            

        }

        public void cmbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
           




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class TeacherUploadedDMCform : Form
    {
        public TeacherUploadedDMCform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherLoginView form = new TeacherLoginView();
            this.Hide();
            form.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool isvalidSub;
            bool isvalidsubject;
            ser.isValidSubject(cmbSubject.Text, out isvalidsubject, out isvalidSub);
            BindingSource source = new BindingSource();
            if (isvalidsubject)
            {
                source.DataSource = ser.TeacherViewDMC(cmbSubject.Text);
                ser.TeacherViewDMC(cmbSubject.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Invalid subject");
            }
        }
    }
}

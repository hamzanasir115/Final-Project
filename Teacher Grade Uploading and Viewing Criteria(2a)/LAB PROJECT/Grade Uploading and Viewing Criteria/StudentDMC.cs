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
    public partial class StudentDMC : Form
    {
        public StudentDMC()
        {
            InitializeComponent();
        }

        private void StudentDMC_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool Validstu;
            bool ValidStudent;
            ser.isValidStudent(txtusername.Text,out Validstu,out ValidStudent);
            BindingSource source = new BindingSource();
            //source.DataSource = ser.StudentViewDMC(txtusername.T);
            //dataGridView1.DataSource = source;
            if (Validstu)
            {
                source.DataSource = ser.StudentViewDMC(txtusername.Text);
                ser.StudentViewDMC(txtusername.Text);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Invalid Student");
            }
        }
    }
}

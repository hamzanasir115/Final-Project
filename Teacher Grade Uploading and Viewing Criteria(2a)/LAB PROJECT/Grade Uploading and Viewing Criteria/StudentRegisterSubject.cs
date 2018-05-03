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
    public partial class StudentRegisterSubject : Form
    {
        public StudentRegisterSubject()
        {
            InitializeComponent();
        }

        private void btnShowSubject_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            ser.showSubjects(txtUserName.Text);
            source.DataSource = ser.showSubjects(txtUserName.Text);
            dataGridView1.DataSource = source;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            ser.showSubjects(txtUserName.Text);
            source.DataSource = 
            dataGridView1.DataSource = source;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            StudentLoginViewForm stu = new StudentLoginViewForm();
            stu.Show();
            this.Hide();
        }
    }
}

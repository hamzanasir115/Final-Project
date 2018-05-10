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
    public partial class TeacherLoginView : Form
    {
        public TeacherLoginView()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool TeacherLogoutResult;
            bool TeacherLogoutResultSpecified;
            ser.TeacherLogout(out TeacherLogoutResult, out TeacherLogoutResultSpecified);
            if (TeacherLogoutResult)
            {
                TeacherLoginform frm = new TeacherLoginform();
                this.Hide();
                frm.Show();
            }
            else
            {
               
            }
        }

        private void cmbsubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherOfferedSubjectForm form = new TeacherOfferedSubjectForm();
            form.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TeacherRegisteredSubjects form = new TeacherRegisteredSubjects();
            form.Show();
            this.Hide();
        }

        private void btnUploadDMC_Click(object sender, EventArgs e)
        {
            TeacherViewStudent t = new TeacherViewStudent();
            this.Hide();
            t.Show();
        }

        private void btnUploadReport_Click(object sender, EventArgs e)
        {
            ExtraView t = new ExtraView();
            this.Hide();
            t.Show();
        }
    }
}

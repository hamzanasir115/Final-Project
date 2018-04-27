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
    public partial class TeacherForgetPassword : Form
    {
        public TeacherForgetPassword()
        {
            InitializeComponent();
        }

        private void bbsave_Click(object sender, EventArgs e)
        {
            bool isF;
            bool isFF;
            localhost.Service1 ser = new localhost.Service1();
            ser.SetPasswordTeacher(txtusername.Text, txtsecret.Text, out isF, out isFF);
            if (isF == true)
            {
                TeacherResetPassword rf = new TeacherResetPassword();
                this.Hide();
                rf.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }
    }
}

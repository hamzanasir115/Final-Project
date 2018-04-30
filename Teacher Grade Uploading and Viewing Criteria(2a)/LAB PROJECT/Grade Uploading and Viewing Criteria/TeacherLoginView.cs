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
            TeacherLoginform frm = new TeacherLoginform();
            this.Hide();
            frm.Show();
        }

        private void cmbsubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class TeacherOfferedSubjectForm : Form
    {
        public TeacherOfferedSubjectForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherOfferedSubjectForm_Load(object sender, EventArgs e)
        {
            lblsubjectname.Hide();
            lblcredithors.Hide();
            lblsubjectcode.Hide();
            sub1.Hide();
            sub2.Hide();
            sub3.Hide();
            sub4.Hide();
            sub5.Hide();
            code1.Hide();
            code2.Hide();
            code3.Hide();
            code4.Hide();
            code5.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            lblDiscreteMathematics.Hide();
            label6.Hide();
            label9.Hide();
            //int RegisteredSubject = 0;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            
            localhost.Service1 ser = new localhost.Service1();
            bool isalreadyexist;
            bool isalreadyexistpassed;
            ser.isTeacherSubAlreadyExist(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, out isalreadyexist, out isalreadyexistpassed);
            bool isValudTeacherResultSpecified;
            bool isValidTeacherResult;
            ser.isValidTeacher(txtusername.Text, out isValidTeacherResult, out isValudTeacherResultSpecified);
            if (isalreadyexist && isValidTeacherResult)
            {
                MessageBox.Show("Subject is already registered ");
                cmbsubjectcode.Text = "";
                cmbofferedsubjects.Text = "";
                txtcredithours.Text = "";
            }
            else
            {
                if (isValidTeacherResult)
                {
                    if (cmbofferedsubjects.Text == sub1.Text && cmbsubjectcode.Text == code1.Text && txtcredithours.Text == label6.Text)
                    {
                        ser.AddTeacherRegisteredSubject(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, txtcredithours.Text);
                        MessageBox.Show("OOP has been registered");
                        cmbsubjectcode.Text = "";
                        cmbofferedsubjects.Text = "";
                        txtcredithours.Text = "";
                    }
                    else if (cmbofferedsubjects.Text == sub2.Text && cmbsubjectcode.Text == code2.Text && txtcredithours.Text == label6.Text)
                    {
                        ser.AddTeacherRegisteredSubject(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, txtcredithours.Text);
                        MessageBox.Show("PF has been registered");
                        cmbsubjectcode.Text = "";
                        cmbofferedsubjects.Text = "";
                        txtcredithours.Text = "";
                    }
                    else if (cmbsubjectcode.Text == code3.Text && cmbofferedsubjects.Text == sub3.Text && txtcredithours.Text == label6.Text)
                    {
                        ser.AddTeacherRegisteredSubject(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, txtcredithours.Text);
                        MessageBox.Show("ICS has been registered");
                        cmbsubjectcode.Text = "";
                        cmbofferedsubjects.Text = "";
                        txtcredithours.Text = "";
                    }
                    else if (cmbofferedsubjects.Text == lblDiscreteMathematics.Text && cmbsubjectcode.Text == code4.Text && txtcredithours.Text == label6.Text)
                    {
                        ser.AddTeacherRegisteredSubject(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, txtcredithours.Text);
                        MessageBox.Show("DM has been registered");
                        cmbsubjectcode.Text = "";
                        cmbofferedsubjects.Text = "";
                        txtcredithours.Text = "";
                    }
                    else if (cmbofferedsubjects.Text == sub5.Text && cmbsubjectcode.Text == code5.Text && txtcredithours.Text == label6.Text)
                    {
                        ser.AddTeacherRegisteredSubject(txtusername.Text, cmbofferedsubjects.Text, cmbsubjectcode.Text, txtcredithours.Text);
                        MessageBox.Show("DLD has been registered");
                        cmbsubjectcode.Text = "";
                        cmbofferedsubjects.Text = "";
                        txtcredithours.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherLoginView form = new TeacherLoginView();
            form.Show();
            this.Hide();
        }
    }
}

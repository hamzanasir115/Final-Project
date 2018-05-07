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
    public partial class OfferedSubjectsform : Form
    {
        public OfferedSubjectsform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool isalreadyexist;
            bool isalreadyexistpassed;
            bool isValidStudentResult;
            bool isValidStudentResultSpecified;
            service.IsSubjectAlreadyExist(txtUserName.Text, cmbSubject.Text, cmbCode.Text, out isalreadyexist, out isalreadyexistpassed);
            service.isValidStudent(txtUserName.Text, out isValidStudentResult, out isValidStudentResultSpecified);
            if(isalreadyexist && isValidStudentResult)
            {
                MessageBox.Show("Subject has been already registered");
                cmbSubject.Text = "";
                cmbCode.Text = "";
                txtCreditHour.Text = "";
            }
            else
            {
                if (isValidStudentResult)
                {
                    if (cmbSubject.Text == sub1.Text && cmbCode.Text == code1.Text && txtCreditHour.Text == label6.Text)
                    {
                        service.AddSubject(txtUserName.Text, cmbSubject.Text, cmbCode.Text, txtCreditHour.Text);
                        MessageBox.Show("Subject has been added");
                        cmbSubject.Text = "";
                        cmbCode.Text = "";
                        txtCreditHour.Text = "";
                    }
                    else if (cmbSubject.Text == sub2.Text && cmbCode.Text == code2.Text && txtCreditHour.Text == label6.Text)
                    {
                        service.AddSubject(txtUserName.Text, cmbSubject.Text, cmbCode.Text, txtCreditHour.Text);
                        MessageBox.Show("Subject has been added");
                        cmbSubject.Text = "";
                        cmbCode.Text = "";
                        txtCreditHour.Text = "";
                    }
                    else if (cmbSubject.Text == sub3.Text && cmbCode.Text == code3.Text && txtCreditHour.Text == label6.Text)
                    {
                        service.AddSubject(txtUserName.Text, cmbSubject.Text, cmbCode.Text, txtCreditHour.Text);
                        MessageBox.Show("Subject has been added");
                        cmbSubject.Text = "";
                        cmbCode.Text = "";
                        txtCreditHour.Text = "";
                    }
                    else if (cmbSubject.Text == label4.Text && cmbCode.Text == code4.Text && txtCreditHour.Text == label6.Text)
                    {
                        service.AddSubject(txtUserName.Text, cmbSubject.Text, cmbCode.Text, txtCreditHour.Text);
                        MessageBox.Show("Subject has been added");
                        cmbSubject.Text = "";
                        cmbCode.Text = "";
                        txtCreditHour.Text = "";
                    }
                    else if (cmbSubject.Text == sub5.Text && cmbCode.Text == code5.Text && txtCreditHour.Text == label6.Text)
                    {
                        service.AddSubject(txtUserName.Text, cmbSubject.Text, cmbCode.Text, txtCreditHour.Text);
                        MessageBox.Show("Subject has been added");
                        cmbSubject.Text = "";
                        cmbCode.Text = "";
                        txtCreditHour.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Subject i.e. either SubjectName or SubjectCode or CreditHour doesn't match.Please select a suitable one");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Student");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLoginform login = new StudentLoginform();
            this.Hide();
            login.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLoginViewForm frm = new StudentLoginViewForm();
            this.Hide();
            frm.Show();
        }

        private void OfferedSubjectsform_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            sub1.Hide();
            sub2.Hide();
            sub3.Hide();
            label4.Hide();
            sub5.Hide();
            code1.Hide();
            code2.Hide();
            code3.Hide();
            code4.Hide();
            code5.Hide();
            label6.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

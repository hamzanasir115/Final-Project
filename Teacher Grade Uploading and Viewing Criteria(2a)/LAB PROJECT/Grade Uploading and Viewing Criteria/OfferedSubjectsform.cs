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
            service.IsSubjectAlreadyExist(cmbSubject.Text, cmbCode.Text, out isalreadyexist, out isalreadyexistpassed);
            if(isalreadyexist)
            {
                MessageBox.Show("Subject is added already");
                cmbSubject.Text = "";
                cmbCode.Text = "";
            }
            else
            {
                if(cmbSubject.Text == sub1.Text && cmbCode.Text == code1.Text)
                {
                    service.AddSubject(cmbSubject.Text, cmbCode.Text);
                    MessageBox.Show("Subject has been added");
                    cmbSubject.Text = "";
                    cmbCode.Text = "";
                }
                else if(cmbSubject.Text == sub2.Text && cmbCode.Text == code2.Text)
                {
                    service.AddSubject(cmbSubject.Text, cmbCode.Text);
                    MessageBox.Show("Subject has been added");
                    cmbSubject.Text = "";
                    cmbCode.Text = "";
                }
                else if(cmbSubject.Text == sub3.Text && cmbCode.Text == code3.Text)
                {
                    service.AddSubject(cmbSubject.Text, cmbCode.Text);
                    MessageBox.Show("Subject has been added");
                    cmbSubject.Text = "";
                    cmbCode.Text = "";
                }
                else if (cmbSubject.Text == label4.Text && cmbCode.Text == code4.Text)
                {
                    service.AddSubject(cmbSubject.Text, cmbCode.Text);
                    MessageBox.Show("Subject has been added");
                    cmbSubject.Text = "";
                    cmbCode.Text = "";
                }
                else if (cmbSubject.Text == sub5.Text && cmbCode.Text == code5.Text)
                {
                    service.AddSubject(cmbSubject.Text, cmbCode.Text);
                    MessageBox.Show("Subject has been added");
                    cmbSubject.Text = "";
                    cmbCode.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Subject i.e. either SubjectName or SubjectCode doesn't match.Please select a suitable one");
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
    }
}

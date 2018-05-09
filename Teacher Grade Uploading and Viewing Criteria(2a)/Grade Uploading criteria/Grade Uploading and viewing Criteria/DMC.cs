using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grade_Uploading_and_viewing_Criteria
{
    public class DMC
    {
        private string StudentName;

        public string StudentName1
        {
            get { return StudentName; }
            set { StudentName = value; }
        }
        private string TeacherName;

        public string TeacherName1
        {
            get { return TeacherName; }
            set { TeacherName = value; }
        }

        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
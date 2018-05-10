using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grade_Uploading_and_viewing_Criteria
{
    public class Report
    {
        private string teachername;

        public string TeacherName
        {
            get { return teachername; }
            set { teachername = value; }
        }
        private string studentname;

        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string behaviorereport;

        public string BehavioreReport
        {
            get { return behaviorereport; }
            set { behaviorereport = value; }
        }

        
        private string attendencepercentage;

        public string AttendencePercentage
        {
            get { return attendencepercentage; }
            set { attendencepercentage = value; }
        }

       
    }
}
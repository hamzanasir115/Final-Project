using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections;

namespace Grade_Uploading_and_viewing_Criteria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void RegisterStd(string username, string password, string ques, string answer)
        {
            STUDENT std = new STUDENT();
            std.UserName1 = username;
            STUDENTDL.username.Add(username);
            std.Password1 = password;
            STUDENTDL.password.Add(password);
            std.SecretQuestion1 = ques;
            STUDENTDL.secretQ.Add(ques);
            std.Answer1 = answer;
            STUDENTDL.answer.Add(answer);
            /*bool x;
            foreach (STUDENT s in STUDENTDL.list)
            {
                if (s.UserName1 == username)
                {
                    x = true;
                }
            }
            if (x == true)
            {
                MessageBox.Show("User Already exists");
            }*/
            STUDENTDL.list.Add(std);
        }

        public void RegisterTeacher(string username, string password, string secretcode)
        {
            TEACHER teach = new TEACHER();
            teach.UserName1 = username;
            teach.Password1 = password;
            teach.Secretcode = secretcode;
            TEACHERDL.TeacherList.Add(teach);
        }

        public bool Login(string username, string pass)
        {
            bool isfound = false;
            STUDENTDL stdlist = new STUDENTDL();
            foreach (STUDENT s in STUDENTDL.list)
            {
                if (s.UserName1 == username)
                {
                    if(s.Password1 == pass)
                    {
                        isfound = true;
                    }
                }
            }
            return isfound;
        }

        public bool isValidUser(string userName, string password)
        {
            bool isFound = false;
            foreach (STUDENT u in STUDENTDL.list)
            {
                if (u.UserName1 == userName && u.Password1 == password)
                {
                    isFound = true;
                }
            }
            return isFound;
            throw new NotImplementedException();
        }

        public bool IsLoginTeacher(string username, string password)
        {
            bool isfound = false;
            TEACHER teach = new TEACHER();
            foreach (TEACHER t in TEACHERDL.TeacherList)
            {
                if (t.UserName1 == username && t.Password1 == password)
                {
                    isfound = true;
                    TEACHERDL.userName.Clear();
                    teach.UserName1 = username;
                    TEACHERDL.userName.Add(teach);
                }    
            }
            return isfound;

        }

        public bool TeacherLogout()
        {
            bool istrue = false;
            TEACHERDL.userName.Clear();
            if (TEACHERDL.userName.Count == 0)
            {
                istrue = true;
            }
            return istrue;
        }
        public bool IsAlreadyExist(string username, string pass, string ques, string answer)
        {
            bool x = false;
            foreach (STUDENT s in STUDENTDL.list)
            {
                if (s.UserName1 == username)
                {
                    x = true;
                }
            }
            return x;
        }


        public bool IsTeacherAlreadyExists(string username, string password)
        {
            bool x = false;
            foreach(TEACHER t in TEACHERDL.TeacherList)
            {
                if (t.UserName1 == username)
                {
                    x = true;
                }
                
            }
            return x;
        }
        public bool ValidReset(string username, string ques, string answer)
        { 
          bool reset = false;
          foreach (STUDENT u in STUDENTDL.list)
          {
              if (u.UserName1 == username && u.SecretQuestion1 == ques && u.Answer1 == answer)
              {
                  reset = true;
              }
          }
          return reset;
        }
        public bool SetPassword(string username, string ques, string ans)
        {
            return STUDENTDL.SetPassword(username, ques, ans);
        }

        public void DeleteRecord(string username, string secretquestion, string answer)
        {
            
        }


        public void resetPass(string username, string pass)
        {
             STUDENTDL.resetPass(username, pass);
        }
        public bool SetPasswordTeacher(string username, string code)
        {
            return TEACHERDL.SetPasswordTeacher(username, code);
        }

        public void resetPassTeacher(string username, string pass)
        {
            TEACHERDL.resetPassTeacher(username, pass);
        }

        public bool isValidSubject(string subjectName, string subjectCode)
        {
            bool isfoundsubject = false;
            foreach (SUBJECT s in SUBJECTDL.SubjectList)
            {
                if (s.SubjectName1 == subjectName && s.SubjectCode1 == subjectCode)
                {
                    isfoundsubject = true;
                }
            }
            return isfoundsubject;          
        }

        public void AddSubject(string username, string subjectname, string subjectcode, string creditHour)
        {
            bool isfound = false;
            foreach (STUDENT stu in STUDENTDL.list)
            {
                if (stu.UserName1 == username)
                {
                    isfound = true;
                }
            }

            if (isfound == true)
            {
                SUBJECT sub = new SUBJECT();
                sub.Username = username;
                sub.SubjectName1 = subjectname;
                sub.SubjectCode1 = subjectcode;
                sub.CreditHours1 = creditHour;
                SUBJECTDL.SubjectList.Add(sub);
                STUDENTDL.RegisterSubjectList.Add(sub);
            }
        }

        public bool IsSubjectAlreadyExist(string username, string subjectname, string subjectcode)
        {
            bool isSubjectAlreadyExist = false;
            foreach (SUBJECT s in SUBJECTDL.SubjectList)
            {
                if (s.SubjectName1 == subjectname && s.Username == username)
                {
                    isSubjectAlreadyExist = true;
                }
            }
            return isSubjectAlreadyExist;
        }

        public bool isTeacherSubAlreadyExist(string username, string subjectname, string subjectcode)
        {
            bool isSubjectExist = false;
            foreach (SUBJECT sub in SUBJECTDL.TeacherSubList)
            {
                if (sub.SubjectName1 == subjectname && sub.Username == username)
                {
                    isSubjectExist = true;
                }
            }
            return isSubjectExist;
        }
        public List<SUBJECT> showSubjects(string username)
        {
            List<SUBJECT> sub = new List<SUBJECT>();
            SUBJECT s = new SUBJECT();
            foreach (SUBJECT subj in SUBJECTDL.SubjectList)
            {
                if (subj.Username == username)
                {
                    sub.Add(subj);
                }
            }
            return sub;

        }

        public List<SUBJECT> TeacherShowSubject(string username)
        {
            List<SUBJECT> sub = new List<SUBJECT>();
            foreach (SUBJECT subj in SUBJECTDL.TeacherSubList)
            {
                if (subj.Username == username)
                {
                    sub.Add(subj);
                }
            }
            return sub;
        }


        public bool isValidTeacher(string username)
        {
            
            bool isfound = false;
            foreach (TEACHER t in TEACHERDL.userName)
            {
                if (t.UserName1== username)
                {
                    isfound = true;
                }
            }
            return isfound;
        }

        public void AddTeacherRegisteredSubject(string username, string SubjectName, string SubjectCode, string CreditHour)
        {
            SUBJECT subj = new SUBJECT();
            subj.Username = username;
            subj.SubjectCode1 = SubjectCode;
            subj.SubjectName1 = SubjectName;
            subj.CreditHours1 = CreditHour;
            SUBJECTDL.TeacherSubList.Add(subj);
        }

        
    }
}

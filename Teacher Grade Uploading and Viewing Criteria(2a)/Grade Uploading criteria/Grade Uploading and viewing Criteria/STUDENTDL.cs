using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows;

namespace Grade_Uploading_and_viewing_Criteria
{
    public class STUDENTDL
    {
        public static List<STUDENT> list = new List<STUDENT>();
        public static ArrayList username = new ArrayList();
        public static ArrayList password = new ArrayList();
        public static ArrayList secretQ = new ArrayList();
        public static ArrayList answer = new ArrayList();
        public static ArrayList subject = new ArrayList();

        public static List<SUBJECT> RegisterSubjectList = new List<SUBJECT>();

        public static  STUDENT loginuser = null;
        public static bool SetPassword(string username,  string ques, string ans)
        {
            bool isFound = false;
            foreach (STUDENT SU in list)
            {

                if (SU.UserName1 == username && SU.SecretQuestion1 == ques && SU.Answer1 == ans)
                {
                    
                    isFound = true;
                    
                }
            }
            return isFound;

        }
        public static void resetPass(string username, string pass)
        {
            foreach (STUDENT S in list)
            {
                if (S.UserName1 == username)
                {
                    S.Password1 = pass;
                }
            }
        }
/*
        public static List<STUDENTDL> showSubjects(string username)
        {
            List<STUDENTDL> dl = new List<STUDENTDL>();
           
            foreach(STUDENT s in STUDENTDL.list)
            {
                if (s.UserName1 == username)
                {
                    STUDENTDL.subject.Add(s);
                    
                }
            }

            return dl;
        }*/
    }
}
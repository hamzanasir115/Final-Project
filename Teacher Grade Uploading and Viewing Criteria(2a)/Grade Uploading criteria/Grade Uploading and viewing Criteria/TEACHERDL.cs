using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Grade_Uploading_and_viewing_Criteria
{
    public class TEACHERDL
    {
        public static List<TEACHER> TeacherList = new List<TEACHER>();

        public static List<TEACHER> userName = new List<TEACHER>();
        public static ArrayList password = new ArrayList();
        public static bool SetPasswordTeacher(string username, string code)
        {
            bool isFound = false;
            foreach (TEACHER Te in TeacherList)
            {

                if (Te.UserName1 == username && Te.Secretcode == code)
                {

                    isFound = true;

                }
            }
            return isFound;

        }
        public static void resetPassTeacher(string username, string pass)
        {
            foreach (TEACHER Te in TeacherList)
            {
                if (Te.UserName1 == username)
                {
                    Te.Password1 = pass;
                }
            }
        }
    }
}
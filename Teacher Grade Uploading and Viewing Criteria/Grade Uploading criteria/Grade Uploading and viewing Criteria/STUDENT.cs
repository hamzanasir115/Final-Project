using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grade_Uploading_and_viewing_Criteria
{
    public class STUDENT
    {
        private string UserName;

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string Password;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }

        private string SecretQuestion;

        public string SecretQuestion1
        {
            get { return SecretQuestion; }
            set { SecretQuestion = value; }
        }

        private string Answer;

        public string Answer1
        {
            get { return Answer; }
            set { Answer = value; }
        }
        private string Email;

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
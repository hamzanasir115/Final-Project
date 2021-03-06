﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Grade_Uploading_and_viewing_Criteria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool IsAlreadyExist(string username, string pass, string ques, string answer);
        
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void RegisterStd(string username, string password, string ques, string answer);

        [OperationContract]
        void RegisterTeacher(string username, string password, string secretcode);

        [OperationContract]
        bool IsLoginTeacher(string username, string password);

        [OperationContract]
        bool Login(string username, string pass);

        [OperationContract]
        bool isValidUser(string userName, string password);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool IsTeacherAlreadyExists(string username, string password);

        [OperationContract]
        bool ValidReset(string username, string ques, string answer);

        // TODO: Add your service operations here

        [OperationContract]
        bool SetPassword(string username,  string ques, string ans);

        [OperationContract]
        bool SetPasswordTeacher(string username, string code);
        [OperationContract]
        void resetPass(string username, string pass);
        [OperationContract]
        void resetPassTeacher(string username, string pass);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Grade_Uploading_and_Viewing_Criteria.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback IsAlreadyExistOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterStdOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterTeacherOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsLoginTeacherOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback isValidUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsTeacherAlreadyExistsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::Grade_Uploading_and_Viewing_Criteria.Properties.Settings.Default.Grade_Uploading_and_Viewing_Criteria_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event IsAlreadyExistCompletedEventHandler IsAlreadyExistCompleted;
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event RegisterStdCompletedEventHandler RegisterStdCompleted;
        
        /// <remarks/>
        public event RegisterTeacherCompletedEventHandler RegisterTeacherCompleted;
        
        /// <remarks/>
        public event IsLoginTeacherCompletedEventHandler IsLoginTeacherCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event isValidUserCompletedEventHandler isValidUserCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        public event IsTeacherAlreadyExistsCompletedEventHandler IsTeacherAlreadyExistsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/IsAlreadyExist", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IsAlreadyExist([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pass, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ques, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string answer, out bool IsAlreadyExistResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool IsAlreadyExistResultSpecified) {
            object[] results = this.Invoke("IsAlreadyExist", new object[] {
                        username,
                        pass,
                        ques,
                        answer});
            IsAlreadyExistResult = ((bool)(results[0]));
            IsAlreadyExistResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void IsAlreadyExistAsync(string username, string pass, string ques, string answer) {
            this.IsAlreadyExistAsync(username, pass, ques, answer, null);
        }
        
        /// <remarks/>
        public void IsAlreadyExistAsync(string username, string pass, string ques, string answer, object userState) {
            if ((this.IsAlreadyExistOperationCompleted == null)) {
                this.IsAlreadyExistOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsAlreadyExistOperationCompleted);
            }
            this.InvokeAsync("IsAlreadyExist", new object[] {
                        username,
                        pass,
                        ques,
                        answer}, this.IsAlreadyExistOperationCompleted, userState);
        }
        
        private void OnIsAlreadyExistOperationCompleted(object arg) {
            if ((this.IsAlreadyExistCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsAlreadyExistCompleted(this, new IsAlreadyExistCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/RegisterStd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RegisterStd([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ques, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string answer) {
            this.Invoke("RegisterStd", new object[] {
                        username,
                        password,
                        ques,
                        answer});
        }
        
        /// <remarks/>
        public void RegisterStdAsync(string username, string password, string ques, string answer) {
            this.RegisterStdAsync(username, password, ques, answer, null);
        }
        
        /// <remarks/>
        public void RegisterStdAsync(string username, string password, string ques, string answer, object userState) {
            if ((this.RegisterStdOperationCompleted == null)) {
                this.RegisterStdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterStdOperationCompleted);
            }
            this.InvokeAsync("RegisterStd", new object[] {
                        username,
                        password,
                        ques,
                        answer}, this.RegisterStdOperationCompleted, userState);
        }
        
        private void OnRegisterStdOperationCompleted(object arg) {
            if ((this.RegisterStdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterStdCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/RegisterTeacher", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RegisterTeacher([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string secretcode) {
            this.Invoke("RegisterTeacher", new object[] {
                        username,
                        password,
                        secretcode});
        }
        
        /// <remarks/>
        public void RegisterTeacherAsync(string username, string password, string secretcode) {
            this.RegisterTeacherAsync(username, password, secretcode, null);
        }
        
        /// <remarks/>
        public void RegisterTeacherAsync(string username, string password, string secretcode, object userState) {
            if ((this.RegisterTeacherOperationCompleted == null)) {
                this.RegisterTeacherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterTeacherOperationCompleted);
            }
            this.InvokeAsync("RegisterTeacher", new object[] {
                        username,
                        password,
                        secretcode}, this.RegisterTeacherOperationCompleted, userState);
        }
        
        private void OnRegisterTeacherOperationCompleted(object arg) {
            if ((this.RegisterTeacherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterTeacherCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/IsLoginTeacher", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IsLoginTeacher([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool IsLoginTeacherResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool IsLoginTeacherResultSpecified) {
            object[] results = this.Invoke("IsLoginTeacher", new object[] {
                        username,
                        password});
            IsLoginTeacherResult = ((bool)(results[0]));
            IsLoginTeacherResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void IsLoginTeacherAsync(string username, string password) {
            this.IsLoginTeacherAsync(username, password, null);
        }
        
        /// <remarks/>
        public void IsLoginTeacherAsync(string username, string password, object userState) {
            if ((this.IsLoginTeacherOperationCompleted == null)) {
                this.IsLoginTeacherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsLoginTeacherOperationCompleted);
            }
            this.InvokeAsync("IsLoginTeacher", new object[] {
                        username,
                        password}, this.IsLoginTeacherOperationCompleted, userState);
        }
        
        private void OnIsLoginTeacherOperationCompleted(object arg) {
            if ((this.IsLoginTeacherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsLoginTeacherCompleted(this, new IsLoginTeacherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Login([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pass, out bool LoginResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LoginResultSpecified) {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        pass});
            LoginResult = ((bool)(results[0]));
            LoginResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string pass) {
            this.LoginAsync(username, pass, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string pass, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        pass}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/isValidUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void isValidUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string userName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool isValidUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool isValidUserResultSpecified) {
            object[] results = this.Invoke("isValidUser", new object[] {
                        userName,
                        password});
            isValidUserResult = ((bool)(results[0]));
            isValidUserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void isValidUserAsync(string userName, string password) {
            this.isValidUserAsync(userName, password, null);
        }
        
        /// <remarks/>
        public void isValidUserAsync(string userName, string password, object userState) {
            if ((this.isValidUserOperationCompleted == null)) {
                this.isValidUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisValidUserOperationCompleted);
            }
            this.InvokeAsync("isValidUser", new object[] {
                        userName,
                        password}, this.isValidUserOperationCompleted, userState);
        }
        
        private void OnisValidUserOperationCompleted(object arg) {
            if ((this.isValidUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isValidUserCompleted(this, new isValidUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/IsTeacherAlreadyExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IsTeacherAlreadyExists([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool IsTeacherAlreadyExistsResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool IsTeacherAlreadyExistsResultSpecified) {
            object[] results = this.Invoke("IsTeacherAlreadyExists", new object[] {
                        username,
                        password});
            IsTeacherAlreadyExistsResult = ((bool)(results[0]));
            IsTeacherAlreadyExistsResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void IsTeacherAlreadyExistsAsync(string username, string password) {
            this.IsTeacherAlreadyExistsAsync(username, password, null);
        }
        
        /// <remarks/>
        public void IsTeacherAlreadyExistsAsync(string username, string password, object userState) {
            if ((this.IsTeacherAlreadyExistsOperationCompleted == null)) {
                this.IsTeacherAlreadyExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsTeacherAlreadyExistsOperationCompleted);
            }
            this.InvokeAsync("IsTeacherAlreadyExists", new object[] {
                        username,
                        password}, this.IsTeacherAlreadyExistsOperationCompleted, userState);
        }
        
        private void OnIsTeacherAlreadyExistsOperationCompleted(object arg) {
            if ((this.IsTeacherAlreadyExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsTeacherAlreadyExistsCompleted(this, new IsTeacherAlreadyExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Grade_Uploading_and_viewing_Criteria")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void IsAlreadyExistCompletedEventHandler(object sender, IsAlreadyExistCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsAlreadyExistCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsAlreadyExistCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool IsAlreadyExistResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool IsAlreadyExistResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterStdCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterTeacherCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void IsLoginTeacherCompletedEventHandler(object sender, IsLoginTeacherCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsLoginTeacherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsLoginTeacherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool IsLoginTeacherResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool IsLoginTeacherResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool LoginResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool LoginResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void isValidUserCompletedEventHandler(object sender, isValidUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isValidUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isValidUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool isValidUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool isValidUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void IsTeacherAlreadyExistsCompletedEventHandler(object sender, IsTeacherAlreadyExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsTeacherAlreadyExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsTeacherAlreadyExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool IsTeacherAlreadyExistsResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool IsTeacherAlreadyExistsResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace LB.LBWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LBWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class LBWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback RunProcedureOperationCompleted;
        
        private System.Threading.SendOrPostCallback RunViewOperationCompleted;
        
        private System.Threading.SendOrPostCallback RunDirectSQLOperationCompleted;
        
        private System.Threading.SendOrPostCallback User_InsertOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LBWebService() {
            this.Url = global::LB.Properties.Settings.Default.LB_Base_LBWebService_LBWebService;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event RunProcedureCompletedEventHandler RunProcedureCompleted;
        
        /// <remarks/>
        public event RunViewCompletedEventHandler RunViewCompleted;
        
        /// <remarks/>
        public event RunDirectSQLCompletedEventHandler RunDirectSQLCompleted;
        
        /// <remarks/>
        public event User_InsertCompletedEventHandler User_InsertCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RunProcedure", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet RunProcedure(int ProcedureType, string strLoginName, System.Data.DataTable dtParmValue, out System.Data.DataTable dtOut, out string ErrorMsg, out bool bolIsError) {
            object[] results = this.Invoke("RunProcedure", new object[] {
                        ProcedureType,
                        strLoginName,
                        dtParmValue});
            dtOut = ((System.Data.DataTable)(results[1]));
            ErrorMsg = ((string)(results[2]));
            bolIsError = ((bool)(results[3]));
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void RunProcedureAsync(int ProcedureType, string strLoginName, System.Data.DataTable dtParmValue) {
            this.RunProcedureAsync(ProcedureType, strLoginName, dtParmValue, null);
        }
        
        /// <remarks/>
        public void RunProcedureAsync(int ProcedureType, string strLoginName, System.Data.DataTable dtParmValue, object userState) {
            if ((this.RunProcedureOperationCompleted == null)) {
                this.RunProcedureOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunProcedureOperationCompleted);
            }
            this.InvokeAsync("RunProcedure", new object[] {
                        ProcedureType,
                        strLoginName,
                        dtParmValue}, this.RunProcedureOperationCompleted, userState);
        }
        
        private void OnRunProcedureOperationCompleted(object arg) {
            if ((this.RunProcedureCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RunProcedureCompleted(this, new RunProcedureCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RunView", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable RunView(int iViewType, string strLoginName, string strFieldNames, string strWhere, string strOrderBy, out string ErrorMsg, out bool bolIsError) {
            object[] results = this.Invoke("RunView", new object[] {
                        iViewType,
                        strLoginName,
                        strFieldNames,
                        strWhere,
                        strOrderBy});
            ErrorMsg = ((string)(results[1]));
            bolIsError = ((bool)(results[2]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void RunViewAsync(int iViewType, string strLoginName, string strFieldNames, string strWhere, string strOrderBy) {
            this.RunViewAsync(iViewType, strLoginName, strFieldNames, strWhere, strOrderBy, null);
        }
        
        /// <remarks/>
        public void RunViewAsync(int iViewType, string strLoginName, string strFieldNames, string strWhere, string strOrderBy, object userState) {
            if ((this.RunViewOperationCompleted == null)) {
                this.RunViewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunViewOperationCompleted);
            }
            this.InvokeAsync("RunView", new object[] {
                        iViewType,
                        strLoginName,
                        strFieldNames,
                        strWhere,
                        strOrderBy}, this.RunViewOperationCompleted, userState);
        }
        
        private void OnRunViewOperationCompleted(object arg) {
            if ((this.RunViewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RunViewCompleted(this, new RunViewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RunDirectSQL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable RunDirectSQL(string strLoginName, string strSQL, out string ErrorMsg, out bool bolIsError) {
            object[] results = this.Invoke("RunDirectSQL", new object[] {
                        strLoginName,
                        strSQL});
            ErrorMsg = ((string)(results[1]));
            bolIsError = ((bool)(results[2]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void RunDirectSQLAsync(string strLoginName, string strSQL) {
            this.RunDirectSQLAsync(strLoginName, strSQL, null);
        }
        
        /// <remarks/>
        public void RunDirectSQLAsync(string strLoginName, string strSQL, object userState) {
            if ((this.RunDirectSQLOperationCompleted == null)) {
                this.RunDirectSQLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunDirectSQLOperationCompleted);
            }
            this.InvokeAsync("RunDirectSQL", new object[] {
                        strLoginName,
                        strSQL}, this.RunDirectSQLOperationCompleted, userState);
        }
        
        private void OnRunDirectSQLOperationCompleted(object arg) {
            if ((this.RunDirectSQLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RunDirectSQLCompleted(this, new RunDirectSQLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/User_Insert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void User_Insert(string strAccount, string strPassword, string strName) {
            this.Invoke("User_Insert", new object[] {
                        strAccount,
                        strPassword,
                        strName});
        }
        
        /// <remarks/>
        public void User_InsertAsync(string strAccount, string strPassword, string strName) {
            this.User_InsertAsync(strAccount, strPassword, strName, null);
        }
        
        /// <remarks/>
        public void User_InsertAsync(string strAccount, string strPassword, string strName, object userState) {
            if ((this.User_InsertOperationCompleted == null)) {
                this.User_InsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUser_InsertOperationCompleted);
            }
            this.InvokeAsync("User_Insert", new object[] {
                        strAccount,
                        strPassword,
                        strName}, this.User_InsertOperationCompleted, userState);
        }
        
        private void OnUser_InsertOperationCompleted(object arg) {
            if ((this.User_InsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.User_InsertCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void RunProcedureCompletedEventHandler(object sender, RunProcedureCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RunProcedureCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RunProcedureCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public System.Data.DataTable dtOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string ErrorMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public bool bolIsError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void RunViewCompletedEventHandler(object sender, RunViewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RunViewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RunViewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string ErrorMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool bolIsError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void RunDirectSQLCompletedEventHandler(object sender, RunDirectSQLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RunDirectSQLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RunDirectSQLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string ErrorMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool bolIsError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void User_InsertCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
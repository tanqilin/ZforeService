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

namespace ZforeFromwork.UploadWebservice {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UploadWebserviceSoap", Namespace="http://tempuri.org/")]
    public partial class UploadWebservice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UpHumanInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpAttendInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback InMyHeartOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UploadWebservice() {
            this.Url = global::ZforeFromwork.Properties.Settings.Default.ZforeFromwork_UploadWebservice_UploadWebservice;
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
        public event UpHumanInfoCompletedEventHandler UpHumanInfoCompleted;
        
        /// <remarks/>
        public event UpAttendInfoCompletedEventHandler UpAttendInfoCompleted;
        
        /// <remarks/>
        public event InMyHeartCompletedEventHandler InMyHeartCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpHumanInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpHumanInfo(string humanXml) {
            object[] results = this.Invoke("UpHumanInfo", new object[] {
                        humanXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpHumanInfoAsync(string humanXml) {
            this.UpHumanInfoAsync(humanXml, null);
        }
        
        /// <remarks/>
        public void UpHumanInfoAsync(string humanXml, object userState) {
            if ((this.UpHumanInfoOperationCompleted == null)) {
                this.UpHumanInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpHumanInfoOperationCompleted);
            }
            this.InvokeAsync("UpHumanInfo", new object[] {
                        humanXml}, this.UpHumanInfoOperationCompleted, userState);
        }
        
        private void OnUpHumanInfoOperationCompleted(object arg) {
            if ((this.UpHumanInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpHumanInfoCompleted(this, new UpHumanInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpAttendInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpAttendInfo() {
            this.Invoke("UpAttendInfo", new object[0]);
        }
        
        /// <remarks/>
        public void UpAttendInfoAsync() {
            this.UpAttendInfoAsync(null);
        }
        
        /// <remarks/>
        public void UpAttendInfoAsync(object userState) {
            if ((this.UpAttendInfoOperationCompleted == null)) {
                this.UpAttendInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpAttendInfoOperationCompleted);
            }
            this.InvokeAsync("UpAttendInfo", new object[0], this.UpAttendInfoOperationCompleted, userState);
        }
        
        private void OnUpAttendInfoOperationCompleted(object arg) {
            if ((this.UpAttendInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpAttendInfoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InMyHeart", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InMyHeart(string heartXml) {
            this.Invoke("InMyHeart", new object[] {
                        heartXml});
        }
        
        /// <remarks/>
        public void InMyHeartAsync(string heartXml) {
            this.InMyHeartAsync(heartXml, null);
        }
        
        /// <remarks/>
        public void InMyHeartAsync(string heartXml, object userState) {
            if ((this.InMyHeartOperationCompleted == null)) {
                this.InMyHeartOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInMyHeartOperationCompleted);
            }
            this.InvokeAsync("InMyHeart", new object[] {
                        heartXml}, this.InMyHeartOperationCompleted, userState);
        }
        
        private void OnInMyHeartOperationCompleted(object arg) {
            if ((this.InMyHeartCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InMyHeartCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void UpHumanInfoCompletedEventHandler(object sender, UpHumanInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpHumanInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpHumanInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void UpAttendInfoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void InMyHeartCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
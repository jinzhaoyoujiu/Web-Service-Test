﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hahhah/", ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: 命名空间 http://hahhah/ 的元素名称 testStr 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://hahhah/RevertString", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.RevertStringResponse RevertString(WindowsFormsApp1.ServiceReference1.RevertStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://hahhah/RevertString", ReplyAction="*")]
        System.IAsyncResult BeginRevertString(WindowsFormsApp1.ServiceReference1.RevertStringRequest request, System.AsyncCallback callback, object asyncState);
        
        WindowsFormsApp1.ServiceReference1.RevertStringResponse EndRevertString(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevertStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevertString", Namespace="http://hahhah/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.RevertStringRequestBody Body;
        
        public RevertStringRequest() {
        }
        
        public RevertStringRequest(WindowsFormsApp1.ServiceReference1.RevertStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://hahhah/")]
    public partial class RevertStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string testStr;
        
        public RevertStringRequestBody() {
        }
        
        public RevertStringRequestBody(string testStr) {
            this.testStr = testStr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevertStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevertStringResponse", Namespace="http://hahhah/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.RevertStringResponseBody Body;
        
        public RevertStringResponse() {
        }
        
        public RevertStringResponse(WindowsFormsApp1.ServiceReference1.RevertStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://hahhah/")]
    public partial class RevertStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RevertStringResult;
        
        public RevertStringResponseBody() {
        }
        
        public RevertStringResponseBody(string RevertStringResult) {
            this.RevertStringResult = RevertStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RevertStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public RevertStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
        private BeginOperationDelegate onBeginRevertStringDelegate;
        
        private EndOperationDelegate onEndRevertStringDelegate;
        
        private System.Threading.SendOrPostCallback onRevertStringCompletedDelegate;
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<RevertStringCompletedEventArgs> RevertStringCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.RevertStringResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.RevertString(WindowsFormsApp1.ServiceReference1.RevertStringRequest request) {
            return base.Channel.RevertString(request);
        }
        
        public string RevertString(string testStr) {
            WindowsFormsApp1.ServiceReference1.RevertStringRequest inValue = new WindowsFormsApp1.ServiceReference1.RevertStringRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.RevertStringRequestBody();
            inValue.Body.testStr = testStr;
            WindowsFormsApp1.ServiceReference1.RevertStringResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).RevertString(inValue);
            return retVal.Body.RevertStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsFormsApp1.ServiceReference1.WebService1Soap.BeginRevertString(WindowsFormsApp1.ServiceReference1.RevertStringRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRevertString(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginRevertString(string testStr, System.AsyncCallback callback, object asyncState) {
            WindowsFormsApp1.ServiceReference1.RevertStringRequest inValue = new WindowsFormsApp1.ServiceReference1.RevertStringRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.RevertStringRequestBody();
            inValue.Body.testStr = testStr;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).BeginRevertString(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.RevertStringResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.EndRevertString(System.IAsyncResult result) {
            return base.Channel.EndRevertString(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndRevertString(System.IAsyncResult result) {
            WindowsFormsApp1.ServiceReference1.RevertStringResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).EndRevertString(result);
            return retVal.Body.RevertStringResult;
        }
        
        private System.IAsyncResult OnBeginRevertString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string testStr = ((string)(inValues[0]));
            return this.BeginRevertString(testStr, callback, asyncState);
        }
        
        private object[] OnEndRevertString(System.IAsyncResult result) {
            string retVal = this.EndRevertString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnRevertStringCompleted(object state) {
            if ((this.RevertStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RevertStringCompleted(this, new RevertStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RevertStringAsync(string testStr) {
            this.RevertStringAsync(testStr, null);
        }
        
        public void RevertStringAsync(string testStr, object userState) {
            if ((this.onBeginRevertStringDelegate == null)) {
                this.onBeginRevertStringDelegate = new BeginOperationDelegate(this.OnBeginRevertString);
            }
            if ((this.onEndRevertStringDelegate == null)) {
                this.onEndRevertStringDelegate = new EndOperationDelegate(this.OnEndRevertString);
            }
            if ((this.onRevertStringCompletedDelegate == null)) {
                this.onRevertStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRevertStringCompleted);
            }
            base.InvokeAsync(this.onBeginRevertStringDelegate, new object[] {
                        testStr}, this.onEndRevertStringDelegate, this.onRevertStringCompletedDelegate, userState);
        }
    }
}

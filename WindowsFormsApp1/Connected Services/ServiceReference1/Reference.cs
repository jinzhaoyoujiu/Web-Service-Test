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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hahhah/RevertString", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.RevertStringResponse> RevertStringAsync(WindowsFormsApp1.ServiceReference1.RevertStringRequest request);
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
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
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
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.RevertStringResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.RevertStringAsync(WindowsFormsApp1.ServiceReference1.RevertStringRequest request) {
            return base.Channel.RevertStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.RevertStringResponse> RevertStringAsync(string testStr) {
            WindowsFormsApp1.ServiceReference1.RevertStringRequest inValue = new WindowsFormsApp1.ServiceReference1.RevertStringRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.RevertStringRequestBody();
            inValue.Body.testStr = testStr;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).RevertStringAsync(inValue);
        }
    }
}
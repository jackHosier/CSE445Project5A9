//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItPage.Top10ContentWordsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Top10ContentWordsService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top10ContentWords", ReplyAction="http://tempuri.org/IService1/Top10ContentWordsResponse")]
        string[] Top10ContentWords(string textFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top10ContentWords", ReplyAction="http://tempuri.org/IService1/Top10ContentWordsResponse")]
        System.Threading.Tasks.Task<string[]> Top10ContentWordsAsync(string textFile);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryItPage.Top10ContentWordsService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryItPage.Top10ContentWordsService.IService1>, TryItPage.Top10ContentWordsService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] Top10ContentWords(string textFile) {
            return base.Channel.Top10ContentWords(textFile);
        }
        
        public System.Threading.Tasks.Task<string[]> Top10ContentWordsAsync(string textFile) {
            return base.Channel.Top10ContentWordsAsync(textFile);
        }
    }
}

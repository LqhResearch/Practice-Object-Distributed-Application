﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecToBin", ReplyAction="http://tempuri.org/IService/DecToBinResponse")]
        string DecToBin(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecToBin", ReplyAction="http://tempuri.org/IService/DecToBinResponse")]
        System.Threading.Tasks.Task<string> DecToBinAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Sum1ToN", ReplyAction="http://tempuri.org/IService/Sum1ToNResponse")]
        double Sum1ToN(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Sum1ToN", ReplyAction="http://tempuri.org/IService/Sum1ToNResponse")]
        System.Threading.Tasks.Task<double> Sum1ToNAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Factorial", ReplyAction="http://tempuri.org/IService/FactorialResponse")]
        int Factorial(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Factorial", ReplyAction="http://tempuri.org/IService/FactorialResponse")]
        System.Threading.Tasks.Task<int> FactorialAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PrintPrimeAToB", ReplyAction="http://tempuri.org/IService/PrintPrimeAToBResponse")]
        string PrintPrimeAToB(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PrintPrimeAToB", ReplyAction="http://tempuri.org/IService/PrintPrimeAToBResponse")]
        System.Threading.Tasks.Task<string> PrintPrimeAToBAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WebForm.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WebForm.Service.IService>, WebForm.Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DecToBin(int n) {
            return base.Channel.DecToBin(n);
        }
        
        public System.Threading.Tasks.Task<string> DecToBinAsync(int n) {
            return base.Channel.DecToBinAsync(n);
        }
        
        public double Sum1ToN(int n) {
            return base.Channel.Sum1ToN(n);
        }
        
        public System.Threading.Tasks.Task<double> Sum1ToNAsync(int n) {
            return base.Channel.Sum1ToNAsync(n);
        }
        
        public int Factorial(int n) {
            return base.Channel.Factorial(n);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int n) {
            return base.Channel.FactorialAsync(n);
        }
        
        public string PrintPrimeAToB(int a, int b) {
            return base.Channel.PrintPrimeAToB(a, b);
        }
        
        public System.Threading.Tasks.Task<string> PrintPrimeAToBAsync(int a, int b) {
            return base.Channel.PrintPrimeAToBAsync(a, b);
        }
    }
}
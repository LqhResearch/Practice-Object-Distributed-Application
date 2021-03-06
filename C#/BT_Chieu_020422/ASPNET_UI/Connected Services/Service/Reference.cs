//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNET_UI.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SingleEquation", ReplyAction="http://tempuri.org/IService/SingleEquationResponse")]
        string SingleEquation(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SingleEquation", ReplyAction="http://tempuri.org/IService/SingleEquationResponse")]
        System.Threading.Tasks.Task<string> SingleEquationAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrime", ReplyAction="http://tempuri.org/IService/IsPrimeResponse")]
        bool IsPrime(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrime", ReplyAction="http://tempuri.org/IService/IsPrimeResponse")]
        System.Threading.Tasks.Task<bool> IsPrimeAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/QuadraticEquation", ReplyAction="http://tempuri.org/IService/QuadraticEquationResponse")]
        string QuadraticEquation(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/QuadraticEquation", ReplyAction="http://tempuri.org/IService/QuadraticEquationResponse")]
        System.Threading.Tasks.Task<string> QuadraticEquationAsync(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Factorial", ReplyAction="http://tempuri.org/IService/FactorialResponse")]
        int Factorial(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Factorial", ReplyAction="http://tempuri.org/IService/FactorialResponse")]
        System.Threading.Tasks.Task<int> FactorialAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckOddEvenNumber", ReplyAction="http://tempuri.org/IService/CheckOddEvenNumberResponse")]
        string CheckOddEvenNumber(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckOddEvenNumber", ReplyAction="http://tempuri.org/IService/CheckOddEvenNumberResponse")]
        System.Threading.Tasks.Task<string> CheckOddEvenNumberAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsTriangle", ReplyAction="http://tempuri.org/IService/IsTriangleResponse")]
        bool IsTriangle(double a, double b, double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsTriangle", ReplyAction="http://tempuri.org/IService/IsTriangleResponse")]
        System.Threading.Tasks.Task<bool> IsTriangleAsync(double a, double b, double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TriangleName", ReplyAction="http://tempuri.org/IService/TriangleNameResponse")]
        string TriangleName(double a, double b, double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TriangleName", ReplyAction="http://tempuri.org/IService/TriangleNameResponse")]
        System.Threading.Tasks.Task<string> TriangleNameAsync(double a, double b, double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AverageTriangle", ReplyAction="http://tempuri.org/IService/AverageTriangleResponse")]
        double AverageTriangle(double a, double b, double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AverageTriangle", ReplyAction="http://tempuri.org/IService/AverageTriangleResponse")]
        System.Threading.Tasks.Task<double> AverageTriangleAsync(double a, double b, double c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ASPNET_UI.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ASPNET_UI.Service.IService>, ASPNET_UI.Service.IService {
        
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
        
        public string SingleEquation(int a, int b) {
            return base.Channel.SingleEquation(a, b);
        }
        
        public System.Threading.Tasks.Task<string> SingleEquationAsync(int a, int b) {
            return base.Channel.SingleEquationAsync(a, b);
        }
        
        public bool IsPrime(int n) {
            return base.Channel.IsPrime(n);
        }
        
        public System.Threading.Tasks.Task<bool> IsPrimeAsync(int n) {
            return base.Channel.IsPrimeAsync(n);
        }
        
        public string QuadraticEquation(int a, int b, int c) {
            return base.Channel.QuadraticEquation(a, b, c);
        }
        
        public System.Threading.Tasks.Task<string> QuadraticEquationAsync(int a, int b, int c) {
            return base.Channel.QuadraticEquationAsync(a, b, c);
        }
        
        public int Factorial(int n) {
            return base.Channel.Factorial(n);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int n) {
            return base.Channel.FactorialAsync(n);
        }
        
        public string CheckOddEvenNumber(int n) {
            return base.Channel.CheckOddEvenNumber(n);
        }
        
        public System.Threading.Tasks.Task<string> CheckOddEvenNumberAsync(int n) {
            return base.Channel.CheckOddEvenNumberAsync(n);
        }
        
        public bool IsTriangle(double a, double b, double c) {
            return base.Channel.IsTriangle(a, b, c);
        }
        
        public System.Threading.Tasks.Task<bool> IsTriangleAsync(double a, double b, double c) {
            return base.Channel.IsTriangleAsync(a, b, c);
        }
        
        public string TriangleName(double a, double b, double c) {
            return base.Channel.TriangleName(a, b, c);
        }
        
        public System.Threading.Tasks.Task<string> TriangleNameAsync(double a, double b, double c) {
            return base.Channel.TriangleNameAsync(a, b, c);
        }
        
        public double AverageTriangle(double a, double b, double c) {
            return base.Channel.AverageTriangle(a, b, c);
        }
        
        public System.Threading.Tasks.Task<double> AverageTriangleAsync(double a, double b, double c) {
            return base.Channel.AverageTriangleAsync(a, b, c);
        }
    }
}

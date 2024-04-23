﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InputRequest", Namespace="http://schemas.datacontract.org/2004/07/SOAPWebApiAssignment.Model.Request")]
    public partial class InputRequest : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private double Operand1Field;
        
        private double Operand2Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Operand1
        {
            get
            {
                return this.Operand1Field;
            }
            set
            {
                if ((this.Operand1Field.Equals(value) != true))
                {
                    this.Operand1Field = value;
                    this.RaisePropertyChanged("Operand1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Operand2
        {
            get
            {
                return this.Operand2Field;
            }
            set
            {
                if ((this.Operand2Field.Equals(value) != true))
                {
                    this.Operand2Field = value;
                    this.RaisePropertyChanged("Operand2");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OutputResponse", Namespace="http://schemas.datacontract.org/2004/07/SOAPWebApiAssignment.Model.Response")]
    public partial class OutputResponse : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string ErrorMessageField;
        
        private bool IsSuccessfulField;
        
        private double OutputField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true))
                {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccessful
        {
            get
            {
                return this.IsSuccessfulField;
            }
            set
            {
                if ((this.IsSuccessfulField.Equals(value) != true))
                {
                    this.IsSuccessfulField = value;
                    this.RaisePropertyChanged("IsSuccessful");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Output
        {
            get
            {
                return this.OutputField;
            }
            set
            {
                if ((this.OutputField.Equals(value) != true))
                {
                    this.OutputField = value;
                    this.RaisePropertyChanged("Output");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOperations")]
    public interface IOperations
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Add", ReplyAction="http://tempuri.org/IOperations/AddResponse")]
        ServiceReference1.OutputResponse Add(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Add", ReplyAction="http://tempuri.org/IOperations/AddResponse")]
        System.Threading.Tasks.Task<ServiceReference1.OutputResponse> AddAsync(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Subtract", ReplyAction="http://tempuri.org/IOperations/SubtractResponse")]
        ServiceReference1.OutputResponse Subtract(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Subtract", ReplyAction="http://tempuri.org/IOperations/SubtractResponse")]
        System.Threading.Tasks.Task<ServiceReference1.OutputResponse> SubtractAsync(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Multiply", ReplyAction="http://tempuri.org/IOperations/MultiplyResponse")]
        ServiceReference1.OutputResponse Multiply(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Multiply", ReplyAction="http://tempuri.org/IOperations/MultiplyResponse")]
        System.Threading.Tasks.Task<ServiceReference1.OutputResponse> MultiplyAsync(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Divide", ReplyAction="http://tempuri.org/IOperations/DivideResponse")]
        ServiceReference1.OutputResponse Divide(ServiceReference1.InputRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperations/Divide", ReplyAction="http://tempuri.org/IOperations/DivideResponse")]
        System.Threading.Tasks.Task<ServiceReference1.OutputResponse> DivideAsync(ServiceReference1.InputRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IOperationsChannel : ServiceReference1.IOperations, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class OperationsClient : System.ServiceModel.ClientBase<ServiceReference1.IOperations>, ServiceReference1.IOperations
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OperationsClient() : 
                base(OperationsClient.GetDefaultBinding(), OperationsClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IOperations.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationsClient(EndpointConfiguration endpointConfiguration) : 
                base(OperationsClient.GetBindingForEndpoint(endpointConfiguration), OperationsClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OperationsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OperationsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.OutputResponse Add(ServiceReference1.InputRequest request)
        {
            return base.Channel.Add(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.OutputResponse> AddAsync(ServiceReference1.InputRequest request)
        {
            return base.Channel.AddAsync(request);
        }
        
        public ServiceReference1.OutputResponse Subtract(ServiceReference1.InputRequest request)
        {
            return base.Channel.Subtract(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.OutputResponse> SubtractAsync(ServiceReference1.InputRequest request)
        {
            return base.Channel.SubtractAsync(request);
        }
        
        public ServiceReference1.OutputResponse Multiply(ServiceReference1.InputRequest request)
        {
            return base.Channel.Multiply(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.OutputResponse> MultiplyAsync(ServiceReference1.InputRequest request)
        {
            return base.Channel.MultiplyAsync(request);
        }
        
        public ServiceReference1.OutputResponse Divide(ServiceReference1.InputRequest request)
        {
            return base.Channel.Divide(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.OutputResponse> DivideAsync(ServiceReference1.InputRequest request)
        {
            return base.Channel.DivideAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOperations))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOperations))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7273/Operations.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return OperationsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IOperations);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return OperationsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IOperations);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IOperations,
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.WcfServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFServer.WCF")]
    [System.SerializableAttribute()]
    public partial class DataResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Response {
            get {
                return this.ResponseField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseField, value) != true)) {
                    this.ResponseField = value;
                    this.RaisePropertyChanged("Response");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceReference.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/Ping", ReplyAction="http://tempuri.org/IDataService/PingResponse")]
        string Ping(string sMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/Ping", ReplyAction="http://tempuri.org/IDataService/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync(string sMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/Ping2", ReplyAction="http://tempuri.org/IDataService/Ping2Response")]
        WCFClient.WcfServiceReference.DataResponse Ping2(string sMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/Ping2", ReplyAction="http://tempuri.org/IDataService/Ping2Response")]
        System.Threading.Tasks.Task<WCFClient.WcfServiceReference.DataResponse> Ping2Async(string sMessage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : WCFClient.WcfServiceReference.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<WCFClient.WcfServiceReference.IDataService>, WCFClient.WcfServiceReference.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Ping(string sMessage) {
            return base.Channel.Ping(sMessage);
        }
        
        public System.Threading.Tasks.Task<string> PingAsync(string sMessage) {
            return base.Channel.PingAsync(sMessage);
        }
        
        public WCFClient.WcfServiceReference.DataResponse Ping2(string sMessage) {
            return base.Channel.Ping2(sMessage);
        }
        
        public System.Threading.Tasks.Task<WCFClient.WcfServiceReference.DataResponse> Ping2Async(string sMessage) {
            return base.Channel.Ping2Async(sMessage);
        }
    }
}
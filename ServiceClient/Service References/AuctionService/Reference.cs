﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceClient.AuctionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auction", Namespace="http://schemas.datacontract.org/2004/07/WcfPr%C3%B8veEksamen")]
    [System.SerializableAttribute()]
    public partial class Auction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServiceClient.AuctionService.Bid BidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingField;
        
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
        public ServiceClient.AuctionService.Bid Bid {
            get {
                return this.BidField;
            }
            set {
                if ((object.ReferenceEquals(this.BidField, value) != true)) {
                    this.BidField = value;
                    this.RaisePropertyChanged("Bid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bid", Namespace="http://schemas.datacontract.org/2004/07/WcfPr%C3%B8veEksamen")]
    [System.SerializableAttribute()]
    public partial class Bid : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuctionService.IAuctionService")]
    public interface IAuctionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctions", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionsResponse")]
        ServiceClient.AuctionService.Auction[] GetAuctions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctions", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionsResponse")]
        System.Threading.Tasks.Task<ServiceClient.AuctionService.Auction[]> GetAuctionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuction", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionResponse")]
        ServiceClient.AuctionService.Auction GetAuction(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuction", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionResponse")]
        System.Threading.Tasks.Task<ServiceClient.AuctionService.Auction> GetAuctionAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/Bid", ReplyAction="http://tempuri.org/IAuctionService/BidResponse")]
        string Bid(string ID, int price, string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/Bid", ReplyAction="http://tempuri.org/IAuctionService/BidResponse")]
        System.Threading.Tasks.Task<string> BidAsync(string ID, int price, string name, string phone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuctionServiceChannel : ServiceClient.AuctionService.IAuctionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuctionServiceClient : System.ServiceModel.ClientBase<ServiceClient.AuctionService.IAuctionService>, ServiceClient.AuctionService.IAuctionService {
        
        public AuctionServiceClient() {
        }
        
        public AuctionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceClient.AuctionService.Auction[] GetAuctions() {
            return base.Channel.GetAuctions();
        }
        
        public System.Threading.Tasks.Task<ServiceClient.AuctionService.Auction[]> GetAuctionsAsync() {
            return base.Channel.GetAuctionsAsync();
        }
        
        public ServiceClient.AuctionService.Auction GetAuction(string ID) {
            return base.Channel.GetAuction(ID);
        }
        
        public System.Threading.Tasks.Task<ServiceClient.AuctionService.Auction> GetAuctionAsync(string ID) {
            return base.Channel.GetAuctionAsync(ID);
        }
        
        public string Bid(string ID, int price, string name, string phone) {
            return base.Channel.Bid(ID, price, name, phone);
        }
        
        public System.Threading.Tasks.Task<string> BidAsync(string ID, int price, string name, string phone) {
            return base.Channel.BidAsync(ID, price, name, phone);
        }
    }
}

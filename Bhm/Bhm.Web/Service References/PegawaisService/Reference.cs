﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bhm.Web.PegawaisService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PegawaiData", Namespace="http://schemas.datacontract.org/2004/07/Pegawais")]
    [System.SerializableAttribute()]
    public partial class PegawaiData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPgwField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string instansiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaPgwField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordPgwField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernamePgwField;
        
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
        public int idPgw {
            get {
                return this.idPgwField;
            }
            set {
                if ((this.idPgwField.Equals(value) != true)) {
                    this.idPgwField = value;
                    this.RaisePropertyChanged("idPgw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string instansi {
            get {
                return this.instansiField;
            }
            set {
                if ((object.ReferenceEquals(this.instansiField, value) != true)) {
                    this.instansiField = value;
                    this.RaisePropertyChanged("instansi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAdmin {
            get {
                return this.isAdminField;
            }
            set {
                if ((this.isAdminField.Equals(value) != true)) {
                    this.isAdminField = value;
                    this.RaisePropertyChanged("isAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaPgw {
            get {
                return this.namaPgwField;
            }
            set {
                if ((object.ReferenceEquals(this.namaPgwField, value) != true)) {
                    this.namaPgwField = value;
                    this.RaisePropertyChanged("namaPgw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string passwordPgw {
            get {
                return this.passwordPgwField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordPgwField, value) != true)) {
                    this.passwordPgwField = value;
                    this.RaisePropertyChanged("passwordPgw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usernamePgw {
            get {
                return this.usernamePgwField;
            }
            set {
                if ((object.ReferenceEquals(this.usernamePgwField, value) != true)) {
                    this.usernamePgwField = value;
                    this.RaisePropertyChanged("usernamePgw");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PegawaisService.IPegawaisService")]
    public interface IPegawaisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPegawaisService/ListPegawai", ReplyAction="http://tempuri.org/IPegawaisService/ListPegawaiResponse")]
        string[] ListPegawai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPegawaisService/GetPegawai", ReplyAction="http://tempuri.org/IPegawaisService/GetPegawaiResponse")]
        Bhm.Web.PegawaisService.PegawaiData GetPegawai(string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPegawaisService/CheckLogin", ReplyAction="http://tempuri.org/IPegawaisService/CheckLoginResponse")]
        Bhm.Web.PegawaisService.PegawaiData CheckLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPegawaisService/InsertPegawai", ReplyAction="http://tempuri.org/IPegawaisService/InsertPegawaiResponse")]
        void InsertPegawai(string nama, string instansi, string username, string password, bool isAdmin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPegawaisServiceChannel : Bhm.Web.PegawaisService.IPegawaisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PegawaisServiceClient : System.ServiceModel.ClientBase<Bhm.Web.PegawaisService.IPegawaisService>, Bhm.Web.PegawaisService.IPegawaisService {
        
        public PegawaisServiceClient() {
        }
        
        public PegawaisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PegawaisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PegawaisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PegawaisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListPegawai() {
            return base.Channel.ListPegawai();
        }
        
        public Bhm.Web.PegawaisService.PegawaiData GetPegawai(string nama) {
            return base.Channel.GetPegawai(nama);
        }
        
        public Bhm.Web.PegawaisService.PegawaiData CheckLogin(string username, string password) {
            return base.Channel.CheckLogin(username, password);
        }
        
        public void InsertPegawai(string nama, string instansi, string username, string password, bool isAdmin) {
            base.Channel.InsertPegawai(nama, instansi, username, password, isAdmin);
        }
    }
}

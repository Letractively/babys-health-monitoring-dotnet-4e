﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bhm.Web.BalitasService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BalitaData", Namespace="http://schemas.datacontract.org/2004/07/Balitas")]
    [System.SerializableAttribute()]
    public partial class BalitaData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alamatBalitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int anakKeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double bblField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idAyahField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBalitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idIbuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idImunisasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idVitaminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jnsKelaminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaBalitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double tblField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime tlBalitaField;
        
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
        public string alamatBalita {
            get {
                return this.alamatBalitaField;
            }
            set {
                if ((object.ReferenceEquals(this.alamatBalitaField, value) != true)) {
                    this.alamatBalitaField = value;
                    this.RaisePropertyChanged("alamatBalita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int anakKe {
            get {
                return this.anakKeField;
            }
            set {
                if ((this.anakKeField.Equals(value) != true)) {
                    this.anakKeField = value;
                    this.RaisePropertyChanged("anakKe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double bbl {
            get {
                return this.bblField;
            }
            set {
                if ((this.bblField.Equals(value) != true)) {
                    this.bblField = value;
                    this.RaisePropertyChanged("bbl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idAyah {
            get {
                return this.idAyahField;
            }
            set {
                if ((this.idAyahField.Equals(value) != true)) {
                    this.idAyahField = value;
                    this.RaisePropertyChanged("idAyah");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idBalita {
            get {
                return this.idBalitaField;
            }
            set {
                if ((this.idBalitaField.Equals(value) != true)) {
                    this.idBalitaField = value;
                    this.RaisePropertyChanged("idBalita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idIbu {
            get {
                return this.idIbuField;
            }
            set {
                if ((this.idIbuField.Equals(value) != true)) {
                    this.idIbuField = value;
                    this.RaisePropertyChanged("idIbu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idImunisasi {
            get {
                return this.idImunisasiField;
            }
            set {
                if ((this.idImunisasiField.Equals(value) != true)) {
                    this.idImunisasiField = value;
                    this.RaisePropertyChanged("idImunisasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idVitamin {
            get {
                return this.idVitaminField;
            }
            set {
                if ((this.idVitaminField.Equals(value) != true)) {
                    this.idVitaminField = value;
                    this.RaisePropertyChanged("idVitamin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jnsKelamin {
            get {
                return this.jnsKelaminField;
            }
            set {
                if ((object.ReferenceEquals(this.jnsKelaminField, value) != true)) {
                    this.jnsKelaminField = value;
                    this.RaisePropertyChanged("jnsKelamin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaBalita {
            get {
                return this.namaBalitaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaBalitaField, value) != true)) {
                    this.namaBalitaField = value;
                    this.RaisePropertyChanged("namaBalita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double tbl {
            get {
                return this.tblField;
            }
            set {
                if ((this.tblField.Equals(value) != true)) {
                    this.tblField = value;
                    this.RaisePropertyChanged("tbl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime tlBalita {
            get {
                return this.tlBalitaField;
            }
            set {
                if ((this.tlBalitaField.Equals(value) != true)) {
                    this.tlBalitaField = value;
                    this.RaisePropertyChanged("tlBalita");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BalitasService.IBalitasService")]
    public interface IBalitasService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalitasService/ListBalita", ReplyAction="http://tempuri.org/IBalitasService/ListBalitaResponse")]
        string[] ListBalita();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalitasService/GetBalita", ReplyAction="http://tempuri.org/IBalitasService/GetBalitaResponse")]
        Bhm.Web.BalitasService.BalitaData GetBalita(string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalitasService/InsertBalita", ReplyAction="http://tempuri.org/IBalitasService/InsertBalitaResponse")]
        void InsertBalita(int idAyah, int idIbu, string nama, System.DateTime tl, string alamat, int anak, string jk, double bbl, double tbl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalitasService/UpdateBalita", ReplyAction="http://tempuri.org/IBalitasService/UpdateBalitaResponse")]
        void UpdateBalita(int id, int idAyah, int idIbu, int idVit, int idImun, string nama, System.DateTime tl, string alamat, int anak, string jk, double bbl, double tbl);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBalitasServiceChannel : Bhm.Web.BalitasService.IBalitasService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BalitasServiceClient : System.ServiceModel.ClientBase<Bhm.Web.BalitasService.IBalitasService>, Bhm.Web.BalitasService.IBalitasService {
        
        public BalitasServiceClient() {
        }
        
        public BalitasServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BalitasServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalitasServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalitasServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListBalita() {
            return base.Channel.ListBalita();
        }
        
        public Bhm.Web.BalitasService.BalitaData GetBalita(string nama) {
            return base.Channel.GetBalita(nama);
        }
        
        public void InsertBalita(int idAyah, int idIbu, string nama, System.DateTime tl, string alamat, int anak, string jk, double bbl, double tbl) {
            base.Channel.InsertBalita(idAyah, idIbu, nama, tl, alamat, anak, jk, bbl, tbl);
        }
        
        public void UpdateBalita(int id, int idAyah, int idIbu, int idVit, int idImun, string nama, System.DateTime tl, string alamat, int anak, string jk, double bbl, double tbl) {
            base.Channel.UpdateBalita(id, idAyah, idIbu, idVit, idImun, nama, tl, alamat, anak, jk, bbl, tbl);
        }
    }
}

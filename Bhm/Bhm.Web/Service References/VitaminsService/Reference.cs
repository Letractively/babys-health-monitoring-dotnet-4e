﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bhm.Web.VitaminsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VitaminsService.IVitaminsService")]
    public interface IVitaminsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVitaminsService/InsertVitamin", ReplyAction="http://tempuri.org/IVitaminsService/InsertVitaminResponse")]
        void InsertVitamin(System.DateTime kapsulBiru, System.DateTime kapsulMerah1, System.DateTime kapsulMerah2, System.DateTime kapsulMerah3, System.DateTime kapsulMerah4);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVitaminsServiceChannel : Bhm.Web.VitaminsService.IVitaminsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VitaminsServiceClient : System.ServiceModel.ClientBase<Bhm.Web.VitaminsService.IVitaminsService>, Bhm.Web.VitaminsService.IVitaminsService {
        
        public VitaminsServiceClient() {
        }
        
        public VitaminsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VitaminsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VitaminsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VitaminsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertVitamin(System.DateTime kapsulBiru, System.DateTime kapsulMerah1, System.DateTime kapsulMerah2, System.DateTime kapsulMerah3, System.DateTime kapsulMerah4) {
            base.Channel.InsertVitamin(kapsulBiru, kapsulMerah1, kapsulMerah2, kapsulMerah3, kapsulMerah4);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWAFTcp.VelibService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibService.IItineraryService")]
    public interface IItineraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItineraryService/getItinerary", ReplyAction="http://tempuri.org/IItineraryService/getItineraryResponse")]
        string getItinerary(string origin, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItineraryService/getItinerary", ReplyAction="http://tempuri.org/IItineraryService/getItineraryResponse")]
        System.Threading.Tasks.Task<string> getItineraryAsync(string origin, string destination);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItineraryServiceChannel : ClientWAFTcp.VelibService.IItineraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItineraryServiceClient : System.ServiceModel.ClientBase<ClientWAFTcp.VelibService.IItineraryService>, ClientWAFTcp.VelibService.IItineraryService {
        
        public ItineraryServiceClient() {
        }
        
        public ItineraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItineraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItineraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItineraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getItinerary(string origin, string destination) {
            return base.Channel.getItinerary(origin, destination);
        }
        
        public System.Threading.Tasks.Task<string> getItineraryAsync(string origin, string destination) {
            return base.Channel.getItineraryAsync(origin, destination);
        }
    }
}

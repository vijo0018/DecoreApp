﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decore.ClientApp.EventServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventServiceReference.IEventService")]
    public interface IEventService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEvents", ReplyAction="http://tempuri.org/IEventService/GetEventsResponse")]
        Decore.Models.Event[] GetEvents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEvents", ReplyAction="http://tempuri.org/IEventService/GetEventsResponse")]
        System.Threading.Tasks.Task<Decore.Models.Event[]> GetEventsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventById", ReplyAction="http://tempuri.org/IEventService/GetEventByIdResponse")]
        Decore.Models.Event GetEventById(int eventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventById", ReplyAction="http://tempuri.org/IEventService/GetEventByIdResponse")]
        System.Threading.Tasks.Task<Decore.Models.Event> GetEventByIdAsync(int eventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/CreateEvent", ReplyAction="http://tempuri.org/IEventService/CreateEventResponse")]
        void CreateEvent(Decore.Models.Event eventObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/CreateEvent", ReplyAction="http://tempuri.org/IEventService/CreateEventResponse")]
        System.Threading.Tasks.Task CreateEventAsync(Decore.Models.Event eventObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/DeleteEventById", ReplyAction="http://tempuri.org/IEventService/DeleteEventByIdResponse")]
        void DeleteEventById(int eventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/DeleteEventById", ReplyAction="http://tempuri.org/IEventService/DeleteEventByIdResponse")]
        System.Threading.Tasks.Task DeleteEventByIdAsync(int eventId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventsBySectionId", ReplyAction="http://tempuri.org/IEventService/GetEventsBySectionIdResponse")]
        Decore.Models.Event[] GetEventsBySectionId(int sectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventsBySectionId", ReplyAction="http://tempuri.org/IEventService/GetEventsBySectionIdResponse")]
        System.Threading.Tasks.Task<Decore.Models.Event[]> GetEventsBySectionIdAsync(int sectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventTypes", ReplyAction="http://tempuri.org/IEventService/GetEventTypesResponse")]
        Decore.Models.EventType[] GetEventTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventService/GetEventTypes", ReplyAction="http://tempuri.org/IEventService/GetEventTypesResponse")]
        System.Threading.Tasks.Task<Decore.Models.EventType[]> GetEventTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventServiceChannel : Decore.ClientApp.EventServiceReference.IEventService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventServiceClient : System.ServiceModel.ClientBase<Decore.ClientApp.EventServiceReference.IEventService>, Decore.ClientApp.EventServiceReference.IEventService {
        
        public EventServiceClient() {
        }
        
        public EventServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Decore.Models.Event[] GetEvents() {
            return base.Channel.GetEvents();
        }
        
        public System.Threading.Tasks.Task<Decore.Models.Event[]> GetEventsAsync() {
            return base.Channel.GetEventsAsync();
        }
        
        public Decore.Models.Event GetEventById(int eventId) {
            return base.Channel.GetEventById(eventId);
        }
        
        public System.Threading.Tasks.Task<Decore.Models.Event> GetEventByIdAsync(int eventId) {
            return base.Channel.GetEventByIdAsync(eventId);
        }
        
        public void CreateEvent(Decore.Models.Event eventObject) {
            base.Channel.CreateEvent(eventObject);
        }
        
        public System.Threading.Tasks.Task CreateEventAsync(Decore.Models.Event eventObject) {
            return base.Channel.CreateEventAsync(eventObject);
        }
        
        public void DeleteEventById(int eventId) {
            base.Channel.DeleteEventById(eventId);
        }
        
        public System.Threading.Tasks.Task DeleteEventByIdAsync(int eventId) {
            return base.Channel.DeleteEventByIdAsync(eventId);
        }
        
        public Decore.Models.Event[] GetEventsBySectionId(int sectionId) {
            return base.Channel.GetEventsBySectionId(sectionId);
        }
        
        public System.Threading.Tasks.Task<Decore.Models.Event[]> GetEventsBySectionIdAsync(int sectionId) {
            return base.Channel.GetEventsBySectionIdAsync(sectionId);
        }
        
        public Decore.Models.EventType[] GetEventTypes() {
            return base.Channel.GetEventTypes();
        }
        
        public System.Threading.Tasks.Task<Decore.Models.EventType[]> GetEventTypesAsync() {
            return base.Channel.GetEventTypesAsync();
        }
    }
}

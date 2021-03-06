﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteControleClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRemoteService")]
    public interface IRemoteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/Block", ReplyAction="http://tempuri.org/IRemoteService/BlockResponse")]
        void Block();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/Block", ReplyAction="http://tempuri.org/IRemoteService/BlockResponse")]
        System.Threading.Tasks.Task BlockAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/GetScreen", ReplyAction="http://tempuri.org/IRemoteService/GetScreenResponse")]
        byte[] GetScreen();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/GetScreen", ReplyAction="http://tempuri.org/IRemoteService/GetScreenResponse")]
        System.Threading.Tasks.Task<byte[]> GetScreenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/UnBlock", ReplyAction="http://tempuri.org/IRemoteService/UnBlockResponse")]
        void UnBlock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/UnBlock", ReplyAction="http://tempuri.org/IRemoteService/UnBlockResponse")]
        System.Threading.Tasks.Task UnBlockAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/ShutDown", ReplyAction="http://tempuri.org/IRemoteService/ShutDownResponse")]
        void ShutDown();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/ShutDown", ReplyAction="http://tempuri.org/IRemoteService/ShutDownResponse")]
        System.Threading.Tasks.Task ShutDownAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/Reboot", ReplyAction="http://tempuri.org/IRemoteService/RebootResponse")]
        void Reboot();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/Reboot", ReplyAction="http://tempuri.org/IRemoteService/RebootResponse")]
        System.Threading.Tasks.Task RebootAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/CloseProcess", ReplyAction="http://tempuri.org/IRemoteService/CloseProcessResponse")]
        string CloseProcess();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/CloseProcess", ReplyAction="http://tempuri.org/IRemoteService/CloseProcessResponse")]
        System.Threading.Tasks.Task<string> CloseProcessAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/KillProc", ReplyAction="http://tempuri.org/IRemoteService/KillProcResponse")]
        void KillProc(string prc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/KillProc", ReplyAction="http://tempuri.org/IRemoteService/KillProcResponse")]
        System.Threading.Tasks.Task KillProcAsync(string prc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/DisplayMessage", ReplyAction="http://tempuri.org/IRemoteService/DisplayMessageResponse")]
        void DisplayMessage(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/DisplayMessage", ReplyAction="http://tempuri.org/IRemoteService/DisplayMessageResponse")]
        System.Threading.Tasks.Task DisplayMessageAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/KillProcesses", ReplyAction="http://tempuri.org/IRemoteService/KillProcessesResponse")]
        void KillProcesses(string[] prc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteService/KillProcesses", ReplyAction="http://tempuri.org/IRemoteService/KillProcessesResponse")]
        System.Threading.Tasks.Task KillProcessesAsync(string[] prc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRemoteServiceChannel : RemoteControleClient.ServiceReference1.IRemoteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RemoteServiceClient : System.ServiceModel.ClientBase<RemoteControleClient.ServiceReference1.IRemoteService>, RemoteControleClient.ServiceReference1.IRemoteService {
        
        public RemoteServiceClient() {
        }
        
        public RemoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RemoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Block() {
            base.Channel.Block();
        }
        
        public System.Threading.Tasks.Task BlockAsync() {
            return base.Channel.BlockAsync();
        }
        
        public byte[] GetScreen() {
            return base.Channel.GetScreen();
        }
        
        public System.Threading.Tasks.Task<byte[]> GetScreenAsync() {
            return base.Channel.GetScreenAsync();
        }
        
        public void UnBlock() {
            base.Channel.UnBlock();
        }
        
        public System.Threading.Tasks.Task UnBlockAsync() {
            return base.Channel.UnBlockAsync();
        }
        
        public void ShutDown() {
            base.Channel.ShutDown();
        }
        
        public System.Threading.Tasks.Task ShutDownAsync() {
            return base.Channel.ShutDownAsync();
        }
        
        public void Reboot() {
            base.Channel.Reboot();
        }
        
        public System.Threading.Tasks.Task RebootAsync() {
            return base.Channel.RebootAsync();
        }
        
        public string CloseProcess() {
            return base.Channel.CloseProcess();
        }
        
        public System.Threading.Tasks.Task<string> CloseProcessAsync() {
            return base.Channel.CloseProcessAsync();
        }
        
        public void KillProc(string prc) {
            base.Channel.KillProc(prc);
        }
        
        public System.Threading.Tasks.Task KillProcAsync(string prc) {
            return base.Channel.KillProcAsync(prc);
        }
        
        public void DisplayMessage(string msg) {
            base.Channel.DisplayMessage(msg);
        }
        
        public System.Threading.Tasks.Task DisplayMessageAsync(string msg) {
            return base.Channel.DisplayMessageAsync(msg);
        }
        
        public void KillProcesses(string[] prc) {
            base.Channel.KillProcesses(prc);
        }
        
        public System.Threading.Tasks.Task KillProcessesAsync(string[] prc) {
            return base.Channel.KillProcessesAsync(prc);
        }
    }
}

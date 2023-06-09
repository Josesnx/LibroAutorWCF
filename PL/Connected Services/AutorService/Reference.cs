﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.AutorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AutorService.IAutor")]
    public interface IAutor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Add", ReplyAction="http://tempuri.org/IAutor/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Autor))]
        ML.Result Add(ML.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Add", ReplyAction="http://tempuri.org/IAutor/AddResponse")]
        System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Update", ReplyAction="http://tempuri.org/IAutor/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Autor))]
        ML.Result Update(ML.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Update", ReplyAction="http://tempuri.org/IAutor/UpdateResponse")]
        System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Autor autor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Delete", ReplyAction="http://tempuri.org/IAutor/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Autor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        ML.Result Delete(int IdAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/Delete", ReplyAction="http://tempuri.org/IAutor/DeleteResponse")]
        System.Threading.Tasks.Task<ML.Result> DeleteAsync(int IdAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/GetAll", ReplyAction="http://tempuri.org/IAutor/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Autor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        ML.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/GetAll", ReplyAction="http://tempuri.org/IAutor/GetAllResponse")]
        System.Threading.Tasks.Task<ML.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/GetById", ReplyAction="http://tempuri.org/IAutor/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Autor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        ML.Result GetById(int IdAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutor/GetById", ReplyAction="http://tempuri.org/IAutor/GetByIdResponse")]
        System.Threading.Tasks.Task<ML.Result> GetByIdAsync(int IdAutor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAutorChannel : PL.AutorService.IAutor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AutorClient : System.ServiceModel.ClientBase<PL.AutorService.IAutor>, PL.AutorService.IAutor {
        
        public AutorClient() {
        }
        
        public AutorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AutorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ML.Result Add(ML.Autor autor) {
            return base.Channel.Add(autor);
        }
        
        public System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Autor autor) {
            return base.Channel.AddAsync(autor);
        }
        
        public ML.Result Update(ML.Autor autor) {
            return base.Channel.Update(autor);
        }
        
        public System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Autor autor) {
            return base.Channel.UpdateAsync(autor);
        }
        
        public ML.Result Delete(int IdAutor) {
            return base.Channel.Delete(IdAutor);
        }
        
        public System.Threading.Tasks.Task<ML.Result> DeleteAsync(int IdAutor) {
            return base.Channel.DeleteAsync(IdAutor);
        }
        
        public ML.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ML.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public ML.Result GetById(int IdAutor) {
            return base.Channel.GetById(IdAutor);
        }
        
        public System.Threading.Tasks.Task<ML.Result> GetByIdAsync(int IdAutor) {
            return base.Channel.GetByIdAsync(IdAutor);
        }
    }
}

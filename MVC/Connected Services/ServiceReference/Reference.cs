﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sala", Namespace="http://schemas.datacontract.org/2004/07/ServicoWCF")]
    [System.SerializableAttribute()]
    public partial class Sala : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ProjetorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SistemaOperacionalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Software1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Software2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Software3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int qtdAlunosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int qtdComputadoresField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Projetor {
            get {
                return this.ProjetorField;
            }
            set {
                if ((this.ProjetorField.Equals(value) != true)) {
                    this.ProjetorField = value;
                    this.RaisePropertyChanged("Projetor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SistemaOperacional {
            get {
                return this.SistemaOperacionalField;
            }
            set {
                if ((object.ReferenceEquals(this.SistemaOperacionalField, value) != true)) {
                    this.SistemaOperacionalField = value;
                    this.RaisePropertyChanged("SistemaOperacional");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Software1 {
            get {
                return this.Software1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Software1Field, value) != true)) {
                    this.Software1Field = value;
                    this.RaisePropertyChanged("Software1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Software2 {
            get {
                return this.Software2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Software2Field, value) != true)) {
                    this.Software2Field = value;
                    this.RaisePropertyChanged("Software2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Software3 {
            get {
                return this.Software3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Software3Field, value) != true)) {
                    this.Software3Field = value;
                    this.RaisePropertyChanged("Software3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int qtdAlunos {
            get {
                return this.qtdAlunosField;
            }
            set {
                if ((this.qtdAlunosField.Equals(value) != true)) {
                    this.qtdAlunosField = value;
                    this.RaisePropertyChanged("qtdAlunos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int qtdComputadores {
            get {
                return this.qtdComputadoresField;
            }
            set {
                if ((this.qtdComputadoresField.Equals(value) != true)) {
                    this.qtdComputadoresField = value;
                    this.RaisePropertyChanged("qtdComputadores");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IServico")]
    public interface IServico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/inserir", ReplyAction="http://tempuri.org/IServico/inserirResponse")]
        bool inserir(MVC.ServiceReference.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/inserir", ReplyAction="http://tempuri.org/IServico/inserirResponse")]
        System.Threading.Tasks.Task<bool> inserirAsync(MVC.ServiceReference.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/Listar", ReplyAction="http://tempuri.org/IServico/ListarResponse")]
        MVC.ServiceReference.Sala[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/Listar", ReplyAction="http://tempuri.org/IServico/ListarResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReference.Sala[]> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/getById", ReplyAction="http://tempuri.org/IServico/getByIdResponse")]
        MVC.ServiceReference.Sala getById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/getById", ReplyAction="http://tempuri.org/IServico/getByIdResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReference.Sala> getByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/editar", ReplyAction="http://tempuri.org/IServico/editarResponse")]
        int editar(MVC.ServiceReference.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/editar", ReplyAction="http://tempuri.org/IServico/editarResponse")]
        System.Threading.Tasks.Task<int> editarAsync(MVC.ServiceReference.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/excluir", ReplyAction="http://tempuri.org/IServico/excluirResponse")]
        int excluir(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/excluir", ReplyAction="http://tempuri.org/IServico/excluirResponse")]
        System.Threading.Tasks.Task<int> excluirAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoChannel : MVC.ServiceReference.IServico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoClient : System.ServiceModel.ClientBase<MVC.ServiceReference.IServico>, MVC.ServiceReference.IServico {
        
        public ServicoClient() {
        }
        
        public ServicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool inserir(MVC.ServiceReference.Sala sala) {
            return base.Channel.inserir(sala);
        }
        
        public System.Threading.Tasks.Task<bool> inserirAsync(MVC.ServiceReference.Sala sala) {
            return base.Channel.inserirAsync(sala);
        }
        
        public MVC.ServiceReference.Sala[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReference.Sala[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public MVC.ServiceReference.Sala getById(int id) {
            return base.Channel.getById(id);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReference.Sala> getByIdAsync(int id) {
            return base.Channel.getByIdAsync(id);
        }
        
        public int editar(MVC.ServiceReference.Sala sala) {
            return base.Channel.editar(sala);
        }
        
        public System.Threading.Tasks.Task<int> editarAsync(MVC.ServiceReference.Sala sala) {
            return base.Channel.editarAsync(sala);
        }
        
        public int excluir(int id) {
            return base.Channel.excluir(id);
        }
        
        public System.Threading.Tasks.Task<int> excluirAsync(int id) {
            return base.Channel.excluirAsync(id);
        }
    }
}

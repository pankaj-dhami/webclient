﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/HelloService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfClient.ServiceReference1.FullTimeEmployee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfClient.ServiceReference1.PartTimeEmployee))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeType {
            get {
                return this.EmployeeTypeField;
            }
            set {
                if ((this.EmployeeTypeField.Equals(value) != true)) {
                    this.EmployeeTypeField = value;
                    this.RaisePropertyChanged("EmployeeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FullTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/HelloService")]
    [System.SerializableAttribute()]
    public partial class FullTimeEmployee : WcfClient.ServiceReference1.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnnualSalaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AnnualSalary {
            get {
                return this.AnnualSalaryField;
            }
            set {
                if ((this.AnnualSalaryField.Equals(value) != true)) {
                    this.AnnualSalaryField = value;
                    this.RaisePropertyChanged("AnnualSalary");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/HelloService")]
    [System.SerializableAttribute()]
    public partial class PartTimeEmployee : WcfClient.ServiceReference1.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HourlyPayField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HourlyPay {
            get {
                return this.HourlyPayField;
            }
            set {
                if ((this.HourlyPayField.Equals(value) != true)) {
                    this.HourlyPayField = value;
                    this.RaisePropertyChanged("HourlyPay");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        WcfClient.ServiceReference1.Employee1 GetEmployee(WcfClient.ServiceReference1.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee1> GetEmployeeAsync(WcfClient.ServiceReference1.EmployeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeType", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeTypeResponse")]
        WcfClient.ServiceReference1.Employee1 GetEmployeeType(WcfClient.ServiceReference1.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeType", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeTypeResponse")]
        System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee1> GetEmployeeTypeAsync(WcfClient.ServiceReference1.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation SaveEmployee is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        WcfClient.ServiceReference1.SaveEmployeeResponse SaveEmployee(WcfClient.ServiceReference1.Employee1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<WcfClient.ServiceReference1.SaveEmployeeResponse> SaveEmployeeAsync(WcfClient.ServiceReference1.Employee1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetAllEmployeesResponse")]
        WcfClient.ServiceReference1.Employee[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee[]> GetAllEmployeesAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int Id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int TypeId;
        
        public EmployeeRequest() {
        }
        
        public EmployeeRequest(int Id, int TypeId) {
            this.Id = Id;
            this.TypeId = TypeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Employee", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Employee1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int Id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.DateTime DateOfBirth;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int EmployeeType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string Gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string Name;
        
        public Employee1() {
        }
        
        public Employee1(int Id, System.DateTime DateOfBirth, int EmployeeType, string Gender, string Name) {
            this.Id = Id;
            this.DateOfBirth = DateOfBirth;
            this.EmployeeType = EmployeeType;
            this.Gender = Gender;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveEmployeeResponse {
        
        public SaveEmployeeResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : WcfClient.ServiceReference1.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<WcfClient.ServiceReference1.IEmployeeService>, WcfClient.ServiceReference1.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfClient.ServiceReference1.Employee1 WcfClient.ServiceReference1.IEmployeeService.GetEmployee(WcfClient.ServiceReference1.EmployeeRequest request) {
            return base.Channel.GetEmployee(request);
        }
        
        public System.DateTime GetEmployee(ref int Id, int TypeId, out int EmployeeType, out string Gender, out string Name) {
            WcfClient.ServiceReference1.EmployeeRequest inValue = new WcfClient.ServiceReference1.EmployeeRequest();
            inValue.Id = Id;
            inValue.TypeId = TypeId;
            WcfClient.ServiceReference1.Employee1 retVal = ((WcfClient.ServiceReference1.IEmployeeService)(this)).GetEmployee(inValue);
            Id = retVal.Id;
            EmployeeType = retVal.EmployeeType;
            Gender = retVal.Gender;
            Name = retVal.Name;
            return retVal.DateOfBirth;
        }
        
        public System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee1> GetEmployeeAsync(WcfClient.ServiceReference1.EmployeeRequest request) {
            return base.Channel.GetEmployeeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfClient.ServiceReference1.Employee1 WcfClient.ServiceReference1.IEmployeeService.GetEmployeeType(WcfClient.ServiceReference1.EmployeeRequest request) {
            return base.Channel.GetEmployeeType(request);
        }
        
        public System.DateTime GetEmployeeType(ref int Id, int TypeId, out int EmployeeType, out string Gender, out string Name) {
            WcfClient.ServiceReference1.EmployeeRequest inValue = new WcfClient.ServiceReference1.EmployeeRequest();
            inValue.Id = Id;
            inValue.TypeId = TypeId;
            WcfClient.ServiceReference1.Employee1 retVal = ((WcfClient.ServiceReference1.IEmployeeService)(this)).GetEmployeeType(inValue);
            Id = retVal.Id;
            EmployeeType = retVal.EmployeeType;
            Gender = retVal.Gender;
            Name = retVal.Name;
            return retVal.DateOfBirth;
        }
        
        public System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee1> GetEmployeeTypeAsync(WcfClient.ServiceReference1.EmployeeRequest request) {
            return base.Channel.GetEmployeeTypeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfClient.ServiceReference1.SaveEmployeeResponse WcfClient.ServiceReference1.IEmployeeService.SaveEmployee(WcfClient.ServiceReference1.Employee1 request) {
            return base.Channel.SaveEmployee(request);
        }
        
        public void SaveEmployee(int Id, System.DateTime DateOfBirth, int EmployeeType, string Gender, string Name) {
            WcfClient.ServiceReference1.Employee1 inValue = new WcfClient.ServiceReference1.Employee1();
            inValue.Id = Id;
            inValue.DateOfBirth = DateOfBirth;
            inValue.EmployeeType = EmployeeType;
            inValue.Gender = Gender;
            inValue.Name = Name;
            WcfClient.ServiceReference1.SaveEmployeeResponse retVal = ((WcfClient.ServiceReference1.IEmployeeService)(this)).SaveEmployee(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfClient.ServiceReference1.SaveEmployeeResponse> WcfClient.ServiceReference1.IEmployeeService.SaveEmployeeAsync(WcfClient.ServiceReference1.Employee1 request) {
            return base.Channel.SaveEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfClient.ServiceReference1.SaveEmployeeResponse> SaveEmployeeAsync(int Id, System.DateTime DateOfBirth, int EmployeeType, string Gender, string Name) {
            WcfClient.ServiceReference1.Employee1 inValue = new WcfClient.ServiceReference1.Employee1();
            inValue.Id = Id;
            inValue.DateOfBirth = DateOfBirth;
            inValue.EmployeeType = EmployeeType;
            inValue.Gender = Gender;
            inValue.Name = Name;
            return ((WcfClient.ServiceReference1.IEmployeeService)(this)).SaveEmployeeAsync(inValue);
        }
        
        public WcfClient.ServiceReference1.Employee[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<WcfClient.ServiceReference1.Employee[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
    }
}
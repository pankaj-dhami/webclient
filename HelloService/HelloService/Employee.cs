using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloService
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public int EmployeeType { get; set; }
    }

    [DataContract]
    public class EmployeeRequest
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int TypeId { get; set; }
    }
}

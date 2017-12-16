using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloService
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [MessageContract]
    public class Employee
    {
        [MessageHeader]
        public int Id { get; set; }
        [MessageBodyMember]
        public string Name { get; set; }
        [MessageBodyMember]
        public string Gender { get; set; }
        [MessageBodyMember]
        public DateTime DateOfBirth { get; set; }
        [MessageBodyMember]
        public int EmployeeType { get; set; }
    }

    [MessageContract]
    public class EmployeeRequest
    {
        [MessageHeader]
        public int Id { get; set; }
        [MessageHeader]
        public int TypeId { get; set; }
    }
}

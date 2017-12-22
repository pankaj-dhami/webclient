using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloService
{
    [DataContract]
    public class FullTimeEmployee : Employee
    {
        [DataMember]
        public int AnnualSalary { get; set; }
    }
}

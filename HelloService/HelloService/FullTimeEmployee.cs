using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloService
{
    [MessageContract]
    public class FullTimeEmployee : Employee
    {
        [MessageBodyMember]
        public int AnnualSalary { get; set; }
    }
}

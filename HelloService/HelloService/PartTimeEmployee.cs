using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloService
{
    [DataContract]
    public class PartTimeEmployee : Employee
    {
        [DataMember]
        public int HourlyPay { get; set; }
    }
}

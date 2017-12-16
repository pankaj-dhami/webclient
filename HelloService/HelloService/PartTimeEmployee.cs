using System.ServiceModel;

namespace HelloService
{
    [MessageContract]
    public class PartTimeEmployee : Employee
    {
        [MessageBodyMember]
        public int HourlyPay { get; set; }
    }
}

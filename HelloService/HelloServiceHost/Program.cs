using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloServiceHost
{
    class Program
    {
        //https://refactoring.guru/design-patterns/behavioral-patterns

        static void Main(string[] args)
        {
            using (ServiceHost host2 = new ServiceHost(typeof(HelloService.CalculatorService)))
            using (ServiceHost host = new ServiceHost(typeof(HelloService.EmployeeService)))
            {
                host2.Open();
                host.Open();
                Console.WriteLine("Host Started {0}/{1}", DateTime.Now.ToString(), host.State);
                Console.Read();
            }

        }
    }
}

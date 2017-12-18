using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace HelloService.auth
{
    class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            try
            {
                if (userName == "test" && password == "test123")
                {
                    Console.WriteLine("Authentic User");
                }
            }
            catch (Exception ex)
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel.Tokens;

namespace HelloService.auth
{
    public class ServiceAuthenticator : UserNamePasswordValidator
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
    public class MyX509CertificateValidator : X509CertificateValidator
    {
        string allowedIssuerName;

        public MyX509CertificateValidator(string allowedIssuerName)
        {
            if (allowedIssuerName == null)
            {
                throw new ArgumentNullException("allowedIssuerName");
            }

            this.allowedIssuerName = allowedIssuerName;
        }

        public override void Validate(X509Certificate2 certificate)
        {
            // Check that there is a certificate.
            if (certificate == null)
            {
                throw new ArgumentNullException("certificate");
            }

            // Check that the certificate issuer matches the configured issuer.
            if (allowedIssuerName != certificate.IssuerName.Name)
            {
                throw new SecurityTokenValidationException
                  ("Certificate was not issued by a trusted issuer");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfClient.ServiceReference1;

namespace WcfClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("NetTcpBinding_HelloService");
            // var result = client.Hello("pankaj");
            ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            Employee1 result=
            client.GetEmployeeTypeAsync(new EmployeeRequest { TypeId=1}).Result;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
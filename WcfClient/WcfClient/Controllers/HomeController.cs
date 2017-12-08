using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WcfClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("NetTcpBinding_HelloService");
           // var result = client.Hello("pankaj");
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
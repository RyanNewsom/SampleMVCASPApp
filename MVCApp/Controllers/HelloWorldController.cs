using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID is: " + ID);
        }
    }
}
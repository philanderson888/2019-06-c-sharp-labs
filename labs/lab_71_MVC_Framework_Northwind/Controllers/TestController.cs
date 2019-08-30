using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_71_MVC_Framework_Northwind.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return "Hello how are you?";
        }
    }
}
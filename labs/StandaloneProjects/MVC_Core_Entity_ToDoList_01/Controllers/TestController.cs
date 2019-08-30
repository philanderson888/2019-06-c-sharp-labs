using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Controllers
{
    public class TestController : Controller
    {
        

        public IActionResult Index()
        {
            var instance = new Lists();
            instance.stringList = new List<string>() { "one", "two", "three" };
            instance.publicCelebrityWhoWeWontActuallyName = "Un-named Celebrity";
            instance.publicCelebrityHasNoAge = 55;
            return View(instance);
        }
    }
}
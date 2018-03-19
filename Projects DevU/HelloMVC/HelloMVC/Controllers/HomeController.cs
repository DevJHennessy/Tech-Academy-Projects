using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();
            
            //If you create a dynamic property and spell it wrong in one place, there
            //isn't anything to tell you that you made a mistake. It just won't show up.
            ViewBag.JohnCreatedThisValue = "Hello, MVC.";

            return View(cars);
        }
    }
}
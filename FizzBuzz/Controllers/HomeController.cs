using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persona = new Persona();
            return View(persona);
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            return View(persona);
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

        public ActionResult FizzBuzz()
        {
            ViewBag.Message = "FizzBuzzeando un ratete";
            var fizzBuzzer = new FizzBuzzer();
            return View(fizzBuzzer);
        }
        [HttpPost]
        public ActionResult FizzBuzz(FizzBuzzer fizzBuzzer)
        {
            return View(fizzBuzzer);
        }
    }
}
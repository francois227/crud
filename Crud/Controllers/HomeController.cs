using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
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

        public ActionResult Persons()
        {
            var persons = new List<Person>();
            persons.Add(new Person { Nombre = "Pepe", Edad = 10 });
            persons.Add(new Person { Nombre = "Jaimito", Edad = 30 });
            persons.Add(new Person { Nombre = "Juanito", Edad = 20 });
            return View(persons);
        }
    }
}
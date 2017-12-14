using Practica14._12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica14._12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Persona");
        }

        public ActionResult Persona()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Persona(Persona person)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
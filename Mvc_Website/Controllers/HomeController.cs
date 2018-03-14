using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Website.Models;

namespace Mvc_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aplikacja()
        {
            ViewBag.Message = "Nie musicie już wyszukiwać ważnych informacji kursując między fanpage'ami, scrollując posty na wallu a stroną internetową.";

            return View();
        }

        public ActionResult Rejestracja()
        {
            ViewBag.Message = "Jeżeli chciałbyś mieć swojego Food Trucka umieszczonego w mojej aplikacji, wypełnij formularz.";
            /*
            registration registrations = new registration()
            {
                NameOfTruck = "Pasibus",
                TypeOfMeal = "Burger",
                City = "Wroclaw"
            };
            */

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Zapraszam do kontaktu.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Controller.Controllers
{
    public class HomeController : MyController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Title = "Sobre";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Layout.Controllers
{
    public class HomeController : MyController
    {
        public ActionResult Index()
        {
            ViewBag.h1 = "Index - página inicial";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.h1 = "Quem somos";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.h1 = "Fale conosco";
            return View();
        }
    }
}

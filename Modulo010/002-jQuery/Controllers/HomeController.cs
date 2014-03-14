using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002_jQuery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Bind()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Text()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Length()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Id()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Seletor()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Filtro()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Multiplos()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Live()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Ajax()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult UI()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }
    }
}
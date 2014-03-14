using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Javascript.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Variaveis()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Objetos()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Funcoes()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Init()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Classe()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Prototype()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Create()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Prototype2()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult GetterSetter()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Heranca()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Namespace()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult Strict()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }

        public ActionResult DOM()
        {
            @ViewBag.Title = ControllerContext.RouteData.GetRequiredString("action").ToString();
            return View();
        }
    }
}
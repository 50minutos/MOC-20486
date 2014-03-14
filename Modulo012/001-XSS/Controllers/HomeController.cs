using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_XSS.Controllers
{
    public class HomeController : Controller
    {
        [ValidateInput(false)]
        public ActionResult Index(String mensagem)
        {
            ViewBag.Title = "Index";
            ViewBag.Mensagem = mensagem;

            return View();
        }
    }
}
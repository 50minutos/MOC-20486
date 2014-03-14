using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _003_TempData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["NOME"] = "AGNALDO";

            return RedirectToAction("Index2");
        }
    
        public ActionResult Index2()
        {
            var nome = TempData["NOME"];
            
            return View(nome);
        }
    }
}
using _001_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_View.Controllers
{
    public class UfController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(String id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UF uf)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(String id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(UF uf)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(String id)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(String id)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UT.Controllers
{
    public class PessoaController : Controller
    {
        DBEntities db = null;

        public PessoaController()
        {
            db = new DBEntities();
        }

        public ActionResult Index()
        {
            var list = db.Pessoas.ToList();

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Edit/5

        public ActionResult Edit(int id)
        {
            return View(db.Pessoas.Find(id));
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

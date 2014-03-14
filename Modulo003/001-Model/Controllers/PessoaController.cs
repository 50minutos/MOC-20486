using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Model.Controllers
{
    public class PessoaController : Controller
    {
        Models.DBEntities db = new Models.DBEntities();

        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            var pessoas = db.Pessoas;

            ViewBag.Title = "Pessoas";

            return View(pessoas);
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create

        [HttpPost]
        public ActionResult Create(Models.Pessoa p)
        {
            try
            {
                db.Pessoas.Add(p);

                db.SaveChanges();

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
            var pessoa = db.Pessoas.FirstOrDefault(p => p.Cod == id);

            if(pessoa == null)
                return RedirectToAction("Index");

            return View(pessoa);
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

using _001_TryCatch.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_TryCatch.Controllers
{
    public class PessoaController : Controller
    {
        DBEntities db = new DBEntities();

        public ActionResult Index()
        {
            var list = db.Pessoas.ToList();

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pessoa p)
        {
            try
            {
                db.Pessoas.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;

                return View();
            }
        }

        //
        // GET: /Pessoa/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var p = db.Pessoas.FirstOrDefault(o => o.Codigo == id);

            if (p == null)
                return RedirectToAction("Index");
            else
                return View(p);
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(Pessoa p)
        {
            try
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();

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

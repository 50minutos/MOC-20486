using _001_View.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace _001_View.Controllers
{
    public class CidadeController : Controller
    {
        DbEntities db = new DbEntities();

        public ActionResult Index()
        {
            return View(db.Cidades.Include("UF"));
        }

        public ActionResult Create()
        {
            ViewData["SiglaUFDDL"] = new SelectList(db.UFs.OrderBy(o => o.Nome), "Sigla", "Nome");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cidade cidade)
        {
            try
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ModelState.Keys)
                {
                    ModelState[item].Errors.Clear();
                }

                foreach (var i in ex.EntityValidationErrors)
                {
                    foreach (var j in i.ValidationErrors)
                    {
                        ModelState.AddModelError(j.PropertyName, j.ErrorMessage);
                    }
                }

                TempData["ViewData"] = ViewData;

                ViewData["SiglaUFDDL"] = new SelectList(db.UFs.OrderBy(o => o.Nome), "Sigla", "Nome");

                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = db.Cidades.Find(id);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            ViewData["SiglaUFDDL"] = new SelectList(db.UFs.OrderBy(o => o.Nome), "Sigla", "Nome", cidade.SiglaUF);

            return View(cidade);
        }

        [HttpPost]
        public ActionResult Edit(Cidade cidade)
        {
            try
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ModelState.Keys)
                {
                    ModelState[item].Errors.Clear();
                }

                foreach (var i in ex.EntityValidationErrors)
                {
                    foreach (var j in i.ValidationErrors)
                    {
                        ModelState.AddModelError(j.PropertyName, j.ErrorMessage);
                    }
                }

                ViewData["SiglaUFDDL"] = new SelectList(db.UFs.OrderBy(o => o.Nome), "Sigla", "Nome", cidade.SiglaUF);

                return View(cidade);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = db.Cidades.Find(id);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            try
            {
                Cidade cidade = db.Cidades.Find(id);
                db.Cidades.Remove(cidade);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ModelState.Keys)
                {
                    ModelState[item].Errors.Clear();
                }

                foreach (var i in ex.EntityValidationErrors)
                {
                    foreach (var j in i.ValidationErrors)
                    {
                        ModelState.AddModelError(j.PropertyName, j.ErrorMessage);
                    }
                }

                return View(db.Cidades.FirstOrDefault(o => o.Id == id));
            }
        }
    }
}

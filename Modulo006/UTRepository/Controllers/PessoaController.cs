using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UTRepository.Models;

namespace UTRepository.Controllers
{
    public class PessoaController : Controller
    {
        IPessoaRepository db = null;

        public PessoaController(IPessoaRepository db)
        {
            this.db = db;
        }

        public PessoaController()
            : this(new PessoaRepository())
        {
        }

        public ActionResult Index()
        {
            var pessoas = db.GetAll();

            return View(pessoas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                db.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }

        public ActionResult Edit(int id = 0)
        {
            var pessoa = db.Get(id);
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                db.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
        }

        public ActionResult Delete(int id = 0)
        {
            var pessoa = db.Get(id);
            return View(pessoa);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            if (ModelState.IsValid)
            {
                db.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Delete");
            }
        }
    }
}
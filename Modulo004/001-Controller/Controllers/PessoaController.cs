using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Controller.Controllers
{
    public class PessoaController : MyController
    {
        public ActionResult Index()
        {
            var pessoas = db.Pessoas;

            return View(pessoas);
        }

        public ActionResult Json()
        {
            var pessoas = db.Pessoas;

            return Json(pessoas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id)
        {
            var pessoa = db.Pessoas.FirstOrDefault(o => o.Id == id);

            if (pessoa == null)
                return RedirectToAction("Index");

            return View(pessoa);
        }

        public ActionResult Delete(int id)
        {
            var pessoa = db.Pessoas.FirstOrDefault(o => o.Id == id);

            if (pessoa == null)
                return RedirectToAction("Index");

            return View(pessoa);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            var pessoa = db.Pessoas.FirstOrDefault(o => o.Id == id);

            if (pessoa == null)
                return RedirectToAction("Index");

            db.Pessoas.Remove(pessoa);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public String GetNome(int id)
        {
            var retorno = "dado não encontrado";

            var p = db.Pessoas.FirstOrDefault(o => o.Id == id);

            if (p != null)
                retorno = p.Nome;

            return retorno;
        }
    }
}

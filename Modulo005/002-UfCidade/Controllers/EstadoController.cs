using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UfCidade.Models;
 
namespace UfCidade.Controllers
{
    public class EstadoController : Controller
    {
        private DBEntities db = new DBEntities();

        // GET: /Estado/
        public ActionResult Index()
        {
            return View(db.Estados.ToList());
        }

        // GET: /Estado/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = db.Estados.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        // GET: /Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Estado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EstadoId,EstadoNome")] Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Estados.Add(estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado);
        }

        // GET: /Estado/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = db.Estados.Include(o=> o.Cidades).Where(o => o.EstadoId == id).Single();
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        // POST: /Estado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EstadoId,EstadoNome,Cidades")] Estado estado)
        {
            if (ModelState.IsValid)
            {
                var obj = db.Estados.Include(o=> o.Cidades).Where(o => o.EstadoId == estado.EstadoId).Single();

                db.Entry(obj).CurrentValues.SetValues(estado);
                
                foreach (var item in obj.Cidades)
                {
                    item.CidadeNome = estado.Cidades.First(o => o.CidadeId == item.CidadeId).CidadeNome;
                }

                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(estado);
        }

        // GET: /Estado/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = db.Estados.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        // POST: /Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Estado estado = db.Estados.Find(id);
            db.Estados.Remove(estado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
/*
CREATE TABLE Estado
(
	EstadoId CHAR(2) PRIMARY KEY, 
	EstadoNome VARCHAR(50) NOT NULL
)

INSERT Estado
VALUES ('SP', 'SAO PAULO')

CREATE TABLE Cidade
(
	CidadeId INT IDENTITY PRIMARY KEY, 
	CidadeNome VARCHAR(50) NOT NULL, 
	EstadoId CHAR(2) REFERENCES Estado
)

INSERT Cidade
VALUES ('SAO PAULO', 'SP'),
	('CAMPINAS', 'SP') 
 */
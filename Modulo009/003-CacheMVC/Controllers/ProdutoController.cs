using _003_CacheMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace _003_CacheMVC.Controllers
{
    public class ProdutoController : Controller
    {
        DBEntities db = new DBEntities();

        public ActionResult List()
        {
            if (MemoryCache.Default["PRODUTOS"] == null)
            {
                MemoryCache.Default.AddOrGetExisting("PRODUTOS", db.Produtos.ToList(), DateTime.Now.AddSeconds(90));
            }

            return View(MemoryCache.Default["PRODUTOS"] as List<Produto>);
        }

        [OutputCache(Duration = 20)]
        public ActionResult Index()
        {
            ViewBag.Agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff");

            return View(db.Produtos);
        }
    }
}

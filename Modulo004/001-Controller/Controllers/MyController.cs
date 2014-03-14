using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Controller.Controllers
{
    public class MyController : Controller
    {
        protected Models.Contexto db = new Models.Contexto();

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var p = db.Parametros.FirstOrDefault(o => o.Chave.Equals("URL", StringComparison.CurrentCultureIgnoreCase));

            if (p != null)
                ViewBag.URL = p.Conteudo;

            p = db.Parametros.FirstOrDefault(o => o.Chave.Equals("ENDERECO", StringComparison.CurrentCultureIgnoreCase));

            if (p != null)
                ViewBag.ENDERECO = p.Conteudo;
        }
    }
}
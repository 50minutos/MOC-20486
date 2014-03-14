using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using _001_MVC.Models;

namespace _001_MVC.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult List()
        {
            var pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa { Codigo = 1, Nome = "ADÃO" });
            pessoas.Add(new Pessoa { Codigo = 2, Nome = "EVA" });
            pessoas.Add(new Pessoa { Codigo = 3, Nome = "CAIM" });
            pessoas.Add(new Pessoa { Codigo = 4, Nome = "ABEL" });

            return View(pessoas);
        }

    }
}

using SEO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEO.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Edit(int id = 0)
        {
            //simulando uma ida ao banco de dados
            var p = new Pessoa { Codigo = id, Nome = "ADAO" };

            return View(p);
        }

        public ActionResult List()
        {
            //simulando uma ida ao banco de dados
            return View(new List<Pessoa> 
            { 
                new Pessoa { Codigo = 1, Nome = "ADAO" }, 
                new Pessoa { Codigo = 2, Nome = "EVA" } 
            });
        }
    }

}

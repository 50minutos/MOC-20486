using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace _001_Layout.Controllers
{
    public class MyController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            ViewBag.title = "site de exemplo ASP.NET MVC - exemplo de view com layout";
            ViewBag.description = "site de exemplo ASP.NET MVC";
            ViewBag.keywords = "asp, asp.net, mvc, asp.net mvc, view, exemplo de mvc, mvc example";
            ViewBag.googlebot = "follow, index";
            ViewBag.robots = "follow, index";
        }
    }
}

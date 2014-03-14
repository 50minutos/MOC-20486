using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SEO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Pessoa",
                url: "pessoa/editar/{id}",
                defaults: new { controller = "Pessoa", action = "Edit" }
            );

            routes.MapRoute(
                            name: "ListarPessoas",
                            url: "pessoas",
                            defaults: new { controller = "Pessoa", action = "List" }
                        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
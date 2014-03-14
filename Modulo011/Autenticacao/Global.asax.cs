using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Autenticacao.Models;

namespace Autenticacao
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void FormsAuthentication_OnAuthenticate(Object sender, FormsAuthenticationEventArgs e)
        {
            if (FormsAuthentication.CookiesSupported == true)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    var nome = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;

                    var db = new DBEntities();

                    var user = db.Logins.Include("Roles").SingleOrDefault(u => u.LoginNome == nome);

                    var roles = user.Roles.Select(o => o.RoleNome).ToArray();

                    e.User = new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(nome, "Forms"), roles);
                }
            }
        }
    }
}

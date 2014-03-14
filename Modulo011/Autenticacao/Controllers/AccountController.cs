using Autenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Autenticacao.Controllers
{
    public class AccountController : Controller
    {
        DBEntities db = new DBEntities();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login, String returnUrl)
        {
            if(db.Logins.Any(o => o.LoginNome.Equals(login.LoginNome) && o.LoginSenha.Equals(login.LoginSenha)))
            {
                FormsAuthentication.SetAuthCookie(login.LoginNome, false);

                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
                ModelState.AddModelError("", "usuário ou senha incorretos");

            return View();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autenticacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult IndexAutenticado()
        {
            return View();
        }

        [Authorize(Roles = "ADMIN")]
        public ActionResult IndexAdmin()
        {
            return View();
        }
    }
}

/*
CREATE TABLE Role
(
	RoleId INT IDENTITY PRIMARY KEY, 
	RoleNome VARCHAR(10) NOT NULL UNIQUE
)

CREATE TABLE Login
(
	LoginId INT IDENTITY PRIMARY KEY, 
	LoginNome VARCHAR(10) NOT NULL UNIQUE, 
	LoginSenha VARCHAR(10) NOT NULL
)

CREATE TABLE RoleLogin
(
    RoleId INT REFERENCES Role, 
    LoginId INT REFERENCES Login, 
    PRIMARY KEY(RoleId, LoginId)
)
 
INSERT Role VALUES ('ADMIN')
INSERT Role VALUES ('FINANCEIRO')
INSERT Role VALUES ('PRODUCAO')

INSERT Login VALUES ('ADMIN', 'ADMIN')
INSERT Login VALUES ('USUARIO', 'USUARIO')

INSERT RoleLogin VALUES (1, 1)
*/
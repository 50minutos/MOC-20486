using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _001_Handler.Controllers
{
    public class DownloadPNG : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", context.Request.QueryString["NOME"]));
            context.Response.ContentType = "image/png";
            context.Response.WriteFile(context.Request.QueryString["NOME"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
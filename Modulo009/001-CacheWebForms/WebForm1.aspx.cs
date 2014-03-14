using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_CacheWebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Origem.Text = "CACHE";

            if (Cache["ARQ"] == null)
            {
                Origem.Text = "DISCO";

                var nomeArquivo = Server.MapPath("Arquivo.txt");

                using (var sr = new StreamReader(nomeArquivo))
                {
                    //Cache["ARQ"] = sr.ReadToEnd();
                    Cache.Insert("ARQ", sr.ReadToEnd(), new CacheDependency(nomeArquivo));
                    sr.Close();
                }
            }

            Conteudo.Text = Cache["ARQ"].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_CacheWebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cache.Insert("NUNCA", "AGNALDO");
                Cache.Insert("EM_20_SEGUNDOS", "CONTEÚDO", null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(20));
                Cache.Insert("FIM_DO_ANO", "CONTEÚDO", null, new DateTime(2014, 12, 31, 23, 59, 59, 997), System.Web.Caching.Cache.NoSlidingExpiration);
            }
            else
            {
                if (Cache["NUNCA"] != null) NUNCA.Text = Cache["NUNCA"].ToString();
                
                if (Cache["EM_20_SEGUNDOS"] != null) EM_20_SEGUNDOS.Text = Cache["EM_20_SEGUNDOS"].ToString();

                if (Cache["FIM_DO_ANO"] != null) FIM_DO_ANO.Text = Cache["FIM_DO_ANO"].ToString();
            }
        }
    }
}
using System.Web;
using System.Web.Mvc;

namespace _001_AjaxActionLink
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
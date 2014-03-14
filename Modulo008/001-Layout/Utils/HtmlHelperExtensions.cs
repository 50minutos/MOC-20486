using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_Layout.Utils
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString ActionLinkWithHighlight(this HtmlHelper htmlHelper, String text, String action, String controller)
        {
            var a = new TagBuilder("a");

            var v = htmlHelper.ViewContext.RouteData.GetRequiredString("action");

            a.SetInnerText(text);
            a.Attributes.Add("href", String.Format("/{0}/{1}", controller, action));

            if (v.Equals(action, StringComparison.CurrentCultureIgnoreCase))
            {
                a.Attributes.Add("class", "selected");
            }

            return MvcHtmlString.Create(a.ToString());
        }
    }
}
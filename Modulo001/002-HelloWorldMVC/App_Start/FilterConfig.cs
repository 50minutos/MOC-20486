﻿using System.Web;
using System.Web.Mvc;

namespace _002_HelloWorldMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
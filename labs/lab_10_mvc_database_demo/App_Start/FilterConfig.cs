﻿using System.Web;
using System.Web.Mvc;

namespace lab_10_mvc_database_demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

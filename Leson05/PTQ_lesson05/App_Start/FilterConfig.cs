﻿using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

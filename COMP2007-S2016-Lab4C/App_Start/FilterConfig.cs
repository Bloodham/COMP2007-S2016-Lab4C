﻿using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Lab4C
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

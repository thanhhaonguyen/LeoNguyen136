﻿using System.Web;
using System.Web.Mvc;

namespace NguyenThanhHao_Lab456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

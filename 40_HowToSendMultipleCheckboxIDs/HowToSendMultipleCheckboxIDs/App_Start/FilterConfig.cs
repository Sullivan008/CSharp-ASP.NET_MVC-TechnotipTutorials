﻿using System.Web.Mvc;

namespace HowToSendMultipleCheckboxIDs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

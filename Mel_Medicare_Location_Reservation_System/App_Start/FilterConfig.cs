﻿using System.Web;
using System.Web.Mvc;

namespace Mel_Medicare_Location_Reservation_System
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

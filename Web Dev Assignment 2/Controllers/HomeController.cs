﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Web_Dev_Assignment_2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

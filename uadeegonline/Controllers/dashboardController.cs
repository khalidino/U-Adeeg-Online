﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uadeegonline.Controllers
{
    public class dashboardController : Controller
    {
        // GET: dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}
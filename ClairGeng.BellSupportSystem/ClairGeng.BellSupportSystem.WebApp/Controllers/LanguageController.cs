﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ClairGeng.BellSupportSystem.WebApp.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(string LanguageAbbr)
        {
            if (LanguageAbbr != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbr);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbr);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbr;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
    }
}
﻿using System.Web.Mvc;

namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "VendingMachine");
        }
    }
}
﻿using System.Web.Mvc;


namespace CyrillicSoftware.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var email = HttpContext.User.Identity.Name;
            ViewBag.email = email;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Passion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult AboutSection()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Codes()
        {
            return View();
        }
        public ActionResult Icons()
        {
            return View();
        }
        public ActionResult Portfolio()
        {
            return View();
        }
    }
}
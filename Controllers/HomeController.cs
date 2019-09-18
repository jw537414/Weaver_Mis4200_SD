using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mis4200_SD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "| Ohio University Class of 2019 | Management Information System | Business Analytics |";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
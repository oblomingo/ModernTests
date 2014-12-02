using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModernTests.Helpers;

namespace ModernTests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.Message = EmailHelper.SendEmail("aleksandr.suchovarov@gmail.com", "hi", "hello!!!")
                ? "Message sended"
                : "Message not sended";

            return View();
        }
    }
}
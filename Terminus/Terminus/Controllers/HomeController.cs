using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Terminus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Terminus!";

            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "What is Terminus?";

            return View();
        }
    }
}

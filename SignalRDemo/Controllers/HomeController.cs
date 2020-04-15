using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JqueryChat()
        {
            return View();
        }

        public ActionResult AngularJsChat()
        {

            return View();
        }
    }
}
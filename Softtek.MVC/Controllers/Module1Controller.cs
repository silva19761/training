using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softtek.MVC.Controllers
{
    public class Module1Controller : Controller
    {
        // GET: Module1
        public ActionResult HTML5AndCSS3()
        {
            return View();
        }

        public ActionResult Bootstrap()
        {
            return View();
        }

        public ActionResult jQuery()
        {
            return View();
        }
    }
}
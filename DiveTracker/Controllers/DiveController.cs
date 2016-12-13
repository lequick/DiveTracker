using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiveTracker.Controllers
{
    public class DiveController : Controller
    {
        // GET: Dive
        public ActionResult AddPosition()
        {
            return View();
        }
    }
}
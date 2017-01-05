using DiveRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiveTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DiveFac Df = new DiveFac();
        public ActionResult Index()
        {

            return View(Df.GetAll());
        }
    }
}
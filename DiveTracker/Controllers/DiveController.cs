using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiveRepo;


namespace DiveTracker
{
    public class DiveController : Controller
    {
        DiveFac Df = new DiveFac();
        // GET: Dive
        public ActionResult AddPosition()
        {

            return View(Df.GetAll());
        }

        [HttpPost]
        public ActionResult AddPosition(DiveRepo.DiveTracker dive, HttpPostedFileBase billeder)
        {
            dive.Billeder = null;
            

            if (billeder != null)
            {
                Uploader uploader = new Uploader();
                string path = Request.PhysicalApplicationPath + "/Content/";

                string fil = uploader.UploadImage(billeder, path, 255, true);

                dive.Billeder = System.IO.Path.GetFileName(fil);
            }
            else
            {
                ViewBag.MSG = "Der er Ikke valgt et billede";
            }

            Df.Insert(dive);
            return RedirectToAction("AddPosition");
        }



        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase billeder)
        {

            return RedirectToAction("AddPosition");
        }

        public HttpPostedFileBase Billeder { get; set; }
    }
}
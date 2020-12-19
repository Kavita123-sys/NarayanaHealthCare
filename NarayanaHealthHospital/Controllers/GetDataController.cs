using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NarayanaHealthHospital.Controllers
{
    public class GetDataController : Controller
    {
        // GET: GetData
        public ActionResult Index()
        {
            return View("getdata");
        }
        public ActionResult EnquiryInternational()
        {
            return View();
        }
        public ActionResult FeedbackForm()
        {
            return View();
        }
        public ActionResult AppointmentForm()
        {
            return View();
        }
        public ActionResult HealthPackage()
        {
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Design_Lab_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Details()
        {
            ViewBag.Message = "person test";

            return View();
        }
    }
}
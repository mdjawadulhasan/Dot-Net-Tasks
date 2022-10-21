using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "MD.JAWADUL HASAN";
            ViewBag.ID = "20-41958-1";
            ViewBag.cgpa = 3.99;
            ViewBag.CreditCompleted = 120;
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }


        public ActionResult Projects()
        {
            return View();
        }


        public ActionResult Reference()
        {
            ViewBag.Name = "TANVIR AHMED";
            ViewBag.Email = "tanvir.ahmed@aiub.edu";
            ViewBag.Designations = "Lecturer , Computer Science";
            return View();
        }


    }
}
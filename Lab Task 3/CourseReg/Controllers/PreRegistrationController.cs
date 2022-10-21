using CourseReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseReg.Controllers
{
    public class PreRegistrationController : Controller
    {
        // GET: PreRegistration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PreReg()
        {

            var db = new UMSTaskEntities1();
            var course = db.Courses.ToList();



            List<Course> courses = new List<Course>();

            foreach (var cr in course)
            {
                var studentcourses = db.CourseStudents.Where(temp => temp.StudentId == 1 && temp.CourseId == cr.Id).SingleOrDefault();

                if (studentcourses == null)
                {
                    var prereqcheck = db.CourseStudents.Where(temp => temp.StudentId == 1 && temp.CourseId == cr.PreReq).SingleOrDefault();
                    if (prereqcheck != null)
                    {
                        if (prereqcheck.Status == "Passed")
                        {
                            courses.Add(cr);
                        }

                    }
                }
                else if (studentcourses.Marks < 60 || studentcourses.Status == "W")
                {
                    courses.Add(cr);
                }
            }

            return View(courses);
        }



        [HttpPost]
        public ActionResult Create(int[] courses)
        {


            if (courses.Length < 5)
            {
                TempData["msg"] = "null";
                return RedirectToAction("PreReg");
            }
            var db = new UMSTaskEntities1();
            foreach (var course in courses)
            {
                int count = db.CourseStudents.Where(temp => temp.CourseId == course && temp.Semester=="Fall").ToList().Count;
                if (count < 40)
                {
                    db.CourseStudents.Add(new CourseStudent()
                    {

                        CourseId = course,
                        StudentId = 1,
                        Semester="Fall"
                    });
                }

            }
            db.SaveChanges();
            return RedirectToAction("PreReg");
        }


    }
}
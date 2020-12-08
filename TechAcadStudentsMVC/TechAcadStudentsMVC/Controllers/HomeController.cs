﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor datTimeInstructor = new Instructor
            {
                ID = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(datTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    ID = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    ID = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"

                },
                new Instructor
                {
                    ID = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                },
            };
            
            return View(instructors);
        }
    }
}
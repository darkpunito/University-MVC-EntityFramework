using Project_mvc.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_mvc.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = GetStudents();
            return View(vm);
        }
        [HttpGet]
        public ActionResult About()
        {
            var vm = new Student();
            return View(vm);
        }
        [HttpPost]
        public ActionResult About(Student student)
        {
            if (ModelState.IsValid)
            {
                //ToDo
                //zapisz studenta
                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { ID =1, Email = "mail1", Name = "Bartosz", Surname = "Bereszyński" },
                new Student() { ID =2, Email = "mail2", Name = "Adrian", Surname = "Kowal" },
                new Student() { ID =3, Email = "mail3", Name = "Tomasz", Surname = "Krzysztofik" },
                new Student() { ID =4, Email = "mail4", Name = "Pawel", Surname = "Nowak" },
                new Student() { ID =5, Email = "mail5", Name = "Patryk", Surname = "Broda" },
            };
            return students;
        }

    }
}
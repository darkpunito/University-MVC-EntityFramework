using AutoMapper;
using Project_mvc.Service.ModelsDTO;
using Project_mvc.Service.Service;
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
        private IStudentService StudentService;
        public HomeController(IStudentService studentService)
        {
            StudentService = studentService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

    }
}
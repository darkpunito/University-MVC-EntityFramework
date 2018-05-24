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
    public class StudentController : Controller
    {
        private IStudentService StudentService;
        public StudentController(IStudentService studentService)
        {
            StudentService = studentService;
        }
        // GET: Student
        public ActionResult Index()
        {
            var vm = GetStudents();
            return View(vm);
        }
        public ActionResult Create()
        {
            var studentVM = new StudentViewModel()
            {
                Provinces = GetProvinces()
            };
            return View(studentVM);
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var studentDTO = Mapper.Map<StudentDTO>(model);
                StudentService.Insert(studentDTO);
                StudentService.Commit();
                return RedirectToAction("Index");
            }
            else
            {
                model.Provinces = GetProvinces();
                return View(model);
            }
        }
        private List<StudentViewModel> GetStudents()
        {
            List<StudentViewModel> students = new List<StudentViewModel>()
            {
                new StudentViewModel() { ID =1, Email = "mail1", Name = "Bartosz", Surname = "Bereszyński" },
                new StudentViewModel() { ID =2, Email = "mail2", Name = "Adrian", Surname = "Kowal" },
                new StudentViewModel() { ID =3, Email = "mail3", Name = "Tomasz", Surname = "Krzysztofik" },
                new StudentViewModel() { ID =4, Email = "mail4", Name = "Pawel", Surname = "Nowak" },
                new StudentViewModel() { ID =5, Email = "mail5", Name = "Patryk", Surname = "Broda" },
            };
            return students;
        }
        private IEnumerable<SelectListItem> GetProvinces()
        {
            var provinces = StudentService.GetProvinces()
                .Select(province => new SelectListItem()
                {
                    Value = province.ID.ToString(),
                    Text = province.Name
                });
            return provinces;
        }
    }
}

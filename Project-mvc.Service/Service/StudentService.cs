using Project_mvc.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_mvc.Service.Service
{   
    public interface IStudentService
    {
        void AddStudent();
    }
    public class StudentService : IStudentService
    {
        private StudentDBContext _context;
        public StudentService(StudentDBContext context)
        {
            _context = context;
        }

        public void AddStudent()
        {
            Student student = new Student()
            {
                Email = "EmailTest",
                Name = "TestStudent",
                Password = "TestPassword",
                Surname = "TestSurname"
            };
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}

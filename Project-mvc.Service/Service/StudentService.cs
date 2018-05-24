using AutoMapper;
using Project_mvc.Database;
using Project_mvc.Service.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_mvc.Service.Service
{
    public interface IStudentService
    {
        void Insert(StudentDTO student);
        StudentDTO FindById(int id);
        void Commit();
        IList<ProvinceDTO> GetProvinces();

    }
    public class StudentService : IStudentService
    {
        DatabaseContext _context;
        public StudentService(DatabaseContext context)
        {
            _context = context;
        }
        public void Insert(StudentDTO studentDTO)
        {
            var student = Mapper.Map<Student>(studentDTO);
            _context.Students.Add(student);
        }
        public StudentDTO FindById(int id)
        {
            var student = _context.Students.Where(x => x.id == id).FirstOrDefault();
            var studentDTO = new StudentDTO()
            {
                id = student.id
            };
            return studentDTO;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IList<ProvinceDTO> GetProvinces()
        {
            var provinces = _context.Provinces.OrderBy(x => x.Name).ToList();
            return Mapper.Map<IList<ProvinceDTO>>(provinces);
        }
    }
}

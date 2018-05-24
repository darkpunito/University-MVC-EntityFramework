using Project_mvc.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_mvc.Service
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("DefaultConnection") {}
        public DbSet<Student> Students { get; set; }
    }
}

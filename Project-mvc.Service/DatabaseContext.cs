using Project_mvc.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_mvc.Service
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("UniversityDbContext") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Province> Provinces { get; set; }

    }
}

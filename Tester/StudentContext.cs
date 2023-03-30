using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tester
{
    public class StudentContext :DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
        {
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ORBFC3M\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}

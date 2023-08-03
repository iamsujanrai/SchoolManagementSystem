using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domains.Models;

namespace StudentManagement.Infrastructure.SchoolContext
{
    public class SchoolDbContext : DbContext, ISchoolDbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
            
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}

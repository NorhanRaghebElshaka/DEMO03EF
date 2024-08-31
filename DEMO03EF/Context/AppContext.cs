using DEMO03EF.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.Context
{
    internal class AppContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfing());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());

            modelBuilder.Entity<StudentCourse>().HasKey(Sc => new { Sc.StudentId, Sc.CourseId });

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=.;Database=EFCore3;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}

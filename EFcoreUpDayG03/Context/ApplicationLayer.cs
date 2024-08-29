using EFcoreUpDayG03.Configuration;
using EFcoreUpDayG03.Entites;
//using Humanizer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreUpDayG03.Context
{
    internal class ApplicationLayer:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=.;Database=AppContextEFcoreDay03;Trusted_Connection=True;TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigure());
            modelBuilder.ApplyConfiguration(new DepartmentConfigure());
            //modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.CourseId, sc.StudentId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments {  get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}

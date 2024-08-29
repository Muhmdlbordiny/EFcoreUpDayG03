using Inheritance.cs.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.cs.Context
{
    internal class ApplicationLayer : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InheritanceG03;Trusted_Connection = True;TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///TPC
            ///modelBuilder.Entity<Employee>().ToTable("Employees");
            ///modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            ///modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            
            ///TPh
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            
            base.OnModelCreating(modelBuilder);
        }
       // public DbSet<Employee> Employees { get; set; }
       public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
       public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

    }
}

using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {
        // register models
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<DepartmentLocation> departmentLocations { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<WorksOn> worksOns { get; set; }
        public DbSet<Dependent> dependents { get; set; }

        // connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=Alqrsan\\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

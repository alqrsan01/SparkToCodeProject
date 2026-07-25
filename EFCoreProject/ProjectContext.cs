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
        public DbSet<Employee> employees;
        public DbSet<Department> departments;
        public DbSet<DepartmentLocation> departmentLocations;
        public DbSet<Project> projects;
        public DbSet<WorksOn> worksOns;
        public DbSet<Dependent> dependents;

        // connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=Alqrsan\\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertification=True;");
        }
    }
}

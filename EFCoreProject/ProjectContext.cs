using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {
        DbSet<Employee> employees;
        DbSet<Department> departments;
        DbSet<DepartmentLocation> departmentLocations;
        DbSet<Project> projects;
        DbSet<WorksOn> worksOns;
        DbSet<Dependent> dependents;
    }
}

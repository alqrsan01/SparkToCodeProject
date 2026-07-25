using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            // add data on table employee
            Employee e1 = new Employee();
            e1.Fname = "Hassan";
            e1.Minit = "A";
            e1.Lname = "Ambusaidi";
            e1.Ssn = 123456789;
            e1.Bdate = "2001-03-20";
            e1.Address = "Nizwa";
            e1.Sex = 'M';
            e1.Salary = 1000;
            e1.Super_ssn = 123456789;
            e1.DepartmentNumber = 1;
            
            context.employees.Add(e1);
            context.SaveChanges();

        }
    }
}

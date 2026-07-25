using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            // add data on table employee
            //Employee e1 = new Employee();
            //e1.Fname = "Hassan";
            //e1.Minit = "A";
            //e1.Lname = "Ambusaidi";
            //e1.Ssn = 123456789;
            //e1.Bdate = "2001-03-20";
            //e1.Address = "Nizwa";
            //e1.Sex = 'M';
            //e1.Salary = 1000;
            //e1.Super_ssn = 123456789;
            //e1.DepartmentNumber = 1;

            //context.employees.Add(e1);
            //context.SaveChanges();

            ///////////////////////////////////////////////////
            //Console.WriteLine("Register Employee");
            //Employee e1 = new Employee();
            //Console.Write("Enter First Name: ");
            //e1.Fname = Console.ReadLine();
            //Console.Write("Enter Minit: ");
            //e1.Minit = Console.ReadLine();
            //Console.Write("Enter Last Name: ");
            //e1.Lname = Console.ReadLine();
            //Console.Write("Enter SSN: ");
            //e1.Ssn = int.Parse(Console.ReadLine());
            //Console.Write("Enter Birth Date (YYYY-MM-DD): ");
            //e1.Bdate = Console.ReadLine();
            //Console.Write("Enter Address: ");
            //e1.Address = Console.ReadLine();
            //Console.Write("Enter Sex (M/F): ");
            //e1.Sex = char.Parse(Console.ReadLine());
            //Console.Write("Enter Salary: ");
            //e1.Salary = double.Parse(Console.ReadLine());
            //Console.Write("Enter Supervisor SSN: ");
            //e1.Super_ssn = int.Parse(Console.ReadLine());
            //Console.Write("Enter Department Number: ");
            //e1.DepartmentNumber = int.Parse(Console.ReadLine());

            //context.employees.Add(e1);
            //context.SaveChanges();
            /////////////////////////////////////////////////////////////////
            //Console.Write("Enter employee id to delete: ");
            //int employeeIdToDelete = int.Parse(Console.ReadLine());

            //Employee e1 = context.employees.FirstOrDefault(e => e.EmoloyeeId == employeeIdToDelete);
            //if (e1 == null)
            //{
            //    Console.WriteLine("Employee not found");
            //}
            //else
            //{
            //    context.employees.Remove(e1);
            //    context.SaveChanges();
            //    Console.WriteLine("Employee deleted successfully");
            //}
        }
    }
}

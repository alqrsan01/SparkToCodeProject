using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        [Key]
        public int EmoloyeeId { get; set; }
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public int Ssn { get; set; }
        public string Bdate { get; set; }
        public string Address { get; set; }
        public char Sex { get; set; }
        public int Super_ssn { get; set; }
        public int DepartmentNumber { get; set; }
        public double Salary { get; set; }

        // work on relation
        [ForeignKey("D")]
        public int DepartmentId { get; set; }
        public Department D { get; set; }

        // manage relation
        [InverseProperty("Employee")]
        public Department ManageDepartment { get; set; }

        // supervise
        [InverseProperty("Supervisor")]
        public List<Employee> Supervisors { get; set; }
        [ForeignKey("Supervisor")]
        public int supervisorId { get; set; }
        public Employee Supervisor { get; set; }
    }
}

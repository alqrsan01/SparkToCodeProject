using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}

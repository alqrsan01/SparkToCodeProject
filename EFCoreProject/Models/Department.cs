using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerSsn { get; set; }

        // work on relation
        [InverseProperty("D")]
        public List<Employee> Employees { get; set; }

        // manage relation
        [ForeignKey("Employee")]
        public int EmoloyeeId { get; set; }

        public Employee Employee { get; set; }

        // location relation
        public string ManagerStartDate { get; set; }
    }
}
